### Example 1: Get details of an identity account

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityIdentityAccount -IdentityAccountsId $identityAccountsId

```
This example will get details of an identity account

### Example 2: Get the account details of an identity account

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityIdentityAccount -IdentityAccountsId $identityAccountsId -Property "accounts" 

```
This example will get the account details of an identity account

