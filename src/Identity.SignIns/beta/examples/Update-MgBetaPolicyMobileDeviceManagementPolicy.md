### Example 1: Using the Update-MgBetaPolicyMobileDeviceManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.uem.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.uem.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.uem.contoso.com/TermsofUse.aspx"
}
Update-MgBetaPolicyMobileDeviceManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyMobileDeviceManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
