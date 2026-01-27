### Example 1: Adding a new key credential to a servicePrincipal

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	keyCredential = @{
		type = "AsymmetricX509Cert"
		usage = "Verify"
		key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	passwordCredential = $null
	proof = "eyJ0eXAiOiJ..."
}

Add-MgServicePrincipalKey -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows adding a new key credential to a serviceprincipal

### Example 2: Adding a key credential and an associated password for the key

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	keyCredential = @{
		type = "X509CertAndPassword"
		usage = "Sign"
		key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	passwordCredential = @{
		secretText = "<secret here>"
	}
	proof = "eyJ0eXAiOiJ..."
}

Add-MgServicePrincipalKey -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows adding a key credential and an associated password for the key

