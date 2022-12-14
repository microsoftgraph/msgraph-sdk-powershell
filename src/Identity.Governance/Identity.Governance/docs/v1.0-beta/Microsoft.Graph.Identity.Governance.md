---
Module Name: Microsoft.Graph.Beta.Identity.Governance
Module Guid: 0156255c-5096-45c3-a3fb-87c6adb21ca3
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.identity.governance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Identity.Governance Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

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

### [Get-MgBetaAccessReviewDecision](Get-MgBetaAccessReviewDecision.md)
The collection of decisions for this access review.

### [Get-MgBetaAccessReviewInstance](Get-MgBetaAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Get-MgBetaAccessReviewInstanceDecision](Get-MgBetaAccessReviewInstanceDecision.md)
The collection of decisions for this access review.

### [Get-MgBetaAccessReviewInstanceMyDecision](Get-MgBetaAccessReviewInstanceMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgBetaAccessReviewInstanceReviewer](Get-MgBetaAccessReviewInstanceReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Get-MgBetaAccessReviewMyDecision](Get-MgBetaAccessReviewMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgBetaAccessReviewReviewer](Get-MgBetaAccessReviewReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

### [Get-MgBetaAgreement](Get-MgBetaAgreement.md)
Get entity from agreements by key

### [Get-MgBetaAgreementAcceptance](Get-MgBetaAgreementAcceptance.md)
Read-only.
Information about acceptances of this agreement.

### [Get-MgBetaAgreementFile](Get-MgBetaAgreementFile.md)
Retrieve the details of the default file for an agreement, including the language and version information.
The file information is specified through the agreementFile object.

### [Get-MgBetaAgreementFileLocalization](Get-MgBetaAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgBetaAgreementFileLocalizationVersion](Get-MgBetaAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaBusinessFlowTemplate](Get-MgBetaBusinessFlowTemplate.md)
Get entity from businessFlowTemplates by key

### [Get-MgBetaEntitlementManagementAccessPackage](Get-MgBetaEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgBetaEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
In Azure AD entitlement management, this action retrieves a list of accessPackageAssignmentRequestRequirements objects that the currently signed-in user can use to create an accessPackageAssignmentRequest.
Each requirement object corresponds to an access package assignment policy that the currently signed-in user is allowed to request an assignment for.

### [Get-MgBetaEntitlementManagementAccessPackageAssignment](Get-MgBetaEntitlementManagementAccessPackageAssignment.md)
The assignment of an access package to a subject for a period of time.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentAdditional](Get-MgBetaEntitlementManagementAccessPackageAssignmentAdditional.md)
Invoke function additionalAccess

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Get-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRole](Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRole.md)
Represents the resource-specific role which a subject has been assigned through an access package assignment.

### [Get-MgBetaEntitlementManagementAccessPackageCatalog](Get-MgBetaEntitlementManagementAccessPackageCatalog.md)
A container of access packages.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource.md)
Retrieve a list of accessPackageResource objects in an accessPackageCatalog.
To request to add or remove an accessPackageResource, use create accessPackageResourceRequest.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceRole.md)
Retrieve a list of accessPackageResourceRole objects of an accessPackageResource in an accessPackageCatalog.
The resource should have been added to the catalog by creating an accessPackageResourceRequest.
This list of roles can then be used by the caller to select a role, which is needed when subsequently creating an accessPackageResourceRoleScope.

### [Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceScope](Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResourceScope.md)
Get accessPackageResourceScopes from identityGovernance

### [Get-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Get-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Get customAccessPackageWorkflowExtensions from identityGovernance

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

### [Get-MgBetaEntitlementManagementAccessPackageResourceEnvironment](Get-MgBetaEntitlementManagementAccessPackageResourceEnvironment.md)
A reference to the geolocation environment in which a resource is located.

### [Get-MgBetaEntitlementManagementAccessPackageResourceRequest](Get-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Get-MgBetaEntitlementManagementConnectedOrganization](Get-MgBetaEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsor.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorById](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's external sponsors.
The external sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject](Get-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsor.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorById](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorById.md)
Return the directory objects specified in a list of IDs.
Some common uses for this function are to:

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Retrieve a list of a connectedOrganization's internal sponsors.
The internal sponsors are a set of users who can approve requests on behalf of other users from that connected organization.

### [Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject](Get-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgBetaEntitlementManagementSetting](Get-MgBetaEntitlementManagementSetting.md)
Retrieve the properties of an entitlementManagementSettings object.

### [Get-MgBetaEntitlementManagementSubject](Get-MgBetaEntitlementManagementSubject.md)
Get subjects from identityGovernance

### [Get-MgBetaEntitlementManagementSubjectConnectedOrganization](Get-MgBetaEntitlementManagementSubjectConnectedOrganization.md)
The connected organization of the subject.
Read-only.
Nullable.

### [Get-MgBetaIdentityGovernanceAccessReviewDecision](Get-MgBetaIdentityGovernanceAccessReviewDecision.md)
Represents an Azure AD access review decision on an instance of a review.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstance](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDefinition](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinition](Get-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Represents the template and scheduling for an access review.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Set of access reviews instances for this access review series.
Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDefinition](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinition](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinition.md)
Represents a collection of access review history data and the scopes used to collect that data.

### [Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance](Get-MgBetaIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence.
A definition that does not recur will have exactly one instance.

### [Get-MgBetaIdentityGovernanceAccessReviewPolicy](Get-MgBetaIdentityGovernanceAccessReviewPolicy.md)
Read the properties and relationships of an accessReviewPolicy object.

### [Get-MgBetaIdentityGovernanceAppConsentRequest](Get-MgBetaIdentityGovernanceAppConsentRequest.md)
A collection of userConsentRequest objects for a specific application.

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest.md)
A list of pending user consent requests.
Supports $filter (eq).

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Approval decisions associated with a request.

### [Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Get steps from identityGovernance

### [Get-MgBetaIdentityGovernanceLifecycleWorkflow](Get-MgBetaIdentityGovernanceLifecycleWorkflow.md)
The workflows in the lifecycle workflows instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
The customTaskExtension instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy.md)
The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy](Get-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy.md)
The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Deleted workflows in your lifecycle workflows instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Deleted workflows that end up in the deletedItemsContainer.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Get runs from identityGovernance

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Get userProcessingResults from identityGovernance

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
The workflow versions that are available.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScope](Get-MgBetaIdentityGovernanceLifecycleWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRun](Get-MgBetaIdentityGovernanceLifecycleWorkflowRun.md)
Get runs from identityGovernance

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
The related taskProcessingResults.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
The associated individual user execution.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting](Get-MgBetaIdentityGovernanceLifecycleWorkflowSetting.md)
Read the properties and relationships of a lifecycleManagementSettings object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
The definition of tasks within the lifecycle workflows instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTask.md)
The related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition.md)
The taskDefinition associated with the related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
The related lifecycle workflow taskProcessingResults.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplate](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplate.md)
The workflow templates in the lifecycle workflow instance.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Represents the configured tasks to execute and their execution sequence within a workflow.
This relationship is expanded by default.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
The result of processing the task.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask](Get-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask.md)
The related workflow task

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Get userProcessingResults from identityGovernance

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion](Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion.md)
The workflow versions that are available.

### [Get-MgBetaIdentityGovernanceTermOfUseAgreement](Get-MgBetaIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Get-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance](Get-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgBetaIdentityGovernanceTermOfUseAgreementFile](Get-MgBetaIdentityGovernanceTermOfUseAgreementFile.md)
Retrieve the details of the default file for an agreement, including the language and version information.
The file information is specified through the agreementFile object.

### [Get-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization](Get-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Get-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgBetaPrivilegedAccess](Get-MgBetaPrivilegedAccess.md)
Get entity from privilegedAccess by key

### [Get-MgBetaPrivilegedAccessResource](Get-MgBetaPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Get-MgBetaPrivilegedAccessResourceParent](Get-MgBetaPrivilegedAccessResourceParent.md)
Read-only.
The parent resource.
for pimforazurerbac scenario, it can represent the subscription the resource belongs to.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignment](Get-MgBetaPrivilegedAccessResourceRoleAssignment.md)
The collection of role assignments for the resource.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment](Get-MgBetaPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Get-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
The collection of role assignment requests for the resource.

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

### [Get-MgBetaPrivilegedAccessResourceRoleDefinitionResource](Get-MgBetaPrivilegedAccessResourceRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessResourceRoleSetting](Get-MgBetaPrivilegedAccessResourceRoleSetting.md)
The collection of role settings for the resource.

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

### [Get-MgBetaPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment](Get-MgBetaPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgBetaPrivilegedAccessRoleAssignmentRequest](Get-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

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

### [Get-MgBetaPrivilegedAccessRoleDefinitionResource](Get-MgBetaPrivilegedAccessRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgBetaPrivilegedAccessRoleDefinitionRoleSetting](Get-MgBetaPrivilegedAccessRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgBetaPrivilegedAccessRoleSetting](Get-MgBetaPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [Get-MgBetaPrivilegedAccessRoleSettingResource](Get-MgBetaPrivilegedAccessRoleSettingResource.md)
Read-only.
The associated resource for this role setting.

### [Get-MgBetaPrivilegedAccessRoleSettingRoleDefinition](Get-MgBetaPrivilegedAccessRoleSettingRoleDefinition.md)
Read-only.
The role definition that is enforced with this role setting.

### [Get-MgBetaPrivilegedApproval](Get-MgBetaPrivilegedApproval.md)
Retrieve the properties and relationships of privilegedapproval object.

### [Get-MgBetaPrivilegedApprovalRequest](Get-MgBetaPrivilegedApprovalRequest.md)
Read-only.
The role assignment request for this approval object

### [Get-MgBetaPrivilegedApprovalRoleInfo](Get-MgBetaPrivilegedApprovalRoleInfo.md)
Get roleInfo from privilegedApproval

### [Get-MgBetaPrivilegedApprovalRoleInfoAssignment](Get-MgBetaPrivilegedApprovalRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgBetaPrivilegedApprovalRoleInfoSetting](Get-MgBetaPrivilegedApprovalRoleInfoSetting.md)
Retrieve the role settings for the given role.
A privilegedRoleSettings object will be returned.

### [Get-MgBetaPrivilegedApprovalRoleInfoSummary](Get-MgBetaPrivilegedApprovalRoleInfoSummary.md)
Retrieve the properties and relationships of privilegedRoleSummary object.

### [Get-MgBetaPrivilegedOperationEvent](Get-MgBetaPrivilegedOperationEvent.md)
Get entity from privilegedOperationEvents by key

### [Get-MgBetaPrivilegedRole](Get-MgBetaPrivilegedRole.md)
Retrieve the properties and relationships of privilegedRole object.

### [Get-MgBetaPrivilegedRoleAssignmentRequest](Get-MgBetaPrivilegedRoleAssignmentRequest.md)
Get entity from privilegedRoleAssignmentRequests by key

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfo](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfo.md)
The roleInfo object of the role assignment request.

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignment](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Retrieve the role settings for the given role.
A privilegedRoleSettings object will be returned.

### [Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary](Get-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Retrieve the properties and relationships of privilegedRoleSummary object.

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfo](Get-MgBetaPrivilegedRoleAssignmentRoleInfo.md)
Read-only.
Nullable.
The associated role information.

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignment](Get-MgBetaPrivilegedRoleAssignmentRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoSetting](Get-MgBetaPrivilegedRoleAssignmentRoleInfoSetting.md)
Retrieve the role settings for the given role.
A privilegedRoleSettings object will be returned.

### [Get-MgBetaPrivilegedRoleAssignmentRoleInfoSummary](Get-MgBetaPrivilegedRoleAssignmentRoleInfoSummary.md)
Retrieve the properties and relationships of privilegedRoleSummary object.

### [Get-MgBetaPrivilegedRoleRoleAssignment](Get-MgBetaPrivilegedRoleRoleAssignment.md)
Retrieve the properties and relationships of privilegedRoleAssignment object.

### [Get-MgBetaPrivilegedRoleSetting](Get-MgBetaPrivilegedRoleSetting.md)
Retrieve the role settings for the given role.
A privilegedRoleSettings object will be returned.

### [Get-MgBetaPrivilegedRoleSummary](Get-MgBetaPrivilegedRoleSummary.md)
Retrieve the properties and relationships of privilegedRoleSummary object.

### [Get-MgBetaProgram](Get-MgBetaProgram.md)
Get entity from programs by key

### [Get-MgBetaProgramControl](Get-MgBetaProgramControl.md)
Get entity from programControls by key

### [Get-MgBetaProgramControlProgram](Get-MgBetaProgramControlProgram.md)
The program this control is part of.

### [Get-MgBetaProgramControlType](Get-MgBetaProgramControlType.md)
Get entity from programControlTypes by key

### [Get-MgBetaUserAgreementAcceptance](Get-MgBetaUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

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

### [Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser](Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgBetaMyPrivilegedApprovalRequest](Invoke-MgBetaMyPrivilegedApprovalRequest.md)
Invoke function myRequests

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

### [Invoke-MgBetaSelfPrivilegedApprovalRoleInfoActivate](Invoke-MgBetaSelfPrivilegedApprovalRoleInfoActivate.md)
Activate the role that is assigned to the requester.

### [Invoke-MgBetaSelfPrivilegedApprovalRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedApprovalRoleInfoDeactivate.md)
Deactivate the role that is assigned to the requestor.

### [Invoke-MgBetaSelfPrivilegedRoleActivate](Invoke-MgBetaSelfPrivilegedRoleActivate.md)
Activate the role that is assigned to the requester.

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoActivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoActivate.md)
Activate the role that is assigned to the requester.

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate.md)
Deactivate the role that is assigned to the requestor.

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoActivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoActivate.md)
Activate the role that is assigned to the requester.

### [Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoDeactivate](Invoke-MgBetaSelfPrivilegedRoleAssignmentRoleInfoDeactivate.md)
Deactivate the role that is assigned to the requestor.

### [Invoke-MgBetaSelfPrivilegedRoleDeactivate](Invoke-MgBetaSelfPrivilegedRoleDeactivate.md)
Deactivate the role that is assigned to the requestor.

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

### [New-MgBetaAgreementFileLocalization](New-MgBetaAgreementFileLocalization.md)
Create new navigation property to localizations for agreements

### [New-MgBetaAgreementFileLocalizationVersion](New-MgBetaAgreementFileLocalizationVersion.md)
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

### [New-MgBetaEntitlementManagementAccessPackageAssignmentRequest](New-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
In Azure AD Entitlement Management, create a new accessPackageAssignmentRequest object.
This operation is used to assign a user to an access package, or to remove an access package assignment.

### [New-MgBetaEntitlementManagementAccessPackageCatalog](New-MgBetaEntitlementManagementAccessPackageCatalog.md)
Create a new accessPackageCatalog object.

### [New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](New-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Create a new customAccessPackageWorkflowExtension object and add it to an existing accessPackageCatalog object.

### [New-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Create new navigation property ref to incompatibleAccessPackages for identityGovernance

### [New-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Create new navigation property ref to incompatibleGroups for identityGovernance

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
Create new navigation property ref to externalSponsors for identityGovernance

### [New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](New-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Create new navigation property ref to internalSponsors for identityGovernance

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

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Create new navigation property to workflows for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Create new navigation property to runs for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Create new navigation property to taskReports for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Create new navigation property to userProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowNewVersion.md)
Create a new version of the workflow object.

### [New-MgBetaIdentityGovernanceLifecycleWorkflowRun](New-MgBetaIdentityGovernanceLifecycleWorkflowRun.md)
Create new navigation property to runs for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Create new navigation property to taskProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Create new navigation property to userProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
Create new navigation property to taskProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition](New-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
Create new navigation property to taskDefinitions for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport](New-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport.md)
Create new navigation property to taskReports for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Create new navigation property to taskProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTemplate](New-MgBetaIdentityGovernanceLifecycleWorkflowTemplate.md)
Create new navigation property to workflowTemplates for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask](New-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Create new navigation property to tasks for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Create new navigation property to taskProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Create new navigation property to userProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](New-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
Create new navigation property to taskProcessingResults for identityGovernance

### [New-MgBetaIdentityGovernanceLifecycleWorkflowVersion](New-MgBetaIdentityGovernanceLifecycleWorkflowVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgBetaIdentityGovernanceTermOfUseAgreement](New-MgBetaIdentityGovernanceTermOfUseAgreement.md)
Create a new agreement object.

### [New-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance](New-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance.md)
Create new navigation property to agreementAcceptances for identityGovernance

### [New-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization](New-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Create new navigation property to localizations for identityGovernance

### [New-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](New-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
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
Use this API to create a new privilegedApproval.

### [New-MgBetaPrivilegedOperationEvent](New-MgBetaPrivilegedOperationEvent.md)
Add new entity to privilegedOperationEvents

### [New-MgBetaPrivilegedRole](New-MgBetaPrivilegedRole.md)
Add new entity to privilegedRoles

### [New-MgBetaPrivilegedRoleAssignment](New-MgBetaPrivilegedRoleAssignment.md)
Use this API to create a new  privilegedRoleAssignment.

### [New-MgBetaPrivilegedRoleAssignmentEligible](New-MgBetaPrivilegedRoleAssignmentEligible.md)
Make the role assignment eligible.
If the role assignment is already eligible before the call, it does nothing.
If the role assignment is permanent and the requestor is different from the target user, the role assignment will become eligible and the role will be deactivated for the target user.
If the requestor is the target user and the role is Security Administrator or Privileged Role Administrator, the role will be activated with the default expiration.

### [New-MgBetaPrivilegedRoleAssignmentPermanent](New-MgBetaPrivilegedRoleAssignmentPermanent.md)
Make the role assignment permanent.

### [New-MgBetaPrivilegedRoleAssignmentRequest](New-MgBetaPrivilegedRoleAssignmentRequest.md)
Create a privilegedroleassignmentrequest object.

### [New-MgBetaProgram](New-MgBetaProgram.md)
In the Azure AD access reviews feature, create a new program object.

### [New-MgBetaProgramControl](New-MgBetaProgramControl.md)
In the Azure AD access reviews feature, create a new programControl object.
This links an access review to a program.
Prior to making this request, the caller must have previously

### [New-MgBetaProgramControlType](New-MgBetaProgramControlType.md)
Add new entity to programControlTypes

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
Delete navigation property reviewers for accessReviews

### [Remove-MgBetaAccessReviewMyDecision](Remove-MgBetaAccessReviewMyDecision.md)
Delete navigation property myDecisions for accessReviews

### [Remove-MgBetaAccessReviewReviewer](Remove-MgBetaAccessReviewReviewer.md)
Delete navigation property reviewers for accessReviews

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

### [Remove-MgBetaBusinessFlowTemplate](Remove-MgBetaBusinessFlowTemplate.md)
Delete entity from businessFlowTemplates

### [Remove-MgBetaEntitlementManagementAccessPackage](Remove-MgBetaEntitlementManagementAccessPackage.md)
Delete navigation property accessPackages for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignment](Remove-MgBetaEntitlementManagementAccessPackageAssignment.md)
Delete navigation property accessPackageAssignments for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentApproval](Remove-MgBetaEntitlementManagementAccessPackageAssignmentApproval.md)
Delete navigation property accessPackageAssignmentApprovals for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep](Remove-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Delete navigation property accessPackageAssignmentPolicies for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Remove-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Delete navigation property customExtensionHandlers for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Remove-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
Delete navigation property accessPackageAssignmentRequests for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageCatalog](Remove-MgBetaEntitlementManagementAccessPackageCatalog.md)
Delete navigation property accessPackageCatalogs for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Remove-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Delete navigation property customAccessPackageWorkflowExtensions for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Remove-MgBetaEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Delete ref of navigation property incompatibleAccessPackages for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef](Remove-MgBetaEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Delete ref of navigation property incompatibleGroups for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageResourceRequest](Remove-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Delete navigation property accessPackageResourceRequests for identityGovernance

### [Remove-MgBetaEntitlementManagementAccessPackageResourceRoleScope](Remove-MgBetaEntitlementManagementAccessPackageResourceRoleScope.md)
Delete navigation property accessPackageResourceRoleScopes for identityGovernance

### [Remove-MgBetaEntitlementManagementConnectedOrganization](Remove-MgBetaEntitlementManagementConnectedOrganization.md)
Delete navigation property connectedOrganizations for identityGovernance

### [Remove-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef](Remove-MgBetaEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Delete ref of navigation property externalSponsors for identityGovernance

### [Remove-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef](Remove-MgBetaEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Delete ref of navigation property internalSponsors for identityGovernance

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
Delete navigation property definitions for identityGovernance

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
Delete navigation property workflows for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Remove-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Delete navigation property customTaskExtensions for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Delete navigation property deletedItems for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Delete navigation property workflows for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Delete navigation property runs for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Delete navigation property taskReports for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Delete navigation property userProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Remove-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowRun](Remove-MgBetaIdentityGovernanceLifecycleWorkflowRun.md)
Delete navigation property runs for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Delete navigation property taskProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Delete navigation property userProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
Delete navigation property taskProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowSetting](Remove-MgBetaIdentityGovernanceLifecycleWorkflowSetting.md)
Delete navigation property settings for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
Delete navigation property taskDefinitions for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport.md)
Delete navigation property taskReports for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Delete navigation property taskProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplate](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplate.md)
Delete navigation property workflowTemplates for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Delete navigation property tasks for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Delete navigation property taskProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Delete navigation property userProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Remove-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
Delete navigation property taskProcessingResults for identityGovernance

### [Remove-MgBetaIdentityGovernanceLifecycleWorkflowVersion](Remove-MgBetaIdentityGovernanceLifecycleWorkflowVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermOfUseAgreement](Remove-MgBetaIdentityGovernanceTermOfUseAgreement.md)
Delete navigation property agreements for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance](Remove-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance.md)
Delete navigation property agreementAcceptances for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermOfUseAgreementFile](Remove-MgBetaIdentityGovernanceTermOfUseAgreementFile.md)
Delete navigation property file for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization](Remove-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Delete navigation property localizations for identityGovernance

### [Remove-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Remove-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
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
Delete privilegedRoleAssignment.

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

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
An Azure Logic Apps system-assigned managed identity calls this API.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
An Azure Logic Apps system-assigned managed identity calls this API.

### [Resume-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Resume-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Resume a task processing result that's `inProgress`.
An Azure Logic Apps system-assigned managed identity calls this API.

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
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgBetaEntitlementManagementConnectedOrganization, to simplify reporting.

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

### [Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Stop-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Stop an access review stage that is `inProgress`.
After the access review stage stops, the stage **status** will be `Completed` and the reviewers can no longer give input.
If there are subsequent stages that depend on the completed stage, the next stage will be created.
The accessReviewInstanceDecisionItem objects will always reflect the last decisions recorded across all stages at that given time, regardless of the status of the stages.

### [Stop-MgBetaPrivilegedAccessResourceRoleAssignmentRequest](Stop-MgBetaPrivilegedAccessResourceRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgBetaPrivilegedAccessRoleAssignmentRequest](Stop-MgBetaPrivilegedAccessRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgBetaPrivilegedRoleAssignmentRequest](Stop-MgBetaPrivilegedRoleAssignmentRequest.md)
Cancel a privilegedRoleAssignmentRequest.

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

### [Update-MgBetaBusinessFlowTemplate](Update-MgBetaBusinessFlowTemplate.md)
Update entity in businessFlowTemplates

### [Update-MgBetaEntitlementManagementAccessPackage](Update-MgBetaEntitlementManagementAccessPackage.md)
Update the navigation property accessPackages in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignment](Update-MgBetaEntitlementManagementAccessPackageAssignment.md)
Invoke action reprocess

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentApproval](Update-MgBetaEntitlementManagementAccessPackageAssignmentApproval.md)
Update the navigation property accessPackageAssignmentApprovals in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep](Update-MgBetaEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Update the navigation property steps in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicy](Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Update-MgBetaEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Update the navigation property customExtensionHandlers in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageAssignmentRequest](Update-MgBetaEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action reprocess

### [Update-MgBetaEntitlementManagementAccessPackageCatalog](Update-MgBetaEntitlementManagementAccessPackageCatalog.md)
Update the navigation property accessPackageCatalogs in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Update-MgBetaEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Update the navigation property customAccessPackageWorkflowExtensions in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageResourceRequest](Update-MgBetaEntitlementManagementAccessPackageResourceRequest.md)
Update the navigation property accessPackageResourceRequests in identityGovernance

### [Update-MgBetaEntitlementManagementAccessPackageResourceRoleScope](Update-MgBetaEntitlementManagementAccessPackageResourceRoleScope.md)
Update the navigation property accessPackageResourceRoleScopes in identityGovernance

### [Update-MgBetaEntitlementManagementConnectedOrganization](Update-MgBetaEntitlementManagementConnectedOrganization.md)
Update the navigation property connectedOrganizations in identityGovernance

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
Update the navigation property stages in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinition](Update-MgBetaIdentityGovernanceAccessReviewDefinition.md)
Update the navigation property definitions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstance](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Update the navigation property stages in identityGovernance

### [Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Update the navigation property decisions in identityGovernance

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
Update the navigation property steps in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflow](Update-MgBetaIdentityGovernanceLifecycleWorkflow.md)
Update the navigation property workflows in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Update-MgBetaIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Update the navigation property customTaskExtensions in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Update the navigation property deletedItems in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Update the navigation property workflows in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Update the navigation property runs in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Update the navigation property taskReports in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Update the navigation property userProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Update-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRun](Update-MgBetaIdentityGovernanceLifecycleWorkflowRun.md)
Update the navigation property runs in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Update the navigation property taskProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Update the navigation property userProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
Update the navigation property taskProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting](Update-MgBetaIdentityGovernanceLifecycleWorkflowSetting.md)
Update the properties of a lifecycleManagementSettings object.

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition](Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
Update the navigation property taskDefinitions in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport](Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReport.md)
Update the navigation property taskReports in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Update the navigation property taskProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplate](Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplate.md)
Update the navigation property workflowTemplates in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask](Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Update the navigation property tasks in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Update the navigation property taskProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Update the navigation property userProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Update-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
Update the navigation property taskProcessingResults in identityGovernance

### [Update-MgBetaIdentityGovernanceLifecycleWorkflowVersion](Update-MgBetaIdentityGovernanceLifecycleWorkflowVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgBetaIdentityGovernanceTermOfUseAgreement](Update-MgBetaIdentityGovernanceTermOfUseAgreement.md)
Update the navigation property agreements in identityGovernance

### [Update-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance](Update-MgBetaIdentityGovernanceTermOfUseAgreementAcceptance.md)
Update the navigation property agreementAcceptances in identityGovernance

### [Update-MgBetaIdentityGovernanceTermOfUseAgreementFile](Update-MgBetaIdentityGovernanceTermOfUseAgreementFile.md)
Update the navigation property file in identityGovernance

### [Update-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization](Update-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Update the navigation property localizations in identityGovernance

### [Update-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Update-MgBetaIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
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
Update the navigation property roleSettings in privilegedAccess

### [Update-MgBetaPrivilegedAccessRoleSettingRoleDefinition](Update-MgBetaPrivilegedAccessRoleSettingRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgBetaPrivilegedApproval](Update-MgBetaPrivilegedApproval.md)
Update the properties of privilegedapproval object.

### [Update-MgBetaPrivilegedApprovalRoleInfo](Update-MgBetaPrivilegedApprovalRoleInfo.md)
Update the navigation property roleInfo in privilegedApproval

### [Update-MgBetaPrivilegedApprovalRoleInfoSetting](Update-MgBetaPrivilegedApprovalRoleInfoSetting.md)
Update the role settings for the given role setting.
A privilegedRoleSettings object will be returned.

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
Update the role settings for the given role setting.
A privilegedRoleSettings object will be returned.

### [Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary](Update-MgBetaPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignmentRequests

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfo](Update-MgBetaPrivilegedRoleAssignmentRoleInfo.md)
Update the navigation property roleInfo in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfoSetting](Update-MgBetaPrivilegedRoleAssignmentRoleInfoSetting.md)
Update the role settings for the given role setting.
A privilegedRoleSettings object will be returned.

### [Update-MgBetaPrivilegedRoleAssignmentRoleInfoSummary](Update-MgBetaPrivilegedRoleAssignmentRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignments

### [Update-MgBetaPrivilegedRoleSetting](Update-MgBetaPrivilegedRoleSetting.md)
Update the role settings for the given role setting.
A privilegedRoleSettings object will be returned.

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

