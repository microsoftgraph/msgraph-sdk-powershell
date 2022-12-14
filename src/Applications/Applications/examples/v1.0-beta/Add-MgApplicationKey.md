### Example 1: Using the Add-MgBetaApplicationKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	KeyCredential = @{
		Type = "AsymmetricX509Cert"
		Usage = "Verify"
		Key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	PasswordCredential = $null
	Proof = "eyJ0eXAiOiJ..."
}
Add-MgBetaApplicationKey -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Add-MgBetaApplicationKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Add-MgBetaApplicationKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
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
Add-MgBetaApplicationKey -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Add-MgBetaApplicationKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
