---
Module Name: Microsoft.Graph.Identity.Governance
Module Guid: 3562c685-ac24-4455-b8b2-9c5e76dfa3b7
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Identity.Governance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Identity.Governance Cmdlets
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

### [Get-MgEntitlementManagementAccessPackage](Get-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Get-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
A collection of stages in the approval decision.

### [Get-MgEntitlementManagementAccessPackageAssignmentPolicy](Get-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Get assignmentPolicies from identityGovernance

### [Get-MgEntitlementManagementAccessPackageCatalog](Get-MgEntitlementManagementAccessPackageCatalog.md)
Read-only.
Nullable.

### [Get-MgEntitlementManagementAssignment](Get-MgEntitlementManagementAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [Get-MgEntitlementManagementAssignmentAssignmentPolicyByRef](Get-MgEntitlementManagementAssignmentAssignmentPolicyByRef.md)
Get ref of assignmentPolicy from identityGovernance

### [Get-MgEntitlementManagementAssignmentPolicy](Get-MgEntitlementManagementAssignmentPolicy.md)
Get assignmentPolicies from identityGovernance

### [Get-MgEntitlementManagementAssignmentPolicyAccessPackage](Get-MgEntitlementManagementAssignmentPolicyAccessPackage.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAssignmentPolicyAccessPackageApplicablePolicyRequirement](Get-MgEntitlementManagementAssignmentPolicyAccessPackageApplicablePolicyRequirement.md)
Invoke action getApplicablePolicyRequirements

### [Get-MgEntitlementManagementAssignmentPolicyAccessPackageByRef](Get-MgEntitlementManagementAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Get-MgEntitlementManagementAssignmentPolicyCatalog](Get-MgEntitlementManagementAssignmentPolicyCatalog.md)
Get catalog from identityGovernance

### [Get-MgEntitlementManagementAssignmentPolicyCatalogByRef](Get-MgEntitlementManagementAssignmentPolicyCatalogByRef.md)
Get ref of catalog from identityGovernance

### [Get-MgEntitlementManagementAssignmentRequest](Get-MgEntitlementManagementAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Get-MgEntitlementManagementCatalog](Get-MgEntitlementManagementCatalog.md)
Represents a group of access packages.

### [Get-MgEntitlementManagementConnectedOrganization](Get-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Get-MgEntitlementManagementConnectedOrganizationExternalSponsor](Get-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Get-MgEntitlementManagementConnectedOrganizationInternalSponsor](Get-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Get-MgEntitlementManagementSetting](Get-MgEntitlementManagementSetting.md)
Represents the settings that control the behavior of Azure AD entitlement management.

### [Get-MgIdentityGovernanceTermOfUseAgreement](Get-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Get-MgIdentityGovernanceTermOfUseAgreementAcceptance](Get-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Get-MgUserAgreementAcceptance](Get-MgUserAgreementAcceptance.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Get-MgUserAgreementAcceptanceByRef](Get-MgUserAgreementAcceptanceByRef.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

### [Invoke-MgFilterEntitlementManagementAccessPackage](Invoke-MgFilterEntitlementManagementAccessPackage.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApproval](Invoke-MgFilterEntitlementManagementAccessPackageAssignmentApproval.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignment](Invoke-MgFilterEntitlementManagementAssignment.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementAssignmentRequest](Invoke-MgFilterEntitlementManagementAssignmentRequest.md)
Invoke function filterByCurrentUser

### [Invoke-MgFilterEntitlementManagementCatalogAccessPackage](Invoke-MgFilterEntitlementManagementCatalogAccessPackage.md)
Invoke function filterByCurrentUser

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

### [New-MgEntitlementManagementAccessPackage](New-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [New-MgEntitlementManagementAccessPackageAssignmentApprovalStage](New-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
A collection of stages in the approval decision.

### [New-MgEntitlementManagementAccessPackageAssignmentPolicy](New-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Create new navigation property to assignmentPolicies for identityGovernance

### [New-MgEntitlementManagementAssignment](New-MgEntitlementManagementAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [New-MgEntitlementManagementAssignmentPolicy](New-MgEntitlementManagementAssignmentPolicy.md)
Create new navigation property to assignmentPolicies for identityGovernance

### [New-MgEntitlementManagementAssignmentRequest](New-MgEntitlementManagementAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [New-MgEntitlementManagementCatalog](New-MgEntitlementManagementCatalog.md)
Represents a group of access packages.

### [New-MgEntitlementManagementConnectedOrganization](New-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [New-MgEntitlementManagementConnectedOrganizationExternalSponsor](New-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [New-MgEntitlementManagementConnectedOrganizationInternalSponsor](New-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [New-MgIdentityGovernanceTermOfUseAgreement](New-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [New-MgIdentityGovernanceTermOfUseAgreementAcceptance](New-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [New-MgUserAgreementAcceptanceByRef](New-MgUserAgreementAcceptanceByRef.md)
The user's terms of use acceptance statuses.
Read-only.
Nullable.

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

### [Remove-MgEntitlementManagementAccessPackage](Remove-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Remove-MgEntitlementManagementAccessPackageAssignmentApproval](Remove-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Approval stages for assignment requests.

### [Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Remove-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
A collection of stages in the approval decision.

### [Remove-MgEntitlementManagementAccessPackageAssignmentPolicy](Remove-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Delete navigation property assignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementAssignment](Remove-MgEntitlementManagementAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [Remove-MgEntitlementManagementAssignmentAssignmentPolicyByRef](Remove-MgEntitlementManagementAssignmentAssignmentPolicyByRef.md)
Delete ref of navigation property assignmentPolicy for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicy](Remove-MgEntitlementManagementAssignmentPolicy.md)
Delete navigation property assignmentPolicies for identityGovernance

### [Remove-MgEntitlementManagementAssignmentPolicyAccessPackageByRef](Remove-MgEntitlementManagementAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Remove-MgEntitlementManagementAssignmentPolicyCatalogByRef](Remove-MgEntitlementManagementAssignmentPolicyCatalogByRef.md)
Delete ref of navigation property catalog for identityGovernance

### [Remove-MgEntitlementManagementAssignmentRequest](Remove-MgEntitlementManagementAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Remove-MgEntitlementManagementCatalog](Remove-MgEntitlementManagementCatalog.md)
Represents a group of access packages.

### [Remove-MgEntitlementManagementConnectedOrganization](Remove-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Remove-MgEntitlementManagementConnectedOrganizationExternalSponsor](Remove-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Remove-MgEntitlementManagementConnectedOrganizationInternalSponsor](Remove-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Remove-MgIdentityGovernanceTermOfUseAgreement](Remove-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance](Remove-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

### [Set-MgEntitlementManagementAssignmentAssignmentPolicyByRef](Set-MgEntitlementManagementAssignmentAssignmentPolicyByRef.md)
Update the ref of navigation property assignmentPolicy in identityGovernance

### [Set-MgEntitlementManagementAssignmentPolicyAccessPackageByRef](Set-MgEntitlementManagementAssignmentPolicyAccessPackageByRef.md)
The access package with this policy.
Read-only.
Nullable.
Supports $expand.

### [Set-MgEntitlementManagementAssignmentPolicyCatalogByRef](Set-MgEntitlementManagementAssignmentPolicyCatalogByRef.md)
Update the ref of navigation property catalog in identityGovernance

### [Split-MgEntitlementManagementConnectedOrganization](Split-MgEntitlementManagementConnectedOrganization.md)
Split elements of one or more Azure AD entitlement management connected organizations, returned by Get-MgEntitlementManagementConnectedOrganization, to simplify reporting.

### [Stop-MgEntitlementManagementAssignmentRequest](Stop-MgEntitlementManagementAssignmentRequest.md)
Invoke action cancel

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

### [Update-MgEntitlementManagementAccessPackage](Update-MgEntitlementManagementAccessPackage.md)
Represents access package objects.

### [Update-MgEntitlementManagementAccessPackageAssignmentApproval](Update-MgEntitlementManagementAccessPackageAssignmentApproval.md)
Approval stages for assignment requests.

### [Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage](Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage.md)
A collection of stages in the approval decision.

### [Update-MgEntitlementManagementAccessPackageAssignmentPolicy](Update-MgEntitlementManagementAccessPackageAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Update-MgEntitlementManagementAssignment](Update-MgEntitlementManagementAssignment.md)
Represents the grant of an access package to a subject (user or group).

### [Update-MgEntitlementManagementAssignmentPolicy](Update-MgEntitlementManagementAssignmentPolicy.md)
Update the navigation property assignmentPolicies in identityGovernance

### [Update-MgEntitlementManagementAssignmentRequest](Update-MgEntitlementManagementAssignmentRequest.md)
Represents access package assignment requests created by or on behalf of a user.

### [Update-MgEntitlementManagementCatalog](Update-MgEntitlementManagementCatalog.md)
Represents a group of access packages.

### [Update-MgEntitlementManagementConnectedOrganization](Update-MgEntitlementManagementConnectedOrganization.md)
Represents references to a directory or domain of another organization whose users can request access.

### [Update-MgEntitlementManagementConnectedOrganizationExternalSponsor](Update-MgEntitlementManagementConnectedOrganizationExternalSponsor.md)
Nullable.

### [Update-MgEntitlementManagementConnectedOrganizationInternalSponsor](Update-MgEntitlementManagementConnectedOrganizationInternalSponsor.md)
Nullable.

### [Update-MgEntitlementManagementSetting](Update-MgEntitlementManagementSetting.md)
Represents the settings that control the behavior of Azure AD entitlement management.

### [Update-MgIdentityGovernanceTermOfUseAgreement](Update-MgIdentityGovernanceTermOfUseAgreement.md)
Represents a tenant's customizable terms of use agreement that's created and managed with Azure Active Directory (Azure AD).

### [Update-MgIdentityGovernanceTermOfUseAgreementAcceptance](Update-MgIdentityGovernanceTermOfUseAgreementAcceptance.md)
Represents the current status of a user's response to a company's customizable terms of use agreement.

