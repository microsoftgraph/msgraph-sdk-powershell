### Example 1: Using the New-MgTrustFrameworkKeySet Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "keyset1"
	Keys = @(
		@{
			K = "k-value"
			X5c = @(
				"x5c-value"
			)
			X5t = "x5t-value"
			Kty = "kty-value"
			Use = "use-value"
			Exp = 99
			Nbf = 99
			Kid = "kid-value"
			E = "e-value"
			N = "n-value"
			D = "d-value"
			P = "p-value"
			Q = "q-value"
			Dp = "dp-value"
			Dq = "dq-value"
			Qi = "qi-value"
		}
	)
}
New-MgTrustFrameworkKeySet -BodyParameter $params
```
This example shows how to use the New-MgTrustFrameworkKeySet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgTrustFrameworkKeySet Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "keyset1"
}
New-MgTrustFrameworkKeySet -BodyParameter $params
```
This example shows how to use the New-MgTrustFrameworkKeySet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
