### Example 1: Using the New-MgBetaGroupEventExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.openTypeExtension"
	ExtensionName = "Com.Contoso.Deal"
	CompanyName = "Alpine Skis"
	DealValue = 
	ExpirationDate = "2015-07-03T13:04:00.000Z"
}
New-MgBetaGroupEventExtension -GroupId $groupId -EventId $eventId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupEventExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
