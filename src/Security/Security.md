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
  - remove-path-by-operation: ^security_.*Alerts_v2$
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
# TODO: Clean up
  # - where:
  #     verb: Remove
  #     subject: ^(SecurityTiIndicator)$
  #     variant: Delete2|DeleteExpanded1
  #   set:
  #     subject: $1ByExternalId
  # - where:
  #     verb: Remove
  #     subject: ^(SecurityTiIndicator)$
  #     variant: Delete1|DeleteExpanded
  #   set:
  #     subject: $1Multiple
  # - where:
  #     verb: Update
  #     subject: ^(SecurityAlert)$
  #     variant: Update2|UpdateExpanded2
  #   set:
  #     subject: $1Multiple
  # - where:
  #     verb: Update
  #     subject: ^(SecurityTiIndicator)$
  #     variant: Update1|UpdateExpanded1
  #   set:
  #     subject: $1Multiple
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
