### Example 1
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
New-MgGroupMemberByRef -GroupId $groupId -BodyParameter $params
```
