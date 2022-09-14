### Example 1: Using the New-MgUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "microsoft.graph.fileAttachment"
	Name = "name-value"
	ContentType = "contentType-value"
	IsInline = $false
	ContentLocation = "contentLocation-value"
	ContentBytes = "base64-contentBytes-value"
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgUserMessageAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	Name = "smile"
	ContentBytes = "R0lGODdhEAYEAA7"
}
# A UPN can also be used as -UserId.
New-MgUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgUserMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
