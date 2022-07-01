---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgriskyuserhistory
schema: 2.0.0
---

# Update-MgRiskyUserHistory

## SYNOPSIS
Update the navigation property history in identityProtection

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRiskyUserHistory -RiskyUserHistoryItemId <String> -RiskyUserId <String>
 [-Activity <IMicrosoftGraphRiskUserActivity1>] [-AdditionalProperties <Hashtable>]
 [-History <IMicrosoftGraphRiskyUserHistoryItem1[]>] [-Id <String>] [-InitiatedBy <String>] [-IsDeleted]
 [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>]
 [-RiskState <String>] [-UserDisplayName <String>] [-UserId <String>] [-UserPrincipalName <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgRiskyUserHistory -RiskyUserHistoryItemId <String> -RiskyUserId <String>
 -BodyParameter <IMicrosoftGraphRiskyUserHistoryItem1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgRiskyUserHistory -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphRiskyUserHistoryItem1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgRiskyUserHistory -InputObject <IIdentitySignInsIdentity>
 [-Activity <IMicrosoftGraphRiskUserActivity1>] [-AdditionalProperties <Hashtable>]
 [-History <IMicrosoftGraphRiskyUserHistoryItem1[]>] [-Id <String>] [-InitiatedBy <String>] [-IsDeleted]
 [-IsProcessing] [-RiskDetail <String>] [-RiskLastUpdatedDateTime <DateTime>] [-RiskLevel <String>]
 [-RiskState <String>] [-UserDisplayName <String>] [-UserId <String>] [-UserPrincipalName <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property history in identityProtection

## EXAMPLES

## PARAMETERS

### -Activity
riskUserActivity
To construct, please use Get-Help -Online and see NOTES section for ACTIVITY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskUserActivity1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
riskyUserHistoryItem
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -History
The activity related to user risk level change
To construct, please use Get-Help -Online and see NOTES section for HISTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem1[]
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

### -InitiatedBy
The id of actor that does the operation.

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

### -IsDeleted
Indicates whether the user is deleted.
Possible values are: true, false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsProcessing
Indicates whether a user's risky state is being processed by the backend.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### -RiskDetail
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

### -RiskLastUpdatedDateTime
The date and time that the risky user was last updated.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -RiskLevel
riskLevel

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

### -RiskState
riskState

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

### -RiskyUserHistoryItemId
key: id of riskyUserHistoryItem

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

### -RiskyUserId
key: id of riskyUser

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

### -UserDisplayName
Risky user display name.

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

### -UserId
The id of the user.

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

### -UserPrincipalName
Risky user principal name.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskyUserHistoryItem1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIVITY <IMicrosoftGraphRiskUserActivity1>: riskUserActivity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Detail <String>]`: 
  - `[EventTypes <String[]>]`: 
  - `[RiskEventTypes <String[]>]`: The type of risk event detected.

BODYPARAMETER <IMicrosoftGraphRiskyUserHistoryItem1>: riskyUserHistoryItem
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[History <IMicrosoftGraphRiskyUserHistoryItem1[]>]`: The activity related to user risk level change
  - `[IsDeleted <Boolean?>]`: Indicates whether the user is deleted. Possible values are: true, false.
  - `[IsProcessing <Boolean?>]`: Indicates whether a user's risky state is being processed by the backend.
  - `[RiskDetail <String>]`: 
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: Risky user display name.
  - `[UserPrincipalName <String>]`: Risky user principal name.
  - `[Id <String>]`: 
  - `[Activity <IMicrosoftGraphRiskUserActivity1>]`: riskUserActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Detail <String>]`: 
    - `[EventTypes <String[]>]`: 
    - `[RiskEventTypes <String[]>]`: The type of risk event detected.
  - `[InitiatedBy <String>]`: The id of actor that does the operation.
  - `[UserId <String>]`: The id of the user.

HISTORY <IMicrosoftGraphRiskyUserHistoryItem1[]>: The activity related to user risk level change
  - `[History <IMicrosoftGraphRiskyUserHistoryItem1[]>]`: The activity related to user risk level change
  - `[IsDeleted <Boolean?>]`: Indicates whether the user is deleted. Possible values are: true, false.
  - `[IsProcessing <Boolean?>]`: Indicates whether a user's risky state is being processed by the backend.
  - `[RiskDetail <String>]`: 
  - `[RiskLastUpdatedDateTime <DateTime?>]`: The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[UserDisplayName <String>]`: Risky user display name.
  - `[UserPrincipalName <String>]`: Risky user principal name.
  - `[Id <String>]`: 
  - `[Activity <IMicrosoftGraphRiskUserActivity1>]`: riskUserActivity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Detail <String>]`: 
    - `[EventTypes <String[]>]`: 
    - `[RiskEventTypes <String[]>]`: The type of risk event detected.
  - `[InitiatedBy <String>]`: The id of actor that does the operation.
  - `[UserId <String>]`: The id of the user.

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

## RELATED LINKS

