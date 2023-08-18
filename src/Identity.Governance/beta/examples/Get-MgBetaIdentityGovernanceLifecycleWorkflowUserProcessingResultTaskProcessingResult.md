### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult -WorkflowId $workflowId -UserProcessingResultId $userProcessingResultId -Property "id,processingStatus,failureReason,subject,task" 

```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowUserProcessingResultTaskProcessingResult Cmdlet.

