<!-- region Generated -->
# Microsoft.Graph.Identity.EntitlementManagement
This directory contains the PowerShell module for the IdentityEntitlement service.

---
## Status
[![Microsoft.Graph.Identity.EntitlementManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.EntitlementManagement.svg?style=flat-square&label=Microsoft.Graph.Identity.EntitlementManagement "Microsoft.Graph.Identity.EntitlementManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.EntitlementManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.EntitlementManagement`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^identityGovernance_(Get|Create|Update|Delete)EntitlementManagement$|^identityGovernance\.entitlementManagement(_.*AccessPackageResourceRoleScopes|\.accessPackageResourceRoleScopes.*|\.accessPackageAssignmentPolicies\..*|\.accessPackageAssignmentRequests\..*|\.accessPackageAssignmentResourceRoles\..*|\.accessPackageAssignments\..*|\.accessPackageCatalogs\..*|\.accessPackageResourceRequests\..*|\.accessPackageResources\..*|\.accessPackages\..*)$
  - where:
      subject: (.*)(IdentityGovernance)(EntitlementManagement)(.*)$
    set:
      subject: $1$3$4
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
