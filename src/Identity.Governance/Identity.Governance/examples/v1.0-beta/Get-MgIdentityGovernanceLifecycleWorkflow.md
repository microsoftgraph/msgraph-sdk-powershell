### Example 1: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflow
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceLifecycleWorkflow -Filter "category eq 'leaver'" -Property "id,category,displayName,isEnabled,isSchedulingEnabled" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
