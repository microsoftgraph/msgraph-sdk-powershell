### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.approvedClientApp"
	displayName = "Client App 1"
}

New-MgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the New-MgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp Cmdlet.

