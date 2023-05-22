### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.room"
	nickname = "Conf Room"
	building = "1"
	label = "100"
	capacity = 
	isWheelChairAccessible = $false
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

