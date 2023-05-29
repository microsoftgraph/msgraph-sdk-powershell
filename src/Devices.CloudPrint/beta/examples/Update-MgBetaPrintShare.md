### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	displayName = "PrinterShare Name"
	"printer@odata.bind" = "https://graph.microsoft.com/v1.0/print/printers/{printerId}"
	allowAllUsers = $false
}

Update-MgBetaPrintShare -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrintShare Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

