### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	id = "id-value"
	groupId = "groupId-value"
}

# A UPN can also be used as -UserId.
Copy-MgUserOnenotePageToSection -UserId $userId -OnenotePageId $onenotePageId -BodyParameter $params

```
This example shows how to use the Copy-MgUserOnenotePageToSection Cmdlet.

