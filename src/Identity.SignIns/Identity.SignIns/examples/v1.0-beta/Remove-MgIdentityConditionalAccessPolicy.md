### Example 1: Remove a conditional access policy

```powershell
Connect-MgBetaGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

Remove-MgBetaIdentityConditionalAccessPolicy -ConditionalAccessPolicyId $conditionalAccessPolicyId
```

This example deletes the conditional access policy specified by `$conditionalAccessPolicyId`.
