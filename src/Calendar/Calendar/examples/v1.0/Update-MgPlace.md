### Example 1
```powershell
Import-Module Microsoft.Graph.Calendar
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
### Example 2
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	"@odata.type" = "microsoft.graph.roomList"
	DisplayName = "Building 1"
	Phone = "555-555-0100"
	Address = @{
		Street = "4567 Main Street"
		City = "Buffalo"
		State = "NY"
		PostalCode = "98052"
		CountryOrRegion = "USA"
	}
	GeoCoordinates = @{
		Altitude = $null
		Latitude = 47
		Longitude = -122
		Accuracy = $null
		AltitudeAccuracy = $null
	}
}
Update-MgPlace -PlaceId $placeId -BodyParameter $params
```
