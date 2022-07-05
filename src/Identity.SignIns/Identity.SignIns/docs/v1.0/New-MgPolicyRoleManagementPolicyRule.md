---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyrolemanagementpolicyrule
schema: 2.0.0
---

# New-MgPolicyRoleManagementPolicyRule

## SYNOPSIS
Create new navigation property to rules for policies

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Target <IMicrosoftGraphUnifiedRoleManagementPolicyRuleTarget>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgPolicyRoleManagementPolicyRule -UnifiedRoleManagementPolicyId <String>
 -BodyParameter <IMicrosoftGraphUnifiedRoleManagementPolicyRule> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgPolicyRoleManagementPolicyRule -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphUnifiedRoleManagementPolicyRule> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgPolicyRoleManagementPolicyRule -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Target <IMicrosoftGraphUnifiedRoleManagementPolicyRuleTarget>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to rules for policies

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
unifiedRoleManagementPolicyRule
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementPolicyRule
Parameter Sets: Create1, CreateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Target
unifiedRoleManagementPolicyRuleTarget
To construct, please use Get-Help -Online and see NOTES section for TARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementPolicyRuleTarget
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRoleManagementPolicyId
key: id of unifiedRoleManagementPolicy

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementPolicyRule

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUnifiedRoleManagementPolicyRule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUnifiedRoleManagementPolicyRule>: unifiedRoleManagementPolicyRule
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphUnifiedRoleManagementPolicyRuleTarget>]`: unifiedRoleManagementPolicyRuleTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Caller <String>]`: The type of caller that's the target of the policy rule. Allowed values are: None, Admin, EndUser.
    - `[EnforcedSettings <String[]>]`: The list of role settings that are enforced and cannot be overridden by child scopes. Use All for all settings.
    - `[InheritableSettings <String[]>]`: The list of role settings that can be inherited by child scopes. Use All for all settings.
    - `[Level <String>]`: The role assignment type that's the target of policy rule. Allowed values are: Eligibility, Assignment.
    - `[Operations <String[]>]`: The role management operations that are the target of the policy rule. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.
    - `[TargetObjects <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: 
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

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

TARGET <IMicrosoftGraphUnifiedRoleManagementPolicyRuleTarget>: unifiedRoleManagementPolicyRuleTarget
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Caller <String>]`: The type of caller that's the target of the policy rule. Allowed values are: None, Admin, EndUser.
  - `[EnforcedSettings <String[]>]`: The list of role settings that are enforced and cannot be overridden by child scopes. Use All for all settings.
  - `[InheritableSettings <String[]>]`: The list of role settings that can be inherited by child scopes. Use All for all settings.
  - `[Level <String>]`: The role assignment type that's the target of policy rule. Allowed values are: Eligibility, Assignment.
  - `[Operations <String[]>]`: The role management operations that are the target of the policy rule. Allowed values are: All, Activate, Deactivate, Assign, Update, Remove, Extend, Renew.
  - `[TargetObjects <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: 
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

## RELATED LINKS

