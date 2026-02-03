### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Users

$params = @{
	displayName = "Project expenses"
	color = "preset9"
}

# A UPN can also be used as -UserId.
New-MgUserOutlookMasterCategory -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookMasterCategory Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

