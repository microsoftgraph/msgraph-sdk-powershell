### Example 1: Add a member to a group

```powershell
Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}

New-MgBetaGroupMemberByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupMemberByRef Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

