### Example 1: Using the Update-MgPolicyMobileAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
}
Update-MgPolicyMobileAppManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyMobileAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgPolicyMobileAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mobilityManagementPolicy"
	ComplianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance"
	DiscoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc"
	TermsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
}
Update-MgPolicyMobileAppManagementPolicy -MobilityManagementPolicyId $mobilityManagementPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyMobileAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
