### Example 1: List userAttributeAssignments in a b2xIdentityUserFlow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId

```
This example will list userattributeassignments in a b2xidentityuserflow

### Example 2: List userAttributeAssignments in a b2xIdentityUserFlow and expand userAttribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "userAttribute" 

```
This example will list userattributeassignments in a b2xidentityuserflow and expand userattribute

