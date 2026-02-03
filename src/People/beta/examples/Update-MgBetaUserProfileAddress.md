### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	allowedAudiences = "me"
	displayName = "Secret Hideout"
}

Update-MgBetaUserProfileAddress -UserId $userId -ItemAddressId $itemAddressId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileAddress Cmdlet.

