### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	Id = "id-value"
	GroupId = "groupId-value"
}

# A UPN can also be used as -UserId.
Copy-MgUserOnenotePageToSection -UserId $userId -OnenotePageId $onenotePageId -BodyParameter $params
```
This example shows how to use the Copy-MgGroupOnenotePageToSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

