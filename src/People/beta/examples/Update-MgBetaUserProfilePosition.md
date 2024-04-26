### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	isCurrent = $true
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfilePosition -UserId $userId -WorkPositionId $workPositionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfilePosition Cmdlet.

