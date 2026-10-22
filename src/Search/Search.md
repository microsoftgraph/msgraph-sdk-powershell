# Search

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Search v1.0 and/or beta modules.

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

### v3 shared-directive migration audit

Reviewed against `powershell-v3` commit `51d441eeb5`. The shared file contains
only the placeholder above: there are no cmdlet suppression/rename directives,
parameter aliases/transforms, or schema/response directives to migrate or defer.
The existing AutoRest requirement and placeholder remain unchanged.

`wrapper/Search_directiveMigrationMap.json` therefore records an empty
`mappings` array, not invented operation mappings. The existing
`SearchCmdletConfigurations` collection remains empty; no redundant curated
override is needed. Structural naming and existing derived parity/collision
data retain their current behavior.

Both required profiles have compatible specifications; neither is excluded.
The reviewed Git blob identities below match the coordinator manifest:

| Profile | Compatible specification | Git blob | Operations |
| --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/Search.yml` | `20180fd6e2c71f9f2bc5e476dc6fbe2fb45f19e5` | 63 |
| beta | `openApiDocs_KiotaCompat/beta/Search.yml` | `a655b02e3c874bf6a4c07a9922201f781590b5a5` | 145 |

`SearchDirectiveMigrationTests` reads those real compatible specifications,
checks exact HTTP method/path/operation-ID evidence, verifies that their
operations remain unsuppressed, and exercises cmdlet emission for a reviewed
path subset in temporary directories using the original operations and schemas.
Coverage includes connection list/item CRUD, external item PUT,
schema GET/PATCH, bookmark list/item GET, and the search query action. The
existing v1.0 query parity name (`Invoke-MgQuerySearch`) and beta structural
name (`Invoke-MgSearchQuery`) are intentionally preserved rather than reconciled
with ignored profile-local directives. Beta quota GET/PATCH/DELETE are also
covered; the quota path is absent from the v1.0 compatible specification.

Scope is exclusively this shared file. All profile-local directive files and
`src/readme.graph.md` are ignored and unchanged. Parameter aliases/transforms
and schema/response directives remain outside this cmdlet-only migration;
none are present here. No legacy specification fallback is permitted.

The strict inventory command is
`tools/Get-WrapperDirectiveMigrationInventory.ps1 -Module Search -FailOnUnresolved`;
a successful audit returns zero directive rows. This audit and its isolated
generator tests do not establish Kiota generation, Release compilation, or
compiled exports. Those remain separate gates for both profiles, including
creation of the initially absent beta wrapper output.

A full-spec isolated generator probe on this audit base passed for v1.0 but
reported three existing beta IndustryData collisions: collection and item
`runs/.../microsoft.graph.industryData.getStatistics` operations both produce
`Get-MgExternalIndustryDataRunGetStatistics`, while `runs/{industryDataRun-id}/activities`,
its item, and the nested item `activity` navigation all produce
`Get-MgExternalIndustryDataRunActivity`. These are not shared-directive migration
mappings. No suppressions or renames are invented to hide them; full beta
generation remains blocked pending a separately reviewed resolution.
