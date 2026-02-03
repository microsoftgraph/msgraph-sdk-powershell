### Example 1: Get all authentication strength policies

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyAuthenticationStrengthPolicy

```
This example will get all authentication strength policies

### Example 2: Get policies that include specific authentication method modes

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyAuthenticationStrengthPolicy -Filter "allowedCombinations/any(x:x has 'sms, password')" 

```
This example will get policies that include specific authentication method modes

