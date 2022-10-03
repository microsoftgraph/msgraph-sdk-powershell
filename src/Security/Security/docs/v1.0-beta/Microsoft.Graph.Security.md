---
Module Name: Microsoft.Graph.Security
Module Guid: 2763508e-bd59-4642-9576-208d4f60c75a
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Security Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Security Cmdlets
### [Add-MgSecurityCaseEdiscoveryCaseCustodianHold](Add-MgSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of applying hold on eDiscovery custodians.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold](Add-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold.md)
Start the process of applying hold on eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag](Add-MgSecurityCaseEdiscoveryCaseReviewSetQueryTag.md)
Apply tags to files in an eDiscovery review set.
For details, see Tag documents in a review set in eDiscovery.

### [Add-MgSecurityCaseEdiscoveryCaseReviewSetToReviewSet](Add-MgSecurityCaseEdiscoveryCaseReviewSetToReviewSet.md)
Start the process of adding a collection from Microsoft 365 services to a review set.
After the operation is created, you can get the status of the operation by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return a Add to review set operation.

### [Clear-MgSecurityCaseEdiscoveryCaseSearchData](Clear-MgSecurityCaseEdiscoveryCaseSearchData.md)
Permanently delete Microsoft Teams messages contained in a eDiscovery search.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- eDiscovery (Premium) workflow for content in Microsoft Teams

### [Close-MgSecurityCaseEdiscoveryCase](Close-MgSecurityCaseEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Export-MgSecurityCaseEdiscoveryCaseReviewSet](Export-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Initiate an export from a **reviewSet**.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Export-MgSecurityCaseEdiscoveryCaseReviewSetQuery](Export-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Initiate an export from a **reviewSet** query.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Get-MgSecurityAction](Get-MgSecurityAction.md)
Get securityActions from security

### [Get-MgSecurityAlert](Get-MgSecurityAlert.md)
Notifications for suspicious or potential security issues in a customer’s tenant.

### [Get-MgSecurityAttackSimulation](Get-MgSecurityAttackSimulation.md)
Represents an attack simulation training campaign in a tenant.

### [Get-MgSecurityAttackSimulationAutomation](Get-MgSecurityAttackSimulationAutomation.md)
Represents simulation automations created to run on a tenant.

### [Get-MgSecurityAttackSimulationAutomationRun](Get-MgSecurityAttackSimulationAutomationRun.md)
A collection of simulation automation runs.

### [Get-MgSecurityCase](Get-MgSecurityCase.md)
Get cases from security

### [Get-MgSecurityCaseEdiscoveryCase](Get-MgSecurityCaseEdiscoveryCase.md)
Get ediscoveryCases from security

### [Get-MgSecurityCaseEdiscoveryCaseCustodian](Get-MgSecurityCaseEdiscoveryCaseCustodian.md)
Returns a list of case ediscoveryCustodian objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianLastIndexOperation](Get-MgSecurityCaseEdiscoveryCaseCustodianLastIndexOperation.md)
Get a list of the ediscoveryIndexOperation associated with an ediscoveryCustodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Data source entity for SharePoint sites associated with the custodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSourceSite](Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Data source entity for groups associated with the custodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
Represents a group.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUserSource](Get-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Data source entity for a custodian.
This is the container for a custodian's mailbox and OneDrive for Business site.

### [Get-MgSecurityCaseEdiscoveryCaseLegalHold](Get-MgSecurityCaseEdiscoveryCaseLegalHold.md)
Returns a list of case eDiscoveryHoldPolicy objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Get-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Data sources that represent SharePoint sites.

### [Get-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite](Get-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource](Get-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Data sources that represent Exchange mailboxes.

### [Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Returns a list of case ediscoveryNoncustodialDataSource objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation](Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation.md)
Operation entity that represents the latest indexing for the non-custodial data source.

### [Get-MgSecurityCaseEdiscoveryCaseOperation](Get-MgSecurityCaseEdiscoveryCaseOperation.md)
Returns a list of case caseOperation objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSet](Get-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Returns a list of eDiscoveryReviewSet objects in the case.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetFile](Get-MgSecurityCaseEdiscoveryCaseReviewSetFile.md)
Represents files within the review set.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetFileContent](Get-MgSecurityCaseEdiscoveryCaseReviewSetFileContent.md)
Get content for the navigation property files from security

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetFileCustodian](Get-MgSecurityCaseEdiscoveryCaseReviewSetFileCustodian.md)
Custodians associated with the file.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent](Get-MgSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent.md)
Get extractedTextContent for the navigation property files from security

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetFileTag](Get-MgSecurityCaseEdiscoveryCaseReviewSetFileTag.md)
Tags associated with the file.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSetQuery](Get-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Represents queries within the review set.

### [Get-MgSecurityCaseEdiscoveryCaseSearch](Get-MgSecurityCaseEdiscoveryCaseSearch.md)
Returns a list of eDiscoverySearch objects associated with this case.

### [Get-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource](Get-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Adds an additional source to the eDiscovery search.

### [Get-MgSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation](Get-MgSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation.md)
Adds the results of the eDiscovery search to the specified reviewSet.

### [Get-MgSecurityCaseEdiscoveryCaseSearchCustodianSource](Get-MgSecurityCaseEdiscoveryCaseSearchCustodianSource.md)
Custodian sources that are included in the eDiscovery search.

### [Get-MgSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation](Get-MgSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation.md)
Get the last ediscoveryEstimateOperation objects and their properties.

### [Get-MgSecurityCaseEdiscoveryCaseSearchNoncustodialSource](Get-MgSecurityCaseEdiscoveryCaseSearchNoncustodialSource.md)
noncustodialDataSource sources that are included in the eDiscovery search

### [Get-MgSecurityCaseEdiscoveryCaseSetting](Get-MgSecurityCaseEdiscoveryCaseSetting.md)
Read the properties and relationships of an ediscoveryCaseSettings object.

### [Get-MgSecurityCaseEdiscoveryCaseTag](Get-MgSecurityCaseEdiscoveryCaseTag.md)
Returns a list of ediscoveryReviewTag objects associated to this case.

### [Get-MgSecurityCaseEdiscoveryCaseTagChildTag](Get-MgSecurityCaseEdiscoveryCaseTagChildTag.md)
Returns the tags that are a child of a tag.

### [Get-MgSecurityCaseEdiscoveryCaseTagParent](Get-MgSecurityCaseEdiscoveryCaseTagParent.md)
Returns the parent tag of the specified tag.

### [Get-MgSecurityCloudAppSecurityProfile](Get-MgSecurityCloudAppSecurityProfile.md)
Get cloudAppSecurityProfiles from security

### [Get-MgSecurityDomainSecurityProfile](Get-MgSecurityDomainSecurityProfile.md)
Get domainSecurityProfiles from security

### [Get-MgSecurityFileSecurityProfile](Get-MgSecurityFileSecurityProfile.md)
Get fileSecurityProfiles from security

### [Get-MgSecurityHostSecurityProfile](Get-MgSecurityHostSecurityProfile.md)
Get hostSecurityProfiles from security

### [Get-MgSecurityIncident](Get-MgSecurityIncident.md)
A collection of incidents in Microsoft 365 Defender, each of which is a set of correlated alerts and associated metadata that reflects the story of an attack.

### [Get-MgSecurityIncidentAlert](Get-MgSecurityIncidentAlert.md)
The list of related alerts.
Supports $expand.

### [Get-MgSecurityInformationProtection](Get-MgSecurityInformationProtection.md)
Get informationProtection from security

### [Get-MgSecurityInformationProtectionLabelPolicySetting](Get-MgSecurityInformationProtectionLabelPolicySetting.md)
Read the Microsoft Purview Information Protection policy settings for the user or organization.

### [Get-MgSecurityInformationProtectionSensitivityLabel](Get-MgSecurityInformationProtectionSensitivityLabel.md)
Read the Microsoft Purview Information Protection labels for the user or organization.

### [Get-MgSecurityInformationProtectionSensitivityLabelParent](Get-MgSecurityInformationProtectionSensitivityLabelParent.md)
The parent label associated with a child label.
Null if the label has no parent.

### [Get-MgSecurityIPSecurityProfile](Get-MgSecurityIPSecurityProfile.md)
Get ipSecurityProfiles from security

### [Get-MgSecurityLabel](Get-MgSecurityLabel.md)
Get labels from security

### [Get-MgSecurityLabelRetentionEventType](Get-MgSecurityLabelRetentionEventType.md)
Get retentionEventType from security

### [Get-MgSecurityLabelRetentionLabel](Get-MgSecurityLabelRetentionLabel.md)
Get retentionLabels from security

### [Get-MgSecurityLabelRetentionLabelDispositionReviewStage](Get-MgSecurityLabelRetentionLabelDispositionReviewStage.md)
Review stages during which reviewers are notified to determine whether a document must be deleted or retained.

### [Get-MgSecurityProviderTenantSetting](Get-MgSecurityProviderTenantSetting.md)
Get providerTenantSettings from security

### [Get-MgSecuritySecureScore](Get-MgSecuritySecureScore.md)
Measurements of tenants’ security posture to help protect them from threats.

### [Get-MgSecuritySecureScoreControlProfile](Get-MgSecuritySecureScoreControlProfile.md)
Get secureScoreControlProfiles from security

### [Get-MgSecuritySubjectRightsRequest](Get-MgSecuritySubjectRightsRequest.md)
Get subjectRightsRequests from security

### [Get-MgSecuritySubjectRightsRequestFinalAttachment](Get-MgSecuritySubjectRightsRequestFinalAttachment.md)
Invoke function getFinalAttachment

### [Get-MgSecuritySubjectRightsRequestFinalReport](Get-MgSecuritySubjectRightsRequestFinalReport.md)
Invoke function getFinalReport

### [Get-MgSecuritySubjectRightsRequestNote](Get-MgSecuritySubjectRightsRequestNote.md)
List of notes associated with the request.

### [Get-MgSecuritySubjectRightsRequestTeam](Get-MgSecuritySubjectRightsRequestTeam.md)
Information about the Microsoft Teams team that was created for the request.

### [Get-MgSecurityThreatSubmission](Get-MgSecurityThreatSubmission.md)
A threat submission sent to Microsoft; for example, a suspicious email threat, URL threat, or file threat.

### [Get-MgSecurityThreatSubmissionEmailThreat](Get-MgSecurityThreatSubmissionEmailThreat.md)
Get emailThreats from security

### [Get-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy](Get-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Get emailThreatSubmissionPolicies from security

### [Get-MgSecurityThreatSubmissionFileThreat](Get-MgSecurityThreatSubmissionFileThreat.md)
Get fileThreats from security

### [Get-MgSecurityThreatSubmissionUrlThreat](Get-MgSecurityThreatSubmissionUrlThreat.md)
Get urlThreats from security

### [Get-MgSecurityTiIndicator](Get-MgSecurityTiIndicator.md)
Get tiIndicators from security

### [Get-MgSecurityTrigger](Get-MgSecurityTrigger.md)
Get triggers from security

### [Get-MgSecurityTriggerRetentionEvent](Get-MgSecurityTriggerRetentionEvent.md)
Get retentionEvents from security

### [Get-MgSecurityTriggerRetentionEventType](Get-MgSecurityTriggerRetentionEventType.md)
Specifies the event that will start the retention period for labels that use this event type when an event is created.

### [Get-MgSecurityTriggerType](Get-MgSecurityTriggerType.md)
Get triggerTypes from security

### [Get-MgSecurityTriggerTypeRetentionEventType](Get-MgSecurityTriggerTypeRetentionEventType.md)
Get retentionEventTypes from security

### [Get-MgSecurityUserSecurityProfile](Get-MgSecurityUserSecurityProfile.md)
Get userSecurityProfiles from security

### [Initialize-MgSecurityCaseEdiscoveryCaseCustodian](Initialize-MgSecurityCaseEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an eDiscovery (Premium) case.

### [Invoke-MgAsSecurityCaseEdiscoveryCaseTagHierarchy](Invoke-MgAsSecurityCaseEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics](Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics.md)
Run an estimate of the number of emails and documents in the eDiscovery search.
To learn more about searches in eDiscovery, see Collect data for a case in eDiscovery (Premium).

### [Invoke-MgExtractSecurityInformationProtectionSensitivityLabelContentLabel](Invoke-MgExtractSecurityInformationProtectionSensitivityLabelContentLabel.md)
Invoke action extractContentLabel

### [Invoke-MgReopenSecurityCaseEdiscoveryCase](Invoke-MgReopenSecurityCaseEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

### [New-MgSecurityAction](New-MgSecurityAction.md)
Create a new securityAction object.

### [New-MgSecurityAlert](New-MgSecurityAlert.md)
Create new navigation property to alerts for security

### [New-MgSecurityAttackSimulation](New-MgSecurityAttackSimulation.md)
Create new navigation property to simulations for security

### [New-MgSecurityAttackSimulationAutomation](New-MgSecurityAttackSimulationAutomation.md)
Create new navigation property to simulationAutomations for security

### [New-MgSecurityAttackSimulationAutomationRun](New-MgSecurityAttackSimulationAutomationRun.md)
Create new navigation property to runs for security

### [New-MgSecurityCaseEdiscoveryCase](New-MgSecurityCaseEdiscoveryCase.md)
Create a new ediscoveryCase object.

### [New-MgSecurityCaseEdiscoveryCaseCustodian](New-MgSecurityCaseEdiscoveryCaseCustodian.md)
Create a new ediscoveryCustodian object.\nAfter the custodian object is created, you will need to create the custodian's userSource to reference their mailbox and OneDrive for Business site.

### [New-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](New-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Create a new siteSource object associated with an eDiscovery custodian.

### [New-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](New-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Create a new unifiedGroupSource object associated with an eDiscovery custodian.

### [New-MgSecurityCaseEdiscoveryCaseCustodianUserSource](New-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Create a new userSource object associated with an eDiscovery custodian.

### [New-MgSecurityCaseEdiscoveryCaseLegalHold](New-MgSecurityCaseEdiscoveryCaseLegalHold.md)
Create a new ediscoveryHoldPolicy object.

### [New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource](New-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Create a new siteSource object.

### [New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource](New-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Create a new userSource object.

### [New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Create a new ediscoveryNoncustodialDataSource object.

### [New-MgSecurityCaseEdiscoveryCaseOperation](New-MgSecurityCaseEdiscoveryCaseOperation.md)
Create new navigation property to operations for security

### [New-MgSecurityCaseEdiscoveryCaseReviewSet](New-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Create a new ediscoveryReviewSet object.

### [New-MgSecurityCaseEdiscoveryCaseReviewSetFile](New-MgSecurityCaseEdiscoveryCaseReviewSetFile.md)
Create new navigation property to files for security

### [New-MgSecurityCaseEdiscoveryCaseReviewSetQuery](New-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Create a new ediscoveryReviewSetQuery object.

### [New-MgSecurityCaseEdiscoveryCaseSearch](New-MgSecurityCaseEdiscoveryCaseSearch.md)
Create a new ediscoverySearch object.

### [New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource](New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Create a new additional source associated with an eDiscovery search.

### [New-MgSecurityCaseEdiscoveryCaseTag](New-MgSecurityCaseEdiscoveryCaseTag.md)
Create a new ediscoveryReviewTag object.

### [New-MgSecurityCloudAppSecurityProfile](New-MgSecurityCloudAppSecurityProfile.md)
Create new navigation property to cloudAppSecurityProfiles for security

### [New-MgSecurityDomainSecurityProfile](New-MgSecurityDomainSecurityProfile.md)
Create new navigation property to domainSecurityProfiles for security

### [New-MgSecurityFileSecurityProfile](New-MgSecurityFileSecurityProfile.md)
Create new navigation property to fileSecurityProfiles for security

### [New-MgSecurityHostSecurityProfile](New-MgSecurityHostSecurityProfile.md)
Create new navigation property to hostSecurityProfiles for security

### [New-MgSecurityIncident](New-MgSecurityIncident.md)
Create new navigation property to incidents for security

### [New-MgSecurityInformationProtectionSensitivityLabel](New-MgSecurityInformationProtectionSensitivityLabel.md)
Create new navigation property to sensitivityLabels for security

### [New-MgSecurityIPSecurityProfile](New-MgSecurityIPSecurityProfile.md)
Create new navigation property to ipSecurityProfiles for security

### [New-MgSecurityLabelRetentionLabel](New-MgSecurityLabelRetentionLabel.md)
Create a new retentionLabel object.
To create a disposition review stage, include the **actionAfterRetentionPeriod** property in the request body with one of the possible values specified.

### [New-MgSecurityLabelRetentionLabelDispositionReviewStage](New-MgSecurityLabelRetentionLabelDispositionReviewStage.md)
Create new navigation property to dispositionReviewStages for security

### [New-MgSecurityProviderTenantSetting](New-MgSecurityProviderTenantSetting.md)
Create new navigation property to providerTenantSettings for security

### [New-MgSecuritySecureScore](New-MgSecuritySecureScore.md)
Create new navigation property to secureScores for security

### [New-MgSecuritySecureScoreControlProfile](New-MgSecuritySecureScoreControlProfile.md)
Create new navigation property to secureScoreControlProfiles for security

### [New-MgSecuritySubjectRightsRequest](New-MgSecuritySubjectRightsRequest.md)
Create new navigation property to subjectRightsRequests for security

### [New-MgSecuritySubjectRightsRequestNote](New-MgSecuritySubjectRightsRequestNote.md)
Create a new authoredNote object.

### [New-MgSecurityThreatSubmissionEmailThreat](New-MgSecurityThreatSubmissionEmailThreat.md)
Create a new emailThreatSubmission object.

### [New-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy](New-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Create new navigation property to emailThreatSubmissionPolicies for security

### [New-MgSecurityThreatSubmissionFileThreat](New-MgSecurityThreatSubmissionFileThreat.md)
Create new navigation property to fileThreats for security

### [New-MgSecurityThreatSubmissionUrlThreat](New-MgSecurityThreatSubmissionUrlThreat.md)
Create a new urlThreatSubmission object.

### [New-MgSecurityTiIndicator](New-MgSecurityTiIndicator.md)
Create a new tiIndicator object.

### [New-MgSecurityTriggerRetentionEvent](New-MgSecurityTriggerRetentionEvent.md)
Create a new retentionEvent object.

### [New-MgSecurityTriggerTypeRetentionEventType](New-MgSecurityTriggerTypeRetentionEventType.md)
Create a new retentionEventType object.

### [New-MgSecurityUserSecurityProfile](New-MgSecurityUserSecurityProfile.md)
Create new navigation property to userSecurityProfiles for security

### [Publish-MgSecurityCaseEdiscoveryCaseCustodian](Publish-MgSecurityCaseEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Publish-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Release the non-custodial data source from the case.

### [Remove-MgSecurityAction](Remove-MgSecurityAction.md)
Delete navigation property securityActions for security

### [Remove-MgSecurityAttackSimulation](Remove-MgSecurityAttackSimulation.md)
Delete navigation property simulations for security

### [Remove-MgSecurityAttackSimulationAutomation](Remove-MgSecurityAttackSimulationAutomation.md)
Delete navigation property simulationAutomations for security

### [Remove-MgSecurityAttackSimulationAutomationRun](Remove-MgSecurityAttackSimulationAutomationRun.md)
Delete navigation property runs for security

### [Remove-MgSecurityCase](Remove-MgSecurityCase.md)
Delete navigation property cases for security

### [Remove-MgSecurityCaseEdiscoveryCase](Remove-MgSecurityCaseEdiscoveryCase.md)
Delete navigation property ediscoveryCases for security

### [Remove-MgSecurityCaseEdiscoveryCaseCustodian](Remove-MgSecurityCaseEdiscoveryCaseCustodian.md)
Delete navigation property custodians for security

### [Remove-MgSecurityCaseEdiscoveryCaseCustodianHold](Remove-MgSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of removing hold from eDiscovery custodians.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Remove-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](Remove-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Delete navigation property siteSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Remove-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Delete navigation property unifiedGroupSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseCustodianUserSource](Remove-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Delete navigation property userSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseLegalHold](Remove-MgSecurityCaseEdiscoveryCaseLegalHold.md)
Delete navigation property legalHolds for security

### [Remove-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Remove-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Delete navigation property siteSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource](Remove-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Delete navigation property userSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Remove-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Delete navigation property noncustodialDataSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold](Remove-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold.md)
Start the process of removing hold from eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Remove-MgSecurityCaseEdiscoveryCaseOperation](Remove-MgSecurityCaseEdiscoveryCaseOperation.md)
Delete navigation property operations for security

### [Remove-MgSecurityCaseEdiscoveryCaseReviewSet](Remove-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Delete navigation property reviewSets for security

### [Remove-MgSecurityCaseEdiscoveryCaseReviewSetFile](Remove-MgSecurityCaseEdiscoveryCaseReviewSetFile.md)
Delete navigation property files for security

### [Remove-MgSecurityCaseEdiscoveryCaseReviewSetQuery](Remove-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Delete navigation property queries for security

### [Remove-MgSecurityCaseEdiscoveryCaseSearch](Remove-MgSecurityCaseEdiscoveryCaseSearch.md)
Delete navigation property searches for security

### [Remove-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource](Remove-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Delete navigation property additionalSources for security

### [Remove-MgSecurityCaseEdiscoveryCaseSetting](Remove-MgSecurityCaseEdiscoveryCaseSetting.md)
Delete navigation property settings for security

### [Remove-MgSecurityCaseEdiscoveryCaseTag](Remove-MgSecurityCaseEdiscoveryCaseTag.md)
Delete navigation property tags for security

### [Remove-MgSecurityCloudAppSecurityProfile](Remove-MgSecurityCloudAppSecurityProfile.md)
Delete navigation property cloudAppSecurityProfiles for security

### [Remove-MgSecurityDomainSecurityProfile](Remove-MgSecurityDomainSecurityProfile.md)
Delete navigation property domainSecurityProfiles for security

### [Remove-MgSecurityFileSecurityProfile](Remove-MgSecurityFileSecurityProfile.md)
Delete navigation property fileSecurityProfiles for security

### [Remove-MgSecurityHostSecurityProfile](Remove-MgSecurityHostSecurityProfile.md)
Delete navigation property hostSecurityProfiles for security

### [Remove-MgSecurityIncident](Remove-MgSecurityIncident.md)
Delete navigation property incidents for security

### [Remove-MgSecurityInformationProtection](Remove-MgSecurityInformationProtection.md)
Delete navigation property informationProtection for security

### [Remove-MgSecurityInformationProtectionLabelPolicySetting](Remove-MgSecurityInformationProtectionLabelPolicySetting.md)
Delete navigation property labelPolicySettings for security

### [Remove-MgSecurityInformationProtectionSensitivityLabel](Remove-MgSecurityInformationProtectionSensitivityLabel.md)
Delete navigation property sensitivityLabels for security

### [Remove-MgSecurityInformationProtectionSensitivityLabelParent](Remove-MgSecurityInformationProtectionSensitivityLabelParent.md)
Delete navigation property parent for security

### [Remove-MgSecurityIPSecurityProfile](Remove-MgSecurityIPSecurityProfile.md)
Delete navigation property ipSecurityProfiles for security

### [Remove-MgSecurityLabel](Remove-MgSecurityLabel.md)
Delete navigation property labels for security

### [Remove-MgSecurityLabelRetentionLabel](Remove-MgSecurityLabelRetentionLabel.md)
Delete navigation property retentionLabels for security

### [Remove-MgSecurityLabelRetentionLabelDispositionReviewStage](Remove-MgSecurityLabelRetentionLabelDispositionReviewStage.md)
Delete navigation property dispositionReviewStages for security

### [Remove-MgSecurityProviderTenantSetting](Remove-MgSecurityProviderTenantSetting.md)
Delete navigation property providerTenantSettings for security

### [Remove-MgSecuritySecureScore](Remove-MgSecuritySecureScore.md)
Delete navigation property secureScores for security

### [Remove-MgSecuritySecureScoreControlProfile](Remove-MgSecuritySecureScoreControlProfile.md)
Delete navigation property secureScoreControlProfiles for security

### [Remove-MgSecuritySubjectRightsRequest](Remove-MgSecuritySubjectRightsRequest.md)
Delete navigation property subjectRightsRequests for security

### [Remove-MgSecuritySubjectRightsRequestNote](Remove-MgSecuritySubjectRightsRequestNote.md)
Delete navigation property notes for security

### [Remove-MgSecurityThreatSubmission](Remove-MgSecurityThreatSubmission.md)
Delete navigation property threatSubmission for security

### [Remove-MgSecurityThreatSubmissionEmailThreat](Remove-MgSecurityThreatSubmissionEmailThreat.md)
Delete navigation property emailThreats for security

### [Remove-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy](Remove-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Delete navigation property emailThreatSubmissionPolicies for security

### [Remove-MgSecurityThreatSubmissionFileThreat](Remove-MgSecurityThreatSubmissionFileThreat.md)
Delete navigation property fileThreats for security

### [Remove-MgSecurityThreatSubmissionUrlThreat](Remove-MgSecurityThreatSubmissionUrlThreat.md)
Delete navigation property urlThreats for security

### [Remove-MgSecurityTiIndicator](Remove-MgSecurityTiIndicator.md)
Delete navigation property tiIndicators for security

### [Remove-MgSecurityTiIndicatorByExternalId](Remove-MgSecurityTiIndicatorByExternalId.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests, when the request contains external IDs instead of IDs.

### [Remove-MgSecurityTiIndicatorMultiple](Remove-MgSecurityTiIndicatorMultiple.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Remove-MgSecurityTrigger](Remove-MgSecurityTrigger.md)
Delete navigation property triggers for security

### [Remove-MgSecurityTriggerRetentionEvent](Remove-MgSecurityTriggerRetentionEvent.md)
Delete navigation property retentionEvents for security

### [Remove-MgSecurityTriggerType](Remove-MgSecurityTriggerType.md)
Delete navigation property triggerTypes for security

### [Remove-MgSecurityTriggerTypeRetentionEventType](Remove-MgSecurityTriggerTypeRetentionEventType.md)
Delete navigation property retentionEventTypes for security

### [Remove-MgSecurityUserSecurityProfile](Remove-MgSecurityUserSecurityProfile.md)
Delete navigation property userSecurityProfiles for security

### [Reset-MgSecurityCaseEdiscoveryCaseSettingToDefault](Reset-MgSecurityCaseEdiscoveryCaseSettingToDefault.md)
Reset a caseSettings object to the default values.

### [Set-MgSecurityCaseEdiscoveryCaseReviewSetFileContent](Set-MgSecurityCaseEdiscoveryCaseReviewSetFileContent.md)
Update content for the navigation property files in security

### [Set-MgSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent](Set-MgSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent.md)
Update extractedTextContent for the navigation property files in security

### [Start-MgSecurityCaseEdiscoveryCaseReviewSetQuery](Start-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Invoke function run

### [Start-MgSecurityHuntingQuery](Start-MgSecurityHuntingQuery.md)
Invoke action runHuntingQuery

### [Stop-MgSecurityAction](Stop-MgSecurityAction.md)
Cancel a security operation.

### [Submit-MgSecurityTiIndicator](Submit-MgSecurityTiIndicator.md)
Upload multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Test-MgSecurityInformationProtectionSensitivityLabelApplication](Test-MgSecurityInformationProtectionSensitivityLabelApplication.md)
Invoke action evaluateApplication

### [Test-MgSecurityInformationProtectionSensitivityLabelClassificationResult](Test-MgSecurityInformationProtectionSensitivityLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgSecurityInformationProtectionSensitivityLabelRemoval](Test-MgSecurityInformationProtectionSensitivityLabelRemoval.md)
Invoke action evaluateRemoval

### [Update-MgSecurityAction](Update-MgSecurityAction.md)
Update the navigation property securityActions in security

### [Update-MgSecurityAlert](Update-MgSecurityAlert.md)
Update the navigation property alerts in security

### [Update-MgSecurityAlertMultiple](Update-MgSecurityAlertMultiple.md)
Update multiple alerts in one request instead of multiple requests.

### [Update-MgSecurityAttackSimulationAutomation](Update-MgSecurityAttackSimulationAutomation.md)
Update the navigation property simulationAutomations in security

### [Update-MgSecurityAttackSimulationAutomationRun](Update-MgSecurityAttackSimulationAutomationRun.md)
Update the navigation property runs in security

### [Update-MgSecurityCase](Update-MgSecurityCase.md)
Update the navigation property cases in security

### [Update-MgSecurityCaseEdiscoveryCase](Update-MgSecurityCaseEdiscoveryCase.md)
Update the navigation property ediscoveryCases in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodian](Update-MgSecurityCaseEdiscoveryCaseCustodian.md)
Update the navigation property custodians in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodianIndex](Update-MgSecurityCaseEdiscoveryCaseCustodianIndex.md)
Trigger an indexOperation

### [Update-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](Update-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Update the navigation property siteSources in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Update-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodianUserSource](Update-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Update the navigation property userSources in security

### [Update-MgSecurityCaseEdiscoveryCaseLegalHold](Update-MgSecurityCaseEdiscoveryCaseLegalHold.md)
Update the navigation property legalHolds in security

### [Update-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Update-MgSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Update the navigation property siteSources in security

### [Update-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource](Update-MgSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Update the navigation property userSources in security

### [Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Update the navigation property noncustodialDataSources in security

### [Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex](Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex.md)
Trigger an indexOperation

### [Update-MgSecurityCaseEdiscoveryCaseOperation](Update-MgSecurityCaseEdiscoveryCaseOperation.md)
Update the navigation property operations in security

### [Update-MgSecurityCaseEdiscoveryCaseReviewSet](Update-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Update the navigation property reviewSets in security

### [Update-MgSecurityCaseEdiscoveryCaseReviewSetFile](Update-MgSecurityCaseEdiscoveryCaseReviewSetFile.md)
Update the navigation property files in security

### [Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery](Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Update the navigation property queries in security

### [Update-MgSecurityCaseEdiscoveryCaseSearch](Update-MgSecurityCaseEdiscoveryCaseSearch.md)
Update the navigation property searches in security

### [Update-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource](Update-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Update the navigation property additionalSources in security

### [Update-MgSecurityCaseEdiscoveryCaseSetting](Update-MgSecurityCaseEdiscoveryCaseSetting.md)
Update the properties of an ediscoveryCaseSettings object.

### [Update-MgSecurityCaseEdiscoveryCaseTag](Update-MgSecurityCaseEdiscoveryCaseTag.md)
Update the navigation property tags in security

### [Update-MgSecurityCloudAppSecurityProfile](Update-MgSecurityCloudAppSecurityProfile.md)
Update the navigation property cloudAppSecurityProfiles in security

### [Update-MgSecurityDomainSecurityProfile](Update-MgSecurityDomainSecurityProfile.md)
Update the navigation property domainSecurityProfiles in security

### [Update-MgSecurityFileSecurityProfile](Update-MgSecurityFileSecurityProfile.md)
Update the navigation property fileSecurityProfiles in security

### [Update-MgSecurityHostSecurityProfile](Update-MgSecurityHostSecurityProfile.md)
Update the navigation property hostSecurityProfiles in security

### [Update-MgSecurityIncident](Update-MgSecurityIncident.md)
Update the navigation property incidents in security

### [Update-MgSecurityInformationProtection](Update-MgSecurityInformationProtection.md)
Update the navigation property informationProtection in security

### [Update-MgSecurityInformationProtectionLabelPolicySetting](Update-MgSecurityInformationProtectionLabelPolicySetting.md)
Update the navigation property labelPolicySettings in security

### [Update-MgSecurityInformationProtectionSensitivityLabel](Update-MgSecurityInformationProtectionSensitivityLabel.md)
Update the navigation property sensitivityLabels in security

### [Update-MgSecurityInformationProtectionSensitivityLabelParent](Update-MgSecurityInformationProtectionSensitivityLabelParent.md)
Update the navigation property parent in security

### [Update-MgSecurityIPSecurityProfile](Update-MgSecurityIPSecurityProfile.md)
Update the navigation property ipSecurityProfiles in security

### [Update-MgSecurityLabel](Update-MgSecurityLabel.md)
Update the navigation property labels in security

### [Update-MgSecurityLabelRetentionLabel](Update-MgSecurityLabelRetentionLabel.md)
Update the navigation property retentionLabels in security

### [Update-MgSecurityLabelRetentionLabelDispositionReviewStage](Update-MgSecurityLabelRetentionLabelDispositionReviewStage.md)
Update the navigation property dispositionReviewStages in security

### [Update-MgSecurityProviderTenantSetting](Update-MgSecurityProviderTenantSetting.md)
Update the navigation property providerTenantSettings in security

### [Update-MgSecuritySecureScore](Update-MgSecuritySecureScore.md)
Update the navigation property secureScores in security

### [Update-MgSecuritySecureScoreControlProfile](Update-MgSecuritySecureScoreControlProfile.md)
Update the navigation property secureScoreControlProfiles in security

### [Update-MgSecuritySubjectRightsRequest](Update-MgSecuritySubjectRightsRequest.md)
Update the navigation property subjectRightsRequests in security

### [Update-MgSecuritySubjectRightsRequestNote](Update-MgSecuritySubjectRightsRequestNote.md)
Update the navigation property notes in security

### [Update-MgSecurityThreatSubmission](Update-MgSecurityThreatSubmission.md)
Update the navigation property threatSubmission in security

### [Update-MgSecurityThreatSubmissionEmailThreat](Update-MgSecurityThreatSubmissionEmailThreat.md)
Update the navigation property emailThreats in security

### [Update-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy](Update-MgSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Update the navigation property emailThreatSubmissionPolicies in security

### [Update-MgSecurityThreatSubmissionFileThreat](Update-MgSecurityThreatSubmissionFileThreat.md)
Update the navigation property fileThreats in security

### [Update-MgSecurityThreatSubmissionUrlThreat](Update-MgSecurityThreatSubmissionUrlThreat.md)
Update the navigation property urlThreats in security

### [Update-MgSecurityTiIndicator](Update-MgSecurityTiIndicator.md)
Update the navigation property tiIndicators in security

### [Update-MgSecurityTiIndicatorMultiple](Update-MgSecurityTiIndicatorMultiple.md)
Update multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Update-MgSecurityTrigger](Update-MgSecurityTrigger.md)
Update the navigation property triggers in security

### [Update-MgSecurityTriggerRetentionEvent](Update-MgSecurityTriggerRetentionEvent.md)
Update the navigation property retentionEvents in security

### [Update-MgSecurityTriggerType](Update-MgSecurityTriggerType.md)
Update the navigation property triggerTypes in security

### [Update-MgSecurityTriggerTypeRetentionEventType](Update-MgSecurityTriggerTypeRetentionEventType.md)
Update the navigation property retentionEventTypes in security

### [Update-MgSecurityUserSecurityProfile](Update-MgSecurityUserSecurityProfile.md)
Update the navigation property userSecurityProfiles in security

