### Example 1: Creates a new conditional access policy in Azure AD that require MFA to access Exchange Online.
```powershell
PS C:\> New-MgConditionalAccessPolicy -DisplayName "MFA Policy" -State "Enabled" -ApplicationIncludeApplications "00000002-0000-0ff1-ce00-000000000000" -UserIncludeUser "All" -GrantControlBuiltInControls "mfa" -GrantControlOperator "OR"

Id                                   CreatedDateTime      Description DisplayName ModifiedDateTime State
--                                   ---------------      ----------- ----------- ---------------- -----
f550037b-d9ba-4b0f-890b-bb3c346fc11d 5/12/2020 6:05:11 PM             MFA Policy                   enabled
```

This command creates a new conditional access policy in Azure AD that require MFA to access Exchange Online.

### Example 2: Creates a new conditional access policy in Azure AD that blocks access to Exchange Online from non-trusted regions.
```powershell
PS C:\> New-MgConditionalAccessPolicy -DisplayName "Block Policy" -State "Enabled" -ApplicationIncludeApplications "00000002-0000-0ff1-ce00-000000000000" -UserIncludeUser "All" -LocationIncludeLocations "198ad66e-87b3-4157-85a3-8a7b51794ee9" -GrantControlBuiltInControls "block" -GrantControlOperator "OR"

Id                                   CreatedDateTime      Description DisplayName  ModifiedDateTime State
--                                   ---------------      ----------- -----------  ---------------- -----
dbc86c64-3472-4744-8792-182041e4a339 5/12/2020 6:21:15 PM             Block Policy                  enabled
```

This command creates a new conditional access policy in Azure AD that blocks access to Exchange Online from non-trusted regions.

