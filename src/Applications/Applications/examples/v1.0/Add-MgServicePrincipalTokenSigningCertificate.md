### Example 1
``` powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "CN=customDisplayName"
	EndDateTime = [System.DateTime]::Parse("2024-01-25T00:00:00Z")
}
Add-MgServicePrincipalTokenSigningCertificate -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
