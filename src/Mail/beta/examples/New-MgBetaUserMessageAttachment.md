### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Mail

$params = @{
	"@odata.type" = "#Microsoft.OutlookServices.FileAttachment"
	name = "name-value"
	contentType = "contentType-value"
	isInline = $false
	contentLocation = "contentLocation-value"
	contentBytes = "contentBytes-value"
}

# A UPN can also be used as -UserId.
New-MgBetaUserMessageAttachment -UserId $userId -MessageId $messageId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMessageAttachment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

