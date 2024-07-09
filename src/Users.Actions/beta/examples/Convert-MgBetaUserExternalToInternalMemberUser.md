### Example 1: Convert a cloud user and require them to reset their password on next sign in

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	userPrincipalName = "AdeleVance@contoso.com"
	passwordProfile = @{
		password = "Zdi087#2jhkahf"
		forceChangePasswordNextSignIn = "true"
	}
}

Convert-MgBetaUserExternalToInternalMemberUser -UserId $userId -BodyParameter $params

```
This example will convert a cloud user and require them to reset their password on next sign in

### Example 2: Convert a cloud user, change their mail address, and require password reset on next sign in

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	userPrincipalName = "AdeleVance@contoso.com"
	passwordProfile = @{
		password = "Zdi087#2jhkahf"
		forceChangePasswordNextSignIn = "true"
	}
	mail = "AdeleV@contoso.com"
}

Convert-MgBetaUserExternalToInternalMemberUser -UserId $userId -BodyParameter $params

```
This example will convert a cloud user, change their mail address, and require password reset on next sign in

### Example 3: Convert external User to internal for a user synchronized from on-premises AD

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

Convert-MgBetaUserExternalToInternalMemberUser -UserId $userId

```
This example will convert external user to internal for a user synchronized from on-premises ad

