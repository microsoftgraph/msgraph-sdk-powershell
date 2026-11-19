### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	"@odata.type" = "#microsoft.graph.approvedClientApp"
	displayName = "Client App 1"
}

Update-MgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp -ServicePrincipalId $servicePrincipalId -ApprovedClientAppId $approvedClientAppId -BodyParameter $params

```
This example shows how to use the Update-MgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp Cmdlet.

