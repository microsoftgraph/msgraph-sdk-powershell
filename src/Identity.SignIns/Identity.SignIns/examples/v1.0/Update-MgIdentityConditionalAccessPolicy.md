### Example 1: Add sign in risk levels to an existing conditional access policy

```powershell
Connect-MgGraph -Scopes 'Policy.ReadWrite.ConditionalAccess'
  
$params = @{
  Conditions = @{
    SignInRiskLevels = @(
      "high"
      "medium"
      "low"
    )
  }
}

Update-MgIdentityConditionalAccessPolicy -ConditionalAccessPolicyId '61c7530f-5c1d-44b2-a972-4ae658b7a9ac' -BodyParameter $params
```

This example updates and existing access policy to add the sign in risk levels.
