### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	"@odata.type" = "microsoft.graph.fileAttachment"
	name = "name-value"
	contentType = "contentType-value"
	isInline = $false
	contentLocation = "contentLocation-value"
	contentBytes = "base64-contentBytes-value"
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserMailFolderMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "#Microsoft.OutlookServices.ItemAttachment"
	name = "name-value"
	item = @{
		"@odata.type" = "microsoft.graph.message"
	}
}

# A UPN can also be used as -UserId.
New-MgBetaUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserMailFolderMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

