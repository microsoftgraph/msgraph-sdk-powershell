---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicycrosstenantaccesspolicypartner
schema: 2.0.0
---

# Update-MgPolicyCrossTenantAccessPolicyPartner

## SYNOPSIS
Update the navigation property partners in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId <String>
 [-AdditionalProperties <Hashtable>]
 [-B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>] [-IsServiceProvider]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPolicyCrossTenantAccessPolicyPartner -CrossTenantAccessPolicyConfigurationPartnerTenantId <String>
 -BodyParameter <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPolicyCrossTenantAccessPolicyPartner -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPolicyCrossTenantAccessPolicyPartner -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>]
 [-B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]
 [-InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>] [-IsServiceProvider]
 [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property partners in policies

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

### -B2BCollaborationInbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BCOLLABORATIONINBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BCollaborationOutbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BCOLLABORATIONOUTBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BDirectConnectInbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BDIRECTCONNECTINBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -B2BDirectConnectOutbound
crossTenantAccessPolicyB2BSetting
To construct, please use Get-Help -Online and see NOTES section for B2BDIRECTCONNECTOUTBOUND properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyB2BSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
crossTenantAccessPolicyConfigurationPartner
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CrossTenantAccessPolicyConfigurationPartnerTenantId
key: tenantId of crossTenantAccessPolicyConfigurationPartner

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

### -InboundTrust
crossTenantAccessPolicyInboundTrust
To construct, please use Get-Help -Online and see NOTES section for INBOUNDTRUST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyInboundTrust
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

### -IsServiceProvider
Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.

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

### -TenantId
The tenant identifier for the partner Azure AD organization.
Read-only.
Key.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


B2BCOLLABORATIONINBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BCOLLABORATIONOUTBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BDIRECTCONNECTINBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

B2BDIRECTCONNECTOUTBOUND <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>: crossTenantAccessPolicyB2BSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
    - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
      - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
      - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
  - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration

BODYPARAMETER <IMicrosoftGraphCrossTenantAccessPolicyConfigurationPartner>: crossTenantAccessPolicyConfigurationPartner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[B2BCollaborationInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessType <String>]`: crossTenantAccessPolicyTargetConfigurationAccessType
      - `[Targets <IMicrosoftGraphCrossTenantAccessPolicyTarget[]>]`: Specifies whether to target users, groups, or applications with this rule.
        - `[Target <String>]`: The unique identifier of the user, group, or application; one of the following keywords: AllUsers and AllApplications; or for targets that are applications, you may use reserved values.
        - `[TargetType <String>]`: crossTenantAccessPolicyTargetType
    - `[UsersAndGroups <IMicrosoftGraphCrossTenantAccessPolicyTargetConfiguration>]`: crossTenantAccessPolicyTargetConfiguration
  - `[B2BCollaborationOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectInbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[B2BDirectConnectOutbound <IMicrosoftGraphCrossTenantAccessPolicyB2BSetting>]`: crossTenantAccessPolicyB2BSetting
  - `[InboundTrust <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>]`: crossTenantAccessPolicyInboundTrust
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
    - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
    - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.
  - `[IsServiceProvider <Boolean?>]`: Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.
  - `[TenantId <String>]`: The tenant identifier for the partner Azure AD organization. Read-only. Key.

INBOUNDTRUST <IMicrosoftGraphCrossTenantAccessPolicyInboundTrust>: crossTenantAccessPolicyInboundTrust
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsCompliantDeviceAccepted <Boolean?>]`: Specifies whether compliant devices from external Azure AD organizations are trusted.
  - `[IsHybridAzureAdJoinedDeviceAccepted <Boolean?>]`: Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
  - `[IsMfaAccepted <Boolean?>]`: Specifies whether MFA from external Azure AD organizations is trusted.

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

