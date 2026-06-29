### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.building"
	tags = @(
	"most popular building"
)
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlace Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.floor"
	isWheelChairAccessible = $true
	sortOrder = 
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlace Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.section"
	label = "discuss area"
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlace Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.desk"
	mode = @{
		"@odata.type" = "microsoft.graph.dropInPlaceMode"
	}
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlace Cmdlet.

### Example 5: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

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
This example shows how to use the Update-MgBetaPlace Cmdlet.

### Example 6: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.workspace"
	nickname = "Conf Room"
	building = "1"
	label = "100"
	capacity = 
	isWheelChairAccessible = $false
}

Update-MgBetaPlace -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPlace Cmdlet.

