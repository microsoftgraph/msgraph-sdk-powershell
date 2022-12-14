### Example 1: Using the New-MgBetaUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	DisplayName = "Innocenty Popov"
	First = "Innocenty"
	Initials = "IP"
	Last = "Popov"
	LanguageTag = "en-US"
	Maiden = $null
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileName -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
