---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mguserauthenticationwindowhello
schema: 2.0.0
---

# Update-MgUserAuthenticationWindowHello

## SYNOPSIS
Update the navigation property windowsHelloForBusinessMethods in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserAuthenticationWindowHello -UserId <String> -WindowsHelloForBusinessAuthenticationMethodId <String>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Device <IMicrosoftGraphDevice1>]
 [-DisplayName <String>] [-Id <String>] [-KeyStrength <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update1
```
Update-MgUserAuthenticationWindowHello -UserId <String> -WindowsHelloForBusinessAuthenticationMethodId <String>
 -BodyParameter <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod1> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserAuthenticationWindowHello -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Device <IMicrosoftGraphDevice1>]
 [-DisplayName <String>] [-Id <String>] [-KeyStrength <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserAuthenticationWindowHello -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod1> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property windowsHelloForBusinessMethods in users

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
windowsHelloForBusinessAuthenticationMethod
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod1
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time that this Windows Hello for Business key was registered.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Device
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for DEVICE properties and create a hash table.

```yaml
Type: IMicrosoftGraphDevice1
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the device on which Windows Hello for Business is registered

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeyStrength
authenticationMethodKeyStrength

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: SwitchParameter
Parameter Sets: (All)
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
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WindowsHelloForBusinessAuthenticationMethodId
key: id of windowsHelloForBusinessAuthenticationMethod

```yaml
Type: String
Parameter Sets: UpdateExpanded1, Update1
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod1
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod1>: windowsHelloForBusinessAuthenticationMethod
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time that this Windows Hello for Business key was registered.
  - `[Device <IMicrosoftGraphDevice1>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. default is true.
    - `[AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]`: For internal use only. Not nullable.
      - `[IdentityProvider <String>]`: For internal use only
      - `[Key <Byte[]>]`: For internal use only
      - `[Type <Int32?>]`: For internal use only
    - `[ApproximateLastSignInDateTime <DateTime?>]`: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[ComplianceExpirationDateTime <DateTime?>]`: The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DeviceId <String>]`: Identifier set by Azure Device Registration Service at the time of registration.
    - `[DeviceMetadata <String>]`: For internal use only. Set to null.
    - `[DeviceVersion <Int32?>]`: For internal use only.
    - `[DisplayName <String>]`: The display name for the device. Required.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the device. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[IsCompliant <Boolean?>]`: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
    - `[IsManaged <Boolean?>]`: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
    - `[MdmAppId <String>]`: Application identifier used to register device into MDM. Read-only. Supports $filter.
    - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[OnPremisesLastSyncDateTime <DateTime?>]`: The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only.
    - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only.
    - `[OperatingSystem <String>]`: The type of operating system on the device. Required.
    - `[OperatingSystemVersion <String>]`: Operating system version of the device. Required.
    - `[PhysicalIds <String[]>]`: For internal use only. Not nullable.
    - `[ProfileType <String>]`: The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
    - `[RegisteredOwners <IMicrosoftGraphDirectoryObject[]>]`: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
    - `[RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]`: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
    - `[SystemLabels <String[]>]`: List of labels applied to the device by the system.
    - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. This operation is transitive.
    - `[TrustType <String>]`: Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory
  - `[DisplayName <String>]`: The name of the device on which Windows Hello for Business is registered
  - `[KeyStrength <String>]`: authenticationMethodKeyStrength

DEVICE <IMicrosoftGraphDevice1>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. default is true.
  - `[AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]`: For internal use only. Not nullable.
    - `[IdentityProvider <String>]`: For internal use only
    - `[Key <Byte[]>]`: For internal use only
    - `[Type <Int32?>]`: For internal use only
  - `[ApproximateLastSignInDateTime <DateTime?>]`: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[ComplianceExpirationDateTime <DateTime?>]`: The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DeviceId <String>]`: Identifier set by Azure Device Registration Service at the time of registration.
  - `[DeviceMetadata <String>]`: For internal use only. Set to null.
  - `[DeviceVersion <Int32?>]`: For internal use only.
  - `[DisplayName <String>]`: The display name for the device. Required.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the device. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[IsCompliant <Boolean?>]`: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  - `[IsManaged <Boolean?>]`: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  - `[MdmAppId <String>]`: Application identifier used to register device into MDM. Read-only. Supports $filter.
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only.
  - `[OperatingSystem <String>]`: The type of operating system on the device. Required.
  - `[OperatingSystemVersion <String>]`: Operating system version of the device. Required.
  - `[PhysicalIds <String[]>]`: For internal use only. Not nullable.
  - `[ProfileType <String>]`: The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
  - `[RegisteredOwners <IMicrosoftGraphDirectoryObject[]>]`: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
  - `[RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]`: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
  - `[SystemLabels <String[]>]`: List of labels applied to the device by the system.
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. This operation is transitive.
  - `[TrustType <String>]`: Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AuthenticationContextClassReferenceId <String>]`: key: id of authenticationContextClassReference
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[BitlockerRecoveryKeyId <String>]`: key: id of bitlockerRecoveryKey
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[DataLossPreventionPolicyId <String>]`: key: id of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: key: id of dataPolicyOperation
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EmailAuthenticationMethodId <String>]`: key: id of emailAuthenticationMethod
  - `[FeatureRolloutPolicyId <String>]`: key: id of featureRolloutPolicy
  - `[Fido2AuthenticationMethodId <String>]`: key: id of fido2AuthenticationMethod
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[IdentityProviderId <String>]`: key: id of identityProvider
  - `[IdentityUserFlowId <String>]`: key: id of identityUserFlow
  - `[InformationProtectionLabelId <String>]`: key: id of informationProtectionLabel
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
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: key: id of sensitivityLabel
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
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

## RELATED LINKS
