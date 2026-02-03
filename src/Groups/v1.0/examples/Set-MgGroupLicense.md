### Example 1: Add licenses to the group

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	addLicenses = @(
		@{
			disabledPlans = @(
			"113feb6c-3fe4-4440-bddc-54d774bf0318"
		"14ab5db5-e6c4-4b20-b4bc-13e36fd2227f"
	)
	skuId = "b05e124f-c7cc-45a0-a6aa-8cf78c946968"
}
@{
	disabledPlans = @(
	"a413a9ff-720c-4822-98ef-2f37c2a21f4c"
)
skuId = "c7df2760-2c81-4ef7-b578-5b5392b571df"
}
)
removeLicenses = @(
)
}

Set-MgGroupLicense -GroupId $groupId -BodyParameter $params

```
This example will add licenses to the group

### Example 2: Remove licenses from the group

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	addLicenses = @(
	)
	removeLicenses = @(
	"c7df2760-2c81-4ef7-b578-5b5392b571df"
"b05e124f-c7cc-45a0-a6aa-8cf78c946968"
)
}

Set-MgGroupLicense -GroupId $groupId -BodyParameter $params

```
This example will remove licenses from the group

