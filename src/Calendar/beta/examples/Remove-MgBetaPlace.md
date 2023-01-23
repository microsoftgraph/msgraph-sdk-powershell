### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.room"
	Nickname = "Conf Room"
	Building = "1"
	Label = "100"
	Capacity = 
	IsWheelChairAccessible = $false
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaPlace Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

