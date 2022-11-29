### Example 1: Using the Add-MgServicePrincipalKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	KeyCredential = @{
		Type = "AsymmetricX509Cert"
		Usage = "Verify"
		Key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	PasswordCredential = $null
	Proof = "eyJ0eXAiOiJ..."
}
Add-MgServicePrincipalKey -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Add-MgServicePrincipalKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Add-MgServicePrincipalKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	KeyCredential = @{
		Type = "X509CertAndPassword"
		Usage = "Sign"
		Key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	PasswordCredential = @{
		SecretText = "MKTr0w1..."
	}
	Proof = "eyJ0eXAiOiJ..."
}
Add-MgServicePrincipalKey -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the Add-MgServicePrincipalKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
