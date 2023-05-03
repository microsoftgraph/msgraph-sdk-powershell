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
### [Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Add-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Invoke action applyDecisions

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

### [Get-MgEntitlementManagementAccessPackage](Get-MgEntitlementManagementAccessPackage.md)
Access packages define the collection of resource roles and the policies for which subjects can request or be assigned access to those resources.

### [Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
A collection of stages in the approval decision.

### [Get-MgEntitlementManagementAccessPackageCatalog](Get-MgEntitlementManagementAccessPackageCatalog.md)
Get catalog from identityGovernance

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackage.md)
The access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Get-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
The access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroup](Get-MgEntitlementManagementAccessPackageIncompatibleGroup.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Get-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementAccessPackageIncompatibleWith](Get-MgEntitlementManagementAccessPackageIncompatibleWith.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementAssignment](Get-MgEntitlementManagementAssignment.md)
The assignment of an access package to a subject for a period of time.

### [Get-MgEntitlementManagementAssignmentAdditional](Get-MgEntitlementManagementAssignmentAdditional.md)
Invoke function additionalAccess

### [Get-MgEntitlementManagementAssignmentPolicy](Get-MgEntitlementManagementAssignmentPolicy.md)
Access package assignment policies govern which subjects can request or be assigned an access package via an access package assignment.

### [Get-MgEntitlementManagementAssignmentPolicyAccessPackage](Get-MgEntitlementManagementAssignmentPolicyAccessPackage.md)
Access package containing this policy.
Read-only.

### [Get-MgEntitlementManagementAssignmentPolicyCatalog](Get-MgEntitlementManagementAssignmentPolicyCatalog.md)
Catalog of the access package containing this policy.
Read-only.

### [Get-MgEntitlementManagementAssignmentPolicyQuestion](Get-MgEntitlementManagementAssignmentPolicyQuestion.md)
Questions that are posed to the  requestor.

### [Get-MgEntitlementManagementAssignmentRequest](Get-MgEntitlementManagementAssignmentRequest.md)
Access package assignment requests created by or on behalf of a subject.

### [Get-MgEntitlementManagementCatalog](Get-MgEntitlementManagementCatalog.md)
A container for access packages.

### [Get-MgEntitlementManagementCatalogAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementCatalogAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy](Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy.md)
Get assignmentPolicies from identityGovernance

### [Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyAccessPackage](Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyAccessPackage.md)
Access package containing this policy.
Read-only.

### [Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyCatalog](Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyCatalog.md)
Catalog of the access package containing this policy.
Read-only.

### [Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion](Get-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion.md)
Questions that are posed to the  requestor.

### [Get-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackage](Get-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackage.md)
The access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef](Get-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef.md)
The access packages whose assigned users are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementCatalogAccessPackageIncompatibleGroup](Get-MgEntitlementManagementCatalogAccessPackageIncompatibleGroup.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef](Get-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef.md)
The groups whose members are ineligible to be assigned this access package.

### [Get-MgEntitlementManagementCatalogAccessPackageIncompatibleWith](Get-MgEntitlementManagementCatalogAccessPackageIncompatibleWith.md)
The access packages that are incompatible with this package.
Read-only.

### [Get-MgEntitlementManagementConnectedOrganization](Get-MgEntitlementManagementConnectedOrganization.md)
References to a directory or domain of another organization whose users can request access.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Get externalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorAvailableExtensionProperty](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorAvailableExtensionProperty.md)
Invoke action getAvailableExtensionProperties

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorById.md)
Invoke action getByIds

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Get ref of externalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationExternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Get internalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorAvailableExtensionProperty](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorAvailableExtensionProperty.md)
Invoke action getAvailableExtensionProperties

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorById.md)
Invoke action getByIds

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Get ref of internalSponsors from identityGovernance

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta](Get-MgEntitlementManagementConnectedOrganizationInternalSponsorDelta.md)
Invoke function delta

### [Get-MgEntitlementManagementSetting](Get-MgEntitlementManagementSetting.md)
The settings that control the behavior of Azure AD entitlement management.

### [Get-MgIdentityGovernanceAccessReviewDefinition](Get-MgIdentityGovernanceAccessReviewDefinition.md)
Represents the template and scheduling for an access review.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstance](Get-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
If the accessReviewScheduleDefinition is a recurring access review, instances represent each recurrence.
A review that does not recur will have exactly one instance.
Instances also represent each unique resource under review in the accessReviewScheduleDefinition.
If a review has multiple resources and multiple instances, each resource will have a unique instance for each recurrence.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.

### [Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.

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

### [Get-MgIdentityGovernanceAppConsentRequest](Get-MgIdentityGovernanceAppConsentRequest.md)
A collection of userConsentRequest objects for a specific application.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest.md)
A list of pending user consent requests.
Supports $filter (eq).

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApproval.md)
Approval decisions associated with a request.

### [Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](Get-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
A collection of stages in the approval decision.

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

### [Get-MgUserAgreementAcceptance](Get-MgUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation](Invoke-MgAcceptIdentityGovernanceAccessReviewDefinitionInstanceRecommendation.md)
Invoke action acceptRecommendations

### [Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision](Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision.md)
Invoke action batchRecordDecisions

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApprovalByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser](Invoke-MgFilterEntitlementManagementAccessPackageByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignmentByCurrentUser](Invoke-MgFilterEntitlementManagementAssignmentByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignmentRequestByCurrentUser](Invoke-MgFilterEntitlementManagementAssignmentRequestByCurrentUser.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementCatalogAccessPackageByCurrentUser](Invoke-MgFilterEntitlementManagementCatalogAccessPackageByCurrentUser.md)
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

### [New-MgAgreement](New-MgAgreement.md)
Add new entity to agreements

### [New-MgAgreementAcceptance](New-MgAgreementAcceptance.md)
Create new navigation property to acceptances for agreements

### [New-MgAgreementFileLocalization](New-MgAgreementFileLocalization.md)
Create new navigation property to localizations for agreements

### [New-MgAgreementFileLocalizationVersion](New-MgAgreementFileLocalizationVersion.md)
Create new navigation property to versions for agreements

### [New-MgEntitlementManagementAccessPackage](New-MgEntitlementManagementAccessPackage.md)
Create new navigation property to accessPackages for identityGovernance

### [New-MgEntitlementManagementAccessPackageAssignmentApprovalStage](New-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](New-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Create new navigation property ref to incompatibleAccessPackages for identityGovernance

### [New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](New-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Create new navigation property ref to incompatibleGroups for identityGovernance

### [New-MgEntitlementManagementAssignment](New-MgEntitlementManagementAssignment.md)
Create new navigation property to assignments for identityGovernance

### [New-MgEntitlementManagementAssignmentPolicy](New-MgEntitlementManagementAssignmentPolicy.md)
Create new navigation property to assignmentPolicies for identityGovernance

### [New-MgEntitlementManagementAssignmentPolicyQuestion](New-MgEntitlementManagementAssignmentPolicyQuestion.md)
Create new navigation property to questions for identityGovernance

### [New-MgEntitlementManagementAssignmentRequest](New-MgEntitlementManagementAssignmentRequest.md)
Create new navigation property to assignmentRequests for identityGovernance

### [New-MgEntitlementManagementCatalog](New-MgEntitlementManagementCatalog.md)
Create new navigation property to catalogs for identityGovernance

### [New-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy](New-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy.md)
Create new navigation property to assignmentPolicies for identityGovernance

### [New-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion](New-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion.md)
Create new navigation property to questions for identityGovernance

### [New-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef](New-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef.md)
Create new navigation property ref to incompatibleAccessPackages for identityGovernance

### [New-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef](New-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef.md)
Create new navigation property ref to incompatibleGroups for identityGovernance

### [New-MgEntitlementManagementConnectedOrganization](New-MgEntitlementManagementConnectedOrganization.md)
Create new navigation property to connectedOrganizations for identityGovernance

### [New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Create new navigation property ref to externalSponsors for identityGovernance

### [New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](New-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Create new navigation property ref to internalSponsors for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinition](New-MgIdentityGovernanceAccessReviewDefinition.md)
Create new navigation property to definitions for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstance](New-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Create new navigation property to instances for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](New-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Create new navigation property to contactedReviewers for identityGovernance

### [New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](New-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Create new navigation property to decisions for identityGovernance

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

### [New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage](New-MgIdentityGovernanceAppConsentRequestUserConsentRequestApprovalStage.md)
Create new navigation property to stages for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreement](New-MgIdentityGovernanceTermOfUseAgreement.md)
Create new navigation property to agreements for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementAcceptance](New-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Create new navigation property to agreementAcceptances for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementFileLocalization](New-MgIdentityGovernanceTermOfUseAgreementFileLocalization.md)
Create new navigation property to localizations for identityGovernance

### [New-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion](New-MgIdentityGovernanceTermOfUseAgreementFileLocalizationVersion.md)
Create new navigation property to versions for identityGovernance

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

### [Remove-MgEntitlementManagementAccessPackage](Remove-MgEntitlementManagementAccessPackage.md)
Delete navigation property accessPackages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentApproval](Remove-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Delete navigation property accessPackageAssignmentApprovals for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef.md)
Delete ref of navigation property incompatibleAccessPackages for identityGovernance

### [Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef](Remove-MgEntitlementManagementAccessPackageIncompatibleGroupByRef.md)
Delete ref of navigation property incompatibleGroups for identityGovernance

### [Remove-MgEntitlementManagementAssignment](Remove-MgEntitlementManagementAssignment.md)
Delete navigation property assignments for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicy](Remove-MgEntitlementManagementAssignmentPolicy.md)
Delete navigation property assignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicyQuestion](Remove-MgEntitlementManagementAssignmentPolicyQuestion.md)
Delete navigation property questions for identityGovernance

### [Remove-MgEntitlementManagementAssignmentRequest](Remove-MgEntitlementManagementAssignmentRequest.md)
Delete navigation property assignmentRequests for identityGovernance

### [Remove-MgEntitlementManagementCatalog](Remove-MgEntitlementManagementCatalog.md)
Delete navigation property catalogs for identityGovernance

### [Remove-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy](Remove-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy.md)
Delete navigation property assignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion](Remove-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion.md)
Delete navigation property questions for identityGovernance

### [Remove-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef](Remove-MgEntitlementManagementCatalogAccessPackageIncompatibleAccessPackageByRef.md)
Delete ref of navigation property incompatibleAccessPackages for identityGovernance

### [Remove-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef](Remove-MgEntitlementManagementCatalogAccessPackageIncompatibleGroupByRef.md)
Delete ref of navigation property incompatibleGroups for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganization](Remove-MgEntitlementManagementConnectedOrganization.md)
Delete navigation property connectedOrganizations for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationExternalSponsorByRef.md)
Delete ref of navigation property externalSponsors for identityGovernance

### [Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef](Remove-MgEntitlementManagementConnectedOrganizationInternalSponsorByRef.md)
Delete ref of navigation property internalSponsors for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinition](Remove-MgIdentityGovernanceAccessReviewDefinition.md)
Delete navigation property definitions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstance](Remove-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Delete navigation property instances for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Delete navigation property contactedReviewers for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Delete navigation property decisions for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Delete navigation property stages for identityGovernance

### [Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Remove-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Delete navigation property decisions for identityGovernance

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

### [Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Reset-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Invoke action resetDecisions

### [Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder](Send-MgIdentityGovernanceAccessReviewDefinitionInstanceReminder.md)
Invoke action sendReminder

### [Set-MgEntitlementManagementAssignmentPolicy](Set-MgEntitlementManagementAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Stop-MgEntitlementManagementAssignmentRequest](Stop-MgEntitlementManagementAssignmentRequest.md)
Invoke action cancel

### [Stop-MgIdentityGovernanceAccessReviewDefinition](Stop-MgIdentityGovernanceAccessReviewDefinition.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstance](Stop-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Invoke action stop

### [Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Stop-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Invoke action stop

### [Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationExternalSponsorProperty.md)
Invoke action validateProperties

### [Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty](Test-MgEntitlementManagementConnectedOrganizationInternalSponsorProperty.md)
Invoke action validateProperties

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

### [Update-MgEntitlementManagementAccessPackage](Update-MgEntitlementManagementAccessPackage.md)
Update the navigation property accessPackages in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentApproval](Update-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Update the navigation property accessPackageAssignmentApprovals in identityGovernance

### [Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
Update the navigation property stages in identityGovernance

### [Update-MgEntitlementManagementAssignment](Update-MgEntitlementManagementAssignment.md)
Invoke action reprocess

### [Update-MgEntitlementManagementAssignmentPolicyQuestion](Update-MgEntitlementManagementAssignmentPolicyQuestion.md)
Update the navigation property questions in identityGovernance

### [Update-MgEntitlementManagementAssignmentRequest](Update-MgEntitlementManagementAssignmentRequest.md)
Invoke action reprocess

### [Update-MgEntitlementManagementCatalog](Update-MgEntitlementManagementCatalog.md)
Update the navigation property catalogs in identityGovernance

### [Update-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy](Update-MgEntitlementManagementCatalogAccessPackageAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Update-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion](Update-MgEntitlementManagementCatalogAccessPackageAssignmentPolicyQuestion.md)
Update the navigation property questions in identityGovernance

### [Update-MgEntitlementManagementConnectedOrganization](Update-MgEntitlementManagementConnectedOrganization.md)
Update the navigation property connectedOrganizations in identityGovernance

### [Update-MgEntitlementManagementSetting](Update-MgEntitlementManagementSetting.md)
Update the navigation property settings in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinition](Update-MgIdentityGovernanceAccessReviewDefinition.md)
Update the navigation property definitions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstance](Update-MgIdentityGovernanceAccessReviewDefinitionInstance.md)
Update the navigation property instances in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceContactedReviewer.md)
Update the navigation property contactedReviewers in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision.md)
Update the navigation property decisions in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage.md)
Update the navigation property stages in identityGovernance

### [Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision](Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision.md)
Update the navigation property decisions in identityGovernance

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
Update the navigation property stages in identityGovernance

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

