###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -ExpandProperty "files" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceTermOfUseAgreement -AgreementId $agreementId -ExpandProperty "files" 
```
