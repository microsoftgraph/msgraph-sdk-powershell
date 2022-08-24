### Example 1: Remove a conditional access policy

```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'

Remove-MgIdentityConditionalAccessPolicy -ConditionalAccessPolicyId $conditionalAccessPolicyId
```

This example deletes the conditional access policy specified by `$conditionalAccessPolicyId`.
