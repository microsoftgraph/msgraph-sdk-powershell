---
Module Name: Microsoft.Graph.Beta.Security
Module Guid: 30ed7ded-e69d-4e0f-b8ec-31514f2de688
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.security
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Security Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Security Cmdlets
### [Add-MgBetaSecurityCaseEdiscoveryCaseCustodianHold](Add-MgBetaSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of applying hold on eDiscovery custodians.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold](Add-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceHold.md)
Start the process of applying hold on eDiscovery non-custodial data sources.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag](Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetQueryTag.md)
Apply tags to files in an eDiscovery review set.
For details, see Tag documents in a review set in eDiscovery.

### [Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet](Add-MgBetaSecurityCaseEdiscoveryCaseReviewSetToReviewSet.md)
Start the process of adding a collection from Microsoft 365 services to a review set.
After the operation is created, you can get the status of the operation by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return a Add to review set operation.

### [Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData](Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData.md)
Permanently delete Microsoft Teams messages contained in a eDiscovery search.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- eDiscovery (Premium) workflow for content in Microsoft Teams

### [Close-MgBetaSecurityCaseEdiscoveryCase](Close-MgBetaSecurityCaseEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Export-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Initiate an export from a **reviewSet**.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Export-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Initiate an export from a **reviewSet** query.
For details, see Export documents from a review set in eDiscovery (Premium).

### [Get-MgBetaSecurityAction](Get-MgBetaSecurityAction.md)
Get securityActions from security

### [Get-MgBetaSecurityAlert](Get-MgBetaSecurityAlert.md)
Notifications for suspicious or potential security issues in a customer’s tenant.

### [Get-MgBetaSecurityAttackSimulation](Get-MgBetaSecurityAttackSimulation.md)
Represents an attack simulation training campaign in a tenant.

### [Get-MgBetaSecurityAttackSimulationAutomation](Get-MgBetaSecurityAttackSimulationAutomation.md)
Represents simulation automation created to run on a tenant.

### [Get-MgBetaSecurityAttackSimulationAutomationRun](Get-MgBetaSecurityAttackSimulationAutomationRun.md)
A collection of simulation automation runs.

### [Get-MgBetaSecurityCase](Get-MgBetaSecurityCase.md)
Get cases from security

### [Get-MgBetaSecurityCaseEdiscoveryCase](Get-MgBetaSecurityCaseEdiscoveryCase.md)
Get ediscoveryCases from security

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodian](Get-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Returns a list of case ediscoveryCustodian objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianLastIndexOperation](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianLastIndexOperation.md)
Get a list of the ediscoveryIndexOperation associated with an ediscoveryCustodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Data source entity for SharePoint sites associated with the custodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceSite](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Data source entity for groups associated with the custodian.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
Represents a group.

### [Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource](Get-MgBetaSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Data source entity for a custodian.
This is the container for a custodian's mailbox and OneDrive for Business site.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHold](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHold.md)
Returns a list of case eDiscoveryHoldPolicy objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSource.md)
Data sources that represent SharePoint sites.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource](Get-MgBetaSecurityCaseEdiscoveryCaseLegalHoldUserSource.md)
Data sources that represent Exchange mailboxes.

### [Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Returns a list of case ediscoveryNoncustodialDataSource objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation](Get-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation.md)
Operation entity that represents the latest indexing for the non-custodial data source.

### [Get-MgBetaSecurityCaseEdiscoveryCaseOperation](Get-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Returns a list of case caseOperation objects for this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Returns a list of eDiscoveryReviewSet objects in the case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Represents files within the review set.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileContent.md)
Get content for the navigation property files from security

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCustodian](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileCustodian.md)
Custodians associated with the file.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileExtractedTextContent.md)
Get extractedTextContent for the navigation property files from security

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTag](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetFileTag.md)
Tags associated with the file.

### [Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Get-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Represents queries within the review set.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearch](Get-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Returns a list of eDiscoverySearch objects associated with this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Adds an additional source to the eDiscovery search.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation](Get-MgBetaSecurityCaseEdiscoveryCaseSearchAddToReviewSetOperation.md)
Adds the results of the eDiscovery search to the specified reviewSet.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchCustodianSource.md)
Custodian sources that are included in the eDiscovery search.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation](Get-MgBetaSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation.md)
Get the last ediscoveryEstimateOperation objects and their properties.

### [Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource](Get-MgBetaSecurityCaseEdiscoveryCaseSearchNoncustodialSource.md)
noncustodialDataSource sources that are included in the eDiscovery search

### [Get-MgBetaSecurityCaseEdiscoveryCaseSetting](Get-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Read the properties and relationships of an ediscoveryCaseSettings object.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTag](Get-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Returns a list of ediscoveryReviewTag objects associated to this case.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTag](Get-MgBetaSecurityCaseEdiscoveryCaseTagChildTag.md)
Returns the tags that are a child of a tag.

### [Get-MgBetaSecurityCaseEdiscoveryCaseTagParent](Get-MgBetaSecurityCaseEdiscoveryCaseTagParent.md)
Returns the parent tag of the specified tag.

### [Get-MgBetaSecurityCloudAppSecurityProfile](Get-MgBetaSecurityCloudAppSecurityProfile.md)
Get cloudAppSecurityProfiles from security

### [Get-MgBetaSecurityDomainSecurityProfile](Get-MgBetaSecurityDomainSecurityProfile.md)
Get domainSecurityProfiles from security

### [Get-MgBetaSecurityFileSecurityProfile](Get-MgBetaSecurityFileSecurityProfile.md)
Get fileSecurityProfiles from security

### [Get-MgBetaSecurityHostSecurityProfile](Get-MgBetaSecurityHostSecurityProfile.md)
Get hostSecurityProfiles from security

### [Get-MgBetaSecurityIncident](Get-MgBetaSecurityIncident.md)
A collection of incidents in Microsoft 365 Defender, each of which is a set of correlated alerts and associated metadata that reflects the story of an attack.

### [Get-MgBetaSecurityIncidentAlert](Get-MgBetaSecurityIncidentAlert.md)
The list of related alerts.
Supports $expand.

### [Get-MgBetaSecurityInformationProtection](Get-MgBetaSecurityInformationProtection.md)
Get informationProtection from security

### [Get-MgBetaSecurityInformationProtectionLabelPolicySetting](Get-MgBetaSecurityInformationProtectionLabelPolicySetting.md)
Read the properties and relationships of an informationProtectionPolicySetting object.
The settings exposed by this API should be used in applications to populate the **moreInfoUrl** property for Microsoft Purview Information Protection help, and indicate whether labeling is mandatory for the user and whether justification must be provided on downgrade.

### [Get-MgBetaSecurityInformationProtectionSensitivityLabel](Get-MgBetaSecurityInformationProtectionSensitivityLabel.md)
Read the Microsoft Purview Information Protection labels for the user or organization.

### [Get-MgBetaSecurityInformationProtectionSensitivityLabelParent](Get-MgBetaSecurityInformationProtectionSensitivityLabelParent.md)
The parent label associated with a child label.
Null if the label has no parent.

### [Get-MgBetaSecurityIPSecurityProfile](Get-MgBetaSecurityIPSecurityProfile.md)
Get ipSecurityProfiles from security

### [Get-MgBetaSecurityLabel](Get-MgBetaSecurityLabel.md)
Get labels from security

### [Get-MgBetaSecurityLabelRetentionEventType](Get-MgBetaSecurityLabelRetentionEventType.md)
Get retentionEventType from security

### [Get-MgBetaSecurityLabelRetentionLabel](Get-MgBetaSecurityLabelRetentionLabel.md)
Get retentionLabels from security

### [Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](Get-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
Review stages during which reviewers are notified to determine whether a document must be deleted or retained.

### [Get-MgBetaSecurityProviderTenantSetting](Get-MgBetaSecurityProviderTenantSetting.md)
Get providerTenantSettings from security

### [Get-MgBetaSecuritySecureScore](Get-MgBetaSecuritySecureScore.md)
Measurements of tenants’ security posture to help protect them from threats.

### [Get-MgBetaSecuritySecureScoreControlProfile](Get-MgBetaSecuritySecureScoreControlProfile.md)
Get secureScoreControlProfiles from security

### [Get-MgBetaSecuritySubjectRightsRequest](Get-MgBetaSecuritySubjectRightsRequest.md)
Get subjectRightsRequests from security

### [Get-MgBetaSecuritySubjectRightsRequestFinalAttachment](Get-MgBetaSecuritySubjectRightsRequestFinalAttachment.md)
Invoke function getFinalAttachment

### [Get-MgBetaSecuritySubjectRightsRequestFinalReport](Get-MgBetaSecuritySubjectRightsRequestFinalReport.md)
Invoke function getFinalReport

### [Get-MgBetaSecuritySubjectRightsRequestNote](Get-MgBetaSecuritySubjectRightsRequestNote.md)
List of notes associated with the request.

### [Get-MgBetaSecuritySubjectRightsRequestTeam](Get-MgBetaSecuritySubjectRightsRequestTeam.md)
Information about the Microsoft Teams team that was created for the request.

### [Get-MgBetaSecurityThreatSubmission](Get-MgBetaSecurityThreatSubmission.md)
A threat submission sent to Microsoft; for example, a suspicious email threat, URL threat, or file threat.

### [Get-MgBetaSecurityThreatSubmissionEmailThreat](Get-MgBetaSecurityThreatSubmissionEmailThreat.md)
Get emailThreats from security

### [Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy](Get-MgBetaSecurityThreatSubmissionEmailThreatSubmissionPolicy.md)
Get emailThreatSubmissionPolicies from security

### [Get-MgBetaSecurityThreatSubmissionFileThreat](Get-MgBetaSecurityThreatSubmissionFileThreat.md)
Get fileThreats from security

### [Get-MgBetaSecurityThreatSubmissionUrlThreat](Get-MgBetaSecurityThreatSubmissionUrlThreat.md)
Get urlThreats from security

### [Get-MgBetaSecurityTiIndicator](Get-MgBetaSecurityTiIndicator.md)
Get tiIndicators from security

### [Get-MgBetaSecurityTrigger](Get-MgBetaSecurityTrigger.md)
Get triggers from security

### [Get-MgBetaSecurityTriggerRetentionEvent](Get-MgBetaSecurityTriggerRetentionEvent.md)
Get retentionEvents from security

### [Get-MgBetaSecurityTriggerRetentionEventType](Get-MgBetaSecurityTriggerRetentionEventType.md)
Specifies the event that will start the retention period for labels that use this event type when an event is created.

### [Get-MgBetaSecurityTriggerType](Get-MgBetaSecurityTriggerType.md)
Get triggerTypes from security

### [Get-MgBetaSecurityTriggerTypeRetentionEventType](Get-MgBetaSecurityTriggerTypeRetentionEventType.md)
Get retentionEventTypes from security

### [Get-MgBetaSecurityUserSecurityProfile](Get-MgBetaSecurityUserSecurityProfile.md)
Get userSecurityProfiles from security

### [Initialize-MgBetaSecurityCaseEdiscoveryCaseCustodian](Initialize-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an eDiscovery (Premium) case.

### [Invoke-MgBetaAsSecurityCaseEdiscoveryCaseTagHierarchy](Invoke-MgBetaAsSecurityCaseEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics](Invoke-MgBetaEstimateSecurityCaseEdiscoveryCaseSearchStatistics.md)
Run an estimate of the number of emails and documents in the eDiscovery search.
To learn more about searches in eDiscovery, see Collect data for a case in eDiscovery (Premium).

### [Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel](Invoke-MgBetaExtractSecurityInformationProtectionSensitivityLabelContentLabel.md)
Invoke action extractContentLabel

### [Invoke-MgBetaReopenSecurityCaseEdiscoveryCase](Invoke-MgBetaReopenSecurityCaseEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

### [New-MgBetaSecurityAction](New-MgBetaSecurityAction.md)
Create a new securityAction object.

### [New-MgBetaSecurityAlert](New-MgBetaSecurityAlert.md)
Create new navigation property to alerts for security

### [New-MgBetaSecurityAttackSimulation](New-MgBetaSecurityAttackSimulation.md)
Create new navigation property to simulations for security

### [New-MgBetaSecurityAttackSimulationAutomation](New-MgBetaSecurityAttackSimulationAutomation.md)
Create new navigation property to simulationAutomations for security

### [New-MgBetaSecurityAttackSimulationAutomationRun](New-MgBetaSecurityAttackSimulationAutomationRun.md)
Create new navigation property to runs for security

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

### [New-MgBetaSecurityLabelRetentionLabel](New-MgBetaSecurityLabelRetentionLabel.md)
Create a new retentionLabel object.
To create a disposition review stage, include the **actionAfterRetentionPeriod** property in the request body with one of the possible values specified.

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

### [Publish-MgBetaSecurityCaseEdiscoveryCaseCustodian](Publish-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource](Publish-MgBetaSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Release the non-custodial data source from the case.

### [Remove-MgBetaSecurityAction](Remove-MgBetaSecurityAction.md)
Delete navigation property securityActions for security

### [Remove-MgBetaSecurityAttackSimulation](Remove-MgBetaSecurityAttackSimulation.md)
Delete navigation property simulations for security

### [Remove-MgBetaSecurityAttackSimulationAutomation](Remove-MgBetaSecurityAttackSimulationAutomation.md)
Delete navigation property simulationAutomations for security

### [Remove-MgBetaSecurityAttackSimulationAutomationRun](Remove-MgBetaSecurityAttackSimulationAutomationRun.md)
Delete navigation property runs for security

### [Remove-MgBetaSecurityCase](Remove-MgBetaSecurityCase.md)
Delete navigation property cases for security

### [Remove-MgBetaSecurityCaseEdiscoveryCase](Remove-MgBetaSecurityCaseEdiscoveryCase.md)
Delete navigation property ediscoveryCases for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodian](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodian.md)
Delete navigation property custodians for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianHold](Remove-MgBetaSecurityCaseEdiscoveryCaseCustodianHold.md)
Start the process of removing hold from eDiscovery custodians.
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
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
After the operation is created, you can get the status by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return an eDiscoveryHoldOperation object.

### [Remove-MgBetaSecurityCaseEdiscoveryCaseOperation](Remove-MgBetaSecurityCaseEdiscoveryCaseOperation.md)
Delete navigation property operations for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSet](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSet.md)
Delete navigation property reviewSets for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetFile.md)
Delete navigation property files for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery](Remove-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Delete navigation property queries for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearch](Remove-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Delete navigation property searches for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Remove-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Delete navigation property additionalSources for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseSetting](Remove-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Delete navigation property settings for security

### [Remove-MgBetaSecurityCaseEdiscoveryCaseTag](Remove-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Delete navigation property tags for security

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

### [Remove-MgBetaSecurityLabelRetentionLabel](Remove-MgBetaSecurityLabelRetentionLabel.md)
Delete navigation property retentionLabels for security

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
Delete navigation property tiIndicators for security

### [Remove-MgBetaSecurityTiIndicatorByExternalId](Remove-MgBetaSecurityTiIndicatorByExternalId.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests, when the request contains external IDs instead of IDs.

### [Remove-MgBetaSecurityTiIndicatorMultiple](Remove-MgBetaSecurityTiIndicatorMultiple.md)
Delete multiple threat intelligence (TI) indicators in one request instead of multiple requests.

### [Remove-MgBetaSecurityTrigger](Remove-MgBetaSecurityTrigger.md)
Delete navigation property triggers for security

### [Remove-MgBetaSecurityTriggerRetentionEvent](Remove-MgBetaSecurityTriggerRetentionEvent.md)
Delete navigation property retentionEvents for security

### [Remove-MgBetaSecurityTriggerType](Remove-MgBetaSecurityTriggerType.md)
Delete navigation property triggerTypes for security

### [Remove-MgBetaSecurityTriggerTypeRetentionEventType](Remove-MgBetaSecurityTriggerTypeRetentionEventType.md)
Delete navigation property retentionEventTypes for security

### [Remove-MgBetaSecurityUserSecurityProfile](Remove-MgBetaSecurityUserSecurityProfile.md)
Delete navigation property userSecurityProfiles for security

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
Invoke action evaluateApplication

### [Test-MgBetaSecurityInformationProtectionSensitivityLabelClassificationResult](Test-MgBetaSecurityInformationProtectionSensitivityLabelClassificationResult.md)
Invoke action evaluateClassificationResults

### [Test-MgBetaSecurityInformationProtectionSensitivityLabelRemoval](Test-MgBetaSecurityInformationProtectionSensitivityLabelRemoval.md)
Invoke action evaluateRemoval

### [Update-MgBetaSecurityAction](Update-MgBetaSecurityAction.md)
Update the navigation property securityActions in security

### [Update-MgBetaSecurityAlert](Update-MgBetaSecurityAlert.md)
Update the navigation property alerts in security

### [Update-MgBetaSecurityAlertMultiple](Update-MgBetaSecurityAlertMultiple.md)
Update multiple alerts in one request instead of multiple requests.

### [Update-MgBetaSecurityAttackSimulationAutomation](Update-MgBetaSecurityAttackSimulationAutomation.md)
Update the navigation property simulationAutomations in security

### [Update-MgBetaSecurityAttackSimulationAutomationRun](Update-MgBetaSecurityAttackSimulationAutomationRun.md)
Update the navigation property runs in security

### [Update-MgBetaSecurityCase](Update-MgBetaSecurityCase.md)
Update the navigation property cases in security

### [Update-MgBetaSecurityCaseEdiscoveryCase](Update-MgBetaSecurityCaseEdiscoveryCase.md)
Update the navigation property ediscoveryCases in security

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
Update the navigation property queries in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseSearch](Update-MgBetaSecurityCaseEdiscoveryCaseSearch.md)
Update the navigation property searches in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource](Update-MgBetaSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Update the navigation property additionalSources in security

### [Update-MgBetaSecurityCaseEdiscoveryCaseSetting](Update-MgBetaSecurityCaseEdiscoveryCaseSetting.md)
Update the properties of an ediscoveryCaseSettings object.

### [Update-MgBetaSecurityCaseEdiscoveryCaseTag](Update-MgBetaSecurityCaseEdiscoveryCaseTag.md)
Update the navigation property tags in security

### [Update-MgBetaSecurityCloudAppSecurityProfile](Update-MgBetaSecurityCloudAppSecurityProfile.md)
Update the navigation property cloudAppSecurityProfiles in security

### [Update-MgBetaSecurityDomainSecurityProfile](Update-MgBetaSecurityDomainSecurityProfile.md)
Update the navigation property domainSecurityProfiles in security

### [Update-MgBetaSecurityFileSecurityProfile](Update-MgBetaSecurityFileSecurityProfile.md)
Update the navigation property fileSecurityProfiles in security

### [Update-MgBetaSecurityHostSecurityProfile](Update-MgBetaSecurityHostSecurityProfile.md)
Update the navigation property hostSecurityProfiles in security

### [Update-MgBetaSecurityIncident](Update-MgBetaSecurityIncident.md)
Update the navigation property incidents in security

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

### [Update-MgBetaSecurityLabelRetentionLabel](Update-MgBetaSecurityLabelRetentionLabel.md)
Update the navigation property retentionLabels in security

### [Update-MgBetaSecurityLabelRetentionLabelDispositionReviewStage](Update-MgBetaSecurityLabelRetentionLabelDispositionReviewStage.md)
Update the navigation property dispositionReviewStages in security

### [Update-MgBetaSecurityProviderTenantSetting](Update-MgBetaSecurityProviderTenantSetting.md)
Update the navigation property providerTenantSettings in security

### [Update-MgBetaSecuritySecureScore](Update-MgBetaSecuritySecureScore.md)
Update the navigation property secureScores in security

### [Update-MgBetaSecuritySecureScoreControlProfile](Update-MgBetaSecuritySecureScoreControlProfile.md)
Update the navigation property secureScoreControlProfiles in security

### [Update-MgBetaSecuritySubjectRightsRequest](Update-MgBetaSecuritySubjectRightsRequest.md)
Update the navigation property subjectRightsRequests in security

### [Update-MgBetaSecuritySubjectRightsRequestNote](Update-MgBetaSecuritySubjectRightsRequestNote.md)
Update the navigation property notes in security

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
Update the navigation property tiIndicators in security

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

