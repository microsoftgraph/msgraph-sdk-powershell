### Example 1: Using the New-MgGroupSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	TemplateId = "08d542b9-071f-4e16-94b0-74abb372e3d9"
	Values = @(
		@{
			Name = "AllowToAddGuests"
			Value = "false"
		}
	)
}
New-MgGroupSetting -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
