### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Calendar

$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	name = "menu.txt"
	contentBytes = "base64bWFjIGFuZCBjaGVlc2UgdG9kYXk="
}

# A UPN can also be used as -UserId.
New-MgUserEventAttachment -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

