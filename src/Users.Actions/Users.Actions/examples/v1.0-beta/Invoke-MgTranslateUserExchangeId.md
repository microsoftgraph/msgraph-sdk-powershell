### Example 1: Using the Invoke-MgBetaTranslateUserExchangeId Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	InputIds = @(
		"{rest-formatted-id-1}"
		"{rest-formatted-id-2}"
	)
	SourceIdType = "restId"
	TargetIdType = "restImmutableEntryId"
}
# A UPN can also be used as -UserId.
Invoke-MgBetaTranslateUserExchangeId -UserId $userId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaTranslateUserExchangeId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
