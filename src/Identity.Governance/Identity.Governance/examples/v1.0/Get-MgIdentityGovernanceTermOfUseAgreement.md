### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -ExpandProperty "files" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -ExpandProperty "files" 
```
