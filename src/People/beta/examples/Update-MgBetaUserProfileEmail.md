### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	displayName = "Business Email"
	type = "work"
}

Update-MgBetaUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileEmail Cmdlet.

