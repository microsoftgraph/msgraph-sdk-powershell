### Example 1: Using the Update-MgIdentityGovernanceTermOfUseAgreement Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "All Contoso volunteers - Terms of use"
	IsViewingBeforeAcceptanceRequired = $true
}
Update-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceTermOfUseAgreement Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
