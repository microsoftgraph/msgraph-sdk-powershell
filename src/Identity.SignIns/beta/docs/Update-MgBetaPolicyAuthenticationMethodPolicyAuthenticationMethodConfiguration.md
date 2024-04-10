---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/update-mgbetapolicyauthenticationmethodpolicyauthenticationmethodconfiguration
schema: 2.0.0
---

# Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration

## SYNOPSIS
Update the navigation property authenticationMethodConfigurations in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration
 -AuthenticationMethodConfigurationId <String> [-AdditionalProperties <Hashtable>]
 [-ExcludeTargets <IMicrosoftGraphExcludeTarget[]>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-State <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration
 -AuthenticationMethodConfigurationId <String>
 -BodyParameter <IMicrosoftGraphAuthenticationMethodConfiguration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration
 -InputObject <IIdentitySignInsIdentity> -BodyParameter <IMicrosoftGraphAuthenticationMethodConfiguration>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration
 -InputObject <IIdentitySignInsIdentity> [-AdditionalProperties <Hashtable>]
 [-ExcludeTargets <IMicrosoftGraphExcludeTarget[]>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-State <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authenticationMethodConfigurations in policies

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.emailAuthenticationMethodConfiguration"
	AllowExternalIdToUseEmailOtp = "disabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.fido2AuthenticationMethodConfiguration"
	State = "enabled"
	IsAttestationEnforced = "true"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 4 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.passwordlessMicrosoftAuthenticatorAuthenticationMethodConfiguration"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 5 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.smsAuthenticationMethodConfiguration"
	Id = "Sms"
	State = "enabled"
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 6 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration"
	IsUsableOnce = $true
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
```



### -------------------------- EXAMPLE 7 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration"
	Id = "X509Certificate"
	State = "enabled"
	CertificateUserBindings = @(
	)
	IncludeTargets = @(
	)
}
Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params
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

### -AuthenticationMethodConfigurationId
The unique identifier of authenticationMethodConfiguration

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
authenticationMethodConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationMethodConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExcludeTargets
Groups of users that are excluded from a policy.
To construct, see NOTES section for EXCLUDETARGETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExcludeTarget[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
authenticationMethodState

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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationMethodConfiguration

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationMethodConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthenticationMethodConfiguration>`: authenticationMethodConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExcludeTargets <IMicrosoftGraphExcludeTarget[]>]`: Groups of users that are excluded from a policy.
    - `[Id <String>]`: The object identifier of a Microsoft Entra group.
    - `[TargetType <String>]`: authenticationMethodTargetType
  - `[State <String>]`: authenticationMethodState

`EXCLUDETARGETS <IMicrosoftGraphExcludeTarget[]>`: Groups of users that are excluded from a policy.
  - `[Id <String>]`: The object identifier of a Microsoft Entra group.
  - `[TargetType <String>]`: authenticationMethodTargetType

`INPUTOBJECT <IIdentitySignInsIdentity>`: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: The unique identifier of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AuthenticationCombinationConfigurationId <String>]`: The unique identifier of authenticationCombinationConfiguration
  - `[AuthenticationConditionApplicationAppId <String>]`: The unique identifier of authenticationConditionApplication
  - `[AuthenticationContextClassReferenceId <String>]`: The unique identifier of authenticationContextClassReference
  - `[AuthenticationEventListenerId <String>]`: The unique identifier of authenticationEventListener
  - `[AuthenticationEventsFlowId <String>]`: The unique identifier of authenticationEventsFlow
  - `[AuthenticationMethodConfigurationId <String>]`: The unique identifier of authenticationMethodConfiguration
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[AuthenticationMethodModeDetailId <String>]`: The unique identifier of authenticationMethodModeDetail
  - `[AuthenticationMethodModes <String[]>]`: Usage: authenticationMethodModes={authenticationMethodModes}
  - `[AuthenticationStrengthPolicyId <String>]`: The unique identifier of authenticationStrengthPolicy
  - `[AuthorizationPolicyId <String>]`: The unique identifier of authorizationPolicy
  - `[B2CIdentityUserFlowId <String>]`: The unique identifier of b2cIdentityUserFlow
  - `[B2XIdentityUserFlowId <String>]`: The unique identifier of b2xIdentityUserFlow
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[CertificateBasedAuthConfigurationId <String>]`: The unique identifier of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: The unique identifier of claimsMappingPolicy
  - `[ConditionalAccessPolicyId <String>]`: The unique identifier of conditionalAccessPolicy
  - `[ConditionalAccessTemplateId <String>]`: The unique identifier of conditionalAccessTemplate
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: The unique identifier of crossTenantAccessPolicyConfigurationPartner
  - `[CustomAuthenticationExtensionId <String>]`: The unique identifier of customAuthenticationExtension
  - `[DataLossPreventionPolicyId <String>]`: The unique identifier of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: The unique identifier of dataPolicyOperation
  - `[DefaultUserRoleOverrideId <String>]`: The unique identifier of defaultUserRoleOverride
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EmailAuthenticationMethodId <String>]`: The unique identifier of emailAuthenticationMethod
  - `[FeatureRolloutPolicyId <String>]`: The unique identifier of featureRolloutPolicy
  - `[Fido2AuthenticationMethodId <String>]`: The unique identifier of fido2AuthenticationMethod
  - `[GroupId <String>]`: The unique identifier of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: The unique identifier of homeRealmDiscoveryPolicy
  - `[IdentityApiConnectorId <String>]`: The unique identifier of identityApiConnector
  - `[IdentityProviderBaseId <String>]`: The unique identifier of identityProviderBase
  - `[IdentityProviderId <String>]`: The unique identifier of identityProvider
  - `[IdentityUserFlowAttributeAssignmentId <String>]`: The unique identifier of identityUserFlowAttributeAssignment
  - `[IdentityUserFlowAttributeId <String>]`: The unique identifier of identityUserFlowAttribute
  - `[IdentityUserFlowId <String>]`: The unique identifier of identityUserFlow
  - `[InformationProtectionLabelId <String>]`: The unique identifier of informationProtectionLabel
  - `[InvitationId <String>]`: The unique identifier of invitation
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: The unique identifier of microsoftAuthenticatorAuthenticationMethod
  - `[MobilityManagementPolicyId <String>]`: The unique identifier of mobilityManagementPolicy
  - `[MultiTenantOrganizationMemberId <String>]`: The unique identifier of multiTenantOrganizationMember
  - `[NamedLocationId <String>]`: The unique identifier of namedLocation
  - `[OAuth2PermissionGrantId <String>]`: The unique identifier of oAuth2PermissionGrant
  - `[OrganizationId <String>]`: The unique identifier of organization
  - `[PasswordAuthenticationMethodId <String>]`: The unique identifier of passwordAuthenticationMethod
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: The unique identifier of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionGrantConditionSetId <String>]`: The unique identifier of permissionGrantConditionSet
  - `[PermissionGrantPolicyId <String>]`: The unique identifier of permissionGrantPolicy
  - `[PhoneAuthenticationMethodId <String>]`: The unique identifier of phoneAuthenticationMethod
  - `[PlatformCredentialAuthenticationMethodId <String>]`: The unique identifier of platformCredentialAuthenticationMethod
  - `[RiskDetectionId <String>]`: The unique identifier of riskDetection
  - `[RiskyServicePrincipalHistoryItemId <String>]`: The unique identifier of riskyServicePrincipalHistoryItem
  - `[RiskyServicePrincipalId <String>]`: The unique identifier of riskyServicePrincipal
  - `[RiskyUserHistoryItemId <String>]`: The unique identifier of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: The unique identifier of riskyUser
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: The unique identifier of sensitivityLabel
  - `[ServicePrincipalCreationConditionSetId <String>]`: The unique identifier of servicePrincipalCreationConditionSet
  - `[ServicePrincipalCreationPolicyId <String>]`: The unique identifier of servicePrincipalCreationPolicy
  - `[ServicePrincipalRiskDetectionId <String>]`: The unique identifier of servicePrincipalRiskDetection
  - `[SoftwareOathAuthenticationMethodId <String>]`: The unique identifier of softwareOathAuthenticationMethod
  - `[TemporaryAccessPassAuthenticationMethodId <String>]`: The unique identifier of temporaryAccessPassAuthenticationMethod
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[TokenIssuancePolicyId <String>]`: The unique identifier of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: The unique identifier of tokenLifetimePolicy
  - `[TrustFrameworkKeySetId <String>]`: The unique identifier of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: The unique identifier of trustFrameworkPolicy
  - `[UnifiedRoleManagementPolicyAssignmentId <String>]`: The unique identifier of unifiedRoleManagementPolicyAssignment
  - `[UnifiedRoleManagementPolicyId <String>]`: The unique identifier of unifiedRoleManagementPolicy
  - `[UnifiedRoleManagementPolicyRuleId <String>]`: The unique identifier of unifiedRoleManagementPolicyRule
  - `[UserFlowLanguageConfigurationId <String>]`: The unique identifier of userFlowLanguageConfiguration
  - `[UserFlowLanguagePageId <String>]`: The unique identifier of userFlowLanguagePage
  - `[UserId <String>]`: The unique identifier of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: The unique identifier of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

