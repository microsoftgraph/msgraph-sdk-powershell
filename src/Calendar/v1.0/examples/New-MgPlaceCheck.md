### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Calendar

$params = @{
	"@odata.type" = "#microsoft.graph.checkInClaim"
	calendarEventId = "040000008200E00074C5B7101A82E00800000000D02AC02D26EFDB010000000000000000100000005A18ADA04F0A24489AE13ED3CC367978"
	checkInMethod = "verified"
}

New-MgPlaceCheck -PlaceId $placeId -BodyParameter $params

```
This example shows how to use the New-MgPlaceCheck Cmdlet.

