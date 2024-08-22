### Example 1: Retrieve the versions of a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId

```
This example will retrieve the versions of a workflow

### Example 2: Retrieve specific properties of all versions of a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowVersion -WorkflowId $workflowId -Property "category,displayName,versionNumber" 

```
This example will retrieve specific properties of all versions of a workflow

