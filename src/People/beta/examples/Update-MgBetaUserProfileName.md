### Example 1: Using the Update-MgBetaUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Nickname = "Kesha"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileName -UserId $userId -PersonNameId $personNameId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
