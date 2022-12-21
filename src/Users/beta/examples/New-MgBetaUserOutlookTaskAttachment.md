### Example 1: Using the New-MgBetaUserOutlookTaskAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	"@odata.type" = "#microsoft.graph.fileAttachment"
	Name = "menu.txt"
	ContentBytes = "bWFjIGFuZCBjaGVlc2UgdG9kYXk="
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskAttachment -UserId $userId -OutlookTaskId $outlookTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaUserOutlookTaskAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	"@odata.type" = "#microsoft.graph.itemAttachment"
	Name = "Holiday event"
	Item = @{
		"@odata.type" = "microsoft.graph.event"
		Subject = "Discuss gifts for children"
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserOutlookTaskAttachment -UserId $userId -OutlookTaskId $outlookTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOutlookTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
