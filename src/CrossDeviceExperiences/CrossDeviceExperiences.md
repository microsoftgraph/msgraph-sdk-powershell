# CrossDeviceExperiences

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for CrossDeviceExperiences v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!
directive:
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0.
  - remove-path-by-operation: ^user.device_DeleteRegisteredOwnerGraphBPreRef$|^user.device_DeleteRegisteredUserGraphBPreRef$
```
