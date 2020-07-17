### Example 1: Retrieves a list of all conditional access policies in Azure AD.
```powershell
PS C:\> Get-MgConditionalAccessPolicy

Id                                   CreatedDateTime      Description DisplayName              ModifiedDateTime     State
--                                   ---------------      ----------- -----------              ----------------     -----
99dac946-5c4a-42de-ac16-76159af6a584                                  User Policy for Exchange 4/3/2020 7:22:14 PM  enabled
ff402a0f-fa39-4d7e-bbe6-63b91c89f3d8                                  XYZ                                           enabled
5f06ee26-a784-4ead-9327-ef617b2c50be 4/3/2020 7:58:10 PM              Test Policy 1            4/3/2020 8:16:44 PM  disabled
dd3d362a-5d8a-4f88-b335-a23bd88f8dac 4/7/2020 5:06:10 PM              User Policy for Exchange                      enabled
486358c9-25bd-401a-a40a-607ce5cf18a2 4/7/2020 5:07:15 PM              User Policy for Exchange                      enabled
a65f1a0c-3417-4cd2-b141-365223c38288 4/7/2020 5:08:42 PM              User Policy for Exchange                      enabled
c7d7a349-60e1-4130-b9d2-044244a93177 4/10/2020 7:06:22 PM             Device state policy 1                         enabled
2d306301-1dfe-44a7-9e7a-84279a332de0 4/14/2020 5:25:45 AM             MFA Test Policy          4/14/2020 5:27:25 AM enabled
27d299c0-b597-4fed-a471-2708c909683c 4/23/2020 5:00:44 PM             ReportOnlyTest                                enabledForReportingButNotEnforced
f935790a-ed33-41be-b525-7f331f4d692a 4/23/2020 5:02:51 PM             ReportOnlyTest                                enabledForReportingButNotEnforced
2029f5f8-87d1-48dc-b42e-7367bc0b40ce 4/24/2020 7:29:10 PM             MFA policy                                    disabled
e865f454-d27f-4f8d-8f78-edb9839689b1 5/7/2020 4:47:54 PM              User Policy for Exchange                      enabled
b84c8b50-f5f5-46a7-b3a8-48326f16f1d7 5/7/2020 4:50:25 PM              User Policy for Exchange                      enabled
98f92b11-70ed-4977-b22e-948ed0633073 5/7/2020 4:50:59 PM              User Policy for Exchange                      enabled
```

This command retrieves a list of all conditional access policies in Azure AD.

### Example 2: Retrieves a conditional access policy in Azure AD with given Id.
```powershell
PS C:\> Get-MgConditionalAccessPolicy -ConditionalAccessPolicyId 99dac946-5c4a-42de-ac16-76159af6a584 | Format-List | More

ApplicationEnforcedRestrictionIsEnabled :
ApplicationExcludeApplications          : {}
ApplicationIncludeApplications          : {18899b4f-04e9-4da5-874a-bfc2f73e9dae, 00000002-0000-0ff1-ce00-000000000000}
ApplicationIncludeUserActions           : {}
CloudAppSecurityCloudAppSecurityType    :
CloudAppSecurityIsEnabled               :
ConditionClientAppTypes                 : {}
ConditionSignInRiskLevels               : {}
CreatedDateTime                         :
Description                             :
DeviceStateExcludeStates                :
DeviceStateIncludeStates                :
DisplayName                             : User Policy for Exchange
GrantControlBuiltInControls             : {compliantDevice}
GrantControlCustomAuthenticationFactors : {}
GrantControlOperator                    : OR
GrantControlTermsOfUse                  : {}
Id                                      : 99dac946-5c4a-42de-ac16-76159af6a584
LocationExcludeLocations                :
LocationIncludeLocations                :
ModifiedDateTime                        : 4/3/2020 7:22:14 PM
PersistentBrowserIsEnabled              :
PersistentBrowserMode                   :
PlatformExcludePlatforms                :
PlatformIncludePlatforms                :
SignInFrequencyIsEnabled                :
SignInFrequencyType                     :
SignInFrequencyValue                    :
State                                   : enabled
UserExcludeGroups                       : {}
UserExcludeRoles                        : {}
UserExcludeUsers                        : {}
UserIncludeGroups                       : {}
UserIncludeRoles                        : {}
UserIncludeUsers                        : {853a6905-8948-4678-8056-bb12225d64f4}
```

This command retrieves a conditional access policy in Azure AD.

