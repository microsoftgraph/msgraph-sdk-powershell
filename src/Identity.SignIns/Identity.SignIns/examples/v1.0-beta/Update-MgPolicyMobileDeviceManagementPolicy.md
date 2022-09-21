### Example 1: Using the Update-MgPolicyMobileDeviceManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.uem.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.uem.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.uem.contoso.com/TermsofUse.aspx"
}
Update-MgPolicyMobileDeviceManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyMobileDeviceManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
