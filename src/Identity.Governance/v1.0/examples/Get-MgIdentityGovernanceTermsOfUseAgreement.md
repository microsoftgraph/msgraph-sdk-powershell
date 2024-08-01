### Example 1: Retrieve an agreement

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceTermsOfUseAgreement -AgreementId $agreementId

```
This example will retrieve an agreement

### Example 2: Retrieve an agreement and its related files

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceTermsOfUseAgreement -AgreementId $agreementId -ExpandProperty "files" 

```
This example will retrieve an agreement and its related files

