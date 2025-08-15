### Example 1: Export results with search hits only, excluding partially indexed items, as .pst files for each mailbox, and thread contextual chat messages into HTML transcripts

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 1 - simple PST"
	exportCriteria = "searchHits"
	additionalOptions = "htmlTranscripts, splitSource, includeFolderAndPath, condensePaths, friendlyName"
	exportFormat = "pst"
}

Export-MgSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits only, excluding partially indexed items, as .pst files for each mailbox, and thread contextual chat messages into html transcripts

### Example 2: Export results with search hits and partially indexed items from all locations, as .pst files for each mailbox

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 2"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "splitSource"
	exportFormat = "pst"
}

Export-MgSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits and partially indexed items from all locations, as .pst files for each mailbox

### Example 3: Export results with search hits and partially indexed items from locations with search hits, with no additional options, as .msg files for each message

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 3"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "none"
	exportFormat = "msg"
}

Export-MgSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits and partially indexed items from locations with search hits, with no additional options, as .msg files for each message

### Example 4: Export results with partially indexed items from all targeted locations, with all additional options, as .eml files for each message

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 4"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "advancedIndexing, subfolderContents, allItemsInFolder, listAttachments, teamsAndYammerConversations, htmlTranscripts, cloudAttachments, includeFolderAndPath, splitSource, condensePaths, friendlyName, includeReport"
	exportFormat = "eml"
}

Export-MgSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with partially indexed items from all targeted locations, with all additional options, as .eml files for each message

### Example 5: Export results with partially indexed items from search hit locations and cloud attachments

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Export 5"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "splitSource, includeFolderAndPath, condensePaths, friendlyName"
	exportFormat = "eml"
	cloudAttachmentVersion = "all"
	documentVersion = "recent100"
}

Export-MgSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with partially indexed items from search hit locations and cloud attachments

