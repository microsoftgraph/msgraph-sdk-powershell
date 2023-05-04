---
Module Name: Microsoft.Graph.Identity.Governance
Module Guid: fea5a5fe-62f3-4221-a662-cacc38bf1bb8
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

### [Add-MgAccessReviewInstanceDecision](Add-MgAccessReviewInstanceDecision.md)
Invoke action applyDecisions

### [Add-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Add-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke action applyDecisions

### [Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Invoke action applyDecisions

### [Export-MgPrivilegedAccessResourceRoleAssignment](Export-MgPrivilegedAccessResourceRoleAssignment.md)
Invoke function export

### [Export-MgPrivilegedAccessRoleAssignment](Export-MgPrivilegedAccessRoleAssignment.md)
Invoke function export

### [Get-MgAccessReview](Get-MgAccessReview.md)
In the Azure AD access reviews feature, retrieve an accessReview object.
 To retrieve the reviewers of the access review, use the list accessReview reviewers API.
To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API.
If this is a recurring access review, no decisions will be associated with the recurring access review series.
Instead, use the `instances` relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review.
Each past and current instance will have decisions.

### [Get-MgAccessReviewDecision](Get-MgAccessReviewDecision.md)
The collection of decisions for this access review.

### [Get-MgAccessReviewInstance](Get-MgAccessReviewInstance.md)
The collection of access reviews instances past, present and future, if this object is a recurring access review.

### [Get-MgAccessReviewInstanceDecision](Get-MgAccessReviewInstanceDecision.md)
The collection of decisions for this access review.

### [Get-MgAccessReviewInstanceMyDecision](Get-MgAccessReviewInstanceMyDecision.md)
The collection of decisions for the caller, if the caller is a reviewer.

### [Get-MgAccessReviewInstanceReviewer](Get-MgAccessReviewInstanceReviewer.md)
The collection of reviewers for an access review, if access review reviewerType is of type delegated.

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

### [Get-MgBusinessFlowTemplate](Get-MgBusinessFlowTemplate.md)
Get entity from businessFlowTemplates by key

### [Get-MgEntitlementManagementAccessPackage](Get-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementAccessPackageAssignment](Get-MgEntitlementManagementAccessPackageAssignment.md)
The assignment of an access package to a subject for a period of time.

### [Get-MgEntitlementManagementAccessPackageAssignmentAdditional](Get-MgEntitlementManagementAccessPackageAssignmentAdditional.md)
Invoke function additionalAccess

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicy](Get-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Get-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
The collection of stages when to execute one or more custom access package workflow extensions.
Supports $expand.

### [Get-MgEntitlementManagementAccessPackageAssignmentRequest](Get-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Get-MgEntitlementManagementAccessPackageAssignmentResourceRole](Get-MgEntitlementManagementAccessPackageAssignmentResourceRole.md)
Represents the resource-specific role which a subject has been assigned through an access package assignment.

### [Get-MgEntitlementManagementAccessPackageCatalog](Get-MgEntitlementManagementAccessPackageCatalog.md)
Get accessPackageCatalog from identityGovernance

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
The attributes of a logic app, which can be called at various stages of an access package request and assignment cycle.

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResource.md)
Get accessPackageResources from identityGovernance

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceRole](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceRole.md)
The roles in each resource in a catalog.
Read-only.

### [Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceScope](Get-MgEntitlementManagementAccessPackageCatalogAccessPackageResourceScope.md)
Get accessPackageResourceScopes from identityGovernance

### [Get-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Get-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Get customAccessPackageWorkflowExtensions from identityGovernance

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage.md)
The  access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
The  access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroup](Get-MgEntitlementManagementAccessPackageIncompatibleGroup.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleWith](Get-MgEntitlementManagementAccessPackageIncompatibleWith.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementAccessPackageResource](Get-MgEntitlementManagementAccessPackageResource.md)
A reference to a resource associated with an access package catalog.

### [Get-MgEntitlementManagementAccessPackageResourceEnvironment](Get-MgEntitlementManagementAccessPackageResourceEnvironment.md)
A reference to the geolocation environment in which a resource is located.

### [Get-MgEntitlementManagementAccessPackageResourceRequest](Get-MgEntitlementManagementAccessPackageResourceRequest.md)
Represents a request to add or remove a resource to or from a catalog respectively.

### [Get-MgEntitlementManagementConnectedOrganization](Get-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Get externalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById.md)
Invoke action getByIds

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Get ref of externalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Get internalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById.md)
Invoke action getByIds

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Get ref of internalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorUserOwnedObject.md)
Invoke action getUserOwnedObjects

### [Get-MgEntitlementManagementSetting](Get-MgEntitlementManagementSetting.md)
Represents the settings that control the behavior of Azure AD entitlement management.

### [Get-MgEntitlementManagementSubject](Get-MgEntitlementManagementSubject.md)
Get subjects from identityGovernance

### [Get-MgEntitlementManagementSubjectConnectedOrganization](Get-MgEntitlementManagementSubjectConnectedOrganization.md)
The connected organization of the subject.
Read-only.
Nullable.

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
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Get-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition](Get-MgIdentityGovernanceAccessReviewDecisionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Get-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Get-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewDefinition](Get-MgIdentityGovernanceAccessReviewDefinition.md)
Represents the template and scheduling for an access review.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstance](Get-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Set of access reviews instances for this access review series.
Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Insights are recommendations to reviewers on whether to approve or deny a decision.
There can be multiple insights associated with an accessReviewInstanceDecisionItem.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDefinition](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDefinition.md)
There is exactly one accessReviewScheduleDefinition associated with each instance.
It is the parent schedule for the instance, where instances are created for each recurrence of a review definition and each group selected to review by the definition.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
If the instance has multiple stages, this returns the collection of stages.
A new stage will only be created when the previous stage ends.
The existence, number, and settings of stages on a review instance are created based on the accessReviewStageSettings on the parent accessReviewScheduleDefinition.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinition](Get-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Represents a collection of access review history data and the scopes used to collect that data.

### [Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Get-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence.
A definition that does not recur will have exactly one instance.

### [Get-MgIdentityGovernanceAccessReviewPolicy](Get-MgIdentityGovernanceAccessReviewPolicy.md)
Resource that enables administrators to manage directory-level access review policies in their tenant.

### [Get-MgIdentityGovernanceAppConsentRequest](Get-MgIdentityGovernanceAppConsentRequest.md)
A collection of userConsentRequest objects for a specific application.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
A list of pending user consent requests.
Supports $filter (eq).

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Approval decisions associated with a request.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Get steps from identityGovernance

### [Get-MgIdentityGovernanceLifecycleWorkflow](Get-MgIdentityGovernanceLifecycleWorkflow.md)
The workflows in the lifecycle workflows instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
The customTaskExtension instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedBy.md)
The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedBy.md)
The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItem](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Deleted workflows in your lifecycle workflows instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Deleted workflows that end up in the deletedItemsContainer.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowRun.md)
Workflow runs.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion](Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowVersion.md)
The workflow versions that are available.

### [Get-MgIdentityGovernanceLifecycleWorkflowExecutionScope](Get-MgIdentityGovernanceLifecycleWorkflowExecutionScope.md)
The unique identifier of the Azure AD identity that last modified the workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowExecutionScopeMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowExecutionScopeMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRun](Get-MgIdentityGovernanceLifecycleWorkflowRun.md)
Workflow runs.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
The related taskProcessingResults.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
The associated individual user execution.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgIdentityGovernanceLifecycleWorkflowSetting](Get-MgIdentityGovernanceLifecycleWorkflowSetting.md)
The settings of the lifecycle workflows instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition](Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition.md)
The definition of tasks within the lifecycle workflows instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReport](Get-MgIdentityGovernanceLifecycleWorkflowTaskReport.md)
Represents the aggregation of task execution data for tasks within a workflow object.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTask](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTask.md)
The related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskDefinition.md)
The taskDefinition associated with the related lifecycle workflow task.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
The related lifecycle workflow taskProcessingResults.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplate](Get-MgIdentityGovernanceLifecycleWorkflowTemplate.md)
The workflow templates in the lifecycle workflow instance.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTask](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTask.md)
Represents the configured tasks to execute and their execution sequence within a workflow.
This relationship is expanded by default.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
The result of processing the task.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubject.md)
The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask](Get-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultTask.md)
The related workflow task

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Per-user workflow execution results.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubject.md)
The unique identifier of the AAD user targeted for the taskProcessingResult.Supports $filter(eq, ne) and $expand.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult](Get-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult.md)
The associated individual task execution.

### [Get-MgIdentityGovernanceLifecycleWorkflowVersion](Get-MgIdentityGovernanceLifecycleWorkflowVersion.md)
The workflow versions that are available.

### [Get-MgIdentityGovernancePrivilegedAccess](Get-MgIdentityGovernancePrivilegedAccess.md)
Get privilegedAccess from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroup](Get-MgIdentityGovernancePrivilegedAccessGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Get assignmentApprovals from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Get steps from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Get assignmentSchedules from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleActivatedUsing](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleActivatedUsing.md)
Get activatedUsing from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleGroup](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Get assignmentScheduleInstances from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceActivatedUsing](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceActivatedUsing.md)
Get activatedUsing from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceGroup](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstancePrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstancePrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedulePrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedulePrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Get assignmentScheduleRequests from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestActivatedUsing](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestActivatedUsing.md)
Get activatedUsing from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestGroup](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestPrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestPrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestTargetSchedule](Get-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestTargetSchedule.md)
Get targetSchedule from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Get eligibilitySchedules from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleGroup](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Get eligibilityScheduleInstances from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceGroup](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstancePrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstancePrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedulePrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedulePrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Get eligibilityScheduleRequests from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestGroup](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestGroup.md)
Get group from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestPrincipal](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestPrincipal.md)
Get principal from identityGovernance

### [Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestTargetSchedule](Get-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestTargetSchedule.md)
Get targetSchedule from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlert](Get-MgIdentityGovernanceRoleManagementAlert.md)
Get alerts from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlertConfiguration](Get-MgIdentityGovernanceRoleManagementAlertConfiguration.md)
Get alertConfigurations from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlertConfigurationAlertDefinition](Get-MgIdentityGovernanceRoleManagementAlertConfigurationAlertDefinition.md)
Get alertDefinition from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlertDefinition](Get-MgIdentityGovernanceRoleManagementAlertDefinition.md)
Get alertDefinitions from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlertIncident](Get-MgIdentityGovernanceRoleManagementAlertIncident.md)
Get alertIncidents from identityGovernance

### [Get-MgIdentityGovernanceRoleManagementAlertOperation](Get-MgIdentityGovernanceRoleManagementAlertOperation.md)
Get operations from identityGovernance

### [Get-MgIdentityGovernanceTermOfUseAgreement](Get-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Get-MgIdentityGovernanceTermOfUseAgreementAcceptance](Get-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgIdentityGovernanceTermOfUseAgreementFile](Get-MgIdentityGovernanceTermOfUseAgreementFile.md)
Default PDF linked to this agreement.

### [Get-MgIdentityGovernanceTermOfUseAgreementFileLocalization](Get-MgIdentityGovernanceTermOfUseAgreementFileLocalization.md)
The localized version of the terms of use agreement files attached to the agreement.

### [Get-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Get-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Read-only.
Customized versions of the terms of use agreement in the Azure AD tenant.

### [Get-MgPrivilegedAccess](Get-MgPrivilegedAccess.md)
Get entity from privilegedAccess by key

### [Get-MgPrivilegedAccessResource](Get-MgPrivilegedAccessResource.md)
A collection of resources for the provider.

### [Get-MgPrivilegedAccessResourceParent](Get-MgPrivilegedAccessResourceParent.md)
Read-only.
The parent resource.
for pimforazurerbac scenario, it can represent the subscription the resource belongs to.

### [Get-MgPrivilegedAccessResourceRoleAssignment](Get-MgPrivilegedAccessResourceRoleAssignment.md)
The collection of role assignments for the resource.

### [Get-MgPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment](Get-MgPrivilegedAccessResourceRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequest](Get-MgPrivilegedAccessResourceRoleAssignmentRequest.md)
The collection of role assignment requests for the resource.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequestResource](Get-MgPrivilegedAccessResourceRoleAssignmentRequestResource.md)
Read-only.
The resource that the request aims to.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Read-only.
The role definition that the request aims to.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionResource](Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionRoleSetting](Get-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRequestSubject](Get-MgPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Read-only.
The user/group principal.

### [Get-MgPrivilegedAccessResourceRoleAssignmentResource](Get-MgPrivilegedAccessResourceRoleAssignmentResource.md)
Read-only.
The resource associated with the role assignment.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition](Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Read-only.
The role definition associated with the role assignment.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinitionResource](Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinitionRoleSetting](Get-MgPrivilegedAccessResourceRoleAssignmentRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgPrivilegedAccessResourceRoleAssignmentSubject](Get-MgPrivilegedAccessResourceRoleAssignmentSubject.md)
Read-only.
The subject associated with the role assignment.

### [Get-MgPrivilegedAccessResourceRoleDefinition](Get-MgPrivilegedAccessResourceRoleDefinition.md)
The collection of role defintions for the resource.

### [Get-MgPrivilegedAccessResourceRoleDefinitionResource](Get-MgPrivilegedAccessResourceRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgPrivilegedAccessResourceRoleDefinitionRoleSetting](Get-MgPrivilegedAccessResourceRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgPrivilegedAccessResourceRoleSetting](Get-MgPrivilegedAccessResourceRoleSetting.md)
The collection of role settings for the resource.

### [Get-MgPrivilegedAccessResourceRoleSettingResource](Get-MgPrivilegedAccessResourceRoleSettingResource.md)
Read-only.
The associated resource for this role setting.

### [Get-MgPrivilegedAccessResourceRoleSettingRoleDefinition](Get-MgPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Read-only.
The role definition that is enforced with this role setting.

### [Get-MgPrivilegedAccessResourceRoleSettingRoleDefinitionResource](Get-MgPrivilegedAccessResourceRoleSettingRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgPrivilegedAccessResourceRoleSettingRoleDefinitionRoleSetting](Get-MgPrivilegedAccessResourceRoleSettingRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgPrivilegedAccessRoleAssignment](Get-MgPrivilegedAccessRoleAssignment.md)
A collection of role assignments for the provider.

### [Get-MgPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment](Get-MgPrivilegedAccessRoleAssignmentLinkedEligibleRoleAssignment.md)
Read-only.
If this is an active assignment and created due to activation on an eligible assignment, it represents the object of that eligible assignment; Otherwise, the value is null.

### [Get-MgPrivilegedAccessRoleAssignmentRequest](Get-MgPrivilegedAccessRoleAssignmentRequest.md)
A collection of role assignment requests for the provider.

### [Get-MgPrivilegedAccessRoleAssignmentRequestResource](Get-MgPrivilegedAccessRoleAssignmentRequestResource.md)
Read-only.
The resource that the request aims to.

### [Get-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition](Get-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Read-only.
The role definition that the request aims to.

### [Get-MgPrivilegedAccessRoleAssignmentRequestSubject](Get-MgPrivilegedAccessRoleAssignmentRequestSubject.md)
Read-only.
The user/group principal.

### [Get-MgPrivilegedAccessRoleAssignmentResource](Get-MgPrivilegedAccessRoleAssignmentResource.md)
Read-only.
The resource associated with the role assignment.

### [Get-MgPrivilegedAccessRoleAssignmentRoleDefinition](Get-MgPrivilegedAccessRoleAssignmentRoleDefinition.md)
Read-only.
The role definition associated with the role assignment.

### [Get-MgPrivilegedAccessRoleAssignmentSubject](Get-MgPrivilegedAccessRoleAssignmentSubject.md)
Read-only.
The subject associated with the role assignment.

### [Get-MgPrivilegedAccessRoleDefinition](Get-MgPrivilegedAccessRoleDefinition.md)
A collection of role defintions for the provider.

### [Get-MgPrivilegedAccessRoleDefinitionResource](Get-MgPrivilegedAccessRoleDefinitionResource.md)
Read-only.
The associated resource for the role definition.

### [Get-MgPrivilegedAccessRoleDefinitionRoleSetting](Get-MgPrivilegedAccessRoleDefinitionRoleSetting.md)
The associated role setting for the role definition.

### [Get-MgPrivilegedAccessRoleSetting](Get-MgPrivilegedAccessRoleSetting.md)
A collection of role settings for the provider.

### [Get-MgPrivilegedAccessRoleSettingResource](Get-MgPrivilegedAccessRoleSettingResource.md)
Read-only.
The associated resource for this role setting.

### [Get-MgPrivilegedAccessRoleSettingRoleDefinition](Get-MgPrivilegedAccessRoleSettingRoleDefinition.md)
Read-only.
The role definition that is enforced with this role setting.

### [Get-MgPrivilegedApproval](Get-MgPrivilegedApproval.md)
Retrieve the properties and relationships of privilegedapproval object.

### [Get-MgPrivilegedApprovalRequest](Get-MgPrivilegedApprovalRequest.md)
Read-only.
The role assignment request for this approval object

### [Get-MgPrivilegedApprovalRoleInfo](Get-MgPrivilegedApprovalRoleInfo.md)
Get roleInfo from privilegedApproval

### [Get-MgPrivilegedApprovalRoleInfoAssignment](Get-MgPrivilegedApprovalRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedApprovalRoleInfoSetting](Get-MgPrivilegedApprovalRoleInfoSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedApprovalRoleInfoSummary](Get-MgPrivilegedApprovalRoleInfoSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedOperationEvent](Get-MgPrivilegedOperationEvent.md)
Get entity from privilegedOperationEvents by key

### [Get-MgPrivilegedRole](Get-MgPrivilegedRole.md)
Retrieve the properties and relationships of privilegedRole object.

### [Get-MgPrivilegedRoleAssignmentRequest](Get-MgPrivilegedRoleAssignmentRequest.md)
Get entity from privilegedRoleAssignmentRequests by key

### [Get-MgPrivilegedRoleAssignmentRequestRoleInfo](Get-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
The roleInfo object of the role assignment request.

### [Get-MgPrivilegedRoleAssignmentRequestRoleInfoAssignment](Get-MgPrivilegedRoleAssignmentRequestRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRequestRoleInfoSetting](Get-MgPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRequestRoleInfoSummary](Get-MgPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRoleInfo](Get-MgPrivilegedRoleAssignmentRoleInfo.md)
Read-only.
Nullable.
The associated role information.

### [Get-MgPrivilegedRoleAssignmentRoleInfoAssignment](Get-MgPrivilegedRoleAssignmentRoleInfoAssignment.md)
The assignments for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRoleInfoSetting](Get-MgPrivilegedRoleAssignmentRoleInfoSetting.md)
The settings for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleAssignmentRoleInfoSummary](Get-MgPrivilegedRoleAssignmentRoleInfoSummary.md)
The summary information for this role.
Read-only.
Nullable.

### [Get-MgPrivilegedRoleRoleAssignment](Get-MgPrivilegedRoleRoleAssignment.md)
Retrieve the properties and relationships of privilegedRoleAssignment object.

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

### [Initialize-MgIdentityGovernanceLifecycleWorkflow](Initialize-MgIdentityGovernanceLifecycleWorkflow.md)
Invoke action activate

### [Initialize-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Initialize-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Invoke action activate

### [Invoke-MgAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation](Invoke-MgAcceptIdentityGovernanceAccessReviewDecisionInstanceRecommendation.md)
Invoke action acceptRecommendations

### [Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation](Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation.md)
Invoke action acceptRecommendations

### [Invoke-MgBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision](Invoke-MgBatchIdentityGovernanceAccessReviewDecisionInstanceRecordDecision.md)
Invoke action batchRecordDecisions

### [Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision](Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision.md)
Invoke action batchRecordDecisions

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentRequestByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDecisionInstanceStageDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser](Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser](Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser](Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentApprovalByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstanceByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestByCurrentUser](Invoke-MgFilterIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequestByCurrentUser.md)
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

### [Invoke-MgRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision](Invoke-MgRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Invoke action recordAllDecisions

### [Invoke-MgRemediateIdentityGovernanceRoleManagementAlertIncident](Invoke-MgRemediateIdentityGovernanceRoleManagementAlertIncident.md)
Invoke action remediate

### [Invoke-MgSelfPrivilegedApprovalRoleInfoActivate](Invoke-MgSelfPrivilegedApprovalRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgSelfPrivilegedApprovalRoleInfoDeactivate](Invoke-MgSelfPrivilegedApprovalRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgSelfPrivilegedRoleActivate](Invoke-MgSelfPrivilegedRoleActivate.md)
Invoke action selfActivate

### [Invoke-MgSelfPrivilegedRoleAssignmentRequestRoleInfoActivate](Invoke-MgSelfPrivilegedRoleAssignmentRequestRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate](Invoke-MgSelfPrivilegedRoleAssignmentRequestRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgSelfPrivilegedRoleAssignmentRoleInfoActivate](Invoke-MgSelfPrivilegedRoleAssignmentRoleInfoActivate.md)
Invoke action selfActivate

### [Invoke-MgSelfPrivilegedRoleAssignmentRoleInfoDeactivate](Invoke-MgSelfPrivilegedRoleAssignmentRoleInfoDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgSelfPrivilegedRoleDeactivate](Invoke-MgSelfPrivilegedRoleDeactivate.md)
Invoke action selfDeactivate

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRun](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRun.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowTaskReport](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowTaskReport.md)
Invoke function summary

### [Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult](Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowUserProcessingResult.md)
Invoke function summary

### [Move-MgEntitlementManagementAccessPackageToCatalog](Move-MgEntitlementManagementAccessPackageToCatalog.md)
Invoke action moveToCatalog

### [New-MgAccessReview](New-MgAccessReview.md)
In the Azure AD access reviews feature, create a new accessReview object.
Before making this request, the caller must have previously retrieved the list of business flow templates, to have the value of **businessFlowTemplateId** to include in the request.
After making this request, the caller should create a programControl, to link the access review to a program.

### [New-MgAccessReviewDecision](New-MgAccessReviewDecision.md)
Create new navigation property to decisions for accessReviews

### [New-MgAccessReviewInstance](New-MgAccessReviewInstance.md)
Create new navigation property to instances for accessReviews

### [New-MgAccessReviewInstanceDecision](New-MgAccessReviewInstanceDecision.md)
Create new navigation property to decisions for accessReviews

### [New-MgAccessReviewInstanceMyDecision](New-MgAccessReviewInstanceMyDecision.md)
Create new navigation property to myDecisions for accessReviews

### [New-MgAccessReviewInstanceReviewer](New-MgAccessReviewInstanceReviewer.md)
Create new navigation property to reviewers for accessReviews

### [New-MgAccessReviewMyDecision](New-MgAccessReviewMyDecision.md)
Create new navigation property to myDecisions for accessReviews

### [New-MgAccessReviewReviewer](New-MgAccessReviewReviewer.md)
Create new navigation property to reviewers for accessReviews

### [New-MgAgreement](New-MgAgreement.md)
Add new entity to agreements

### [New-MgAgreementAcceptance](New-MgAgreementAcceptance.md)
Create new navigation property to acceptances for agreements

### [New-MgAgreementFileLocalization](New-MgAgreementFileLocalization.md)
Create new navigation property to localizations for agreements

### [New-MgAgreementFileLocalizationVersion](New-MgAgreementFileLocalizationVersion.md)
Create new navigation property to versions for agreements

### [New-MgBusinessFlowTemplate](New-MgBusinessFlowTemplate.md)
Add new entity to businessFlowTemplates

### [New-MgEntitlementManagementAccessPackage](New-MgEntitlementManagementAccessPackage.md)
Create new navigation property to accessPackages for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignment](New-MgEntitlementManagementAccessPackageAssignment.md)
Create a new entitlement management accessPackageAssignment

### [New-MgEntitlementManagementAccessPackageAssignmentPolicy](New-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Create new navigation property to accessPackageAssignmentPolicies for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Create new navigation property to customExtensionHandlers for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](New-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Create new navigation property to customExtensionStageSettings for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignmentRequest](New-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Create new navigation property to accessPackageAssignmentRequests for identityGovernance

### [New-MgEntitlementManagementAccessPackageCatalog](New-MgEntitlementManagementAccessPackageCatalog.md)
Create new navigation property to accessPackageCatalogs for identityGovernance

### [New-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](New-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Create new navigation property to accessPackageCustomWorkflowExtensions for identityGovernance

### [New-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](New-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Create new navigation property to customAccessPackageWorkflowExtensions for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Create new navigation property ref to incompatibleAccessPackages for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Create new navigation property ref to incompatibleGroups for identityGovernance

### [New-MgEntitlementManagementAccessPackageResourceRequest](New-MgEntitlementManagementAccessPackageResourceRequest.md)
Create new navigation property to accessPackageResourceRequests for identityGovernance

### [New-MgEntitlementManagementAccessPackageResourceRoleScope](New-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Create new navigation property to accessPackageResourceRoleScopes for identityGovernance

### [New-MgEntitlementManagementConnectedOrganization](New-MgEntitlementManagementConnectedOrganization.md)
Create new navigation property to connectedOrganizations for identityGovernance

### [New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Create new navigation property ref to externalSponsors for identityGovernance

### [New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Create new navigation property ref to internalSponsors for identityGovernance

### [New-MgEntitlementManagementSubject](New-MgEntitlementManagementSubject.md)
Create new navigation property to subjects for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecision](New-MgIdentityGovernanceAccessReviewDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInsight](New-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](New-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Create new navigation property to contactedReviewers for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](New-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](New-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceStage](New-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Create new navigation property to decisions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](New-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Create new navigation property to insights for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinition](New-MgIdentityGovernanceAccessReviewDefinition.md)
Create new navigation property to definitions for identityGovernance

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

### [New-MgIdentityGovernanceAccessReviewHistoryDefinition](New-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Create new navigation property to historyDefinitions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri](New-MgIdentityGovernanceAccessReviewHistoryDefinitionInstanceDownloadUri.md)
Invoke action generateDownloadUri

### [New-MgIdentityGovernanceAppConsentRequest](New-MgIdentityGovernanceAppConsentRequest.md)
Create new navigation property to appConsentRequests for identityGovernance

### [New-MgIdentityGovernanceAppConsentRequestUserConsentRequest](New-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Create new navigation property to userConsentRequests for identityGovernance

### [New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Create new navigation property to steps for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflow](New-MgIdentityGovernanceLifecycleWorkflow.md)
Create new navigation property to workflows for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](New-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Create new navigation property to customTaskExtensions for identityGovernance

### [New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion](New-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflowNewVersion.md)
Invoke action createNewVersion

### [New-MgIdentityGovernanceLifecycleWorkflowNewVersion](New-MgIdentityGovernanceLifecycleWorkflowNewVersion.md)
Invoke action createNewVersion

### [New-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval](New-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Create new navigation property to assignmentApprovals for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](New-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Create new navigation property to steps for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](New-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Create new navigation property to assignmentSchedules for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Create new navigation property to assignmentScheduleInstances for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](New-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Create new navigation property to assignmentScheduleRequests for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](New-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Create new navigation property to eligibilitySchedules for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](New-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Create new navigation property to eligibilityScheduleInstances for identityGovernance

### [New-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](New-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Create new navigation property to eligibilityScheduleRequests for identityGovernance

### [New-MgIdentityGovernanceRoleManagementAlert](New-MgIdentityGovernanceRoleManagementAlert.md)
Create new navigation property to alerts for identityGovernance

### [New-MgIdentityGovernanceRoleManagementAlertConfiguration](New-MgIdentityGovernanceRoleManagementAlertConfiguration.md)
Create new navigation property to alertConfigurations for identityGovernance

### [New-MgIdentityGovernanceRoleManagementAlertDefinition](New-MgIdentityGovernanceRoleManagementAlertDefinition.md)
Create new navigation property to alertDefinitions for identityGovernance

### [New-MgIdentityGovernanceRoleManagementAlertIncident](New-MgIdentityGovernanceRoleManagementAlertIncident.md)
Create new navigation property to alertIncidents for identityGovernance

### [New-MgIdentityGovernanceRoleManagementAlertOperation](New-MgIdentityGovernanceRoleManagementAlertOperation.md)
Create new navigation property to operations for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreement](New-MgIdentityGovernanceTermOfUseAgreement.md)
Create new navigation property to agreements for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementAcceptance](New-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Create new navigation property to agreementAcceptances for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementFileLocalization](New-MgIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Create new navigation property to localizations for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](New-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Create new navigation property to versions for identityGovernance

### [New-MgPrivilegedAccess](New-MgPrivilegedAccess.md)
Add new entity to privilegedAccess

### [New-MgPrivilegedAccessResource](New-MgPrivilegedAccessResource.md)
Create new navigation property to resources for privilegedAccess

### [New-MgPrivilegedAccessResourceRoleAssignment](New-MgPrivilegedAccessResourceRoleAssignment.md)
Create new navigation property to roleAssignments for privilegedAccess

### [New-MgPrivilegedAccessResourceRoleAssignmentRequest](New-MgPrivilegedAccessResourceRoleAssignmentRequest.md)
Create new navigation property to roleAssignmentRequests for privilegedAccess

### [New-MgPrivilegedAccessResourceRoleDefinition](New-MgPrivilegedAccessResourceRoleDefinition.md)
Create new navigation property to roleDefinitions for privilegedAccess

### [New-MgPrivilegedAccessResourceRoleSetting](New-MgPrivilegedAccessResourceRoleSetting.md)
Create new navigation property to roleSettings for privilegedAccess

### [New-MgPrivilegedAccessRoleAssignment](New-MgPrivilegedAccessRoleAssignment.md)
Create new navigation property to roleAssignments for privilegedAccess

### [New-MgPrivilegedAccessRoleAssignmentRequest](New-MgPrivilegedAccessRoleAssignmentRequest.md)
Create new navigation property to roleAssignmentRequests for privilegedAccess

### [New-MgPrivilegedAccessRoleDefinition](New-MgPrivilegedAccessRoleDefinition.md)
Create new navigation property to roleDefinitions for privilegedAccess

### [New-MgPrivilegedAccessRoleSetting](New-MgPrivilegedAccessRoleSetting.md)
Create new navigation property to roleSettings for privilegedAccess

### [New-MgPrivilegedApproval](New-MgPrivilegedApproval.md)
Use this API to create a new privilegedApproval.

### [New-MgPrivilegedOperationEvent](New-MgPrivilegedOperationEvent.md)
Add new entity to privilegedOperationEvents

### [New-MgPrivilegedRole](New-MgPrivilegedRole.md)
Add new entity to privilegedRoles

### [New-MgPrivilegedRoleAssignment](New-MgPrivilegedRoleAssignment.md)
Use this API to create a new  privilegedRoleAssignment.

### [New-MgPrivilegedRoleAssignmentEligible](New-MgPrivilegedRoleAssignmentEligible.md)
Invoke action makeEligible

### [New-MgPrivilegedRoleAssignmentPermanent](New-MgPrivilegedRoleAssignmentPermanent.md)
Invoke action makePermanent

### [New-MgPrivilegedRoleAssignmentRequest](New-MgPrivilegedRoleAssignmentRequest.md)
Create a privilegedroleassignmentrequest object.

### [New-MgProgram](New-MgProgram.md)
In the Azure AD access reviews feature, create a new program object.

### [New-MgProgramControl](New-MgProgramControl.md)
In the Azure AD access reviews feature, create a new programControl object.
This links an access review to a program.
Prior to making this request, the caller must have previously

### [New-MgProgramControlType](New-MgProgramControlType.md)
Add new entity to programControlTypes

### [Register-MgPrivilegedAccessResource](Register-MgPrivilegedAccessResource.md)
Invoke action register

### [Remove-MgAccessReview](Remove-MgAccessReview.md)
In the Azure AD access reviews feature, delete an accessReview object.

### [Remove-MgAccessReviewDecision](Remove-MgAccessReviewDecision.md)
Delete navigation property decisions for accessReviews

### [Remove-MgAccessReviewInstance](Remove-MgAccessReviewInstance.md)
Delete navigation property instances for accessReviews

### [Remove-MgAccessReviewInstanceDecision](Remove-MgAccessReviewInstanceDecision.md)
Delete navigation property decisions for accessReviews

### [Remove-MgAccessReviewInstanceMyDecision](Remove-MgAccessReviewInstanceMyDecision.md)
Delete navigation property myDecisions for accessReviews

### [Remove-MgAccessReviewInstanceReviewer](Remove-MgAccessReviewInstanceReviewer.md)
Delete navigation property reviewers for accessReviews

### [Remove-MgAccessReviewMyDecision](Remove-MgAccessReviewMyDecision.md)
Delete navigation property myDecisions for accessReviews

### [Remove-MgAccessReviewReviewer](Remove-MgAccessReviewReviewer.md)
Delete navigation property reviewers for accessReviews

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

### [Remove-MgBusinessFlowTemplate](Remove-MgBusinessFlowTemplate.md)
Delete entity from businessFlowTemplates

### [Remove-MgEntitlementManagementAccessPackage](Remove-MgEntitlementManagementAccessPackage.md)
Delete navigation property accessPackages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignment](Remove-MgEntitlementManagementAccessPackageAssignment.md)
Delete navigation property accessPackageAssignments for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentApproval](Remove-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Delete navigation property accessPackageAssignmentApprovals for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStep](Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Delete navigation property accessPackageAssignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Delete navigation property customExtensionHandlers for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Remove-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Delete navigation property customExtensionStageSettings for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentRequest](Remove-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Delete navigation property accessPackageAssignmentRequests for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageCatalog](Remove-MgEntitlementManagementAccessPackageCatalog.md)
Delete navigation property accessPackageCatalogs for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Remove-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Delete navigation property accessPackageCustomWorkflowExtensions for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Remove-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Delete navigation property customAccessPackageWorkflowExtensions for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Delete ref of navigation property incompatibleAccessPackages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Delete ref of navigation property incompatibleGroups for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageResourceRequest](Remove-MgEntitlementManagementAccessPackageResourceRequest.md)
Delete navigation property accessPackageResourceRequests for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageResourceRoleScope](Remove-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Delete navigation property accessPackageResourceRoleScopes for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganization](Remove-MgEntitlementManagementConnectedOrganization.md)
Delete navigation property connectedOrganizations for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Delete ref of navigation property externalSponsors for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Delete ref of navigation property internalSponsors for identityGovernance

### [Remove-MgEntitlementManagementSubject](Remove-MgEntitlementManagementSubject.md)
Delete navigation property subjects for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecision](Remove-MgIdentityGovernanceAccessReviewDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstance](Remove-MgIdentityGovernanceAccessReviewDecisionInstance.md)
Delete navigation property instance for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinition](Remove-MgIdentityGovernanceAccessReviewDefinition.md)
Delete navigation property definitions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstance](Remove-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Delete navigation property insights for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
Delete navigation property instance for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewHistoryDefinition](Remove-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Delete navigation property historyDefinitions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Remove-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewPolicy](Remove-MgIdentityGovernanceAccessReviewPolicy.md)
Delete navigation property policy for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequest](Remove-MgIdentityGovernanceAppConsentRequest.md)
Delete navigation property appConsentRequests for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Delete navigation property userConsentRequests for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Delete navigation property approval for identityGovernance

### [Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Remove-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflow](Remove-MgIdentityGovernanceLifecycleWorkflow.md)
Delete navigation property workflows for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Remove-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Delete navigation property customTaskExtensions for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItem](Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItem.md)
Delete navigation property deletedItems for identityGovernance

### [Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Remove-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Delete navigation property workflows for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccess](Remove-MgIdentityGovernancePrivilegedAccess.md)
Delete navigation property privilegedAccess for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroup](Remove-MgIdentityGovernancePrivilegedAccessGroup.md)
Delete navigation property group for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Delete navigation property assignmentApprovals for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Delete navigation property steps for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Delete navigation property assignmentSchedules for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Delete navigation property assignmentScheduleInstances for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Remove-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Delete navigation property assignmentScheduleRequests for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Delete navigation property eligibilitySchedules for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Delete navigation property eligibilityScheduleInstances for identityGovernance

### [Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Remove-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Delete navigation property eligibilityScheduleRequests for identityGovernance

### [Remove-MgIdentityGovernanceRoleManagementAlert](Remove-MgIdentityGovernanceRoleManagementAlert.md)
Delete navigation property alerts for identityGovernance

### [Remove-MgIdentityGovernanceRoleManagementAlertConfiguration](Remove-MgIdentityGovernanceRoleManagementAlertConfiguration.md)
Delete navigation property alertConfigurations for identityGovernance

### [Remove-MgIdentityGovernanceRoleManagementAlertDefinition](Remove-MgIdentityGovernanceRoleManagementAlertDefinition.md)
Delete navigation property alertDefinitions for identityGovernance

### [Remove-MgIdentityGovernanceRoleManagementAlertIncident](Remove-MgIdentityGovernanceRoleManagementAlertIncident.md)
Delete navigation property alertIncidents for identityGovernance

### [Remove-MgIdentityGovernanceRoleManagementAlertOperation](Remove-MgIdentityGovernanceRoleManagementAlertOperation.md)
Delete navigation property operations for identityGovernance

### [Remove-MgIdentityGovernanceTermOfUseAgreement](Remove-MgIdentityGovernanceTermOfUseAgreement.md)
Delete navigation property agreements for identityGovernance

### [Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance](Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Delete navigation property agreementAcceptances for identityGovernance

### [Remove-MgIdentityGovernanceTermOfUseAgreementFile](Remove-MgIdentityGovernanceTermOfUseAgreementFile.md)
Delete navigation property file for identityGovernance

### [Remove-MgIdentityGovernanceTermOfUseAgreementFileLocalization](Remove-MgIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Delete navigation property localizations for identityGovernance

### [Remove-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Remove-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Delete navigation property versions for identityGovernance

### [Remove-MgPrivilegedAccess](Remove-MgPrivilegedAccess.md)
Delete entity from privilegedAccess

### [Remove-MgPrivilegedAccessResource](Remove-MgPrivilegedAccessResource.md)
Delete navigation property resources for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignment](Remove-MgPrivilegedAccessResourceRoleAssignment.md)
Delete navigation property roleAssignments for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignmentRequest](Remove-MgPrivilegedAccessResourceRoleAssignmentRequest.md)
Delete navigation property roleAssignmentRequests for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Remove-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignmentRequestSubject](Remove-MgPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition](Remove-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleAssignmentSubject](Remove-MgPrivilegedAccessResourceRoleAssignmentSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleDefinition](Remove-MgPrivilegedAccessResourceRoleDefinition.md)
Delete navigation property roleDefinitions for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleSetting](Remove-MgPrivilegedAccessResourceRoleSetting.md)
Delete navigation property roleSettings for privilegedAccess

### [Remove-MgPrivilegedAccessResourceRoleSettingRoleDefinition](Remove-MgPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignment](Remove-MgPrivilegedAccessRoleAssignment.md)
Delete navigation property roleAssignments for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignmentRequest](Remove-MgPrivilegedAccessRoleAssignmentRequest.md)
Delete navigation property roleAssignmentRequests for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition](Remove-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignmentRequestSubject](Remove-MgPrivilegedAccessRoleAssignmentRequestSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignmentRoleDefinition](Remove-MgPrivilegedAccessRoleAssignmentRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedAccessRoleAssignmentSubject](Remove-MgPrivilegedAccessRoleAssignmentSubject.md)
Delete navigation property subject for privilegedAccess

### [Remove-MgPrivilegedAccessRoleDefinition](Remove-MgPrivilegedAccessRoleDefinition.md)
Delete navigation property roleDefinitions for privilegedAccess

### [Remove-MgPrivilegedAccessRoleSetting](Remove-MgPrivilegedAccessRoleSetting.md)
Delete navigation property roleSettings for privilegedAccess

### [Remove-MgPrivilegedAccessRoleSettingRoleDefinition](Remove-MgPrivilegedAccessRoleSettingRoleDefinition.md)
Delete navigation property roleDefinition for privilegedAccess

### [Remove-MgPrivilegedApproval](Remove-MgPrivilegedApproval.md)
Delete entity from privilegedApproval

### [Remove-MgPrivilegedApprovalRoleInfo](Remove-MgPrivilegedApprovalRoleInfo.md)
Delete navigation property roleInfo for privilegedApproval

### [Remove-MgPrivilegedApprovalRoleInfoSetting](Remove-MgPrivilegedApprovalRoleInfoSetting.md)
Delete navigation property settings for privilegedApproval

### [Remove-MgPrivilegedApprovalRoleInfoSummary](Remove-MgPrivilegedApprovalRoleInfoSummary.md)
Delete navigation property summary for privilegedApproval

### [Remove-MgPrivilegedOperationEvent](Remove-MgPrivilegedOperationEvent.md)
Delete entity from privilegedOperationEvents

### [Remove-MgPrivilegedRole](Remove-MgPrivilegedRole.md)
Delete entity from privilegedRoles

### [Remove-MgPrivilegedRoleAssignment](Remove-MgPrivilegedRoleAssignment.md)
Delete privilegedRoleAssignment.

### [Remove-MgPrivilegedRoleAssignmentRequest](Remove-MgPrivilegedRoleAssignmentRequest.md)
Delete entity from privilegedRoleAssignmentRequests

### [Remove-MgPrivilegedRoleAssignmentRequestRoleInfo](Remove-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
Delete navigation property roleInfo for privilegedRoleAssignmentRequests

### [Remove-MgPrivilegedRoleAssignmentRequestRoleInfoSetting](Remove-MgPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Delete navigation property settings for privilegedRoleAssignmentRequests

### [Remove-MgPrivilegedRoleAssignmentRequestRoleInfoSummary](Remove-MgPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Delete navigation property summary for privilegedRoleAssignmentRequests

### [Remove-MgPrivilegedRoleAssignmentRoleInfo](Remove-MgPrivilegedRoleAssignmentRoleInfo.md)
Delete navigation property roleInfo for privilegedRoleAssignments

### [Remove-MgPrivilegedRoleAssignmentRoleInfoSetting](Remove-MgPrivilegedRoleAssignmentRoleInfoSetting.md)
Delete navigation property settings for privilegedRoleAssignments

### [Remove-MgPrivilegedRoleAssignmentRoleInfoSummary](Remove-MgPrivilegedRoleAssignmentRoleInfoSummary.md)
Delete navigation property summary for privilegedRoleAssignments

### [Remove-MgPrivilegedRoleSetting](Remove-MgPrivilegedRoleSetting.md)
Delete navigation property settings for privilegedRoles

### [Remove-MgPrivilegedRoleSummary](Remove-MgPrivilegedRoleSummary.md)
Delete navigation property summary for privilegedRoles

### [Remove-MgProgram](Remove-MgProgram.md)
In the Azure AD access reviews feature, delete a program object.
Do not delete a program which still has `programControl` linked to it, those access reviews should first be deleted or unlinked from the program and linked to a different program.
Also, please note that the built-in default program cannot be deleted.

### [Remove-MgProgramControl](Remove-MgProgramControl.md)
In the Azure AD access reviews feature, delete a programControl object.
This unlinks an access review from a program.

### [Remove-MgProgramControlProgram](Remove-MgProgramControlProgram.md)
Delete navigation property program for programControls

### [Remove-MgProgramControlType](Remove-MgProgramControlType.md)
Delete entity from programControlTypes

### [Reset-MgAccessReviewDecision](Reset-MgAccessReviewDecision.md)
Invoke action resetDecisions

### [Reset-MgAccessReviewInstanceDecision](Reset-MgAccessReviewInstanceDecision.md)
Invoke action resetDecisions

### [Reset-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Reset-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Invoke action resetDecisions

### [Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Invoke action resetDecisions

### [Restore-MgIdentityGovernanceLifecycleWorkflow](Restore-MgIdentityGovernanceLifecycleWorkflow.md)
Invoke action restore

### [Restore-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow](Restore-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow.md)
Invoke action restore

### [Resume-MgEntitlementManagementAccessPackageAssignmentRequest](Resume-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action resume

### [Resume-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult.md)
Invoke action resume

### [Resume-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResult.md)
Invoke action resume

### [Resume-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult](Resume-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResult.md)
Invoke action resume

### [Select-MgEntitlementManagementAccessPackage](Select-MgEntitlementManagementAccessPackage.md)
Select matching entitlement management accessPackage

### [Select-MgEntitlementManagementAccessPackageAssignmentPolicy](Select-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Select matching entitlement management accessPackageAssignmentPolicy

### [Send-MgAccessReviewInstanceReminder](Send-MgAccessReviewInstanceReminder.md)
Invoke action sendReminder

### [Send-MgAccessReviewReminder](Send-MgAccessReviewReminder.md)
Invoke action sendReminder

### [Send-MgIdentityGovernanceAccessReviewDecisionInstanceReminder](Send-MgIdentityGovernanceAccessReviewDecisionInstanceReminder.md)
Invoke action sendReminder

### [Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder](Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder.md)
Invoke action sendReminder

### [Set-MgEntitlementManagementAccessPackageAssignmentPolicy](Set-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

### [Split-MgEntitlementManagementConnectedOrganization](Split-MgEntitlementManagementConnectedOrganization.md)
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgEntitlementManagementConnectedOrganization, to simplify reporting.

### [Stop-MgAccessReview](Stop-MgAccessReview.md)
Invoke action stop

### [Stop-MgAccessReviewInstance](Stop-MgAccessReviewInstance.md)
Invoke action stop

### [Stop-MgEntitlementManagementAccessPackageAssignmentRequest](Stop-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action cancel

### [Stop-MgIdentityGovernanceAccessReviewDecisionInstance](Stop-MgIdentityGovernanceAccessReviewDecisionInstance.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Stop-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinition](Stop-MgIdentityGovernanceAccessReviewDefinition.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstance](Stop-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Invoke action stop

### [Stop-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Stop-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Invoke action cancel

### [Stop-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Stop-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Invoke action cancel

### [Stop-MgPrivilegedAccessResourceRoleAssignmentRequest](Stop-MgPrivilegedAccessResourceRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgPrivilegedAccessRoleAssignmentRequest](Stop-MgPrivilegedAccessRoleAssignmentRequest.md)
Invoke action cancel

### [Stop-MgPrivilegedRoleAssignmentRequest](Stop-MgPrivilegedRoleAssignmentRequest.md)
Invoke action cancel

### [Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty.md)
Invoke action validateProperties

### [Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty.md)
Invoke action validateProperties

### [Update-MgAccessReview](Update-MgAccessReview.md)
In the Azure AD access reviews feature, update an existing accessReview object to change one or more of its properties.
This API is not intended to change the reviewers or decisions of a review.
To change the reviewers, use the addReviewer or removeReviewer APIs.
To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API.
To apply the decisions to the target group or app access rights, use the apply API.

### [Update-MgAccessReviewDecision](Update-MgAccessReviewDecision.md)
Update the navigation property decisions in accessReviews

### [Update-MgAccessReviewInstance](Update-MgAccessReviewInstance.md)
Update the navigation property instances in accessReviews

### [Update-MgAccessReviewInstanceDecision](Update-MgAccessReviewInstanceDecision.md)
Update the navigation property decisions in accessReviews

### [Update-MgAccessReviewInstanceMyDecision](Update-MgAccessReviewInstanceMyDecision.md)
Update the navigation property myDecisions in accessReviews

### [Update-MgAccessReviewInstanceReviewer](Update-MgAccessReviewInstanceReviewer.md)
Update the navigation property reviewers in accessReviews

### [Update-MgAccessReviewMyDecision](Update-MgAccessReviewMyDecision.md)
Update the navigation property myDecisions in accessReviews

### [Update-MgAccessReviewReviewer](Update-MgAccessReviewReviewer.md)
Update the navigation property reviewers in accessReviews

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

### [Update-MgBusinessFlowTemplate](Update-MgBusinessFlowTemplate.md)
Update entity in businessFlowTemplates

### [Update-MgEntitlementManagementAccessPackage](Update-MgEntitlementManagementAccessPackage.md)
Update the navigation property accessPackages in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignment](Update-MgEntitlementManagementAccessPackageAssignment.md)
Invoke action reprocess

### [Update-MgEntitlementManagementAccessPackageAssignmentApproval](Update-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Update the navigation property accessPackageAssignmentApprovals in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentApprovalStep](Update-MgEntitlementManagementAccessPackageAssignmentApprovalStep.md)
Update the navigation property steps in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler](Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionHandler.md)
Update the navigation property customExtensionHandlers in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting](Update-MgEntitlementManagementAccessPackageAssignmentPolicyCustomExtensionStageSetting.md)
Update the navigation property customExtensionStageSettings in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentRequest](Update-MgEntitlementManagementAccessPackageAssignmentRequest.md)
Invoke action reprocess

### [Update-MgEntitlementManagementAccessPackageCatalog](Update-MgEntitlementManagementAccessPackageCatalog.md)
Update the navigation property accessPackageCatalogs in identityGovernance

### [Update-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension](Update-MgEntitlementManagementAccessPackageCatalogAccessPackageCustomWorkflowExtension.md)
Update the navigation property accessPackageCustomWorkflowExtensions in identityGovernance

### [Update-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension](Update-MgEntitlementManagementAccessPackageCatalogCustomAccessPackageWorkflowExtension.md)
Update the navigation property customAccessPackageWorkflowExtensions in identityGovernance

### [Update-MgEntitlementManagementAccessPackageResourceRequest](Update-MgEntitlementManagementAccessPackageResourceRequest.md)
Update the navigation property accessPackageResourceRequests in identityGovernance

### [Update-MgEntitlementManagementAccessPackageResourceRoleScope](Update-MgEntitlementManagementAccessPackageResourceRoleScope.md)
Update the navigation property accessPackageResourceRoleScopes in identityGovernance

### [Update-MgEntitlementManagementConnectedOrganization](Update-MgEntitlementManagementConnectedOrganization.md)
Update the navigation property connectedOrganizations in identityGovernance

### [Update-MgEntitlementManagementSetting](Update-MgEntitlementManagementSetting.md)
Update the navigation property settings in identityGovernance

### [Update-MgEntitlementManagementSubject](Update-MgEntitlementManagementSubject.md)
Update the navigation property subjects in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecision](Update-MgIdentityGovernanceAccessReviewDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInsight](Update-MgIdentityGovernanceAccessReviewDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstance](Update-MgIdentityGovernanceAccessReviewDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer](Update-MgIdentityGovernanceAccessReviewDecisionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecision](Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight](Update-MgIdentityGovernanceAccessReviewDecisionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceStage](Update-MgIdentityGovernanceAccessReviewDecisionInstanceStage.md)
Update the navigation property stages in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision](Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight](Update-MgIdentityGovernanceAccessReviewDecisionInstanceStageDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinition](Update-MgIdentityGovernanceAccessReviewDefinition.md)
Update the navigation property definitions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstance](Update-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInsight.md)
Update the navigation property insights in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecisionInstance.md)
Update the navigation property instance in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Update the navigation property stages in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewHistoryDefinition](Update-MgIdentityGovernanceAccessReviewHistoryDefinition.md)
Update the navigation property historyDefinitions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance](Update-MgIdentityGovernanceAccessReviewHistoryDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewPolicy](Update-MgIdentityGovernanceAccessReviewPolicy.md)
Update the navigation property policy in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequest](Update-MgIdentityGovernanceAppConsentRequest.md)
Update the navigation property appConsentRequests in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
Update the navigation property userConsentRequests in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Update the navigation property approval in identityGovernance

### [Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep](Update-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStep.md)
Update the navigation property steps in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflow](Update-MgIdentityGovernanceLifecycleWorkflow.md)
Update the navigation property workflows in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtension.md)
Update the navigation property customTaskExtensions in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionCreatedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowCustomTaskExtensionLastModifiedByMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowExecutionScopeMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowExecutionScopeMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowRunTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowRunUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowSetting](Update-MgIdentityGovernanceLifecycleWorkflowSetting.md)
Update the navigation property settings in identityGovernance

### [Update-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowTaskReportTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowTemplateTaskProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting](Update-MgIdentityGovernanceLifecycleWorkflowUserProcessingResultSubjectMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgIdentityGovernancePrivilegedAccess](Update-MgIdentityGovernancePrivilegedAccess.md)
Update the navigation property privilegedAccess in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroup](Update-MgIdentityGovernancePrivilegedAccessGroup.md)
Update the navigation property group in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval](Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentApproval.md)
Update the navigation property assignmentApprovals in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep](Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStep.md)
Update the navigation property steps in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule](Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule.md)
Update the navigation property assignmentSchedules in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance](Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleInstance.md)
Update the navigation property assignmentScheduleInstances in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest](Update-MgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleRequest.md)
Update the navigation property assignmentScheduleRequests in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule](Update-MgIdentityGovernancePrivilegedAccessGroupEligibilitySchedule.md)
Update the navigation property eligibilitySchedules in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance](Update-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleInstance.md)
Update the navigation property eligibilityScheduleInstances in identityGovernance

### [Update-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest](Update-MgIdentityGovernancePrivilegedAccessGroupEligibilityScheduleRequest.md)
Update the navigation property eligibilityScheduleRequests in identityGovernance

### [Update-MgIdentityGovernanceRoleManagementAlert](Update-MgIdentityGovernanceRoleManagementAlert.md)
Update the navigation property alerts in identityGovernance

### [Update-MgIdentityGovernanceRoleManagementAlertConfiguration](Update-MgIdentityGovernanceRoleManagementAlertConfiguration.md)
Update the navigation property alertConfigurations in identityGovernance

### [Update-MgIdentityGovernanceRoleManagementAlertDefinition](Update-MgIdentityGovernanceRoleManagementAlertDefinition.md)
Update the navigation property alertDefinitions in identityGovernance

### [Update-MgIdentityGovernanceRoleManagementAlertIncident](Update-MgIdentityGovernanceRoleManagementAlertIncident.md)
Update the navigation property alertIncidents in identityGovernance

### [Update-MgIdentityGovernanceRoleManagementAlertOperation](Update-MgIdentityGovernanceRoleManagementAlertOperation.md)
Update the navigation property operations in identityGovernance

### [Update-MgIdentityGovernanceTermOfUseAgreement](Update-MgIdentityGovernanceTermOfUseAgreement.md)
Update the navigation property agreements in identityGovernance

### [Update-MgIdentityGovernanceTermOfUseAgreementAcceptance](Update-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Update the navigation property agreementAcceptances in identityGovernance

### [Update-MgIdentityGovernanceTermOfUseAgreementFile](Update-MgIdentityGovernanceTermOfUseAgreementFile.md)
Update the navigation property file in identityGovernance

### [Update-MgIdentityGovernanceTermOfUseAgreementFileLocalization](Update-MgIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Update the navigation property localizations in identityGovernance

### [Update-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](Update-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Update the navigation property versions in identityGovernance

### [Update-MgPrivilegedAccess](Update-MgPrivilegedAccess.md)
Update entity in privilegedAccess

### [Update-MgPrivilegedAccessResource](Update-MgPrivilegedAccessResource.md)
Update the navigation property resources in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignment](Update-MgPrivilegedAccessResourceRoleAssignment.md)
Update the navigation property roleAssignments in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignmentRequest](Update-MgPrivilegedAccessResourceRoleAssignmentRequest.md)
Update the navigation property roleAssignmentRequests in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition](Update-MgPrivilegedAccessResourceRoleAssignmentRequestRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignmentRequestSubject](Update-MgPrivilegedAccessResourceRoleAssignmentRequestSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition](Update-MgPrivilegedAccessResourceRoleAssignmentRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleAssignmentSubject](Update-MgPrivilegedAccessResourceRoleAssignmentSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleDefinition](Update-MgPrivilegedAccessResourceRoleDefinition.md)
Update the navigation property roleDefinitions in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleSetting](Update-MgPrivilegedAccessResourceRoleSetting.md)
Update the navigation property roleSettings in privilegedAccess

### [Update-MgPrivilegedAccessResourceRoleSettingRoleDefinition](Update-MgPrivilegedAccessResourceRoleSettingRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignment](Update-MgPrivilegedAccessRoleAssignment.md)
Update the navigation property roleAssignments in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignmentRequest](Update-MgPrivilegedAccessRoleAssignmentRequest.md)
Update the navigation property roleAssignmentRequests in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition](Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignmentRequestSubject](Update-MgPrivilegedAccessRoleAssignmentRequestSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignmentRoleDefinition](Update-MgPrivilegedAccessRoleAssignmentRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedAccessRoleAssignmentSubject](Update-MgPrivilegedAccessRoleAssignmentSubject.md)
Update the navigation property subject in privilegedAccess

### [Update-MgPrivilegedAccessRoleDefinition](Update-MgPrivilegedAccessRoleDefinition.md)
Update the navigation property roleDefinitions in privilegedAccess

### [Update-MgPrivilegedAccessRoleSetting](Update-MgPrivilegedAccessRoleSetting.md)
Update the navigation property roleSettings in privilegedAccess

### [Update-MgPrivilegedAccessRoleSettingRoleDefinition](Update-MgPrivilegedAccessRoleSettingRoleDefinition.md)
Update the navigation property roleDefinition in privilegedAccess

### [Update-MgPrivilegedApproval](Update-MgPrivilegedApproval.md)
Update the properties of privilegedapproval object.

### [Update-MgPrivilegedApprovalRoleInfo](Update-MgPrivilegedApprovalRoleInfo.md)
Update the navigation property roleInfo in privilegedApproval

### [Update-MgPrivilegedApprovalRoleInfoSetting](Update-MgPrivilegedApprovalRoleInfoSetting.md)
Update the navigation property settings in privilegedApproval

### [Update-MgPrivilegedApprovalRoleInfoSummary](Update-MgPrivilegedApprovalRoleInfoSummary.md)
Update the navigation property summary in privilegedApproval

### [Update-MgPrivilegedOperationEvent](Update-MgPrivilegedOperationEvent.md)
Update entity in privilegedOperationEvents

### [Update-MgPrivilegedRole](Update-MgPrivilegedRole.md)
Update entity in privilegedRoles

### [Update-MgPrivilegedRoleAssignment](Update-MgPrivilegedRoleAssignment.md)
Update entity in privilegedRoleAssignments

### [Update-MgPrivilegedRoleAssignmentRequest](Update-MgPrivilegedRoleAssignmentRequest.md)
Update entity in privilegedRoleAssignmentRequests

### [Update-MgPrivilegedRoleAssignmentRequestRoleInfo](Update-MgPrivilegedRoleAssignmentRequestRoleInfo.md)
Update the navigation property roleInfo in privilegedRoleAssignmentRequests

### [Update-MgPrivilegedRoleAssignmentRequestRoleInfoSetting](Update-MgPrivilegedRoleAssignmentRequestRoleInfoSetting.md)
Update the navigation property settings in privilegedRoleAssignmentRequests

### [Update-MgPrivilegedRoleAssignmentRequestRoleInfoSummary](Update-MgPrivilegedRoleAssignmentRequestRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignmentRequests

### [Update-MgPrivilegedRoleAssignmentRoleInfo](Update-MgPrivilegedRoleAssignmentRoleInfo.md)
Update the navigation property roleInfo in privilegedRoleAssignments

### [Update-MgPrivilegedRoleAssignmentRoleInfoSetting](Update-MgPrivilegedRoleAssignmentRoleInfoSetting.md)
Update the navigation property settings in privilegedRoleAssignments

### [Update-MgPrivilegedRoleAssignmentRoleInfoSummary](Update-MgPrivilegedRoleAssignmentRoleInfoSummary.md)
Update the navigation property summary in privilegedRoleAssignments

### [Update-MgPrivilegedRoleSetting](Update-MgPrivilegedRoleSetting.md)
Update the navigation property settings in privilegedRoles

### [Update-MgPrivilegedRoleSummary](Update-MgPrivilegedRoleSummary.md)
Update the navigation property summary in privilegedRoles

### [Update-MgProgram](Update-MgProgram.md)
In the Azure AD access reviews feature, update an existing program object.

### [Update-MgProgramControl](Update-MgProgramControl.md)
Update entity in programControls

### [Update-MgProgramControlProgram](Update-MgProgramControlProgram.md)
Update the navigation property program in programControls

### [Update-MgProgramControlType](Update-MgProgramControlType.md)
Update entity in programControlTypes

