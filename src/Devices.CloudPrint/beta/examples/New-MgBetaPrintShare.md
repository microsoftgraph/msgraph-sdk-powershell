### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	name = "name-value"
	"printer@odata.bind" = "https://graph.microsoft.com/beta/print/printers/{id}"
}

New-MgBetaPrintShare -BodyParameter $params

```
This example shows how to use the New-MgBetaPrintShare Cmdlet.

