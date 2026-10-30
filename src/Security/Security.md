# Security

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Security v1.0 and/or beta modules.

## Wrapper migration audit

Only the six shared cmdlet directives below are in scope. Global and profile-local
directives are ignored; parameter aliases/transforms and schema directives remain
deferred. Both v1.0 and beta are required; neither profile is excluded.

The original operation-ID selector matches six legacy v1.0 and seven legacy beta
operations. Every selected method/path survives. Six IDs now align with the
compatible specification; the beta `aggregatedAppsDetails` function still has a
different ID. Its exact source/current pair is retained in the ledger notes and
tests. The literal-only inventory gate remains blocked on that source bridge;
zero literal matches for that function is not API absence.

Full beta generation also exposes six collection/item action collisions and seven
count collisions. Collection actions have an `ids` body whereas item actions are
bodyless, so compatible natural-ID grouping is inappropriate. Shared exact noun
overrides append `Multiple` to the collection action names. Count alternatives use
`ByArticle`, `ByHost`, or `AcrossHost` according to their actual URL scope, leaving
the published count name on its existing route. No selectors, authored profile
filters, response-union restrictions, or new suppressions resolve these collisions.
Existing v1.0 derived suppressions and curated child-navigation behavior remain
unchanged. No mutation variant groups are introduced.

On the integrated framework, full Release generation/build succeeds for both
profiles (662 v1.0 exports; 1,003 beta exports). Fresh compiled route, naming,
mandatory-ID and `WhatIf` checks are separate from transport validation. An actual
beta bulk-action invocation using the compiled module and official Authentication
2.38.1 fails on the shared missing `Microsoft.IO.RecyclableMemoryStream` 3.0.1
dependency before a request is sent. No dependency shim is included here.
Publication remains blocked on that shared packaging fix and the strict source
bridge above; build success alone is not a body/HTTP or service-validity claim.

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
# Six IDs now align; the seventh beta function still needs reviewed legacy-helper
# support for the strict inventory gate. It is not absent and is not dropped.
# The existing
# attackSimulation container suppression is reused; nested dataSource operations
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
