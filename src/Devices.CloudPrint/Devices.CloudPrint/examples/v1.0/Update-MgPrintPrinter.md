### Example 1
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	Name = "PrinterName"
	Location = @{
		Latitude = 1.1
		Longitude = 2.2
		AltitudeInMeters = 3
	}
}
Update-MgPrintPrinter -PrinterId $printerId -BodyParameter $params
```
