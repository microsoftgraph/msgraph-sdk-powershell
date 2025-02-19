### Example 1: Export results with search hits only, excluding partially indexed items, with no additional options, as .pst files for each mailbox

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Export 1 - simple PST"
	exportCriteria = "searchHits"
	additionalOptions = "none"
	exportFormat = "pst"
}

Export-MgBetaSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits only, excluding partially indexed items, with no additional options, as .pst files for each mailbox

### Example 2: Export results with search hits and partially indexed items in all locations, with no additional options, as .pst files for each mailbox.

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Export 2"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "none"
	exportFormat = "pst"
}

Export-MgBetaSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits and partially indexed items in all locations, with no additional options, as .pst files for each mailbox.

### Example 3: Export results with search hits and partially indexed items in locations with search hits, with no additional options, as .msg files for each message

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Export 3"
	exportCriteria = "searchHits, partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "none"
	exportFormat = "msg"
}

Export-MgBetaSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with search hits and partially indexed items in locations with search hits, with no additional options, as .msg files for each message

### Example 4: Export results with partially indexed items in all targeted locations, with all additional options, as .eml files for each message

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Export 4"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations, nonresponsiveLocations"
	additionalOptions = "teamsAndYammerConversations, cloudAttachments, allDocumentVersions, subfolderContents, listAttachments"
	exportFormat = "eml"
}

Export-MgBetaSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with partially indexed items in all targeted locations, with all additional options, as .eml files for each message

### Example 5: Export results with partially indexed items in search hit locations, with cloud attachments, as .eml files for each message

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Export 5"
	exportCriteria = "partiallyIndexed"
	exportLocation = "responsiveLocations"
	additionalOptions = "cloudAttachments"
	exportFormat = "eml"
}

Export-MgBetaSecurityCaseEdiscoveryCaseSearchResult -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example will export results with partially indexed items in search hit locations, with cloud attachments, as .eml files for each message

