### Example 1
```powershell
Import-Module Microsoft.Graph.PersonalContacts
$params = @{
	HomeAddress = @{
		Street = "123 Some street"
		City = "Seattle"
		State = "WA"
		PostalCode = "98121"
	}
	Birthday = [System.DateTime]::Parse("1974-07-22")
}
# A UPN can also be used as -UserId.
Update-MgUserContact -UserId $userId -ContactId $contactId -BodyParameter $params
```
