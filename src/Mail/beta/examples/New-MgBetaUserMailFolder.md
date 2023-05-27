### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

$params = @{
	displayName = "Clutter"
	isHidden = $true
}

# A UPN can also be used as -UserId.
New-MgBetaUserMailFolder -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

