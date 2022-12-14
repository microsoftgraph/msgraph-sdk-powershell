---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/update-mguserinformationprotection
schema: 2.0.0
---

# Update-MgBetaUserInformationProtection

## SYNOPSIS
Update the navigation property informationProtection in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserInformationProtection -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Bitlocker <IMicrosoftGraphBitlocker>]
 [-DataLossPreventionPolicies <IMicrosoftGraphDataLossPreventionPolicy[]>] [-Id <String>]
 [-Policy <IMicrosoftGraphInformationProtectionPolicy>]
 [-SensitivityLabels <IMicrosoftGraphSensitivityLabel[]>]
 [-SensitivityPolicySettings <IMicrosoftGraphSensitivityPolicySettings>]
 [-ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaUserInformationProtection -UserId <String> -BodyParameter <IMicrosoftGraphInformationProtection>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserInformationProtection -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphInformationProtection> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserInformationProtection -InputObject <IIdentitySignInsIdentity> [-AdditionalProperties <Hashtable>]
 [-Bitlocker <IMicrosoftGraphBitlocker>]
 [-DataLossPreventionPolicies <IMicrosoftGraphDataLossPreventionPolicy[]>] [-Id <String>]
 [-Policy <IMicrosoftGraphInformationProtectionPolicy>]
 [-SensitivityLabels <IMicrosoftGraphSensitivityLabel[]>]
 [-SensitivityPolicySettings <IMicrosoftGraphSensitivityPolicySettings>]
 [-ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property informationProtection in users

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

### -Bitlocker
bitlocker
To construct, please use Get-Help -Online and see NOTES section for BITLOCKER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBitlocker
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
informationProtection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtection
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DataLossPreventionPolicies
.
To construct, please use Get-Help -Online and see NOTES section for DATALOSSPREVENTIONPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDataLossPreventionPolicy[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Policy
informationProtectionPolicy
To construct, please use Get-Help -Online and see NOTES section for POLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtectionPolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensitivityLabels
.
To construct, please use Get-Help -Online and see NOTES section for SENSITIVITYLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensitivityPolicySettings
sensitivityPolicySettings
To construct, please use Get-Help -Online and see NOTES section for SENSITIVITYPOLICYSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityPolicySettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThreatAssessmentRequests
.
To construct, please use Get-Help -Online and see NOTES section for THREATASSESSMENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInformationProtection

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BITLOCKER <IMicrosoftGraphBitlocker>: bitlocker
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory. Not nullable.
    - `[DeviceId <String>]`: Identifier of the device the BitLocker key is originally backed up from. Supports $filter (eq).
    - `[Key <String>]`: The BitLocker recovery key. Returned only on $select. Not nullable.
    - `[VolumeType <String>]`: volumeType

BODYPARAMETER <IMicrosoftGraphInformationProtection>: informationProtection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Bitlocker <IMicrosoftGraphBitlocker>]`: bitlocker
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[RecoveryKeys <IMicrosoftGraphBitlockerRecoveryKey[]>]`: The recovery keys associated with the bitlocker entity.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time when the key was originally backed up to Azure Active Directory. Not nullable.
      - `[DeviceId <String>]`: Identifier of the device the BitLocker key is originally backed up from. Supports $filter (eq).
      - `[Key <String>]`: The BitLocker recovery key. Returned only on $select. Not nullable.
      - `[VolumeType <String>]`: volumeType
  - `[DataLossPreventionPolicies <IMicrosoftGraphDataLossPreventionPolicy[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Name <String>]`: 
  - `[Policy <IMicrosoftGraphInformationProtectionPolicy>]`: informationProtectionPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Labels <IMicrosoftGraphInformationProtectionLabel[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Color <String>]`: The color that the UI should display for the label, if configured.
      - `[Description <String>]`: The admin-defined description for the label.
      - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.
      - `[Name <String>]`: The plaintext name of the label.
      - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Color <String>]`: The color that the user interface should display for the label, if configured.
        - `[Description <String>]`: The admin-defined description for the label.
        - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
        - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
        - `[Name <String>]`: The plaintext name of the label.
        - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
        - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
        - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.
      - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
      - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a UI.
  - `[SensitivityLabels <IMicrosoftGraphSensitivityLabel[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ApplicableTo <String>]`: sensitivityLabelTarget
    - `[ApplicationMode <String>]`: applicationMode
    - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
      - `[Id <String>]`: 
      - `[Name <String>]`: 
    - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Message <String>]`: 
      - `[SensitiveTypeIds <String[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[IsEndpointProtectionEnabled <Boolean?>]`: 
    - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
      - `[Name <String>]`: 
    - `[Name <String>]`: 
    - `[Priority <Int32?>]`: 
    - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
    - `[ToolTip <String>]`: 
  - `[SensitivityPolicySettings <IMicrosoftGraphSensitivityPolicySettings>]`: sensitivityPolicySettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ApplicableTo <String>]`: sensitivityLabelTarget
    - `[DowngradeSensitivityRequiresJustification <Boolean?>]`: 
    - `[HelpWebUrl <String>]`: 
    - `[IsMandatory <Boolean?>]`: 
  - `[ThreatAssessmentRequests <IMicrosoftGraphThreatAssessmentRequest[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Category <String>]`: threatCategory
    - `[ContentType <String>]`: threatAssessmentContentType
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ExpectedAssessment <String>]`: threatExpectedAssessment
    - `[RequestSource <String>]`: threatAssessmentRequestSource
    - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Message <String>]`: The result message for each threat assessment.
      - `[ResultType <String>]`: threatAssessmentResultType
    - `[Status <String>]`: threatAssessmentStatus

DATALOSSPREVENTIONPOLICIES <IMicrosoftGraphDataLossPreventionPolicy[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Name <String>]`: 

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AuthenticationCombinationConfigurationId <String>]`: key: id of authenticationCombinationConfiguration
  - `[AuthenticationContextClassReferenceId <String>]`: key: id of authenticationContextClassReference
  - `[AuthenticationEventListenerId <String>]`: key: id of authenticationEventListener
  - `[AuthenticationMethodConfigurationId <String>]`: key: id of authenticationMethodConfiguration
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthenticationMethodModeDetailId <String>]`: key: id of authenticationMethodModeDetail
  - `[AuthenticationMethodModes <String[]>]`: Usage: authenticationMethodModes={authenticationMethodModes}
  - `[AuthenticationStrengthPolicyId <String>]`: key: id of authenticationStrengthPolicy
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[B2CIdentityUserFlowId <String>]`: key: id of b2cIdentityUserFlow
  - `[B2XIdentityUserFlowId <String>]`: key: id of b2xIdentityUserFlow
  - `[BitlockerRecoveryKeyId <String>]`: key: id of bitlockerRecoveryKey
  - `[CertificateBasedAuthConfigurationId <String>]`: key: id of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[CommandId <String>]`: key: id of command
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[ConditionalAccessTemplateId <String>]`: key: id of conditionalAccessTemplate
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: key: tenantId of crossTenantAccessPolicyConfigurationPartner
  - `[CustomAuthenticationExtensionId <String>]`: key: id of customAuthenticationExtension
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
  - `[IdentityApiConnectorId <String>]`: key: id of identityApiConnector
  - `[IdentityProviderBaseId <String>]`: key: id of identityProviderBase
  - `[IdentityProviderId <String>]`: key: id of identityProvider
  - `[IdentityUserFlowAttributeAssignmentId <String>]`: key: id of identityUserFlowAttributeAssignment
  - `[IdentityUserFlowAttributeId <String>]`: key: id of identityUserFlowAttribute
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
  - `[UserFlowLanguageConfigurationId <String>]`: key: id of userFlowLanguageConfiguration
  - `[UserFlowLanguagePageId <String>]`: key: id of userFlowLanguagePage
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

POLICY <IMicrosoftGraphInformationProtectionPolicy>: informationProtectionPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Labels <IMicrosoftGraphInformationProtectionLabel[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Color <String>]`: The color that the UI should display for the label, if configured.
    - `[Description <String>]`: The admin-defined description for the label.
    - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.
    - `[Name <String>]`: The plaintext name of the label.
    - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Color <String>]`: The color that the user interface should display for the label, if configured.
      - `[Description <String>]`: The admin-defined description for the label.
      - `[Id <String>]`: The label ID is a globally unique identifier (GUID).
      - `[IsActive <Boolean?>]`: Indicates whether the label is active or not. Active labels should be hidden or disabled in user interfaces.
      - `[Name <String>]`: The plaintext name of the label.
      - `[Parent <IMicrosoftGraphParentLabelDetails>]`: parentLabelDetails
      - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
      - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a user interface.
    - `[Sensitivity <Int32?>]`: The sensitivity value of the label, where lower is less sensitive.
    - `[Tooltip <String>]`: The tooltip that should be displayed for the label in a UI.

SENSITIVITYLABELS <IMicrosoftGraphSensitivityLabel[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[ApplicationMode <String>]`: applicationMode
  - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
  - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Message <String>]`: 
    - `[SensitiveTypeIds <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsEndpointProtectionEnabled <Boolean?>]`: 
  - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
    - `[Name <String>]`: 
  - `[Name <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
  - `[ToolTip <String>]`: 

SENSITIVITYPOLICYSETTINGS <IMicrosoftGraphSensitivityPolicySettings>: sensitivityPolicySettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[DowngradeSensitivityRequiresJustification <Boolean?>]`: 
  - `[HelpWebUrl <String>]`: 
  - `[IsMandatory <Boolean?>]`: 

THREATASSESSMENTREQUESTS <IMicrosoftGraphThreatAssessmentRequest[]>: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Category <String>]`: threatCategory
  - `[ContentType <String>]`: threatAssessmentContentType
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ExpectedAssessment <String>]`: threatExpectedAssessment
  - `[RequestSource <String>]`: threatAssessmentRequestSource
  - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Message <String>]`: The result message for each threat assessment.
    - `[ResultType <String>]`: threatAssessmentResultType
  - `[Status <String>]`: threatAssessmentStatus

## RELATED LINKS

