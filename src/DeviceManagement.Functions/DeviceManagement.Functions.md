# DeviceManagement.Functions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Functions v1.0 and/or beta modules.

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
# Rename cmdlets.
  - where:
      subject: ^(DeviceManagement(Condition|ConditionStatementManagementCondition|ConditionStatementManagementConditionStatement))$
    set:
      subject: $1ForPlatform
# TODO: Clean up
  # - where:
  #     subject: ^(DeviceManagementRoleScopeTag)$
  #     variant: ^Get$
  #   set:
  #     subject: $1ById
  # - where:
  #     subject: ^(DeviceManagementRoleScopeTag)$
  #     variant: ^Get1$|^GetViaIdentity$
  #   set:
  #     subject: $1ByResource
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
