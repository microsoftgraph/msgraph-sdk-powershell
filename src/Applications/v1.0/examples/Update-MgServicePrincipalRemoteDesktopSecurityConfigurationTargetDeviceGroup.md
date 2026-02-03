### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.targetDeviceGroup"
	displayName = "Device Group A"
}

Update-MgServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup -ServicePrincipalId $servicePrincipalId -TargetDeviceGroupId $targetDeviceGroupId -BodyParameter $params

```
This example shows how to use the Update-MgServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup Cmdlet.

