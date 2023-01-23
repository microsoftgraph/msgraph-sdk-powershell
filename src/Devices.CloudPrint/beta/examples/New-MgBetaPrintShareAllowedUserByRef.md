### Example 1: Using the New-MgBetaPrintShareAllowedUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.CloudPrint
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}
New-MgBetaPrintShareAllowedUserByRef -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the New-MgBetaPrintShareAllowedUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
