# DeviceManagement.Enrollment

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Enrollment v1.0 and/or beta modules.

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
  - remove-path-by-operation: ^(deviceManagement_.*UserExperienceAnalytic.*|roleManagement\..*\.roleDefinition\.inheritsPermissionsFrom.*)$
# Remove cmdlets.
  - where:
      verb: Update
      subject: ^DeviceManagementWindowAutopilotDeviceIdentity$
    remove: true
```
