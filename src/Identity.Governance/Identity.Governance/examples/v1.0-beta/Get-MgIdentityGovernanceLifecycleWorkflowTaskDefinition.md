### Example 1: Using the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition -TaskDefinitionId $taskDefinitionId
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition -Filter "category eq 'joiner,leaver' OR category eq 'joiner'" 
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
