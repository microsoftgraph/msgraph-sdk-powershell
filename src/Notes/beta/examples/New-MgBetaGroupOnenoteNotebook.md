### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Notes

$params = @{
	displayName = "My Private notebook"
}

# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebook -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaGroupOnenoteNotebook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

