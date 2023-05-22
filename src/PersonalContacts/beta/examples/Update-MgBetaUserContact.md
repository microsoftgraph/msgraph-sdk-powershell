### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.PersonalContacts

$params = @{
	homeAddress = @{
		street = "123 Some street"
		city = "Seattle"
		state = "WA"
		postalCode = "98121"
	}
	birthday = [System.DateTime]::Parse("1974-07-22")
}

# A UPN can also be used as -UserId.
Update-MgBetaUserContact -UserId $userId -ContactId $contactId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaUserContact Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

