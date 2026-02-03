### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	type = "other"
}

Update-MgBetaUserProfilePhone -UserId $userId -ItemPhoneId $itemPhoneId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfilePhone Cmdlet.

