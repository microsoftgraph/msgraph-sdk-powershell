### Example 1: Using the New-MgPrintShareAllowedUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/{id}"
}
New-MgPrintShareAllowedUserByRef -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the New-MgPrintShareAllowedUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
