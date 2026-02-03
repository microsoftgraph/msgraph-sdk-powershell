### Example 1: Retrieve a list of all languages

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowLanguage -B2cIdentityUserFlowId $b2cIdentityUserFlowId

```
This example will retrieve a list of all languages

### Example 2: Retrieve a list of only enabled languages

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowLanguage -B2cIdentityUserFlowId $b2cIdentityUserFlowId -Filter "isEnabled eq true" 

```
This example will retrieve a list of only enabled languages

