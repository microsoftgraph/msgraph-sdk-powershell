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
  - remove-path-by-operation: ^security(.case.ediscoveryCase.noncustodialDataSource_.*DataSource)$|^security_DeleteAttackSimulation$|^security_UpdateAttackSimulation$|^security_GetAttackSimulation$|^security.dataDiscovery.cloudAppDiscovery.uploadedStream_aggregatedAppsDetail$
# Remove properties whose free-form object schemas generate invalid C# types.
  - from: openapi-document
    where: $.components.schemas['microsoft.graph.security.securityCopilot.prompt'].allOf[1].properties.inputs
    transform: $ = undefined
  - from: openapi-document
    where: $.components.schemas['microsoft.graph.security.detectionAction'].properties.responseActions
    transform: $ = undefined
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
      verb: New
      subject: ^(SecurityAlert)$
      variant: ^Create1$|^CreateExpanded1$
    set:
      verb: Invoke
      subject: Create$1
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
  - where:
      verb: Get
      subject: ^(SecurityAlert)$
      variant: Get1
    set:
      subject: $1V2Count
```
