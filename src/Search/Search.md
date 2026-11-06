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

The original audit used `powershell-v3` target `08e409a6aa`; final revalidation
uses normally merged target `6475f3f5be` (PATCH result contract). The shared file contains only the placeholder
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
and the normally packaged adapted Authentication `2.41.2`. The original `08e409a6aa`
run used official Authentication `2.38.1`. Historical pre-integration
builds are not current-target validation. Fresh compiled full-module checks
must verify exports, exact repaired and neighboring routes, List/Get defaults,
mandatory IDs and actual stub-HTTP requests without a tenant connection.

Raw oracle parity is reported unchanged, without normalizing the beta command
prefix or hiding unmatched/client-only operations. The qualified external-item
`addActivities` action and beta structural search-query name are existing
baseline naming differences, not migrations of ignored profile-local directives.

Historical `08e409a6aa` results after the two final shared naming entries:

| Gate | v1.0 | beta |
| --- | --- | --- |
| Full queued compatible-spec Release build | Exit 0, `OK`, 17.40 seconds | Exit 0, `OK`, 30.50 seconds |
| Fresh full-module exports | 72 | 166 |
| `tools/Test-SearchDirectiveMigration.ps1 -ApiVersion <profile>` | 34 assertions, 5 stub-HTTP requests | 76 assertions, 10 stub-HTTP requests |
| Exact distinct compiled operations | All 63; zero client-only | All 145; zero client-only |
| Raw `Compare-WrapperCmdletNames.ps1` | Exit 1: 71 matched, 1 mismatch | Exit 1: 164 mismatches, 2 no-oracle |

The compiled gate exercises the real complete module with original Authentication
`2.38.1`. It verifies both function requests and Kiota results, List/Get inference,
the distinct flow model, mandatory-ID/unknown-selector binder rejection before
transport, unaffected neighbors, and the existing update neighbor's WhatIf gate.
It is a deterministic HTTP-stub test, not live tenant/service validation or proof
of mutation serialization. No mutation variants are introduced.

`dotnet test tools/WrapperGenerator.Tests/WrapperGenerator.Tests.csproj --no-restore
--filter 'FullyQualifiedName~SearchDirectiveMigrationTests|FullyQualifiedName~CmdletConfiguratorTests|FullyQualifiedName~NamingTests'`
passes 94 tests, including both complete specs with derived data on/off.
The strict Search inventory passes with zero rows and an empty ledger.
Beta's two no-oracle routes are the retained collection-bound statistics function
and nested activity flow. Missing published URI records do not remove either
endpoint. No beta prefix normalization or broad naming correction is applied.

#### Historical normal Authentication refresh at `844672d7c2`

The existing branch normally merges `powershell-v3` including Authentication
change #3891. The shared directives, exact naming entries, complete route
selection and frozen parity limitations above are unchanged. Historical
Authentication `2.38.1` results are not evidence for this target.

Fresh full generation uses the unchanged four-mutex queue, v1.0 then beta,
isolated Kiota `1.36.1` with parallelism 1, and the normally packaged adapted
Authentication `2.41.2` from the exact merged shipping source. All 64 package
file SHA256s match its producer manifest; the Authentication nupkg SHA256 is
`2FC09BFE6B70D313BC56DF8ADCCFB1976FB4E90A1898BF8A916B4B8B792898EB`.
No gallery substitution, dependency injection, global environment edit,
unmerged overlay, or authored naming/schema expansion is used.

| Historical gate | v1.0 | beta |
| --- | --- | --- |
| Full queued Release generation | Exit 0, `OK`, 35.20 seconds | Exit 0, `OK`, 59.00 seconds |
| Fresh normal-manifest exports | 72 | 166 |
| Distinct compiled compatible operations | All 63; zero client-only | All 145; zero client-only |
| Global offline factory checks | 137 assertions, 16 HTTP requests, 4 declined prompts | 196 assertions, 22 HTTP requests, 5 declined prompts |
| USGov offline factory checks | Same counts as Global | Same counts as Global |
| Complete runtime gate outcome, each cloud | **Exit 1: generic-header refetch failure** | **Exit 1: generic-header refetch failure** |

`Test-SearchDirectiveMigration.ps1 -ApiVersion <profile> -Environment <Global|USGov>
-OutputPath <artifact.json>` imports the normal module manifest (Authentication
minimum `2.41.2`, no dependency preloads). Each bin contains exactly its own
wrapper, typed client and runtime DLLs. Real `Connect-MgGraph`, the existing
in-memory MockDataStore, and the actual `GraphHttpClientFactory` token pipeline
terminate in an offline handler. The factory's original global `/v1.0/`
BaseAddress is retained: generated beta calls actually send `/beta`, and USGov
calls retain `graph.microsoft.us`. Alternating profiles, cache reuse,
request-context invalidation, reconnect and disconnected zero-HTTP behavior
pass without changing the shared HttpClient BaseAddress.

Every loaded Authentication/Kiota/RMS/UriTemplate identity is unique and comes
from the adapted Authentication package in its expected load context. Typed
connection POST/PATCH bodies/results, search-action nested JSON, bodyless DELETE,
the beta bodyless start action, WhatIf, real declined Confirm and invalid binder
zero-HTTP checks pass. The original migration still introduces no mutations or
operation groups. No live OAuth, Graph or credentials store is used.

The expanded test deliberately retains an actual normal-target failure:
`Update-MgExternalConnection -Headers @{ 'x-search-marker' = 'bound-mutation' }`
sends the header on PATCH, but its selected-route 204 follow-up GET drops it.
Both clouds and profiles reproduce #3886, so **all-runtime PASS is not claimed**.
The typed body, selected GET URL and typed result succeed; no unmerged fix is
copied in or the header assertion suppressed. This module has no reference-delete
route or migrated required-DELETE-query surface requiring #3882.

The combined Search/configurator/naming command above passes 94/94 with a
nonzero TRX on the new target, and ordinary strict Search inventory still passes
zero rows/empty mappings. Raw current parity remains exit 1: v1.0 71 matched/1
mismatch; beta 164 mismatches/2 no-oracle, without prefix normalization.
Detailed new logs, TRX, captures, hash manifests and failed-attempt diagnostics
are retained separately under the session's `search-844672-revalidation` evidence
folder; earlier target evidence is untouched. That refresh retained the
header-loss runtime blocker rather than certifying it green.

#### Final PATCH contract on normal target `6475f3f5be`

The subsequent user-directed #3886 change supersedes automatic PATCH readback.
A successful 204 PATCH now returns no object and issues exactly one PATCH,
without a GET even if reading the resource would return 403. A 200 PATCH returns
the actual typed response from that single operation. Callers explicitly invoke
the ordinary GET command if desired; GET owns its own query/header inputs,
result and error. No PassThru, ReadBack, Refetch or other option is added.

The coupled Search acceptance probe now asserts both positive PATCH outcomes.
Its terminal handler rejects any hidden GET during each PATCH. Separate
caller-directed GETs prove independent native `$select`, bound generic headers,
typed results and a 403 error without replaying the mutation. This replaces the
old implicit-GET expectation; historical failed captures remain unchanged.
The probe also retains normal Auth ownership, real factory Global/USGov
profile/cache/identity checks, typed POST/PUT/search-action JSON, bodyless DELETE
and beta start action, real declined Confirm/WhatIf zero-HTTP gates and binder
rejections. All 63/145 routes, the two exact noun repairs, empty directive
ledger, ordinary List defaults and raw oracle limitations remain unchanged.
The real Search specifications have no mandatory query operations; synthetic
required-query tests are included in the targeted selection without inventing
new module queries or reference-delete routes.

Final evidence is kept separately in `post3886-6475-final`, using the same
four-mutex full build queue, isolated Kiota `1.36.1`/parallelism 1 and exact
physical adapted Auth `2.41.2` package whose 64 hashes and nupkg SHA match above.
No unmerged #3881 fix, optional-query expansion or other-owner changes are
included. This is offline behavior proof, not tenant/service certification.
