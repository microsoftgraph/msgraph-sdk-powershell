### Example 1: Using the Update-MgUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	CountryCode = "NO"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
