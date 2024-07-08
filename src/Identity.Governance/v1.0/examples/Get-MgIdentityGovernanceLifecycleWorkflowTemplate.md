### Example 1: Retrieve all Lifecycle Workflows workflow templates

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTemplate

```
This example will retrieve all lifecycle workflows workflow templates

### Example 2: Retrieve workflow templates supported for "leaver" workflows

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTemplate -Filter "category eq 'leaver'" 

```
This example will retrieve workflow templates supported for "leaver" workflows

