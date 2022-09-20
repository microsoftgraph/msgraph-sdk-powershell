### Example 1: Using the New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/odata/groups('dc3d2ce5-7c5e-4dca-a0ef-2145bf6e53ef')"
}
New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/odata/groups('dc3d2ce5-7c5e-4dca-a0ef-2145bf6e53ef')"
}
New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the New-MgPolicyMobileDeviceManagementPolicyIncludedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
