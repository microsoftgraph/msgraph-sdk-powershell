---
external help file:
Module Name: Microsoft.Graph.Identity.Policies
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.policies/update-mgpolicyroot
schema: 2.0.0
---

# Update-MgPolicyRoot

## SYNOPSIS
Update policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyRoot [-ActivityBasedTimeoutPolicies <IMicrosoftGraphActivityBasedTimeoutPolicy1[]>]
 [-AdminConsentRequestPolicyId <String>] [-AdminConsentRequestPolicyIsEnabled]
 [-AdminConsentRequestPolicyNotifyReviewers] [-AdminConsentRequestPolicyRemindersEnabled]
 [-AdminConsentRequestPolicyRequestDurationInDays <Int32>]
 [-AdminConsentRequestPolicyReviewers <IMicrosoftGraphAccessReviewScope[]>]
 [-AdminConsentRequestPolicyVersion <Int32>] [-ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]
 [-ConditionalAccessPolicies <IMicrosoftGraphConditionalAccessPolicy[]>]
 [-HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>] [-Id <String>]
 [-IdentitySecurityDefaultEnforcementPolicyDeletedDateTime <DateTime>]
 [-IdentitySecurityDefaultEnforcementPolicyDescription <String>]
 [-IdentitySecurityDefaultEnforcementPolicyDisplayName <String>]
 [-IdentitySecurityDefaultEnforcementPolicyId <String>] [-IdentitySecurityDefaultEnforcementPolicyIsEnabled]
 [-TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]
 [-TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyIsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyNotifyReviewers
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyRemindersEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyRequestDurationInDays
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyReviewers
.
To construct, see NOTES section for ADMINCONSENTREQUESTPOLICYREVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScope[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdminConsentRequestPolicyVersion
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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
Parameter Sets: Update
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
Parameter Sets: UpdateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultEnforcementPolicyDeletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultEnforcementPolicyDescription
Description for this policy.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultEnforcementPolicyDisplayName
Display name for this policy.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultEnforcementPolicyId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentitySecurityDefaultEnforcementPolicyIsEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
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

### -TokenIssuancePolicies
.
To construct, see NOTES section for TOKENISSUANCEPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTokenIssuancePolicy1[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
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

ADMINCONSENTREQUESTPOLICYREVIEWERS <IMicrosoftGraphAccessReviewScope[]>: .
  - `[Query <String>]`: 
  - `[QueryType <String>]`: 

BODYPARAMETER <IMicrosoftGraphPolicyRoot>: policyRoot
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
  - `[AdminConsentRequestPolicyId <String>]`: Read-only.
  - `[AdminConsentRequestPolicyIsEnabled <Boolean?>]`: 
  - `[AdminConsentRequestPolicyNotifyReviewers <Boolean?>]`: 
  - `[AdminConsentRequestPolicyRemindersEnabled <Boolean?>]`: 
  - `[AdminConsentRequestPolicyRequestDurationInDays <Int32?>]`: 
  - `[AdminConsentRequestPolicyReviewers <IMicrosoftGraphAccessReviewScope[]>]`: 
    - `[Query <String>]`: 
    - `[QueryType <String>]`: 
  - `[AdminConsentRequestPolicyVersion <Int32?>]`: 
  - `[ClaimsMappingPolicies <IMicrosoftGraphClaimsMappingPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[ConditionalAccessPolicies <IMicrosoftGraphConditionalAccessPolicy[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ApplicationEnforcedRestrictionIsEnabled <Boolean?>]`: 
    - `[CloudAppSecurityCloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
    - `[CloudAppSecurityIsEnabled <Boolean?>]`: 
    - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet>]`: conditionalAccessConditionSet
      - `[ApplicationExcludeApplications <String[]>]`: 
      - `[ApplicationIncludeApplications <String[]>]`: 
      - `[ApplicationIncludeUserActions <String[]>]`: 
      - `[ClientAppTypes <String[]>]`: 
      - `[DeviceExcludeDeviceStates <String[]>]`: 
      - `[DeviceIncludeDeviceStates <String[]>]`: 
      - `[DeviceStateExcludeStates <String[]>]`: 
      - `[DeviceStateIncludeStates <String[]>]`: 
      - `[LocationExcludeLocations <String[]>]`: 
      - `[LocationIncludeLocations <String[]>]`: 
      - `[PlatformExcludePlatforms <String[]>]`: 
      - `[PlatformIncludePlatforms <String[]>]`: 
      - `[SignInRiskLevels <String[]>]`: 
      - `[UserExcludeGroups <String[]>]`: 
      - `[UserExcludeRoles <String[]>]`: 
      - `[UserExcludeUsers <String[]>]`: 
      - `[UserIncludeGroups <String[]>]`: 
      - `[UserIncludeRoles <String[]>]`: 
      - `[UserIncludeUsers <String[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[GrantControlBuiltInControls <String[]>]`: 
    - `[GrantControlCustomAuthenticationFactors <String[]>]`: 
    - `[GrantControlOperator <String>]`: 
    - `[GrantControlTermsOfUse <String[]>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[PersistentBrowserIsEnabled <Boolean?>]`: 
    - `[PersistentBrowserMode <String>]`: persistentBrowserSessionMode
    - `[SignInFrequencyIsEnabled <Boolean?>]`: 
    - `[SignInFrequencyType <String>]`: signinFrequencyType
    - `[SignInFrequencyValue <Int32?>]`: 
    - `[State <String>]`: conditionalAccessPolicyState
  - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
    - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
    - `[Description <String>]`: Description for this policy.
    - `[DisplayName <String>]`: Display name for this policy.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
  - `[IdentitySecurityDefaultEnforcementPolicyDeletedDateTime <DateTime?>]`: 
  - `[IdentitySecurityDefaultEnforcementPolicyDescription <String>]`: Description for this policy.
  - `[IdentitySecurityDefaultEnforcementPolicyDisplayName <String>]`: Display name for this policy.
  - `[IdentitySecurityDefaultEnforcementPolicyId <String>]`: Read-only.
  - `[IdentitySecurityDefaultEnforcementPolicyIsEnabled <Boolean?>]`: 
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

CONDITIONALACCESSPOLICIES <IMicrosoftGraphConditionalAccessPolicy[]>: .
  - `[Id <String>]`: Read-only.
  - `[ApplicationEnforcedRestrictionIsEnabled <Boolean?>]`: 
  - `[CloudAppSecurityCloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
  - `[CloudAppSecurityIsEnabled <Boolean?>]`: 
  - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet>]`: conditionalAccessConditionSet
    - `[ApplicationExcludeApplications <String[]>]`: 
    - `[ApplicationIncludeApplications <String[]>]`: 
    - `[ApplicationIncludeUserActions <String[]>]`: 
    - `[ClientAppTypes <String[]>]`: 
    - `[DeviceExcludeDeviceStates <String[]>]`: 
    - `[DeviceIncludeDeviceStates <String[]>]`: 
    - `[DeviceStateExcludeStates <String[]>]`: 
    - `[DeviceStateIncludeStates <String[]>]`: 
    - `[LocationExcludeLocations <String[]>]`: 
    - `[LocationIncludeLocations <String[]>]`: 
    - `[PlatformExcludePlatforms <String[]>]`: 
    - `[PlatformIncludePlatforms <String[]>]`: 
    - `[SignInRiskLevels <String[]>]`: 
    - `[UserExcludeGroups <String[]>]`: 
    - `[UserExcludeRoles <String[]>]`: 
    - `[UserExcludeUsers <String[]>]`: 
    - `[UserIncludeGroups <String[]>]`: 
    - `[UserIncludeRoles <String[]>]`: 
    - `[UserIncludeUsers <String[]>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[GrantControlBuiltInControls <String[]>]`: 
  - `[GrantControlCustomAuthenticationFactors <String[]>]`: 
  - `[GrantControlOperator <String>]`: 
  - `[GrantControlTermsOfUse <String[]>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[PersistentBrowserIsEnabled <Boolean?>]`: 
  - `[PersistentBrowserMode <String>]`: persistentBrowserSessionMode
  - `[SignInFrequencyIsEnabled <Boolean?>]`: 
  - `[SignInFrequencyType <String>]`: signinFrequencyType
  - `[SignInFrequencyValue <Int32?>]`: 
  - `[State <String>]`: conditionalAccessPolicyState

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

