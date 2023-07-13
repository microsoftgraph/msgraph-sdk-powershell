### Example 1: Using the Set-MgBetaGroupLicense Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	AddLicenses = @(
		@{
			DisabledPlans = @(
				"113feb6c-3fe4-4440-bddc-54d774bf0318"
				"14ab5db5-e6c4-4b20-b4bc-13e36fd2227f"
			)
			SkuId = "b05e124f-c7cc-45a0-a6aa-8cf78c946968"
		}
		@{
			DisabledPlans = @(
				"a413a9ff-720c-4822-98ef-2f37c2a21f4c"
			)
			SkuId = "c7df2760-2c81-4ef7-b578-5b5392b571df"
		}
	)
	RemoveLicenses = @(
	)
}
Set-MgBetaGroupLicense -GroupId $groupId -BodyParameter $params
```
This example shows how to use the Set-MgBetaGroupLicense Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Set-MgBetaGroupLicense Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	AddLicenses = @(
	)
	RemoveLicenses = @(
		"c7df2760-2c81-4ef7-b578-5b5392b571df"
		"b05e124f-c7cc-45a0-a6aa-8cf78c946968"
	)
}
Set-MgBetaGroupLicense -GroupId $groupId -BodyParameter $params
```
This example shows how to use the Set-MgBetaGroupLicense Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
