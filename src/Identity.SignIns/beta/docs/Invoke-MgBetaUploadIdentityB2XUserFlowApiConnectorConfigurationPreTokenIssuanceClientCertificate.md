---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/invoke-mgbetauploadidentityb2xuserflowapiconnectorconfigurationpretokenissuanceclientcertificate
schema: 2.0.0
---

# Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate

## SYNOPSIS
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

## SYNTAX

### UploadExpanded (Default)
```
Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate
 -B2XIdentityUserFlowId <String> [-AdditionalProperties <Hashtable>] [-Password <String>]
 [-Pkcs12Value <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Upload
```
Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate
 -B2XIdentityUserFlowId <String>
 -BodyParameter <IPathsN6Lkm6IdentityB2XuserflowsB2XidentityuserflowIdApiconnectorconfigurationPretokenissuanceMicrosoftGraphUploadclientcertificatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UploadViaIdentity
```
Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate
 -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IPathsN6Lkm6IdentityB2XuserflowsB2XidentityuserflowIdApiconnectorconfigurationPretokenissuanceMicrosoftGraphUploadclientcertificatePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UploadViaIdentityExpanded
```
Invoke-MgBetaUploadIdentityB2XUserFlowApiConnectorConfigurationPreTokenIssuanceClientCertificate
 -InputObject <IIdentitySignInsIdentity> [-AdditionalProperties <Hashtable>] [-Password <String>]
 [-Pkcs12Value <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration.
The input is a base-64 encoded value of the PKCS 12 certificate contents.
This method returns an apiConnector.

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
Parameter Sets: UploadExpanded, UploadViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2XIdentityUserFlowId
The unique identifier of b2xIdentityUserFlow

```yaml
Type: System.String
Parameter Sets: Upload, UploadExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsN6Lkm6IdentityB2XuserflowsB2XidentityuserflowIdApiconnectorconfigurationPretokenissuanceMicrosoftGraphUploadclientcertificatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Upload, UploadViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentitySignInsIdentity
Parameter Sets: UploadViaIdentity, UploadViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Password
.

```yaml
Type: System.String
Parameter Sets: UploadExpanded, UploadViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Pkcs12Value
.

```yaml
Type: System.String
Parameter Sets: UploadExpanded, UploadViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsN6Lkm6IdentityB2XuserflowsB2XidentityuserflowIdApiconnectorconfigurationPretokenissuanceMicrosoftGraphUploadclientcertificatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentityApiConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsN6Lkm6IdentityB2XuserflowsB2XidentityuserflowIdApiconnectorconfigurationPretokenissuanceMicrosoftGraphUploadclientcertificatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Password <String>]`: 
  - `[Pkcs12Value <String>]`: 

`INPUTOBJECT <IIdentitySignInsIdentity>`: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: The unique identifier of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: The unique identifier of appManagementPolicy
  - `[AuthenticationCombinationConfigurationId <String>]`: The unique identifier of authenticationCombinationConfiguration
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

