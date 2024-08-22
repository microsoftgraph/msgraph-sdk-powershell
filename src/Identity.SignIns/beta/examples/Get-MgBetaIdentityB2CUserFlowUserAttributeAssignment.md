### Example 1: List userAttributeAssignments in a b2cIdentityUserFlow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId

```
This example will list userattributeassignments in a b2cidentityuserflow

### Example 2: List userAttributeAssignments in a b2cIdentityUserFlow and expand userAttribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -ExpandProperty "userAttribute" 

```
This example will list userattributeassignments in a b2cidentityuserflow and expand userattribute

