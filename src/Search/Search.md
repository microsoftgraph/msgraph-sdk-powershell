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

Revalidated on the normally merged `powershell-v3` target `08e409a6aa`
(operation-variant support). The shared file contains only the placeholder
above: there are no cmdlet suppression/rename directives, parameter
aliases/transforms, or schema/response directives to migrate or defer.
The AutoRest requirement and placeholder remain unchanged.

`wrapper/Search_directiveMigrationMap.json` records an empty `mappings` array.
There is no original selector or legacy match set to bridge; neither aligned
operation IDs nor metadata absence are used to invent a directive mapping.
All profile-local directive files and `src/readme.graph.md` are ignored and
unchanged. Parameter/schema directives remain outside the cmdlet-only scope.

Both profiles are required and neither is excluded. Current committed inputs:

| Profile | Specification | Git blob | Operations |
| --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/Search.yml` | `10bfa3ec66104d39da29c39eeeeb01154a2ff4ca` | 63 |
| beta | `openApiDocs_KiotaCompat/beta/Search.yml` | `7bf19d7a55f303509ef23bd89b0bc75ea60cb604` | 145 |
| v1.0 | `openApiDocs/v1.0/Search.yml` (lineage only) | `874ec28befe8da54ca689ce4df6cd32204fe83e8` | N/A |
| beta | `openApiDocs/beta/Search.yml` (lineage only) | `abdbd822db5d44f2e0713f7f3b517c3d51b7b8b9` | N/A |

Generation uses compatible specifications only, without legacy fallback.

#### Evidence-backed collision repairs

The initial beta generation failed on three IndustryData name collisions.
These are not shared-directive mappings. The current module configuration has
only two exact, shared GET noun entries; it has no profile-scoped rules,
operation groups, selector parameters, capability flags, or suppressions.

| Method and compatible path | Operation ID | Result |
| --- | --- | --- |
| GET `/external/industryData/runs/{industryDataRun-id}/microsoft.graph.industryData.getStatistics()` | `external.industryData.run.industryDataRun_getStatistics` | `Get-MgExternalIndustryDataRunStatistics` |
| GET `/external/industryData/runs/microsoft.graph.industryData.getStatistics()` | `external.industryData.run_getStatistics` | Existing structural `Get-MgExternalIndustryDataRunGetStatistics`, no rename |
| GET `/external/industryData/runs/{industryDataRun-id}/activities` | `external.industryData.run_ListActivity` | Ordinary `Get-MgExternalIndustryDataRunActivity`, default List |
| GET `/external/industryData/runs/{industryDataRun-id}/activities/{industryDataRunActivity-id}` | `external.industryData.run_GetActivity` | Same ordinary command, Get selected by activity ID |
| GET `/external/industryData/runs/{industryDataRun-id}/activities/{industryDataRunActivity-id}/activity` | `external.industryData.run.activity_GetActivity` | `Get-MgExternalIndustryDataRunActivityFlow` |

The item function's source description is "Get statistics for an industryDataRun."
Its Statistics noun also matches the published
[command](https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/get-mgbetaexternalindustrydatarunstatistics?view=graph-powershell-beta).
The collection-bound function keeps its structural name and zero-ID binding;
neither function is forced into an unsupported group or assigned aggregate
semantics absent from the source.

The nested navigation's exact description is "The flow that was run by this
activity." It returns `microsoft.graph.industryData.industryDataActivity`, not
the list/item `microsoft.graph.industryData.industryDataRunActivity`. Both item
GETs require the same run/activity IDs. The distinguishing Flow noun follows
that description instead of adding a selector or grouping incompatible results.
All five endpoints survive; ordinary List defaults and neighboring routes stay
unchanged. Kiota retains ownership of response-union deserialization.

#### Validation and limitations

`SearchDirectiveMigrationTests` reads both complete real compatible specs,
pins exact method/path/operation-ID evidence, verifies no operations are
suppressed, and generates the complete command surface into isolated temporary
directories. Tests exercise derived data both enabled and disabled, passing
the runtime API profile separately to the generation service, naming, noun,
verb and suppression callers. They cover the repairs, connection CRUD/item PUT,
schema GET/PATCH, bookmark List/Get, query action and beta quota neighbors.

The strict command is
`tools/Get-WrapperDirectiveMigrationInventory.ps1 -Module Search -FailOnUnresolved`;
success returns zero rows. No unmerged source-translation helper is needed for
this empty shared-directive inventory.

Full generation and Release compilation are separate required gates for each
profile through the shared queue, using Kiota `1.36.1` (model parallelism 1)
and the complete official Authentication `2.38.1`. Historical pre-integration
builds are not current-target validation. Fresh compiled full-module checks
must verify exports, exact repaired and neighboring routes, List/Get defaults,
mandatory IDs and actual stub-HTTP requests without a tenant connection.

Raw oracle parity is reported unchanged, without normalizing the beta command
prefix or hiding unmatched/client-only operations. The qualified external-item
`addActivities` action and beta structural search-query name are existing
baseline naming differences, not migrations of ignored profile-local directives.
