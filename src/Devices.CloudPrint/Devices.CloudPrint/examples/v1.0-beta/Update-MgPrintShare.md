### Example 1: Using the Update-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "ShareName"
	AllowAllUsers = $true
	"Printer@odata.bind" = "https://graph.microsoft.com/beta/print/printers/{id}"
}
Update-MgPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the Update-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
