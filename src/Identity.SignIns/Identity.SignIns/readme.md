<!-- region Generated -->
# Microsoft.Graph.Identity.SignIns
This directory contains the PowerShell module for the IdentitySignIns service.

---
## Status
[![Microsoft.Graph.Identity.SignIns](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.SignIns.svg?style=flat-square&label=Microsoft.Graph.Identity.SignIns "Microsoft.Graph.Identity.SignIns")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.SignIns/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.SignIns`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
  - remove-path-by-operation: ^identity_(Get|Create|Delete|Update|List)ConditionalAccess$|^policies\.policyRoot_.*PolicyRoot|^policies_(Get|Create|Delete|Update|List)ConditionalAccessPolicies$|^invitations\.invitation_(List|Get|Update|Delete)Invitation$|^invitations_(.*)InvitedUser$
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(Oauth2PermissionGrant)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(DataPolicyOperation)(\1)+
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
