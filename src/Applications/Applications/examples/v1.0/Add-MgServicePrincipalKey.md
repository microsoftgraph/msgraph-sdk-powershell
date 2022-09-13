###Example 1
```
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
###Example 2
```
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
