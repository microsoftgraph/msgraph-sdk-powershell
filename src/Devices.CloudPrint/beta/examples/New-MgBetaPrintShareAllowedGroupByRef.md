### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Devices.CloudPrint

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/groups/{groupId}"
}

New-MgBetaPrintShareAllowedGroupByRef -PrinterShareId $printerShareId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaPrintShareAllowedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

