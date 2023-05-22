### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.PersonalContacts

$params = @{
	givenName = "Pavel"
	surname = "Bansky"
	emailAddresses = @(
		@{
			address = "pavelb@fabrikam.onmicrosoft.com"
			name = "Pavel Bansky"
		}
	)
	businessPhones = @(
		"+1 732 555 0102"
	)
}

# A UPN can also be used as -UserId.
New-MgBetaUserContact -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

