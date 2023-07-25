### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users

$params = @{
	contributionToContentDiscoveryDisabled = $true
}

# A UPN can also be used as -UserId.
Update-MgUserSetting -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

