### Example 1
``` powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/alexd@contoso.com"
}
New-MgGroupAcceptedSenderByRef -GroupId $groupId -BodyParameter $params
```
