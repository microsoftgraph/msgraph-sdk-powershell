### Example 1: Using the Invoke-MgTranslateUserExchangeId Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	InputIds = @(
		"{rest-formatted-id-1}"
		"{rest-formatted-id-2}"
	)
	SourceIdType = "restId"
	TargetIdType = "restImmutableEntryId"
}
# A UPN can also be used as -UserId.
Invoke-MgTranslateUserExchangeId -UserId $userId -BodyParameter $params
```
This example shows how to use the Invoke-MgTranslateUserExchangeId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
