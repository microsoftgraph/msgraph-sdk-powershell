### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.openTypeExtension"
	extensionName = "Com.Contoso.Deal"
	companyName = "Alpine Skis"
	dealValue = 
	expirationDate = "2015-07-03T13:04:00.000Z"
}

New-MgBetaGroupEventExtension -GroupId $groupId -EventId $eventId -BodyParameter $params

```
This example shows how to use the New-MgBetaGroupEventExtension Cmdlet.

