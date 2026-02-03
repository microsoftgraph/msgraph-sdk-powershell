### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.targetDeviceGroup"
	displayName = "Device Group A"
}

Update-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup -ServicePrincipalId $servicePrincipalId -TargetDeviceGroupId $targetDeviceGroupId -BodyParameter $params

```
This example shows how to use the Update-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup Cmdlet.

