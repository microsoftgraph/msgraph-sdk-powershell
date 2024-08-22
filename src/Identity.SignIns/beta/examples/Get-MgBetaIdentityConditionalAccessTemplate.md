### Example 1: List all conditional access policy templates

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessTemplate

```
This example will list all conditional access policy templates

### Example 2: List name, description, id, scenarios of templates whose scenarios contain "secureFoundation"

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessTemplate -Property "name,description,id,scenarios" -Filter "scenarios has 'secureFoundation'" 

```
This example will list name, description, id, scenarios of templates whose scenarios contain "securefoundation"

