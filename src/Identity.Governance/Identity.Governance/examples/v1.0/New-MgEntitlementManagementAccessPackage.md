###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "sales reps"
	Description = "outside sales representatives"
	IsHidden = $false
	Catalog = @{
		Id = "66584aae-98bb-48cc-9458-7bee5d2a6577"
	}
}
New-MgEntitlementManagementAccessPackage -BodyParameter $params
```
