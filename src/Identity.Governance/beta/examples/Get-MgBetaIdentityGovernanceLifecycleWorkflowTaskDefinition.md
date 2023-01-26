### Example 1: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition -TaskDefinitionId $taskDefinitionId
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition -Filter "category eq 'joiner,leaver' OR category eq 'joiner'" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
