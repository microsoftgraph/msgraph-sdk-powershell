### Example 1: Using the Update-MgBetaUserContact Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.PersonalContacts
$params = @{
	EmailAddresses = @(
		@{
			Type = "personal"
			Name = "Pavel Bansky"
			Address = "pavelb@adatum.onmicrosoft.com"
		}
		@{
			Address = "pavelb@fabrikam.onmicrosoft.com"
			Name = "Pavel Bansky"
			Type = "other"
			OtherLabel = "Volunteer work"
		}
	)
}
# A UPN can also be used as -UserId.
Update-MgBetaUserContact -UserId $userId -ContactId $contactId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
