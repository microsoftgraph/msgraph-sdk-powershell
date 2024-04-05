---
Module Name: Microsoft.Graph.Beta.Compliance
Module Guid: 91bd60e0-4401-4c9a-a4a4-30c5ce620732
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.compliance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Compliance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Compliance Cmdlets
### [Add-MgBetaComplianceEdiscoveryCaseCustodianHold](Add-MgBetaComplianceEdiscoveryCaseCustodianHold.md)
Invoke action applyHold

### [Add-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceHold](Add-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceHold.md)
Invoke action applyHold

### [Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag](Add-MgBetaComplianceEdiscoveryCaseReviewSetQueryTag.md)
Apply tags to documents that match the specified reviewSetQuery.

### [Add-MgBetaComplianceEdiscoveryCaseReviewSetToReviewSet](Add-MgBetaComplianceEdiscoveryCaseReviewSetToReviewSet.md)
Start the process of adding a collection from Microsoft 365 services to a review set.
After the operation is created, you can get the status of the operation by retrieving the Location parameter from the response headers.
The location provides a URL that will return a caseExportOperation.

### [Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData](Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData.md)
Permanently delete Microsoft Teams messages contained in a sourceCollection.
You can collect and purge the following categories of Teams content:\n- Teams 1:1 chats - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- Teams group chats - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- Teams channels - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- Private channels - Message posts, replies, and attachments shared in a private Teams channel.\n- Shared channels - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- Advanced eDiscovery workflow for content in Microsoft Teams

### [Close-MgBetaComplianceEdiscoveryCase](Close-MgBetaComplianceEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Export-MgBetaComplianceEdiscoveryCaseReviewSet](Export-MgBetaComplianceEdiscoveryCaseReviewSet.md)
Initiate an export from a reviewSet.
For details, see Export documents from a review set in Advanced eDiscovery.

### [Get-MgBetaCompliance](Get-MgBetaCompliance.md)
Get compliance

### [Get-MgBetaComplianceEdiscovery](Get-MgBetaComplianceEdiscovery.md)
Get ediscovery from compliance

### [Get-MgBetaComplianceEdiscoveryCase](Get-MgBetaComplianceEdiscoveryCase.md)
Retrieve the properties and relationships of a case object.

### [Get-MgBetaComplianceEdiscoveryCaseCount](Get-MgBetaComplianceEdiscoveryCaseCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseCustodian](Get-MgBetaComplianceEdiscoveryCaseCustodian.md)
Read the properties and relationships of a custodian object.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianCount](Get-MgBetaComplianceEdiscoveryCaseCustodianCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseCustodianLastIndexOperation](Get-MgBetaComplianceEdiscoveryCaseCustodianLastIndexOperation.md)
Get lastIndexOperation from compliance

### [Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSource](Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSource.md)
Read the properties and relationships of a siteSource object.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSourceCount](Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSourceSite](Get-MgBetaComplianceEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Read the properties and relationships of a unifiedGroupSource object.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceCount](Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
The group associated with the unifiedGroupSource.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroupServiceProvisioningError](Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroupServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a group object.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroupServiceProvisioningErrorCount](Get-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUserSource](Get-MgBetaComplianceEdiscoveryCaseCustodianUserSource.md)
Read the properties and relationships of a userSource object.

### [Get-MgBetaComplianceEdiscoveryCaseCustodianUserSourceCount](Get-MgBetaComplianceEdiscoveryCaseCustodianUserSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseLegalHold](Get-MgBetaComplianceEdiscoveryCaseLegalHold.md)
Read the properties and relationships of a legalHold object.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldCount](Get-MgBetaComplianceEdiscoveryCaseLegalHoldCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource](Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Data source entity for SharePoint sites associated with the legal hold.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSourceCount](Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSourceSite](Get-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Get unifiedGroupSources from compliance

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceCount](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroup](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroup.md)
The group associated with the unifiedGroupSource.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroupServiceProvisioningError](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroupServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a group object.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroupServiceProvisioningErrorCount](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroupServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource.md)
Data source entity for a the legal hold.
This is the container for a mailbox and OneDrive for Business site.

### [Get-MgBetaComplianceEdiscoveryCaseLegalHoldUserSourceCount](Get-MgBetaComplianceEdiscoveryCaseLegalHoldUserSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource](Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource.md)
Read the properties and relationships of a noncustodialDataSource object.

### [Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceCount](Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceDataSource](Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceDataSource.md)
User source or SharePoint site data source as noncustodial data source.

### [Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceLastIndexOperation](Get-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceLastIndexOperation.md)
Get lastIndexOperation from compliance

### [Get-MgBetaComplianceEdiscoveryCaseOperation](Get-MgBetaComplianceEdiscoveryCaseOperation.md)
Returns a list of case operation objects for this case.
Nullable.

### [Get-MgBetaComplianceEdiscoveryCaseOperationAsCaseExportOperation](Get-MgBetaComplianceEdiscoveryCaseOperationAsCaseExportOperation.md)
Get the item of type microsoft.graph.ediscovery.caseOperation as microsoft.graph.ediscovery.caseExportOperation

### [Get-MgBetaComplianceEdiscoveryCaseOperationAsCaseExportOperationReviewSet](Get-MgBetaComplianceEdiscoveryCaseOperationAsCaseExportOperationReviewSet.md)
The review set the content is being exported from.

### [Get-MgBetaComplianceEdiscoveryCaseOperationCount](Get-MgBetaComplianceEdiscoveryCaseOperationCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseOperationCountAsCaseExportOperation](Get-MgBetaComplianceEdiscoveryCaseOperationCountAsCaseExportOperation.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseReviewSet](Get-MgBetaComplianceEdiscoveryCaseReviewSet.md)
Retrieve the properties and relationships of a reviewSet object.

### [Get-MgBetaComplianceEdiscoveryCaseReviewSetCount](Get-MgBetaComplianceEdiscoveryCaseReviewSetCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseReviewSetQuery](Get-MgBetaComplianceEdiscoveryCaseReviewSetQuery.md)
Retrieve the properties and relationships of an eDiscovery reviewSetQuery object.

### [Get-MgBetaComplianceEdiscoveryCaseReviewSetQueryCount](Get-MgBetaComplianceEdiscoveryCaseReviewSetQueryCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseSetting](Get-MgBetaComplianceEdiscoveryCaseSetting.md)
Read the properties and relationships of an eDiscovery caseSettings object.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollection](Get-MgBetaComplianceEdiscoveryCaseSourceCollection.md)
Returns a list of sourceCollection objects associated with this case.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Adds an additional source to the sourceCollection.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSourceCount](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAddToReviewSetOperation](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionAddToReviewSetOperation.md)
Get the last addToReviewSetOperation object associated with a source collection.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCount](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCustodianSource](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCustodianSource.md)
Custodian sources that are included in the sourceCollection.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCustodianSourceCount](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionCustodianSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionLastEstimateStatisticsOperation](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionLastEstimateStatisticsOperation.md)
Get the last estimateStatisticsOperation object associated with a source collection.

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionNoncustodialSource](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionNoncustodialSource.md)
noncustodialDataSource sources that are included in the sourceCollection

### [Get-MgBetaComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceCount](Get-MgBetaComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseTag](Get-MgBetaComplianceEdiscoveryCaseTag.md)
Read the properties and relationships of a tag object.

### [Get-MgBetaComplianceEdiscoveryCaseTagChildTag](Get-MgBetaComplianceEdiscoveryCaseTagChildTag.md)
Returns the tags that are a child of a tag.

### [Get-MgBetaComplianceEdiscoveryCaseTagChildTagCount](Get-MgBetaComplianceEdiscoveryCaseTagChildTagCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseTagCount](Get-MgBetaComplianceEdiscoveryCaseTagCount.md)
Get the number of the resource

### [Get-MgBetaComplianceEdiscoveryCaseTagParent](Get-MgBetaComplianceEdiscoveryCaseTagParent.md)
Returns the parent tag of the specified tag.

### [Get-MgBetaPrivacySubjectRightsRequest](Get-MgBetaPrivacySubjectRightsRequest.md)
Read the properties and relationships of a subjectRightsRequest object.

### [Get-MgBetaPrivacySubjectRightsRequestApprover](Get-MgBetaPrivacySubjectRightsRequestApprover.md)
Get approvers from privacy

### [Get-MgBetaPrivacySubjectRightsRequestApproverCount](Get-MgBetaPrivacySubjectRightsRequestApproverCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestApproverMailboxSetting](Get-MgBetaPrivacySubjectRightsRequestApproverMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaPrivacySubjectRightsRequestApproverServiceProvisioningError](Get-MgBetaPrivacySubjectRightsRequestApproverServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.

### [Get-MgBetaPrivacySubjectRightsRequestApproverServiceProvisioningErrorCount](Get-MgBetaPrivacySubjectRightsRequestApproverServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestCollaborator](Get-MgBetaPrivacySubjectRightsRequestCollaborator.md)
Get collaborators from privacy

### [Get-MgBetaPrivacySubjectRightsRequestCollaboratorCount](Get-MgBetaPrivacySubjectRightsRequestCollaboratorCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestCollaboratorMailboxSetting](Get-MgBetaPrivacySubjectRightsRequestCollaboratorMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaPrivacySubjectRightsRequestCollaboratorServiceProvisioningError](Get-MgBetaPrivacySubjectRightsRequestCollaboratorServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.

### [Get-MgBetaPrivacySubjectRightsRequestCollaboratorServiceProvisioningErrorCount](Get-MgBetaPrivacySubjectRightsRequestCollaboratorServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestCount](Get-MgBetaPrivacySubjectRightsRequestCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestNote](Get-MgBetaPrivacySubjectRightsRequestNote.md)
List of notes associated with the request.

### [Get-MgBetaPrivacySubjectRightsRequestNoteCount](Get-MgBetaPrivacySubjectRightsRequestNoteCount.md)
Get the number of the resource

### [Get-MgBetaPrivacySubjectRightsRequestTeam](Get-MgBetaPrivacySubjectRightsRequestTeam.md)
Information about the Microsoft Teams team that was created for the request.

### [Initialize-MgBetaComplianceEdiscoveryCaseCustodian](Initialize-MgBetaComplianceEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an Advanced eDiscovery case.

### [Invoke-MgBetaAsComplianceEdiscoveryCaseTagHierarchy](Invoke-MgBetaAsComplianceEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics](Invoke-MgBetaEstimateComplianceEdiscoveryCaseSourceCollectionStatistics.md)
Run an estimate of the number of emails and documents in the source collection.
To learn more about source collections (also known as searches in eDiscovery), see Collect data for a case in Advanced eDiscovery.

### [Invoke-MgBetaReopenComplianceEdiscoveryCase](Invoke-MgBetaReopenComplianceEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

### [New-MgBetaComplianceEdiscoveryCase](New-MgBetaComplianceEdiscoveryCase.md)
Create a new case object.

### [New-MgBetaComplianceEdiscoveryCaseCustodian](New-MgBetaComplianceEdiscoveryCaseCustodian.md)
Create a new custodian object.
After the custodian object is created, you will need to create the custodian's userSource to reference their mailbox and OneDrive for Business site.

### [New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource](New-MgBetaComplianceEdiscoveryCaseCustodianSiteSource.md)
Create a new custodian siteSource object.

### [New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource](New-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Create a new unifiedGroupSource object.

### [New-MgBetaComplianceEdiscoveryCaseCustodianUserSource](New-MgBetaComplianceEdiscoveryCaseCustodianUserSource.md)
Create a new custodian userSource object.

### [New-MgBetaComplianceEdiscoveryCaseLegalHold](New-MgBetaComplianceEdiscoveryCaseLegalHold.md)
Create new navigation property to legalHolds for compliance

### [New-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource](New-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Adds a siteSource to a legalHold object.

### [New-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](New-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Create new navigation property to unifiedGroupSources for compliance

### [New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource](New-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource.md)
Adds a userSource to a legalHold object.

### [New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource](New-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource.md)
Create a new noncustodialDataSource object.

### [New-MgBetaComplianceEdiscoveryCaseOperation](New-MgBetaComplianceEdiscoveryCaseOperation.md)
Create new navigation property to operations for compliance

### [New-MgBetaComplianceEdiscoveryCaseReviewSet](New-MgBetaComplianceEdiscoveryCaseReviewSet.md)
Create a new reviewSet object.
The request body contains the display name of the review set, which is the only writable property.

### [New-MgBetaComplianceEdiscoveryCaseReviewSetQuery](New-MgBetaComplianceEdiscoveryCaseReviewSetQuery.md)
Create a new reviewSetQuery object.

### [New-MgBetaComplianceEdiscoveryCaseSourceCollection](New-MgBetaComplianceEdiscoveryCaseSourceCollection.md)
Create a new sourceCollection object.

### [New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource](New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Create new navigation property to additionalSources for compliance

### [New-MgBetaComplianceEdiscoveryCaseTag](New-MgBetaComplianceEdiscoveryCaseTag.md)
Create a new tag for the specified case.
The tags are used in review sets while reviewing content.

### [New-MgBetaPrivacySubjectRightsRequest](New-MgBetaPrivacySubjectRightsRequest.md)
Create a new subjectRightsRequest object.

### [New-MgBetaPrivacySubjectRightsRequestNote](New-MgBetaPrivacySubjectRightsRequestNote.md)
Create a new authoredNote object.

### [Publish-MgBetaComplianceEdiscoveryCaseCustodian](Publish-MgBetaComplianceEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource](Publish-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource.md)
Releases the non-custodial data source from the case.

### [Remove-MgBetaComplianceEdiscovery](Remove-MgBetaComplianceEdiscovery.md)
Delete navigation property ediscovery for compliance

### [Remove-MgBetaComplianceEdiscoveryCase](Remove-MgBetaComplianceEdiscoveryCase.md)
Delete a case object.

### [Remove-MgBetaComplianceEdiscoveryCaseCustodian](Remove-MgBetaComplianceEdiscoveryCaseCustodian.md)
Delete navigation property custodians for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseCustodianHold](Remove-MgBetaComplianceEdiscoveryCaseCustodianHold.md)
Invoke action removeHold

### [Remove-MgBetaComplianceEdiscoveryCaseCustodianSiteSource](Remove-MgBetaComplianceEdiscoveryCaseCustodianSiteSource.md)
Delete a siteSource object.

### [Remove-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Remove-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Delete a unifiedGroupSource object.

### [Remove-MgBetaComplianceEdiscoveryCaseCustodianUserSource](Remove-MgBetaComplianceEdiscoveryCaseCustodianUserSource.md)
Delete a userSource object.

### [Remove-MgBetaComplianceEdiscoveryCaseLegalHold](Remove-MgBetaComplianceEdiscoveryCaseLegalHold.md)
Delete a legalHold object.

### [Remove-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource](Remove-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Delete navigation property siteSources for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Remove-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Delete navigation property unifiedGroupSources for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource](Remove-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource.md)
Delete navigation property userSources for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource](Remove-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource.md)
Delete navigation property noncustodialDataSources for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceHold](Remove-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceHold.md)
Invoke action removeHold

### [Remove-MgBetaComplianceEdiscoveryCaseOperation](Remove-MgBetaComplianceEdiscoveryCaseOperation.md)
Delete navigation property operations for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseReviewSet](Remove-MgBetaComplianceEdiscoveryCaseReviewSet.md)
Delete navigation property reviewSets for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseReviewSetQuery](Remove-MgBetaComplianceEdiscoveryCaseReviewSetQuery.md)
Delete a reviewSetQuery object.

### [Remove-MgBetaComplianceEdiscoveryCaseSetting](Remove-MgBetaComplianceEdiscoveryCaseSetting.md)
Delete navigation property settings for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseSourceCollection](Remove-MgBetaComplianceEdiscoveryCaseSourceCollection.md)
Delete a sourceCollection object.

### [Remove-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Remove-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Delete navigation property additionalSources for compliance

### [Remove-MgBetaComplianceEdiscoveryCaseTag](Remove-MgBetaComplianceEdiscoveryCaseTag.md)
Delete a tag object.

### [Remove-MgBetaPrivacySubjectRightsRequest](Remove-MgBetaPrivacySubjectRightsRequest.md)
Delete navigation property subjectRightsRequests for privacy

### [Remove-MgBetaPrivacySubjectRightsRequestNote](Remove-MgBetaPrivacySubjectRightsRequestNote.md)
Delete navigation property notes for privacy

### [Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault](Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault.md)
Reset a caseSettings object to the default values.

### [Update-MgBetaCompliance](Update-MgBetaCompliance.md)
Update compliance

### [Update-MgBetaComplianceEdiscovery](Update-MgBetaComplianceEdiscovery.md)
Update the navigation property ediscovery in compliance

### [Update-MgBetaComplianceEdiscoveryCase](Update-MgBetaComplianceEdiscoveryCase.md)
Update the properties of a case object.

### [Update-MgBetaComplianceEdiscoveryCaseCustodian](Update-MgBetaComplianceEdiscoveryCaseCustodian.md)
Update the properties of a custodian object.

### [Update-MgBetaComplianceEdiscoveryCaseCustodianIndex](Update-MgBetaComplianceEdiscoveryCaseCustodianIndex.md)
Invoke action updateIndex

### [Update-MgBetaComplianceEdiscoveryCaseCustodianSiteSource](Update-MgBetaComplianceEdiscoveryCaseCustodianSiteSource.md)
Update the navigation property siteSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Update-MgBetaComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseCustodianUserSource](Update-MgBetaComplianceEdiscoveryCaseCustodianUserSource.md)
Update the navigation property userSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseLegalHold](Update-MgBetaComplianceEdiscoveryCaseLegalHold.md)
Update the properties of a legalHold object.

### [Update-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource](Update-MgBetaComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Update the navigation property siteSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Update-MgBetaComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource](Update-MgBetaComplianceEdiscoveryCaseLegalHoldUserSource.md)
Update the navigation property userSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource](Update-MgBetaComplianceEdiscoveryCaseNoncustodialDataSource.md)
Update the navigation property noncustodialDataSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceIndex](Update-MgBetaComplianceEdiscoveryCaseNoncustodialDataSourceIndex.md)
Invoke action updateIndex

### [Update-MgBetaComplianceEdiscoveryCaseOperation](Update-MgBetaComplianceEdiscoveryCaseOperation.md)
Update the navigation property operations in compliance

### [Update-MgBetaComplianceEdiscoveryCaseReviewSet](Update-MgBetaComplianceEdiscoveryCaseReviewSet.md)
Update the navigation property reviewSets in compliance

### [Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery](Update-MgBetaComplianceEdiscoveryCaseReviewSetQuery.md)
Update the properties of an eDiscovery reviewSetQuery.

### [Update-MgBetaComplianceEdiscoveryCaseSetting](Update-MgBetaComplianceEdiscoveryCaseSetting.md)
Update the properties of a an eDiscovery caseSettings object.

### [Update-MgBetaComplianceEdiscoveryCaseSourceCollection](Update-MgBetaComplianceEdiscoveryCaseSourceCollection.md)
Update the properties of a sourceCollection object.

### [Update-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Update-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Update the navigation property additionalSources in compliance

### [Update-MgBetaComplianceEdiscoveryCaseTag](Update-MgBetaComplianceEdiscoveryCaseTag.md)
Update the properties of a tag object.

### [Update-MgBetaPrivacySubjectRightsRequest](Update-MgBetaPrivacySubjectRightsRequest.md)
Update the properties of a subjectRightsRequest object.

### [Update-MgBetaPrivacySubjectRightsRequestApproverMailboxSetting](Update-MgBetaPrivacySubjectRightsRequestApproverMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaPrivacySubjectRightsRequestCollaboratorMailboxSetting](Update-MgBetaPrivacySubjectRightsRequestCollaboratorMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaPrivacySubjectRightsRequestNote](Update-MgBetaPrivacySubjectRightsRequestNote.md)
Update the navigation property notes in privacy

