### Example 1: Using the Update-MgBetaIdentityGovernanceTermOfUseAgreement Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "All Contoso volunteers - Terms of use"
	IsViewingBeforeAcceptanceRequired = $true
}
Update-MgBetaIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityGovernanceTermOfUseAgreement Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
