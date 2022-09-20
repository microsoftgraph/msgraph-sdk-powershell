### Example 1: Using the New-MgUserAuthenticationTemporaryAccessPassMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	StartDateTime = [System.DateTime]::Parse("2022-06-05T00:00:00.000Z")
	LifetimeInMinutes = 60
	IsUsableOnce = $false
}
New-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserAuthenticationTemporaryAccessPassMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
