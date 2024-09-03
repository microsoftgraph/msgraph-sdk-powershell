### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.targetDeviceGroup"
	id = "b9e4eae4-b781-45a1-ce65-f2dd8ac3b696"
	displayName = "Device Group A"
}

New-MgServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the New-MgServicePrincipalRemoteDesktopSecurityConfigurationTargetDeviceGroup Cmdlet.

