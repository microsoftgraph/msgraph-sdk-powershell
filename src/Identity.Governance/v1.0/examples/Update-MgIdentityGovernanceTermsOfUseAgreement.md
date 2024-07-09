### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "All Contoso volunteers - Terms of use"
	isViewingBeforeAcceptanceRequired = $true
}

Update-MgIdentityGovernanceTermsOfUseAgreement -AgreementId $agreementId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityGovernanceTermsOfUseAgreement Cmdlet.

