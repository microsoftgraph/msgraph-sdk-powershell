---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyroot
schema: 2.0.0
---

# Update-MgPolicyRoot

## SYNOPSIS
Update policies

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgPolicyRoot [-ActivityBasedTimeoutPolicies <IMicrosoftGraphActivityBasedTimeoutPolicy1[]>]
 [-AdditionalProperties <Hashtable>] [-AdminConsentRequestPolicy <IMicrosoftGraphAdminConsentRequestPolicy>]
 [-AuthenticationFlowsPolicy <IMicrosoftGraphAuthenticationFlowsPolicy>]
 [-AuthorizationPolicy <IMicrosoftGraphAuthorizationPolicy[]>]
 [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]
 [-ConditionalAccessPolicies <IMicrosoftGraphConditionalAccessPolicy1[]>]
 [-DeviceRegistrationPolicy <Hashtable>]
 [-DirectoryRoleAccessReviewPolicy <IMicrosoftGraphDirectoryRoleAccessReviewPolicy>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>] [-Id <String>]
 [-IdentitySecurityDefaultsEnforcementPolicy <IMicrosoftGraphIdentitySecurityDefaultsEnforcementPolicy1>]
 [-PermissionGrantPolicies <IMicrosoftGraphPermissionGrantPolicy[]>]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgPolicyRoot -BodyParameter <IMicrosoftGraphPolicyRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update policies

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ActivityBasedTimeoutPolicies
.
To construct, see NOTES section for ACTIVITYBASEDTIMEOUTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphActivityBasedTimeoutPolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicy
adminConsentRequestPolicy
To construct, see NOTES section for ADMINCONSENTREQUESTPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdminConsentRequestPolicy
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationFlowsPolicy
authenticationFlowsPolicy
To construct, see NOTES section for AUTHENTICATIONFLOWSPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationFlowsPolicy
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationPolicy
.
To construct, see NOTES section for AUTHORIZATIONPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
policyRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicyRoot
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClaimsMappingPolicies
.
To construct, see NOTES section for CLAIMSMAPPINGPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphClaimsMappingPolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConditionalAccessPolicies
.
To construct, see NOTES section for CONDITIONALACCESSPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceRegistrationPolicy
deviceRegistrationPolicy

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectoryRoleAccessReviewPolicy
directoryRoleAccessReviewPolicy
To construct, see NOTES section for DIRECTORYROLEACCESSREVIEWPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryRoleAccessReviewPolicy
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HomeRealmDiscoveryPolicies
.
To construct, see NOTES section for HOMEREALMDISCOVERYPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHomeRealmDiscoveryPolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultsEnforcementPolicy
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for IDENTITYSECURITYDEFAULTSENFORCEMENTPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySecurityDefaultsEnforcementPolicy1
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionGrantPolicies
.
To construct, see NOTES section for PERMISSIONGRANTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenLifetimePolicies
.
To construct, see NOTES section for TOKENLIFETIMEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenLifetimePolicy1[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicyRoot

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIVITYBASEDTIMEOUTPOLICIES <IMicrosoftGraphActivityBasedTimeoutPolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

ADMINCONSENTREQUESTPOLICY <IMicrosoftGraphAdminConsentRequestPolicy>: adminConsentRequestPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[IsEnabled <Boolean?>]`: 
  - `[NotifyReviewers <Boolean?>]`: 
  - `[RemindersEnabled <Boolean?>]`: 
  - `[RequestDurationInDays <Int32?>]`: 
  - `[Reviewers <IMicrosoftGraphAccessReviewScope[]>]`: 
    - `[Query <String>]`: 
    - `[QueryType <String>]`: 
  - `[Version <Int32?>]`: 

AUTHENTICATIONFLOWSPOLICY <IMicrosoftGraphAuthenticationFlowsPolicy>: authenticationFlowsPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[SelfServiceSignUp <IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration>]`: selfServiceSignUpAuthenticationFlowConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: 

AUTHORIZATIONPOLICY <IMicrosoftGraphAuthorizationPolicy[]>: .
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AllowEmailVerifiedUsersToJoinOrganization <Boolean?>]`: 
  - `[AllowedToSignUpEmailBasedSubscriptions <Boolean?>]`: 
  - `[AllowedToUseSspr <Boolean?>]`: 
  - `[BlockMsolPowerShell <Boolean?>]`: 
  - `[DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]`: defaultUserRolePermissions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedToCreateApps <Boolean?>]`: 
    - `[AllowedToCreateSecurityGroups <Boolean?>]`: 
    - `[AllowedToReadOtherUsers <Boolean?>]`: 
  - `[EnabledPreviewFeatures <String[]>]`: 
  - `[GuestUserRoleId <String>]`: 
  - `[PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]`: 

BODYPARAMETER <IMicrosoftGraphPolicyRoot>: policyRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActivityBasedTimeoutPolicies <IMicrosoftGraphActivityBasedTimeoutPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[AdminConsentRequestPolicy <IMicrosoftGraphAdminConsentRequestPolicy>]`: adminConsentRequestPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[IsEnabled <Boolean?>]`: 
    - `[NotifyReviewers <Boolean?>]`: 
    - `[RemindersEnabled <Boolean?>]`: 
    - `[RequestDurationInDays <Int32?>]`: 
    - `[Reviewers <IMicrosoftGraphAccessReviewScope[]>]`: 
      - `[Query <String>]`: 
      - `[QueryType <String>]`: 
    - `[Version <Int32?>]`: 
  - `[AuthenticationFlowsPolicy <IMicrosoftGraphAuthenticationFlowsPolicy>]`: authenticationFlowsPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[SelfServiceSignUp <IMicrosoftGraphSelfServiceSignUpAuthenticationFlowConfiguration>]`: selfServiceSignUpAuthenticationFlowConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: 
  - `[AuthorizationPolicy <IMicrosoftGraphAuthorizationPolicy[]>]`: 
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[AllowEmailVerifiedUsersToJoinOrganization <Boolean?>]`: 
    - `[AllowedToSignUpEmailBasedSubscriptions <Boolean?>]`: 
    - `[AllowedToUseSspr <Boolean?>]`: 
    - `[BlockMsolPowerShell <Boolean?>]`: 
    - `[DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]`: defaultUserRolePermissions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AllowedToCreateApps <Boolean?>]`: 
      - `[AllowedToCreateSecurityGroups <Boolean?>]`: 
      - `[AllowedToReadOtherUsers <Boolean?>]`: 
    - `[EnabledPreviewFeatures <String[]>]`: 
    - `[GuestUserRoleId <String>]`: 
    - `[PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]`: 
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[ConditionalAccessPolicies <IMicrosoftGraphConditionalAccessPolicy1[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet1>]`: conditionalAccessConditionSet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludeApplications <String[]>]`: The list of application IDs explicitly excluded from the policy.
        - `[IncludeApplications <String[]>]`: The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.
        - `[IncludeUserActions <String[]>]`: User actions to include. For example, urn:user:registersecurityinfo
      - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other.
      - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludeStates <String[]>]`: 
        - `[IncludeStates <String[]>]`: 
      - `[Devices <IMicrosoftGraphConditionalAccessDevices>]`: conditionalAccessDevices
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludeDeviceStates <String[]>]`: 
        - `[IncludeDeviceStates <String[]>]`: 
      - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
        - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
      - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, unknownFutureValue.
        - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue.
      - `[SignInRiskLevels <String[]>]`: Risk levels included in the policy. Possible values are: low, medium, high, none.
      - `[UserRiskLevels <String[]>]`: 
      - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
        - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
        - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
        - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded, or All.
        - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded, or All.
        - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Readonly.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: Specifies a display name for the conditionalAccessPolicy object.
    - `[GrantControls <IMicrosoftGraphConditionalAccessGrantControls1>]`: conditionalAccessGrantControls
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: Block, Mfa, CompliantDevice, DomainJoinedDevice, ApprovedApplication, CompliantApplication
      - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. For more information, see Custom controls.
      - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
      - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Readonly.
    - `[SessionControls <IMicrosoftGraphConditionalAccessSessionControls>]`: conditionalAccessSessionControls
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationEnforcedRestrictions <IMicrosoftGraphApplicationEnforcedRestrictionsSessionControl>]`: applicationEnforcedRestrictionsSessionControl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[CloudAppSecurity <IMicrosoftGraphCloudAppSecuritySessionControl>]`: cloudAppSecuritySessionControl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
        - `[CloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
      - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
        - `[Mode <String>]`: persistentBrowserSessionMode
      - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl>]`: signInFrequencySessionControl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
        - `[Type <String>]`: signinFrequencyType
        - `[Value <Int32?>]`: The number of days or hours.
    - `[State <String>]`: conditionalAccessPolicyState
  - `[DeviceRegistrationPolicy <IMicrosoftGraphDeviceRegistrationPolicy>]`: deviceRegistrationPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
  - `[DirectoryRoleAccessReviewPolicy <IMicrosoftGraphDirectoryRoleAccessReviewPolicy>]`: directoryRoleAccessReviewPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings>]`: accessReviewScheduleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: 
      - `[AutoApplyDecisionsEnabled <Boolean?>]`: 
      - `[DefaultDecision <String>]`: 
      - `[DefaultDecisionEnabled <Boolean?>]`: 
      - `[InstanceDurationInDays <Int32?>]`: 
      - `[JustificationRequiredOnApproval <Boolean?>]`: 
      - `[MailNotificationsEnabled <Boolean?>]`: 
      - `[RecommendationsEnabled <Boolean?>]`: 
      - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
          - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
          - `[FirstDayOfWeek <String>]`: dayOfWeek
          - `[Index <String>]`: weekIndex
          - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
          - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
          - `[Type <String>]`: recurrencePatternType
        - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
          - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
          - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
          - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
          - `[Type <String>]`: recurrenceRangeType
      - `[ReminderNotificationsEnabled <Boolean?>]`: 
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[IdentitySecurityDefaultsEnforcementPolicy <IMicrosoftGraphIdentitySecurityDefaultsEnforcementPolicy1>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[IsEnabled <Boolean?>]`: If set to true, Azure Active Directory security defaults is enabled for the tenant.
  - `[PermissionGrantPolicies <IMicrosoftGraphPermissionGrantPolicy[]>]`: 
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ClientApplicationIds <String[]>]`: 
      - `[ClientApplicationPublisherIds <String[]>]`: 
      - `[ClientApplicationTenantIds <String[]>]`: 
      - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
      - `[PermissionClassification <String>]`: 
      - `[PermissionType <String>]`: permissionType
      - `[Permissions <String[]>]`: 
      - `[ResourceApplication <String>]`: 
    - `[Includes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 
  - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.

CLAIMSMAPPINGPOLICIES <IMicrosoftGraphClaimsMappingPolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

CONDITIONALACCESSPOLICIES <IMicrosoftGraphConditionalAccessPolicy1[]>: .
  - `[Id <String>]`: Read-only.
  - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet1>]`: conditionalAccessConditionSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeApplications <String[]>]`: The list of application IDs explicitly excluded from the policy.
      - `[IncludeApplications <String[]>]`: The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.
      - `[IncludeUserActions <String[]>]`: User actions to include. For example, urn:user:registersecurityinfo
    - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other.
    - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeStates <String[]>]`: 
      - `[IncludeStates <String[]>]`: 
    - `[Devices <IMicrosoftGraphConditionalAccessDevices>]`: conditionalAccessDevices
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeDeviceStates <String[]>]`: 
      - `[IncludeDeviceStates <String[]>]`: 
    - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
      - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
    - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, unknownFutureValue.
      - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue.
    - `[SignInRiskLevels <String[]>]`: Risk levels included in the policy. Possible values are: low, medium, high, none.
    - `[UserRiskLevels <String[]>]`: 
    - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
      - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
      - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
      - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded, or All.
      - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded, or All.
      - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Readonly.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: Specifies a display name for the conditionalAccessPolicy object.
  - `[GrantControls <IMicrosoftGraphConditionalAccessGrantControls1>]`: conditionalAccessGrantControls
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: Block, Mfa, CompliantDevice, DomainJoinedDevice, ApprovedApplication, CompliantApplication
    - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. For more information, see Custom controls.
    - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
    - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Readonly.
  - `[SessionControls <IMicrosoftGraphConditionalAccessSessionControls>]`: conditionalAccessSessionControls
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationEnforcedRestrictions <IMicrosoftGraphApplicationEnforcedRestrictionsSessionControl>]`: applicationEnforcedRestrictionsSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[CloudAppSecurity <IMicrosoftGraphCloudAppSecuritySessionControl>]`: cloudAppSecuritySessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[CloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
    - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[Mode <String>]`: persistentBrowserSessionMode
    - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl>]`: signInFrequencySessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[Type <String>]`: signinFrequencyType
      - `[Value <Int32?>]`: The number of days or hours.
  - `[State <String>]`: conditionalAccessPolicyState

DIRECTORYROLEACCESSREVIEWPOLICY <IMicrosoftGraphDirectoryRoleAccessReviewPolicy>: directoryRoleAccessReviewPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings>]`: accessReviewScheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: 
    - `[AutoApplyDecisionsEnabled <Boolean?>]`: 
    - `[DefaultDecision <String>]`: 
    - `[DefaultDecisionEnabled <Boolean?>]`: 
    - `[InstanceDurationInDays <Int32?>]`: 
    - `[JustificationRequiredOnApproval <Boolean?>]`: 
    - `[MailNotificationsEnabled <Boolean?>]`: 
    - `[RecommendationsEnabled <Boolean?>]`: 
    - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
        - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
        - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
        - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
        - `[Type <String>]`: recurrenceRangeType
    - `[ReminderNotificationsEnabled <Boolean?>]`: 

HOMEREALMDISCOVERYPOLICIES <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

IDENTITYSECURITYDEFAULTSENFORCEMENTPOLICY <IMicrosoftGraphIdentitySecurityDefaultsEnforcementPolicy1>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[IsEnabled <Boolean?>]`: If set to true, Azure Active Directory security defaults is enabled for the tenant.

PERMISSIONGRANTPOLICIES <IMicrosoftGraphPermissionGrantPolicy[]>: .
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ClientApplicationIds <String[]>]`: 
    - `[ClientApplicationPublisherIds <String[]>]`: 
    - `[ClientApplicationTenantIds <String[]>]`: 
    - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
    - `[PermissionClassification <String>]`: 
    - `[PermissionType <String>]`: permissionType
    - `[Permissions <String[]>]`: 
    - `[ResourceApplication <String>]`: 
  - `[Includes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 

TOKENISSUANCEPOLICIES <IMicrosoftGraphTokenIssuancePolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

TOKENLIFETIMEPOLICIES <IMicrosoftGraphTokenLifetimePolicy1[]>: .
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
  - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.

## RELATED LINKS

