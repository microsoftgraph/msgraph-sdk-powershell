###Example 1
```
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/alexd@contoso.com"
}
New-MgGroupAcceptedSenderByRef -GroupId $groupId -BodyParameter $params
```
