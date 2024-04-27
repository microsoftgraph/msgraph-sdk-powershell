### Example 1: Get the details of an identityUserFlowAttributeAssignment

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId

```
This example will get the details of an identityuserflowattributeassignment

### Example 2: Get the details of an identityUserFlowAttributeAssignment and expand userAttribute

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2CUserFlowUserAttributeAssignment -B2cIdentityUserFlowId $b2cIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute" 

```
This example will get the details of an identityuserflowattributeassignment and expand userattribute

