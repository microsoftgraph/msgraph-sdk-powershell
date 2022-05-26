---
Module Name: Microsoft.Graph.Identity.Governance
Module Guid: 9d264349-3572-484f-a7dd-c406110e009e
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.Governance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.Governance Cmdlets
### [Add-MgAccessReviewDecision](Add-MgAccessReviewDecision.md)
Invoke action applyDecisions

### [Add-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Add-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke action applyDecisions

### [Get-MgAccessReview](Get-MgAccessReview.md)
Get entity from accessReviews by key

### [Get-MgAccessReviewDecision](Get-MgAccessReviewDecision.md)
The collection of decisions for this access review.

### [Get-MgAccessReviewInstance](Get-MgAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Get-MgAccessReviewMyDecision](Get-MgAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgAccessReviewReviewer](Get-MgAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Get-MgAgreement](Get-MgAgreement.md)
Get entity from agreements by key

### [Get-MgAgreementAcceptance](Get-MgAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Get-MgAgreementFile](Get-MgAgreementFile.md)
Default PDF linked to this agreement.

### [Get-MgAgreementFileLocalization](Get-MgAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgAgreementFileLocalizationVersion](Get-MgAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgAgreementFileVersion](Get-MgAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBusinessFlowTemplate](Get-MgBusinessFlowTemplate.md)
Get entity from businessFlowTemplates by key

### [Get-MgEntitlementManagementAccessPackage](Get-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Get-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef](Get-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef.md)
Read-only.
Nullable.

### [Get-MgEntitlementManagementAccessPackageAccessPackageIncompatibleByRef](Get-MgEntitlementManagementAccessPackageAccessPackageIncompatibleByRef.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementAccessPackageAssignment](Get-MgEntitlementManagementAccessPackageAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicy](Get-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef](Get-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef](Get-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef.md)
Get ref of accessPackageCatalog from identityGovernance

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentRequest](Get-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Get-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef](Get-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef.md)
For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.
For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef](Get-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef.md)
The access package associated with the accessPackageAssignmentRequest.
An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources.
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentResourceRole](Get-MgEntitlementManagementAccessPackageAssignmentResourceRole.md)
Represents the resource-specific role which a subject has been assigned through an access package assignment.

### [Get-MgEntitlementManagementAccessPackageAssignmentResourceRoleAccessPackageAssignmentByRef](Get-MgEntitlementManagementAccessPackageAssignmentResourceRoleAccessPackageAssignmentByRef.md)
The access package assignments resulting in this role assignment.
Read-only.
Nullable.

### [Get-MgEntitlementManagementAccessPackageCatalog](Get-MgEntitlementManagementAccessPackageCatalog.md)
Represents a group of access packages.

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource.md)
Read-only.
Nullable.

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceRole](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceRole.md)
The roles in each resource in a catalog.
Read-only.

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceScope](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceScope.md)
Read-only.

### [Get-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Get-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Get customAccessPackageWorkflowExtensions from identityGovernance

### [Get-MgEntitlementManagementAccessPackageIncompatible](Get-MgEntitlementManagementAccessPackageIncompatible.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage.md)
The  access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
The  access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroup](Get-MgEntitlementManagementAccessPackageIncompatibleGroup.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageResource](Get-MgEntitlementManagementAccessPackageResource.md)
A reference to a resource associated with an access package catalog.

### [Get-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef](Get-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Get-MgEntitlementManagementAccessPackageResourceEnvironment](Get-MgEntitlementManagementAccessPackageResourceEnvironment.md)
A reference to the geolocation environment in which a resource is located.

### [Get-MgEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceByRef](Get-MgEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceByRef.md)
Read-only.
Required.

### [Get-MgEntitlementManagementAccessPackageResourceRequest](Get-MgEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Get-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef](Get-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef.md)
Nullable.

### [Get-MgEntitlementManagementConnectedOrganization](Get-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Get-MgEntitlementManagementSetting](Get-MgEntitlementManagementSetting.md)
Represents the settings that control the behavior of Azure AD entitlement management.

### [Get-MgIdentityGovernanceAccessReviewDecision](Get-MgIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [Get-MgIdentityGovernanceAccessReviewDecisionInsight](Get-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstance](Get-MgIdentityGovernanceAccessReviewDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Get-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Get-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition](Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef](Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Get-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceTermOfUseAgreement](Get-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Get-MgIdentityGovernanceTermOfUseAgreementAcceptance](Get-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgPrivilegedAccess](Get-MgPrivilegedAccess.md)
Get entity from privilegedAccess by key

### [Get-MgPrivilegedAccessResource](Get-MgPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Get-MgPrivilegedAccessRoleAssignment](Get-MgPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [Get-MgPrivilegedAccessRoleAssignmentRequest](Get-MgPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [Get-MgPrivilegedAccessRoleDefinition](Get-MgPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [Get-MgPrivilegedAccessRoleSetting](Get-MgPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [Get-MgPrivilegedApproval](Get-MgPrivilegedApproval.md)
Get entity from privilegedApproval by key

### [Get-MgPrivilegedApprovalRequest](Get-MgPrivilegedApprovalRequest.md)
Read-only.
The role assignment request for this approval object

### [Get-MgPrivilegedApprovalRequestByRef](Get-MgPrivilegedApprovalRequestByRef.md)
Read-only.
The role assignment request for this approval object

### [Get-MgPrivilegedApprovalRoleInfo](Get-MgPrivilegedApprovalRoleInfo.md)
Read-only.
Nullable.

### [Get-MgPrivilegedOperationEvent](Get-MgPrivilegedOperationEvent.md)
Get entity from privilegedOperationEvents by key

### [Get-MgPrivilegedRole](Get-MgPrivilegedRole.md)
Get entity from privilegedRoles by key

### [Get-MgPrivilegedRoleAssignmentByRef](Get-MgPrivilegedRoleAssignmentByRef.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRequest](Get-MgPrivilegedRoleAssignmentRequest.md)
Get entity from privilegedRoleAssignmentRequests by key

### [Get-MgPrivilegedRoleAssignmentRequestRoleInfo](Get-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
The roleInfo object of the role assignment request.

### [Get-MgPrivilegedRoleAssignmentRoleInfo](Get-MgPrivilegedRoleAssignmentRoleInfo.md)
Read-only.
Nullable.
The associated role information.

### [Get-MgPrivilegedRoleRoleAssignment](Get-MgPrivilegedRoleRoleAssignment.md)
Get entity from privilegedRoleAssignments by key

### [Get-MgPrivilegedRoleSetting](Get-MgPrivilegedRoleSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleSummary](Get-MgPrivilegedRoleSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Get-MgProgram](Get-MgProgram.md)
Get entity from programs by key

### [Get-MgProgramControl](Get-MgProgramControl.md)
Get entity from programControls by key

### [Get-MgProgramControlProgram](Get-MgProgramControlProgram.md)
The program this control is part of.

### [Get-MgProgramControlType](Get-MgProgramControlType.md)
Get entity from programControlTypes by key

### [Get-MgUserAgreementAcceptance](Get-MgUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Get-MgUserAgreementAcceptanceByRef](Get-MgUserAgreementAcceptanceByRef.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Invoke-MgAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation](Invoke-MgAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation.md)
Invoke action acceptRecommendations

### [Invoke-MgBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision](Invoke-MgBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision.md)
Invoke action batchRecordDecisions

### [Invoke-MgFilterEntitlementManagementAccessPackage](Invoke-MgFilterEntitlementManagementAccessPackage.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignment](Invoke-MgFilterEntitlementManagementAccessPackageAssignment.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApproval](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApproval.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentRequest](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecision](Invoke-MgFilterIdentityGovernanceAccessReviewDecision.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceDecision](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStage](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Invoke function filterByCurrentUser

### [Invoke-MgMyPrivilegedApprovalRequest](Invoke-MgMyPrivilegedApprovalRequest.md)
Invoke function myRequests

### [Invoke-MgMyPrivilegedRoleAssignment](Invoke-MgMyPrivilegedRoleAssignment.md)
Invoke function my

### [Invoke-MgMyPrivilegedRoleAssignmentRequest](Invoke-MgMyPrivilegedRoleAssignmentRequest.md)
Invoke function my

### [Invoke-MgRecordIdentityGovernanceAccessReviewDecision](Invoke-MgRecordIdentityGovernanceAccessReviewDecision.md)
Invoke action recordAllDecisions

### [Invoke-MgRecordIdentityGovernanceAccessReviewDecisionInstanceDecision](Invoke-MgRecordIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke action recordAllDecisions

### [Invoke-MgRecordIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Invoke-MgRecordIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Invoke action recordAllDecisions

### [Invoke-MgSelfPrivilegedRoleActivate](Invoke-MgSelfPrivilegedRoleActivate.md)
Invoke action selfActivate

### [Invoke-MgSelfPrivilegedRoleDeactivate](Invoke-MgSelfPrivilegedRoleDeactivate.md)
Invoke action selfDeactivate

### [New-MgAccessReview](New-MgAccessReview.md)
Add new entity to accessReviews

### [New-MgAccessReviewDecision](New-MgAccessReviewDecision.md)
The collection of decisions for this access review.

### [New-MgAccessReviewInstance](New-MgAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [New-MgAccessReviewMyDecision](New-MgAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [New-MgAccessReviewReviewer](New-MgAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [New-MgAgreement](New-MgAgreement.md)
Add new entity to agreements

### [New-MgAgreementAcceptance](New-MgAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [New-MgAgreementFile](New-MgAgreementFile.md)
PDFs linked to this agreement.
This property is in the process of being deprecated.
Use the  file property instead.
Supports $expand.

### [New-MgAgreementFileLocalization](New-MgAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [New-MgAgreementFileLocalizationVersion](New-MgAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [New-MgAgreementFileVersion](New-MgAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [New-MgBusinessFlowTemplate](New-MgBusinessFlowTemplate.md)
Add new entity to businessFlowTemplates

### [New-MgEntitlementManagementAccessPackage](New-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [New-MgEntitlementManagementAccessPackageAccessPackageIncompatibleByRef](New-MgEntitlementManagementAccessPackageAccessPackageIncompatibleByRef.md)
The access packages that are incompatible with this package.
Read-only.

### [New-MgEntitlementManagementAccessPackageAssignment](New-MgEntitlementManagementAccessPackageAssignment.md)
Create a new entitlement management accessPackageAssignment

### [New-MgEntitlementManagementAccessPackageAssignmentPolicy](New-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [New-MgEntitlementManagementAccessPackageAssignmentRequest](New-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [New-MgEntitlementManagementAccessPackageAssignmentResourceRoleAccessPackageAssignmentByRef](New-MgEntitlementManagementAccessPackageAssignmentResourceRoleAccessPackageAssignmentByRef.md)
The access package assignments resulting in this role assignment.
Read-only.
Nullable.

### [New-MgEntitlementManagementAccessPackageCatalog](New-MgEntitlementManagementAccessPackageCatalog.md)
Represents a group of access packages.

### [New-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](New-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Create new navigation property to customAccessPackageWorkflowExtensions for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
The  access packages whose assigned users are ineligible to be assigned this access package.

### [New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
The groups whose members are ineligible to be assigned this access package.

### [New-MgEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceByRef](New-MgEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceByRef.md)
Read-only.
Required.

### [New-MgEntitlementManagementAccessPackageResourceRequest](New-MgEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [New-MgEntitlementManagementAccessPackageResourceRoleScope](New-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Nullable.

### [New-MgEntitlementManagementConnectedOrganization](New-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [New-MgEntitlementManagementConnectedOrganizationExternalSponsor](New-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [New-MgEntitlementManagementConnectedOrganizationInternalSponsor](New-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [New-MgIdentityGovernanceAccessReviewDecision](New-MgIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [New-MgIdentityGovernanceAccessReviewDecisionInsight](New-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](New-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](New-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceStage](New-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [New-MgIdentityGovernanceTermOfUseAgreement](New-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [New-MgIdentityGovernanceTermOfUseAgreementAcceptance](New-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [New-MgPrivilegedAccess](New-MgPrivilegedAccess.md)
Add new entity to privilegedAccess

### [New-MgPrivilegedAccessResource](New-MgPrivilegedAccessResource.md)
A collection of resources for the provider.

### [New-MgPrivilegedAccessRoleAssignment](New-MgPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [New-MgPrivilegedAccessRoleAssignmentRequest](New-MgPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [New-MgPrivilegedAccessRoleDefinition](New-MgPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [New-MgPrivilegedAccessRoleSetting](New-MgPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [New-MgPrivilegedApproval](New-MgPrivilegedApproval.md)
Add new entity to privilegedApproval

### [New-MgPrivilegedOperationEvent](New-MgPrivilegedOperationEvent.md)
Add new entity to privilegedOperationEvents

### [New-MgPrivilegedRole](New-MgPrivilegedRole.md)
Add new entity to privilegedRoles

### [New-MgPrivilegedRoleAssignment](New-MgPrivilegedRoleAssignment.md)
Add new entity to privilegedRoleAssignments

### [New-MgPrivilegedRoleAssignmentByRef](New-MgPrivilegedRoleAssignmentByRef.md)
The assignments for this role.
Read-only.
Nullable.

### [New-MgPrivilegedRoleAssignmentEligible](New-MgPrivilegedRoleAssignmentEligible.md)
Invoke action makeEligible

### [New-MgPrivilegedRoleAssignmentPermanent](New-MgPrivilegedRoleAssignmentPermanent.md)
Invoke action makePermanent

### [New-MgPrivilegedRoleAssignmentRequest](New-MgPrivilegedRoleAssignmentRequest.md)
Add new entity to privilegedRoleAssignmentRequests

### [New-MgProgram](New-MgProgram.md)
Add new entity to programs

### [New-MgProgramControl](New-MgProgramControl.md)
Add new entity to programControls

### [New-MgProgramControlType](New-MgProgramControlType.md)
Add new entity to programControlTypes

### [New-MgUserAgreementAcceptanceByRef](New-MgUserAgreementAcceptanceByRef.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Remove-MgAccessReview](Remove-MgAccessReview.md)
Delete entity from accessReviews

### [Remove-MgAccessReviewDecision](Remove-MgAccessReviewDecision.md)
The collection of decisions for this access review.

### [Remove-MgAccessReviewInstance](Remove-MgAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Remove-MgAccessReviewMyDecision](Remove-MgAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Remove-MgAccessReviewReviewer](Remove-MgAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Remove-MgAgreement](Remove-MgAgreement.md)
Delete entity from agreements

### [Remove-MgAgreementAcceptance](Remove-MgAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Remove-MgAgreementFile](Remove-MgAgreementFile.md)
Default PDF linked to this agreement.

### [Remove-MgAgreementFileLocalization](Remove-MgAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Remove-MgAgreementFileLocalizationVersion](Remove-MgAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Remove-MgAgreementFileVersion](Remove-MgAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Remove-MgBusinessFlowTemplate](Remove-MgBusinessFlowTemplate.md)
Delete entity from businessFlowTemplates

### [Remove-MgEntitlementManagementAccessPackage](Remove-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Remove-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef](Remove-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef.md)
Read-only.
Nullable.

### [Remove-MgEntitlementManagementAccessPackageAssignment](Remove-MgEntitlementManagementAccessPackageAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [Remove-MgEntitlementManagementAccessPackageAssignmentApproval](Remove-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Approval stages for assignment requests.

### [Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStep](Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef](Remove-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef](Remove-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef.md)
Delete ref of navigation property accessPackageCatalog for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Remove-MgEntitlementManagementAccessPackageAssignmentRequest](Remove-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Remove-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef](Remove-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef.md)
For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.
For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.
Supports $expand.

### [Remove-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef](Remove-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef.md)
The access package associated with the accessPackageAssignmentRequest.
An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources.
Read-only.
Nullable.
Supports $expand.

### [Remove-MgEntitlementManagementAccessPackageCatalog](Remove-MgEntitlementManagementAccessPackageCatalog.md)
Represents a group of access packages.

### [Remove-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Remove-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Delete navigation property customAccessPackageWorkflowExtensions for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef](Remove-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Remove-MgEntitlementManagementAccessPackageResourceRequest](Remove-MgEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Remove-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef](Remove-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef.md)
Nullable.

### [Remove-MgEntitlementManagementAccessPackageResourceRoleScope](Remove-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Nullable.

### [Remove-MgEntitlementManagementConnectedOrganization](Remove-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Remove-MgEntitlementManagementConnectedOrganizationExternalSponsor](Remove-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Remove-MgEntitlementManagementConnectedOrganizationInternalSponsor](Remove-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Remove-MgIdentityGovernanceAccessReviewDecision](Remove-MgIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstance](Remove-MgIdentityGovernanceAccessReviewDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Remove-MgIdentityGovernanceTermOfUseAgreement](Remove-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance](Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Remove-MgPrivilegedAccess](Remove-MgPrivilegedAccess.md)
Delete entity from privilegedAccess

### [Remove-MgPrivilegedAccessResource](Remove-MgPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Remove-MgPrivilegedAccessRoleAssignment](Remove-MgPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [Remove-MgPrivilegedAccessRoleAssignmentRequest](Remove-MgPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [Remove-MgPrivilegedAccessRoleDefinition](Remove-MgPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [Remove-MgPrivilegedAccessRoleSetting](Remove-MgPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [Remove-MgPrivilegedApproval](Remove-MgPrivilegedApproval.md)
Delete entity from privilegedApproval

### [Remove-MgPrivilegedApprovalRequestByRef](Remove-MgPrivilegedApprovalRequestByRef.md)
Read-only.
The role assignment request for this approval object

### [Remove-MgPrivilegedApprovalRoleInfo](Remove-MgPrivilegedApprovalRoleInfo.md)
Read-only.
Nullable.

### [Remove-MgPrivilegedOperationEvent](Remove-MgPrivilegedOperationEvent.md)
Delete entity from privilegedOperationEvents

### [Remove-MgPrivilegedRole](Remove-MgPrivilegedRole.md)
Delete entity from privilegedRoles

### [Remove-MgPrivilegedRoleAssignment](Remove-MgPrivilegedRoleAssignment.md)
Delete entity from privilegedRoleAssignments

### [Remove-MgPrivilegedRoleAssignmentRequest](Remove-MgPrivilegedRoleAssignmentRequest.md)
Delete entity from privilegedRoleAssignmentRequests

### [Remove-MgPrivilegedRoleAssignmentRequestRoleInfo](Remove-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
The roleInfo object of the role assignment request.

### [Remove-MgPrivilegedRoleAssignmentRoleInfo](Remove-MgPrivilegedRoleAssignmentRoleInfo.md)
Read-only.
Nullable.
The associated role information.

### [Remove-MgPrivilegedRoleSetting](Remove-MgPrivilegedRoleSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Remove-MgPrivilegedRoleSummary](Remove-MgPrivilegedRoleSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Remove-MgProgram](Remove-MgProgram.md)
Delete entity from programs

### [Remove-MgProgramControl](Remove-MgProgramControl.md)
Delete entity from programControls

### [Remove-MgProgramControlProgram](Remove-MgProgramControlProgram.md)
The program this control is part of.

### [Remove-MgProgramControlType](Remove-MgProgramControlType.md)
Delete entity from programControlTypes

### [Reset-MgAccessReviewDecision](Reset-MgAccessReviewDecision.md)
Invoke action resetDecisions

### [Reset-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Reset-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke action resetDecisions

### [Select-MgEntitlementManagementAccessPackage](Select-MgEntitlementManagementAccessPackage.md)
Select matching entitlement management accessPackage

### [Select-MgEntitlementManagementAccessPackageAssignmentPolicy](Select-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Select matching entitlement management accessPackageAssignmentPolicy

### [Send-MgAccessReviewReminder](Send-MgAccessReviewReminder.md)
Invoke action sendReminder

### [Send-MgIdentityGovernanceAccessReviewDecisionInstanceReminder](Send-MgIdentityGovernanceAccessReviewDecisionInstanceReminder.md)
Invoke action sendReminder

### [Set-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef](Set-MgEntitlementManagementAccessPackageAccessPackageCatalogByRef.md)
Read-only.
Nullable.

### [Set-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef](Set-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Set-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef](Set-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalogByRef.md)
Update the ref of navigation property accessPackageCatalog in identityGovernance

### [Set-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef](Set-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignmentByRef.md)
For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.
For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.
Supports $expand.

### [Set-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef](Set-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageByRef.md)
The access package associated with the accessPackageAssignmentRequest.
An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources.
Read-only.
Nullable.
Supports $expand.

### [Set-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef](Set-MgEntitlementManagementAccessPackageResourceAccessPackageResourceEnvironmentByRef.md)
Contains the environment information for the resource.
This can be set using either the @odata.bind annotation or the environment's originId.Supports $expand.

### [Set-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef](Set-MgEntitlementManagementAccessPackageResourceRequestAccessPackageResourceByRef.md)
Nullable.

### [Set-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef](Set-MgIdentityGovernanceAccessReviewDecisionInstanceDefinitionByRef.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Set-MgPrivilegedApprovalRequestByRef](Set-MgPrivilegedApprovalRequestByRef.md)
Read-only.
The role assignment request for this approval object

### [Split-MgEntitlementManagementConnectedOrganization](Split-MgEntitlementManagementConnectedOrganization.md)
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgEntitlementManagementConnectedOrganization, to simplify reporting.

### [Stop-MgAccessReview](Stop-MgAccessReview.md)
Invoke action stop

### [Stop-MgEntitlementManagementAccessPackageAssignmentRequest](Stop-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action cancel

### [Stop-MgIdentityGovernanceAccessReviewDecisionInstance](Stop-MgIdentityGovernanceAccessReviewDecisionInstance.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition](Stop-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Stop-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Invoke action stop

### [Stop-MgPrivilegedRoleAssignmentRequest](Stop-MgPrivilegedRoleAssignmentRequest.md)
Invoke action cancel

### [Update-MgAccessReview](Update-MgAccessReview.md)
Update entity in accessReviews

### [Update-MgAccessReviewDecision](Update-MgAccessReviewDecision.md)
The collection of decisions for this access review.

### [Update-MgAccessReviewInstance](Update-MgAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Update-MgAccessReviewMyDecision](Update-MgAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Update-MgAccessReviewReviewer](Update-MgAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Update-MgAgreement](Update-MgAgreement.md)
Update entity in agreements

### [Update-MgAgreementAcceptance](Update-MgAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Update-MgAgreementFile](Update-MgAgreementFile.md)
Default PDF linked to this agreement.

### [Update-MgAgreementFileLocalization](Update-MgAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Update-MgAgreementFileLocalizationVersion](Update-MgAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Update-MgAgreementFileVersion](Update-MgAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Update-MgBusinessFlowTemplate](Update-MgBusinessFlowTemplate.md)
Update entity in businessFlowTemplates

### [Update-MgEntitlementManagementAccessPackage](Update-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Update-MgEntitlementManagementAccessPackageAssignment](Update-MgEntitlementManagementAccessPackageAssignment.md)
Invoke action reprocess

### [Update-MgEntitlementManagementAccessPackageAssignmentApproval](Update-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Approval stages for assignment requests.

### [Update-MgEntitlementManagementAccessPackageAssignmentApprovalStep](Update-MgEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Update the navigation property steps in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicy](Update-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Update-MgEntitlementManagementAccessPackageAssignmentRequest](Update-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action reprocess

### [Update-MgEntitlementManagementAccessPackageCatalog](Update-MgEntitlementManagementAccessPackageCatalog.md)
Represents a group of access packages.

### [Update-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Update-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Update the navigation property customAccessPackageWorkflowExtensions in identityGovernance

### [Update-MgEntitlementManagementAccessPackageResourceRequest](Update-MgEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Update-MgEntitlementManagementAccessPackageResourceRoleScope](Update-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Nullable.

### [Update-MgEntitlementManagementConnectedOrganization](Update-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Update-MgEntitlementManagementConnectedOrganizationExternalSponsor](Update-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Update-MgEntitlementManagementConnectedOrganizationInternalSponsor](Update-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Update-MgEntitlementManagementSetting](Update-MgEntitlementManagementSetting.md)
Represents the settings that control the behavior of Azure AD entitlement management.

### [Update-MgIdentityGovernanceAccessReviewDecision](Update-MgIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [Update-MgIdentityGovernanceAccessReviewDecisionInsight](Update-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Update-MgIdentityGovernanceAccessReviewDecisionInstance](Update-MgIdentityGovernanceAccessReviewDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Update-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Each principal reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Update-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Update-MgIdentityGovernanceTermOfUseAgreement](Update-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Update-MgIdentityGovernanceTermOfUseAgreementAcceptance](Update-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Update-MgPrivilegedAccess](Update-MgPrivilegedAccess.md)
Update entity in privilegedAccess

### [Update-MgPrivilegedAccessResource](Update-MgPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Update-MgPrivilegedAccessRoleAssignment](Update-MgPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [Update-MgPrivilegedAccessRoleAssignmentRequest](Update-MgPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [Update-MgPrivilegedAccessRoleDefinition](Update-MgPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [Update-MgPrivilegedAccessRoleSetting](Update-MgPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [Update-MgPrivilegedApproval](Update-MgPrivilegedApproval.md)
Update entity in privilegedApproval

### [Update-MgPrivilegedApprovalRoleInfo](Update-MgPrivilegedApprovalRoleInfo.md)
Read-only.
Nullable.

### [Update-MgPrivilegedOperationEvent](Update-MgPrivilegedOperationEvent.md)
Update entity in privilegedOperationEvents

### [Update-MgPrivilegedRole](Update-MgPrivilegedRole.md)
Update entity in privilegedRoles

### [Update-MgPrivilegedRoleAssignment](Update-MgPrivilegedRoleAssignment.md)
Update entity in privilegedRoleAssignments

### [Update-MgPrivilegedRoleAssignmentRequest](Update-MgPrivilegedRoleAssignmentRequest.md)
Update entity in privilegedRoleAssignmentRequests

### [Update-MgPrivilegedRoleAssignmentRequestRoleInfo](Update-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
The roleInfo object of the role assignment request.

### [Update-MgPrivilegedRoleAssignmentRoleInfo](Update-MgPrivilegedRoleAssignmentRoleInfo.md)
Read-only.
Nullable.
The associated role information.

### [Update-MgPrivilegedRoleSetting](Update-MgPrivilegedRoleSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Update-MgPrivilegedRoleSummary](Update-MgPrivilegedRoleSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Update-MgProgram](Update-MgProgram.md)
Update entity in programs

### [Update-MgProgramControl](Update-MgProgramControl.md)
Update entity in programControls

### [Update-MgProgramControlProgram](Update-MgProgramControlProgram.md)
The program this control is part of.

### [Update-MgProgramControlType](Update-MgProgramControlType.md)
Update entity in programControlTypes

