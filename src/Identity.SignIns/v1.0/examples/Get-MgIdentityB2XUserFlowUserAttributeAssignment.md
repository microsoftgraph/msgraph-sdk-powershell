### Example 1: Get the details of an identityUserFlowAttributeAssignment

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId

```
This example will get the details of an identityuserflowattributeassignment

### Example 2: Get the details of an identityUserFlowAttributeAssignment and expand userAttribute

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlowUserAttributeAssignment -B2xIdentityUserFlowId $b2xIdentityUserFlowId -IdentityUserFlowAttributeAssignmentId $identityUserFlowAttributeAssignmentId -ExpandProperty "userAttribute" 

```
This example will get the details of an identityuserflowattributeassignment and expand userattribute

