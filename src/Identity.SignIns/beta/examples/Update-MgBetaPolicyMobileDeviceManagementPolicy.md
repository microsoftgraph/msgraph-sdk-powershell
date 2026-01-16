### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	complianceUrl = "https://portal.uem.contoso.com/?portalAction=Compliance"
	discoveryUrl = "https://enrollment.uem.contoso.com/enrollmentserver/discovery.svc"
	termsOfUseUrl = "https://portal.uem.contoso.com/TermsofUse.aspx"
}

Update-MgBetaPolicyMobileDeviceManagementPolicy -MobileDeviceManagementPolicyId $mobileDeviceManagementPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyMobileDeviceManagementPolicy Cmdlet.

