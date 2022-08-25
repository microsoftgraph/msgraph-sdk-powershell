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
directive:
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1$
    remove: true
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Get1$|^GetViaIdentity1$
    set:
      subject: $1DataSource
```
