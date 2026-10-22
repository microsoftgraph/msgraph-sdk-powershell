# Security

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Security v1.0 and/or beta modules.

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
# wrapper/Security_directiveMigrationMap.json records both IDs. The existing
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
