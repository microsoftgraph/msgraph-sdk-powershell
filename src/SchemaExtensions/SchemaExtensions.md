# SchemaExtensions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for SchemaExtensions v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!
```

### Shared directive migration audit

Only this shared module file is in scope. Its directive block is empty: there
are no cmdlet suppressions or renames to migrate, and no parameter aliases,
parameter transforms, or schema/response directives to defer. The
`require` above remains unchanged; directives in `src/readme.graph.md` and
profile-specific `readme.md` files are explicitly excluded from this audit.
No claim is made that those excluded directives have been migrated.

`wrapper/SchemaExtensions_cmdletConfigurations.cs` remains empty intentionally.
`wrapper/SchemaExtensions_directiveMigrationMap.json` records no mappings, since
there are no shared selectors to resolve. Structural naming already supplies
the SchemaExtension CRUD and count names; no synthetic overrides are needed.

Both currently compatible profiles are required; none is excluded:

| Profile | Compatible spec | Git blob | Existing output directory |
| --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/SchemaExtensions.yml` | `121c9a107ef31504c720af9f088c2b7bc685a707` | `wrapper/v1.0` |
| beta | `openApiDocs_KiotaCompat/beta/SchemaExtensions.yml` | `a0b0746ade2a173cb4e3aecdd2b299d96b63b39b` | `wrapper/Beta` |

Each spec contains the following six operations. These are unaffected-route
evidence, not directive mappings:

| Method | Path | Operation ID |
| --- | --- | --- |
| GET | `/schemaExtensions` | `schemaExtension_ListSchemaExtension` |
| POST | `/schemaExtensions` | `schemaExtension_CreateSchemaExtension` |
| GET | `/schemaExtensions/{schemaExtension-id}` | `schemaExtension_GetSchemaExtension` |
| PATCH | `/schemaExtensions/{schemaExtension-id}` | `schemaExtension_UpdateSchemaExtension` |
| DELETE | `/schemaExtensions/{schemaExtension-id}` | `schemaExtension_DeleteSchemaExtension` |
| GET | `/schemaExtensions/$count` | `schemaExtension_GetCount` |

These are the current compatible IDs after operation-ID alignment in the target
branch. The original audit used `schemaExtensions.schemaExtension.<operation>`
for CRUD and `schemaExtensions.GetCount-e324` for count; the HTTP methods and paths
above are unchanged. No shared source selector existed before or after alignment.

`SchemaExtensionsDirectiveMigrationTests` reads both compatible specs and pins
these operation identities and all seven emitted cmdlets, including the
collection/item workers and count route. Both profiles run with derived data
enabled and disabled, passing the profile separately to the generation, naming,
and suppression APIs. Exact method/path metadata is checked on each emitted
worker. This preserves the existing surface without adding suppression or rename
rules for nonexistent shared directives.
