# DeviceManagement.Administration

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Administration v1.0 and/or beta modules.

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
# Pluralize
  - where:
      subject: (.*)OnPremisConnection(.*)
    set:
      subject: $1OnPremisesConnection$2
# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagementGroupPolicyMigrationReport$
    remove: true
  - where:
      verb: Remove
      subject: ^DeviceManagementGroupPolicyUploadedDefinitionFile$
    remove: true
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint(AuditEvent|CloudPC|AuditEventAuditActivityType|DeviceImageSourceImage)$
    remove: true
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint$
    remove: true
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
