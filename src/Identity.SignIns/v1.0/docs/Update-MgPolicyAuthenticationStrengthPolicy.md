---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.signins/update-mgpolicyauthenticationstrengthpolicy
schema: 2.0.0
---

# Update-MgPolicyAuthenticationStrengthPolicy

## SYNOPSIS
Update the properties of an authenticationStrengthPolicy object.
You cannot update the allowed auth method combinations using this request.
To do so, use the Update allowed combinations action.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyAuthenticationStrengthPolicy -AuthenticationStrengthPolicyId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedCombinations <String[]>]
 [-CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-PolicyType <String>] [-RequirementsSatisfied <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPolicyAuthenticationStrengthPolicy -AuthenticationStrengthPolicyId <String>
 -BodyParameter <IMicrosoftGraphAuthenticationStrengthPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPolicyAuthenticationStrengthPolicy -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphAuthenticationStrengthPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPolicyAuthenticationStrengthPolicy -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-AllowedCombinations <String[]>]
 [-CombinationConfigurations <IMicrosoftGraphAuthenticationCombinationConfiguration[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-PolicyType <String>] [-RequirementsSatisfied <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an authenticationStrengthPolicy object.
You cannot update the allowed auth method combinations using this request.
To do so, use the Update allowed combinations action.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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

### -AllowedCombinations
A collection of authentication method modes that are required be used to satify this authentication strength.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationStrengthPolicyId
The unique identifier of authenticationStrengthPolicy

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

### -BodyParameter
authenticationStrengthPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CombinationConfigurations
Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
To construct, see NOTES section for COMBINATIONCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationCombinationConfiguration[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The datetime when this policy was created.

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
The human-readable description of this policy.

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
The human-readable display name of this policy.
Supports $filter (eq, ne, not , and in).

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

### -Id
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
The datetime when this policy was last modified.

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

### -PolicyType
authenticationStrengthPolicyType

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

### -RequirementsSatisfied
authenticationStrengthRequirements

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationStrengthPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthenticationStrengthPolicy>`: authenticationStrengthPolicy
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

`COMBINATIONCONFIGURATIONS <IMicrosoftGraphAuthenticationCombinationConfiguration[]>`: Settings that may be used to require specific types or instances of an authentication method to be used when authenticating with a specified combination of authentication methods.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppliesToCombinations <String[]>]`: Which authentication method combinations this configuration applies to. Must be an allowedCombinations object that's defined for the authenticationStrengthPolicy. The only possible value for fido2combinationConfigurations is 'fido2'.

`INPUTOBJECT <IIdentitySignInsIdentity>`: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: The unique identifier of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AuthenticationCombinationConfigurationId <String>]`: The unique identifier of authenticationCombinationConfiguration
  - `[AuthenticationContextClassReferenceId <String>]`: The unique identifier of authenticationContextClassReference
  - `[AuthenticationMethodConfigurationId <String>]`: The unique identifier of authenticationMethodConfiguration
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[AuthenticationMethodModeDetailId <String>]`: The unique identifier of authenticationMethodModeDetail
  - `[AuthenticationStrengthPolicyId <String>]`: The unique identifier of authenticationStrengthPolicy
  - `[B2XIdentityUserFlowId <String>]`: The unique identifier of b2xIdentityUserFlow
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[CertificateBasedAuthConfigurationId <String>]`: The unique identifier of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[ConditionalAccessPolicyId <String>]`: The unique identifier of conditionalAccessPolicy
  - `[ConditionalAccessTemplateId <String>]`: The unique identifier of conditionalAccessTemplate
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: The unique identifier of crossTenantAccessPolicyConfigurationPartner
  - `[DataPolicyOperationId <String>]`: The unique identifier of dataPolicyOperation
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EmailAuthenticationMethodId <String>]`: The unique identifier of emailAuthenticationMethod
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[Fido2AuthenticationMethodId <String>]`: The unique identifier of fido2AuthenticationMethod
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[IdentityApiConnectorId <String>]`: The unique identifier of identityApiConnector
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[IdentityProviderId <String>]`: The unique identifier of identityProvider
  - `[IdentityUserFlowAttributeAssignmentId <String>]`: The unique identifier of identityUserFlowAttributeAssignment
  - `[IdentityUserFlowAttributeId <String>]`: The unique identifier of identityUserFlowAttribute
  - `[InvitationId <String>]`: The unique identifier of invitation
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: The unique identifier of microsoftAuthenticatorAuthenticationMethod
  - `[NamedLocationId <String>]`: The unique identifier of namedLocation
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[PasswordAuthenticationMethodId <String>]`: The unique identifier of passwordAuthenticationMethod
  - `[PermissionGrantConditionSetId <String>]`: The unique identifier of permissionGrantConditionSet
  - `[PermissionGrantPolicyId <String>]`: The unique identifier of permissionGrantPolicy
  - `[PhoneAuthenticationMethodId <String>]`: The unique identifier of phoneAuthenticationMethod
  - `[RiskDetectionId <String>]`: The unique identifier of riskDetection
  - `[RiskyServicePrincipalHistoryItemId <String>]`: The unique identifier of riskyServicePrincipalHistoryItem
  - `[RiskyServicePrincipalId <String>]`: The unique identifier of riskyServicePrincipal
  - `[RiskyUserHistoryItemId <String>]`: The unique identifier of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: The unique identifier of riskyUser
  - `[ServicePrincipalRiskDetectionId <String>]`: The unique identifier of servicePrincipalRiskDetection
  - `[SoftwareOathAuthenticationMethodId <String>]`: The unique identifier of softwareOathAuthenticationMethod
  - `[TemporaryAccessPassAuthenticationMethodId <String>]`: The unique identifier of temporaryAccessPassAuthenticationMethod
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[UnifiedRoleManagementPolicyAssignmentId <String>]`: The unique identifier of unifiedRoleManagementPolicyAssignment
  - `[UnifiedRoleManagementPolicyId <String>]`: The unique identifier of unifiedRoleManagementPolicy
  - `[UnifiedRoleManagementPolicyRuleId <String>]`: The unique identifier of unifiedRoleManagementPolicyRule
  - `[UserFlowLanguageConfigurationId <String>]`: The unique identifier of userFlowLanguageConfiguration
  - `[UserFlowLanguagePageId <String>]`: The unique identifier of userFlowLanguagePage
  - `[UserId <String>]`: The unique identifier of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: The unique identifier of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

