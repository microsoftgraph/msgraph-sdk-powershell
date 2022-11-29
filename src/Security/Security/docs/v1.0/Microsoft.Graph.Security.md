---
Module Name: Microsoft.Graph.Security
Module Guid: c243c0e2-fde3-409c-86c7-9ff5fd49604e
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

### [Close-MgSecurityCaseEdiscoveryCase](Close-MgSecurityCaseEdiscoveryCase.md)
Close an eDiscovery case.
For details, see Close a case.

### [Get-MgSecurityAlert](Get-MgSecurityAlert.md)
Get alerts from security

### [Get-MgSecurityAttackSimulation](Get-MgSecurityAttackSimulation.md)
Get attackSimulation from security

### [Get-MgSecurityAttackSimulationAutomation](Get-MgSecurityAttackSimulationAutomation.md)
Represents simulation automation created to run on a tenant.

### [Get-MgSecurityAttackSimulationAutomationRun](Get-MgSecurityAttackSimulationAutomationRun.md)
A collection of simulation automation runs.

### [Get-MgSecurityCase](Get-MgSecurityCase.md)
Get cases from security

### [Get-MgSecurityCaseEdiscoveryCase](Get-MgSecurityCaseEdiscoveryCase.md)
Get ediscoveryCases from security

### [Get-MgSecurityCaseEdiscoveryCaseCustodian](Get-MgSecurityCaseEdiscoveryCaseCustodian.md)
Returns a list of case ediscoveryCustodian objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianLastIndexOperation](Get-MgSecurityCaseEdiscoveryCaseCustodianLastIndexOperation.md)
Get a list of the ediscoveryIndexOperations associated with an ediscoveryCustodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Data source entity for SharePoint sites associated with the custodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSourceSite](Get-MgSecurityCaseEdiscoveryCaseCustodianSiteSourceSite.md)
The SharePoint site associated with the siteSource.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Data source entity for groups associated with the custodian.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup](Get-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSourceGroup.md)
Represents a group.

### [Get-MgSecurityCaseEdiscoveryCaseCustodianUserSource](Get-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Data source entity for a the custodian.
This is the container for a custodian's mailbox and OneDrive for Business site.

### [Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Returns a list of case ediscoveryNoncustodialDataSource objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation](Get-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceLastIndexOperation.md)
Operation entity that represents the latest indexing for the non-custodial data source.

### [Get-MgSecurityCaseEdiscoveryCaseOperation](Get-MgSecurityCaseEdiscoveryCaseOperation.md)
Returns a list of case caseOperation objects for this case.

### [Get-MgSecurityCaseEdiscoveryCaseReviewSet](Get-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Returns a list of eDiscoveryReviewSet objects in the case.

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
Get the last  ediscoveryEstimateOperation objects and their properties.

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

### [Get-MgSecuritySecureScore](Get-MgSecuritySecureScore.md)
Get secureScores from security

### [Get-MgSecuritySecureScoreControlProfile](Get-MgSecuritySecureScoreControlProfile.md)
Get secureScoreControlProfiles from security

### [Initialize-MgSecurityCaseEdiscoveryCaseCustodian](Initialize-MgSecurityCaseEdiscoveryCaseCustodian.md)
Activate a custodian that has been released from a case to make them part of the case again.
For details, see Manage custodians in an eDiscovery (Premium) case.

### [Invoke-MgAsSecurityCaseEdiscoveryCaseTagHierarchy](Invoke-MgAsSecurityCaseEdiscoveryCaseTagHierarchy.md)
Invoke function asHierarchy

### [Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics](Invoke-MgEstimateSecurityCaseEdiscoveryCaseSearchStatistics.md)
Run an estimate of the number of emails and documents in the eDiscovery search.
To learn more about searches in eDiscovery, see Collect data for a case in eDiscovery (Premium).

### [Invoke-MgReopenSecurityCaseEdiscoveryCase](Invoke-MgReopenSecurityCaseEdiscoveryCase.md)
Reopen an eDiscovery case that was closed.
For details, see Reopen a closed case.

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

### [New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](New-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Create a new ediscoveryNoncustodialDataSource object.

### [New-MgSecurityCaseEdiscoveryCaseOperation](New-MgSecurityCaseEdiscoveryCaseOperation.md)
Create new navigation property to operations for security

### [New-MgSecurityCaseEdiscoveryCaseReviewSet](New-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Create a new ediscoveryReviewSet object.

### [New-MgSecurityCaseEdiscoveryCaseReviewSetQuery](New-MgSecurityCaseEdiscoveryCaseReviewSetQuery.md)
Create a new ediscoveryReviewSetQuery object.

### [New-MgSecurityCaseEdiscoveryCaseSearch](New-MgSecurityCaseEdiscoveryCaseSearch.md)
Create a new ediscoverySearch object.

### [New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource](New-MgSecurityCaseEdiscoveryCaseSearchAdditionalSource.md)
Create a new additional source associated with an eDiscovery search.

### [New-MgSecurityCaseEdiscoveryCaseTag](New-MgSecurityCaseEdiscoveryCaseTag.md)
Create a new ediscoveryReviewTag object.

### [New-MgSecuritySecureScore](New-MgSecuritySecureScore.md)
Create new navigation property to secureScores for security

### [New-MgSecuritySecureScoreControlProfile](New-MgSecuritySecureScoreControlProfile.md)
Create new navigation property to secureScoreControlProfiles for security

### [Publish-MgSecurityCaseEdiscoveryCaseCustodian](Publish-MgSecurityCaseEdiscoveryCaseCustodian.md)
Release a custodian from a case.
For details, see Release a custodian from a case.

### [Publish-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Publish-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Release the non-custodial data source from the case.

### [Remove-MgSecurityAttackSimulation](Remove-MgSecurityAttackSimulation.md)
Delete navigation property attackSimulation for security

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

### [Remove-MgSecuritySecureScore](Remove-MgSecuritySecureScore.md)
Delete navigation property secureScores for security

### [Remove-MgSecuritySecureScoreControlProfile](Remove-MgSecuritySecureScoreControlProfile.md)
Delete navigation property secureScoreControlProfiles for security

### [Reset-MgSecurityCaseEdiscoveryCaseSettingToDefault](Reset-MgSecurityCaseEdiscoveryCaseSettingToDefault.md)
Reset a caseSettings object to the default values.

### [Update-MgSecurityAlert](Update-MgSecurityAlert.md)
Update the navigation property alerts in security

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
Trigger an indexOperation to make a custodian and associated sources searchable.

### [Update-MgSecurityCaseEdiscoveryCaseCustodianSiteSource](Update-MgSecurityCaseEdiscoveryCaseCustodianSiteSource.md)
Update the navigation property siteSources in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource](Update-MgSecurityCaseEdiscoveryCaseCustodianUnifiedGroupSource.md)
Update the navigation property unifiedGroupSources in security

### [Update-MgSecurityCaseEdiscoveryCaseCustodianUserSource](Update-MgSecurityCaseEdiscoveryCaseCustodianUserSource.md)
Update the navigation property userSources in security

### [Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource](Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSource.md)
Update the navigation property noncustodialDataSources in security

### [Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex](Update-MgSecurityCaseEdiscoveryCaseNoncustodialDataSourceIndex.md)
Trigger an indexOperation to make a non-custodial data source and its associated data source searchable.

### [Update-MgSecurityCaseEdiscoveryCaseOperation](Update-MgSecurityCaseEdiscoveryCaseOperation.md)
Update the navigation property operations in security

### [Update-MgSecurityCaseEdiscoveryCaseReviewSet](Update-MgSecurityCaseEdiscoveryCaseReviewSet.md)
Update the navigation property reviewSets in security

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

### [Update-MgSecuritySecureScore](Update-MgSecuritySecureScore.md)
Update the navigation property secureScores in security

### [Update-MgSecuritySecureScoreControlProfile](Update-MgSecuritySecureScoreControlProfile.md)
Update the navigation property secureScoreControlProfiles in security

