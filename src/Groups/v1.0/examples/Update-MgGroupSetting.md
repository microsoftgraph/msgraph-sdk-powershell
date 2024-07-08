### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	values = @(
		@{
			name = "AllowToAddGuests"
			value = "true"
		}
	)
}

Update-MgGroupSetting -GroupId $groupId -GroupSettingId $groupSettingId -BodyParameter $params

```
This example shows how to use the Update-MgGroupSetting Cmdlet.

