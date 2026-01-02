### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	complianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance"
	discoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc"
	termsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
}

Update-MgBetaPolicyMobileAppManagementPolicy -MobileAppManagementPolicyId $mobileAppManagementPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyMobileAppManagementPolicy Cmdlet.

