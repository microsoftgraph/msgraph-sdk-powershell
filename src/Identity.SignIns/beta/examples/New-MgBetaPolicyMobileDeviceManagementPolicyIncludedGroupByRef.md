### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/odata/groups('dc3d2ce5-7c5e-4dca-a0ef-2145bf6e53ef')"
}

New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef -MobileDeviceManagementPolicyId $mobileDeviceManagementPolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyMobileDeviceManagementPolicyIncludedGroupByRef Cmdlet.

