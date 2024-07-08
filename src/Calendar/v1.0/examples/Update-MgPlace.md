### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.room"
	nickname = "Conf Room"
	building = "1"
	label = "100"
	capacity = 
	isWheelChairAccessible = $false
}

Update-MgPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgPlace Cmdlet.

