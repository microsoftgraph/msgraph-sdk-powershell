### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts

$params = @{
	givenName = "Pavel"
	surname = "Bansky"
	emailAddresses = @(
		@{
			address = "pavelb@contoso.onmicrosoft.com"
			name = "Pavel Bansky"
			type = "personal"
		}
		@{
			address = "pavelb@fabrikam.onmicrosoft.com"
			name = "Pavel Bansky"
			type = "other"
			otherLabel = "Volunteer work"
		}
	)
	phones = @(
		@{
			number = "+1 732 555 0102"
			type = "business"
		}
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserContact -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserContact Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

