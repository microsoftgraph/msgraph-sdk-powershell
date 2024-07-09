### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	use = "sig"
	kty = "RSA"
	nbf = 1508969811
	exp = 1508969811
}

New-MgBetaTrustFrameworkKeySetKey -TrustFrameworkKeySetId $trustFrameworkKeySetId -BodyParameter $params

```
This example shows how to use the New-MgBetaTrustFrameworkKeySetKey Cmdlet.

