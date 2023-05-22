### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	startDateTime = [System.DateTime]::Parse("2022-06-05T00:00:00.000Z")
	lifetimeInMinutes = 60
	isUsableOnce = $false
}

New-MgBetaUserAuthenticationTemporaryAccessPassMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserAuthenticationTemporaryAccessPassMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

