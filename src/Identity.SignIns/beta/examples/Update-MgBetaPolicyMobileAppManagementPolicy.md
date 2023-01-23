### Example 1: Using the Update-MgBetaPolicyMobileAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
}
Update-MgBetaPolicyMobileAppManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyMobileAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaPolicyMobileAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
}
Update-MgBetaPolicyMobileAppManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyMobileAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
