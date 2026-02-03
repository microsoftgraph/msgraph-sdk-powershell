### Example 1: Retrieve all built-in task definitions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition

```
This example will retrieve all built-in task definitions

### Example 2: Retrieve all built-in tasks supported for "joiner" workflows

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowTaskDefinition -Filter "category has 'joiner'" 

```
This example will retrieve all built-in tasks supported for "joiner" workflows

