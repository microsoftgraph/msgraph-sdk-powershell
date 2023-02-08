### Example 1: Using the New-MgPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	DisplayName = "ShareName"
	AllowAllUsers = $false
	"Printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
}
New-MgPrintShare -BodyParameter $params
```
This example shows how to use the New-MgPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
