#!/bin/bash

# Define the input directory for JSON Schema files
JSON_SCHEMA_DIR="../json-schemas/models"

# Define the output directories for TypeScript and C# models
TYPESCRIPT_OUTPUT_DIR="../typescript-models/src"
CSHARP_OUTPUT_DIR="../csharp-models/Nimbus.DataModels/Nimbus.DataModels/Models"

# Define the base namespace for C# models
CSHARP_NAMESPACE_BASE="Nimbus.DataModels.Models"

# Ensure the output directories exist
mkdir -p "$TYPESCRIPT_OUTPUT_DIR"
mkdir -p "$CSHARP_OUTPUT_DIR"

# Find all subdirectories in BASE_DIR and loop through them
for SUBDIR_FULL_PATH in "$JSON_SCHEMA_DIR"/*/; do
    # Remove the trailing slash to get the clean directory path
    SUBDIR_FULL_PATH="${SUBDIR_FULL_PATH%/}"

    echo $SUBDIR_FULL_PATH

    # Use 'basename' to extract the name of the subdirectory
    SUBDIR_NAME=$(basename "$SUBDIR_FULL_PATH")
    
    # Check if the subdirectory contains any .json files
    if [ -z "$(find "$SUBDIR_FULL_PATH" -maxdepth 1 -type f -name '*.json')" ]; then
        echo "No JSON files found in $SUBDIR_NAME, skipping..."
        continue
    fi

    echo "Processing $SUBDIR_NAME"

    mkdir -p "$CSHARP_OUTPUT_DIR/$SUBDIR_NAME"
    mkdir -p "$TYPESCRIPT_OUTPUT_DIR/$SUBDIR_NAME"
    
    # Loop through all .json files in the JSON schema directory
    for JSON_FILE in "$SUBDIR_FULL_PATH"/*.json; do
        # Extract the base filename without the extension
        MODEL_NAME=$(basename "$JSON_FILE" .json)

        # Generate TypeScript models with just types
        quicktype "$JSON_FILE" -l ts --just-types -o "$TYPESCRIPT_OUTPUT_DIR/$SUBDIR_NAME/$MODEL_NAME.ts" -s schema --no-combine-classes

        # Define the C# namespace for this model
        CSHARP_NAMESPACE="$CSHARP_NAMESPACE_BASE.$SUBDIR_NAME"

        # Generate C# models with just types
        quicktype "$JSON_FILE" -l csharp --namespace "$CSHARP_NAMESPACE" -o "$CSHARP_OUTPUT_DIR/$SUBDIR_NAME/$MODEL_NAME.cs" --array-type "list" --features "attributes-only" -s schema --no-combine-classes

        # Apply sed commands to the generated C# model file
        sed -i -e 's/using Newtonsoft.Json;/using MongoDB.Bson;/g' \
            -e 's/using Newtonsoft.Json.Converters;/using MongoDB.Bson.Serialization.Attributes;/g' \
            -e 's/, NullValueHandling = NullValueHandling.Ignore//g' \
            -e 's/\[JsonProperty(\(.*\))\]/\[BsonElement(\1)\]/g' \
            -e '/\[BsonElement("_id")\]/{n;s/public string/public ObjectId/;}' \
            "$CSHARP_OUTPUT_DIR/$SUBDIR_NAME/$MODEL_NAME.cs"
    done
done

# Output message indicating completion
echo "Model generation complete."
