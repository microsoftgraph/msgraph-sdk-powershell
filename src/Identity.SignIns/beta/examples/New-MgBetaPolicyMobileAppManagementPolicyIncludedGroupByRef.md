### Example 1: Using the New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/odata/groups('1a9db3ab-0acf-4808-99ae-e8ed581cb2e0')"
}
New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
