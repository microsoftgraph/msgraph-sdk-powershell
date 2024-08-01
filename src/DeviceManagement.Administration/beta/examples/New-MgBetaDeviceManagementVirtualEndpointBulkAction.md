### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcBulkAction"
	displayName = "Bulk Power Off by Andy"
	cloudPcIds = @(
	"d6e0b8ee-8836-4b8d-b038-6130a97a3a9d"
"85994912-197b-4927-b569-447bd81350ec"
)
scheduledDuringMaintenanceWindow = $true
}

New-MgBetaDeviceManagementVirtualEndpointBulkAction -BodyParameter $params

```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointBulkAction Cmdlet.

