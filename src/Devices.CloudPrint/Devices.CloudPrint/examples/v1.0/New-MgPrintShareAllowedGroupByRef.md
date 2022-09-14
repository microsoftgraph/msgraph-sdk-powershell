### Example 1
```powershell
Import-Module Microsoft.Graph.Devices.CloudPrint
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/groups/{groupId}"
}
New-MgPrintShareAllowedGroupByRef -PrinterShareId $printerShareId -BodyParameter $params
```
