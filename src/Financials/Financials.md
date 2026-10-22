# Financials

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Financials v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

### Wrapper migration audit

The shared source below contains no cmdlet suppressions or renames and no deferred
parameter aliases/transforms or schema/response directives. The empty
`wrapper/Financials_directiveMigrationMap.json` ledger records that review; the
existing empty `Financials_cmdletConfigurations.cs` needs no overrides.

Only `openApiDocs_KiotaCompat/beta/Financials.yml` is compatible with this migration.
v1.0 is excluded because it has no compatible specification; the legacy OpenAPI
directory is not a fallback. `src/readme.graph.md` and all profile-local readme
directives are explicitly outside this audit and remain unchanged.

`FinancialsDirectiveMigrationTests` pins real beta operation identities,
unaffected naming/suppression behavior, and representative emitted routes. These
targeted tests do not establish full Kiota generation, module build, or nonzero
compiled exports; those remain a separate beta generation gate.

``` yaml
# Directives go here!
```
