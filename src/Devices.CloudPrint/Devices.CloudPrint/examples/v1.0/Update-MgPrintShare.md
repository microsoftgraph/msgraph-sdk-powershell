### Example 1: Using the Update-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "PrinterShare Name"
	"Printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
	AllowAllUsers = $false
}
Update-MgPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the Update-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
