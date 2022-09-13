###Example 1
```
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "PrinterShare Name"
	"Printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
	AllowAllUsers = $false
}
Update-MgPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
