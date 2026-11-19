### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	templateId = "08d542b9-071f-4e16-94b0-74abb372e3d9"
	values = @(
		@{
			name = "AllowToAddGuests"
			value = "false"
		}
	)
}

New-MgGroupSetting -GroupId $groupId -BodyParameter $params

```
This example shows how to use the New-MgGroupSetting Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	templateId = "7e0abea2-5c20-405f-9658-bfc9a523fd49"
	values = @(
		@{
			name = "AllowToAddGuests"
			value = "false"
		}
	)
}

New-MgGroupSetting -GroupId $groupId -BodyParameter $params

```
This example shows how to use the New-MgGroupSetting Cmdlet.

