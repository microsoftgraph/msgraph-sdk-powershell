---
Module Name: Microsoft.Graph.Compliance
Module Guid: 62cfbe62-d47c-4175-bc08-f211365ef80b
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Compliance Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Compliance Cmdlets
### [Add-MgComplianceEdiscoveryCaseCustodianHold](Add-MgComplianceEdiscoveryCaseCustodianHold.md)
Invoke action applyHold

### [Add-MgComplianceEdiscoveryCaseNoncustodialDataSourceHold](Add-MgComplianceEdiscoveryCaseNoncustodialDataSourceHold.md)
Invoke action applyHold

### [Add-MgComplianceEdiscoveryCaseReviewSetQueryTag](Add-MgComplianceEdiscoveryCaseReviewSetQueryTag.md)
Apply tags to documents that match the specified reviewSetQuery.

### [Add-MgComplianceEdiscoveryCaseReviewSetToReviewSet](Add-MgComplianceEdiscoveryCaseReviewSetToReviewSet.md)
Start the process of adding a collection from Microsoft 365 services to a review set.
After the operation is created, you can get the status of the operation by retrieving the `Location` parameter from the response headers.
The location provides a URL that will return a caseExportOperation.

### [Clear-MgComplianceEdiscoveryCaseSourceCollectionData](Clear-MgComplianceEdiscoveryCaseSourceCollectionData.md)
Permanently delete Microsoft Teams messages contained in a sourceCollection.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- Advanced eDiscovery workflow for content in Microsoft Teams

### [Close-MgComplianceEdiscoveryCase](Close-MgComplianceEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Export-MgComplianceEdiscoveryCaseReviewSet](Export-MgComplianceEdiscoveryCaseReviewSet.md)
Initiate an export from a **reviewSet**.
For details, see Export documents from a review set in Advanced eDiscovery.

### [Get-MgCompliance](Get-MgCompliance.md)
Get compliance

### [Get-MgComplianceEdiscovery](Get-MgComplianceEdiscovery.md)
Get ediscovery from compliance

### [Get-MgComplianceEdiscoveryCase](Get-MgComplianceEdiscoveryCase.md)
Get cases from compliance

### [Get-MgComplianceEdiscoveryCaseCustodian](Get-MgComplianceEdiscoveryCaseCustodian.md)
Returns a list of case custodian objects for this case.
Nullable.

### [Get-MgComplianceEdiscoveryCaseCustodianSiteSource](Get-MgComplianceEdiscoveryCaseCustodianSiteSource.md)
Data source entity for SharePoint sites associated with the custodian.

### [Get-MgComplianceEdiscoveryCaseCustodianSiteSourceSite](Get-MgComplianceEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Data source entity for groups associated with the custodian.

### [Get-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
The group associated with the unifiedGroupSource.

### [Get-MgComplianceEdiscoveryCaseCustodianUserSource](Get-MgComplianceEdiscoveryCaseCustodianUserSource.md)
Data source entity for a the custodian.
This is the container for a custodian's mailbox and OneDrive for Business site.

### [Get-MgComplianceEdiscoveryCaseLegalHold](Get-MgComplianceEdiscoveryCaseLegalHold.md)
Returns a list of case legalHold objects for this case.
Nullable.

### [Get-MgComplianceEdiscoveryCaseLegalHoldSiteSource](Get-MgComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Data source entity for SharePoint sites associated with the legal hold.

### [Get-MgComplianceEdiscoveryCaseLegalHoldSiteSourceSite](Get-MgComplianceEdiscoveryCaseLegalHoldSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Get-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Get unifiedGroupSources from compliance

### [Get-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroup](Get-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSourceGroup.md)
The group associated with the unifiedGroupSource.

### [Get-MgComplianceEdiscoveryCaseLegalHoldUserSource](Get-MgComplianceEdiscoveryCaseLegalHoldUserSource.md)
Data source entity for a the legal hold.
This is the container for a mailbox and OneDrive for Business site.

### [Get-MgComplianceEdiscoveryCaseNoncustodialDataSource](Get-MgComplianceEdiscoveryCaseNoncustodialDataSource.md)
Returns a list of case noncustodialDataSource objects for this case.
Nullable.

### [Get-MgComplianceEdiscoveryCaseOperation](Get-MgComplianceEdiscoveryCaseOperation.md)
Returns a list of case operation objects for this case.
Nullable.

### [Get-MgComplianceEdiscoveryCaseReviewSet](Get-MgComplianceEdiscoveryCaseReviewSet.md)
Returns a list of reviewSet objects in the case.
Read-only.
Nullable.

### [Get-MgComplianceEdiscoveryCaseReviewSetQuery](Get-MgComplianceEdiscoveryCaseReviewSetQuery.md)
Get queries from compliance

### [Get-MgComplianceEdiscoveryCaseSetting](Get-MgComplianceEdiscoveryCaseSetting.md)
Read the properties and relationships of an eDiscovery caseSettings object.

### [Get-MgComplianceEdiscoveryCaseSourceCollection](Get-MgComplianceEdiscoveryCaseSourceCollection.md)
Returns a list of sourceCollection objects associated with this case.

### [Get-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Get-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Adds an additional source to the sourceCollection.

### [Get-MgComplianceEdiscoveryCaseSourceCollectionAddToReviewSetOperation](Get-MgComplianceEdiscoveryCaseSourceCollectionAddToReviewSetOperation.md)
Get the last addToReviewSetOperation object associated with a source collection.

### [Get-MgComplianceEdiscoveryCaseSourceCollectionCustodianSource](Get-MgComplianceEdiscoveryCaseSourceCollectionCustodianSource.md)
Custodian sources that are included in the sourceCollection.

### [Get-MgComplianceEdiscoveryCaseSourceCollectionLastEstimateStatisticsOperation](Get-MgComplianceEdiscoveryCaseSourceCollectionLastEstimateStatisticsOperation.md)
Get the last estimateStatisticsOperation object associated with a source collection.

### [Get-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSource](Get-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSource.md)
noncustodialDataSource sources that are included in the sourceCollection

### [Get-MgComplianceEdiscoveryCaseTag](Get-MgComplianceEdiscoveryCaseTag.md)
Returns a list of tag objects associated to this case.

### [Get-MgComplianceEdiscoveryCaseTagChildTag](Get-MgComplianceEdiscoveryCaseTagChildTag.md)
Returns the tags that are a child of a tag.

### [Get-MgComplianceEdiscoveryCaseTagParent](Get-MgComplianceEdiscoveryCaseTagParent.md)
Returns the parent tag of the specified tag.

### [Initialize-MgComplianceEdiscoveryCaseCustodian](Initialize-MgComplianceEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an Advanced eDiscovery case.

### [Invoke-MgAsComplianceEdiscoveryCaseTagHierarchy](Invoke-MgAsComplianceEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgEstimateComplianceEdiscoveryCaseSourceCollectionStatistics](Invoke-MgEstimateComplianceEdiscoveryCaseSourceCollectionStatistics.md)
Run an estimate of the number of emails and documents in the source collection.
To learn more about source collections (also known as searches in eDiscovery), see Collect data for a case in Advanced eDiscovery.

### [Invoke-MgReopenComplianceEdiscoveryCase](Invoke-MgReopenComplianceEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

### [New-MgComplianceEdiscoveryCase](New-MgComplianceEdiscoveryCase.md)
Create a new case object.

### [New-MgComplianceEdiscoveryCaseCustodian](New-MgComplianceEdiscoveryCaseCustodian.md)
Create a new custodian object.
After the custodian object is created, you will need to create the custodian's userSource to reference their mailbox and OneDrive for Business site.

### [New-MgComplianceEdiscoveryCaseCustodianSiteSource](New-MgComplianceEdiscoveryCaseCustodianSiteSource.md)
Create a new custodian siteSource object.

### [New-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource](New-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Create a new unifiedGroupSource object.

### [New-MgComplianceEdiscoveryCaseCustodianUserSource](New-MgComplianceEdiscoveryCaseCustodianUserSource.md)
Create a new custodian userSource object.

### [New-MgComplianceEdiscoveryCaseLegalHold](New-MgComplianceEdiscoveryCaseLegalHold.md)
Create new navigation property to legalHolds for compliance

### [New-MgComplianceEdiscoveryCaseLegalHoldSiteSource](New-MgComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Adds a siteSource to a legalHold object.

### [New-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](New-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Create new navigation property to unifiedGroupSources for compliance

### [New-MgComplianceEdiscoveryCaseLegalHoldUserSource](New-MgComplianceEdiscoveryCaseLegalHoldUserSource.md)
Adds a userSource to a legalHold object.

### [New-MgComplianceEdiscoveryCaseNoncustodialDataSource](New-MgComplianceEdiscoveryCaseNoncustodialDataSource.md)
Create a new noncustodialDataSource object.

### [New-MgComplianceEdiscoveryCaseOperation](New-MgComplianceEdiscoveryCaseOperation.md)
Create new navigation property to operations for compliance

### [New-MgComplianceEdiscoveryCaseReviewSet](New-MgComplianceEdiscoveryCaseReviewSet.md)
Create a new reviewSet object.
The request body contains the display name of the review set, which is the only writable property.

### [New-MgComplianceEdiscoveryCaseReviewSetQuery](New-MgComplianceEdiscoveryCaseReviewSetQuery.md)
Create a new reviewSetQuery object.

### [New-MgComplianceEdiscoveryCaseSourceCollection](New-MgComplianceEdiscoveryCaseSourceCollection.md)
Create a new sourceCollection object.

### [New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource](New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Create new navigation property to additionalSources for compliance

### [New-MgComplianceEdiscoveryCaseTag](New-MgComplianceEdiscoveryCaseTag.md)
Create a new tag for the specified case.
The tags are used in review sets while reviewing content.

### [Publish-MgComplianceEdiscoveryCaseCustodian](Publish-MgComplianceEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgComplianceEdiscoveryCaseNoncustodialDataSource](Publish-MgComplianceEdiscoveryCaseNoncustodialDataSource.md)
Releases the non-custodial data source from the case.

### [Remove-MgComplianceEdiscovery](Remove-MgComplianceEdiscovery.md)
Delete navigation property ediscovery for compliance

### [Remove-MgComplianceEdiscoveryCase](Remove-MgComplianceEdiscoveryCase.md)
Delete navigation property cases for compliance

### [Remove-MgComplianceEdiscoveryCaseCustodian](Remove-MgComplianceEdiscoveryCaseCustodian.md)
Delete navigation property custodians for compliance

### [Remove-MgComplianceEdiscoveryCaseCustodianHold](Remove-MgComplianceEdiscoveryCaseCustodianHold.md)
Invoke action removeHold

### [Remove-MgComplianceEdiscoveryCaseCustodianSiteSource](Remove-MgComplianceEdiscoveryCaseCustodianSiteSource.md)
Delete navigation property siteSources for compliance

### [Remove-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Remove-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Delete navigation property unifiedGroupSources for compliance

### [Remove-MgComplianceEdiscoveryCaseCustodianUserSource](Remove-MgComplianceEdiscoveryCaseCustodianUserSource.md)
Delete navigation property userSources for compliance

### [Remove-MgComplianceEdiscoveryCaseLegalHold](Remove-MgComplianceEdiscoveryCaseLegalHold.md)
Delete navigation property legalHolds for compliance

### [Remove-MgComplianceEdiscoveryCaseLegalHoldSiteSource](Remove-MgComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Delete navigation property siteSources for compliance

### [Remove-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Remove-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Delete navigation property unifiedGroupSources for compliance

### [Remove-MgComplianceEdiscoveryCaseLegalHoldUserSource](Remove-MgComplianceEdiscoveryCaseLegalHoldUserSource.md)
Delete navigation property userSources for compliance

### [Remove-MgComplianceEdiscoveryCaseNoncustodialDataSource](Remove-MgComplianceEdiscoveryCaseNoncustodialDataSource.md)
Delete navigation property noncustodialDataSources for compliance

### [Remove-MgComplianceEdiscoveryCaseNoncustodialDataSourceHold](Remove-MgComplianceEdiscoveryCaseNoncustodialDataSourceHold.md)
Invoke action removeHold

### [Remove-MgComplianceEdiscoveryCaseOperation](Remove-MgComplianceEdiscoveryCaseOperation.md)
Delete navigation property operations for compliance

### [Remove-MgComplianceEdiscoveryCaseReviewSet](Remove-MgComplianceEdiscoveryCaseReviewSet.md)
Delete navigation property reviewSets for compliance

### [Remove-MgComplianceEdiscoveryCaseReviewSetQuery](Remove-MgComplianceEdiscoveryCaseReviewSetQuery.md)
Delete navigation property queries for compliance

### [Remove-MgComplianceEdiscoveryCaseSetting](Remove-MgComplianceEdiscoveryCaseSetting.md)
Delete navigation property settings for compliance

### [Remove-MgComplianceEdiscoveryCaseSourceCollection](Remove-MgComplianceEdiscoveryCaseSourceCollection.md)
Delete navigation property sourceCollections for compliance

### [Remove-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Remove-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Delete navigation property additionalSources for compliance

### [Remove-MgComplianceEdiscoveryCaseTag](Remove-MgComplianceEdiscoveryCaseTag.md)
Delete navigation property tags for compliance

### [Reset-MgComplianceEdiscoveryCaseSettingToDefault](Reset-MgComplianceEdiscoveryCaseSettingToDefault.md)
Reset a caseSettings object to the default values.

### [Update-MgCompliance](Update-MgCompliance.md)
Update compliance

### [Update-MgComplianceEdiscovery](Update-MgComplianceEdiscovery.md)
Update the navigation property ediscovery in compliance

### [Update-MgComplianceEdiscoveryCase](Update-MgComplianceEdiscoveryCase.md)
Update the navigation property cases in compliance

### [Update-MgComplianceEdiscoveryCaseCustodian](Update-MgComplianceEdiscoveryCaseCustodian.md)
Update the navigation property custodians in compliance

### [Update-MgComplianceEdiscoveryCaseCustodianIndex](Update-MgComplianceEdiscoveryCaseCustodianIndex.md)
Invoke action updateIndex

### [Update-MgComplianceEdiscoveryCaseCustodianSiteSource](Update-MgComplianceEdiscoveryCaseCustodianSiteSource.md)
Update the navigation property siteSources in compliance

### [Update-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource](Update-MgComplianceEdiscoveryCaseCustodianUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in compliance

### [Update-MgComplianceEdiscoveryCaseCustodianUserSource](Update-MgComplianceEdiscoveryCaseCustodianUserSource.md)
Update the navigation property userSources in compliance

### [Update-MgComplianceEdiscoveryCaseLegalHold](Update-MgComplianceEdiscoveryCaseLegalHold.md)
Update the navigation property legalHolds in compliance

### [Update-MgComplianceEdiscoveryCaseLegalHoldSiteSource](Update-MgComplianceEdiscoveryCaseLegalHoldSiteSource.md)
Update the navigation property siteSources in compliance

### [Update-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource](Update-MgComplianceEdiscoveryCaseLegalHoldUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in compliance

### [Update-MgComplianceEdiscoveryCaseLegalHoldUserSource](Update-MgComplianceEdiscoveryCaseLegalHoldUserSource.md)
Update the navigation property userSources in compliance

### [Update-MgComplianceEdiscoveryCaseNoncustodialDataSource](Update-MgComplianceEdiscoveryCaseNoncustodialDataSource.md)
Update the navigation property noncustodialDataSources in compliance

### [Update-MgComplianceEdiscoveryCaseNoncustodialDataSourceIndex](Update-MgComplianceEdiscoveryCaseNoncustodialDataSourceIndex.md)
Invoke action updateIndex

### [Update-MgComplianceEdiscoveryCaseOperation](Update-MgComplianceEdiscoveryCaseOperation.md)
Update the navigation property operations in compliance

### [Update-MgComplianceEdiscoveryCaseReviewSet](Update-MgComplianceEdiscoveryCaseReviewSet.md)
Update the navigation property reviewSets in compliance

### [Update-MgComplianceEdiscoveryCaseReviewSetQuery](Update-MgComplianceEdiscoveryCaseReviewSetQuery.md)
Update the navigation property queries in compliance

### [Update-MgComplianceEdiscoveryCaseSetting](Update-MgComplianceEdiscoveryCaseSetting.md)
Update the properties of a an eDiscovery caseSettings object.

### [Update-MgComplianceEdiscoveryCaseSourceCollection](Update-MgComplianceEdiscoveryCaseSourceCollection.md)
Update the navigation property sourceCollections in compliance

### [Update-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource](Update-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource.md)
Update the navigation property additionalSources in compliance

### [Update-MgComplianceEdiscoveryCaseTag](Update-MgComplianceEdiscoveryCaseTag.md)
Update the navigation property tags in compliance

