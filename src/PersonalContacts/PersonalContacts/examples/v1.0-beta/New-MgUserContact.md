### Example 1: Using the New-MgUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	GivenName = "Pavel"
	Surname = "Bansky"
	EmailAddresses = @(
		@{
			Address = "pavelb@contoso.onmicrosoft.com"
			Name = "Pavel Bansky"
			Type = "personal"
		}
		@{
			Address = "pavelb@fabrikam.onmicrosoft.com"
			Name = "Pavel Bansky"
			Type = "other"
			OtherLabel = "Volunteer work"
		}
	)
	Phones = @(
		@{
			Number = "+1 732 555 0102"
			Type = "business"
		}
	)
}
# A UPN can also be used as -UserId.
New-MgUserContact -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
