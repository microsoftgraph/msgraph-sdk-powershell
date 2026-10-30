# Identity.Governance

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Identity.Governance v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The active directives below are reviewed for both Kiota-compatible profiles in
`wrapper/Identity.Governance_directiveMigrationMap.json`. Only this shared file is
in scope; global and profile-local directives are not migrated. Parameter aliases,
transforms, and schema/response directives remain deferred; this shared file has
no groups in those deferred classes. Numbered AutoRest variants are not grounds
to suppress a unique compatible operation.

Legacy OpenAPI documents supply original operation-ID selector evidence only;
generation still uses the compatible profiles exclusively. Removed legacy
operations are recorded individually. A surviving namespace-unqualified action
must not be treated as an absent operation.

``` yaml
directive:
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0. The affected operation Ids starts from connectedOrganization_DeleteExternalSponsorGraphBPreRef$
# Wrapper migration 1: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
# Original operation-ID matches are reconciled through explicit legacy/current
# route evidence; obsolete IDs are not guessed against renamed compatible IDs.
# Reviewed namespace-unqualified action bridges require the shared validation API.
  - remove-path-by-operation: ^identityGovernance_(Get|Create|Update|Set|Delete)EntitlementManagement$|^identityGovernance\.entitlementManagement(_.*AccessPackageResourceRoleScope|\.accessPackageResourceRoleScope.*|\.accessPackageAssignmentPolicy\..*|\.accessPackageAssignmentRequest\..*|\.accessPackageAssignmentResourceRole\..*|\.accessPackageAssignment\..*|\.accessPackageCatalog\..*|\.accessPackageResourceRequest\..*|\.accessPackageResource\..*|\.accessPackage\..*)|^identityGovernance\.accessReview\.definition\.instance\.decision\.instance(\.|_).*|^identityGovernance\.accessReview\.definition\.instance\.stage\.decision\..*$|^privilegedAccess.roleAssignmentRequest.(resource|roleDefinition).*$|^privilegedAccess.roleAssignment.(resource|roleDefinition).*$|^privilegedAccess.roleDefinition.(resource|roleSetting).*$|^privilegedAccess.roleSetting.(resource|roleDefinition).*$|^identityGovernance_.*LifecycleWorkflow|^identityGovernance\.lifecycleWorkflow\.deletedItem\.(workflow|run|userProcessingResult)\..*|^identityGovernance\.lifecycleWorkflow\.workflow\.run\.userProcessingResult\.taskProcessingResult.*|^identityGovernance\.lifecycleWorkflow\.workflow\.userProcessingResult\.taskProcessingResult.*|^identityGovernance_.*RoleManagementAlert$|^identityGovernance\.roleManagementAlert_refresh$|^identityGovernance\.entitlementManagement\.resourceRoleScope_.*Scope$|^identityGovernance.entitlementManagement.connectedOrganization_DeleteExternalSponsorGraphBPreRef$|^identityGovernance.entitlementManagement.connectedOrganization_DeleteInternalSponsorGraphBPreRef$
# Remove cmdlets
# Wrapper migration 2: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AccessPackageRefAccessPackageCatalog$
    remove: true
# Wrapper migration 3: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AccessPackageGraphRefCatalog$
    remove: true
# Wrapper migration 4: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackage$
    remove: true
# Wrapper migration 5: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AssignmentGraphRefAccessPackage$
    remove: true
# Wrapper migration 6: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AssignmentAccessPackage$
    remove: true
# Wrapper migration 7: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentPolicy$
    remove: true
# Wrapper migration 8: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentRequest$
    remove: true
# Wrapper migration 9: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentAccessPackageAssignmentResourceRole$
    remove: true
# Wrapper migration 10: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentApproval$
    remove: true
# Wrapper migration 11: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentApprovalStep$
    remove: true
# Wrapper migration 12: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyAccessPackage$
    remove: true
# Wrapper migration 13: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Set|Remove
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyRefAccessPackage$
    remove: true
# Wrapper migration 14: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicyAccessPackageCatalog$
    remove: true
# Wrapper migration 15: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestAccessPackage$
    remove: true
# Wrapper migration 16: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AssignmentRequestAccessPackage$
    remove: true
# Wrapper migration 17: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestAccessPackageAssignment$
    remove: true
# Wrapper migration 18: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AssignmentRequestAssignment$
    remove: true
# Wrapper migration 19: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestRefAccessPackage$
    remove: true
# Wrapper migration 20: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AssignmentRequestGraphRefAccessPackage$
    remove: true
# Wrapper migration 21: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AssignmentRequestGraphRefAssignment$
    remove: true
# Wrapper migration 22: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AssignmentRequestGraphRefRequestor$
    remove: true
# Wrapper migration 23: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentRequestRequestor$
    remove: true
# Wrapper migration 24: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AssignmentRequestRequestor$
    remove: true
# Wrapper migration 25: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageAssignment$
    remove: true
# Wrapper migration 26: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageResourceRole$
    remove: true
# Wrapper migration 27: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageResourceScope$
    remove: true
# Wrapper migration 28: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRoleAccessPackageSubject$
    remove: true
# Wrapper migration 29: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentTarget$
    remove: true
# Wrapper migration 30: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AssignmentTarget$
    remove: true
# Wrapper migration 31: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AssignmentGraphRefTarget$
    remove: true
# Wrapper migration 32: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageCatalogAccessPackage$
    remove: true
# Wrapper migration 33: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)CatalogGraphRefAccessPackage$
    remove: true
# Wrapper migration 34: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update|Set|Invoke
      subject: (.*)(EntitlementManagement)CatalogAccessPackage$
    remove: true
# Wrapper migration 35: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)CatalogAccessPackageCatalog$
    remove: true
# Wrapper migration 36: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceEnvironment$
    remove: true
# Wrapper migration 37: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AccessPackageResourceRefAccessPackageResourceEnvironment$
    remove: true
# Wrapper migration 38: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceRole$
    remove: true
# Wrapper migration 39: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageResourceAccessPackageResourceScope$
    remove: true
# Wrapper migration 40: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceEnvironmentAccessPackageResource$
    remove: true
# Wrapper migration 41: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New
      subject: (.*)(EntitlementManagement)AccessPackageResourceEnvironmentRefAccessPackageResource$
    remove: true
# Wrapper migration 42: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestAccessPackageResource$
    remove: true
# Wrapper migration 43: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Set
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestRefAccessPackageResource$
    remove: true
# Wrapper migration 44: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageResourceRequestRequestor$
    remove: true
# Wrapper migration 45: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: (.*)(EntitlementManagement)AccessPackageResourceRoleScope$
    remove: true
# Wrapper migration 46: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New
      subject: (.*)(EntitlementManagement)AccessPackageAssignment$
    remove: true
# Wrapper migration 47: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Invoke|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentResourceRole$
    remove: true
# Wrapper migration 48: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update|Get
      subject: (.*)(EntitlementManagement)AccessPackageCatalogAccessPackageResourceRole$
      variant: (Create.*|Delete.*|Update.*|Get.*) # Removes all variants except List.*
    remove: true
# Wrapper migration 49: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update|Get
      subject: (.*)(EntitlementManagement)AccessPackageCatalogAccessPackageResourceScope$
      variant: (Create.*|Delete.*|Update.*|Get.*)
    remove: true
# Wrapper migration 50: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageResource$
    remove: true
# Wrapper migration 51: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageResourceEnvironment$
    remove: true
# Wrapper migration 52: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Search
      subject: (.*)(EntitlementManagement)AccessPackage$
    remove: true
# Wrapper migration 53: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Search|Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageCatalog$
      variant: ^(Search.*|Get1|List1|GetViaIdentity1|Create1|CreateExpanded1|CreateViaIdentity|CreateViaIdentityExpanded|Update1|UpdateExpanded1|UpdateViaIdentity1|UpdateViaIdentityExpanded1|Delete1|DeleteViaIdentity1)$
    remove: true
# Wrapper migration 54: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update|Get
      subject: (.*)(EntitlementManagement)AccessPackageCatalogAccessPackageResource$
      variant: (Create.*|Delete.*|Update.*|Get.*)
    remove: true
# Wrapper migration 55: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update
      subject: (.*)(EntitlementManagement)AccessPackageAssignmentPolicy$
      variant: ^(Get1|List1|GetViaIdentity1|Create1|CreateExpanded1|CreateViaIdentity|CreateViaIdentityExpanded|Update1|UpdateExpanded1|UpdateViaIdentity1|UpdateViaIdentityExpanded1|Delete1|DeleteViaIdentity1)$
    remove: true
# Wrapper migration 56: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: (.*)Privileged(Access|AccessResource)RoleAssignmentRequest$
      variant: ^(Update1|UpdateExpanded1|UpdateViaIdentity1|UpdateViaIdentityExpanded1)$
    remove: true
# Wrapper migration 57: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Remove
      subject: (.*)(EntitlementManagement)Setting$
    remove: true
# Wrapper migration 58: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Update
      subject: (.*)(IdentityGovernance)$
    remove: true
# Wrapper migration 59: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|Remove|Update
      subject: (.*)(IdentityGovernance)AccessReview$
    remove: true
# Wrapper migration 60: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update|Get|Invoke
      subject: (.*)(IdentityGovernance)AppConsent$
    remove: true
# Wrapper migration 61: NoCompatibleOperation; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: New|Remove|Update
      subject: ^(.*)EntitlementManagementConnectedOrganization(Internal|External)Sponsor$
    remove: true
# Wrapper migration 62: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get|New|Remove|Update|Remove|Set
      subject: ^(.*)AgreementFile$
      variant: (.*\d)
    remove: true
# Wrapper migration 63: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Remove
      subject: ^EntitlementManagementAccessPackageAssignment$
    remove: true
# Rename cmdlets with duplicates in their name.
# Wrapper migration 64: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: ^(BusinessFlowTemplate)(\1)+
    set:
      subject: $1
# Wrapper migration 65: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: ^(ProgramControlType)(\1)+
    set:
      subject: $1
# Wrapper migration 66: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: ^(PrivilegedRoleAssignment)(\1)+
    set:
      subject: $1
# Wrapper migration 67: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: ^(PrivilegedRoleAssignmentRequest)(\1)+
    set:
      subject: $1
# Wrapper migration 68: StructuralNaming; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: ^(PrivilegedOperationEvent)(\1)+
    set:
      subject: $1
# Rename cmdlets
# Wrapper migration 69: CmdletConfigurator; shared natural-ID operation variants.
# Exact profile evidence and all four preserved GET routes are recorded in
# wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      verb: Get
      subject: ^(PrivilegedRole)(Assignment)$
    set:
      subject: $1Role$2
# Wrapper migration 70: CmdletConfigurator; exact profile evidence and
# reviewed scope are in wrapper/Identity.Governance_directiveMigrationMap.json.
  - where:
      subject: (.*)(IdentityGovernance)(EntitlementManagement)(.*)$
    set:
      subject: $1$3$4
```
