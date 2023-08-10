---
Module Name: Microsoft.Graph.Beta.Security
Module Guid: b65f538b-392f-46b8-960a-8aa71f6c0efd
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Security Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Security Cmdlets
### [Add-MgBetaSecurityCaseEdiscoveryCaseCustodianHold](Add-MgBetaSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of applying hold on eDiscovery custodians.
After the operation is created, you can get the status by retrieving the Location parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold](Add-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold.md)
Start the process of applying hold on eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the Location parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag](Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag.md)
Apply tags to files in an eDiscovery review set.
For details, see Tag documents in a review set in eDiscovery.

### [Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet](Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet.md)
Start the process of adding a collection from Microsoft 365 services to a review set.
After the operation is created, you can get the status of the operation by retrieving the Location parameter from the response headers.
The location provides a URL that will return a Add to review set operation.

### [Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData](Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData.md)
Delete Microsoft Teams messages contained in a eDiscovery search.
You can collect and purge the following categories of Teams content:\n- Teams 1:1 chats - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- Teams group chats - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- Teams channels - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- Private channels - Message posts, replies, and attachments shared in a private Teams channel.\n- Shared channels - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- eDiscovery (Premium) workflow for content in Microsoft Teams

### [Close-MgBetaSecurityCaseEdiscoveryCase](Close-MgBetaSecurityCaseEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Initiate an export from a reviewSet.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Initiate an export from a ediscoveryReviewSetQuery.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Get-MgBetaSecurityAction](Get-MgBetaSecurityAction.md)
Retrieve the properties and relationships of a securityAction object.

### [Get-MgBetaSecurityActionCount](Get-MgBetaSecurityActionCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAlert](Get-MgBetaSecurityAlert.md)
Retrieve the properties and relationships of an alert object.

### [Get-MgBetaSecurityAlertCount](Get-MgBetaSecurityAlertCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAlertV2](Get-MgBetaSecurityAlertV2.md)
Get the properties and relationships of an alert in an organization based on the specified alert id property.

### [Get-MgBetaSecurityAlertV2Count](Get-MgBetaSecurityAlertV2Count.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulation](Get-MgBetaSecurityAttackSimulation.md)
Provides tenants capability to launch a simulated and realistic phishing attack and learn from it.

### [Get-MgBetaSecurityAttackSimulationAutomation](Get-MgBetaSecurityAttackSimulationAutomation.md)
Get an attack simulation automation for a tenant.

### [Get-MgBetaSecurityAttackSimulationAutomationCount](Get-MgBetaSecurityAttackSimulationAutomationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationAutomationRun](Get-MgBetaSecurityAttackSimulationAutomationRun.md)
A collection of simulation automation runs.

### [Get-MgBetaSecurityAttackSimulationAutomationRunCount](Get-MgBetaSecurityAttackSimulationAutomationRunCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationCount](Get-MgBetaSecurityAttackSimulationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationEndUserNotification](Get-MgBetaSecurityAttackSimulationEndUserNotification.md)
Get endUserNotifications from security

### [Get-MgBetaSecurityAttackSimulationEndUserNotificationCount](Get-MgBetaSecurityAttackSimulationEndUserNotificationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationEndUserNotificationDetail](Get-MgBetaSecurityAttackSimulationEndUserNotificationDetail.md)
Get details from security

### [Get-MgBetaSecurityAttackSimulationEndUserNotificationDetailCount](Get-MgBetaSecurityAttackSimulationEndUserNotificationDetailCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationLandingPage](Get-MgBetaSecurityAttackSimulationLandingPage.md)
Get landingPages from security

### [Get-MgBetaSecurityAttackSimulationLandingPageCount](Get-MgBetaSecurityAttackSimulationLandingPageCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationLandingPageDetail](Get-MgBetaSecurityAttackSimulationLandingPageDetail.md)
Get details from security

### [Get-MgBetaSecurityAttackSimulationLandingPageDetailCount](Get-MgBetaSecurityAttackSimulationLandingPageDetailCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationLoginPage](Get-MgBetaSecurityAttackSimulationLoginPage.md)
Get loginPages from security

### [Get-MgBetaSecurityAttackSimulationLoginPageCount](Get-MgBetaSecurityAttackSimulationLoginPageCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationOperation](Get-MgBetaSecurityAttackSimulationOperation.md)
Get an attack simulation operation to track a long-running operation request for a tenant.

### [Get-MgBetaSecurityAttackSimulationOperationCount](Get-MgBetaSecurityAttackSimulationOperationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationPayload](Get-MgBetaSecurityAttackSimulationPayload.md)
Represents an attack simulation training campaign payload in a tenant.

### [Get-MgBetaSecurityAttackSimulationPayloadCount](Get-MgBetaSecurityAttackSimulationPayloadCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationTraining](Get-MgBetaSecurityAttackSimulationTraining.md)
Get trainings from security

### [Get-MgBetaSecurityAttackSimulationTrainingCount](Get-MgBetaSecurityAttackSimulationTrainingCount.md)
Get the number of the resource

### [Get-MgBetaSecurityAttackSimulationTrainingLanguageDetail](Get-MgBetaSecurityAttackSimulationTrainingLanguageDetail.md)
Get languageDetails from security

### [Get-MgBetaSecurityAttackSimulationTrainingLanguageDetailCount](Get-MgBetaSecurityAttackSimulationTrainingLanguageDetailCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCase](Get-MgBetaSecurityCase.md)
Get cases from security

### [Get-MgBetaSecurityCaseEdiscoveryCase](Get-MgBetaSecurityCaseEdiscoveryCase.md)
Read the properties and relationships of an ediscoveryCase object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCount](Get-MgBetaSecurityCaseEdiscoveryCaseCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodian](Get-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Read the properties and relationships of an ediscoveryCustodian object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianCount](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianLastIndexOperation](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianLastIndexOperation.md)
Get a list of the ediscoveryIndexOperation associated with an ediscoveryCustodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Data source entity for SharePoint sites associated with the custodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceSite](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Data source entity for groups associated with the custodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
Represents a group.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Data source entity for a custodian.
This is the container for a custodian's mailbox and OneDrive for Business site.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHold](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHold.md)
Returns a list of case eDiscoveryHoldPolicy objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldCount](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Data sources that represent SharePoint sites.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Data sources that represent Exchange mailboxes.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Returns a list of case ediscoveryNoncustodialDataSource objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation](Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation.md)
Operation entity that represents the latest indexing for the non-custodial data source.

### [Get-MgBetaSecurityCaseEdiscoveryCaseOperation](Get-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Read the properties and relationships of a caseOperation object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseOperationCount](Get-MgBetaSecurityCaseEdiscoveryCaseOperationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Read the properties and relationships of an ediscoveryReviewSet object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetCount](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Read the properties and relationships of an ediscoveryFile object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent.md)
Get content for the navigation property files from security

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCount](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCustodian](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCustodian.md)
Custodians associated with the file.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent.md)
Get extractedTextContent for the navigation property files from security

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTag](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTag.md)
Tags associated with the file.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTagCount](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTagCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Read the properties and relationships of an ediscoveryReviewSetQuery object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryCount](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearch](Get-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Read the properties and relationships of an ediscoverySearch object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Adds an additional source to the eDiscovery search.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation](Get-MgBetaSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation.md)
Adds the results of the eDiscovery search to the specified reviewSet.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchCount](Get-MgBetaSecurityCaseEdiscoveryCaseSearchCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource.md)
Custodian sources that are included in the eDiscovery search.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation](Get-MgBetaSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation.md)
Get the last ediscoveryEstimateOperation objects and their properties.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource.md)
noncustodialDataSource sources that are included in the eDiscovery search

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSourceCount](Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSourceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseSetting](Get-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Read the properties and relationships of an ediscoveryCaseSettings object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTag](Get-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Read the properties and relationships of an ediscoveryReviewTag object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTag](Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTag.md)
Returns the tags that are a child of a tag.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTagCount](Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTagCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagCount](Get-MgBetaSecurityCaseEdiscoveryCaseTagCount.md)
Get the number of the resource

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagParent](Get-MgBetaSecurityCaseEdiscoveryCaseTagParent.md)
Returns the parent tag of the specified tag.

### [Get-MgBetaSecurityCloudAppSecurityProfile](Get-MgBetaSecurityCloudAppSecurityProfile.md)
Get cloudAppSecurityProfiles from security

### [Get-MgBetaSecurityCloudAppSecurityProfileCount](Get-MgBetaSecurityCloudAppSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityDomainSecurityProfile](Get-MgBetaSecurityDomainSecurityProfile.md)
Get domainSecurityProfiles from security

### [Get-MgBetaSecurityDomainSecurityProfileCount](Get-MgBetaSecurityDomainSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityFileSecurityProfile](Get-MgBetaSecurityFileSecurityProfile.md)
Get fileSecurityProfiles from security

### [Get-MgBetaSecurityFileSecurityProfileCount](Get-MgBetaSecurityFileSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityHostSecurityProfile](Get-MgBetaSecurityHostSecurityProfile.md)
Get hostSecurityProfiles from security

### [Get-MgBetaSecurityHostSecurityProfileCount](Get-MgBetaSecurityHostSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityIncident](Get-MgBetaSecurityIncident.md)
Retrieve the properties and relationships of an incident object.
Attacks are typically inflicted on different types of entities, such as devices, users, and mailboxes, resulting in multiple alert objects.
Microsoft 365 Defender correlates alerts with the same attack techniques or the same attacker into an incident.

### [Get-MgBetaSecurityIncidentAlert](Get-MgBetaSecurityIncidentAlert.md)
The list of related alerts.
Supports $expand.

### [Get-MgBetaSecurityIncidentAlertCount](Get-MgBetaSecurityIncidentAlertCount.md)
Get the number of the resource

### [Get-MgBetaSecurityIncidentCount](Get-MgBetaSecurityIncidentCount.md)
Get the number of the resource

### [Get-MgBetaSecurityInformationProtection](Get-MgBetaSecurityInformationProtection.md)
Get informationProtection from security

### [Get-MgBetaSecurityInformationProtectionLabelPolicySetting](Get-MgBetaSecurityInformationProtectionLabelPolicySetting.md)
Read the properties and relationships of an informationProtectionPolicySetting object.
The settings exposed by this API should be used in applications to populate the moreInfoUrl property for Microsoft Purview Information Protection help, and indicate whether labeling is mandatory for the user and whether justification must be provided on downgrade.

### [Get-MgBetaSecurityInformationProtectionSensitivityLabel](Get-MgBetaSecurityInformationProtectionSensitivityLabel.md)
Read the Microsoft Purview Information Protection labels for the user or organization.

### [Get-MgBetaSecurityInformationProtectionSensitivityLabelCount](Get-MgBetaSecurityInformationProtectionSensitivityLabelCount.md)
Get the number of the resource

### [Get-MgBetaSecurityInformationProtectionSensitivityLabelParent](Get-MgBetaSecurityInformationProtectionSensitivityLabelParent.md)
The parent label associated with a child label.
Null if the label has no parent.

### [Get-MgBetaSecurityIPSecurityProfile](Get-MgBetaSecurityIPSecurityProfile.md)
Get ipSecurityProfiles from security

### [Get-MgBetaSecurityIPSecurityProfileCount](Get-MgBetaSecurityIPSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabel](Get-MgBetaSecurityLabel.md)
Get labels from security

### [Get-MgBetaSecurityLabelAuthority](Get-MgBetaSecurityLabelAuthority.md)
Read the properties and relationships of a authorityTemplate object.

### [Get-MgBetaSecurityLabelAuthorityCount](Get-MgBetaSecurityLabelAuthorityCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelCategory](Get-MgBetaSecurityLabelCategory.md)
Read the properties and relationships of a categoryTemplate object.

### [Get-MgBetaSecurityLabelCategoryCount](Get-MgBetaSecurityLabelCategoryCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelCategorySubCategory](Get-MgBetaSecurityLabelCategorySubCategory.md)
Read the properties and relationships of a subCategoryTemplate object.

### [Get-MgBetaSecurityLabelCategorySubCategoryCount](Get-MgBetaSecurityLabelCategorySubCategoryCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelCitation](Get-MgBetaSecurityLabelCitation.md)
Read the properties and relationships of a citationTemplate object.

### [Get-MgBetaSecurityLabelCitationCount](Get-MgBetaSecurityLabelCitationCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelDepartment](Get-MgBetaSecurityLabelDepartment.md)
Read the properties and relationships of a departmentTemplate object.

### [Get-MgBetaSecurityLabelDepartmentCount](Get-MgBetaSecurityLabelDepartmentCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelFilePlanReference](Get-MgBetaSecurityLabelFilePlanReference.md)
Read the properties and relationships of a filePlanReferenceTemplate object.

### [Get-MgBetaSecurityLabelFilePlanReferenceCount](Get-MgBetaSecurityLabelFilePlanReferenceCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelRetentionEventType](Get-MgBetaSecurityLabelRetentionEventType.md)
Represents the type associated with a retention event.

### [Get-MgBetaSecurityLabelRetentionLabel](Get-MgBetaSecurityLabelRetentionLabel.md)
Represents how customers can manage their data, whether and for how long to retain or delete it.

### [Get-MgBetaSecurityLabelRetentionLabelCount](Get-MgBetaSecurityLabelRetentionLabelCount.md)
Get the number of the resource

### [Get-MgBetaSecurityLabelRetentionLabelDescriptor](Get-MgBetaSecurityLabelRetentionLabelDescriptor.md)
Represents out-of-the-box values that provide more options to improve the manageability and organization of the content you need to label.

### [Get-MgBetaSecurityLabelRetentionLabelDescriptorAuthorityTemplate](Get-MgBetaSecurityLabelRetentionLabelDescriptorAuthorityTemplate.md)
Specifies the underlying authority that describes the type of content to be retained and its retention schedule.

### [Get-MgBetaSecurityLabelRetentionLabelDescriptorCategoryTemplate](Get-MgBetaSecurityLabelRetentionLabelDescriptorCategoryTemplate.md)
Specifies a group of similar types of content in a particular department.

### [Get-MgBetaSecurityLabelRetentionLabelDescriptorCitationTemplate](Get-MgBetaSecurityLabelRetentionLabelDescriptorCitationTemplate.md)
The specific rule or regulation created by a jurisdiction used to determine whether certain labels and content should be retained or deleted.

### [Get-MgBetaSecurityLabelRetentionLabelDescriptorDepartmentTemplate](Get-MgBetaSecurityLabelRetentionLabelDescriptorDepartmentTemplate.md)
Specifies the  department or business unit of an organization to which a label belongs.

### [Get-MgBetaSecurityLabelRetentionLabelDescriptorFilePlanReferenceTemplate](Get-MgBetaSecurityLabelRetentionLabelDescriptorFilePlanReferenceTemplate.md)
Specifies a unique alpha-numeric identifier for an organization’s retention schedule.

### [Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
When action at the end of retention is chosen as 'dispositionReview', dispositionReviewStages specifies a sequential set of stages with at least one reviewer in each stage.

### [Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStageCount](Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStageCount.md)
Get the number of the resource

### [Get-MgBetaSecurityProviderTenantSetting](Get-MgBetaSecurityProviderTenantSetting.md)
Get providerTenantSettings from security

### [Get-MgBetaSecurityProviderTenantSettingCount](Get-MgBetaSecurityProviderTenantSettingCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySecureScore](Get-MgBetaSecuritySecureScore.md)
Measurements of tenants’ security posture to help protect them from threats.

### [Get-MgBetaSecuritySecureScoreControlProfile](Get-MgBetaSecuritySecureScoreControlProfile.md)
Get secureScoreControlProfiles from security

### [Get-MgBetaSecuritySecureScoreControlProfileCount](Get-MgBetaSecuritySecureScoreControlProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySecureScoreCount](Get-MgBetaSecuritySecureScoreCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySubjectRightsRequest](Get-MgBetaSecuritySubjectRightsRequest.md)
Get subjectRightsRequests from security

### [Get-MgBetaSecuritySubjectRightsRequestApprover](Get-MgBetaSecuritySubjectRightsRequestApprover.md)
Get approvers from security

### [Get-MgBetaSecuritySubjectRightsRequestApproverCount](Get-MgBetaSecuritySubjectRightsRequestApproverCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySubjectRightsRequestApproverMailboxSetting](Get-MgBetaSecuritySubjectRightsRequestApproverMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaSecuritySubjectRightsRequestCollaborator](Get-MgBetaSecuritySubjectRightsRequestCollaborator.md)
Get collaborators from security

### [Get-MgBetaSecuritySubjectRightsRequestCollaboratorCount](Get-MgBetaSecuritySubjectRightsRequestCollaboratorCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting](Get-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaSecuritySubjectRightsRequestCount](Get-MgBetaSecuritySubjectRightsRequestCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySubjectRightsRequestFinalAttachment](Get-MgBetaSecuritySubjectRightsRequestFinalAttachment.md)
Invoke function getFinalAttachment

### [Get-MgBetaSecuritySubjectRightsRequestFinalReport](Get-MgBetaSecuritySubjectRightsRequestFinalReport.md)
Invoke function getFinalReport

### [Get-MgBetaSecuritySubjectRightsRequestNote](Get-MgBetaSecuritySubjectRightsRequestNote.md)
List of notes associated with the request.

### [Get-MgBetaSecuritySubjectRightsRequestNoteCount](Get-MgBetaSecuritySubjectRightsRequestNoteCount.md)
Get the number of the resource

### [Get-MgBetaSecuritySubjectRightsRequestTeam](Get-MgBetaSecuritySubjectRightsRequestTeam.md)
Information about the Microsoft Teams team that was created for the request.

### [Get-MgBetaSecurityThreatIntelligence](Get-MgBetaSecurityThreatIntelligence.md)
Get threatIntelligence from security

### [Get-MgBetaSecurityThreatIntelligenceArticle](Get-MgBetaSecurityThreatIntelligenceArticle.md)
Read the properties and relationships of an article object.

### [Get-MgBetaSecurityThreatIntelligenceArticleCount](Get-MgBetaSecurityThreatIntelligenceArticleCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceArticleIndicator](Get-MgBetaSecurityThreatIntelligenceArticleIndicator.md)
Read the properties and relationships of an articleIndicator object.

### [Get-MgBetaSecurityThreatIntelligenceArticleIndicatorArtifact](Get-MgBetaSecurityThreatIntelligenceArticleIndicatorArtifact.md)
The artifact related to this indicator.

### [Get-MgBetaSecurityThreatIntelligenceArticleIndicatorCount](Get-MgBetaSecurityThreatIntelligenceArticleIndicatorCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHost](Get-MgBetaSecurityThreatIntelligenceHost.md)
Read the properties and relationships of a host object.
The host resource is the abstract base type that returns an implementation.
A host can be of one of the following types:

### [Get-MgBetaSecurityThreatIntelligenceHostChildHostPair](Get-MgBetaSecurityThreatIntelligenceHostChildHostPair.md)
The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a cihldHost.

### [Get-MgBetaSecurityThreatIntelligenceHostChildHostPairCount](Get-MgBetaSecurityThreatIntelligenceHostChildHostPairCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostComponent](Get-MgBetaSecurityThreatIntelligenceHostComponent.md)
Read the properties and relationships of a hostComponent object.

### [Get-MgBetaSecurityThreatIntelligenceHostComponentCount](Get-MgBetaSecurityThreatIntelligenceHostComponentCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostComponentHost](Get-MgBetaSecurityThreatIntelligenceHostComponentHost.md)
The host related to this component.
This is a reverse navigation property.
When navigating to components from a host, this should be assumed to be a return reference.

### [Get-MgBetaSecurityThreatIntelligenceHostCookie](Get-MgBetaSecurityThreatIntelligenceHostCookie.md)
Read the properties and relationships of a hostCookie object.

### [Get-MgBetaSecurityThreatIntelligenceHostCookieCount](Get-MgBetaSecurityThreatIntelligenceHostCookieCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostCookieHost](Get-MgBetaSecurityThreatIntelligenceHostCookieHost.md)
Indicates that a cookie of this name and domain was found related to this host.

### [Get-MgBetaSecurityThreatIntelligenceHostCount](Get-MgBetaSecurityThreatIntelligenceHostCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostPair](Get-MgBetaSecurityThreatIntelligenceHostPair.md)
Read the properties and relationships of a hostPair object.

### [Get-MgBetaSecurityThreatIntelligenceHostPairChildHost](Get-MgBetaSecurityThreatIntelligenceHostPairChildHost.md)
Host reached via the parentHost.

### [Get-MgBetaSecurityThreatIntelligenceHostPairCount](Get-MgBetaSecurityThreatIntelligenceHostPairCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostPairParentHost](Get-MgBetaSecurityThreatIntelligenceHostPairParentHost.md)
Host used to reach the childHost.

### [Get-MgBetaSecurityThreatIntelligenceHostParentHostPair](Get-MgBetaSecurityThreatIntelligenceHostParentHostPair.md)
The hostPairs that are associated with a host, where that host is the childHost and has an incoming pairing with a parentHost.

### [Get-MgBetaSecurityThreatIntelligenceHostParentHostPairCount](Get-MgBetaSecurityThreatIntelligenceHostParentHostPairCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostPassiveDns](Get-MgBetaSecurityThreatIntelligenceHostPassiveDns.md)
Passive DNS retrieval about this host.

### [Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsCount](Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsReverse](Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsReverse.md)
Reverse passive DNS retrieval about this host.

### [Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsReverseCount](Get-MgBetaSecurityThreatIntelligenceHostPassiveDnsReverseCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostReputation](Get-MgBetaSecurityThreatIntelligenceHostReputation.md)
Get the properties and relationships of a hostReputation object.

### [Get-MgBetaSecurityThreatIntelligenceHostSslCertificate](Get-MgBetaSecurityThreatIntelligenceHostSslCertificate.md)
Get hostSslCertificates from security

### [Get-MgBetaSecurityThreatIntelligenceHostSslCertificateCount](Get-MgBetaSecurityThreatIntelligenceHostSslCertificateCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostSslCertificateHost](Get-MgBetaSecurityThreatIntelligenceHostSslCertificateHost.md)
Get host from security

### [Get-MgBetaSecurityThreatIntelligenceHostSubdomain](Get-MgBetaSecurityThreatIntelligenceHostSubdomain.md)
The subdomains that are associated with this host.

### [Get-MgBetaSecurityThreatIntelligenceHostSubdomainCount](Get-MgBetaSecurityThreatIntelligenceHostSubdomainCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostTracker](Get-MgBetaSecurityThreatIntelligenceHostTracker.md)
Read the properties and relationships of a hostTracker object.

### [Get-MgBetaSecurityThreatIntelligenceHostTrackerCount](Get-MgBetaSecurityThreatIntelligenceHostTrackerCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceHostTrackerHost](Get-MgBetaSecurityThreatIntelligenceHostTrackerHost.md)
The host related to this hostTracker.
When navigating to a hostTracker from a host, this should be assumed to be a return reference.

### [Get-MgBetaSecurityThreatIntelligenceHostWhoi](Get-MgBetaSecurityThreatIntelligenceHostWhoi.md)
Get whois from security

### [Get-MgBetaSecurityThreatIntelligenceIntelProfile](Get-MgBetaSecurityThreatIntelligenceIntelProfile.md)
Read the properties and relationships of a intelligenceProfile object.

### [Get-MgBetaSecurityThreatIntelligenceIntelProfileCount](Get-MgBetaSecurityThreatIntelligenceIntelProfileCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceIntelProfileIndicator](Get-MgBetaSecurityThreatIntelligenceIntelProfileIndicator.md)
Includes an assemblage of high-fidelity network indicators of compromise.

### [Get-MgBetaSecurityThreatIntelligenceIntelProfileIndicatorCount](Get-MgBetaSecurityThreatIntelligenceIntelProfileIndicatorCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligencePassiveDnsRecord](Get-MgBetaSecurityThreatIntelligencePassiveDnsRecord.md)
Read the properties and relationships of a passiveDnsRecord object.

### [Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordArtifact](Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordArtifact.md)
The artifact related to this passiveDnsRecord entry.

### [Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordCount](Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordParentHost](Get-MgBetaSecurityThreatIntelligencePassiveDnsRecordParentHost.md)
The parent host related to this passiveDnsRecord entry.
Generally, this is the value that you can search to discover this passiveDnsRecord value.

### [Get-MgBetaSecurityThreatIntelligenceProfileIndicator](Get-MgBetaSecurityThreatIntelligenceProfileIndicator.md)
Read the properties and relationships of a intelligenceProfileIndicator object.

### [Get-MgBetaSecurityThreatIntelligenceProfileIndicatorArtifact](Get-MgBetaSecurityThreatIntelligenceProfileIndicatorArtifact.md)
The artifact related to this indicator.

### [Get-MgBetaSecurityThreatIntelligenceProfileIndicatorCount](Get-MgBetaSecurityThreatIntelligenceProfileIndicatorCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceSslCertificate](Get-MgBetaSecurityThreatIntelligenceSslCertificate.md)
Get sslCertificates from security

### [Get-MgBetaSecurityThreatIntelligenceSslCertificateCount](Get-MgBetaSecurityThreatIntelligenceSslCertificateCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceSslCertificateRelatedHost](Get-MgBetaSecurityThreatIntelligenceSslCertificateRelatedHost.md)
Get relatedHosts from security

### [Get-MgBetaSecurityThreatIntelligenceSslCertificateRelatedHostCount](Get-MgBetaSecurityThreatIntelligenceSslCertificateRelatedHostCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceSubdomain](Get-MgBetaSecurityThreatIntelligenceSubdomain.md)
Read the properties and relationships of a subdomain object.

### [Get-MgBetaSecurityThreatIntelligenceSubdomainCount](Get-MgBetaSecurityThreatIntelligenceSubdomainCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceSubdomainHost](Get-MgBetaSecurityThreatIntelligenceSubdomainHost.md)
The host of the subdomain.

### [Get-MgBetaSecurityThreatIntelligenceVulnerability](Get-MgBetaSecurityThreatIntelligenceVulnerability.md)
Read the properties and relationships of a vulnerability object.

### [Get-MgBetaSecurityThreatIntelligenceVulnerabilityArticle](Get-MgBetaSecurityThreatIntelligenceVulnerabilityArticle.md)
Articles related to this vulnerability.

### [Get-MgBetaSecurityThreatIntelligenceVulnerabilityArticleCount](Get-MgBetaSecurityThreatIntelligenceVulnerabilityArticleCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceVulnerabilityComponent](Get-MgBetaSecurityThreatIntelligenceVulnerabilityComponent.md)
Read the properties and relationships of a vulnerabilityComponent object.

### [Get-MgBetaSecurityThreatIntelligenceVulnerabilityComponentCount](Get-MgBetaSecurityThreatIntelligenceVulnerabilityComponentCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceVulnerabilityCount](Get-MgBetaSecurityThreatIntelligenceVulnerabilityCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceWhoisRecord](Get-MgBetaSecurityThreatIntelligenceWhoisRecord.md)
Get whoisRecords from security

### [Get-MgBetaSecurityThreatIntelligenceWhoisRecordCount](Get-MgBetaSecurityThreatIntelligenceWhoisRecordCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatIntelligenceWhoisRecordHost](Get-MgBetaSecurityThreatIntelligenceWhoisRecordHost.md)
Get host from security

### [Get-MgBetaSecurityThreatSubmission](Get-MgBetaSecurityThreatSubmission.md)
A threat submission sent to Microsoft; for example, a suspicious email threat, URL threat, or file threat.

### [Get-MgBetaSecurityThreatSubmissionEmailThreat](Get-MgBetaSecurityThreatSubmissionEmailThreat.md)
Read the properties and relationships of an emailThreatSubmission object.

### [Get-MgBetaSecurityThreatSubmissionEmailThreatCount](Get-MgBetaSecurityThreatSubmissionEmailThreatCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy](Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Read the properties and relationships of an emailThreatSubmissionPolicy object.

### [Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicyCount](Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicyCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatSubmissionFileThreat](Get-MgBetaSecurityThreatSubmissionFileThreat.md)
Read the properties and relationships of a fileThreatSubmission object.

### [Get-MgBetaSecurityThreatSubmissionFileThreatCount](Get-MgBetaSecurityThreatSubmissionFileThreatCount.md)
Get the number of the resource

### [Get-MgBetaSecurityThreatSubmissionUrlThreat](Get-MgBetaSecurityThreatSubmissionUrlThreat.md)
Read the properties and relationships of an urlThreatSubmission object.

### [Get-MgBetaSecurityThreatSubmissionUrlThreatCount](Get-MgBetaSecurityThreatSubmissionUrlThreatCount.md)
Get the number of the resource

### [Get-MgBetaSecurityTiIndicator](Get-MgBetaSecurityTiIndicator.md)
Retrieve the properties and relationships of a tiIndicator object.

### [Get-MgBetaSecurityTiIndicatorCount](Get-MgBetaSecurityTiIndicatorCount.md)
Get the number of the resource

### [Get-MgBetaSecurityTrigger](Get-MgBetaSecurityTrigger.md)
Get triggers from security

### [Get-MgBetaSecurityTriggerRetentionEvent](Get-MgBetaSecurityTriggerRetentionEvent.md)
Read the properties and relationships of a retentionEvent object.

### [Get-MgBetaSecurityTriggerRetentionEventCount](Get-MgBetaSecurityTriggerRetentionEventCount.md)
Get the number of the resource

### [Get-MgBetaSecurityTriggerRetentionEventType](Get-MgBetaSecurityTriggerRetentionEventType.md)
Specifies the event that will start the retention period for labels that use this event type when an event is created.

### [Get-MgBetaSecurityTriggerType](Get-MgBetaSecurityTriggerType.md)
Get triggerTypes from security

### [Get-MgBetaSecurityTriggerTypeRetentionEventType](Get-MgBetaSecurityTriggerTypeRetentionEventType.md)
Read the properties and relationships of a retentionEventType object.

### [Get-MgBetaSecurityTriggerTypeRetentionEventTypeCount](Get-MgBetaSecurityTriggerTypeRetentionEventTypeCount.md)
Get the number of the resource

### [Get-MgBetaSecurityUserSecurityProfile](Get-MgBetaSecurityUserSecurityProfile.md)
Get userSecurityProfiles from security

### [Get-MgBetaSecurityUserSecurityProfileCount](Get-MgBetaSecurityUserSecurityProfileCount.md)
Get the number of the resource

### [Get-MgBetaUserSecurity](Get-MgBetaUserSecurity.md)
Get security from users

### [Get-MgBetaUserSecurityInformationProtection](Get-MgBetaUserSecurityInformationProtection.md)
Get informationProtection from users

### [Get-MgBetaUserSecurityInformationProtectionLabelPolicySetting](Get-MgBetaUserSecurityInformationProtectionLabelPolicySetting.md)
Read the properties and relationships of an informationProtectionPolicySetting object.
The settings exposed by this API should be used in applications to populate the moreInfoUrl property for Microsoft Purview Information Protection help, and indicate whether labeling is mandatory for the user and whether justification must be provided on downgrade.

### [Get-MgBetaUserSecurityInformationProtectionSensitivityLabel](Get-MgBetaUserSecurityInformationProtectionSensitivityLabel.md)
Read the Microsoft Purview Information Protection labels for the user or organization.

### [Get-MgBetaUserSecurityInformationProtectionSensitivityLabelCount](Get-MgBetaUserSecurityInformationProtectionSensitivityLabelCount.md)
Get the number of the resource

### [Get-MgBetaUserSecurityInformationProtectionSensitivityLabelParent](Get-MgBetaUserSecurityInformationProtectionSensitivityLabelParent.md)
The parent label associated with a child label.
Null if the label has no parent.

### [Initialize-MgBetaSecurityCaseEdiscoveryCaseCustodian](Initialize-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an eDiscovery (Premium) case.

### [Invoke-MgBetaAsSecurityCaseEdiscoveryCaseTagHierarchy](Invoke-MgBetaAsSecurityCaseEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics](Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics.md)
Run an estimate of the number of emails and documents in the eDiscovery search.
To learn more about searches in eDiscovery, see Collect data for a case in eDiscovery (Premium).

### [Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel](Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel.md)
Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

### [Invoke-MgBetaReopenSecurityCaseEdiscoveryCase](Invoke-MgBetaReopenSecurityCaseEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

### [New-MgBetaSecurityAction](New-MgBetaSecurityAction.md)
Create a new securityAction object.

### [New-MgBetaSecurityAlert](New-MgBetaSecurityAlert.md)
Create new navigation property to alerts for security

### [New-MgBetaSecurityAlertV2](New-MgBetaSecurityAlertV2.md)
Create new navigation property to alerts_v2 for security

### [New-MgBetaSecurityAttackSimulation](New-MgBetaSecurityAttackSimulation.md)
Create an attack simulation campaign for a tenant.

### [New-MgBetaSecurityAttackSimulationAutomation](New-MgBetaSecurityAttackSimulationAutomation.md)
Create new navigation property to simulationAutomations for security

### [New-MgBetaSecurityAttackSimulationAutomationRun](New-MgBetaSecurityAttackSimulationAutomationRun.md)
Create new navigation property to runs for security

### [New-MgBetaSecurityAttackSimulationEndUserNotification](New-MgBetaSecurityAttackSimulationEndUserNotification.md)
Create new navigation property to endUserNotifications for security

### [New-MgBetaSecurityAttackSimulationEndUserNotificationDetail](New-MgBetaSecurityAttackSimulationEndUserNotificationDetail.md)
Create new navigation property to details for security

### [New-MgBetaSecurityAttackSimulationLandingPage](New-MgBetaSecurityAttackSimulationLandingPage.md)
Create new navigation property to landingPages for security

### [New-MgBetaSecurityAttackSimulationLandingPageDetail](New-MgBetaSecurityAttackSimulationLandingPageDetail.md)
Create new navigation property to details for security

### [New-MgBetaSecurityAttackSimulationLoginPage](New-MgBetaSecurityAttackSimulationLoginPage.md)
Create new navigation property to loginPages for security

### [New-MgBetaSecurityAttackSimulationOperation](New-MgBetaSecurityAttackSimulationOperation.md)
Create new navigation property to operations for security

### [New-MgBetaSecurityAttackSimulationPayload](New-MgBetaSecurityAttackSimulationPayload.md)
Create new navigation property to payloads for security

### [New-MgBetaSecurityAttackSimulationTraining](New-MgBetaSecurityAttackSimulationTraining.md)
Create new navigation property to trainings for security

### [New-MgBetaSecurityAttackSimulationTrainingLanguageDetail](New-MgBetaSecurityAttackSimulationTrainingLanguageDetail.md)
Create new navigation property to languageDetails for security

### [New-MgBetaSecurityCaseEdiscoveryCase](New-MgBetaSecurityCaseEdiscoveryCase.md)
Create a new ediscoveryCase object.

### [New-MgBetaSecurityCaseEdiscoveryCaseCustodian](New-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Create a new ediscoveryCustodian object.\nAfter the custodian object is created, you will need to create the custodian's userSource to reference their mailbox and OneDrive for Business site.

### [New-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource](New-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Create a new siteSource object associated with an eDiscovery custodian.

### [New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](New-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Create a new unifiedGroupSource object associated with an eDiscovery custodian.

### [New-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource](New-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Create a new userSource object associated with an eDiscovery custodian.

### [New-MgBetaSecurityCaseEdiscoveryCaseLegalHold](New-MgBetaSecurityCaseEdiscoveryCaseLegalHold.md)
Create a new ediscoveryHoldPolicy object.

### [New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource](New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Create a new siteSource object.

### [New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource](New-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Create a new userSource object.

### [New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](New-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Create a new ediscoveryNoncustodialDataSource object.

### [New-MgBetaSecurityCaseEdiscoveryCaseOperation](New-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Create new navigation property to operations for security

### [New-MgBetaSecurityCaseEdiscoveryCaseReviewSet](New-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Create a new ediscoveryReviewSet object.

### [New-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](New-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Create new navigation property to files for security

### [New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Create a new ediscoveryReviewSetQuery object.

### [New-MgBetaSecurityCaseEdiscoveryCaseSearch](New-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Create a new ediscoverySearch object.

### [New-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](New-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Create a new additional source associated with an eDiscovery search.

### [New-MgBetaSecurityCaseEdiscoveryCaseTag](New-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Create a new ediscoveryReviewTag object.

### [New-MgBetaSecurityCloudAppSecurityProfile](New-MgBetaSecurityCloudAppSecurityProfile.md)
Create new navigation property to cloudAppSecurityProfiles for security

### [New-MgBetaSecurityDomainSecurityProfile](New-MgBetaSecurityDomainSecurityProfile.md)
Create new navigation property to domainSecurityProfiles for security

### [New-MgBetaSecurityFileSecurityProfile](New-MgBetaSecurityFileSecurityProfile.md)
Create new navigation property to fileSecurityProfiles for security

### [New-MgBetaSecurityHostSecurityProfile](New-MgBetaSecurityHostSecurityProfile.md)
Create new navigation property to hostSecurityProfiles for security

### [New-MgBetaSecurityIncident](New-MgBetaSecurityIncident.md)
Create new navigation property to incidents for security

### [New-MgBetaSecurityInformationProtectionSensitivityLabel](New-MgBetaSecurityInformationProtectionSensitivityLabel.md)
Create new navigation property to sensitivityLabels for security

### [New-MgBetaSecurityIPSecurityProfile](New-MgBetaSecurityIPSecurityProfile.md)
Create new navigation property to ipSecurityProfiles for security

### [New-MgBetaSecurityLabelAuthority](New-MgBetaSecurityLabelAuthority.md)
Create a new authorityTemplate object.

### [New-MgBetaSecurityLabelCategory](New-MgBetaSecurityLabelCategory.md)
Create a new categoryTemplate object.

### [New-MgBetaSecurityLabelCategorySubCategory](New-MgBetaSecurityLabelCategorySubCategory.md)
Create a new subCategoryTemplate object.

### [New-MgBetaSecurityLabelCitation](New-MgBetaSecurityLabelCitation.md)
Create a new citationTemplate object.

### [New-MgBetaSecurityLabelDepartment](New-MgBetaSecurityLabelDepartment.md)
Create a new departmentTemplate object.

### [New-MgBetaSecurityLabelFilePlanReference](New-MgBetaSecurityLabelFilePlanReference.md)
Create a new filePlanReferenceTemplate object.

### [New-MgBetaSecurityLabelRetentionLabel](New-MgBetaSecurityLabelRetentionLabel.md)
Create a new retentionLabel object.
To create a disposition review stage, include the actionAfterRetentionPeriod property in the request body with one of the possible values specified.

### [New-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](New-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
Create new navigation property to dispositionReviewStages for security

### [New-MgBetaSecurityProviderTenantSetting](New-MgBetaSecurityProviderTenantSetting.md)
Create new navigation property to providerTenantSettings for security

### [New-MgBetaSecuritySecureScore](New-MgBetaSecuritySecureScore.md)
Create new navigation property to secureScores for security

### [New-MgBetaSecuritySecureScoreControlProfile](New-MgBetaSecuritySecureScoreControlProfile.md)
Create new navigation property to secureScoreControlProfiles for security

### [New-MgBetaSecuritySubjectRightsRequest](New-MgBetaSecuritySubjectRightsRequest.md)
Create new navigation property to subjectRightsRequests for security

### [New-MgBetaSecuritySubjectRightsRequestNote](New-MgBetaSecuritySubjectRightsRequestNote.md)
Create a new authoredNote object.

### [New-MgBetaSecurityThreatIntelligenceArticle](New-MgBetaSecurityThreatIntelligenceArticle.md)
Create new navigation property to articles for security

### [New-MgBetaSecurityThreatIntelligenceArticleIndicator](New-MgBetaSecurityThreatIntelligenceArticleIndicator.md)
Create new navigation property to articleIndicators for security

### [New-MgBetaSecurityThreatIntelligenceHost](New-MgBetaSecurityThreatIntelligenceHost.md)
Create new navigation property to hosts for security

### [New-MgBetaSecurityThreatIntelligenceHostComponent](New-MgBetaSecurityThreatIntelligenceHostComponent.md)
Create new navigation property to hostComponents for security

### [New-MgBetaSecurityThreatIntelligenceHostCookie](New-MgBetaSecurityThreatIntelligenceHostCookie.md)
Create new navigation property to hostCookies for security

### [New-MgBetaSecurityThreatIntelligenceHostPair](New-MgBetaSecurityThreatIntelligenceHostPair.md)
Create new navigation property to hostPairs for security

### [New-MgBetaSecurityThreatIntelligenceHostSslCertificate](New-MgBetaSecurityThreatIntelligenceHostSslCertificate.md)
Create new navigation property to hostSslCertificates for security

### [New-MgBetaSecurityThreatIntelligenceHostTracker](New-MgBetaSecurityThreatIntelligenceHostTracker.md)
Create new navigation property to hostTrackers for security

### [New-MgBetaSecurityThreatIntelligenceIntelProfile](New-MgBetaSecurityThreatIntelligenceIntelProfile.md)
Create new navigation property to intelProfiles for security

### [New-MgBetaSecurityThreatIntelligencePassiveDnsRecord](New-MgBetaSecurityThreatIntelligencePassiveDnsRecord.md)
Create new navigation property to passiveDnsRecords for security

### [New-MgBetaSecurityThreatIntelligenceProfileIndicator](New-MgBetaSecurityThreatIntelligenceProfileIndicator.md)
Create new navigation property to intelligenceProfileIndicators for security

### [New-MgBetaSecurityThreatIntelligenceSslCertificate](New-MgBetaSecurityThreatIntelligenceSslCertificate.md)
Create new navigation property to sslCertificates for security

### [New-MgBetaSecurityThreatIntelligenceSubdomain](New-MgBetaSecurityThreatIntelligenceSubdomain.md)
Create new navigation property to subdomains for security

### [New-MgBetaSecurityThreatIntelligenceVulnerability](New-MgBetaSecurityThreatIntelligenceVulnerability.md)
Create new navigation property to vulnerabilities for security

### [New-MgBetaSecurityThreatIntelligenceVulnerabilityComponent](New-MgBetaSecurityThreatIntelligenceVulnerabilityComponent.md)
Create new navigation property to components for security

### [New-MgBetaSecurityThreatIntelligenceWhoisRecord](New-MgBetaSecurityThreatIntelligenceWhoisRecord.md)
Create new navigation property to whoisRecords for security

### [New-MgBetaSecurityThreatSubmissionEmailThreat](New-MgBetaSecurityThreatSubmissionEmailThreat.md)
Create a new emailThreatSubmission object.

### [New-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy](New-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Create new navigation property to emailThreatSubmissionPolicies for security

### [New-MgBetaSecurityThreatSubmissionFileThreat](New-MgBetaSecurityThreatSubmissionFileThreat.md)
Create new navigation property to fileThreats for security

### [New-MgBetaSecurityThreatSubmissionUrlThreat](New-MgBetaSecurityThreatSubmissionUrlThreat.md)
Create a new urlThreatSubmission object.

### [New-MgBetaSecurityTiIndicator](New-MgBetaSecurityTiIndicator.md)
Create a new tiIndicator object.

### [New-MgBetaSecurityTriggerRetentionEvent](New-MgBetaSecurityTriggerRetentionEvent.md)
Create a new retentionEvent object.

### [New-MgBetaSecurityTriggerTypeRetentionEventType](New-MgBetaSecurityTriggerTypeRetentionEventType.md)
Create a new retentionEventType object.

### [New-MgBetaSecurityUserSecurityProfile](New-MgBetaSecurityUserSecurityProfile.md)
Create new navigation property to userSecurityProfiles for security

### [New-MgBetaUserSecurityInformationProtectionSensitivityLabel](New-MgBetaUserSecurityInformationProtectionSensitivityLabel.md)
Create new navigation property to sensitivityLabels for users

### [Publish-MgBetaSecurityCaseEdiscoveryCaseCustodian](Publish-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Publish-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Release the non-custodial data source from the case.

### [Remove-MgBetaSecurityAction](Remove-MgBetaSecurityAction.md)
Delete navigation property securityActions for security

### [Remove-MgBetaSecurityAlertV2](Remove-MgBetaSecurityAlertV2.md)
Delete navigation property alerts_v2 for security

### [Remove-MgBetaSecurityAttackSimulation](Remove-MgBetaSecurityAttackSimulation.md)
Delete navigation property attackSimulation for security

### [Remove-MgBetaSecurityAttackSimulationAutomation](Remove-MgBetaSecurityAttackSimulationAutomation.md)
Delete navigation property simulationAutomations for security

### [Remove-MgBetaSecurityAttackSimulationAutomationRun](Remove-MgBetaSecurityAttackSimulationAutomationRun.md)
Delete navigation property runs for security

### [Remove-MgBetaSecurityAttackSimulationEndUserNotification](Remove-MgBetaSecurityAttackSimulationEndUserNotification.md)
Delete navigation property endUserNotifications for security

### [Remove-MgBetaSecurityAttackSimulationEndUserNotificationDetail](Remove-MgBetaSecurityAttackSimulationEndUserNotificationDetail.md)
Delete navigation property details for security

### [Remove-MgBetaSecurityAttackSimulationLandingPage](Remove-MgBetaSecurityAttackSimulationLandingPage.md)
Delete navigation property landingPages for security

### [Remove-MgBetaSecurityAttackSimulationLandingPageDetail](Remove-MgBetaSecurityAttackSimulationLandingPageDetail.md)
Delete navigation property details for security

### [Remove-MgBetaSecurityAttackSimulationLoginPage](Remove-MgBetaSecurityAttackSimulationLoginPage.md)
Delete navigation property loginPages for security

### [Remove-MgBetaSecurityAttackSimulationOperation](Remove-MgBetaSecurityAttackSimulationOperation.md)
Delete navigation property operations for security

### [Remove-MgBetaSecurityAttackSimulationPayload](Remove-MgBetaSecurityAttackSimulationPayload.md)
Delete navigation property payloads for security

### [Remove-MgBetaSecurityAttackSimulationTraining](Remove-MgBetaSecurityAttackSimulationTraining.md)
Delete navigation property trainings for security

### [Remove-MgBetaSecurityAttackSimulationTrainingLanguageDetail](Remove-MgBetaSecurityAttackSimulationTrainingLanguageDetail.md)
Delete navigation property languageDetails for security

### [Remove-MgBetaSecurityCase](Remove-MgBetaSecurityCase.md)
Delete navigation property cases for security

### [Remove-MgBetaSecurityCaseEdiscoveryCase](Remove-MgBetaSecurityCaseEdiscoveryCase.md)
Delete an ediscoveryCase object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodian](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Delete navigation property custodians for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianHold](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of removing hold from eDiscovery custodians.
After the operation is created, you can get the status by retrieving the Location parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Delete navigation property siteSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Delete navigation property unifiedGroupSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Delete navigation property userSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHold](Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHold.md)
Delete navigation property legalHolds for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Delete navigation property siteSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource](Remove-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Delete navigation property userSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Remove-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Delete navigation property noncustodialDataSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold](Remove-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold.md)
Start the process of removing hold from eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the Location parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseOperation](Remove-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Delete navigation property operations for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Delete navigation property reviewSets for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Delete navigation property files for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Delete an ediscoveryReviewSetQuery object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearch](Remove-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Delete an ediscoverySearch object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Remove-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Delete navigation property additionalSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource](Remove-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource.md)
Remove a dataSource object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource](Remove-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource.md)
Remove an ediscoveryNoncustodialDataSource object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSetting](Remove-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Delete navigation property settings for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseTag](Remove-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Remove an ediscoveryReviewTag object.

### [Remove-MgBetaSecurityCloudAppSecurityProfile](Remove-MgBetaSecurityCloudAppSecurityProfile.md)
Delete navigation property cloudAppSecurityProfiles for security

### [Remove-MgBetaSecurityDomainSecurityProfile](Remove-MgBetaSecurityDomainSecurityProfile.md)
Delete navigation property domainSecurityProfiles for security

### [Remove-MgBetaSecurityFileSecurityProfile](Remove-MgBetaSecurityFileSecurityProfile.md)
Delete navigation property fileSecurityProfiles for security

### [Remove-MgBetaSecurityHostSecurityProfile](Remove-MgBetaSecurityHostSecurityProfile.md)
Delete navigation property hostSecurityProfiles for security

### [Remove-MgBetaSecurityIncident](Remove-MgBetaSecurityIncident.md)
Delete navigation property incidents for security

### [Remove-MgBetaSecurityInformationProtection](Remove-MgBetaSecurityInformationProtection.md)
Delete navigation property informationProtection for security

### [Remove-MgBetaSecurityInformationProtectionLabelPolicySetting](Remove-MgBetaSecurityInformationProtectionLabelPolicySetting.md)
Delete navigation property labelPolicySettings for security

### [Remove-MgBetaSecurityInformationProtectionSensitivityLabel](Remove-MgBetaSecurityInformationProtectionSensitivityLabel.md)
Delete navigation property sensitivityLabels for security

### [Remove-MgBetaSecurityInformationProtectionSensitivityLabelParent](Remove-MgBetaSecurityInformationProtectionSensitivityLabelParent.md)
Delete navigation property parent for security

### [Remove-MgBetaSecurityIPSecurityProfile](Remove-MgBetaSecurityIPSecurityProfile.md)
Delete navigation property ipSecurityProfiles for security

### [Remove-MgBetaSecurityLabel](Remove-MgBetaSecurityLabel.md)
Delete navigation property labels for security

### [Remove-MgBetaSecurityLabelAuthority](Remove-MgBetaSecurityLabelAuthority.md)
Delete a authorityTemplate object.

### [Remove-MgBetaSecurityLabelCategory](Remove-MgBetaSecurityLabelCategory.md)
Delete a categoryTemplate object.

### [Remove-MgBetaSecurityLabelCategorySubCategory](Remove-MgBetaSecurityLabelCategorySubCategory.md)
Delete a subCategoryTemplate object.

### [Remove-MgBetaSecurityLabelCitation](Remove-MgBetaSecurityLabelCitation.md)
Delete a citationTemplate object.

### [Remove-MgBetaSecurityLabelDepartment](Remove-MgBetaSecurityLabelDepartment.md)
Delete a departmentTemplate object.

### [Remove-MgBetaSecurityLabelFilePlanReference](Remove-MgBetaSecurityLabelFilePlanReference.md)
Delete a filePlanReferenceTemplate object.

### [Remove-MgBetaSecurityLabelRetentionLabel](Remove-MgBetaSecurityLabelRetentionLabel.md)
Delete a retentionLabel object.

### [Remove-MgBetaSecurityLabelRetentionLabelDescriptor](Remove-MgBetaSecurityLabelRetentionLabelDescriptor.md)
Delete navigation property descriptors for security

### [Remove-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](Remove-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
Delete navigation property dispositionReviewStages for security

### [Remove-MgBetaSecurityProviderTenantSetting](Remove-MgBetaSecurityProviderTenantSetting.md)
Delete navigation property providerTenantSettings for security

### [Remove-MgBetaSecuritySecureScore](Remove-MgBetaSecuritySecureScore.md)
Delete navigation property secureScores for security

### [Remove-MgBetaSecuritySecureScoreControlProfile](Remove-MgBetaSecuritySecureScoreControlProfile.md)
Delete navigation property secureScoreControlProfiles for security

### [Remove-MgBetaSecuritySubjectRightsRequest](Remove-MgBetaSecuritySubjectRightsRequest.md)
Delete navigation property subjectRightsRequests for security

### [Remove-MgBetaSecuritySubjectRightsRequestNote](Remove-MgBetaSecuritySubjectRightsRequestNote.md)
Delete navigation property notes for security

### [Remove-MgBetaSecurityThreatIntelligence](Remove-MgBetaSecurityThreatIntelligence.md)
Delete navigation property threatIntelligence for security

### [Remove-MgBetaSecurityThreatIntelligenceArticle](Remove-MgBetaSecurityThreatIntelligenceArticle.md)
Delete navigation property articles for security

### [Remove-MgBetaSecurityThreatIntelligenceArticleIndicator](Remove-MgBetaSecurityThreatIntelligenceArticleIndicator.md)
Delete navigation property articleIndicators for security

### [Remove-MgBetaSecurityThreatIntelligenceHost](Remove-MgBetaSecurityThreatIntelligenceHost.md)
Delete navigation property hosts for security

### [Remove-MgBetaSecurityThreatIntelligenceHostComponent](Remove-MgBetaSecurityThreatIntelligenceHostComponent.md)
Delete navigation property hostComponents for security

### [Remove-MgBetaSecurityThreatIntelligenceHostCookie](Remove-MgBetaSecurityThreatIntelligenceHostCookie.md)
Delete navigation property hostCookies for security

### [Remove-MgBetaSecurityThreatIntelligenceHostPair](Remove-MgBetaSecurityThreatIntelligenceHostPair.md)
Delete navigation property hostPairs for security

### [Remove-MgBetaSecurityThreatIntelligenceHostReputation](Remove-MgBetaSecurityThreatIntelligenceHostReputation.md)
Delete navigation property reputation for security

### [Remove-MgBetaSecurityThreatIntelligenceHostSslCertificate](Remove-MgBetaSecurityThreatIntelligenceHostSslCertificate.md)
Delete navigation property hostSslCertificates for security

### [Remove-MgBetaSecurityThreatIntelligenceHostTracker](Remove-MgBetaSecurityThreatIntelligenceHostTracker.md)
Delete navigation property hostTrackers for security

### [Remove-MgBetaSecurityThreatIntelligenceIntelProfile](Remove-MgBetaSecurityThreatIntelligenceIntelProfile.md)
Delete navigation property intelProfiles for security

### [Remove-MgBetaSecurityThreatIntelligencePassiveDnsRecord](Remove-MgBetaSecurityThreatIntelligencePassiveDnsRecord.md)
Delete navigation property passiveDnsRecords for security

### [Remove-MgBetaSecurityThreatIntelligenceProfileIndicator](Remove-MgBetaSecurityThreatIntelligenceProfileIndicator.md)
Delete navigation property intelligenceProfileIndicators for security

### [Remove-MgBetaSecurityThreatIntelligenceSslCertificate](Remove-MgBetaSecurityThreatIntelligenceSslCertificate.md)
Delete navigation property sslCertificates for security

### [Remove-MgBetaSecurityThreatIntelligenceSubdomain](Remove-MgBetaSecurityThreatIntelligenceSubdomain.md)
Delete navigation property subdomains for security

### [Remove-MgBetaSecurityThreatIntelligenceVulnerability](Remove-MgBetaSecurityThreatIntelligenceVulnerability.md)
Delete navigation property vulnerabilities for security

### [Remove-MgBetaSecurityThreatIntelligenceVulnerabilityComponent](Remove-MgBetaSecurityThreatIntelligenceVulnerabilityComponent.md)
Delete navigation property components for security

### [Remove-MgBetaSecurityThreatIntelligenceWhoisRecord](Remove-MgBetaSecurityThreatIntelligenceWhoisRecord.md)
Delete navigation property whoisRecords for security

### [Remove-MgBetaSecurityThreatSubmission](Remove-MgBetaSecurityThreatSubmission.md)
Delete navigation property threatSubmission for security

### [Remove-MgBetaSecurityThreatSubmissionEmailThreat](Remove-MgBetaSecurityThreatSubmissionEmailThreat.md)
Delete navigation property emailThreats for security

### [Remove-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy](Remove-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Delete navigation property emailThreatSubmissionPolicies for security

### [Remove-MgBetaSecurityThreatSubmissionFileThreat](Remove-MgBetaSecurityThreatSubmissionFileThreat.md)
Delete navigation property fileThreats for security

### [Remove-MgBetaSecurityThreatSubmissionUrlThreat](Remove-MgBetaSecurityThreatSubmissionUrlThreat.md)
Delete navigation property urlThreats for security

### [Remove-MgBetaSecurityTiIndicator](Remove-MgBetaSecurityTiIndicator.md)
Delete a tiIndicator object.

### [Remove-MgBetaSecurityTiIndicatorByExternalId](Remove-MgBetaSecurityTiIndicatorByExternalId.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests, when the request contains external IDs instead of IDs.

### [Remove-MgBetaSecurityTiIndicatorMultiple](Remove-MgBetaSecurityTiIndicatorMultiple.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Remove-MgBetaSecurityTrigger](Remove-MgBetaSecurityTrigger.md)
Delete navigation property triggers for security

### [Remove-MgBetaSecurityTriggerRetentionEvent](Remove-MgBetaSecurityTriggerRetentionEvent.md)
Delete a retentionEvent object.

### [Remove-MgBetaSecurityTriggerType](Remove-MgBetaSecurityTriggerType.md)
Delete navigation property triggerTypes for security

### [Remove-MgBetaSecurityTriggerTypeRetentionEventType](Remove-MgBetaSecurityTriggerTypeRetentionEventType.md)
Delete a retentionEventType object.

### [Remove-MgBetaSecurityUserSecurityProfile](Remove-MgBetaSecurityUserSecurityProfile.md)
Delete navigation property userSecurityProfiles for security

### [Remove-MgBetaUserSecurity](Remove-MgBetaUserSecurity.md)
Delete navigation property security for users

### [Remove-MgBetaUserSecurityInformationProtection](Remove-MgBetaUserSecurityInformationProtection.md)
Delete navigation property informationProtection for users

### [Remove-MgBetaUserSecurityInformationProtectionLabelPolicySetting](Remove-MgBetaUserSecurityInformationProtectionLabelPolicySetting.md)
Delete navigation property labelPolicySettings for users

### [Remove-MgBetaUserSecurityInformationProtectionSensitivityLabel](Remove-MgBetaUserSecurityInformationProtectionSensitivityLabel.md)
Delete navigation property sensitivityLabels for users

### [Remove-MgBetaUserSecurityInformationProtectionSensitivityLabelParent](Remove-MgBetaUserSecurityInformationProtectionSensitivityLabelParent.md)
Delete navigation property parent for users

### [Reset-MgBetaSecurityCaseEdiscoveryCaseSettingToDefault](Reset-MgBetaSecurityCaseEdiscoveryCaseSettingToDefault.md)
Reset a caseSettings object to the default values.

### [Set-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent](Set-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent.md)
Update content for the navigation property files in security

### [Set-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent](Set-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent.md)
Update extractedTextContent for the navigation property files in security

### [Start-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Start-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Invoke function run

### [Start-MgBetaSecurityHuntingQuery](Start-MgBetaSecurityHuntingQuery.md)
Invoke action runHuntingQuery

### [Stop-MgBetaSecurityAction](Stop-MgBetaSecurityAction.md)
Cancel a security operation.

### [Submit-MgBetaSecurityTiIndicator](Submit-MgBetaSecurityTiIndicator.md)
Upload multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Test-MgBetaSecurityInformationProtectionSensitivityLabelApplication](Test-MgBetaSecurityInformationProtectionSensitivityLabelApplication.md)
Compute the sensitivity label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set manually or explicitly by a user or service, rather than automatically based on file contents.
Given contentInfo, which includes existing content metadata key-value pairs, and labelingOptions as an input, the API returns an informationProtectionAction object that contains one of more of the following:

### [Test-MgBetaSecurityInformationProtectionSensitivityLabelClassificationResult](Test-MgBetaSecurityInformationProtectionSensitivityLabelClassificationResult.md)
Use the classification results to compute the sensitivity label that should be applied and return the set of actions that must be taken to correctly label the information.
This API is useful when a label should be set automatically based on classification of the file contents, rather than labeled directly by a user or service.
To evaluate based on classification results, provide the contentInfo, which includes existing content metadata key-value pairs, and classification results.
The API returns an informationProtectionAction that contains one of more of the following:

### [Test-MgBetaSecurityInformationProtectionSensitivityLabelRemoval](Test-MgBetaSecurityInformationProtectionSensitivityLabelRemoval.md)
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key-value pairs, the API returns an informationProtectionAction that contains some combination of one or more of the following:

### [Update-MgBetaSecurityAction](Update-MgBetaSecurityAction.md)
Update the navigation property securityActions in security

### [Update-MgBetaSecurityAlert](Update-MgBetaSecurityAlert.md)
Update an editable alert property within any integrated solution to keep alert status and assignments in sync across solutions.
This method updates any solution that has a record of the referenced alert ID.

### [Update-MgBetaSecurityAlertMultiple](Update-MgBetaSecurityAlertMultiple.md)
Update multiple alerts in one request instead of multiple requests.

### [Update-MgBetaSecurityAlertV2](Update-MgBetaSecurityAlertV2.md)
Update the properties of an alert object in an organization based on the specified alert id property.

### [Update-MgBetaSecurityAttackSimulationAutomation](Update-MgBetaSecurityAttackSimulationAutomation.md)
Update the navigation property simulationAutomations in security

### [Update-MgBetaSecurityAttackSimulationAutomationRun](Update-MgBetaSecurityAttackSimulationAutomationRun.md)
Update the navigation property runs in security

### [Update-MgBetaSecurityAttackSimulationEndUserNotification](Update-MgBetaSecurityAttackSimulationEndUserNotification.md)
Update the navigation property endUserNotifications in security

### [Update-MgBetaSecurityAttackSimulationEndUserNotificationDetail](Update-MgBetaSecurityAttackSimulationEndUserNotificationDetail.md)
Update the navigation property details in security

### [Update-MgBetaSecurityAttackSimulationLandingPage](Update-MgBetaSecurityAttackSimulationLandingPage.md)
Update the navigation property landingPages in security

### [Update-MgBetaSecurityAttackSimulationLandingPageDetail](Update-MgBetaSecurityAttackSimulationLandingPageDetail.md)
Update the navigation property details in security

### [Update-MgBetaSecurityAttackSimulationLoginPage](Update-MgBetaSecurityAttackSimulationLoginPage.md)
Update the navigation property loginPages in security

### [Update-MgBetaSecurityAttackSimulationOperation](Update-MgBetaSecurityAttackSimulationOperation.md)
Update the navigation property operations in security

### [Update-MgBetaSecurityAttackSimulationPayload](Update-MgBetaSecurityAttackSimulationPayload.md)
Update the navigation property payloads in security

### [Update-MgBetaSecurityAttackSimulationTraining](Update-MgBetaSecurityAttackSimulationTraining.md)
Update the navigation property trainings in security

### [Update-MgBetaSecurityAttackSimulationTrainingLanguageDetail](Update-MgBetaSecurityAttackSimulationTrainingLanguageDetail.md)
Update the navigation property languageDetails in security

### [Update-MgBetaSecurityCase](Update-MgBetaSecurityCase.md)
Update the navigation property cases in security

### [Update-MgBetaSecurityCaseEdiscoveryCase](Update-MgBetaSecurityCaseEdiscoveryCase.md)
Update the properties of an ediscoveryCase object.

### [Update-MgBetaSecurityCaseEdiscoveryCaseCustodian](Update-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Update the navigation property custodians in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseCustodianIndex](Update-MgBetaSecurityCaseEdiscoveryCaseCustodianIndex.md)
Trigger an indexOperation

### [Update-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource](Update-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Update the navigation property siteSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Update-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource](Update-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Update the navigation property userSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseLegalHold](Update-MgBetaSecurityCaseEdiscoveryCaseLegalHold.md)
Update the navigation property legalHolds in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Update-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Update the navigation property siteSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource](Update-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Update the navigation property userSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Update-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Update the navigation property noncustodialDataSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex](Update-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex.md)
Trigger an indexOperation

### [Update-MgBetaSecurityCaseEdiscoveryCaseOperation](Update-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Update the navigation property operations in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Update-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Update the navigation property reviewSets in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Update the navigation property files in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Update the properties of an ediscoveryReviewSetQuery object.

### [Update-MgBetaSecurityCaseEdiscoveryCaseSearch](Update-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Update the properties of an ediscoverySearch object.

### [Update-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Update-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Update the navigation property additionalSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseSetting](Update-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Update the properties of an ediscoveryCaseSettings object.

### [Update-MgBetaSecurityCaseEdiscoveryCaseTag](Update-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Update the properties of an ediscoveryReviewTag object.

### [Update-MgBetaSecurityCloudAppSecurityProfile](Update-MgBetaSecurityCloudAppSecurityProfile.md)
Update the navigation property cloudAppSecurityProfiles in security

### [Update-MgBetaSecurityDomainSecurityProfile](Update-MgBetaSecurityDomainSecurityProfile.md)
Update the navigation property domainSecurityProfiles in security

### [Update-MgBetaSecurityFileSecurityProfile](Update-MgBetaSecurityFileSecurityProfile.md)
Update the navigation property fileSecurityProfiles in security

### [Update-MgBetaSecurityHostSecurityProfile](Update-MgBetaSecurityHostSecurityProfile.md)
Update the navigation property hostSecurityProfiles in security

### [Update-MgBetaSecurityIncident](Update-MgBetaSecurityIncident.md)
Update the properties of an incident object.

### [Update-MgBetaSecurityInformationProtection](Update-MgBetaSecurityInformationProtection.md)
Update the navigation property informationProtection in security

### [Update-MgBetaSecurityInformationProtectionLabelPolicySetting](Update-MgBetaSecurityInformationProtectionLabelPolicySetting.md)
Update the navigation property labelPolicySettings in security

### [Update-MgBetaSecurityInformationProtectionSensitivityLabel](Update-MgBetaSecurityInformationProtectionSensitivityLabel.md)
Update the navigation property sensitivityLabels in security

### [Update-MgBetaSecurityInformationProtectionSensitivityLabelParent](Update-MgBetaSecurityInformationProtectionSensitivityLabelParent.md)
Update the navigation property parent in security

### [Update-MgBetaSecurityIPSecurityProfile](Update-MgBetaSecurityIPSecurityProfile.md)
Update the navigation property ipSecurityProfiles in security

### [Update-MgBetaSecurityLabel](Update-MgBetaSecurityLabel.md)
Update the navigation property labels in security

### [Update-MgBetaSecurityLabelAuthority](Update-MgBetaSecurityLabelAuthority.md)
Update the navigation property authorities in security

### [Update-MgBetaSecurityLabelCategory](Update-MgBetaSecurityLabelCategory.md)
Update the navigation property categories in security

### [Update-MgBetaSecurityLabelCategorySubCategory](Update-MgBetaSecurityLabelCategorySubCategory.md)
Update the navigation property subCategories in security

### [Update-MgBetaSecurityLabelCitation](Update-MgBetaSecurityLabelCitation.md)
Update the navigation property citations in security

### [Update-MgBetaSecurityLabelDepartment](Update-MgBetaSecurityLabelDepartment.md)
Update the navigation property departments in security

### [Update-MgBetaSecurityLabelFilePlanReference](Update-MgBetaSecurityLabelFilePlanReference.md)
Update the navigation property filePlanReferences in security

### [Update-MgBetaSecurityLabelRetentionLabel](Update-MgBetaSecurityLabelRetentionLabel.md)
Update the properties of a retentionLabel object.
To update a disposition review stage, include the actionAfterRetentionPeriod property in the request body with one of the possible values specified.

### [Update-MgBetaSecurityLabelRetentionLabelDescriptor](Update-MgBetaSecurityLabelRetentionLabelDescriptor.md)
Update the navigation property descriptors in security

### [Update-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](Update-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
Update the navigation property dispositionReviewStages in security

### [Update-MgBetaSecurityProviderTenantSetting](Update-MgBetaSecurityProviderTenantSetting.md)
Update the navigation property providerTenantSettings in security

### [Update-MgBetaSecuritySecureScore](Update-MgBetaSecuritySecureScore.md)
Update the navigation property secureScores in security

### [Update-MgBetaSecuritySecureScoreControlProfile](Update-MgBetaSecuritySecureScoreControlProfile.md)
Update an editable secureScoreControlProfiles property within any integrated solution to change various properties, such as assignedTo or tenantNote.

### [Update-MgBetaSecuritySubjectRightsRequest](Update-MgBetaSecuritySubjectRightsRequest.md)
Update the navigation property subjectRightsRequests in security

### [Update-MgBetaSecuritySubjectRightsRequestApproverMailboxSetting](Update-MgBetaSecuritySubjectRightsRequestApproverMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting](Update-MgBetaSecuritySubjectRightsRequestCollaboratorMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaSecuritySubjectRightsRequestNote](Update-MgBetaSecuritySubjectRightsRequestNote.md)
Update the navigation property notes in security

### [Update-MgBetaSecurityThreatIntelligence](Update-MgBetaSecurityThreatIntelligence.md)
Update the navigation property threatIntelligence in security

### [Update-MgBetaSecurityThreatIntelligenceArticle](Update-MgBetaSecurityThreatIntelligenceArticle.md)
Update the navigation property articles in security

### [Update-MgBetaSecurityThreatIntelligenceArticleIndicator](Update-MgBetaSecurityThreatIntelligenceArticleIndicator.md)
Update the navigation property articleIndicators in security

### [Update-MgBetaSecurityThreatIntelligenceHost](Update-MgBetaSecurityThreatIntelligenceHost.md)
Update the navigation property hosts in security

### [Update-MgBetaSecurityThreatIntelligenceHostComponent](Update-MgBetaSecurityThreatIntelligenceHostComponent.md)
Update the navigation property hostComponents in security

### [Update-MgBetaSecurityThreatIntelligenceHostCookie](Update-MgBetaSecurityThreatIntelligenceHostCookie.md)
Update the navigation property hostCookies in security

### [Update-MgBetaSecurityThreatIntelligenceHostPair](Update-MgBetaSecurityThreatIntelligenceHostPair.md)
Update the navigation property hostPairs in security

### [Update-MgBetaSecurityThreatIntelligenceHostReputation](Update-MgBetaSecurityThreatIntelligenceHostReputation.md)
Update the navigation property reputation in security

### [Update-MgBetaSecurityThreatIntelligenceHostSslCertificate](Update-MgBetaSecurityThreatIntelligenceHostSslCertificate.md)
Update the navigation property hostSslCertificates in security

### [Update-MgBetaSecurityThreatIntelligenceHostTracker](Update-MgBetaSecurityThreatIntelligenceHostTracker.md)
Update the navigation property hostTrackers in security

### [Update-MgBetaSecurityThreatIntelligenceIntelProfile](Update-MgBetaSecurityThreatIntelligenceIntelProfile.md)
Update the navigation property intelProfiles in security

### [Update-MgBetaSecurityThreatIntelligencePassiveDnsRecord](Update-MgBetaSecurityThreatIntelligencePassiveDnsRecord.md)
Update the navigation property passiveDnsRecords in security

### [Update-MgBetaSecurityThreatIntelligenceProfileIndicator](Update-MgBetaSecurityThreatIntelligenceProfileIndicator.md)
Update the navigation property intelligenceProfileIndicators in security

### [Update-MgBetaSecurityThreatIntelligenceSslCertificate](Update-MgBetaSecurityThreatIntelligenceSslCertificate.md)
Update the navigation property sslCertificates in security

### [Update-MgBetaSecurityThreatIntelligenceSubdomain](Update-MgBetaSecurityThreatIntelligenceSubdomain.md)
Update the navigation property subdomains in security

### [Update-MgBetaSecurityThreatIntelligenceVulnerability](Update-MgBetaSecurityThreatIntelligenceVulnerability.md)
Update the navigation property vulnerabilities in security

### [Update-MgBetaSecurityThreatIntelligenceVulnerabilityComponent](Update-MgBetaSecurityThreatIntelligenceVulnerabilityComponent.md)
Update the navigation property components in security

### [Update-MgBetaSecurityThreatIntelligenceWhoisRecord](Update-MgBetaSecurityThreatIntelligenceWhoisRecord.md)
Update the navigation property whoisRecords in security

### [Update-MgBetaSecurityThreatSubmission](Update-MgBetaSecurityThreatSubmission.md)
Update the navigation property threatSubmission in security

### [Update-MgBetaSecurityThreatSubmissionEmailThreat](Update-MgBetaSecurityThreatSubmissionEmailThreat.md)
Update the navigation property emailThreats in security

### [Update-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy](Update-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Update the navigation property emailThreatSubmissionPolicies in security

### [Update-MgBetaSecurityThreatSubmissionFileThreat](Update-MgBetaSecurityThreatSubmissionFileThreat.md)
Update the navigation property fileThreats in security

### [Update-MgBetaSecurityThreatSubmissionUrlThreat](Update-MgBetaSecurityThreatSubmissionUrlThreat.md)
Update the navigation property urlThreats in security

### [Update-MgBetaSecurityTiIndicator](Update-MgBetaSecurityTiIndicator.md)
Update the properties of a tiIndicator object.

### [Update-MgBetaSecurityTiIndicatorMultiple](Update-MgBetaSecurityTiIndicatorMultiple.md)
Update multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Update-MgBetaSecurityTrigger](Update-MgBetaSecurityTrigger.md)
Update the navigation property triggers in security

### [Update-MgBetaSecurityTriggerRetentionEvent](Update-MgBetaSecurityTriggerRetentionEvent.md)
Update the navigation property retentionEvents in security

### [Update-MgBetaSecurityTriggerType](Update-MgBetaSecurityTriggerType.md)
Update the navigation property triggerTypes in security

### [Update-MgBetaSecurityTriggerTypeRetentionEventType](Update-MgBetaSecurityTriggerTypeRetentionEventType.md)
Update the navigation property retentionEventTypes in security

### [Update-MgBetaSecurityUserSecurityProfile](Update-MgBetaSecurityUserSecurityProfile.md)
Update the navigation property userSecurityProfiles in security

### [Update-MgBetaUserSecurity](Update-MgBetaUserSecurity.md)
Update the navigation property security in users

### [Update-MgBetaUserSecurityInformationProtection](Update-MgBetaUserSecurityInformationProtection.md)
Update the navigation property informationProtection in users

### [Update-MgBetaUserSecurityInformationProtectionLabelPolicySetting](Update-MgBetaUserSecurityInformationProtectionLabelPolicySetting.md)
Update the navigation property labelPolicySettings in users

### [Update-MgBetaUserSecurityInformationProtectionSensitivityLabel](Update-MgBetaUserSecurityInformationProtectionSensitivityLabel.md)
Update the navigation property sensitivityLabels in users

### [Update-MgBetaUserSecurityInformationProtectionSensitivityLabelParent](Update-MgBetaUserSecurityInformationProtectionSensitivityLabelParent.md)
Update the navigation property parent in users

