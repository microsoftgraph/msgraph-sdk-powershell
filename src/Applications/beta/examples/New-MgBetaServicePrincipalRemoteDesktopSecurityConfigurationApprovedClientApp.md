### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.approvedClientApp"
	id = "cd57c330-a543-4249-9486-c1c257341de6"
}

New-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the New-MgBetaServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp Cmdlet.

