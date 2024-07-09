### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	isEmailPasswordAuthenticationEnabled = $false
	isUserNameAuthenticationEnabled = $true
	isPhoneOneTimePasswordAuthenticationEnabled = $true
}

Update-MgBetaPolicyB2CAuthenticationMethodPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyB2CAuthenticationMethodPolicy Cmdlet.

