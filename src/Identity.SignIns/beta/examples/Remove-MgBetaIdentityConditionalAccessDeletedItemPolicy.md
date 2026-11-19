### Example 1: Permanently delete a deleted conditionalAccessPolicy object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Remove-MgBetaIdentityConditionalAccessDeletedItemPolicy -ConditionalAccessPolicyId $conditionalAccessPolicyId

```
This example will permanently delete a deleted conditionalaccesspolicy object

