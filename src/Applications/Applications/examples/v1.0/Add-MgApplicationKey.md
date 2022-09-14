### Example 1: Using the Add-MgApplicationKey Cmdlet
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
Add-MgApplicationKey -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Add-MgApplicationKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Add-MgApplicationKey Cmdlet
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
Add-MgApplicationKey -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Add-MgApplicationKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
