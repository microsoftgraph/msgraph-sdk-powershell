# Compliance

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Compliance v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# directive:
# Remove undocumented cmdlets
# TODO: Clean up
  # - where:
  #     subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
  #     variant: ^Get1$|^GetViaIdentity1$|^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1|Get3$|^GetViaIdentity3$|^Update3$|^UpdateExpanded3$|^UpdateViaIdentity3$|^UpdateViaIdentityExpanded3$|^Delete3$|^DeleteViaIdentity3$
  #   remove: true
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
