# Nimbus Data Models

![.NET 6.0](https://img.shields.io/badge/.NET-6.0-blueviolet) ![TypeScript](https://img.shields.io/badge/TypeScript-3178C6.svg?&logo=typescript&logoColor=white) ![JSON](https://img.shields.io/badge/JSON-%20Schema-lightgrey)

## Overview

The `nimbus.datamodels` repository serves as the single source of truth for data object models used across the Nimbus project. It contains JSON schema files defining the structure of data objects, alongside scripts that leverage [Quicktype](https://quicktype.io/) to dynamically generate corresponding C# and TypeScript models.

This approach ensures model consistency between the backend (API and server-side data loader application) and the frontend (React/TypeScript application), eliminating the discrepancies that often arise from manual edits by different teams.

## Repository Structure

- `json-schemas/`: Contains JSON schema files representing data objects.
- `scripts/`: Includes automation scripts for model generation.
- `csharp-models/`: Stores the generated C# models used by backend services.
- `typescript-models/`: Stores the generated TypeScript models used by the frontend application.

## Quicktype Model Generation

Quicktype is used to convert JSON schemas into C# and TypeScript models. The automated script runs Quicktype against the JSON schema files, ensuring that any updates to the schemas are directly and accurately reflected in the respective models.

## Usage

To generate models, navigate to the `scripts/` directory and execute the model generation script:

```bash
./quicktype-generate.sh
```

This will update the models in the `csharp-models/` and `typescript-models/` directories based on the current JSON schemas.

## License

This project is licensed under the [MIT License](LICENSE).
