### Example 1: Using the New-MgGroupMemberByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
New-MgGroupMemberByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
