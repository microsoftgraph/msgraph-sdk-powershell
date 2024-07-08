### Example 1: Create a setting to block guests for a specific Microsoft 365 group

```powershell

Import-Module Microsoft.Graph.Beta.Groups

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
This example will create a setting to block guests for a specific microsoft 365 group

