### Example 1: Retrieve all built-in task definitions

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition

```
This example will retrieve all built-in task definitions

### Example 2: Retrieve all built-in tasks supported for "joiner" workflows

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowTaskDefinition -Filter "category has 'joiner'" 

```
This example will retrieve all built-in tasks supported for "joiner" workflows

