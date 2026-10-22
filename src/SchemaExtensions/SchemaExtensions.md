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
| v1.0 | `openApiDocs_KiotaCompat/v1.0/SchemaExtensions.yml` | `baa25f45d8054433fec5ebb2612ed502b9203ba3` | `wrapper/v1.0` |
| beta | `openApiDocs_KiotaCompat/beta/SchemaExtensions.yml` | `8c603326a663de5210e85034d6850d99590ee2bd` | `wrapper/Beta` |

Each spec contains the following six operations. These are unaffected-route
evidence, not directive mappings:

| Method | Path | Operation ID |
| --- | --- | --- |
| GET | `/schemaExtensions` | `schemaExtensions.schemaExtension.ListSchemaExtension` |
| POST | `/schemaExtensions` | `schemaExtensions.schemaExtension.CreateSchemaExtension` |
| GET | `/schemaExtensions/{schemaExtension-id}` | `schemaExtensions.schemaExtension.GetSchemaExtension` |
| PATCH | `/schemaExtensions/{schemaExtension-id}` | `schemaExtensions.schemaExtension.UpdateSchemaExtension` |
| DELETE | `/schemaExtensions/{schemaExtension-id}` | `schemaExtensions.schemaExtension.DeleteSchemaExtension` |
| GET | `/schemaExtensions/$count` | `schemaExtensions.GetCount-e324` |

`SchemaExtensionsDirectiveMigrationTests` reads both compatible specs and pins
these operation identities and all seven emitted cmdlets, including the
collection/item workers and count route. This preserves the existing surface
without adding suppression or rename rules for nonexistent shared directives.
