### Example 1: Using the New-MgGroupEventExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.openTypeExtension"
	ExtensionName = "Com.Contoso.Deal"
	CompanyName = "Alpine Skis"
	DealValue = 
	ExpirationDate = "2015-07-03T13:04:00.000Z"
}
New-MgGroupEventExtension -GroupId $groupId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgGroupEventExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
