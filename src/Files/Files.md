# Files

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Files v1.0 and/or beta modules.

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
  - remove-path-by-operation: .*_(Create|Get|Update|Set|Delete)Activity$|.*\.activity.*$|share\..*_createLink
  - remove-path-by-operation: ^share\.listItem\.permission_grant$
  # Keep both revokeGrants routes without merging their distinct request-body types.
  - where:
      verb: Revoke
      subject: ^ShareListItemPermissionGrant$
      variant: ^(Revoke|RevokeViaIdentity)1$
      parameter-name: ^(Body|BodyParameter)$
    set:
      parameter-name: SharedListItemBodyParameter
  - where:
      verb: Get
      subject: ^(Group|User)(Drive)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
```
