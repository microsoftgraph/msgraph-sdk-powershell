### Example 1: Using the New-MgBetaPrintShare Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
$params = @{
	Name = "name-value"
	"Printer@odata.bind" = "https://graph.microsoft.com/beta/print/printers/{id}"
}
New-MgBetaPrintShare -BodyParameter $params
```
This example shows how to use the New-MgBetaPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
