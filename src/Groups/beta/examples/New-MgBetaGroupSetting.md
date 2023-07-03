### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	templateId = "08d542b9-071f-4e16-94b0-74abb372e3d9"
	values = @(
		@{
			name = "AllowToAddGuests"
			value = "false"
		}
	)
}

New-MgBetaGroupSetting -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

