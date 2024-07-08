### Example 1: Assign licenses to the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	addLicenses = @(
		@{
			disabledPlans = @(
			"8a256a2b-b617-496d-b51b-e76466e88db0"
		)
		skuId = "84a661c4-e949-4bd2-a560-ed7766fcaf2b"
	}
	@{
		disabledPlans = @(
		)
		skuId = "f30db892-07e9-47e9-837c-80727f46fd3d"
	}
)
removeLicenses = @(
)
}

# A UPN can also be used as -UserId.
Set-MgBetaUserLicense -UserId $userId -BodyParameter $params

```
This example will assign licenses to the signed-in user

### Example 2: Remove licenses from the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	addLicenses = @(
	)
	removeLicenses = @(
	"f30db892-07e9-47e9-837c-80727f46fd3d"
"84a661c4-e949-4bd2-a560-ed7766fcaf2b"
)
}

# A UPN can also be used as -UserId.
Set-MgBetaUserLicense -UserId $userId -BodyParameter $params

```
This example will remove licenses from the signed-in user

