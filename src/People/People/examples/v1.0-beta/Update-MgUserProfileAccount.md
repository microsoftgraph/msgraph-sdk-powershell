### Example 1: Using the Update-MgBetaUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	CountryCode = "NO"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
