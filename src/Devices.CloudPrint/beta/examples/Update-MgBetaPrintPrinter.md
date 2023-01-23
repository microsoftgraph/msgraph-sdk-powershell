### Example 1: Using the Update-MgBetaPrintPrinter Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
$params = @{
	Name = "PrinterName"
	Location = @{
		Latitude = 1.1
		Longitude = 2.2
		AltitudeInMeters = 3
	}
}
Update-MgBetaPrintPrinter -PrinterId $printerId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
