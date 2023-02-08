### Example 1: Using the Add-MgServicePrincipalTokenSigningCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "CN=customDisplayName"
	EndDateTime = [System.DateTime]::Parse("2024-01-25T00:00:00Z")
}
Add-MgServicePrincipalTokenSigningCertificate -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Add-MgServicePrincipalTokenSigningCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
