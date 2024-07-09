### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.onPremisesConditionalAccessSettings"
	enabled = $true
	includedGroups = @(
	"77c9d466-d466-77c9-66d4-c97766d4c977"
)
excludedGroups = @(
"2a0afae4-fae4-2a0a-e4fa-0a2ae4fa0a2a"
)
overrideDefaultRule = $true
}

Update-MgDeviceManagementConditionalAccessSetting -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementConditionalAccessSetting Cmdlet.

