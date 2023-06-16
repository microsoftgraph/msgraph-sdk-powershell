---
Module Name: Microsoft.Graph.Beta.Identity.Governance
Module Guid: 94f1bed8-1a3c-40c0-8d68-1e2ef5556d9b
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Identity.Governance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Identity.Governance Cmdlets
### [Add-MgBetaAccessReviewDecision](Add-MgBetaAccessReviewDecision.md)
In the Azure AD access reviews feature, apply the decisions of a completed accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
 After an access review is finished, either because it reached the end date or an administrator stopped it manually, and auto-apply wasn't configured for the review, you can call Apply to apply the changes.
Until apply occurs, the decisions to remove access rights do not appear on the source resource, the users for instance retain their group memberships.
By calling apply, the outcome of the review is implemented by updating the group or application.
If a user's access was denied in the review, when an administrator calls this API, Azure AD removes their membership or application assignment.
After an access review is finished, and auto-apply was configured, then the status of the review will change from Completed through intermediate states and finally will change to state Applied.
You should expect to see denied users, if any, being removed from the resource group membership or app assignment in a few minutes.
A configured auto applying review, or selecting Apply doesn't have an effect on a group that originates in an on-premises directory or a dynamic group.
If you want to change a group that originates on-premises, download the results and apply those changes to the representation of the group in that directory.

### [Add-MgBetaAccessReviewInstanceDecision](Add-MgBetaAccessReviewInstanceDecision.md)
In the Azure AD access reviews feature, apply the decisions of a completed accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
 After an access review is finished, either because it reached the end date or an administrator stopped it manually, and auto-apply wasn't configured for the review, you can call Apply to apply the changes.
Until apply occurs, the decisions to remove access rights do not appear on the source resource, the users for instance retain their group memberships.
By calling apply, the outcome of the review is implemented by updating the group or application.
If a user's access was denied in the review, when an administrator calls this API, Azure AD removes their membership or application assignment.
After an access review is finished, and auto-apply was configured, then the status of the review will change from Completed through intermediate states and finally will change to state Applied.
You should expect to see denied users, if any, being removed from the resource group membership or app assignment in a few minutes.
A configured auto applying review, or selecting Apply doesn't have an effect on a group that originates in an on-premises directory or a dynamic group.
If you want to change a group that originates on-premises, download the results and apply those changes to the representation of the group in that directory.

### [Add-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Add-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is `false` in the review's accessReviewScheduleSettings.
The status of the accessReviewInstance must be `Completed` to call this method.

### [Add-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Add-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Apply review decisions on an accessReviewInstance if the decisions were not applied automatically because the autoApplyDecisionsEnabled property is `false` in the review's accessReviewScheduleSettings.
The status of the accessReviewInstance must be `Completed` to call this method.

### [Export-MgBetaPrivilegedAccessResourceRoleAssignment](Export-MgBetaPrivilegedAccessResourceRoleAssignment.md)
Invoke function export

### [Export-MgBetaPrivilegedAccessRoleAssignment](Export-MgBetaPrivilegedAccessRoleAssignment.md)
Invoke function export

### [Get-MgBetaAccessReview](Get-MgBetaAccessReview.md)
In the Azure AD access reviews feature, retrieve an accessReview object.
 To retrieve the reviewers of the access review, use the list accessReview reviewers API.
To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API.
If this is a recurring access review, no decisions will be associated with the recurring access review series.
Instead, use the `instances` relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review.
Each past and current instance will have decisions.

### [Get-MgBetaAccessReviewCount](Get-MgBetaAccessReviewCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewDecision](Get-MgBetaAccessReviewDecision.md)
The collection of decisions for this access review.

### [Get-MgBetaAccessReviewDecisionCount](Get-MgBetaAccessReviewDecisionCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewInstance](Get-MgBetaAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Get-MgBetaAccessReviewInstanceCount](Get-MgBetaAccessReviewInstanceCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewInstanceDecision](Get-MgBetaAccessReviewInstanceDecision.md)
The collection of decisions for this access review.

### [Get-MgBetaAccessReviewInstanceDecisionCount](Get-MgBetaAccessReviewInstanceDecisionCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewInstanceMyDecision](Get-MgBetaAccessReviewInstanceMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgBetaAccessReviewInstanceMyDecisionCount](Get-MgBetaAccessReviewInstanceMyDecisionCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewInstanceReviewer](Get-MgBetaAccessReviewInstanceReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Get-MgBetaAccessReviewInstanceReviewerCount](Get-MgBetaAccessReviewInstanceReviewerCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewMyDecision](Get-MgBetaAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgBetaAccessReviewMyDecisionCount](Get-MgBetaAccessReviewMyDecisionCount.md)
Get the number of the resource

### [Get-MgBetaAccessReviewReviewer](Get-MgBetaAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Get-MgBetaAccessReviewReviewerCount](Get-MgBetaAccessReviewReviewerCount.md)
Get the number of the resource

### [Get-MgBetaAgreement](Get-MgBetaAgreement.md)
Get entity from agreements by key

### [Get-MgBetaAgreementAcceptance](Get-MgBetaAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Get-MgBetaAgreementAcceptanceCount](Get-MgBetaAgreementAcceptanceCount.md)
Get the number of the resource

### [Get-MgBetaAgreementFile](Get-MgBetaAgreementFile.md)
Retrieve the details of the default file for an agreement, including the language and version information.
The file information is specified through the agreementFile object.

### [Get-MgBetaAgreementFileCount](Get-MgBetaAgreementFileCount.md)
Get the number of the resource

### [Get-MgBetaAgreementFileLocalization](Get-MgBetaAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgBetaAgreementFileLocalizationCount](Get-MgBetaAgreementFileLocalizationCount.md)
Get the number of the resource

### [Get-MgBetaAgreementFileLocalizationVersion](Get-MgBetaAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaAgreementFileLocalizationVersionCount](Get-MgBetaAgreementFileLocalizationVersionCount.md)
Get the number of the resource

### [Get-MgBetaAgreementFileVersion](Get-MgBetaAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaAgreementFileVersionCount](Get-MgBetaAgreementFileVersionCount.md)
Get the number of the resource

### [Get-MgBetaBusinessFlowTemplate](Get-MgBetaBusinessFlowTemplate.md)
Get entity from businessFlowTemplates by key

### [Get-MgBetaBusinessFlowTemplateCount](Get-MgBetaBusinessFlowTemplateCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackage](Get-MgBetaEntitlementManagementAccessPackage.md)
Retrieve the properties and relationships of an accessPackage object.

### [Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
In Azure AD entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.
Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for.

### [Get-MgBetaEntitlementManagementAccessPackageAssignment](Get-MgBetaEntitlementManagementAccessPackageAssignment.md)
The assignment of an access package to a subject for a period of time.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentAdditional](Get-MgBetaEntitlementManagementAccessPackageAssignmentAdditional.md)
Invoke function additionalAccess

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentApprovalCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStepCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
In Azure AD entitlement management, retrieve the properties and relationships of an\n accessPackageAssignmentPolicy object.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
In Azure AD entitlement management, retrieve the properties and relationships of an  accessPackageAssignmentRequest object.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentRequestCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRole](Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRole.md)
Retrieve the properties and relationships of an accessPackageAssignmentResourceRole object.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRoleCount](Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRoleCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageCatalog](Get-MgBetaEntitlementManagementAccessPackageCatalog.md)
Retrieve the properties and relationships of an accessPackageCatalog object.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Read the properties and relationships of an accessPackageAssignmentWorkflowExtension object.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource.md)
Retrieve a list of accessPackageResource objects in an accessPackageCatalog.
To request to add or remove an accessPackageResource, use create accessPackageResourceRequest.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole.md)
Retrieve a list of accessPackageResourceRole objects of an accessPackageResource in an accessPackageCatalog.
The resource should have been added to the catalog by creating an accessPackageResourceRequest.
This list of roles can then be used by the caller to select a role, which is needed when subsequently creating an accessPackageResourceRoleScope.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceScope](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceScope.md)
Get accessPackageResourceScopes from identityGovernance

### [Get-MgBetaEntitlementManagementAccessPackageCatalogCount](Get-MgBetaEntitlementManagementAccessPackageCatalogCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Get-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Read the properties and relationships of a customAccessPackageWorkflowExtension object for an accessPackageCatalog object.

### [Get-MgBetaEntitlementManagementAccessPackageCount](Get-MgBetaEntitlementManagementAccessPackageCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackage](Get-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackage.md)
Retrieve a list of the accessPackage objects that have been marked as incompatible on an accessPackage.

### [Get-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Get-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Retrieve a list of the accessPackage objects that have been marked as incompatible on an accessPackage.

### [Get-MgBetaEntitlementManagementAccessPackageIncompatibleGroup](Get-MgBetaEntitlementManagementAccessPackageIncompatibleGroup.md)
Retrieve a list of the group objects that have been marked as incompatible on an accessPackage.

### [Get-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef](Get-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Retrieve a list of the group objects that have been marked as incompatible on an accessPackage.

### [Get-MgBetaEntitlementManagementAccessPackageIncompatibleWith](Get-MgBetaEntitlementManagementAccessPackageIncompatibleWith.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgBetaEntitlementManagementAccessPackageResource](Get-MgBetaEntitlementManagementAccessPackageResource.md)
A reference to a resource associated with an access package catalog.

### [Get-MgBetaEntitlementManagementAccessPackageResourceCount](Get-MgBetaEntitlementManagementAccessPackageResourceCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageResourceEnvironment](Get-MgBetaEntitlementManagementAccessPackageResourceEnvironment.md)
Read the properties and relationships of an accessPackageResourceEnvironment object.

### [Get-MgBetaEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceCount](Get-MgBetaEntitlementManagementAccessPackageResourceEnvironmentAccessPackageResourceCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageResourceEnvironmentCount](Get-MgBetaEntitlementManagementAccessPackageResourceEnvironmentCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementAccessPackageResourceRequest](Get-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Get-MgBetaEntitlementManagementAccessPackageResourceRequestCount](Get-MgBetaEntitlementManagementAccessPackageResourceRequestCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementConnectedOrganization](Get-MgBetaEntitlementManagementConnectedOrganization.md)
Retrieve the properties and relationships of a connectedOrganization object.

### [Get-MgBetaEntitlementManagementConnectedOrganizationCount](Get-MgBetaEntitlementManagementConnectedOrganizationCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsor.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorById](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorCount](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorDelta](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorDelta.md)
Invoke function delta

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsor.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorById](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorCount](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorCount.md)
Get the number of the resource

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorDelta](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorDelta.md)
Invoke function delta

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject.md)
Retrieve a list of recently deleted application and group objects owned by the specified user.
This API returns up to 1,000 deleted objects owned by the user, sorted by ID, and doesn't support pagination.

### [Get-MgBetaEntitlementManagementSetting](Get-MgBetaEntitlementManagementSetting.md)
Retrieve the properties of an entitlementManagementSettings object.

### [Get-MgBetaEntitlementManagementSubject](Get-MgBetaEntitlementManagementSubject.md)
Get subjects from identityGovernance

### [Get-MgBetaEntitlementManagementSubjectConnectedOrganization](Get-MgBetaEntitlementManagementSubjectConnectedOrganization.md)
The connected organization of the subject.
Read-only.
Nullable.

### [Get-MgBetaEntitlementManagementSubjectCount](Get-MgBetaEntitlementManagementSubjectCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecision](Get-MgBetaIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInsightCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInsightCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstance](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewerCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewerCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsightCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsightCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDefinition](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Retrieve the properties and relationships of an accessReviewStage object.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsightCount](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsightCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinition](Get-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Retrieve an accessReviewScheduleDefinition object by ID.
This returns all properties of the scheduled access review series except for the associated accessReviewInstances.
Each accessReviewScheduleDefinition has at least one instance.
An instance represents a review for a specific resource (such as a particular group's members), during one occurrence (e.g., March 2021) of a recurring review.
To retrieve the instances of the access review series, use the list accessReviewInstance API.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Retrieve an accessReviewInstance object using the identifier of an accessReviewInstance and its parent accessReviewScheduleDefinition.
This returns all properties of the instance except for the associated accessReviewInstanceDecisionItems.
To retrieve the decisions on the instance, use List accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewerCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewerCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsightCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDefinition](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Retrieve the properties and relationships of an accessReviewStage object.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Read the properties and relationships of an accessReviewInstanceDecisionItem object.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionCount](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinition](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinition.md)
Retrieve an accessReviewHistoryDefinition object by its identifier.
All of the properties of the access review history definition object are returned.
If the definition is 30 days or older, a `404 Not Found` error is returned.

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionCount](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence.
A definition that does not recur will have exactly one instance.

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstanceCount](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstanceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAccessReviewPolicy](Get-MgBetaIdentityGovernanceAccessReviewPolicy.md)
Read the properties and relationships of an accessReviewPolicy object.

### [Get-MgBetaIdentityGovernanceAppConsentRequest](Get-MgBetaIdentityGovernanceAppConsentRequest.md)
Read the properties and relationships of an appConsentRequest object.

### [Get-MgBetaIdentityGovernanceAppConsentRequestCount](Get-MgBetaIdentityGovernanceAppConsentRequestCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Read the properties and relationships of a userConsentRequest object.

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Approval decisions associated with a request.

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Retrieve the properties of an approvalStep object.

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStepCount](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestCount](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflow](Get-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Read the properties and relationships of a workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCreatedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowCreatedBy.md)
The user who created the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Read the properties and relationships of a customTaskExtension object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy.md)
The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy.md)
The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Deleted workflows in your lifecycle workflows instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Retrieve a deleted workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCreatedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowCreatedBy.md)
The user who created the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowLastModifiedBy.md)
The user who last modified the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Read the properties and relationships of a run object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
The tasks in the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
Read the properties and relationships of a workflowVersion object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScope](Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScopeCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScopeCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedBy.md)
The user who last modified the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRun](Get-MgBetaIdentityGovernanceLifecycleWorkflowRun.md)
Read the properties and relationships of a run object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
The related taskProcessingResults.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Get the user processing result of a user processing result of a run.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting.md)
Read the properties and relationships of a lifecycleManagementSettings object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTask.md)
The tasks in the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
Read the details of a built-in workflow task.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinitionCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult.md)
The result of processing the task.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTask.md)
The related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition.md)
The taskDefinition associated with the related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
The related lifecycle workflow taskProcessingResults.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplate](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplate.md)
Read the properties and relationships of a workflowTemplate object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Represents the configured tasks to execute and their execution sequence within a workflow.
This relationship is expanded by default.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
The result of processing the task.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion.md)
Read the properties and relationships of a workflowVersion object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedBy.md)
The user who created the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedBy.md)
The user who last modified the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask.md)
The tasks in the workflow.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult.md)
The result of processing the task.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultCount](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernancePrivilegedAccess](Get-MgBetaIdentityGovernancePrivilegedAccess.md)
Get privilegedAccess from identityGovernance

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroup.md)
A group that's governed through Privileged Identity Management (PIM).

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Get assignmentApprovals from identityGovernance

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Retrieve the properties of an approvalStep object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStepCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Read the properties and relationships of a privilegedAccessGroupAssignmentSchedule object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleActivatedUsing](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleActivatedUsing.md)
When the request activates an ownership or membership assignment in PIM for groups, this object represents the eligibility relationship.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleGroup.md)
References the group that is the scope of the membership or ownership assignment through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Read the properties and relationships of a privilegedAccessGroupAssignmentScheduleInstance object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceActivatedUsing](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceActivatedUsing.md)
When the request activates a membership or ownership in PIM for groups, this object represents the eligibility request for the group.
Otherwise, it is null.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceGroup.md)
References the group that is the scope of the membership or ownership assignment through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstancePrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstancePrincipal.md)
References the principal that's in the scope of the membership or ownership assignment request through the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedulePrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedulePrincipal.md)
References the principal that's in the scope of this membership or ownership assignment request to the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Read the properties and relationships of a privilegedAccessGroupAssignmentScheduleRequest object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestActivatedUsing](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestActivatedUsing.md)
When the request activates a membership or ownership assignment in PIM for groups, this object represents the eligibility policy for the group.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestGroup.md)
References the group that is the scope of the membership or ownership assignment request through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestPrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestPrincipal.md)
References the principal that's in the scope of this membership or ownership assignment request through the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestTargetSchedule](Get-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestTargetSchedule.md)
Schedule created by this request.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Read the properties and relationships of a privilegedAccessGroupEligibilitySchedule object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleGroup.md)
References the group that is the scope of the membership or ownership eligibility through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Read the properties and relationships of a privilegedAccessGroupEligibilityScheduleInstance object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceGroup.md)
References the group that is the scope of the membership or ownership eligibility through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstancePrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstancePrincipal.md)
References the principal that's in the scope of the membership or ownership eligibility request through the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedulePrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedulePrincipal.md)
References the principal that's in the scope of this membership or ownership eligibility request to the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Read the properties and relationships of a privilegedAccessGroupEligibilityScheduleRequest object.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestCount](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestGroup](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestGroup.md)
References the group that is the scope of the membership or ownership eligibility request through PIM for groups.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestPrincipal](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestPrincipal.md)
References the principal that's in the scope of the membership or ownership eligibility request through the group that's governed by PIM.
Supports $expand.

### [Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestTargetSchedule](Get-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestTargetSchedule.md)
Schedule created by this request.

### [Get-MgBetaIdentityGovernanceRoleManagementAlert](Get-MgBetaIdentityGovernanceRoleManagementAlert.md)
Get alerts from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertConfiguration](Get-MgBetaIdentityGovernanceRoleManagementAlertConfiguration.md)
Get alertConfigurations from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertConfigurationAlertDefinition](Get-MgBetaIdentityGovernanceRoleManagementAlertConfigurationAlertDefinition.md)
Get alertDefinition from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertConfigurationCount](Get-MgBetaIdentityGovernanceRoleManagementAlertConfigurationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceRoleManagementAlertCount](Get-MgBetaIdentityGovernanceRoleManagementAlertCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceRoleManagementAlertDefinition](Get-MgBetaIdentityGovernanceRoleManagementAlertDefinition.md)
Get alertDefinitions from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertDefinitionCount](Get-MgBetaIdentityGovernanceRoleManagementAlertDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceRoleManagementAlertIncident](Get-MgBetaIdentityGovernanceRoleManagementAlertIncident.md)
Get alertIncidents from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertIncidentCount](Get-MgBetaIdentityGovernanceRoleManagementAlertIncidentCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceRoleManagementAlertOperation](Get-MgBetaIdentityGovernanceRoleManagementAlertOperation.md)
Get operations from identityGovernance

### [Get-MgBetaIdentityGovernanceRoleManagementAlertOperationCount](Get-MgBetaIdentityGovernanceRoleManagementAlertOperationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreement](Get-MgBetaIdentityGovernanceTermsOfUseAgreement.md)
Retrieve the properties and relationships of an agreement object.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance](Get-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptanceCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptanceCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFile](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFile.md)
Retrieve the details of the default file for an agreement, including the language and version information.
The file information is specified through the agreementFile object.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersionCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersionCount.md)
Get the number of the resource

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersionCount](Get-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersionCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccess](Get-MgBetaPrivilegedAccess.md)
Get entity from privilegedAccess by key

### [Get-MgBetaPrivilegedAccessCount](Get-MgBetaPrivilegedAccessCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResource](Get-MgBetaPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Get-MgBetaPrivilegedAccessResourceCount](Get-MgBetaPrivilegedAccessResourceCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResourceParent](Get-MgBetaPrivilegedAccessResourceParent.md)
Read-only.
The parent resource.
for pimforazurerbac scenario, it can represent the subscription the resource belongs to.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignment](Get-MgBetaPrivilegedAccessResourceRoleAssignment.md)
The collection of role assignments for the resource.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentCount](Get-MgBetaPrivilegedAccessResourceRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment](Get-MgBetaPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
The collection of role assignment requests for the resource.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestCount](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestResource](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestResource.md)
Read-only.
The resource that the request aims to.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Read-only.
The role definition that the request aims to.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionResource](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Read-only.
The user/group principal.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentResource](Get-MgBetaPrivilegedAccessResourceRoleAssignmentResource.md)
Read-only.
The resource associated with the role assignment.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Read-only.
The role definition associated with the role assignment.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinitionResource](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentSubject](Get-MgBetaPrivilegedAccessResourceRoleAssignmentSubject.md)
Read-only.
The subject associated with the role assignment.

### [Get-MgBetaPrivilegedAccessResourceRoleDefinition](Get-MgBetaPrivilegedAccessResourceRoleDefinition.md)
The collection of role defintions for the resource.

### [Get-MgBetaPrivilegedAccessResourceRoleDefinitionCount](Get-MgBetaPrivilegedAccessResourceRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResourceRoleDefinitionResource](Get-MgBetaPrivilegedAccessResourceRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleSetting.md)
The collection of role settings for the resource.

### [Get-MgBetaPrivilegedAccessResourceRoleSettingCount](Get-MgBetaPrivilegedAccessResourceRoleSettingCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessResourceRoleSettingResource](Get-MgBetaPrivilegedAccessResourceRoleSettingResource.md)
Read-only.
The associated resource for this role setting.

### [Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition](Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Read-only.
The role definition that is enforced with this role setting.

### [Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinitionResource](Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessRoleAssignment](Get-MgBetaPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [Get-MgBetaPrivilegedAccessRoleAssignmentCount](Get-MgBetaPrivilegedAccessRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment](Get-MgBetaPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequest](Get-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequestCount](Get-MgBetaPrivilegedAccessRoleAssignmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequestResource](Get-MgBetaPrivilegedAccessRoleAssignmentRequestResource.md)
Read-only.
The resource that the request aims to.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition](Get-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Read-only.
The role definition that the request aims to.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequestSubject](Get-MgBetaPrivilegedAccessRoleAssignmentRequestSubject.md)
Read-only.
The user/group principal.

### [Get-MgBetaPrivilegedAccessRoleAssignmentResource](Get-MgBetaPrivilegedAccessRoleAssignmentResource.md)
Read-only.
The resource associated with the role assignment.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition](Get-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition.md)
Read-only.
The role definition associated with the role assignment.

### [Get-MgBetaPrivilegedAccessRoleAssignmentSubject](Get-MgBetaPrivilegedAccessRoleAssignmentSubject.md)
Read-only.
The subject associated with the role assignment.

### [Get-MgBetaPrivilegedAccessRoleDefinition](Get-MgBetaPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [Get-MgBetaPrivilegedAccessRoleDefinitionCount](Get-MgBetaPrivilegedAccessRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessRoleDefinitionResource](Get-MgBetaPrivilegedAccessRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessRoleSetting](Get-MgBetaPrivilegedAccessRoleSetting.md)
Retrieve the properties and relationships of a governanceRoleSetting.

### [Get-MgBetaPrivilegedAccessRoleSettingCount](Get-MgBetaPrivilegedAccessRoleSettingCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedAccessRoleSettingResource](Get-MgBetaPrivilegedAccessRoleSettingResource.md)
Read-only.
The associated resource for this role setting.

### [Get-MgBetaPrivilegedAccessRoleSettingRoleDefinition](Get-MgBetaPrivilegedAccessRoleSettingRoleDefinition.md)
Read-only.
The role definition that is enforced with this role setting.

### [Get-MgBetaPrivilegedApproval](Get-MgBetaPrivilegedApproval.md)
Get entity from privilegedApproval by key

### [Get-MgBetaPrivilegedApprovalCount](Get-MgBetaPrivilegedApprovalCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedApprovalRequest](Get-MgBetaPrivilegedApprovalRequest.md)
Get request from privilegedApproval

### [Get-MgBetaPrivilegedApprovalRoleInfo](Get-MgBetaPrivilegedApprovalRoleInfo.md)
Get roleInfo from privilegedApproval

### [Get-MgBetaPrivilegedApprovalRoleInfoAssignment](Get-MgBetaPrivilegedApprovalRoleInfoAssignment.md)
Get assignments from privilegedApproval

### [Get-MgBetaPrivilegedApprovalRoleInfoAssignmentCount](Get-MgBetaPrivilegedApprovalRoleInfoAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedApprovalRoleInfoSetting](Get-MgBetaPrivilegedApprovalRoleInfoSetting.md)
Get settings from privilegedApproval

### [Get-MgBetaPrivilegedApprovalRoleInfoSummary](Get-MgBetaPrivilegedApprovalRoleInfoSummary.md)
Get summary from privilegedApproval

### [Get-MgBetaPrivilegedOperationEvent](Get-MgBetaPrivilegedOperationEvent.md)
Get entity from privilegedOperationEvents by key

### [Get-MgBetaPrivilegedOperationEventCount](Get-MgBetaPrivilegedOperationEventCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRole](Get-MgBetaPrivilegedRole.md)
Get entity from privilegedRoles by key

### [Get-MgBetaPrivilegedRoleAssignmentCount](Get-MgBetaPrivilegedRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRoleAssignmentRequest](Get-MgBetaPrivilegedRoleAssignmentRequest.md)
Get entity from privilegedRoleAssignmentRequests by key

### [Get-MgBetaPrivilegedRoleAssignmentRequestCount](Get-MgBetaPrivilegedRoleAssignmentRequestCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfo](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfo.md)
Get roleInfo from privilegedRoleAssignmentRequests

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignment](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignment.md)
Get assignments from privilegedRoleAssignmentRequests

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignmentCount](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Get settings from privilegedRoleAssignmentRequests

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Get summary from privilegedRoleAssignmentRequests

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfo](Get-MgBetaPrivilegedRoleAssignmentRoleInfo.md)
Get roleInfo from privilegedRoleAssignments

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignment](Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignment.md)
Get assignments from privilegedRoleAssignments

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignmentCount](Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoSetting](Get-MgBetaPrivilegedRoleAssignmentRoleInfoSetting.md)
Get settings from privilegedRoleAssignments

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoSummary](Get-MgBetaPrivilegedRoleAssignmentRoleInfoSummary.md)
Get summary from privilegedRoleAssignments

### [Get-MgBetaPrivilegedRoleCount](Get-MgBetaPrivilegedRoleCount.md)
Get the number of the resource

### [Get-MgBetaPrivilegedRoleRoleAssignment](Get-MgBetaPrivilegedRoleRoleAssignment.md)
Get entity from privilegedRoleAssignments by key

### [Get-MgBetaPrivilegedRoleSetting](Get-MgBetaPrivilegedRoleSetting.md)
Get settings from privilegedRoles

### [Get-MgBetaPrivilegedRoleSummary](Get-MgBetaPrivilegedRoleSummary.md)
Get summary from privilegedRoles

### [Get-MgBetaProgram](Get-MgBetaProgram.md)
Get entity from programs by key

### [Get-MgBetaProgramControl](Get-MgBetaProgramControl.md)
Get entity from programControls by key

### [Get-MgBetaProgramControlCount](Get-MgBetaProgramControlCount.md)
Get the number of the resource

### [Get-MgBetaProgramControlProgram](Get-MgBetaProgramControlProgram.md)
The program this control is part of.

### [Get-MgBetaProgramControlType](Get-MgBetaProgramControlType.md)
Get entity from programControlTypes by key

### [Get-MgBetaProgramControlTypeCount](Get-MgBetaProgramControlTypeCount.md)
Get the number of the resource

### [Get-MgBetaProgramCount](Get-MgBetaProgramCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectory](Get-MgBetaRoleManagementDirectory.md)
Get directory from roleManagement

### [Get-MgBetaRoleManagementDirectoryResourceNamespace](Get-MgBetaRoleManagementDirectoryResourceNamespace.md)
Read the properties and relationships of an unifiedRbacResourceNamespace object.

### [Get-MgBetaRoleManagementDirectoryResourceNamespaceCount](Get-MgBetaRoleManagementDirectoryResourceNamespaceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction](Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction.md)
Read the properties and relationships of an unifiedRbacResourceAction object.

### [Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionAuthenticationContext](Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionAuthenticationContext.md)
Get authenticationContext from roleManagement

### [Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionCount](Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope](Get-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope.md)
Get resourceScope from roleManagement

### [Get-MgBetaRoleManagementDirectoryRoleAssignment](Get-MgBetaRoleManagementDirectoryRoleAssignment.md)
Retrieve the properties and relationships of a unifiedRoleAssignment object.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentApproval](Get-MgBetaRoleManagementDirectoryRoleAssignmentApproval.md)
Get roleAssignmentApprovals from roleManagement

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep](Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep.md)
Retrieve the properties of an approvalStep object.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStepCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentAppScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentPrincipal](Get-MgBetaRoleManagementDirectoryRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentSchedule](Get-MgBetaRoleManagementDirectoryRoleAssignmentSchedule.md)
Retrieve the schedule for an active role assignment operation.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleAppScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Get the instance of an active role assignment.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceAppScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstancePrincipal](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentSchedulePrincipal](Get-MgBetaRoleManagementDirectoryRoleAssignmentSchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
In PIM, read the details of a request for an active and persistent role assignment made through the unifiedRoleAssignmentScheduleRequest object.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestCount](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementDirectoryRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleDefinition.md)
Get the properties and relationships of a unifiedRoleDefinition object of an RBAC provider.
The following RBAC providers are currently supported:\n- Cloud PC \n- device management (Intune)\n- directory (Azure AD directory roles)\n- entitlement management (Azure AD entitlement management)\n- Exchange Online

### [Get-MgBetaRoleManagementDirectoryRoleDefinitionCount](Get-MgBetaRoleManagementDirectoryRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Get-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Get-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFromCount](Get-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFromCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleEligibilitySchedule](Get-MgBetaRoleManagementDirectoryRoleEligibilitySchedule.md)
Read the properties and relationships of an unifiedRoleEligibilitySchedule object.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleAppScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleCount](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleInstance object.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceAppScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceCount](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstancePrincipal](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilitySchedulePrincipal](Get-MgBetaRoleManagementDirectoryRoleEligibilitySchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleRequest object.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestCount](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRoleDefinition](Get-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignment](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignment.md)
Get transitiveRoleAssignments from roleManagement

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentCount](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentPrincipal](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseApp](Get-MgBetaRoleManagementEnterpriseApp.md)
Get enterpriseApps from roleManagement

### [Get-MgBetaRoleManagementEnterpriseAppCount](Get-MgBetaRoleManagementEnterpriseAppCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespace](Get-MgBetaRoleManagementEnterpriseAppResourceNamespace.md)
Read the properties and relationships of an unifiedRbacResourceNamespace object.

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceCount](Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction](Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction.md)
Read the properties and relationships of an unifiedRbacResourceAction object.

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionAuthenticationContext](Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionAuthenticationContext.md)
Get authenticationContext from roleManagement

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionCount](Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope](Get-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope.md)
Get resourceScope from roleManagement

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignment](Get-MgBetaRoleManagementEnterpriseAppRoleAssignment.md)
Retrieve the properties and relationships of a unifiedRoleAssignment object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval.md)
Get roleAssignmentApprovals from roleManagement

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep.md)
Retrieve the properties of an approvalStep object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStepCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentPrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule.md)
Retrieve the schedule for an active role assignment operation.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleActivatedUsing](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance.md)
Get the instance of an active role assignment.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceActivatedUsing](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstancePrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedulePrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest.md)
In PIM, read the details of a request for an active and persistent role assignment made through the unifiedRoleAssignmentScheduleRequest object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestActivatedUsing](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestCount](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestPrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestTargetSchedule](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEnterpriseAppRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleDefinition.md)
Get the properties and relationships of a unifiedRoleDefinition object of an RBAC provider.
The following RBAC providers are currently supported:\n- Cloud PC \n- device management (Intune)\n- directory (Azure AD directory roles)\n- entitlement management (Azure AD entitlement management)\n- Exchange Online

### [Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionCount](Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom](Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFromCount](Get-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFromCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule.md)
Read the properties and relationships of an unifiedRoleEligibilitySchedule object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleCount](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleInstance object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceCount](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstancePrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedulePrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleRequest object.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestAppScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestCount](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestPrincipal](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestTargetSchedule](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment.md)
Get transitiveRoleAssignments from roleManagement

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentCount](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentPrincipal](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagement](Get-MgBetaRoleManagementEntitlementManagement.md)
The RbacApplication for Entitlement Management

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespace](Get-MgBetaRoleManagementEntitlementManagementResourceNamespace.md)
Read the properties and relationships of an unifiedRbacResourceNamespace object.

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceCount](Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction](Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Read the properties and relationships of an unifiedRbacResourceAction object.

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionAuthenticationContext](Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionAuthenticationContext.md)
Get authenticationContext from roleManagement

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionCount](Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope](Get-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope.md)
Get resourceScope from roleManagement

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignment](Get-MgBetaRoleManagementEntitlementManagementRoleAssignment.md)
Retrieve the properties and relationships of a unifiedRoleAssignment object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval.md)
Get roleAssignmentApprovals from roleManagement

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep.md)
Retrieve the properties of an approvalStep object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStepCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStepCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentPrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Retrieve the schedule for an active role assignment operation.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Get the instance of an active role assignment.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it is null.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstancePrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedulePrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
In PIM, read the details of a request for an active and persistent role assignment made through the unifiedRoleAssignmentScheduleRequest object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestActivatedUsing.md)
If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation.
Otherwise, it's null.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the assignment is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestCount](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestDirectoryScope.md)
The directory object that is the scope of the assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestPrincipal.md)
The principal that's getting a role assignment through the request.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequestTargetSchedule.md)
The schedule for an eligible role assignment that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEntitlementManagementRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleDefinition.md)
Get the properties and relationships of a unifiedRoleDefinition object of an RBAC provider.
The following RBAC providers are currently supported:\n- Cloud PC \n- device management (Intune)\n- directory (Azure AD directory roles)\n- entitlement management (Azure AD entitlement management)\n- Exchange Online

### [Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionCount](Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Read-only collection of role definitions that the given role definition inherits from.
Only Azure AD built-in roles support this attribute.

### [Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromCount](Get-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Read the properties and relationships of an unifiedRoleEligibilitySchedule object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility or assignment is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleCount](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleDirectoryScope.md)
The directory object that is the scope of the role eligibility or assignment.
Read-only.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleInstance object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceAppScope.md)
Read-only property with details of the app-specific scope when the assignment or role eligibility is scoped to an app.
Nullable.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceCount](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceDirectoryScope.md)
The directory object that is the scope of the assignment or role eligibility.
Read-only.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstancePrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstancePrincipal.md)
The principal that's getting a role assignment or role eligibility through the request.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedulePrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedulePrincipal.md)
The principal that's getting a role assignment or that's eligible for a role through the request.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Read the properties and relationships of an unifiedRoleEligibilityScheduleRequest object.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope.md)
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestCount](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestDirectoryScope.md)
The directory object that is the scope of the role eligibility.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestPrincipal.md)
The principal that's getting a role eligibility through the request.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestRoleDefinition.md)
Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequestTargetSchedule.md)
The schedule for a role eligibility that is referenced through the targetScheduleId property.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRoleDefinition.md)
Detailed information for the roleDefinition object that is referenced through the roleDefinitionId property.

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment.md)
Get transitiveRoleAssignments from roleManagement

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope.md)
Details of the app specific scope when the assignment scope is app specific.
Containment entity.

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentCount](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentCount.md)
Get the number of the resource

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentDirectoryScope](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentDirectoryScope.md)
The directory object that is the scope of the assignment.
Provided so that callers can get the directory object using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentPrincipal](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentPrincipal.md)
The assigned principal.
Provided so that callers can get the principal using $expand at the same time as getting the role assignment.
Read-only.
Supports $expand.

### [Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentRoleDefinition](Get-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentRoleDefinition.md)
The roleDefinition the assignment is for.
Provided so that callers can get the role definition using $expand at the same time as getting the role assignment.
roleDefinition.id will be auto expanded.
Supports $expand.

### [Get-MgBetaUserAgreementAcceptance](Get-MgBetaUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Get-MgBetaUserAgreementAcceptanceCount](Get-MgBetaUserAgreementAcceptanceCount.md)
Get the number of the resource

### [Import-MgBetaRoleManagementCloudPcResourceNamespaceResourceAction](Import-MgBetaRoleManagementCloudPcResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Import-MgBetaRoleManagementDeviceManagementResourceNamespaceResourceAction](Import-MgBetaRoleManagementDeviceManagementResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Import-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction](Import-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Import-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction](Import-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Import-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction](Import-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Import-MgBetaRoleManagementExchangeResourceNamespaceResourceAction](Import-MgBetaRoleManagementExchangeResourceNamespaceResourceAction.md)
Invoke action importResourceActions

### [Initialize-MgBetaIdentityGovernanceLifecycleWorkflow](Initialize-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Run a workflow object on-demand.
You can run any workflow on-demand, including scheduled workflows.
Workflows created from the 'Real-time employee termination' template are run on-demand only.
When you run a workflow on demand, the tasks are executed regardless of whether the user state matches the scope and trigger execution conditions.

### [Initialize-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Initialize-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Run a workflow object on-demand.
You can run any workflow on-demand, including scheduled workflows.
Workflows created from the 'Real-time employee termination' template are run on-demand only.
When you run a workflow on demand, the tasks are executed regardless of whether the user state matches the scope and trigger execution conditions.

### [Invoke-MgBetaAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation](Invoke-MgBetaAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation.md)
Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that have not been reviewed for an accessReviewInstance object for which the calling user is a reviewer.
Recommendations are generated if **recommendationsEnabled** is `true` on the accessReviewScheduleDefinition object.
If there is not a recommendation on an accessReviewInstanceDecisionItem object no decision will be recorded.

### [Invoke-MgBetaAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation](Invoke-MgBetaAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation.md)
Allows the acceptance of recommendations on all accessReviewInstanceDecisionItem objects that have not been reviewed for an accessReviewInstance object for which the calling user is a reviewer.
Recommendations are generated if **recommendationsEnabled** is `true` on the accessReviewScheduleDefinition object.
If there is not a recommendation on an accessReviewInstanceDecisionItem object no decision will be recorded.

### [Invoke-MgBetaAssignedRoleManagementCloudPcRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementCloudPcRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementCloudPcRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementCloudPcRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementDeviceManagementRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementDeviceManagementRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementDeviceManagementRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementDeviceManagementRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementDirectoryRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementDirectoryRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementDirectoryRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementDirectoryRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementEnterpriseAppRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementEnterpriseAppRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementEntitlementManagementRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementEntitlementManagementRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementExchangeRoleDefinitionInheritPermissionFromPrincipal](Invoke-MgBetaAssignedRoleManagementExchangeRoleDefinitionInheritPermissionFromPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaAssignedRoleManagementExchangeRoleDefinitionPrincipal](Invoke-MgBetaAssignedRoleManagementExchangeRoleDefinitionPrincipal.md)
Invoke function assignedPrincipals

### [Invoke-MgBetaBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision](Invoke-MgBetaBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision.md)
Enables reviewers to review all accessReviewInstanceDecisionItem objects in batches by using **principalId**, **resourceId**, or neither.

### [Invoke-MgBetaBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision](Invoke-MgBetaBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision.md)
Enables reviewers to review all accessReviewInstanceDecisionItem objects in batches by using **principalId**, **resourceId**, or neither.

### [Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser](Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentByCurrentUser](Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentRequestByCurrentUser](Invoke-MgBetaFilterEntitlementManagementAccessPackageAssignmentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterEntitlementManagementAccessPackageByCurrentUser](Invoke-MgBetaFilterEntitlementManagementAccessPackageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceDecisionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceStageByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecisionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentApprovalByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentApprovalByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementDirectoryRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentApprovalByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementEnterpriseAppRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentApprovalByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser](Invoke-MgBetaFilterRoleManagementEntitlementManagementRoleEligibilityScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaMyPrivilegedRoleAssignment](Invoke-MgBetaMyPrivilegedRoleAssignment.md)
Invoke function my

### [Invoke-MgBetaMyPrivilegedRoleAssignmentRequest](Invoke-MgBetaMyPrivilegedRoleAssignmentRequest.md)
Invoke function my

### [Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecision](Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecisionInstanceDecision](Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Invoke-MgBetaRecordIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision](Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
As a reviewer of an access review, record a decision for an accessReviewInstanceDecisionItem that is assigned to you and that matches the principal or resource IDs specified.
If no IDs are specified, the decisions will apply to every **accessReviewInstanceDecisionItem** for which you are the reviewer.

### [Invoke-MgBetaRemediateIdentityGovernanceRoleManagementAlertIncident](Invoke-MgBetaRemediateIdentityGovernanceRoleManagementAlertIncident.md)
Invoke action remediate

### [Invoke-MgBetaScheduleRoleManagementDirectory](Invoke-MgBetaScheduleRoleManagementDirectory.md)
Invoke function roleScheduleInstances

### [Invoke-MgBetaScheduleRoleManagementDirectoryRole](Invoke-MgBetaScheduleRoleManagementDirectoryRole.md)
Invoke function roleSchedules

### [Invoke-MgBetaScheduleRoleManagementEnterpriseApp](Invoke-MgBetaScheduleRoleManagementEnterpriseApp.md)
Invoke function roleScheduleInstances

### [Invoke-MgBetaScheduleRoleManagementEnterpriseAppRole](Invoke-MgBetaScheduleRoleManagementEnterpriseAppRole.md)
Invoke function roleSchedules

### [Invoke-MgBetaScheduleRoleManagementEntitlementManagement](Invoke-MgBetaScheduleRoleManagementEntitlementManagement.md)
Invoke function roleScheduleInstances

### [Invoke-MgBetaScheduleRoleManagementEntitlementManagementRole](Invoke-MgBetaScheduleRoleManagementEntitlementManagementRole.md)
Invoke function roleSchedules

### [Invoke-MgBetaSelfPrivilegedApprovalRoleInfoActivate](Invoke-MgBetaSelfPrivilegedApprovalRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgBetaSelfPrivilegedApprovalRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedApprovalRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgBetaSelfPrivilegedRoleActivate](Invoke-MgBetaSelfPrivilegedRoleActivate.md)
Invoke action selfActivate

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoActivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoActivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgBetaSelfPrivilegedRoleDeactivate](Invoke-MgBetaSelfPrivilegedRoleDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowRun](Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowRun.md)
Invoke function summary

### [Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Invoke function summary

### [Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowTaskReport](Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowTaskReport.md)
Invoke function summary

### [Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult](Invoke-MgBetaSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Invoke function summary

### [Move-MgBetaEntitlementManagementAccessPackageToCatalog](Move-MgBetaEntitlementManagementAccessPackageToCatalog.md)
In Azure AD entitlement management, this action moves the accessPackage to a specified target accessPackageCatalog.
The resources in the access package must be present in the target catalog.

### [New-MgBetaAccessReview](New-MgBetaAccessReview.md)
In the Azure AD access reviews feature, create a new accessReview object.
Before making this request, the caller must have previously retrieved the list of business flow templates, to have the value of **businessFlowTemplateId** to include in the request.
After making this request, the caller should create a programControl, to link the access review to a program.

### [New-MgBetaAccessReviewDecision](New-MgBetaAccessReviewDecision.md)
Create new navigation property to decisions for accessReviews

### [New-MgBetaAccessReviewInstance](New-MgBetaAccessReviewInstance.md)
Create new navigation property to instances for accessReviews

### [New-MgBetaAccessReviewInstanceDecision](New-MgBetaAccessReviewInstanceDecision.md)
Create new navigation property to decisions for accessReviews

### [New-MgBetaAccessReviewInstanceMyDecision](New-MgBetaAccessReviewInstanceMyDecision.md)
Create new navigation property to myDecisions for accessReviews

### [New-MgBetaAccessReviewInstanceReviewer](New-MgBetaAccessReviewInstanceReviewer.md)
In the Azure AD access reviews feature, update an existing accessReview object to add another user as a reviewer.
This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified.
This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers.

### [New-MgBetaAccessReviewMyDecision](New-MgBetaAccessReviewMyDecision.md)
Create new navigation property to myDecisions for accessReviews

### [New-MgBetaAccessReviewReviewer](New-MgBetaAccessReviewReviewer.md)
In the Azure AD access reviews feature, update an existing accessReview object to add another user as a reviewer.
This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified.
This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers.

### [New-MgBetaAgreement](New-MgBetaAgreement.md)
Add new entity to agreements

### [New-MgBetaAgreementAcceptance](New-MgBetaAgreementAcceptance.md)
Create new navigation property to acceptances for agreements

### [New-MgBetaAgreementFile](New-MgBetaAgreementFile.md)
Create a new localized agreement file.

### [New-MgBetaAgreementFileLocalization](New-MgBetaAgreementFileLocalization.md)
Create new navigation property to localizations for agreements

### [New-MgBetaAgreementFileLocalizationVersion](New-MgBetaAgreementFileLocalizationVersion.md)
Create new navigation property to versions for agreements

### [New-MgBetaAgreementFileVersion](New-MgBetaAgreementFileVersion.md)
Create new navigation property to versions for agreements

### [New-MgBetaBusinessFlowTemplate](New-MgBetaBusinessFlowTemplate.md)
Add new entity to businessFlowTemplates

### [New-MgBetaEntitlementManagementAccessPackage](New-MgBetaEntitlementManagementAccessPackage.md)
Create a new accessPackage object.
The access package will be added to an existing accessPackageCatalog.
After the access package is created, you can then create accessPackageAssignmentPolicies which specify how users are assigned to the access package.

### [New-MgBetaEntitlementManagementAccessPackageAssignment](New-MgBetaEntitlementManagementAccessPackageAssignment.md)
Create a new entitlement management accessPackageAssignment

### [New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](New-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
In Azure AD entitlement management, create a new accessPackageAssignmentPolicy object.

### [New-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](New-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Create new navigation property to customExtensionHandlers for identityGovernance

### [New-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](New-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Create new navigation property to customExtensionStageSettings for identityGovernance

### [New-MgBetaEntitlementManagementAccessPackageAssignmentRequest](New-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
In Azure AD Entitlement Management, create a new accessPackageAssignmentRequest object.
This operation is used to assign a user to an access package, or to remove an access package assignment.

### [New-MgBetaEntitlementManagementAccessPackageCatalog](New-MgBetaEntitlementManagementAccessPackageCatalog.md)
Create a new accessPackageCatalog object.

### [New-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](New-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Create new navigation property to accessPackageCustomWorkflowExtensions for identityGovernance

### [New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Create a new customAccessPackageWorkflowExtension object and add it to an existing accessPackageCatalog object.

### [New-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Add an accessPackage to the list of access packages that have been marked as incompatible on an accessPackage.

### [New-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Add a group to the list of groups that have been marked as incompatible on an accessPackage.

### [New-MgBetaEntitlementManagementAccessPackageResourceRequest](New-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Create a new accessPackageResourceRequest object to request the addition of a resource to an access package catalog, update of a resource, or the removal of a resource from a catalog.
A resource must be included in an access package catalog before a role of that resource can be added to an access package.

### [New-MgBetaEntitlementManagementAccessPackageResourceRoleScope](New-MgBetaEntitlementManagementAccessPackageResourceRoleScope.md)
Create a new accessPackageResourceRoleScope for adding a resource role to an access package.
The access package resource, for a group, an app, or a SharePoint Online site, must already exist in the access package catalog, and the **originId** for the resource role retrieved from the list of the resource roles.
Once you add the resource role scope to the access package, the user will receive this resource role through any current and future access package assignments.

### [New-MgBetaEntitlementManagementConnectedOrganization](New-MgBetaEntitlementManagementConnectedOrganization.md)
Create a new connectedOrganization object.

### [New-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef](New-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Add a user or a group to the connected organization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Add a user or a group to the connected organization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [New-MgBetaEntitlementManagementSubject](New-MgBetaEntitlementManagementSubject.md)
Create new navigation property to subjects for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecision](New-MgBetaIdentityGovernanceAccessReviewDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInsight](New-MgBetaIdentityGovernanceAccessReviewDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Create new navigation property to contactedReviewers for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](New-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinition](New-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Create a new accessReviewScheduleDefinition object.

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Create new navigation property to contactedReviewers for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](New-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewHistoryDefinition](New-MgBetaIdentityGovernanceAccessReviewHistoryDefinition.md)
Create a new accessReviewHistoryDefinition object.

### [New-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance](New-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri](New-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri.md)
Generates a URI for an accessReviewHistoryInstance object the **status** for which is `done`.
Each URI can be used to retrieve the instance's review history data.
Each URI is valid for 24 hours and can be retrieved by fetching the **downloadUri** property from the accessReviewHistoryInstance object.

### [New-MgBetaIdentityGovernanceAppConsentRequest](New-MgBetaIdentityGovernanceAppConsentRequest.md)
Create new navigation property to appConsentRequests for identityGovernance

### [New-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest](New-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Create new navigation property to userConsentRequests for identityGovernance

### [New-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](New-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Create new navigation property to steps for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflow](New-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Create a new workflow object.
You can create up to 50 workflows in a tenant.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](New-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Create a new customTaskExtension object.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTask](New-MgBetaIdentityGovernanceLifecycleWorkflowTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask](New-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval](New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Create new navigation property to assignmentApprovals for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Create new navigation property to steps for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Create new navigation property to assignmentSchedules for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Create new navigation property to assignmentScheduleInstances for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](New-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Create a new privilegedAccessGroupAssignmentScheduleRequest object.

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Create new navigation property to eligibilitySchedules for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Create new navigation property to eligibilityScheduleInstances for identityGovernance

### [New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](New-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Create a new privilegedAccessGroupEligibilityScheduleRequest object.

### [New-MgBetaIdentityGovernanceRoleManagementAlert](New-MgBetaIdentityGovernanceRoleManagementAlert.md)
Create new navigation property to alerts for identityGovernance

### [New-MgBetaIdentityGovernanceRoleManagementAlertConfiguration](New-MgBetaIdentityGovernanceRoleManagementAlertConfiguration.md)
Create new navigation property to alertConfigurations for identityGovernance

### [New-MgBetaIdentityGovernanceRoleManagementAlertDefinition](New-MgBetaIdentityGovernanceRoleManagementAlertDefinition.md)
Create new navigation property to alertDefinitions for identityGovernance

### [New-MgBetaIdentityGovernanceRoleManagementAlertIncident](New-MgBetaIdentityGovernanceRoleManagementAlertIncident.md)
Create new navigation property to alertIncidents for identityGovernance

### [New-MgBetaIdentityGovernanceRoleManagementAlertOperation](New-MgBetaIdentityGovernanceRoleManagementAlertOperation.md)
Create new navigation property to operations for identityGovernance

### [New-MgBetaIdentityGovernanceTermsOfUseAgreement](New-MgBetaIdentityGovernanceTermsOfUseAgreement.md)
Create a new agreement object.

### [New-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance](New-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Create new navigation property to agreementAcceptances for identityGovernance

### [New-MgBetaIdentityGovernanceTermsOfUseAgreementFile](New-MgBetaIdentityGovernanceTermsOfUseAgreementFile.md)
Create a new localized agreement file.

### [New-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization](New-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Create new navigation property to localizations for identityGovernance

### [New-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](New-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion](New-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgBetaPrivilegedAccess](New-MgBetaPrivilegedAccess.md)
Add new entity to privilegedAccess

### [New-MgBetaPrivilegedAccessResource](New-MgBetaPrivilegedAccessResource.md)
Create new navigation property to resources for privilegedAccess

### [New-MgBetaPrivilegedAccessResourceRoleAssignment](New-MgBetaPrivilegedAccessResourceRoleAssignment.md)
Create new navigation property to roleAssignments for privilegedAccess

### [New-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](New-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
Create new navigation property to roleAssignmentRequests for privilegedAccess

### [New-MgBetaPrivilegedAccessResourceRoleDefinition](New-MgBetaPrivilegedAccessResourceRoleDefinition.md)
Create new navigation property to roleDefinitions for privilegedAccess

### [New-MgBetaPrivilegedAccessResourceRoleSetting](New-MgBetaPrivilegedAccessResourceRoleSetting.md)
Create new navigation property to roleSettings for privilegedAccess

### [New-MgBetaPrivilegedAccessRoleAssignment](New-MgBetaPrivilegedAccessRoleAssignment.md)
Create new navigation property to roleAssignments for privilegedAccess

### [New-MgBetaPrivilegedAccessRoleAssignmentRequest](New-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
Create a role assignment request to represent the operation you want on a role assignment.
The following table lists the operations.

### [New-MgBetaPrivilegedAccessRoleDefinition](New-MgBetaPrivilegedAccessRoleDefinition.md)
Create new navigation property to roleDefinitions for privilegedAccess

### [New-MgBetaPrivilegedAccessRoleSetting](New-MgBetaPrivilegedAccessRoleSetting.md)
Create new navigation property to roleSettings for privilegedAccess

### [New-MgBetaPrivilegedApproval](New-MgBetaPrivilegedApproval.md)
Add new entity to privilegedApproval

### [New-MgBetaPrivilegedOperationEvent](New-MgBetaPrivilegedOperationEvent.md)
Add new entity to privilegedOperationEvents

### [New-MgBetaPrivilegedRole](New-MgBetaPrivilegedRole.md)
Add new entity to privilegedRoles

### [New-MgBetaPrivilegedRoleAssignment](New-MgBetaPrivilegedRoleAssignment.md)
Add new entity to privilegedRoleAssignments

### [New-MgBetaPrivilegedRoleAssignmentEligible](New-MgBetaPrivilegedRoleAssignmentEligible.md)
Invoke action makeEligible

### [New-MgBetaPrivilegedRoleAssignmentPermanent](New-MgBetaPrivilegedRoleAssignmentPermanent.md)
Invoke action makePermanent

### [New-MgBetaPrivilegedRoleAssignmentRequest](New-MgBetaPrivilegedRoleAssignmentRequest.md)
Add new entity to privilegedRoleAssignmentRequests

### [New-MgBetaProgram](New-MgBetaProgram.md)
In the Azure AD access reviews feature, create a new program object.

### [New-MgBetaProgramControl](New-MgBetaProgramControl.md)
In the Azure AD access reviews feature, create a new programControl object.
This links an access review to a program.
Prior to making this request, the caller must have previously

### [New-MgBetaProgramControlType](New-MgBetaProgramControlType.md)
Add new entity to programControlTypes

### [New-MgBetaRoleManagementDirectoryResourceNamespace](New-MgBetaRoleManagementDirectoryResourceNamespace.md)
Create new navigation property to resourceNamespaces for roleManagement

### [New-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction](New-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction.md)
Create new navigation property to resourceActions for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleAssignment](New-MgBetaRoleManagementDirectoryRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgBetaRoleManagementDirectoryRoleAssignmentApproval](New-MgBetaRoleManagementDirectoryRoleAssignmentApproval.md)
Create new navigation property to roleAssignmentApprovals for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep](New-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep.md)
Create new navigation property to steps for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleAssignmentSchedule](New-MgBetaRoleManagementDirectoryRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance](New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest](New-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Create a new unifiedRoleAssignmentScheduleRequest object.
This operation allows both admins and users to add, remove, extend, or renew assignments.
To run this request, the calling user must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgBetaRoleManagementDirectoryRoleDefinition](New-MgBetaRoleManagementDirectoryRoleDefinition.md)
Create a new unifiedRoleDefinition object for an RBAC provider.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [New-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](New-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleEligibilitySchedule](New-MgBetaRoleManagementDirectoryRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance](New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest](New-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Create a new unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [New-MgBetaRoleManagementDirectoryTransitiveRoleAssignment](New-MgBetaRoleManagementDirectoryTransitiveRoleAssignment.md)
Create new navigation property to transitiveRoleAssignments for roleManagement

### [New-MgBetaRoleManagementEnterpriseApp](New-MgBetaRoleManagementEnterpriseApp.md)
Create new navigation property to enterpriseApps for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppResourceNamespace](New-MgBetaRoleManagementEnterpriseAppResourceNamespace.md)
Create new navigation property to resourceNamespaces for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction](New-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction.md)
Create new navigation property to resourceActions for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignment](New-MgBetaRoleManagementEnterpriseAppRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval](New-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval.md)
Create new navigation property to roleAssignmentApprovals for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep](New-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep.md)
Create new navigation property to steps for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule](New-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance](New-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest](New-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest.md)
Create a new unifiedRoleAssignmentScheduleRequest object.
This operation allows both admins and users to add, remove, extend, or renew assignments.
To run this request, the calling user must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgBetaRoleManagementEnterpriseAppRoleDefinition](New-MgBetaRoleManagementEnterpriseAppRoleDefinition.md)
Create a new unifiedRoleDefinition object for an RBAC provider.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [New-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom](New-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule](New-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance](New-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest](New-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest.md)
Create a new unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [New-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment](New-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment.md)
Create new navigation property to transitiveRoleAssignments for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementResourceNamespace](New-MgBetaRoleManagementEntitlementManagementResourceNamespace.md)
Create new navigation property to resourceNamespaces for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction](New-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Create new navigation property to resourceActions for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignment](New-MgBetaRoleManagementEntitlementManagementRoleAssignment.md)
Create a new unifiedRoleAssignment object.

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval](New-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval.md)
Create new navigation property to roleAssignmentApprovals for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep](New-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep.md)
Create new navigation property to steps for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule](New-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Create new navigation property to roleAssignmentSchedules for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](New-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Create new navigation property to roleAssignmentScheduleInstances for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](New-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Create a new unifiedRoleAssignmentScheduleRequest object.
This operation allows both admins and users to add, remove, extend, or renew assignments.
To run this request, the calling user must have multi-factor authentication (MFA) enforced, and running the query in a session in which they were challenged for MFA.
See Enable per-user Azure AD Multi-Factor Authentication to secure sign-in events.

### [New-MgBetaRoleManagementEntitlementManagementRoleDefinition](New-MgBetaRoleManagementEntitlementManagementRoleDefinition.md)
Create a new unifiedRoleDefinition object for an RBAC provider.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [New-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](New-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Create new navigation property to inheritsPermissionsFrom for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule](New-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Create new navigation property to roleEligibilitySchedules for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](New-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Create new navigation property to roleEligibilityScheduleInstances for roleManagement

### [New-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](New-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Create a new unifiedRoleEligibilityScheduleRequest object.
This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.

### [New-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment](New-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment.md)
Create new navigation property to transitiveRoleAssignments for roleManagement

### [Register-MgBetaPrivilegedAccessResource](Register-MgBetaPrivilegedAccessResource.md)
Invoke action register

### [Remove-MgBetaAccessReview](Remove-MgBetaAccessReview.md)
In the Azure AD access reviews feature, delete an accessReview object.

### [Remove-MgBetaAccessReviewDecision](Remove-MgBetaAccessReviewDecision.md)
Delete navigation property decisions for accessReviews

### [Remove-MgBetaAccessReviewInstance](Remove-MgBetaAccessReviewInstance.md)
Delete navigation property instances for accessReviews

### [Remove-MgBetaAccessReviewInstanceDecision](Remove-MgBetaAccessReviewInstanceDecision.md)
Delete navigation property decisions for accessReviews

### [Remove-MgBetaAccessReviewInstanceMyDecision](Remove-MgBetaAccessReviewInstanceMyDecision.md)
Delete navigation property myDecisions for accessReviews

### [Remove-MgBetaAccessReviewInstanceReviewer](Remove-MgBetaAccessReviewInstanceReviewer.md)
In the Azure AD access reviews feature, update an existing accessReview object to remove a user as a reviewer.
This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified.
This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers.

### [Remove-MgBetaAccessReviewMyDecision](Remove-MgBetaAccessReviewMyDecision.md)
Delete navigation property myDecisions for accessReviews

### [Remove-MgBetaAccessReviewReviewer](Remove-MgBetaAccessReviewReviewer.md)
In the Azure AD access reviews feature, update an existing accessReview object to remove a user as a reviewer.
This operation is only permitted for an access review that is not yet completed, and only for an access review where the reviewers are explicitly specified.
This operation is not permitted for an access review in which users review their own access, and not intended for an access review in which the group owners are assigned as the reviewers.

### [Remove-MgBetaAgreement](Remove-MgBetaAgreement.md)
Delete entity from agreements

### [Remove-MgBetaAgreementAcceptance](Remove-MgBetaAgreementAcceptance.md)
Delete navigation property acceptances for agreements

### [Remove-MgBetaAgreementFile](Remove-MgBetaAgreementFile.md)
Delete navigation property file for agreements

### [Remove-MgBetaAgreementFileLocalization](Remove-MgBetaAgreementFileLocalization.md)
Delete navigation property localizations for agreements

### [Remove-MgBetaAgreementFileLocalizationVersion](Remove-MgBetaAgreementFileLocalizationVersion.md)
Delete navigation property versions for agreements

### [Remove-MgBetaAgreementFileVersion](Remove-MgBetaAgreementFileVersion.md)
Delete navigation property versions for agreements

### [Remove-MgBetaBusinessFlowTemplate](Remove-MgBetaBusinessFlowTemplate.md)
Delete entity from businessFlowTemplates

### [Remove-MgBetaEntitlementManagementAccessPackage](Remove-MgBetaEntitlementManagementAccessPackage.md)
Delete an accessPackage object.
You cannot delete an access package if it has any **accessPackageAssignment**.
To delete the access package, first query if there are any assignments with a filter to indicate the specific access package, such as: `$filter=accessPackage/id eq 'a914b616-e04e-476b-aa37-91038f0b165b'`.
For more information on how to remove assignments that are still in the delivered state, see Remove an assignment.

### [Remove-MgBetaEntitlementManagementAccessPackageAssignment](Remove-MgBetaEntitlementManagementAccessPackageAssignment.md)
Delete navigation property accessPackageAssignments for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentApproval](Remove-MgBetaEntitlementManagementAccessPackageAssignmentApproval.md)
Delete navigation property accessPackageAssignmentApprovals for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep](Remove-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
In Azure AD entitlement management, delete an accessPackageAssignmentPolicy.

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Delete navigation property customExtensionHandlers for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Delete navigation property customExtensionStageSettings for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Remove-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
Delete an accessPackageAssignmentRequest object.
This request can be made to remove a denied or completed request.
You cannot delete an access package assignment request if it has any **accessPackageAssignment** objects.

### [Remove-MgBetaEntitlementManagementAccessPackageCatalog](Remove-MgBetaEntitlementManagementAccessPackageCatalog.md)
Delete an accessPackageCatalog.

### [Remove-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Remove-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Delete navigation property accessPackageCustomWorkflowExtensions for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Remove-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Delete an accessPackageAssignmentWorkflowExtension object.
The custom workflow extension must first be removed from any associated policies before it can be deleted.
Follow these steps to remove the custom workflow extension from any associated policies:\n1.
First retrieve the accessPackageCatalogId by calling the Get accessPackageAssignmentPolicies operation and appending `?$expand=accessPackage($expand=accessPackageCatalog)` to the query.
For example, `https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies?$expand=accessPackage($expand=accessPackageCatalog)`.\n2.
Use the access package catalog ID and retrieve the ID of the **accessPackageCustomWorkflowExtension** object that you want to delete by running the List accessPackageCustomWorkflowExtensions operation.\n3.
Call the Update accessPackageAssignmentPolicy operation to remove the custom workflow extension object from the policy.
For an example, see Example 3: Remove the customExtensionStageSettings from a policy.

### [Remove-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Remove-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Remove an access package from the list of access packages that have been marked as incompatible on an accessPackage.

### [Remove-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef](Remove-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Remove a group from the list of groups that have been marked as incompatible on an accessPackage.

### [Remove-MgBetaEntitlementManagementAccessPackageResourceRequest](Remove-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Delete navigation property accessPackageResourceRequests for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageResourceRoleScope](Remove-MgBetaEntitlementManagementAccessPackageResourceRoleScope.md)
Delete navigation property accessPackageResourceRoleScopes for identityGovernance

### [Remove-MgBetaEntitlementManagementConnectedOrganization](Remove-MgBetaEntitlementManagementConnectedOrganization.md)
Delete a connectedOrganization object.

### [Remove-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef](Remove-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Remove a user or a group from the connected organization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Remove-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](Remove-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Remove a user or a group from the connected organization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Remove-MgBetaEntitlementManagementSubject](Remove-MgBetaEntitlementManagementSubject.md)
Delete navigation property subjects for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecision](Remove-MgBetaIdentityGovernanceAccessReviewDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInsight](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstance](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstance.md)
Delete navigation property instance for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Remove-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinition](Remove-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Delete an accessReviewScheduleDefinition object.

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
Delete navigation property instance for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance](Remove-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance.md)
Delete navigation property instance for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewHistoryDefinition](Remove-MgBetaIdentityGovernanceAccessReviewHistoryDefinition.md)
Delete navigation property historyDefinitions for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance](Remove-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgBetaIdentityGovernanceAccessReviewPolicy](Remove-MgBetaIdentityGovernanceAccessReviewPolicy.md)
Delete navigation property policy for identityGovernance

### [Remove-MgBetaIdentityGovernanceAppConsentRequest](Remove-MgBetaIdentityGovernanceAppConsentRequest.md)
Delete navigation property appConsentRequests for identityGovernance

### [Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest](Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Delete navigation property userConsentRequests for identityGovernance

### [Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Delete navigation property approval for identityGovernance

### [Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Remove-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflow](Remove-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Delete a workflow object and its associated tasks, taskProcessingResults and versions.
You can restore a deleted workflow and its associated objects within 30 days of deletion.

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Remove-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Delete a customTaskExtension object.
Can only be deleted if it is not referenced in any task objects in a lifecycle workflow.

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Delete navigation property deletedItems for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Delete a workflow object.

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTask](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask](Remove-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccess](Remove-MgBetaIdentityGovernancePrivilegedAccess.md)
Delete navigation property privilegedAccess for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroup](Remove-MgBetaIdentityGovernancePrivilegedAccessGroup.md)
Delete navigation property group for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Delete navigation property assignmentApprovals for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Delete navigation property assignmentSchedules for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Delete navigation property assignmentScheduleInstances for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Delete navigation property assignmentScheduleRequests for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Delete navigation property eligibilitySchedules for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Delete navigation property eligibilityScheduleInstances for identityGovernance

### [Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Remove-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Delete navigation property eligibilityScheduleRequests for identityGovernance

### [Remove-MgBetaIdentityGovernanceRoleManagementAlert](Remove-MgBetaIdentityGovernanceRoleManagementAlert.md)
Delete navigation property alerts for identityGovernance

### [Remove-MgBetaIdentityGovernanceRoleManagementAlertConfiguration](Remove-MgBetaIdentityGovernanceRoleManagementAlertConfiguration.md)
Delete navigation property alertConfigurations for identityGovernance

### [Remove-MgBetaIdentityGovernanceRoleManagementAlertDefinition](Remove-MgBetaIdentityGovernanceRoleManagementAlertDefinition.md)
Delete navigation property alertDefinitions for identityGovernance

### [Remove-MgBetaIdentityGovernanceRoleManagementAlertIncident](Remove-MgBetaIdentityGovernanceRoleManagementAlertIncident.md)
Delete navigation property alertIncidents for identityGovernance

### [Remove-MgBetaIdentityGovernanceRoleManagementAlertOperation](Remove-MgBetaIdentityGovernanceRoleManagementAlertOperation.md)
Delete navigation property operations for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreement](Remove-MgBetaIdentityGovernanceTermsOfUseAgreement.md)
Delete an agreement object.

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance](Remove-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Delete navigation property agreementAcceptances for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFile](Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFile.md)
Delete navigation property file for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization](Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Delete navigation property localizations for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion](Remove-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgBetaPrivilegedAccess](Remove-MgBetaPrivilegedAccess.md)
Delete entity from privilegedAccess

### [Remove-MgBetaPrivilegedAccessResource](Remove-MgBetaPrivilegedAccessResource.md)
Delete navigation property resources for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignment](Remove-MgBetaPrivilegedAccessResourceRoleAssignment.md)
Delete navigation property roleAssignments for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
Delete navigation property roleAssignmentRequests for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject](Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition](Remove-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleAssignmentSubject](Remove-MgBetaPrivilegedAccessResourceRoleAssignmentSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleDefinition](Remove-MgBetaPrivilegedAccessResourceRoleDefinition.md)
Delete navigation property roleDefinitions for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleSetting](Remove-MgBetaPrivilegedAccessResourceRoleSetting.md)
Delete navigation property roleSettings for privilegedAccess

### [Remove-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition](Remove-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignment](Remove-MgBetaPrivilegedAccessRoleAssignment.md)
Delete navigation property roleAssignments for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignmentRequest](Remove-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
Delete navigation property roleAssignmentRequests for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition](Remove-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignmentRequestSubject](Remove-MgBetaPrivilegedAccessRoleAssignmentRequestSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition](Remove-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleAssignmentSubject](Remove-MgBetaPrivilegedAccessRoleAssignmentSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleDefinition](Remove-MgBetaPrivilegedAccessRoleDefinition.md)
Delete navigation property roleDefinitions for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleSetting](Remove-MgBetaPrivilegedAccessRoleSetting.md)
Delete navigation property roleSettings for privilegedAccess

### [Remove-MgBetaPrivilegedAccessRoleSettingRoleDefinition](Remove-MgBetaPrivilegedAccessRoleSettingRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgBetaPrivilegedApproval](Remove-MgBetaPrivilegedApproval.md)
Delete entity from privilegedApproval

### [Remove-MgBetaPrivilegedApprovalRoleInfo](Remove-MgBetaPrivilegedApprovalRoleInfo.md)
Delete navigation property roleInfo for privilegedApproval

### [Remove-MgBetaPrivilegedApprovalRoleInfoSetting](Remove-MgBetaPrivilegedApprovalRoleInfoSetting.md)
Delete navigation property settings for privilegedApproval

### [Remove-MgBetaPrivilegedApprovalRoleInfoSummary](Remove-MgBetaPrivilegedApprovalRoleInfoSummary.md)
Delete navigation property summary for privilegedApproval

### [Remove-MgBetaPrivilegedOperationEvent](Remove-MgBetaPrivilegedOperationEvent.md)
Delete entity from privilegedOperationEvents

### [Remove-MgBetaPrivilegedRole](Remove-MgBetaPrivilegedRole.md)
Delete entity from privilegedRoles

### [Remove-MgBetaPrivilegedRoleAssignment](Remove-MgBetaPrivilegedRoleAssignment.md)
Delete entity from privilegedRoleAssignments

### [Remove-MgBetaPrivilegedRoleAssignmentRequest](Remove-MgBetaPrivilegedRoleAssignmentRequest.md)
Delete entity from privilegedRoleAssignmentRequests

### [Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfo](Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfo.md)
Delete navigation property roleInfo for privilegedRoleAssignmentRequests

### [Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting](Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Delete navigation property settings for privilegedRoleAssignmentRequests

### [Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary](Remove-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Delete navigation property summary for privilegedRoleAssignmentRequests

### [Remove-MgBetaPrivilegedRoleAssignmentRoleInfo](Remove-MgBetaPrivilegedRoleAssignmentRoleInfo.md)
Delete navigation property roleInfo for privilegedRoleAssignments

### [Remove-MgBetaPrivilegedRoleAssignmentRoleInfoSetting](Remove-MgBetaPrivilegedRoleAssignmentRoleInfoSetting.md)
Delete navigation property settings for privilegedRoleAssignments

### [Remove-MgBetaPrivilegedRoleAssignmentRoleInfoSummary](Remove-MgBetaPrivilegedRoleAssignmentRoleInfoSummary.md)
Delete navigation property summary for privilegedRoleAssignments

### [Remove-MgBetaPrivilegedRoleSetting](Remove-MgBetaPrivilegedRoleSetting.md)
Delete navigation property settings for privilegedRoles

### [Remove-MgBetaPrivilegedRoleSummary](Remove-MgBetaPrivilegedRoleSummary.md)
Delete navigation property summary for privilegedRoles

### [Remove-MgBetaProgram](Remove-MgBetaProgram.md)
In the Azure AD access reviews feature, delete a program object.
Do not delete a program which still has `programControl` linked to it, those access reviews should first be deleted or unlinked from the program and linked to a different program.
Also, please note that the built-in default program cannot be deleted.

### [Remove-MgBetaProgramControl](Remove-MgBetaProgramControl.md)
In the Azure AD access reviews feature, delete a programControl object.
This unlinks an access review from a program.

### [Remove-MgBetaProgramControlProgram](Remove-MgBetaProgramControlProgram.md)
Delete navigation property program for programControls

### [Remove-MgBetaProgramControlType](Remove-MgBetaProgramControlType.md)
Delete entity from programControlTypes

### [Remove-MgBetaRoleManagementDirectory](Remove-MgBetaRoleManagementDirectory.md)
Delete navigation property directory for roleManagement

### [Remove-MgBetaRoleManagementDirectoryResourceNamespace](Remove-MgBetaRoleManagementDirectoryResourceNamespace.md)
Delete navigation property resourceNamespaces for roleManagement

### [Remove-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction](Remove-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction.md)
Delete navigation property resourceActions for roleManagement

### [Remove-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope](Remove-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope.md)
Delete navigation property resourceScope for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignment](Remove-MgBetaRoleManagementDirectoryRoleAssignment.md)
Delete a unifiedRoleAssignment object.

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentApproval](Remove-MgBetaRoleManagementDirectoryRoleAssignmentApproval.md)
Delete navigation property roleAssignmentApprovals for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep](Remove-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep.md)
Delete navigation property steps for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentAppScope](Remove-MgBetaRoleManagementDirectoryRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentSchedule](Remove-MgBetaRoleManagementDirectoryRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance](Remove-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest](Remove-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleDefinition](Remove-MgBetaRoleManagementDirectoryRoleDefinition.md)
Delete a unifiedRoleDefinition object for an RBAC provider.
You cannot delete built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Remove-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Remove-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleEligibilitySchedule](Remove-MgBetaRoleManagementDirectoryRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance](Remove-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest](Remove-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementDirectoryTransitiveRoleAssignment](Remove-MgBetaRoleManagementDirectoryTransitiveRoleAssignment.md)
Delete navigation property transitiveRoleAssignments for roleManagement

### [Remove-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope](Remove-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseApp](Remove-MgBetaRoleManagementEnterpriseApp.md)
Delete navigation property enterpriseApps for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppResourceNamespace](Remove-MgBetaRoleManagementEnterpriseAppResourceNamespace.md)
Delete navigation property resourceNamespaces for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction](Remove-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction.md)
Delete navigation property resourceActions for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope](Remove-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope.md)
Delete navigation property resourceScope for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignment](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignment.md)
Delete a unifiedRoleAssignment object.

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval.md)
Delete navigation property roleAssignmentApprovals for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep.md)
Delete navigation property steps for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest](Remove-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleDefinition](Remove-MgBetaRoleManagementEnterpriseAppRoleDefinition.md)
Delete a unifiedRoleDefinition object for an RBAC provider.
You cannot delete built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Remove-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom](Remove-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule](Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance](Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest](Remove-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment](Remove-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment.md)
Delete navigation property transitiveRoleAssignments for roleManagement

### [Remove-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope](Remove-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagement](Remove-MgBetaRoleManagementEntitlementManagement.md)
Delete navigation property entitlementManagement for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementResourceNamespace](Remove-MgBetaRoleManagementEntitlementManagementResourceNamespace.md)
Delete navigation property resourceNamespaces for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction](Remove-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Delete navigation property resourceActions for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope](Remove-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope.md)
Delete navigation property resourceScope for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignment](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignment.md)
Delete a unifiedRoleAssignment object.

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval.md)
Delete navigation property roleAssignmentApprovals for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep.md)
Delete navigation property steps for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Delete navigation property roleAssignmentSchedules for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Delete navigation property roleAssignmentScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Remove-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Delete navigation property roleAssignmentScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleDefinition](Remove-MgBetaRoleManagementEntitlementManagementRoleDefinition.md)
Delete a unifiedRoleDefinition object for an RBAC provider.
You cannot delete built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Remove-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Remove-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Delete navigation property inheritsPermissionsFrom for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule](Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Delete navigation property roleEligibilitySchedules for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Delete navigation property roleEligibilityScheduleInstances for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Remove-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Delete navigation property roleEligibilityScheduleRequests for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment](Remove-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment.md)
Delete navigation property transitiveRoleAssignments for roleManagement

### [Remove-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope](Remove-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope.md)
Delete navigation property appScope for roleManagement

### [Request-MgBetaPrivilegedApprovalMy](Request-MgBetaPrivilegedApprovalMy.md)
Invoke function myRequests

### [Reset-MgBetaAccessReviewDecision](Reset-MgBetaAccessReviewDecision.md)
In the Azure AD access reviews feature, reset the decisions of a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
Previous decisions are no longer recorded, but reviewers can continue to update decisions.

### [Reset-MgBetaAccessReviewInstanceDecision](Reset-MgBetaAccessReviewInstanceDecision.md)
In the Azure AD access reviews feature, reset the decisions of a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
Previous decisions are no longer recorded, but reviewers can continue to update decisions.

### [Reset-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Reset-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to `notReviewed`.

### [Reset-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Reset-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Resets decisions of all accessReviewInstanceDecisionItem objects on an accessReviewInstance to `notReviewed`.

### [Restore-MgBetaIdentityGovernanceLifecycleWorkflow](Restore-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Restore a workflow that has been deleted.
You can only restore a workflow that was deleted within the last 30 days before Azure AD automatically permanently deletes it.

### [Restore-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Restore-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Restore a workflow that has been deleted.
You can only restore a workflow that was deleted within the last 30 days before Azure AD automatically permanently deletes it.

### [Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
In Azure AD entitlement management, when an access package policy has been enabled to call out a custom extension and the request processing is waiting for the callback from the customer, the customer can initiate a resume action.
It is performed on an accessPackageAssignmentRequest object whose **requestStatus** is in a `WaitingForCallback` state.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information read about Lifecycle Workflows extensibility approach.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information read about Lifecycle Workflows extensibility approach.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information read about Lifecycle Workflows extensibility approach.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information read about Lifecycle Workflows extensibility approach.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information read about Lifecycle Workflows extensibility approach.

### [Select-MgBetaEntitlementManagementAccessPackage](Select-MgBetaEntitlementManagementAccessPackage.md)
Select matching entitlement management accessPackage

### [Select-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Select-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Select matching entitlement management accessPackageAssignmentPolicy

### [Send-MgBetaAccessReviewInstanceReminder](Send-MgBetaAccessReviewInstanceReminder.md)
In the Azure AD access reviews feature, send a reminder to the reviewers of a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.

### [Send-MgBetaAccessReviewReminder](Send-MgBetaAccessReviewReminder.md)
In the Azure AD access reviews feature, send a reminder to the reviewers of a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.

### [Send-MgBetaIdentityGovernanceAccessReviewDecisionInstanceReminder](Send-MgBetaIdentityGovernanceAccessReviewDecisionInstanceReminder.md)
Send a reminder to the reviewers of a currently active accessReviewInstance.

### [Send-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceReminder](Send-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceReminder.md)
Send a reminder to the reviewers of a currently active accessReviewInstance.

### [Set-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Set-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

### [Split-MgBetaEntitlementManagementConnectedOrganization](Split-MgBetaEntitlementManagementConnectedOrganization.md)
Split elements of a connectedOrganization

### [Stop-MgBetaAccessReview](Stop-MgBetaAccessReview.md)
In the Azure AD access reviews feature, stop a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
(To prevent a recurring access review from starting future instances, update it to change its scheduled end date).
After the access review stops, reviewers can no longer give input, and the access review decisions can be applied.

### [Stop-MgBetaAccessReviewInstance](Stop-MgBetaAccessReviewInstance.md)
In the Azure AD access reviews feature, stop a currently active accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
(To prevent a recurring access review from starting future instances, update it to change its scheduled end date).
After the access review stops, reviewers can no longer give input, and the access review decisions can be applied.

### [Stop-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Stop-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
In Azure AD Entitlement Management, cancel accessPackageAssignmentRequest objects that are in a cancellable state: `accepted`, `pendingApproval`, `pendingNotBefore`, `pendingApprovalEscalated`.

### [Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstance](Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstance.md)
Stop a currently active accessReviewInstance.
After the access review instance stops, the instance status will be `Completed`, the reviewers can no longer give input, and the access review decisions can be applied.
Stopping an instance will not effect future instances.
To prevent a recurring access review from starting future instances, update the schedule definition to change its scheduled end date.

### [Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstanceApplyDecision](Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstanceApplyDecision.md)
Invoke action stopApplyDecisions

### [Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](Stop-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Stop an access review stage that is `inProgress`.
After the access review stage stops, the stage **status** will be `Completed` and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Stop-MgBetaIdentityGovernanceAccessReviewDefinition](Stop-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Invoke action stop

### [Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Stop a currently active accessReviewInstance.
After the access review instance stops, the instance status will be `Completed`, the reviewers can no longer give input, and the access review decisions can be applied.
Stopping an instance will not effect future instances.
To prevent a recurring access review from starting future instances, update the schedule definition to change its scheduled end date.

### [Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceApplyDecision](Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceApplyDecision.md)
Invoke action stopApplyDecisions

### [Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Stop an access review stage that is `inProgress`.
After the access review stage stops, the stage **status** will be `Completed` and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Stop-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Stop-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Cancel an access assignment request to a group whose membership and ownership are governed by PIM.

### [Stop-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Stop-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Cancel an eligibility assignment request to a group whose membership and ownership are governed by PIM.

### [Stop-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Stop-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgBetaPrivilegedAccessRoleAssignmentRequest](Stop-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgBetaPrivilegedRoleAssignmentRequest](Stop-MgBetaPrivilegedRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest](Stop-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.

### [Stop-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest](Stop-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest that is in a `Granted` status, and have the system automatically delete the cancelled request after 30 days.
After calling this action, the **status** of the cancelled unifiedRoleEligibilityScheduleRequest changes to `Revoked`.

### [Stop-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest](Stop-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.

### [Stop-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest](Stop-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest that is in a `Granted` status, and have the system automatically delete the cancelled request after 30 days.
After calling this action, the **status** of the cancelled unifiedRoleEligibilityScheduleRequest changes to `Revoked`.

### [Stop-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Stop-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Immediately cancel a unifiedRoleAssignmentScheduleRequest object that is in a `Granted` status, and have the system automatically delete the canceled request after 30 days.
After calling this action, the **status** of the canceled **unifiedRoleAssignmentScheduleRequest** changes to `Canceled`.

### [Stop-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Stop-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Immediately cancel a unifiedRoleEligibilityScheduleRequest that is in a `Granted` status, and have the system automatically delete the cancelled request after 30 days.
After calling this action, the **status** of the cancelled unifiedRoleEligibilityScheduleRequest changes to `Revoked`.

### [Test-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorProperty](Test-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Test-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorProperty](Test-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorProperty.md)
Validate that a Microsoft 365 group's display name or mail nickname complies with naming policies.
Clients can use this API to determine whether a display name or mail nickname is valid before trying to **create** a Microsoft 365 group.
For validating properties of an existing group, use the validateProperties function for groups.
The following validations are performed for the display name and mail nickname properties: \n1.
Validate the prefix and suffix naming policy\n2.
Validate the custom banned words policy\n3.
Validate the mail nickname is unique This API returns with the first failure encountered.
If one or more properties fail multiple validations, only the property with the first validation failure is returned.
However, you can validate both the mail nickname and the display name and receive a collection of validation errors if you are only validating the prefix and suffix naming policy.

### [Update-MgBetaAccessReview](Update-MgBetaAccessReview.md)
In the Azure AD access reviews feature, update an existing accessReview object to change one or more of its properties.
This API is not intended to change the reviewers or decisions of a review.
To change the reviewers, use the addReviewer or removeReviewer APIs.
To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API.
To apply the decisions to the target group or app access rights, use the apply API.

### [Update-MgBetaAccessReviewDecision](Update-MgBetaAccessReviewDecision.md)
Update the navigation property decisions in accessReviews

### [Update-MgBetaAccessReviewInstance](Update-MgBetaAccessReviewInstance.md)
Update the navigation property instances in accessReviews

### [Update-MgBetaAccessReviewInstanceDecision](Update-MgBetaAccessReviewInstanceDecision.md)
Update the navigation property decisions in accessReviews

### [Update-MgBetaAccessReviewInstanceMyDecision](Update-MgBetaAccessReviewInstanceMyDecision.md)
Update the navigation property myDecisions in accessReviews

### [Update-MgBetaAccessReviewInstanceReviewer](Update-MgBetaAccessReviewInstanceReviewer.md)
Update the navigation property reviewers in accessReviews

### [Update-MgBetaAccessReviewMyDecision](Update-MgBetaAccessReviewMyDecision.md)
Update the navigation property myDecisions in accessReviews

### [Update-MgBetaAccessReviewReviewer](Update-MgBetaAccessReviewReviewer.md)
Update the navigation property reviewers in accessReviews

### [Update-MgBetaAgreement](Update-MgBetaAgreement.md)
Update entity in agreements

### [Update-MgBetaAgreementAcceptance](Update-MgBetaAgreementAcceptance.md)
Update the navigation property acceptances in agreements

### [Update-MgBetaAgreementFile](Update-MgBetaAgreementFile.md)
Update the navigation property file in agreements

### [Update-MgBetaAgreementFileLocalization](Update-MgBetaAgreementFileLocalization.md)
Update the navigation property localizations in agreements

### [Update-MgBetaAgreementFileLocalizationVersion](Update-MgBetaAgreementFileLocalizationVersion.md)
Update the navigation property versions in agreements

### [Update-MgBetaAgreementFileVersion](Update-MgBetaAgreementFileVersion.md)
Update the navigation property versions in agreements

### [Update-MgBetaBusinessFlowTemplate](Update-MgBetaBusinessFlowTemplate.md)
Update entity in businessFlowTemplates

### [Update-MgBetaEntitlementManagementAccessPackage](Update-MgBetaEntitlementManagementAccessPackage.md)
Update an existing accessPackage object to change one or more of its properties, such as the display name or description.

### [Update-MgBetaEntitlementManagementAccessPackageAssignment](Update-MgBetaEntitlementManagementAccessPackageAssignment.md)
Invoke action reprocess

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentApproval](Update-MgBetaEntitlementManagementAccessPackageAssignmentApproval.md)
Update the navigation property accessPackageAssignmentApprovals in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep](Update-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Update the navigation property customExtensionHandlers in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Update the navigation property customExtensionStageSettings in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Update-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action reprocess

### [Update-MgBetaEntitlementManagementAccessPackageCatalog](Update-MgBetaEntitlementManagementAccessPackageCatalog.md)
Update an existing accessPackageCatalog object to change one or more of its properties, such as the display name or description.

### [Update-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Update-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Update the properties of an accessPackageAssignmentRequestWorkflowExtension object.

### [Update-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Update-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Update the properties of an existing customAccessPackageWorkflowExtension object.

### [Update-MgBetaEntitlementManagementAccessPackageResourceRequest](Update-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Update the navigation property accessPackageResourceRequests in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageResourceRoleScope](Update-MgBetaEntitlementManagementAccessPackageResourceRoleScope.md)
Update the navigation property accessPackageResourceRoleScopes in identityGovernance

### [Update-MgBetaEntitlementManagementConnectedOrganization](Update-MgBetaEntitlementManagementConnectedOrganization.md)
Update a connectedOrganization object to change one or more of its properties.

### [Update-MgBetaEntitlementManagementSetting](Update-MgBetaEntitlementManagementSetting.md)
Update an existing entitlementManagementSettings object to change one or more of its properties.

### [Update-MgBetaEntitlementManagementSubject](Update-MgBetaEntitlementManagementSubject.md)
Update the navigation property subjects in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecision](Update-MgBetaIdentityGovernanceAccessReviewDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstance](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Update the properties of an accessReviewStage object.
Only the **reviewers** and **fallbackReviewers** properties can be updated.
You can only add reviewers to the **fallbackReviewers** property but can't remove existing **fallbackReviewers**.
To update an **accessReviewStage**, its **status** must be `NotStarted`, `Initializing`, or `InProgress`.

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Update access decisions, known as accessReviewInstanceDecisionItems, for which the user is the reviewer.

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinition](Update-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Update an existing accessReviewScheduleDefinition object to change one or more of its properties.

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Update the properties of an accessReviewInstance object.
Only the **reviewers** and **fallbackReviewers** properties can be updated but the **scope** property is also required in the request body.
You can only add reviewers to the **fallbackReviewers** property but can't remove existing **fallbackReviewers**.
To update an **accessReviewInstance**, it's **status** must be `InProgress`.

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Update the properties of an accessReviewStage object.
Only the **reviewers** and **fallbackReviewers** properties can be updated.
You can only add reviewers to the **fallbackReviewers** property but can't remove existing **fallbackReviewers**.
To update an **accessReviewStage**, its **status** must be `NotStarted`, `Initializing`, or `InProgress`.

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Update access decisions, known as accessReviewInstanceDecisionItems, for which the user is the reviewer.

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewHistoryDefinition](Update-MgBetaIdentityGovernanceAccessReviewHistoryDefinition.md)
Update the navigation property historyDefinitions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance](Update-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewPolicy](Update-MgBetaIdentityGovernanceAccessReviewPolicy.md)
Update the properties of an accessReviewPolicy object.

### [Update-MgBetaIdentityGovernanceAppConsentRequest](Update-MgBetaIdentityGovernanceAppConsentRequest.md)
Update the navigation property appConsentRequests in identityGovernance

### [Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest](Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Update the navigation property userConsentRequests in identityGovernance

### [Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Update the navigation property approval in identityGovernance

### [Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Update-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflow](Update-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Update the properties of a workflow object.
Only the properties listed in the request body table can be updated.
To update any other workflow properties, see workflow: createNewVersion.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Update the properties of a customTaskExtension object.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting.md)
Update the properties of a lifecycleManagementSettings object.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTask](Update-MgBetaIdentityGovernanceLifecycleWorkflowTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask](Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaIdentityGovernancePrivilegedAccess](Update-MgBetaIdentityGovernancePrivilegedAccess.md)
Update the navigation property privilegedAccess in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroup](Update-MgBetaIdentityGovernancePrivilegedAccessGroup.md)
Update the navigation property group in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Update the navigation property assignmentApprovals in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Update the navigation property assignmentSchedules in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Update the navigation property assignmentScheduleInstances in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Update-MgBetaIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Update the navigation property assignmentScheduleRequests in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Update the navigation property eligibilitySchedules in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Update the navigation property eligibilityScheduleInstances in identityGovernance

### [Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Update-MgBetaIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Update the navigation property eligibilityScheduleRequests in identityGovernance

### [Update-MgBetaIdentityGovernanceRoleManagementAlert](Update-MgBetaIdentityGovernanceRoleManagementAlert.md)
Invoke action refresh

### [Update-MgBetaIdentityGovernanceRoleManagementAlertConfiguration](Update-MgBetaIdentityGovernanceRoleManagementAlertConfiguration.md)
Update the navigation property alertConfigurations in identityGovernance

### [Update-MgBetaIdentityGovernanceRoleManagementAlertDefinition](Update-MgBetaIdentityGovernanceRoleManagementAlertDefinition.md)
Update the navigation property alertDefinitions in identityGovernance

### [Update-MgBetaIdentityGovernanceRoleManagementAlertIncident](Update-MgBetaIdentityGovernanceRoleManagementAlertIncident.md)
Update the navigation property alertIncidents in identityGovernance

### [Update-MgBetaIdentityGovernanceRoleManagementAlertOperation](Update-MgBetaIdentityGovernanceRoleManagementAlertOperation.md)
Update the navigation property operations in identityGovernance

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreement](Update-MgBetaIdentityGovernanceTermsOfUseAgreement.md)
Update the properties of an agreement object.

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance](Update-MgBetaIdentityGovernanceTermsOfUseAgreementAcceptance.md)
Update the navigation property agreementAcceptances in identityGovernance

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreementFile](Update-MgBetaIdentityGovernanceTermsOfUseAgreementFile.md)
Update the navigation property file in identityGovernance

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization](Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalization.md)
Update the navigation property localizations in identityGovernance

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion](Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileLocalizationVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion](Update-MgBetaIdentityGovernanceTermsOfUseAgreementFileVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgBetaPrivilegedAccess](Update-MgBetaPrivilegedAccess.md)
Update entity in privilegedAccess

### [Update-MgBetaPrivilegedAccessResource](Update-MgBetaPrivilegedAccessResource.md)
Update the navigation property resources in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignment](Update-MgBetaPrivilegedAccessResourceRoleAssignment.md)
Update the navigation property roleAssignments in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
Update the navigation property roleAssignmentRequests in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject](Update-MgBetaPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition](Update-MgBetaPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleAssignmentSubject](Update-MgBetaPrivilegedAccessResourceRoleAssignmentSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleDefinition](Update-MgBetaPrivilegedAccessResourceRoleDefinition.md)
Update the navigation property roleDefinitions in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleSetting](Update-MgBetaPrivilegedAccessResourceRoleSetting.md)
Update the navigation property roleSettings in privilegedAccess

### [Update-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition](Update-MgBetaPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignment](Update-MgBetaPrivilegedAccessRoleAssignment.md)
Update the navigation property roleAssignments in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignmentRequest](Update-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
Update the navigation property roleAssignmentRequests in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition](Update-MgBetaPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignmentRequestSubject](Update-MgBetaPrivilegedAccessRoleAssignmentRequestSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition](Update-MgBetaPrivilegedAccessRoleAssignmentRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleAssignmentSubject](Update-MgBetaPrivilegedAccessRoleAssignmentSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleDefinition](Update-MgBetaPrivilegedAccessRoleDefinition.md)
Update the navigation property roleDefinitions in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleSetting](Update-MgBetaPrivilegedAccessRoleSetting.md)
Update the properties of governanceRoleSetting.

### [Update-MgBetaPrivilegedAccessRoleSettingRoleDefinition](Update-MgBetaPrivilegedAccessRoleSettingRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedApproval](Update-MgBetaPrivilegedApproval.md)
Update entity in privilegedApproval

### [Update-MgBetaPrivilegedApprovalRoleInfo](Update-MgBetaPrivilegedApprovalRoleInfo.md)
Update the navigation property roleInfo in privilegedApproval

### [Update-MgBetaPrivilegedApprovalRoleInfoSetting](Update-MgBetaPrivilegedApprovalRoleInfoSetting.md)
Update the navigation property settings in privilegedApproval

### [Update-MgBetaPrivilegedApprovalRoleInfoSummary](Update-MgBetaPrivilegedApprovalRoleInfoSummary.md)
Update the navigation property summary in privilegedApproval

### [Update-MgBetaPrivilegedOperationEvent](Update-MgBetaPrivilegedOperationEvent.md)
Update entity in privilegedOperationEvents

### [Update-MgBetaPrivilegedRole](Update-MgBetaPrivilegedRole.md)
Update entity in privilegedRoles

### [Update-MgBetaPrivilegedRoleAssignment](Update-MgBetaPrivilegedRoleAssignment.md)
Update entity in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleAssignmentRequest](Update-MgBetaPrivilegedRoleAssignmentRequest.md)
Update entity in privilegedRoleAssignmentRequests

### [Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfo](Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfo.md)
Update the navigation property roleInfo in privilegedRoleAssignmentRequests

### [Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting](Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Update the navigation property settings in privilegedRoleAssignmentRequests

### [Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary](Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignmentRequests

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfo](Update-MgBetaPrivilegedRoleAssignmentRoleInfo.md)
Update the navigation property roleInfo in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfoSetting](Update-MgBetaPrivilegedRoleAssignmentRoleInfoSetting.md)
Update the navigation property settings in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfoSummary](Update-MgBetaPrivilegedRoleAssignmentRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleSetting](Update-MgBetaPrivilegedRoleSetting.md)
Update the navigation property settings in privilegedRoles

### [Update-MgBetaPrivilegedRoleSummary](Update-MgBetaPrivilegedRoleSummary.md)
Update the navigation property summary in privilegedRoles

### [Update-MgBetaProgram](Update-MgBetaProgram.md)
In the Azure AD access reviews feature, update an existing program object.

### [Update-MgBetaProgramControl](Update-MgBetaProgramControl.md)
Update entity in programControls

### [Update-MgBetaProgramControlProgram](Update-MgBetaProgramControlProgram.md)
Update the navigation property program in programControls

### [Update-MgBetaProgramControlType](Update-MgBetaProgramControlType.md)
Update entity in programControlTypes

### [Update-MgBetaRoleManagementDirectory](Update-MgBetaRoleManagementDirectory.md)
Update the navigation property directory in roleManagement

### [Update-MgBetaRoleManagementDirectoryResourceNamespace](Update-MgBetaRoleManagementDirectoryResourceNamespace.md)
Update the navigation property resourceNamespaces in roleManagement

### [Update-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction](Update-MgBetaRoleManagementDirectoryResourceNamespaceResourceAction.md)
Update the navigation property resourceActions in roleManagement

### [Update-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope](Update-MgBetaRoleManagementDirectoryResourceNamespaceResourceActionResourceScope.md)
Update the navigation property resourceScope in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignment](Update-MgBetaRoleManagementDirectoryRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentApproval](Update-MgBetaRoleManagementDirectoryRoleAssignmentApproval.md)
Update the navigation property roleAssignmentApprovals in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep](Update-MgBetaRoleManagementDirectoryRoleAssignmentApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentAppScope](Update-MgBetaRoleManagementDirectoryRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentSchedule](Update-MgBetaRoleManagementDirectoryRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance](Update-MgBetaRoleManagementDirectoryRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest](Update-MgBetaRoleManagementDirectoryRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleDefinition](Update-MgBetaRoleManagementDirectoryRoleDefinition.md)
Update the properties of a unifiedRoleDefinition object for an RBAC provider.
You cannot update built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Update-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom](Update-MgBetaRoleManagementDirectoryRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleEligibilitySchedule](Update-MgBetaRoleManagementDirectoryRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance](Update-MgBetaRoleManagementDirectoryRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest](Update-MgBetaRoleManagementDirectoryRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementDirectoryTransitiveRoleAssignment](Update-MgBetaRoleManagementDirectoryTransitiveRoleAssignment.md)
Update the navigation property transitiveRoleAssignments in roleManagement

### [Update-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope](Update-MgBetaRoleManagementDirectoryTransitiveRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgBetaRoleManagementEnterpriseApp](Update-MgBetaRoleManagementEnterpriseApp.md)
Update the navigation property enterpriseApps in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppResourceNamespace](Update-MgBetaRoleManagementEnterpriseAppResourceNamespace.md)
Update the navigation property resourceNamespaces in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction](Update-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceAction.md)
Update the navigation property resourceActions in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope](Update-MgBetaRoleManagementEnterpriseAppResourceNamespaceResourceActionResourceScope.md)
Update the navigation property resourceScope in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignment](Update-MgBetaRoleManagementEnterpriseAppRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentApproval.md)
Update the navigation property roleAssignmentApprovals in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest](Update-MgBetaRoleManagementEnterpriseAppRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleDefinition](Update-MgBetaRoleManagementEnterpriseAppRoleDefinition.md)
Update the properties of a unifiedRoleDefinition object for an RBAC provider.
You cannot update built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Update-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom](Update-MgBetaRoleManagementEnterpriseAppRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule](Update-MgBetaRoleManagementEnterpriseAppRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance](Update-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest](Update-MgBetaRoleManagementEnterpriseAppRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment](Update-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignment.md)
Update the navigation property transitiveRoleAssignments in roleManagement

### [Update-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope](Update-MgBetaRoleManagementEnterpriseAppTransitiveRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagement](Update-MgBetaRoleManagementEntitlementManagement.md)
Update the navigation property entitlementManagement in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementResourceNamespace](Update-MgBetaRoleManagementEntitlementManagementResourceNamespace.md)
Update the navigation property resourceNamespaces in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction](Update-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceAction.md)
Update the navigation property resourceActions in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope](Update-MgBetaRoleManagementEntitlementManagementResourceNamespaceResourceActionResourceScope.md)
Update the navigation property resourceScope in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignment](Update-MgBetaRoleManagementEntitlementManagementRoleAssignment.md)
Update the navigation property roleAssignments in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentApproval.md)
Update the navigation property roleAssignmentApprovals in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentApprovalStep.md)
Apply approve or deny decision on an approvalStep object.

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentSchedule.md)
Update the navigation property roleAssignmentSchedules in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleInstance.md)
Update the navigation property roleAssignmentScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest](Update-MgBetaRoleManagementEntitlementManagementRoleAssignmentScheduleRequest.md)
Update the navigation property roleAssignmentScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleDefinition](Update-MgBetaRoleManagementEntitlementManagementRoleDefinition.md)
Update the properties of a unifiedRoleDefinition object for an RBAC provider.
You cannot update built-in roles.
This feature requires an Azure AD Premium P1 or P2 license.
The following RBAC providers are currently supported:\n- Cloud PC\n- device management (Intune)\n- directory (Azure AD)

### [Update-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom](Update-MgBetaRoleManagementEntitlementManagementRoleDefinitionInheritPermissionFrom.md)
Update the navigation property inheritsPermissionsFrom in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule](Update-MgBetaRoleManagementEntitlementManagementRoleEligibilitySchedule.md)
Update the navigation property roleEligibilitySchedules in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance](Update-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleInstance.md)
Update the navigation property roleEligibilityScheduleInstances in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest](Update-MgBetaRoleManagementEntitlementManagementRoleEligibilityScheduleRequest.md)
Update the navigation property roleEligibilityScheduleRequests in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment](Update-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignment.md)
Update the navigation property transitiveRoleAssignments in roleManagement

### [Update-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope](Update-MgBetaRoleManagementEntitlementManagementTransitiveRoleAssignmentAppScope.md)
Update the navigation property appScope in roleManagement

