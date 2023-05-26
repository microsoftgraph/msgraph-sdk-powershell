### Example 1: Add a member to a group

```powershellImport-Module Microsoft.Graph.Groups

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}

New-MgGroupMemberByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add multiple members to a group in a single request

```powershellImport-Module Microsoft.Graph.Groups

$params = @{
	"members@odata.bind" = @(
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
	)
}

Update-MgGroup -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

