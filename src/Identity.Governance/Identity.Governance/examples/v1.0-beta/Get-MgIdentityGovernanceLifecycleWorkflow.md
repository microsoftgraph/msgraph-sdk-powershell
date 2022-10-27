### Example 1: Using the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflow -WorkflowId $workflowId
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflow
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceLifecycleWorkflow -Filter "category eq 'leaver'" -Property "id,category,displayName,isEnabled,isSchedulingEnabled" 
```
This example shows how to use the Get-MgIdentityGovernanceLifecycleWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
