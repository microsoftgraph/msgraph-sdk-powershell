---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetaidentityconditionalaccesspolicy
schema: 2.0.0
---

# New-MgBetaIdentityConditionalAccessPolicy

## SYNOPSIS
Create a new conditionalAccessPolicy.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityConditionalAccessPolicy [-AdditionalProperties <Hashtable>]
 [-Conditions <IMicrosoftGraphConditionalAccessConditionSet>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>]
 [-GrantControls <IMicrosoftGraphConditionalAccessGrantControls>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-SessionControls <IMicrosoftGraphConditionalAccessSessionControls>]
 [-State <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityConditionalAccessPolicy -BodyParameter <IMicrosoftGraphConditionalAccessPolicy> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new conditionalAccessPolicy.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	displayName = "Access to EXO requires MFA"
	state = "enabled"
	conditions = @{
		clientAppTypes = @(
			"mobileAppsAndDesktopClients"
			"browser"
		)
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
		locations = @{
			includeLocations = @(
				"All"
			)
			excludeLocations = @(
				"AllTrusted"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
		)
	}
}

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	displayName = "Block access to EXO non-trusted regions."
	state = "enabled"
	conditions = @{
		clientAppTypes = @(
			"all"
		)
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
		locations = @{
			includeLocations = @(
				"198ad66e-87b3-4157-85a3-8a7b51794ee9"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"block"
		)
	}
}

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	displayName = "Demo app for documentation"
	state = "disabled"
	conditions = @{
		signInRiskLevels = @(
			"high"
			"medium"
		)
		clientAppTypes = @(
			"mobileAppsAndDesktopClients"
			"exchangeActiveSync"
			"other"
		)
		applications = @{
			includeApplications = @(
				"All"
			)
			excludeApplications = @(
				"499b84ac-1321-427f-aa17-267ca6975798"
				"00000007-0000-0000-c000-000000000000"
				"de8bc8b5-d9f9-48b1-a8ad-b748da725064"
				"00000012-0000-0000-c000-000000000000"
				"797f4846-ba00-4fd7-ba43-dac1f8f63013"
				"05a65629-4c1b-48c1-a78b-804c4abdd4af"
				"7df0a125-d3be-4c96-aa54-591f83ff541c"
			)
			includeUserActions = @(
			)
		}
		users = @{
			includeUsers = @(
				"a702a13d-a437-4a07-8a7e-8c052de62dfd"
			)
			excludeUsers = @(
				"124c5b6a-ffa5-483a-9b88-04c3fce5574a"
				"GuestsOrExternalUsers"
			)
			includeGroups = @(
			)
			excludeGroups = @(
			)
			includeRoles = @(
				"9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
				"cf1c38e5-3621-4004-a7cb-879624dced7c"
				"c4e39bd9-1100-46d3-8c65-fb160da0071f"
			)
			excludeRoles = @(
				"b0f54661-2d74-4c50-afa3-1ec803f12efe"
			)
		}
		platforms = @{
			includePlatforms = @(
				"all"
			)
			excludePlatforms = @(
				"iOS"
				"windowsPhone"
			)
		}
		locations = @{
			includeLocations = @(
				"AllTrusted"
			)
			excludeLocations = @(
				"00000000-0000-0000-0000-000000000000"
				"d2136c9c-b049-47ae-b9cf-316e04ef7198"
			)
		}
		deviceStates = @{
			includeStates = @(
				"All"
			)
			excludeStates = @(
				"Compliant"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
			"compliantDevice"
			"domainJoinedDevice"
			"approvedApplication"
			"compliantApplication"
		)
		customAuthenticationFactors = @(
		)
		termsOfUse = @(
			"ce580154-086a-40fd-91df-8a60abac81a0"
			"7f29d675-caff-43e1-8a53-1b8516ed2075"
		)
	}
	sessionControls = @{
		applicationEnforcedRestrictions = $null
		persistentBrowser = $null
		cloudAppSecurity = @{
			cloudAppSecurityType = "blockDownloads"
			isEnabled = $true
		}
		signInFrequency = @{
			value = 4
			type = "hours"
			isEnabled = $true
		}
	}
}

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
```

$params = @{
	displayName = "Require MFA to EXO from non-complaint devices."
	state = "enabled"
	conditions = @{
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
		devices = @{
			includeDevices = @(
				"All"
			)
			excludeDevices = @(
				"Compliant"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
		)
	}
}

New-MgBetaIdentityConditionalAccessPolicy -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
conditionalAccessPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Conditions
conditionalAccessConditionSet
To construct, see NOTES section for CONDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessConditionSet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Readonly.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Not used.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Specifies a display name for the conditionalAccessPolicy object.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantControls
conditionalAccessGrantControls
To construct, see NOTES section for GRANTCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessGrantControls
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Readonly.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SessionControls
conditionalAccessSessionControls
To construct, see NOTES section for SESSIONCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessSessionControls
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
conditionalAccessPolicyState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphConditionalAccessPolicy>`: conditionalAccessPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet>]`: conditionalAccessConditionSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplicationFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Mode <String>]`: filterMode
        - `[Rule <String>]`: Rule syntax is similar to that used for membership rules for groups in Microsoft Entra ID. For details, see rules with multiple expressions
      - `[ExcludeApplications <String[]>]`: Can be one of the following:  The list of client IDs (appId) explicitly excluded from the policy. Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite
      - `[IncludeApplications <String[]>]`: Can be one of the following:  The list of client IDs (appId) the policy applies to, unless explicitly excluded (in excludeApplications)  All  Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite
      - `[IncludeAuthenticationContextClassReferences <String[]>]`: Authentication context class references include. Supported values are c1 through c25.
      - `[IncludeUserActions <String[]>]`: User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice
    - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.  The easUnsupported enumeration member will be deprecated in favor of exchangeActiveSync which includes EAS supported and unsupported platforms.
    - `[ClientApplications <IMicrosoftGraphConditionalAccessClientApplications>]`: conditionalAccessClientApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeServicePrincipals <String[]>]`: Service principal IDs excluded from the policy scope.
      - `[IncludeServicePrincipals <String[]>]`: Service principal IDs included in the policy scope, or ServicePrincipalsInMyTenant.
      - `[ServicePrincipalFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
    - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeStates <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.
      - `[IncludeStates <String[]>]`: States in the scope of the policy. All is the only allowed value.
    - `[Devices <IMicrosoftGraphConditionalAccessDevices>]`: conditionalAccessDevices
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
      - `[ExcludeDeviceStates <String[]>]`: 
      - `[ExcludeDevices <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.
      - `[IncludeDeviceStates <String[]>]`: 
      - `[IncludeDevices <String[]>]`: States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFilter is set.
    - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
      - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
    - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.
      - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux.
    - `[ServicePrincipalRiskLevels <String[]>]`: Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.
    - `[SignInRiskLevels <String[]>]`: Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
    - `[UserRiskLevels <String[]>]`: User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
    - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
      - `[ExcludeGuestsOrExternalUsers <IMicrosoftGraphConditionalAccessGuestsOrExternalUsers>]`: conditionalAccessGuestsOrExternalUsers
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExternalTenants <IMicrosoftGraphConditionalAccessExternalTenants>]`: conditionalAccessExternalTenants
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[MembershipKind <String>]`: conditionalAccessExternalTenantsMembershipKind
        - `[GuestOrExternalUserTypes <String>]`: conditionalAccessGuestOrExternalUserTypes
      - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
      - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
      - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded.
      - `[IncludeGuestsOrExternalUsers <IMicrosoftGraphConditionalAccessGuestsOrExternalUsers>]`: conditionalAccessGuestsOrExternalUsers
      - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded.
      - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, None, All, or GuestsOrExternalUsers.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.
  - `[Description <String>]`: Not used.
  - `[DisplayName <String>]`: Specifies a display name for the conditionalAccessPolicy object.
  - `[GrantControls <IMicrosoftGraphConditionalAccessGrantControls>]`: conditionalAccessGrantControls
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthenticationStrength <IMicrosoftGraphAuthenticationStrengthPolicy>]`: authenticationStrengthPolicy
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AllowedCombinations <String[]>]`: A collection of authentication method modes that are required be used to satify this authentication strength.
      - `[CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object that's defined for the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is 'fido2'.
      - `[CreatedDateTime <DateTime?>]`: The datetime when this policy was created.
      - `[Description <String>]`: The human-readable description of this policy.
      - `[DisplayName <String>]`: The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).
      - `[ModifiedDateTime <DateTime?>]`: The datetime when this policy was last modified.
      - `[PolicyType <String>]`: authenticationStrengthPolicyType
      - `[RequirementsSatisfied <String>]`: authenticationStrengthRequirements
    - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.
    - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. To learn more about custom control, see Custom controls (preview).
    - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
    - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.
  - `[SessionControls <IMicrosoftGraphConditionalAccessSessionControls>]`: conditionalAccessSessionControls
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationEnforcedRestrictions <IMicrosoftGraphApplicationEnforcedRestrictionsSessionControl>]`: applicationEnforcedRestrictionsSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[CloudAppSecurity <IMicrosoftGraphCloudAppSecuritySessionControl>]`: cloudAppSecuritySessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[CloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
    - `[ContinuousAccessEvaluation <IMicrosoftGraphContinuousAccessEvaluationSessionControl>]`: continuousAccessEvaluationSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Mode <String>]`: continuousAccessEvaluationMode
    - `[DisableResilienceDefaults <Boolean?>]`: Session control that determines whether it's acceptable for Microsoft Entra ID to extend existing sessions based on information collected prior to an outage or not.
    - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[Mode <String>]`: persistentBrowserSessionMode
    - `[SecureSignInSession <IMicrosoftGraphSecureSignInSessionControl>]`: secureSignInSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl>]`: signInFrequencySessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[AuthenticationType <String>]`: signInFrequencyAuthenticationType
      - `[FrequencyInterval <String>]`: signInFrequencyInterval
      - `[Type <String>]`: signinFrequencyType
      - `[Value <Int32?>]`: The number of days or hours.
  - `[State <String>]`: conditionalAccessPolicyState

`CONDITIONS <IMicrosoftGraphConditionalAccessConditionSet>`: conditionalAccessConditionSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplicationFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Mode <String>]`: filterMode
      - `[Rule <String>]`: Rule syntax is similar to that used for membership rules for groups in Microsoft Entra ID. For details, see rules with multiple expressions
    - `[ExcludeApplications <String[]>]`: Can be one of the following:  The list of client IDs (appId) explicitly excluded from the policy. Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite
    - `[IncludeApplications <String[]>]`: Can be one of the following:  The list of client IDs (appId) the policy applies to, unless explicitly excluded (in excludeApplications)  All  Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite
    - `[IncludeAuthenticationContextClassReferences <String[]>]`: Authentication context class references include. Supported values are c1 through c25.
    - `[IncludeUserActions <String[]>]`: User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice
  - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.  The easUnsupported enumeration member will be deprecated in favor of exchangeActiveSync which includes EAS supported and unsupported platforms.
  - `[ClientApplications <IMicrosoftGraphConditionalAccessClientApplications>]`: conditionalAccessClientApplications
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeServicePrincipals <String[]>]`: Service principal IDs excluded from the policy scope.
    - `[IncludeServicePrincipals <String[]>]`: Service principal IDs included in the policy scope, or ServicePrincipalsInMyTenant.
    - `[ServicePrincipalFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
  - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeStates <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.
    - `[IncludeStates <String[]>]`: States in the scope of the policy. All is the only allowed value.
  - `[Devices <IMicrosoftGraphConditionalAccessDevices>]`: conditionalAccessDevices
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
    - `[ExcludeDeviceStates <String[]>]`: 
    - `[ExcludeDevices <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.
    - `[IncludeDeviceStates <String[]>]`: 
    - `[IncludeDevices <String[]>]`: States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFilter is set.
  - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
    - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
  - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.
    - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux.
  - `[ServicePrincipalRiskLevels <String[]>]`: Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.
  - `[SignInRiskLevels <String[]>]`: Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
  - `[UserRiskLevels <String[]>]`: User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
  - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
    - `[ExcludeGuestsOrExternalUsers <IMicrosoftGraphConditionalAccessGuestsOrExternalUsers>]`: conditionalAccessGuestsOrExternalUsers
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExternalTenants <IMicrosoftGraphConditionalAccessExternalTenants>]`: conditionalAccessExternalTenants
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[MembershipKind <String>]`: conditionalAccessExternalTenantsMembershipKind
      - `[GuestOrExternalUserTypes <String>]`: conditionalAccessGuestOrExternalUserTypes
    - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
    - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
    - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded.
    - `[IncludeGuestsOrExternalUsers <IMicrosoftGraphConditionalAccessGuestsOrExternalUsers>]`: conditionalAccessGuestsOrExternalUsers
    - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded.
    - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, None, All, or GuestsOrExternalUsers.

`GRANTCONTROLS <IMicrosoftGraphConditionalAccessGrantControls>`: conditionalAccessGrantControls
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuthenticationStrength <IMicrosoftGraphAuthenticationStrengthPolicy>]`: authenticationStrengthPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedCombinations <String[]>]`: A collection of authentication method modes that are required be used to satify this authentication strength.
    - `[CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object that's defined for the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is 'fido2'.
    - `[CreatedDateTime <DateTime?>]`: The datetime when this policy was created.
    - `[Description <String>]`: The human-readable description of this policy.
    - `[DisplayName <String>]`: The human-readable display name of this policy. Supports $filter (eq, ne, not , and in).
    - `[ModifiedDateTime <DateTime?>]`: The datetime when this policy was last modified.
    - `[PolicyType <String>]`: authenticationStrengthPolicyType
    - `[RequirementsSatisfied <String>]`: authenticationStrengthRequirements
  - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.
  - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. To learn more about custom control, see Custom controls (preview).
  - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
  - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.

`SESSIONCONTROLS <IMicrosoftGraphConditionalAccessSessionControls>`: conditionalAccessSessionControls
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ApplicationEnforcedRestrictions <IMicrosoftGraphApplicationEnforcedRestrictionsSessionControl>]`: applicationEnforcedRestrictionsSessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
  - `[CloudAppSecurity <IMicrosoftGraphCloudAppSecuritySessionControl>]`: cloudAppSecuritySessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[CloudAppSecurityType <String>]`: cloudAppSecuritySessionControlType
  - `[ContinuousAccessEvaluation <IMicrosoftGraphContinuousAccessEvaluationSessionControl>]`: continuousAccessEvaluationSessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Mode <String>]`: continuousAccessEvaluationMode
  - `[DisableResilienceDefaults <Boolean?>]`: Session control that determines whether it's acceptable for Microsoft Entra ID to extend existing sessions based on information collected prior to an outage or not.
  - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[Mode <String>]`: persistentBrowserSessionMode
  - `[SecureSignInSession <IMicrosoftGraphSecureSignInSessionControl>]`: secureSignInSessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
  - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl>]`: signInFrequencySessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[AuthenticationType <String>]`: signInFrequencyAuthenticationType
    - `[FrequencyInterval <String>]`: signInFrequencyInterval
    - `[Type <String>]`: signinFrequencyType
    - `[Value <Int32?>]`: The number of days or hours.

## RELATED LINKS

