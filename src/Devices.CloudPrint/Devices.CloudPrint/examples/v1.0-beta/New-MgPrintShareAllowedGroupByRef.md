### Example 1: Using the New-MgPrintShareAllowedGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/groups/{id}"
}
New-MgPrintShareAllowedGroupByRef -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the New-MgPrintShareAllowedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
