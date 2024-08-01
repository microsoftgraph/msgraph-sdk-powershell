### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.remoteDesktopSecurityConfiguration"
	isRemoteDesktopProtocolEnabled = $true
}

Update-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Update-MgBetaServicePrincipalRemoteDesktopSecurityConfiguration Cmdlet.

