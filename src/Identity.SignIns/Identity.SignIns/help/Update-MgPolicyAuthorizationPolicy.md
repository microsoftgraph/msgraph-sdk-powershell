---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyauthorizationpolicy
schema: 2.0.0
---

# Update-MgPolicyAuthorizationPolicy

## SYNOPSIS
Update the navigation property authorizationPolicy in policies

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyAuthorizationPolicy -AuthorizationPolicyId <String> [-AdditionalProperties <Hashtable>]
 [-AllowEmailVerifiedUsersToJoinOrganization] [-AllowInvitesFrom <String>]
 [-AllowedToSignUpEmailBasedSubscriptions] [-AllowedToUseSspr] [-BlockMsolPowerShell]
 [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-EnabledPreviewFeatures <String[]>]
 [-GuestUserRoleId <String>] [-Id <String>] [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPolicyAuthorizationPolicy -AuthorizationPolicyId <String>
 -BodyParameter <IMicrosoftGraphAuthorizationPolicy> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPolicyAuthorizationPolicy -InputObject <IIdentitySignInsIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowEmailVerifiedUsersToJoinOrganization] [-AllowInvitesFrom <String>]
 [-AllowedToSignUpEmailBasedSubscriptions] [-AllowedToUseSspr] [-BlockMsolPowerShell]
 [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-EnabledPreviewFeatures <String[]>]
 [-GuestUserRoleId <String>] [-Id <String>] [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPolicyAuthorizationPolicy -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphAuthorizationPolicy> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authorizationPolicy in policies

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedToSignUpEmailBasedSubscriptions
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedToUseSspr
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowEmailVerifiedUsersToJoinOrganization
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowInvitesFrom
allowInvitesFrom

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationPolicyId
key: id of authorizationPolicy

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockMsolPowerShell
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAuthorizationPolicy
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultUserRolePermissions
defaultUserRolePermissions
To construct, see NOTES section for DEFAULTUSERROLEPERMISSIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDefaultUserRolePermissions
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for this policy.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for this policy.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnabledPreviewFeatures
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestUserRoleId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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
Type: IIdentitySignInsIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionGrantPolicyIdsAssignedToDefaultUserRole
.

```yaml
Type: String[]
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
Type: SwitchParameter
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
Type: SwitchParameter
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphAuthorizationPolicy\>: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Description \<String\>\]: Description for this policy.
  \[DisplayName \<String\>\]: Display name for this policy.
  \[DeletedDateTime \<DateTime?\>\]: 
  \[Id \<String\>\]: Read-only.
  \[AllowEmailVerifiedUsersToJoinOrganization \<Boolean?\>\]: 
  \[AllowInvitesFrom \<String\>\]: allowInvitesFrom
  \[AllowedToSignUpEmailBasedSubscriptions \<Boolean?\>\]: 
  \[AllowedToUseSspr \<Boolean?\>\]: 
  \[BlockMsolPowerShell \<Boolean?\>\]: 
  \[DefaultUserRolePermissions \<IMicrosoftGraphDefaultUserRolePermissions\>\]: defaultUserRolePermissions
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AllowedToCreateApps \<Boolean?\>\]: 
    \[AllowedToCreateSecurityGroups \<Boolean?\>\]: 
    \[AllowedToReadOtherUsers \<Boolean?\>\]: 
  \[EnabledPreviewFeatures \<String\[\]\>\]: 
  \[GuestUserRoleId \<String\>\]: 
  \[PermissionGrantPolicyIdsAssignedToDefaultUserRole \<String\[\]\>\]: 

DEFAULTUSERROLEPERMISSIONS \<IMicrosoftGraphDefaultUserRolePermissions\>: defaultUserRolePermissions
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AllowedToCreateApps \<Boolean?\>\]: 
  \[AllowedToCreateSecurityGroups \<Boolean?\>\]: 
  \[AllowedToReadOtherUsers \<Boolean?\>\]: 

INPUTOBJECT \<IIdentitySignInsIdentity\>: Identity Parameter
  \[ActivityBasedTimeoutPolicyId \<String\>\]: key: id of activityBasedTimeoutPolicy
  \[AuthenticationContextClassReferenceId \<String\>\]: key: id of authenticationContextClassReference
  \[AuthenticationMethodId \<String\>\]: key: id of authenticationMethod
  \[AuthorizationPolicyId \<String\>\]: key: id of authorizationPolicy
  \[ClaimsMappingPolicyId \<String\>\]: key: id of claimsMappingPolicy
  \[ConditionalAccessPolicyId \<String\>\]: key: id of conditionalAccessPolicy
  \[DataLossPreventionPolicyId \<String\>\]: key: id of dataLossPreventionPolicy
  \[DataPolicyOperationId \<String\>\]: key: id of dataPolicyOperation
  \[EmailAuthenticationMethodId \<String\>\]: key: id of emailAuthenticationMethod
  \[Fido2AuthenticationMethodId \<String\>\]: key: id of fido2AuthenticationMethod
  \[HomeRealmDiscoveryPolicyId \<String\>\]: key: id of homeRealmDiscoveryPolicy
  \[IdentityProviderId \<String\>\]: key: id of identityProvider
  \[IdentityUserFlowId \<String\>\]: key: id of identityUserFlow
  \[InformationProtectionLabelId \<String\>\]: key: id of informationProtectionLabel
  \[LongRunningOperationId \<String\>\]: key: id of longRunningOperation
  \[NamedLocationId \<String\>\]: key: id of namedLocation
  \[OAuth2PermissionGrantId \<String\>\]: key: id of oAuth2PermissionGrant
  \[OrganizationId \<String\>\]: key: id of organization
  \[PasswordAuthenticationMethodId \<String\>\]: key: id of passwordAuthenticationMethod
  \[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId \<String\>\]: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  \[PermissionGrantConditionSetId \<String\>\]: key: id of permissionGrantConditionSet
  \[PermissionGrantPolicyId \<String\>\]: key: id of permissionGrantPolicy
  \[PhoneAuthenticationMethodId \<String\>\]: key: id of phoneAuthenticationMethod
  \[PrivateLinkResourcePolicyId \<String\>\]: key: id of privateLinkResourcePolicy
  \[RiskDetectionId \<String\>\]: key: id of riskDetection
  \[RiskyUserHistoryItemId \<String\>\]: key: id of riskyUserHistoryItem
  \[RiskyUserId \<String\>\]: key: id of riskyUser
  \[SensitivityLabelId \<String\>\]: key: id of sensitivityLabel
  \[SensitivityLabelId1 \<String\>\]: key: id of sensitivityLabel
  \[ThreatAssessmentRequestId \<String\>\]: key: id of threatAssessmentRequest
  \[ThreatAssessmentResultId \<String\>\]: key: id of threatAssessmentResult
  \[TokenIssuancePolicyId \<String\>\]: key: id of tokenIssuancePolicy
  \[TokenLifetimePolicyId \<String\>\]: key: id of tokenLifetimePolicy
  \[TrustFrameworkKeySetId \<String\>\]: key: id of trustFrameworkKeySet
  \[TrustFrameworkPolicyId \<String\>\]: key: id of trustFrameworkPolicy
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyauthorizationpolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyauthorizationpolicy)

