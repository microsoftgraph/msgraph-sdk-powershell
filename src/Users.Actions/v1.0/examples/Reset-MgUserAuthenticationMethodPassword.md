### Example 1: User-submitted password

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	newPassword = "Cuyo5459"
}

$authenticationMethodId = "28c10230-6103-485e-b985-444c60001490"

Reset-MgUserAuthenticationMethodPassword -UserId $userId -AuthenticationMethodId $authenticationMethodId -BodyParameter $params

```
This example will set the submitted password.

### Example 2: System-generated password

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
}

$authenticationMethodId = "28c10230-6103-485e-b985-444c60001490"

Reset-MgUserAuthenticationMethodPassword -UserId $userId -AuthenticationMethodId $authenticationMethodId -BodyParameter $params

```
This example will generate a password for a cloud only user.
