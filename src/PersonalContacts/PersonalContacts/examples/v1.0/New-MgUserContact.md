### Example 1
``` powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	GivenName = "Pavel"
	Surname = "Bansky"
	EmailAddresses = @(
		@{
			Address = "pavelb@fabrikam.onmicrosoft.com"
			Name = "Pavel Bansky"
		}
	)
	BusinessPhones = @(
		"+1 732 555 0102"
	)
}
# A UPN can also be used as -UserId.
New-MgUserContact -UserId $userId -BodyParameter $params
```
