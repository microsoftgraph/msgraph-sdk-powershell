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
  - remove-path-by-operation: ^deviceManagement.(deviceManagementScript.userRunState.deviceRunState_.*|groupPolicyConfiguration.definitionValue.presentationValue_.*|deviceShellScript.userRunState.deviceRunState_.*|deviceConfiguration_assignedAccessMultiModeProfile|microsoftTunnelSite.microsoftTunnelServer_createServerLogCollectionRequest|groupPolicyConfiguration_updateDefinitionValue)$

# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagement(Managed|Comanaged)DeviceLogCollectionRequest$
    remove: true
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice$
    remove: true
  - where:
      verb: Start
      subject: ^DeviceManagementUserExperienceAnalyticDeviceScopeAction$
    remove: true
```
