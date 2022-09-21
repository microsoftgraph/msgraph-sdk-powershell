### Example 1: Using the Update-MgUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	IsCurrent = $true
}
# A UPN can also be used as -UserId.
Update-MgUserProfilePosition -UserId $userId -WorkPositionId $workPositionId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
