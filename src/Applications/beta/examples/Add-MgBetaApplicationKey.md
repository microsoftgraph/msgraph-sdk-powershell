### Example 1: Add a new key credential to an application

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	keyCredential = @{
		type = "AsymmetricX509Cert"
		usage = "Verify"
		key = [System.Text.Encoding]::ASCII.GetBytes("MIIDYDCCAki...")
	}
	passwordCredential = $null
	proof = "eyJ0eXAiOiJ..."
}

Add-MgBetaApplicationKey -ApplicationId $applicationId -BodyParameter $params

```
This example will add a new key credential to an application

### Example 2: Add a key credential and an associated password for the key

```powershell

Import-Module Microsoft.Graph.Beta.Applications

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

Add-MgBetaApplicationKey -ApplicationId $applicationId -BodyParameter $params

```
This example will add a key credential and an associated password for the key

