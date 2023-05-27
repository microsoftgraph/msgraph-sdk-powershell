### Example 1: Add a member to a group

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}

New-MgBetaGroupMemberByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Add multiple members to a group in a single request

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	"members@odata.bind" = @(
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
		"https://graph.microsoft.com/v1.0/directoryObjects/{id}"
	)
}

Update-MgBetaGroup -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaGroupMemberByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

