### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "All Contoso volunteers - Terms of use"
	isViewingBeforeAcceptanceRequired = $true
}

Update-MgBetaIdentityGovernanceTermsOfUseAgreement -AgreementId $agreementId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityGovernanceTermsOfUseAgreement Cmdlet.

