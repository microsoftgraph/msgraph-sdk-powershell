### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "PrinterShare Name"
	"Printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
	AllowAllUsers = $false
}
Update-MgPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
