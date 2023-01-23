### Example 1: Using the Update-MgPrintPrinter Cmdlet
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
This example shows how to use the Update-MgPrintPrinter Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
