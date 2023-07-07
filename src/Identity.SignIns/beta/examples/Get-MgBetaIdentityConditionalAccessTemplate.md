### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessTemplate -ConditionalAccessTemplateId $conditionalAccessTemplateId -Property "details"
```
This example shows how to use the Get-MgBetaIdentityConditionalAccessTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

