---
external help file:
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
 [-AllowedToSignUpEmailBasedSubscriptions] [-AllowedToUseSspr] [-AllowEmailVerifiedUsersToJoinOrganization]
 [-BlockMsolPowerShell] [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-EnabledPreviewFeatures <String[]>] [-GuestUserRoleId <String>] [-Id <String>]
 [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPolicyAuthorizationPolicy -AuthorizationPolicyId <String>
 -BodyParameter <IMicrosoftGraphAuthorizationPolicy> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPolicyAuthorizationPolicy -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphAuthorizationPolicy> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPolicyAuthorizationPolicy -InputObject <IIdentitySignInsIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedToSignUpEmailBasedSubscriptions] [-AllowedToUseSspr] [-AllowEmailVerifiedUsersToJoinOrganization]
 [-BlockMsolPowerShell] [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-EnabledPreviewFeatures <String[]>] [-GuestUserRoleId <String>] [-Id <String>]
 [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property authorizationPolicy in policies

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

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

### -AllowedToSignUpEmailBasedSubscriptions
.

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

### -AllowedToUseSspr
.

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

### -AllowEmailVerifiedUsersToJoinOrganization
.

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

### -AuthorizationPolicyId
key: id of authorizationPolicy

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

### -BlockMsolPowerShell
.

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

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultUserRolePermissions
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
Description for this policy.

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
Display name for this policy.

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

### -EnabledPreviewFeatures
.

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

### -GuestUserRoleId
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

### -Id
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

### -PermissionGrantPolicyIdsAssignedToDefaultUserRole
.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuthorizationPolicy>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AllowEmailVerifiedUsersToJoinOrganization <Boolean?>]`: 
  - `[AllowedToSignUpEmailBasedSubscriptions <Boolean?>]`: 
  - `[AllowedToUseSspr <Boolean?>]`: 
  - `[BlockMsolPowerShell <Boolean?>]`: 
  - `[DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]`: defaultUserRolePermissions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedToCreateApps <Boolean?>]`: 
    - `[AllowedToCreateSecurityGroups <Boolean?>]`: 
    - `[AllowedToReadOtherUsers <Boolean?>]`: 
  - `[EnabledPreviewFeatures <String[]>]`: 
  - `[GuestUserRoleId <String>]`: 
  - `[PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]`: 

DEFAULTUSERROLEPERMISSIONS <IMicrosoftGraphDefaultUserRolePermissions>: defaultUserRolePermissions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedToCreateApps <Boolean?>]`: 
  - `[AllowedToCreateSecurityGroups <Boolean?>]`: 
  - `[AllowedToReadOtherUsers <Boolean?>]`: 

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[CertificateBasedAuthConfigurationId <String>]`: key: id of certificateBasedAuthConfiguration
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[DataLossPreventionPolicyId <String>]`: key: id of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: key: id of dataPolicyOperation
  - `[EmailAuthenticationMethodId <String>]`: key: id of emailAuthenticationMethod
  - `[Fido2AuthenticationMethodId <String>]`: key: id of fido2AuthenticationMethod
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[IdentityProviderId <String>]`: key: id of identityProvider
  - `[IdentityUserFlowId <String>]`: key: id of identityUserFlow
  - `[InformationProtectionLabelId <String>]`: key: id of informationProtectionLabel
  - `[InvitationId <String>]`: key: id of invitation
  - `[LongRunningOperationId <String>]`: key: id of longRunningOperation
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of microsoftAuthenticatorAuthenticationMethod
  - `[NamedLocationId <String>]`: key: id of namedLocation
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OrganizationId <String>]`: key: id of organization
  - `[PasswordAuthenticationMethodId <String>]`: key: id of passwordAuthenticationMethod
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionGrantConditionSetId <String>]`: key: id of permissionGrantConditionSet
  - `[PermissionGrantPolicyId <String>]`: key: id of permissionGrantPolicy
  - `[PhoneAuthenticationMethodId <String>]`: key: id of phoneAuthenticationMethod
  - `[RiskDetectionId <String>]`: key: id of riskDetection
  - `[RiskyUserHistoryItemId <String>]`: key: id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: id of riskyUser
  - `[SecurityQuestionAuthenticationMethodId <String>]`: key: id of securityQuestionAuthenticationMethod
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: key: id of sensitivityLabel
  - `[SoftwareOathAuthenticationMethodId <String>]`: key: id of softwareOathAuthenticationMethod
  - `[TemporaryAccessPassAuthenticationMethodId <String>]`: key: id of temporaryAccessPassAuthenticationMethod
  - `[ThreatAssessmentRequestId <String>]`: key: id of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: key: id of threatAssessmentResult
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[TrustFrameworkKeySetId <String>]`: key: id of trustFrameworkKeySet
  - `[TrustFrameworkPolicyId <String>]`: key: id of trustFrameworkPolicy
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

