# Quicktype Help Documentation

## General Options

- `-o, --out FILE` - The output file. Determines `--lang` and `--top-level`.
- `-t, --top-level NAME` - The name for the top-level type.
- `-l, --lang LANG` - The target language.
- `-s, --src-lang SRC_LANG` - The source language (default is JSON).
- `--src FILE|URL|DIRECTORY` - The file, URL, or data directory to type.
- `--src-urls FILE` - Tracery grammar describing URLs to crawl.
- `--no-maps` - Don't infer maps, always use classes.
- `--no-enums` - Don't infer enums, always use strings.
- `--no-uuids` - Don't convert UUIDs to UUID objects.
- `--no-date-times` - Don't infer dates or times.
- `--no-integer-strings` - Don't convert stringified integers to integers.
- `--no-boolean-strings` - Don't convert stringified booleans to booleans.
- `--no-combine-classes` - Don't combine similar classes.
- `--no-ignore-json-refs` - Treat `$ref` as a reference in JSON.
- `--graphql-schema FILE` - GraphQL introspection file.
- `--graphql-introspect URL` - Introspect GraphQL schema from a server.
- `--http-method METHOD` - HTTP method to use for the GraphQL introspection query.
- `--http-header HEADER` - Headers to attach to all HTTP requests, including the GraphQL introspection query.
- `-S, --additional-schema FILE` - Register the `$id`'s of additional JSON Schema files.
- `--alphabetize-properties` - Alphabetize the order of class properties.
- `--all-properties-optional` - Make all class properties optional.
- `--quiet` - Don't show issues in the generated code.
- `--debug OPTIONS or all` - Comma-separated debug options: print-graph, print-reconstitution, print-gather-names, print-transformations, print-schema-resolving, print-times, provenance
- `--telemetry enable|disable` - Enable anonymous telemetry to help improve quicktype
- `-h, --help` - Get some help.
- `-v, --version` - Display the version of quicktype.

## Options for C#

- `--framework NewtonSoft|SystemTextJson` - Serialization framework.
- `--namespace NAME` - Generated namespace.
- `--csharp-version 5|6` - C# version.
- `--density normal|dense` - Property density.
- `--array-type array|list` - Use `T[]` or `List<T>`.
- `--number-type double|decimal` - Type to use for numbers.
- `--any-type object|dynamic` - Type to use for "any".
- `--[no-]virtual` - Generate virtual properties (off by default).
- `--features complete|attributes-only|just-types-and-namespace|just-types` - Output features.
- `--base-class EntityData|Object` - Base class.
- `--[no-]check-required` - Fail if required properties are missing (off by default).

## Options for TypeScript

- `--[no-]just-types` - Interfaces only (off by default).
- `--[no-]nice-property-names` - Transform property names to be JavaScripty (off by default).
- `--[no-]explicit-unions` - Explicitly name unions (off by default).
- `--[no-]runtime-typecheck` - Verify `JSON.parse` results at runtime (on by default).
- `--[no-]runtime-typecheck-ignore-unknown-properties` - Ignore unknown properties when verifying at runtime (off by default).
- `--acronym-style original|pascal|camel|lowerCase` - Acronym naming style.
- `--converters top-level|all-objects` - Which converters to generate (top-level by default).
- `--raw-type json|any` - Type of raw input (json by default).
- `--[no-]prefer-unions` - Use union type instead of enum (off by default).
- `--[no-]prefer-types` - Use types instead of interfaces (off by default).
- `--[no-]prefer-const-values` - Use string instead of enum for string enums with a single value (off by default).
