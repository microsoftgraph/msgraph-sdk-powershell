# Security

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Security v1.0 and/or beta modules.

## Wrapper migration audit

Only the six shared cmdlet directives below are in scope. Global and profile-local
directives are ignored; parameter aliases/transforms and schema directives remain
deferred. Both v1.0 and beta are required; neither profile is excluded.

The original operation-ID selector matches six legacy v1.0 and seven legacy beta
operations. Every selected method/path survives. Normal operation-ID alignment
in #3847 makes the complete compatible selected sets equal to the original
same-profile source sets: six v1.0 and seven beta exact method/path/ID triples.
The ledger uses ordinary literal evidence in both profiles, including the
surviving beta `aggregatedAppsDetails` function. Historical source-bridge proofs
remain separate audit evidence; no rejected Legacy integration metadata is needed.

Full beta generation also exposes six collection/item action collisions and seven
count collisions. Collection actions have an `ids` body whereas item actions are
bodyless, so compatible natural-ID grouping is inappropriate. Shared exact noun
overrides append `Multiple` to the collection action names. Count alternatives use
`ByArticle`, `ByHost`, or `AcrossHost` according to their actual URL scope, leaving
the published count name on its existing route. No selectors, authored profile
filters, response-union restrictions, or new suppressions resolve these collisions.
Existing v1.0 derived suppressions and curated child-navigation behavior remain
unchanged. No mutation variant groups are introduced.

The normally merged Authentication 2.41.2 package owns the complete Kiota
dependency closure. Wrapper bins contain only their module, client, and runtime
assemblies, without dependency copies or preloads. Final validation uses fresh
compiled module imports, exact migrated and neighboring routes, typed mutation
serialization and request URLs, scalar count results and queries, mandatory-ID
binding, and `WhatIf`/declined-confirmation safety. Offline transport proof is not
a claim of live service validity.

After the merged PATCH operation update, a 204 response succeeds without output
or implicit GET; a 200 response returns the PATCH's own typed model. Explicit
reads remain separate calls with independent query inputs, headers, results,
and permissions. The actual Security specs have no required query parameters
and no native PATCH query parameters; GET-only inputs are not added to PATCH.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration: directive 1 bridges the COMPLETE original legacy operation-ID
# match set (6 v1.0, 7 beta) to exact surviving method/path pairs. The adjacent
# wrapper/Security_directiveMigrationMap.json records current IDs and source lineage.
# All IDs align after normal #3847; ordinary literal evidence covers the full
# same-profile source sets. The function is not absent and is not dropped.
# The existing attackSimulation container suppression is reused; nested dataSource operations
# and the beta aggregatedAppsDetails function have exact scoped suppressions.
# Keep all shared AutoRest directives active until that pipeline is retired.
  - remove-path-by-operation: ^security(.case.ediscoveryCase.noncustodialDataSource_.*DataSource)$|^security_DeleteAttackSimulation$|^security_UpdateAttackSimulation$|^security_GetAttackSimulation$|^security.dataDiscovery.cloudAppDiscovery.uploadedStream_aggregatedAppsDetail$
# Remove cmdlets
# Wrapper migration: directive 2 suppresses only GET/PATCH /security in both
# profiles; v1.0 already has derived coverage, beta needs the shared configuration.
  - where:
      verb: Get|Update
      subject: ^Security$
    remove: true
# Wrapper migration: directive 3 is already covered by the exact existing
# attackSimulation container entry. Do not add a redundant override.
  - where:
      verb: Update
      subject: ^SecurityAttackSimulation$
    remove: true
# Rename cmdlets
# Wrapper migration: directive 4 selected the published beta bulk-delete action
# (Delete1/DeleteExpanded), not item DELETE. Its actual legacy route is removed
# from the compatible beta spec; v1.0 has neither the legacy action nor a successor.
# Reviewed absence is recorded without inventing a replacement or suppressing items.
  - where:
      verb: Remove
      subject: ^(SecurityTiIndicator)$
      variant: Delete1|^DeleteExpanded$
    set:
      subject: $1Multiple
# Wrapper migration: directive 5 selected the published beta updateAlerts and
# updateTiIndicators actions (Update1/UpdateExpanded1), not item PATCH. Both actual
# legacy routes are removed from compatible beta; neither existed in legacy v1.0.
  - where:
      verb: Update
      subject: ^(SecurityAlert|SecurityTiIndicator)$
      variant: Update1|UpdateExpanded1
    set:
      subject: $1Multiple
# Wrapper migration: directive 6 is structural naming of GET /security/alerts_v2/$count
# in both compatible profiles. No rename override is necessary. Module-specific
# SecurityDirectiveMigrationTests pin all dispositions and unaffected neighbors.
  - where:
      verb: Get
      subject: ^(SecurityAlert)$
      variant: Get1
    set:
      subject: $1V2Count
```
