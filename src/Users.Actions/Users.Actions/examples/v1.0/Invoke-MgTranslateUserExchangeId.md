###Example 1
```
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
