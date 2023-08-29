---
Module Name: Microsoft.Graph.Identity.Governance
Module Guid: 0b1bbc32-9be6-4726-880c-da380b5e5ed8
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.Governance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.Governance Cmdlets
### [Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is false in the review's accessReviewScheduleSettings.
The status of the accessReviewInstance must be Completed to call this method.

### [Get-MgAgreement](Get-MgAgreement.md)
Get entity from agreements by key

### [Get-MgAgreementAcceptance](Get-MgAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Get-MgAgreementAcceptanceCount](Get-MgAgreementAcceptanceCount.md)
Get the number of the resource

### [Get-MgAgreementFile](Get-MgAgreementFile.md)
Retrieve the details of an agreement file, including the language and version information.
The default file can have multiple versions, each with its own language, that can be retrieved by specifying the Accept-Language header.

### [Get-MgAgreementFileCount](Get-MgAgreementFileCount.md)
Get the number of the resource

### [Get-MgAgreementFileLocalization](Get-MgAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgAgreementFileLocalizationCount](Get-MgAgreementFileLocalizationCount.md)
Get the number of the resource

### [Get-MgAgreementFileLocalizationVersion](Get-MgAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgAgreementFileLocalizationVersionCount](Get-MgAgreementFileLocalizationVersionCount.md)
Get the number of the resource

### [Get-MgAgreementFileVersion](Get-MgAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgAgreementFileVersionCount](Get-MgAgreementFileVersionCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAccessPackage](Get-MgEntitlementManagementAccessPackage.md)
Retrieve an access package with a list of accessPackageResourceRoleScope objects.
These objects represent the resource roles that an access package assigns to each subject.
Each object links to an accessPackageResourceRole and an accessPackageResourceScope.

### [Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
In Azure AD entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.
Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for.

### [Get-MgEntitlementManagementAccessPackageAssignmentApprovalCount](Get-MgEntitlementManagementAccessPackageAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
In Azure AD entitlement management, retrieve the properties of an approvalStage object.
An approval stage is contained within an approval object.

### [Get-MgEntitlementManagementAccessPackageAssignmentApprovalStageCount](Get-MgEntitlementManagementAccessPackageAssignmentApprovalStageCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicy](Get-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageCatalog](Get-MgEntitlementManagementAccessPackageCatalog.md)
Required when creating the access package.
Read-only.
Nullable.

### [Get-MgEntitlementManagementAccessPackageCount](Get-MgEntitlementManagementAccessPackageCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage.md)
Retrieve a list of the accessPackage objects that have been marked as incompatible on an accessPackage.

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Retrieve a list of the accessPackage objects that have been marked as incompatible on an accessPackage.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroup](Get-MgEntitlementManagementAccessPackageIncompatibleGroup.md)
Retrieve a list of the group objects that have been marked as incompatible on an accessPackage.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Retrieve a list of the group objects that have been marked as incompatible on an accessPackage.

### [Get-MgEntitlementManagementAccessPackageIncompatibleWith](Get-MgEntitlementManagementAccessPackageIncompatibleWith.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementAssignment](Get-MgEntitlementManagementAssignment.md)
In Azure AD entitlement management, retrieve the properties and relationships of an accessPackageAssignment object.

### [Get-MgEntitlementManagementAssignmentAdditional](Get-MgEntitlementManagementAssignmentAdditional.md)
Invoke function additionalAccess

### [Get-MgEntitlementManagementAssignmentCount](Get-MgEntitlementManagementAssignmentCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAssignmentPolicy](Get-MgEntitlementManagementAssignmentPolicy.md)
In Azure AD entitlement management, retrieve the properties and relationships of an\n accessPackageAssignmentPolicy object.

### [Get-MgEntitlementManagementAssignmentPolicyAccessPackage](Get-MgEntitlementManagementAssignmentPolicyAccessPackage.md)
Access package containing this policy.
Read-only.
Supports $expand.

### [Get-MgEntitlementManagementAssignmentPolicyCatalog](Get-MgEntitlementManagementAssignmentPolicyCatalog.md)
Catalog of the access package containing this policy.
Read-only.

### [Get-MgEntitlementManagementAssignmentPolicyCount](Get-MgEntitlementManagementAssignmentPolicyCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting](Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSettingCount](Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSettingCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSettingCustomExtension](Get-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSettingCustomExtension.md)
Indicates the custom workflow extension that will be executed at this stage.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAssignmentPolicyQuestion](Get-MgEntitlementManagementAssignmentPolicyQuestion.md)
Questions that are posed to the  requestor.

### [Get-MgEntitlementManagementAssignmentPolicyQuestionCount](Get-MgEntitlementManagementAssignmentPolicyQuestionCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementAssignmentRequest](Get-MgEntitlementManagementAssignmentRequest.md)
In Azure AD entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.

### [Get-MgEntitlementManagementAssignmentRequestCount](Get-MgEntitlementManagementAssignmentRequestCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalog](Get-MgEntitlementManagementCatalog.md)
Retrieve the properties and relationships of an accessPackageCatalog object.

### [Get-MgEntitlementManagementCatalogAccessPackageCount](Get-MgEntitlementManagementCatalogAccessPackageCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogCount](Get-MgEntitlementManagementCatalogCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogCustomWorkflowExtension](Get-MgEntitlementManagementCatalogCustomWorkflowExtension.md)
Get customWorkflowExtensions from identityGovernance

### [Get-MgEntitlementManagementCatalogCustomWorkflowExtensionCount](Get-MgEntitlementManagementCatalogCustomWorkflowExtensionCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResource](Get-MgEntitlementManagementCatalogResource.md)
Access package resources in this catalog.

### [Get-MgEntitlementManagementCatalogResourceCount](Get-MgEntitlementManagementCatalogResourceCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceEnvironment](Get-MgEntitlementManagementCatalogResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceRole](Get-MgEntitlementManagementCatalogResourceRole.md)
Get resourceRoles from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceRoleCount](Get-MgEntitlementManagementCatalogResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceRoleResource](Get-MgEntitlementManagementCatalogResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceRoleResourceEnvironment](Get-MgEntitlementManagementCatalogResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScope](Get-MgEntitlementManagementCatalogResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScopeCount](Get-MgEntitlementManagementCatalogResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResource](Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole](Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRoleCount](Get-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceScope](Get-MgEntitlementManagementCatalogResourceScope.md)
Get resourceScopes from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceScopeCount](Get-MgEntitlementManagementCatalogResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceScopeResource](Get-MgEntitlementManagementCatalogResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceScopeResourceEnvironment](Get-MgEntitlementManagementCatalogResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRole](Get-MgEntitlementManagementCatalogResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRoleCount](Get-MgEntitlementManagementCatalogResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResource](Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope](Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScopeCount](Get-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementConnectedOrganization](Get-MgEntitlementManagementConnectedOrganization.md)
Retrieve the properties and relationships of a connectedOrganization object.

### [Get-MgEntitlementManagementConnectedOrganizationCount](Get-MgEntitlementManagementConnectedOrganizationCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorCount](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Only a subset of user properties are returned by default in v1.0.
Some common uses for this function are to:

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorCount](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementResource](Get-MgEntitlementManagementResource.md)
The resources associated with the catalogs.

### [Get-MgEntitlementManagementResourceCount](Get-MgEntitlementManagementResourceCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironment](Get-MgEntitlementManagementResourceEnvironment.md)
A reference to the geolocation environments in which a resource is located.

### [Get-MgEntitlementManagementResourceEnvironmentCount](Get-MgEntitlementManagementResourceEnvironmentCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResource](Get-MgEntitlementManagementResourceEnvironmentResource.md)
Read-only.
Required.

### [Get-MgEntitlementManagementResourceEnvironmentResourceCount](Get-MgEntitlementManagementResourceEnvironmentResourceCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResourceRole](Get-MgEntitlementManagementResourceEnvironmentResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleCount](Get-MgEntitlementManagementResourceEnvironmentResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResource](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceScope](Get-MgEntitlementManagementResourceEnvironmentResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeCount](Get-MgEntitlementManagementResourceEnvironmentResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResource](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequest](Get-MgEntitlementManagementResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Get-MgEntitlementManagementResourceRequestCatalog](Get-MgEntitlementManagementResourceRequestCatalog.md)
Get catalog from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogAccessPackage](Get-MgEntitlementManagementResourceRequestCatalogAccessPackage.md)
The access packages in this catalog.
Read-only.
Nullable.

### [Get-MgEntitlementManagementResourceRequestCatalogAccessPackageCount](Get-MgEntitlementManagementResourceRequestCatalogAccessPackageCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension](Get-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension.md)
Get customWorkflowExtensions from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtensionCount](Get-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtensionCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResource](Get-MgEntitlementManagementResourceRequestCatalogResource.md)
Access package resources in this catalog.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceCount](Get-MgEntitlementManagementResourceRequestCatalogResourceCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceEnvironment](Get-MgEntitlementManagementResourceRequestCatalogResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRole](Get-MgEntitlementManagementResourceRequestCatalogResourceRole.md)
Get resourceRoles from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleCount](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResource](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScope](Get-MgEntitlementManagementResourceRequestCatalogResourceScope.md)
Get resourceScopes from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeCount](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResource](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestCount](Get-MgEntitlementManagementResourceRequestCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestResource](Get-MgEntitlementManagementResourceRequestResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestResourceEnvironment](Get-MgEntitlementManagementResourceRequestResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceRole](Get-MgEntitlementManagementResourceRequestResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceRoleCount](Get-MgEntitlementManagementResourceRequestResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestResourceRoleResource](Get-MgEntitlementManagementResourceRequestResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRequestResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceRoleResourceScope](Get-MgEntitlementManagementResourceRequestResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource](Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceScope](Get-MgEntitlementManagementResourceRequestResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceScopeCount](Get-MgEntitlementManagementResourceRequestResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestResourceScopeResource](Get-MgEntitlementManagementResourceRequestResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRequestResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceScopeResourceRole](Get-MgEntitlementManagementResourceRequestResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource](Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRole](Get-MgEntitlementManagementResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleCount](Get-MgEntitlementManagementResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleResource](Get-MgEntitlementManagementResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleResourceScope](Get-MgEntitlementManagementResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleResourceScopeResource](Get-MgEntitlementManagementResourceRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScope](Get-MgEntitlementManagementResourceRoleScope.md)
Get resourceRoleScopes from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeCount](Get-MgEntitlementManagementResourceRoleScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeResource](Get-MgEntitlementManagementResourceRoleScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeResourceEnvironment](Get-MgEntitlementManagementResourceRoleScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeResourceRole](Get-MgEntitlementManagementResourceRoleScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeResourceRoleCount](Get-MgEntitlementManagementResourceRoleScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeResourceRoleResource](Get-MgEntitlementManagementResourceRoleScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope](Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScopeCount](Get-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeResourceScope](Get-MgEntitlementManagementResourceRoleScopeResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeResourceScopeCount](Get-MgEntitlementManagementResourceRoleScopeResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeRole](Get-MgEntitlementManagementResourceRoleScopeRole.md)
Get role from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeRoleResource](Get-MgEntitlementManagementResourceRoleScopeRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceEnvironment](Get-MgEntitlementManagementResourceRoleScopeRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceRole](Get-MgEntitlementManagementResourceRoleScopeRoleResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceRoleCount](Get-MgEntitlementManagementResourceRoleScopeRoleResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScope](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeCount](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceScope](Get-MgEntitlementManagementResourceScope.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceScopeCount](Get-MgEntitlementManagementResourceScopeCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceScopeResource](Get-MgEntitlementManagementResourceScopeResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceScopeResourceEnvironment](Get-MgEntitlementManagementResourceScopeResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementResourceScopeResourceRole](Get-MgEntitlementManagementResourceScopeResourceRole.md)
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementResourceScopeResourceRoleCount](Get-MgEntitlementManagementResourceScopeResourceRoleCount.md)
Get the number of the resource

### [Get-MgEntitlementManagementResourceScopeResourceRoleResource](Get-MgEntitlementManagementResourceScopeResourceRoleResource.md)
Get resource from identityGovernance

### [Get-MgEntitlementManagementResourceScopeResourceRoleResourceEnvironment](Get-MgEntitlementManagementResourceScopeResourceRoleResourceEnvironment.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementSetting](Get-MgEntitlementManagementSetting.md)
Retrieve the properties of an entitlementManagementSettings object.

### [Get-MgIdentityGovernanceAccessReviewDefinition](Get-MgIdentityGovernanceAccessReviewDefinition.md)
Read the properties and relationships of an accessReviewScheduleDefinition object.
To retrieve the instances of the access review series, use the list accessReviewInstance API.

### [Get-MgIdentityGovernanceAccessReviewDefinitionCount](Get-MgIdentityGovernanceAccessReviewDefinitionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstance](Get-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Read the properties and relationships of an accessReviewInstance object.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewerCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewerCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Retrieve the properties and relationships of an accessReviewStage object.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionCount](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinition](Get-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Retrieve an accessReviewHistoryDefinition object by its identifier.
All the properties of the access review history definition object are returned.
If the definition is 30 days or older, a 404 Not Found error is returned.

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinitionCount](Get-MgIdentityGovernanceAccessReviewHistoryDefinitionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence.
A definition that does not recur will have exactly one instance.

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceCount](Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAppConsentRequest](Get-MgIdentityGovernanceAppConsentRequest.md)
Read the properties and relationships of an appConsentRequest object.

### [Get-MgIdentityGovernanceAppConsentRequestCount](Get-MgIdentityGovernanceAppConsentRequestCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Read the properties and relationships of a userConsentRequest object.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Approval decisions associated with a request.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
In Azure AD entitlement management, retrieve the properties of an approvalStage object.
An approval stage is contained within an approval object.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStageCount](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStageCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestCount](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflow](Get-MgIdentityGovernanceLifecycleWorkflow.md)
Read the properties and relationships of a workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowCount](Get-MgIdentityGovernanceLifecycleWorkflowCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowCreatedBy](Get-MgIdentityGovernanceLifecycleWorkflowCreatedBy.md)
The user who created the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Read the properties and relationships of a customTaskExtension object.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCount](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy.md)
The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy.md)
The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItem](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Deleted workflows in your lifecycle workflows instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Retrieve a deleted workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCount](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCreatedBy](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCreatedBy.md)
The user who created the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedBy](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedBy.md)
The unique identifier of the AAD identity that last modified the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Read the properties and relationships of a run object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
The tasks in the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
Read the properties and relationships of a workflowVersion object.

### [Get-MgIdentityGovernanceLifecycleWorkflowExecutionScope](Get-MgIdentityGovernanceLifecycleWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowExecutionScopeCount](Get-MgIdentityGovernanceLifecycleWorkflowExecutionScopeCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowLastModifiedBy](Get-MgIdentityGovernanceLifecycleWorkflowLastModifiedBy.md)
The unique identifier of the AAD identity that last modified the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRun](Get-MgIdentityGovernanceLifecycleWorkflowRun.md)
Read the properties and relationships of a run object.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunCount](Get-MgIdentityGovernanceLifecycleWorkflowRunCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
The related taskProcessingResults.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Get the user processing result of a user processing result of a run.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgIdentityGovernanceLifecycleWorkflowSetting](Get-MgIdentityGovernanceLifecycleWorkflowSetting.md)
Read the properties and relationships of a lifecycleManagementSettings object.

### [Get-MgIdentityGovernanceLifecycleWorkflowTask](Get-MgIdentityGovernanceLifecycleWorkflowTask.md)
The tasks in the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskCount](Get-MgIdentityGovernanceLifecycleWorkflowTaskCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition](Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
Read the details of a built-in workflow task.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinitionCount](Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinitionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult.md)
The result of processing the task.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReport](Get-MgIdentityGovernanceLifecycleWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportCount](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTask](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTask.md)
The related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition.md)
The taskDefinition associated with the related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
The related lifecycle workflow taskProcessingResults.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplate](Get-MgIdentityGovernanceLifecycleWorkflowTemplate.md)
Read the properties and relationships of a workflowTemplate object.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateCount](Get-MgIdentityGovernanceLifecycleWorkflowTemplateCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTask](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Represents the configured tasks to execute and their execution sequence within a workflow.
This relationship is expanded by default.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskCount](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
The result of processing the task.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersion](Get-MgIdentityGovernanceLifecycleWorkflowVersion.md)
Read the properties and relationships of a workflowVersion object.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionCount](Get-MgIdentityGovernanceLifecycleWorkflowVersionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionCreatedBy](Get-MgIdentityGovernanceLifecycleWorkflowVersionCreatedBy.md)
The user who created the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedBy](Get-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedBy.md)
The unique identifier of the AAD identity that last modified the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTask](Get-MgIdentityGovernanceLifecycleWorkflowVersionTask.md)
The tasks in the workflow.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskCount](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult.md)
The result of processing the task.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultCount](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceTermsOfUseAgreement](Get-MgIdentityGovernanceTermsOfUseAgreement.md)
Retrieve all files related to an agreement.
This includes the default file and all localized files.

### [Get-MgIdentityGovernanceTermsOfUseAgreementAcceptance](Get-MgIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgIdentityGovernanceTermsOfUseAgreementAcceptanceCount](Get-MgIdentityGovernanceTermsOfUseAgreementAcceptanceCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceTermsOfUseAgreementCount](Get-MgIdentityGovernanceTermsOfUseAgreementCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceTermsOfUseAgreementFile](Get-MgIdentityGovernanceTermsOfUseAgreementFile.md)
Retrieve the details of an agreement file, including the language and version information.
The default file can have multiple versions, each with its own language, that can be retrieved by specifying the Accept-Language header.

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileCount](Get-MgIdentityGovernanceTermsOfUseAgreementFileCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalization](Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationCount](Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersionCount](Get-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersionCount.md)
Get the number of the resource

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileVersion](Get-MgIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgIdentityGovernanceTermsOfUseAgreementFileVersionCount](Get-MgIdentityGovernanceTermsOfUseAgreementFileVersionCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectory](Get-MgRoleManagementDirectory.md)
Get directory from roleManagement

### [Get-MgRoleManagementDirectoryResourceNamespace](Get-MgRoleManagementDirectoryResourceNamespace.md)
Get resourceNamespaces from roleManagement

### [Get-MgRoleManagementDirectoryResourceNamespaceCount](Get-MgRoleManagementDirectoryResourceNamespaceCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryResourceNamespaceResourceAction](Get-MgRoleManagementDirectoryResourceNamespaceResourceAction.md)
Get resourceActions from roleManagement

### [Get-MgRoleManagementDirectoryResourceNamespaceResourceActionCount](Get-MgRoleManagementDirectoryResourceNamespaceResourceActionCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleAssignment](Get-MgRoleManagementDirectoryRoleAssignment.md)
Retrieve the properties and relationships of a unifiedRoleAssignment object.

### [Get-MgRoleManagementDirectoryRoleAssignmentAppScope](Get-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Read-only property with details of the app specific scope when the assignment scope is app specific.
Containment entity.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentCount](Get-MgRoleManagementDirectoryRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentPrincipal](Get-MgRoleManagementDirectoryRoleAssignmentPrincipal.md)
Referencing the assigned principal.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Supports $expand.
roleDefinition.Id will be auto expanded.

### [Get-MgRoleManagementDirectoryRoleAssignmentSchedule](Get-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Retrieve the schedule for an active role assignment operation.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleAppScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleCount](Get-MgRoleManagementDirectoryRoleAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Get the instance of an active role assignment.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceAppScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceCount](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstancePrincipal](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementDirectoryRoleAssignmentSchedulePrincipal](Get-MgRoleManagementDirectoryRoleAssignmentSchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
In PIM, read the details of a request for an active and persistent role assignment made through the unifiedRoleAssignmentScheduleRequest object.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestCount](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleAssignmentScheduleRoleDefinition](Get-MgRoleManagementDirectoryRoleAssignmentScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementDirectoryRoleDefinition](Get-MgRoleManagementDirectoryRoleDefinition.md)
Read the properties and relationships of a unifiedRoleDefinition object.
The following role-based access control (RBAC) providers are currently supported:

### [Get-MgRoleManagementDirectoryRoleDefinitionCount](Get-MgRoleManagementDirectoryRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles (isBuiltIn is true) support this attribute.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFromCount](Get-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFromCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleEligibilitySchedule](Get-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Retrieve the schedule for a role eligibility operation.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleAppScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleCount](Get-MgRoleManagementDirectoryRoleEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleDirectoryScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Get the instance of a role eligibility.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceAppScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceCount](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceDirectoryScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstancePrincipal](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceRoleDefinition](Get-MgRoleManagementDirectoryRoleEligibilityScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementDirectoryRoleEligibilitySchedulePrincipal](Get-MgRoleManagementDirectoryRoleEligibilitySchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
In PIM, read the details of a request for for a role eligibility request made through the unifiedRoleEligibilityScheduleRequest object.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestCount](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementDirectoryRoleEligibilityScheduleRoleDefinition](Get-MgRoleManagementDirectoryRoleEligibilityScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementEntitlementManagement](Get-MgRoleManagementEntitlementManagement.md)
Container for roles and assignments for entitlement management resources.

### [Get-MgRoleManagementEntitlementManagementResourceNamespace](Get-MgRoleManagementEntitlementManagementResourceNamespace.md)
Get resourceNamespaces from roleManagement

### [Get-MgRoleManagementEntitlementManagementResourceNamespaceCount](Get-MgRoleManagementEntitlementManagementResourceNamespaceCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction](Get-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Get resourceActions from roleManagement

### [Get-MgRoleManagementEntitlementManagementResourceNamespaceResourceActionCount](Get-MgRoleManagementEntitlementManagementResourceNamespaceResourceActionCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleAssignment](Get-MgRoleManagementEntitlementManagementRoleAssignment.md)
Retrieve the properties and relationships of a unifiedRoleAssignment object.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Read-only property with details of the app specific scope when the assignment scope is app specific.
Containment entity.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentCount](Get-MgRoleManagementEntitlementManagementRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentPrincipal.md)
Referencing the assigned principal.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Supports $expand.
roleDefinition.Id will be auto expanded.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Retrieve the schedule for an active role assignment operation.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleCount](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Get the instance of an active role assignment.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceCount](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstancePrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedulePrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentSchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
In PIM, read the details of a request for an active and persistent role assignment made through the unifiedRoleAssignmentScheduleRequest object.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestCount](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementEntitlementManagementRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleDefinition.md)
Read the properties and relationships of a unifiedRoleDefinition object.
The following role-based access control (RBAC) providers are currently supported:

### [Get-MgRoleManagementEntitlementManagementRoleDefinitionCount](Get-MgRoleManagementEntitlementManagementRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles (isBuiltIn is true) support this attribute.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromCount](Get-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Retrieve the schedule for a role eligibility operation.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleAppScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleCount](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Get the instance of a role eligibility.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceAppScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceCount](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstancePrincipal](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedulePrincipal](Get-MgRoleManagementEntitlementManagementRoleEligibilitySchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
In PIM, read the details of a request for for a role eligibility request made through the unifiedRoleEligibilityScheduleRequest object.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestCount](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRoleDefinition](Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgUserAgreementAcceptance](Get-MgUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Get-MgUserAgreementAcceptanceCount](Get-MgUserAgreementAcceptanceCount.md)
Get the number of the resource

### [Initialize-MgIdentityGovernanceLifecycleWorkflow](Initialize-MgIdentityGovernanceLifecycleWorkflow.md)
Run a workflow object on-demand.
You can run any workflow on-demand, including scheduled workflows.
Workflows created from the 'Real-time employee termination' template are run on-demand only.
When you run a workflow on demand, the tasks are executed regardless of whether the user state matches the scope and trigger execution conditions.

### [Initialize-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Initialize-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Run a workflow object on-demand.
You can run any workflow on-demand, including scheduled workflows.
Workflows created from the 'Real-time employee termination' template are run on-demand only.
When you run a workflow on demand, the tasks are executed regardless of whether the user state matches the scope and trigger execution conditions.

### [Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation](Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation.md)
Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that have not been reviewed on an accessReviewInstance object for which the calling user is a reviewer.

### [Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision](Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision.md)
Enables reviewers to review all accessReviewInstanceDecisionItem objects in batches by using principalId, resourceId, or neither.

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignmentByCurrentUser](Invoke-MgFilterEntitlementManagementAssignmentByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignmentRequestByCurrentUser](Invoke-MgFilterEntitlementManagementAssignmentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser](Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser](Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRun](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRun.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowTaskReport](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowTaskReport.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Invoke function summary

### [New-MgAgreement](New-MgAgreement.md)
Add new entity to agreements

### [New-MgAgreementAcceptance](New-MgAgreementAcceptance.md)
Create new navigation property to acceptances for agreements

### [New-MgAgreementFile](New-MgAgreementFile.md)
Create a new localized agreement file.

### [New-MgAgreementFileLocalization](New-MgAgreementFileLocalization.md)
Create new navigation property to localizations for agreements

### [New-MgAgreementFileLocalizationVersion](New-MgAgreementFileLocalizationVersion.md)
Create new navigation property to versions for agreements

### [New-MgAgreementFileVersion](New-MgAgreementFileVersion.md)
Create new navigation property to versions for agreements

### [New-MgEntitlementManagementAccessPackage](New-MgEntitlementManagementAccessPackage.md)
Create a new accessPackage object.
The access package will be added to an existing accessPackageCatalog.

### [New-MgEntitlementManagementAccessPackageAssignmentApprovalStage](New-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignmentPolicy](New-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Create new navigation property to assignmentPolicies for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Add an accessPackage to the list of access packages that have been marked as incompatible on an accessPackage.

### [New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Add a group to the list of groups that have been marked as incompatible on an accessPackage.

### [New-MgEntitlementManagementAccessPackageResourceRoleScope](New-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Create a new accessPackageResourceRoleScope for adding a resource role to an access package.
The access package resource, for a group, an app, or a SharePoint Online site, must already exist in the access package catalog, and the originId for the resource role retrieved from the list of the resource roles.
Once you add the resource role scope to the access package, the user will receive this resource role through any current and future access package assignments.

### [New-MgEntitlementManagementAssignment](New-MgEntitlementManagementAssignment.md)
Create new navigation property to assignments for identityGovernance

### [New-MgEntitlementManagementAssignmentPolicy](New-MgEntitlementManagementAssignmentPolicy.md)
In Azure AD entitlement management, create a new accessPackageAssignmentPolicy object.
The request will include a reference to the accessPackage that will contain this policy, which must already exist.

### [New-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting](New-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting.md)
Create new navigation property to customExtensionStageSettings for identityGovernance

### [New-MgEntitlementManagementAssignmentPolicyQuestion](New-MgEntitlementManagementAssignmentPolicyQuestion.md)
Create new navigation property to questions for identityGovernance

### [New-MgEntitlementManagementAssignmentRequest](New-MgEntitlementManagementAssignmentRequest.md)
In Azure AD Entitlement Management, create a new accessPackageAssignmentRequest object.
This operation is used to assign a user to an access package, update the assignment, or to remove an access package assignment.

### [New-MgEntitlementManagementCatalog](New-MgEntitlementManagementCatalog.md)
Create a new accessPackageCatalog object.

### [New-MgEntitlementManagementCatalogCustomWorkflowExtension](New-MgEntitlementManagementCatalogCustomWorkflowExtension.md)
Create new navigation property to customWorkflowExtensions for identityGovernance

### [New-MgEntitlementManagementCatalogResource](New-MgEntitlementManagementCatalogResource.md)
Create new navigation property to resources for identityGovernance

### [New-MgEntitlementManagementCatalogResourceRole](New-MgEntitlementManagementCatalogResourceRole.md)
Create new navigation property to resourceRoles for identityGovernance

### [New-MgEntitlementManagementCatalogResourceRoleResourceScope](New-MgEntitlementManagementCatalogResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole](New-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementCatalogResourceScope](New-MgEntitlementManagementCatalogResourceScope.md)
Create new navigation property to resourceScopes for identityGovernance

### [New-MgEntitlementManagementCatalogResourceScopeResourceRole](New-MgEntitlementManagementCatalogResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope](New-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementConnectedOrganization](New-MgEntitlementManagementConnectedOrganization.md)
Create a new connectedOrganization object.

### [New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Add a user or a group to the connected organization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Add a user or a group to the connected organization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [New-MgEntitlementManagementResource](New-MgEntitlementManagementResource.md)
Create new navigation property to resources for identityGovernance

### [New-MgEntitlementManagementResourceEnvironment](New-MgEntitlementManagementResourceEnvironment.md)
Create new navigation property to resourceEnvironments for identityGovernance

### [New-MgEntitlementManagementResourceEnvironmentResource](New-MgEntitlementManagementResourceEnvironmentResource.md)
Create new navigation property to resources for identityGovernance

### [New-MgEntitlementManagementResourceEnvironmentResourceRole](New-MgEntitlementManagementResourceEnvironmentResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope](New-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceEnvironmentResourceScope](New-MgEntitlementManagementResourceEnvironmentResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole](New-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRequest](New-MgEntitlementManagementResourceRequest.md)
Create a new accessPackageResourceRequest object to request the addition of a resource to an access package catalog, update of a resource, or the removal of a resource from a catalog.
A resource must be included in an access package catalog before a role of that resource can be added to an access package.
To add an Azure AD group as a resource to a catalog, set the requestType to be adminAdd, and a resource representing the resource.
The value of the originSystem property within the resource should be AadGroup and the value of the originId is the identifier of the group.
If using delegated permissions, the user requesting to add a group should be an owner of the group or in a directory role which allows them to modify groups.
If using application permissions, the application requesting to add the group should also be assigned the Group.ReadWrite.All permission.

### [New-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension](New-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension.md)
Create new navigation property to customWorkflowExtensions for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResource](New-MgEntitlementManagementResourceRequestCatalogResource.md)
Create new navigation property to resources for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceRole](New-MgEntitlementManagementResourceRequestCatalogResourceRole.md)
Create new navigation property to resourceRoles for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope](New-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole](New-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceScope](New-MgEntitlementManagementResourceRequestCatalogResourceScope.md)
Create new navigation property to resourceScopes for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole](New-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope](New-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRequestResourceRole](New-MgEntitlementManagementResourceRequestResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRequestResourceRoleResourceScope](New-MgEntitlementManagementResourceRequestResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRequestResourceScope](New-MgEntitlementManagementResourceRequestResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRequestResourceScopeResourceRole](New-MgEntitlementManagementResourceRequestResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRole](New-MgEntitlementManagementResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRoleResourceScope](New-MgEntitlementManagementResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRoleScope](New-MgEntitlementManagementResourceRoleScope.md)
Create new navigation property to resourceRoleScopes for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeResourceRole](New-MgEntitlementManagementResourceRoleScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope](New-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeResourceScope](New-MgEntitlementManagementResourceRoleScopeResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeRoleResourceRole](New-MgEntitlementManagementResourceRoleScopeRoleResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeRoleResourceScope](New-MgEntitlementManagementResourceRoleScopeRoleResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole](New-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgEntitlementManagementResourceScope](New-MgEntitlementManagementResourceScope.md)
Create new navigation property to scopes for identityGovernance

### [New-MgEntitlementManagementResourceScopeResourceRole](New-MgEntitlementManagementResourceScopeResourceRole.md)
Create new navigation property to roles for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinition](New-MgIdentityGovernanceAccessReviewDefinition.md)
Create a new accessReviewScheduleDefinition object.

### [New-MgIdentityGovernanceAccessReviewDefinitionInstance](New-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](New-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Create new navigation property to contactedReviewers for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](New-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](New-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](New-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgIdentityGovernanceAccessReviewHistoryDefinition](New-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Create a new accessReviewHistoryDefinition object.

### [New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri](New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri.md)
Generates a URI for an accessReviewHistoryInstance object the status for which is done.
Each URI can be used to retrieve the instance's review history data.
Each URI is valid for 24 hours and can be retrieved by fetching the downloadUri property from the accessReviewHistoryInstance object.

### [New-MgIdentityGovernanceAppConsentRequest](New-MgIdentityGovernanceAppConsentRequest.md)
Create new navigation property to appConsentRequests for identityGovernance

### [New-MgIdentityGovernanceAppConsentRequestUserConsentRequest](New-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Create new navigation property to userConsentRequests for identityGovernance

### [New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflow](New-MgIdentityGovernanceLifecycleWorkflow.md)
Create a new workflow object.
You can create up to 50 workflows in a tenant.

### [New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Create a new customTaskExtension object.

### [New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion](New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflowNewVersion](New-MgIdentityGovernanceLifecycleWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgIdentityGovernanceLifecycleWorkflowTask](New-MgIdentityGovernanceLifecycleWorkflowTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflowVersionTask](New-MgIdentityGovernanceLifecycleWorkflowVersionTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgIdentityGovernanceTermsOfUseAgreement](New-MgIdentityGovernanceTermsOfUseAgreement.md)
Create a new agreement object.

### [New-MgIdentityGovernanceTermsOfUseAgreementAcceptance](New-MgIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Create new navigation property to agreementAcceptances for identityGovernance

### [New-MgIdentityGovernanceTermsOfUseAgreementFile](New-MgIdentityGovernanceTermsOfUseAgreementFile.md)
Create a new localized agreement file.

### [New-MgIdentityGovernanceTermsOfUseAgreementFileLocalization](New-MgIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Create new navigation property to localizations for identityGovernance

### [New-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](New-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgIdentityGovernanceTermsOfUseAgreementFileVersion](New-MgIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgRoleManagementDirectoryResourceNamespace](New-MgRoleManagementDirectoryResourceNamespace.md)
Create new navigation property to resourceNamespaces for roleManagement

### [New-MgRoleManagementDirectoryResourceNamespaceResourceAction](New-MgRoleManagementDirectoryResourceNamespaceResourceAction.md)
Create new navigation property to resourceActions for roleManagement

### [New-MgRoleManagementDirectoryRoleAssignment](New-MgRoleManagementDirectoryRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgRoleManagementDirectoryRoleAssignmentSchedule](New-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](New-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](New-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
In PIM, carry out the following operations through the unifiedRoleAssignmentScheduleRequest object:\n+ Request active and persistent role assignments for a principal, with or without expiry dates.\n+ Activate, deactivate, extend, or renew an eligible role assignment for a principal.
To call this API to update, renew, and extend assignments for yourself, you must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgRoleManagementDirectoryRoleDefinition](New-MgRoleManagementDirectoryRoleDefinition.md)
Create a new custom unifiedRoleDefinition object.
This feature requires an Azure AD Premium P1 or P2 license.

### [New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](New-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilitySchedule](New-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](New-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](New-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
In PIM, request for a role eligibility for a principal through the unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [New-MgRoleManagementEntitlementManagementResourceNamespace](New-MgRoleManagementEntitlementManagementResourceNamespace.md)
Create new navigation property to resourceNamespaces for roleManagement

### [New-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction](New-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Create new navigation property to resourceActions for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleAssignment](New-MgRoleManagementEntitlementManagementRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](New-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
In PIM, carry out the following operations through the unifiedRoleAssignmentScheduleRequest object:\n+ Request active and persistent role assignments for a principal, with or without expiry dates.\n+ Activate, deactivate, extend, or renew an eligible role assignment for a principal.
To call this API to update, renew, and extend assignments for yourself, you must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgRoleManagementEntitlementManagementRoleDefinition](New-MgRoleManagementEntitlementManagementRoleDefinition.md)
Create a new custom unifiedRoleDefinition object.
This feature requires an Azure AD Premium P1 or P2 license.

### [New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](New-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](New-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](New-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
In PIM, request for a role eligibility for a principal through the unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [Remove-MgAgreement](Remove-MgAgreement.md)
Delete entity from agreements

### [Remove-MgAgreementAcceptance](Remove-MgAgreementAcceptance.md)
Delete navigation property acceptances for agreements

### [Remove-MgAgreementFile](Remove-MgAgreementFile.md)
Delete navigation property file for agreements

### [Remove-MgAgreementFileLocalization](Remove-MgAgreementFileLocalization.md)
Delete navigation property localizations for agreements

### [Remove-MgAgreementFileLocalizationVersion](Remove-MgAgreementFileLocalizationVersion.md)
Delete navigation property versions for agreements

### [Remove-MgAgreementFileVersion](Remove-MgAgreementFileVersion.md)
Delete navigation property versions for agreements

### [Remove-MgEntitlementManagementAccessPackage](Remove-MgEntitlementManagementAccessPackage.md)
Delete an accessPackage object.
You cannot delete an access package if it has any accessPackageAssignment.

### [Remove-MgEntitlementManagementAccessPackageAssignmentApproval](Remove-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Delete navigation property accessPackageAssignmentApprovals for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Delete navigation property assignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Remove an access package from the list of access packages that have been marked as incompatible on an accessPackage.

### [Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Remove a group from the list of groups that have been marked as incompatible on an accessPackage.

### [Remove-MgEntitlementManagementAccessPackageResourceRoleScope](Remove-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Remove a accessPackageResourceRoleScope from an accessPackage list of resource role scopes.

### [Remove-MgEntitlementManagementAssignment](Remove-MgEntitlementManagementAssignment.md)
Delete navigation property assignments for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicy](Remove-MgEntitlementManagementAssignmentPolicy.md)
In Azure AD entitlement management, delete an accessPackageAssignmentPolicy.

### [Remove-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting](Remove-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting.md)
Delete navigation property customExtensionStageSettings for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicyQuestion](Remove-MgEntitlementManagementAssignmentPolicyQuestion.md)
Delete navigation property questions for identityGovernance

### [Remove-MgEntitlementManagementAssignmentRequest](Remove-MgEntitlementManagementAssignmentRequest.md)
Delete an accessPackageAssignmentRequest object.
This request can be made to remove a denied or completed request.
You cannot delete an access package assignment request if it has any accessPackageAssignment objects.

### [Remove-MgEntitlementManagementCatalog](Remove-MgEntitlementManagementCatalog.md)
Delete an accessPackageCatalog.

### [Remove-MgEntitlementManagementCatalogCustomWorkflowExtension](Remove-MgEntitlementManagementCatalogCustomWorkflowExtension.md)
Delete navigation property customWorkflowExtensions for identityGovernance

### [Remove-MgEntitlementManagementCatalogResource](Remove-MgEntitlementManagementCatalogResource.md)
Delete navigation property resources for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceRole](Remove-MgEntitlementManagementCatalogResourceRole.md)
Delete navigation property resourceRoles for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceRoleResource](Remove-MgEntitlementManagementCatalogResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceRoleResourceScope](Remove-MgEntitlementManagementCatalogResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceRoleResourceScopeResource](Remove-MgEntitlementManagementCatalogResourceRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole](Remove-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceScope](Remove-MgEntitlementManagementCatalogResourceScope.md)
Delete navigation property resourceScopes for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceScopeResource](Remove-MgEntitlementManagementCatalogResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceScopeResourceRole](Remove-MgEntitlementManagementCatalogResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceScopeResourceRoleResource](Remove-MgEntitlementManagementCatalogResourceScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope](Remove-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganization](Remove-MgEntitlementManagementConnectedOrganization.md)
Delete a connectedOrganization object.

### [Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Remove a user or a group from the connected organization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Remove a user or a group from the connected organization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Remove-MgEntitlementManagementResource](Remove-MgEntitlementManagementResource.md)
Delete navigation property resources for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironment](Remove-MgEntitlementManagementResourceEnvironment.md)
Delete navigation property resourceEnvironments for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResource](Remove-MgEntitlementManagementResourceEnvironmentResource.md)
Delete navigation property resources for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceRole](Remove-MgEntitlementManagementResourceEnvironmentResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResource](Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope](Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource](Remove-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceScope](Remove-MgEntitlementManagementResourceEnvironmentResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResource](Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole](Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource](Remove-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequest](Remove-MgEntitlementManagementResourceRequest.md)
Delete navigation property resourceRequests for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalog](Remove-MgEntitlementManagementResourceRequestCatalog.md)
Delete navigation property catalog for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension](Remove-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension.md)
Delete navigation property customWorkflowExtensions for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResource](Remove-MgEntitlementManagementResourceRequestCatalogResource.md)
Delete navigation property resources for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceRole](Remove-MgEntitlementManagementResourceRequestCatalogResourceRole.md)
Delete navigation property resourceRoles for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResource](Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope](Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource](Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole](Remove-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceScope](Remove-MgEntitlementManagementResourceRequestCatalogResourceScope.md)
Delete navigation property resourceScopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResource](Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole](Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource](Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope](Remove-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResource](Remove-MgEntitlementManagementResourceRequestResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceRole](Remove-MgEntitlementManagementResourceRequestResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceRoleResource](Remove-MgEntitlementManagementResourceRequestResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceRoleResourceScope](Remove-MgEntitlementManagementResourceRequestResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource](Remove-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceScope](Remove-MgEntitlementManagementResourceRequestResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceScopeResource](Remove-MgEntitlementManagementResourceRequestResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceScopeResourceRole](Remove-MgEntitlementManagementResourceRequestResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource](Remove-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRole](Remove-MgEntitlementManagementResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleResource](Remove-MgEntitlementManagementResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleResourceScope](Remove-MgEntitlementManagementResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleResourceScopeResource](Remove-MgEntitlementManagementResourceRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScope](Remove-MgEntitlementManagementResourceRoleScope.md)
Delete navigation property resourceRoleScopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeResource](Remove-MgEntitlementManagementResourceRoleScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeResourceRole](Remove-MgEntitlementManagementResourceRoleScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeResourceRoleResource](Remove-MgEntitlementManagementResourceRoleScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope](Remove-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeResourceScope](Remove-MgEntitlementManagementResourceRoleScopeResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRole](Remove-MgEntitlementManagementResourceRoleScopeRole.md)
Delete navigation property role for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRoleResource](Remove-MgEntitlementManagementResourceRoleScopeRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRoleResourceRole](Remove-MgEntitlementManagementResourceRoleScopeRoleResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScope](Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource](Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole](Remove-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceScope](Remove-MgEntitlementManagementResourceScope.md)
Delete navigation property scopes for identityGovernance

### [Remove-MgEntitlementManagementResourceScopeResource](Remove-MgEntitlementManagementResourceScopeResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgEntitlementManagementResourceScopeResourceRole](Remove-MgEntitlementManagementResourceScopeResourceRole.md)
Delete navigation property roles for identityGovernance

### [Remove-MgEntitlementManagementResourceScopeResourceRoleResource](Remove-MgEntitlementManagementResourceScopeResourceRoleResource.md)
Delete navigation property resource for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinition](Remove-MgIdentityGovernanceAccessReviewDefinition.md)
Deletes an accessReviewScheduleDefinition object.

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstance](Remove-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewHistoryDefinition](Remove-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Delete navigation property historyDefinitions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Remove-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequest](Remove-MgIdentityGovernanceAppConsentRequest.md)
Delete navigation property appConsentRequests for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Delete navigation property userConsentRequests for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Delete navigation property approval for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflow](Remove-MgIdentityGovernanceLifecycleWorkflow.md)
Delete a workflow object and its associated tasks, taskProcessingResults and versions.
You can restore a deleted workflow and its associated objects within 30 days of deletion.

### [Remove-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Remove-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Delete a customTaskExtension object.
A custom task extension  can only be deleted if it is not referenced in any task objects in a lifecycle workflow.

### [Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItem](Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Delete navigation property deletedItems for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Delete a workflow object.

### [Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowTask](Remove-MgIdentityGovernanceLifecycleWorkflowTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowVersionTask](Remove-MgIdentityGovernanceLifecycleWorkflowVersionTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgIdentityGovernanceTermsOfUseAgreement](Remove-MgIdentityGovernanceTermsOfUseAgreement.md)
Delete an agreement object.

### [Remove-MgIdentityGovernanceTermsOfUseAgreementAcceptance](Remove-MgIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Delete navigation property agreementAcceptances for identityGovernance

### [Remove-MgIdentityGovernanceTermsOfUseAgreementFile](Remove-MgIdentityGovernanceTermsOfUseAgreementFile.md)
Delete navigation property file for identityGovernance

### [Remove-MgIdentityGovernanceTermsOfUseAgreementFileLocalization](Remove-MgIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Delete navigation property localizations for identityGovernance

### [Remove-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Remove-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgIdentityGovernanceTermsOfUseAgreementFileVersion](Remove-MgIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgRoleManagementDirectory](Remove-MgRoleManagementDirectory.md)
Delete navigation property directory for roleManagement

### [Remove-MgRoleManagementDirectoryResourceNamespace](Remove-MgRoleManagementDirectoryResourceNamespace.md)
Delete navigation property resourceNamespaces for roleManagement

### [Remove-MgRoleManagementDirectoryResourceNamespaceResourceAction](Remove-MgRoleManagementDirectoryResourceNamespaceResourceAction.md)
Delete navigation property resourceActions for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignment](Remove-MgRoleManagementDirectoryRoleAssignment.md)
Delete a unifiedRoleAssignment object.

### [Remove-MgRoleManagementDirectoryRoleAssignmentAppScope](Remove-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentSchedule](Remove-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Remove-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Remove-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgRoleManagementDirectoryRoleDefinition](Remove-MgRoleManagementDirectoryRoleDefinition.md)
Delete a unifiedRoleDefinition object.
You cannot delete built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.

### [Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilitySchedule](Remove-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Remove-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Remove-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Remove-MgRoleManagementEntitlementManagement](Remove-MgRoleManagementEntitlementManagement.md)
Delete navigation property entitlementManagement for roleManagement

### [Remove-MgRoleManagementEntitlementManagementResourceNamespace](Remove-MgRoleManagementEntitlementManagementResourceNamespace.md)
Delete navigation property resourceNamespaces for roleManagement

### [Remove-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction](Remove-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Delete navigation property resourceActions for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignment](Remove-MgRoleManagementEntitlementManagementRoleAssignment.md)
Delete a unifiedRoleAssignment object.

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Remove-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Remove-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Remove-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleDefinition](Remove-MgRoleManagementEntitlementManagementRoleDefinition.md)
Delete a unifiedRoleDefinition object.
You cannot delete built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.

### [Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Remove-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Remove-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Remove-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Resets all accessReviewInstanceDecisionItem objects on an accessReviewInstance to notReviewed.

### [Restore-MgIdentityGovernanceLifecycleWorkflow](Restore-MgIdentityGovernanceLifecycleWorkflow.md)
Restore a workflow that has been deleted.
You can only restore a workflow that was deleted within the last 30 days before Azure AD automatically permanently deletes it.

### [Restore-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Restore-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Restore a workflow that has been deleted.
You can only restore a workflow that was deleted within the last 30 days before Azure AD automatically permanently deletes it.

### [Resume-MgEntitlementManagementAssignmentRequest](Resume-MgEntitlementManagementAssignmentRequest.md)
Invoke action resume

### [Resume-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

### [Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult.md)
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

### [Resume-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

### [Resume-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

### [Resume-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult.md)
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

### [Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder](Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder.md)
Send a reminder to the reviewers of an active accessReviewInstance.

### [Set-MgEntitlementManagementAssignmentPolicy](Set-MgEntitlementManagementAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Stop-MgEntitlementManagementAssignmentRequest](Stop-MgEntitlementManagementAssignmentRequest.md)
In Azure AD Entitlement Management, cancel accessPackageAssignmentRequest objects that are in a cancellable state: accepted, pendingApproval, pendingNotBefore, pendingApprovalEscalated.

### [Stop-MgIdentityGovernanceAccessReviewDefinition](Stop-MgIdentityGovernanceAccessReviewDefinition.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstance](Stop-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Stop a currently active accessReviewInstance.
After the access review instance stops, the instance status is marked as Completed, the reviewers can no longer give input, and the access review decisions are applied.
Stopping an instance will not stop future instances.
To prevent a recurring access review from starting future instances, update the schedule definition to change its scheduled end date.

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Stop an access review stage that is inProgress.
After the access review stage stops, the stage status will be Completed and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Stop-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Stop-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a Granted status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the status of the canceled unifiedRoleAssignmentScheduleRequest changes to Canceled.

### [Stop-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Stop-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest object whose status is Granted and have the system automatically delete the cancelled request after 30 days.
After calling this action, the status of the cancelled unifiedRoleEligibilityScheduleRequest changes to Revoked.

### [Stop-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Stop-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a Granted status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the status of the canceled unifiedRoleAssignmentScheduleRequest changes to Canceled.

### [Stop-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Stop-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest object whose status is Granted and have the system automatically delete the cancelled request after 30 days.
After calling this action, the status of the cancelled unifiedRoleEligibilityScheduleRequest changes to Revoked.

### [Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
To validate the properties of an existing group, use the group: validateProperties function.
The following policy validations are performed for the display name and mail nickname properties:\n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate that the mail nickname is unique This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to create a Microsoft 365 group.
To validate the properties of an existing group, use the group: validateProperties function.
The following policy validations are performed for the display name and mail nickname properties:\n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate that the mail nickname is unique This API only returns the first validation failure that is encountered.
If the properties fail multiple validations, only the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.
To learn more about configuring naming policies, see Configure naming policy.

### [Update-MgAgreement](Update-MgAgreement.md)
Update entity in agreements

### [Update-MgAgreementAcceptance](Update-MgAgreementAcceptance.md)
Update the navigation property acceptances in agreements

### [Update-MgAgreementFile](Update-MgAgreementFile.md)
Update the navigation property file in agreements

### [Update-MgAgreementFileLocalization](Update-MgAgreementFileLocalization.md)
Update the navigation property localizations in agreements

### [Update-MgAgreementFileLocalizationVersion](Update-MgAgreementFileLocalizationVersion.md)
Update the navigation property versions in agreements

### [Update-MgAgreementFileVersion](Update-MgAgreementFileVersion.md)
Update the navigation property versions in agreements

### [Update-MgEntitlementManagementAccessPackage](Update-MgEntitlementManagementAccessPackage.md)
Update an existing accessPackage object to change one or more of its properties, such as the display name or description.

### [Update-MgEntitlementManagementAccessPackageAssignmentApproval](Update-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Update the navigation property accessPackageAssignmentApprovals in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
In Azure AD entitlement management, approve or deny an approvalStage object in an approval.

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicy](Update-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Update-MgEntitlementManagementAccessPackageResourceRoleScope](Update-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Update the navigation property resourceRoleScopes in identityGovernance

### [Update-MgEntitlementManagementAssignment](Update-MgEntitlementManagementAssignment.md)
In Azure AD entitlement management, callers can automatically reevaluate and enforce an accessPackageAssignment object of a user’s assignments for a specific access package.
The state of the access package assignment must be Delivered for the administrator to reprocess the user's assignment.
Only admins with the Access Package Assignment Manager role, or higher, in Azure AD entitlement management can perform this action.

### [Update-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting](Update-MgEntitlementManagementAssignmentPolicyCustomExtensionStageSetting.md)
Update the navigation property customExtensionStageSettings in identityGovernance

### [Update-MgEntitlementManagementAssignmentPolicyQuestion](Update-MgEntitlementManagementAssignmentPolicyQuestion.md)
Update the navigation property questions in identityGovernance

### [Update-MgEntitlementManagementAssignmentRequest](Update-MgEntitlementManagementAssignmentRequest.md)
In Azure AD entitlement management, callers can automatically retry a user's request for access to an access package.
It is performed on an accessPackageAssignmentRequest object whose requestState is in a DeliveryFailed or PartiallyDelivered state.
You can only reprocess a request within 14 days from the time the original request was completed.
For requests completed more than 14 days, you will need to ask the users to cancel the request(s) and make a new request in the MyAccess portal.

### [Update-MgEntitlementManagementCatalog](Update-MgEntitlementManagementCatalog.md)
Update an existing accessPackageCatalog object to change one or more of its properties, such as the display name or description.

### [Update-MgEntitlementManagementCatalogCustomWorkflowExtension](Update-MgEntitlementManagementCatalogCustomWorkflowExtension.md)
Update the navigation property customWorkflowExtensions in identityGovernance

### [Update-MgEntitlementManagementCatalogResource](Update-MgEntitlementManagementCatalogResource.md)
Update the navigation property resources in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceRole](Update-MgEntitlementManagementCatalogResourceRole.md)
Update the navigation property resourceRoles in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceRoleResource](Update-MgEntitlementManagementCatalogResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceRoleResourceScope](Update-MgEntitlementManagementCatalogResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceRoleResourceScopeResource](Update-MgEntitlementManagementCatalogResourceRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole](Update-MgEntitlementManagementCatalogResourceRoleResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceScope](Update-MgEntitlementManagementCatalogResourceScope.md)
Update the navigation property resourceScopes in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceScopeResource](Update-MgEntitlementManagementCatalogResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceScopeResourceRole](Update-MgEntitlementManagementCatalogResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceScopeResourceRoleResource](Update-MgEntitlementManagementCatalogResourceScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope](Update-MgEntitlementManagementCatalogResourceScopeResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementConnectedOrganization](Update-MgEntitlementManagementConnectedOrganization.md)
Update a connectedOrganization object to change one or more of its properties.

### [Update-MgEntitlementManagementResource](Update-MgEntitlementManagementResource.md)
Update the navigation property resources in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironment](Update-MgEntitlementManagementResourceEnvironment.md)
Update the navigation property resourceEnvironments in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResource](Update-MgEntitlementManagementResourceEnvironmentResource.md)
Update the navigation property resources in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceRole](Update-MgEntitlementManagementResourceEnvironmentResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceRoleResource](Update-MgEntitlementManagementResourceEnvironmentResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope](Update-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource](Update-MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceScope](Update-MgEntitlementManagementResourceEnvironmentResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceScopeResource](Update-MgEntitlementManagementResourceEnvironmentResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole](Update-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource](Update-MgEntitlementManagementResourceEnvironmentResourceScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequest](Update-MgEntitlementManagementResourceRequest.md)
Update the navigation property resourceRequests in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalog](Update-MgEntitlementManagementResourceRequestCatalog.md)
Update the navigation property catalog in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension](Update-MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension.md)
Update the navigation property customWorkflowExtensions in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResource](Update-MgEntitlementManagementResourceRequestCatalogResource.md)
Update the navigation property resources in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceRole](Update-MgEntitlementManagementResourceRequestCatalogResourceRole.md)
Update the navigation property resourceRoles in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResource](Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope](Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource](Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole](Update-MgEntitlementManagementResourceRequestCatalogResourceRoleResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceScope](Update-MgEntitlementManagementResourceRequestCatalogResourceScope.md)
Update the navigation property resourceScopes in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResource](Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole](Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource](Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope](Update-MgEntitlementManagementResourceRequestCatalogResourceScopeResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResource](Update-MgEntitlementManagementResourceRequestResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceRole](Update-MgEntitlementManagementResourceRequestResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceRoleResource](Update-MgEntitlementManagementResourceRequestResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceRoleResourceScope](Update-MgEntitlementManagementResourceRequestResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource](Update-MgEntitlementManagementResourceRequestResourceRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceScope](Update-MgEntitlementManagementResourceRequestResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceScopeResource](Update-MgEntitlementManagementResourceRequestResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceScopeResourceRole](Update-MgEntitlementManagementResourceRequestResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource](Update-MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRole](Update-MgEntitlementManagementResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRoleResource](Update-MgEntitlementManagementResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleResourceScope](Update-MgEntitlementManagementResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRoleResourceScopeResource](Update-MgEntitlementManagementResourceRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScope](Update-MgEntitlementManagementResourceRoleScope.md)
Update the navigation property resourceRoleScopes in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeResource](Update-MgEntitlementManagementResourceRoleScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeResourceRole](Update-MgEntitlementManagementResourceRoleScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeResourceRoleResource](Update-MgEntitlementManagementResourceRoleScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope](Update-MgEntitlementManagementResourceRoleScopeResourceRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeResourceScope](Update-MgEntitlementManagementResourceRoleScopeResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRole](Update-MgEntitlementManagementResourceRoleScopeRole.md)
Update the navigation property role in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRoleResource](Update-MgEntitlementManagementResourceRoleScopeRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRoleResourceRole](Update-MgEntitlementManagementResourceRoleScopeRoleResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRoleResourceScope](Update-MgEntitlementManagementResourceRoleScopeRoleResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource](Update-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole](Update-MgEntitlementManagementResourceRoleScopeRoleResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceScope](Update-MgEntitlementManagementResourceScope.md)
Update the navigation property scopes in identityGovernance

### [Update-MgEntitlementManagementResourceScopeResource](Update-MgEntitlementManagementResourceScopeResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementResourceScopeResourceRole](Update-MgEntitlementManagementResourceScopeResourceRole.md)
Update the navigation property roles in identityGovernance

### [Update-MgEntitlementManagementResourceScopeResourceRoleResource](Update-MgEntitlementManagementResourceScopeResourceRoleResource.md)
Update the navigation property resource in identityGovernance

### [Update-MgEntitlementManagementSetting](Update-MgEntitlementManagementSetting.md)
Update an existing entitlementManagementSettings object to change one or more of its properties.

### [Update-MgIdentityGovernanceAccessReviewDefinition](Update-MgIdentityGovernanceAccessReviewDefinition.md)
Update an existing accessReviewScheduleDefinition object to change one or more of its properties.

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstance](Update-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Update the properties of an accessReviewInstance object.
Only the reviewers and fallbackReviewers properties can be updated but the scope property is also required in the request body.
You can only add reviewers to the fallbackReviewers property but can't remove existing fallbackReviewers.
To update an accessReviewInstance, it's status must be InProgress.

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Update the properties of an accessReviewStage object.
Only the reviewers and fallbackReviewers properties can be updated.
You can only add reviewers to the fallbackReviewers property but can't remove existing fallbackReviewers.
To update an accessReviewStage, its status must be NotStarted, Initializing, or InProgress.

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Update access decisions, known as accessReviewInstanceDecisionItems, for which the user is the reviewer.

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewHistoryDefinition](Update-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Update the navigation property historyDefinitions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Update-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequest](Update-MgIdentityGovernanceAppConsentRequest.md)
Update the navigation property appConsentRequests in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Update the navigation property userConsentRequests in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Update the navigation property approval in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
In Azure AD entitlement management, approve or deny an approvalStage object in an approval.

### [Update-MgIdentityGovernanceLifecycleWorkflow](Update-MgIdentityGovernanceLifecycleWorkflow.md)
Update the properties of a workflow object.
Only the properties listed in the request body table can be updated.
To update any other workflow properties, see workflow: createNewVersion.

### [Update-MgIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Update the properties of a customTaskExtension object.

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Update-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowSetting](Update-MgIdentityGovernanceLifecycleWorkflowSetting.md)
Update the properties of a lifecycleManagementSettings object.

### [Update-MgIdentityGovernanceLifecycleWorkflowTask](Update-MgIdentityGovernanceLifecycleWorkflowTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowVersionTask](Update-MgIdentityGovernanceLifecycleWorkflowVersionTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceTermsOfUseAgreement](Update-MgIdentityGovernanceTermsOfUseAgreement.md)
Update the properties of an agreement object.

### [Update-MgIdentityGovernanceTermsOfUseAgreementAcceptance](Update-MgIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Update the navigation property agreementAcceptances in identityGovernance

### [Update-MgIdentityGovernanceTermsOfUseAgreementFile](Update-MgIdentityGovernanceTermsOfUseAgreementFile.md)
Update the navigation property file in identityGovernance

### [Update-MgIdentityGovernanceTermsOfUseAgreementFileLocalization](Update-MgIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Update the navigation property localizations in identityGovernance

### [Update-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Update-MgIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgIdentityGovernanceTermsOfUseAgreementFileVersion](Update-MgIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgRoleManagementDirectory](Update-MgRoleManagementDirectory.md)
Update the navigation property directory in roleManagement

### [Update-MgRoleManagementDirectoryResourceNamespace](Update-MgRoleManagementDirectoryResourceNamespace.md)
Update the navigation property resourceNamespaces in roleManagement

### [Update-MgRoleManagementDirectoryResourceNamespaceResourceAction](Update-MgRoleManagementDirectoryResourceNamespaceResourceAction.md)
Update the navigation property resourceActions in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignment](Update-MgRoleManagementDirectoryRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentAppScope](Update-MgRoleManagementDirectoryRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentSchedule](Update-MgRoleManagementDirectoryRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentScheduleInstance](Update-MgRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgRoleManagementDirectoryRoleAssignmentScheduleRequest](Update-MgRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgRoleManagementDirectoryRoleDefinition](Update-MgRoleManagementDirectoryRoleDefinition.md)
Update the properties of a unifiedRoleDefinition object.
You cannot update built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.

### [Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilitySchedule](Update-MgRoleManagementDirectoryRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilityScheduleInstance](Update-MgRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgRoleManagementDirectoryRoleEligibilityScheduleRequest](Update-MgRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

### [Update-MgRoleManagementEntitlementManagement](Update-MgRoleManagementEntitlementManagement.md)
Update the navigation property entitlementManagement in roleManagement

### [Update-MgRoleManagementEntitlementManagementResourceNamespace](Update-MgRoleManagementEntitlementManagementResourceNamespace.md)
Update the navigation property resourceNamespaces in roleManagement

### [Update-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction](Update-MgRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Update the navigation property resourceActions in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignment](Update-MgRoleManagementEntitlementManagementRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope](Update-MgRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentSchedule](Update-MgRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Update-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleDefinition](Update-MgRoleManagementEntitlementManagementRoleDefinition.md)
Update the properties of a unifiedRoleDefinition object.
You cannot update built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.

### [Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Update-MgRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilitySchedule](Update-MgRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Update-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

