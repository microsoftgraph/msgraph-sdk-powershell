### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Notes

$params = @{
	id = "id-value"
	groupId = "groupId-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenotePageToSection -UserId $userId -OnenotePageId $onenotePageId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaUserOnenotePageToSection Cmdlet.

