### Example 1: User-submitted password

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	newPassword = "Cuyo5459"
}

Reset-MgBetaUserAuthenticationMethodPassword -UserId $userId -AuthenticationMethodId $authenticationMethodId -BodyParameter $params

```
This example will user-submitted password

### Example 2: System-generated password

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
}

Reset-MgBetaUserAuthenticationMethodPassword -UserId $userId -AuthenticationMethodId $authenticationMethodId -BodyParameter $params

```
This example will system-generated password

