### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	displayName = "CN=customDisplayName"
	endDateTime = [System.DateTime]::Parse("2024-01-25T00:00:00Z")
}

Add-MgServicePrincipalTokenSigningCertificate -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Add-MgServicePrincipalTokenSigningCertificate Cmdlet.

