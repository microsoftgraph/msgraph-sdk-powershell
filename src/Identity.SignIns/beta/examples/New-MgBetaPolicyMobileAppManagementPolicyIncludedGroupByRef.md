### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/odata/groups('1a9db3ab-0acf-4808-99ae-e8ed581cb2e0')"
}

New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef -MobileAppManagementPolicyId $mobileAppManagementPolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyMobileAppManagementPolicyIncludedGroupByRef Cmdlet.

