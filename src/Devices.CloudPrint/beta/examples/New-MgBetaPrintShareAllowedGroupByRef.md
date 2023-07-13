### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/groups/{id}"
}

New-MgBetaPrintShareAllowedGroupByRef -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the New-MgBetaPrintShareAllowedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

