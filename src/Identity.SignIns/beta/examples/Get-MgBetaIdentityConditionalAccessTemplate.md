### Example 1: Get the properties a template by ID

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessTemplate -ConditionalAccessTemplateId $conditionalAccessTemplateId
```
This example shows how to use the Get-MgBetaIdentityConditionalAccessTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Select details of a template

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityConditionalAccessTemplate -ConditionalAccessTemplateId $conditionalAccessTemplateId -Property "details"
```
This example shows how to use the Get-MgBetaIdentityConditionalAccessTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

