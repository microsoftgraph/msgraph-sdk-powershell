<!-- region Generated -->
# Microsoft.Graph.Identity.Governance
This directory contains the PowerShell module for the IdentityGovernance service.

---
## Status
[![Microsoft.Graph.Identity.Governance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.Governance.svg?style=flat-square&label=Microsoft.Graph.Identity.Governance "Microsoft.Graph.Identity.Governance")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.Governance/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.Governance`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^identityGovernance_(Get|Create|Update|Set|Delete)EntitlementManagement$|^identityGovernance\.entitlementManagement(_.*AccessPackageResourceRoleScopes|\.accessPackageResourceRoleScopes.*|\.accessPackageAssignmentPolicies\..*|\.accessPackageAssignmentRequests\..*|\.accessPackageAssignmentResourceRoles\..*|\.accessPackageAssignments\..*|\.accessPackageCatalogs\..*|\.accessPackageResourceRequests\..*|\.accessPackageResources\..*|\.accessPackages\..*)$
# Remove cmdlets
  - where:
      subject: AgreementFile
      variant: Get(2|3)|GetViaIdentity(2|3)|Delete(1|3)|DeleteViaIdentity(1|3)|Update(1|3)|UpdateExpanded(1|3)|UpdateViaIdentity(1|3)|UpdateViaIdentityExpanded(1|3)
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageRefAccessPackageCatalog$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentPolicy$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentRequest$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentResourceRole$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentApproval$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentApprovalStep$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyRefAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyAccessPackageCatalog$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestAccessPackageAssignment$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestRefAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestRequestor$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageAssignment$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageResourceRole$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageResourceScope$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageSubject$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentTarget$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageCatalogAccessPackage$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceEnvironment$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRefAccessPackageResourceEnvironment$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceRole$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceScope$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceEnvironmentAccessPackageResource$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceEnvironmentRefAccessPackageResource$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestAccessPackageResource$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestRefAccessPackageResource$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestRequestor$
    remove: true
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRoleScope$
    remove: true
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(BusinessFlowTemplate)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(ProgramControlType)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(PrivilegedRoleAssignment)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(PrivilegedRoleAssignmentRequest)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(PrivilegedOperationEvent)(\1)+
    set:
      subject: $1
# Rename cmdlets
  - where:
      verb: Get
      subject: ^(PrivilegedRole)(Assignment)$
    set:
      subject: $1Role$2
  - where:
      subject: (.*)(IdentityGovernance)(EntitlementManagement)(.*)$
    set:
      subject: $1$3$4
```
### Versioning

``` yaml
module-version: 1.4.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
