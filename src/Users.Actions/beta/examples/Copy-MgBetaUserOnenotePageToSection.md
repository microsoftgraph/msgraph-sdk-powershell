### Example 1: Using the Copy-MgBetaUserOnenotePageToSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Id = "id-value"
	GroupId = "groupId-value"
}
# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenotePageToSection -UserId $userId -OnenotePageId $onenotePageId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaUserOnenotePageToSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
