### Example 1: Using the Update-MgUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Nickname = "Kesha"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileName -UserId $userId -PersonNameId $personNameId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
