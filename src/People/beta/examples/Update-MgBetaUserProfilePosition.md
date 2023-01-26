### Example 1: Using the Update-MgBetaUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	IsCurrent = $true
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfilePosition -UserId $userId -WorkPositionId $workPositionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
