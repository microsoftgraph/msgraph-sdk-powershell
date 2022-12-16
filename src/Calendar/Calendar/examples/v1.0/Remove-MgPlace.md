### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.room"
	Nickname = "Conf Room"
	Building = "1"
	Label = "100"
	Capacity = 
	IsWheelChairAccessible = $false
}

Update-MgPlace -PlaceId $placeId -BodyParameter $params
```
This example shows how to use the Remove-MgPlace Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

