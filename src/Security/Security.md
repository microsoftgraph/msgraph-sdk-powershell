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
  - remove-path-by-operation: ^security(_.*Alerts_v2|.cases.ediscoveryCases.noncustodialDataSources_.*DataSource)$
# Remove cmdlets
  - where:
      verb: Get|Update
      subject: ^Security$
    remove: true
  - where:
      verb: Update
      subject: ^SecurityAttackSimulation$
    remove: true
# Rename cmdlets
  - where:
      verb: Remove
      subject: ^(SecurityTiIndicator)$
      variant: Delete1|^DeleteExpanded$
    set:
      subject: $1Multiple
  - where:
      verb: Update
      subject: ^(SecurityAlert|SecurityTiIndicator)$
      variant: Update1|UpdateExpanded1
    set:
      subject: $1Multiple
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
