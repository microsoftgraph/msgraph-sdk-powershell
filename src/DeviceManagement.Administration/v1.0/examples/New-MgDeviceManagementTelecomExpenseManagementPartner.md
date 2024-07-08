### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.telecomExpenseManagementPartner"
	displayName = "Display Name value"
	url = "Url value"
	appAuthorized = $true
	enabled = $true
	lastConnectionDateTime = [System.DateTime]::Parse("2016-12-31T23:58:36.6670033-08:00")
}

New-MgDeviceManagementTelecomExpenseManagementPartner -BodyParameter $params
```
This example shows how to use the New-MgDeviceManagementTelecomExpenseManagementPartner Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

