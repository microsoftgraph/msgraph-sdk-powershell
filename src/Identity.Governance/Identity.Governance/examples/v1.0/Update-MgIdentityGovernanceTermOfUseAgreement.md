### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "All Contoso volunteers - Terms of use"
	IsViewingBeforeAcceptanceRequired = $true
}
Update-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -BodyParameter $params
```
