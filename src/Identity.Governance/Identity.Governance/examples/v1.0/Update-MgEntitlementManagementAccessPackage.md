###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Access Package New Name"
}
Update-MgEntitlementManagementAccessPackage -AccessPackageId $accessPackageId -BodyParameter $params
```
