### Example 1: Using the New-MgUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	DisplayName = "Innocenty Popov"
	First = "Innocenty"
	Initials = "IP"
	Last = "Popov"
	LanguageTag = "en-US"
	Maiden = $null
}
# A UPN can also be used as -UserId.
New-MgUserProfileName -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
