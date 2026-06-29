### Example 1: Export a report of items with search hits only, excluding partially indexed items, without additional options

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 1"
	exportCriteria = "searchHits"
	additionalOptions = "none"
}

Export-MgSecurityCaseEdiscoveryCaseSearchReport -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export a report of items with search hits only, excluding partially indexed items, without additional options

### Example 2: Export a report of items with search hits and partially indexed items in all targeted locations, without additional options

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 2"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "none"
}

Export-MgSecurityCaseEdiscoveryCaseSearchReport -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export a report of items with search hits and partially indexed items in all targeted locations, without additional options

### Example 3: Export a report of items with search hits and partially indexed items in locations with search hits, without additional options

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 3"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "none"
}

Export-MgSecurityCaseEdiscoveryCaseSearchReport -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export a report of items with search hits and partially indexed items in locations with search hits, without additional options

### Example 4: Export a report of partially indexed items in all targeted locations with all additional options selected

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 4"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "teamsAndYammerConversations, cloudAttachments, allDocumentVersions, subfolderContents, listAttachments"
}

Export-MgSecurityCaseEdiscoveryCaseSearchReport -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export a report of partially indexed items in all targeted locations with all additional options selected

### Example 5: Export a report of partially indexed items in locations with search hits and cloud attachments

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 5"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "cloudAttachments"
}

Export-MgSecurityCaseEdiscoveryCaseSearchReport -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export a report of partially indexed items in locations with search hits and cloud attachments

