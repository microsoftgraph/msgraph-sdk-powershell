### Example 1: Using the Update-MgBetaPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
$params = @{
	DisplayName = "ShareName"
	AllowAllUsers = $true
	"Printer@odata.bind" = "https://graph.microsoft.com/beta/print/printers/{id}"
}
Update-MgBetaPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
