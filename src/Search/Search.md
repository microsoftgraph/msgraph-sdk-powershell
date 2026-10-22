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

#### Queued Release pipeline evidence

Both profiles were subsequently attempted, sequentially, through the
coordinator's shared four-slot queue using Kiota
`1.36.1+fd3bf87790149b87f40f7eae1a5feb9016625943` and an unmodified official
Authentication `2.38.1` module in the prescribed process-local environment.
Each invocation ran the complete existing builder with compatible specifications
and no skip flags.

| Profile | Actual pipeline outcome | Compiled exports |
| --- | --- | --- |
| v1.0 | Exit 0, module status `OK`, Release manifest imports successfully | 72 |
| beta | Exit 1, module status `FAILED` at `wrapper-generator`, same three collisions above | Not compiled |

The v1.0 regeneration changes only `Client/kiota-lock.json` from Kiota `1.34.1`
to `1.36.1`; generated client sources, cmdlets, projects and the cmdlet lock
remain byte-identical after Git line-ending normalization. Compiled parity
reports 62 of 63 route-bearing cmdlets matching, plus nine dispatchers; the
existing qualified `addActivities` action still differs from its published
`Add-MgExternalConnectionItemActivity` name. This audit does not change that
unrelated baseline behavior. The builder removed its incomplete beta output
after the failed attempt; neither beta compilation nor an export count is claimed.

Published parameter-set evidence confirms that the beta collisions cannot be
fixed by inventing distinct public nouns or suppressing routes missing from
metadata. The published
[Statistics command](https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/get-mgbetaexternalindustrydatarunstatistics?view=graph-powershell-beta)
has a default `Get1` set without a run ID and a `Get` set requiring
`IndustryDataRunId`, corresponding to the collection and item functions.
The published
[Activity command](https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/get-mgbetaexternalindustrydatarunactivity?view=graph-powershell-beta)
defaults to `List` with `IndustryDataRunId`; both `Get` and `Get1` require
`IndustryDataRunId` and `IndustryDataRunActivityId`. Its compatible item and
nested `activity` routes have identical ID requirements and optional
`$select`/`$expand` queries, but return different schemas:
`microsoft.graph.industryData.industryDataRunActivity` and
`microsoft.graph.industryData.industryDataActivity`. Preserving all routes
therefore requires a separately reviewed shared dispatch capability and an
explicit selection policy, not a module-local suppression or guessed rename.
