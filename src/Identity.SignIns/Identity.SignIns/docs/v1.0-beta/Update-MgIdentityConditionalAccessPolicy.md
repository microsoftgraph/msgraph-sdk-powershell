---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgidentityconditionalaccesspolicy
schema: 2.0.0
---

# Update-MgIdentityConditionalAccessPolicy

## SYNOPSIS
Update the navigation property policies in identity

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgIdentityConditionalAccessPolicy -ConditionalAccessPolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Conditions <IMicrosoftGraphConditionalAccessConditionSet1>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-GrantControls <IMicrosoftGraphConditionalAccessGrantControls>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-SessionControls <IMicrosoftGraphConditionalAccessSessionControls1>]
 [-State <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgIdentityConditionalAccessPolicy -ConditionalAccessPolicyId <String>
 -BodyParameter <IMicrosoftGraphConditionalAccessPolicy1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgIdentityConditionalAccessPolicy -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphConditionalAccessPolicy1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgIdentityConditionalAccessPolicy -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-Conditions <IMicrosoftGraphConditionalAccessConditionSet1>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-GrantControls <IMicrosoftGraphConditionalAccessGrantControls>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-SessionControls <IMicrosoftGraphConditionalAccessSessionControls1>]
 [-State <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property policies in identity

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
conditionalAccessPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConditionalAccessPolicyId
key: id of conditionalAccessPolicy

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Conditions
conditionalAccessConditionSet
To construct, please use Get-Help -Online and see NOTES section for CONDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessConditionSet1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GrantControls
conditionalAccessGrantControls
To construct, please use Get-Help -Online and see NOTES section for GRANTCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessGrantControls
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Readonly.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -SessionControls
conditionalAccessSessionControls
To construct, please use Get-Help -Online and see NOTES section for SESSIONCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessSessionControls1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConditionalAccessPolicy1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphConditionalAccessPolicy1>: conditionalAccessPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Conditions <IMicrosoftGraphConditionalAccessConditionSet1>]`: conditionalAccessConditionSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeApplications <String[]>]`: The list of application IDs explicitly excluded from the policy.
      - `[IncludeApplications <String[]>]`: The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.
      - `[IncludeAuthenticationContextClassReferences <String[]>]`: Authentication context class references include. Supported values are c1 through c25.
      - `[IncludeUserActions <String[]>]`: User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice
    - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.
    - `[ClientApplications <IMicrosoftGraphConditionalAccessClientApplications>]`: conditionalAccessClientApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeServicePrincipals <String[]>]`: Service principal IDs excluded from the policy scope.
      - `[IncludeServicePrincipals <String[]>]`: Service principal IDs included in the policy scope, or ServicePrincipalsInMyTenant.
    - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeStates <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.
      - `[IncludeStates <String[]>]`: States in the scope of the policy. All is the only allowed value.
    - `[Devices <IMicrosoftGraphConditionalAccessDevices1>]`: conditionalAccessDevices
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Mode <String>]`: filterMode
        - `[Rule <String>]`: Rule syntax is similar to that used for membership rules for groups in Azure Active Directory. For details, see rules with multiple expressions
      - `[ExcludeDeviceStates <String[]>]`: 
      - `[ExcludeDevices <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.
      - `[IncludeDeviceStates <String[]>]`: 
      - `[IncludeDevices <String[]>]`: States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFIlter is set.
    - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
      - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
    - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.
      - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux``.
    - `[ServicePrincipalRiskLevels <String[]>]`: Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.
    - `[SignInRiskLevels <String[]>]`: Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
    - `[UserRiskLevels <String[]>]`: User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
    - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
      - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
      - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
      - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded, or All.
      - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded, or All.
      - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.
  - `[Description <String>]`: Not used.
  - `[DisplayName <String>]`: Specifies a display name for the conditionalAccessPolicy object.
  - `[GrantControls <IMicrosoftGraphConditionalAccessGrantControls>]`: conditionalAccessGrantControls
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.
    - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. To learn more about custom control, see Custom controls (preview).
    - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
    - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.
  - `[SessionControls <IMicrosoftGraphConditionalAccessSessionControls1>]`: conditionalAccessSessionControls
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
    - `[DisableResilienceDefaults <Boolean?>]`: Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.
    - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[Mode <String>]`: persistentBrowserSessionMode
    - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl1>]`: signInFrequencySessionControl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
      - `[AuthenticationType <String>]`: signInFrequencyAuthenticationType
      - `[FrequencyInterval <String>]`: signInFrequencyInterval
      - `[Type <String>]`: signinFrequencyType
      - `[Value <Int32?>]`: The number of days or hours.
  - `[State <String>]`: conditionalAccessPolicyState

CONDITIONS <IMicrosoftGraphConditionalAccessConditionSet1>: conditionalAccessConditionSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphConditionalAccessApplications>]`: conditionalAccessApplications
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeApplications <String[]>]`: The list of application IDs explicitly excluded from the policy.
    - `[IncludeApplications <String[]>]`: The list of application IDs the policy applies to, unless explicitly excluded (in excludeApplications). Can also be set to All.
    - `[IncludeAuthenticationContextClassReferences <String[]>]`: Authentication context class references include. Supported values are c1 through c25.
    - `[IncludeUserActions <String[]>]`: User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice
  - `[ClientAppTypes <String[]>]`: Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.
  - `[ClientApplications <IMicrosoftGraphConditionalAccessClientApplications>]`: conditionalAccessClientApplications
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeServicePrincipals <String[]>]`: Service principal IDs excluded from the policy scope.
    - `[IncludeServicePrincipals <String[]>]`: Service principal IDs included in the policy scope, or ServicePrincipalsInMyTenant.
  - `[DeviceStates <IMicrosoftGraphConditionalAccessDeviceStates>]`: conditionalAccessDeviceStates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeStates <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.
    - `[IncludeStates <String[]>]`: States in the scope of the policy. All is the only allowed value.
  - `[Devices <IMicrosoftGraphConditionalAccessDevices1>]`: conditionalAccessDevices
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceFilter <IMicrosoftGraphConditionalAccessFilter>]`: conditionalAccessFilter
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Mode <String>]`: filterMode
      - `[Rule <String>]`: Rule syntax is similar to that used for membership rules for groups in Azure Active Directory. For details, see rules with multiple expressions
    - `[ExcludeDeviceStates <String[]>]`: 
    - `[ExcludeDevices <String[]>]`: States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.
    - `[IncludeDeviceStates <String[]>]`: 
    - `[IncludeDevices <String[]>]`: States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFIlter is set.
  - `[Locations <IMicrosoftGraphConditionalAccessLocations>]`: conditionalAccessLocations
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeLocations <String[]>]`: Location IDs excluded from scope of policy.
    - `[IncludeLocations <String[]>]`: Location IDs in scope of policy unless explicitly excluded, All, or AllTrusted.
  - `[Platforms <IMicrosoftGraphConditionalAccessPlatforms>]`: conditionalAccessPlatforms
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.
    - `[IncludePlatforms <String[]>]`: Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux``.
  - `[ServicePrincipalRiskLevels <String[]>]`: Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.
  - `[SignInRiskLevels <String[]>]`: Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
  - `[UserRiskLevels <String[]>]`: User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.
  - `[Users <IMicrosoftGraphConditionalAccessUsers>]`: conditionalAccessUsers
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExcludeGroups <String[]>]`: Group IDs excluded from scope of policy.
    - `[ExcludeRoles <String[]>]`: Role IDs excluded from scope of policy.
    - `[ExcludeUsers <String[]>]`: User IDs excluded from scope of policy and/or GuestsOrExternalUsers.
    - `[IncludeGroups <String[]>]`: Group IDs in scope of policy unless explicitly excluded, or All.
    - `[IncludeRoles <String[]>]`: Role IDs in scope of policy unless explicitly excluded, or All.
    - `[IncludeUsers <String[]>]`: User IDs in scope of policy unless explicitly excluded, or None or All or GuestsOrExternalUsers.

GRANTCONTROLS <IMicrosoftGraphConditionalAccessGrantControls>: conditionalAccessGrantControls
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BuiltInControls <String[]>]`: List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.
  - `[CustomAuthenticationFactors <String[]>]`: List of custom controls IDs required by the policy. To learn more about custom control, see Custom controls (preview).
  - `[Operator <String>]`: Defines the relationship of the grant controls. Possible values: AND, OR.
  - `[TermsOfUse <String[]>]`: List of terms of use IDs required by the policy.

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AuthenticationContextClassReferenceId <String>]`: key: id of authenticationContextClassReference
  - `[AuthenticationMethodConfigurationId <String>]`: key: id of authenticationMethodConfiguration
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[BitlockerRecoveryKeyId <String>]`: key: id of bitlockerRecoveryKey
  - `[CertificateBasedAuthConfigurationId <String>]`: key: id of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[CommandId <String>]`: key: id of command
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: key: tenantId of crossTenantAccessPolicyConfigurationPartner
  - `[DataLossPreventionPolicyId <String>]`: key: id of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: key: id of dataPolicyOperation
  - `[DefaultUserRoleOverrideId <String>]`: key: id of defaultUserRoleOverride
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EmailAuthenticationMethodId <String>]`: key: id of emailAuthenticationMethod
  - `[ExtensionId <String>]`: key: id of extension
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[Fido2AuthenticationMethodId <String>]`: key: id of fido2AuthenticationMethod
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[IdentityProviderId <String>]`: key: id of identityProvider
  - `[IdentityUserFlowId <String>]`: key: id of identityUserFlow
  - `[InformationProtectionLabelId <String>]`: key: id of informationProtectionLabel
  - `[LongRunningOperationId <String>]`: key: id of longRunningOperation
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of microsoftAuthenticatorAuthenticationMethod
  - `[MobilityManagementPolicyId <String>]`: key: id of mobilityManagementPolicy
  - `[NamedLocationId <String>]`: key: id of namedLocation
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OrganizationId <String>]`: key: id of organization
  - `[PasswordAuthenticationMethodId <String>]`: key: id of passwordAuthenticationMethod
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionGrantConditionSetId <String>]`: key: id of permissionGrantConditionSet
  - `[PermissionGrantPolicyId <String>]`: key: id of permissionGrantPolicy
  - `[PhoneAuthenticationMethodId <String>]`: key: id of phoneAuthenticationMethod
  - `[RiskDetectionId <String>]`: key: id of riskDetection
  - `[RiskyServicePrincipalHistoryItemId <String>]`: key: id of riskyServicePrincipalHistoryItem
  - `[RiskyServicePrincipalId <String>]`: key: id of riskyServicePrincipal
  - `[RiskyUserHistoryItemId <String>]`: key: id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: id of riskyUser
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: key: id of sensitivityLabel
  - `[ServicePrincipalCreationConditionSetId <String>]`: key: id of servicePrincipalCreationConditionSet
  - `[ServicePrincipalCreationPolicyId <String>]`: key: id of servicePrincipalCreationPolicy
  - `[ServicePrincipalRiskDetectionId <String>]`: key: id of servicePrincipalRiskDetection
  - `[SoftwareOathAuthenticationMethodId <String>]`: key: id of softwareOathAuthenticationMethod
  - `[TemporaryAccessPassAuthenticationMethodId <String>]`: key: id of temporaryAccessPassAuthenticationMethod
  - `[ThreatAssessmentRequestId <String>]`: key: id of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: key: id of threatAssessmentResult
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[TrustFrameworkKeySetId <String>]`: key: id of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: key: id of trustFrameworkPolicy
  - `[UnifiedRoleManagementPolicyAssignmentId <String>]`: key: id of unifiedRoleManagementPolicyAssignment
  - `[UnifiedRoleManagementPolicyId <String>]`: key: id of unifiedRoleManagementPolicy
  - `[UnifiedRoleManagementPolicyRuleId <String>]`: key: id of unifiedRoleManagementPolicyRule
  - `[UsageRightId <String>]`: key: id of usageRight
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

SESSIONCONTROLS <IMicrosoftGraphConditionalAccessSessionControls1>: conditionalAccessSessionControls
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
  - `[DisableResilienceDefaults <Boolean?>]`: Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.
  - `[PersistentBrowser <IMicrosoftGraphPersistentBrowserSessionControl>]`: persistentBrowserSessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[Mode <String>]`: persistentBrowserSessionMode
  - `[SignInFrequency <IMicrosoftGraphSignInFrequencySessionControl1>]`: signInFrequencySessionControl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsEnabled <Boolean?>]`: Specifies whether the session control is enabled.
    - `[AuthenticationType <String>]`: signInFrequencyAuthenticationType
    - `[FrequencyInterval <String>]`: signInFrequencyInterval
    - `[Type <String>]`: signinFrequencyType
    - `[Value <Int32?>]`: The number of days or hours.

## RELATED LINKS

