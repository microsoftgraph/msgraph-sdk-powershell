### Example 1: Using the Add-MgBetaServicePrincipalTokenSigningCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	DisplayName = "CN=customDisplayName"
	EndDateTime = [System.DateTime]::Parse("2024-01-25T00:00:00Z")
}
Add-MgBetaServicePrincipalTokenSigningCertificate -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Add-MgBetaServicePrincipalTokenSigningCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
