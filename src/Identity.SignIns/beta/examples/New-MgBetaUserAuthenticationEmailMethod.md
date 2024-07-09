### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	emailAddress = "kim@contoso.com"
}

New-MgBetaUserAuthenticationEmailMethod -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserAuthenticationEmailMethod Cmdlet.

