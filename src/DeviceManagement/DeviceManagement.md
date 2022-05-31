# DeviceManagement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement v1.0 and/or beta modules.

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
  - remove-path-by-operation: ^deviceManagement.(deviceManagementScripts.userRunStates.deviceRunStates_.*|groupPolicyConfigurations.definitionValues.presentationValues_.*|deviceShellScripts.userRunStates.deviceRunStates_.*)$

# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagement(Managed|Comanaged)DeviceLogCollectionRequest$
    remove: true
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice$
    remove: true
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
