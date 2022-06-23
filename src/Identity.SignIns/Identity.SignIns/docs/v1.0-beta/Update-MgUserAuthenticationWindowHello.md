---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mguserauthenticationwindowhello
schema: 2.0.0
---

# Update-MgUserAuthenticationWindowHello

## SYNOPSIS
Represents the Windows Hello for Business authentication method registered to a user for authentication.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserAuthenticationWindowHello -UserId <String>
 -WindowsHelloForBusinessAuthenticationMethodId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Device <IMicrosoftGraphDevice>] [-DisplayName <String>] [-Id <String>]
 [-KeyStrength <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserAuthenticationWindowHello -UserId <String>
 -WindowsHelloForBusinessAuthenticationMethodId <String>
 -BodyParameter <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserAuthenticationWindowHello -InputObject <IIdentitySignInsIdentity>
 -BodyParameter <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserAuthenticationWindowHello -InputObject <IIdentitySignInsIdentity>
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Device <IMicrosoftGraphDevice>]
 [-DisplayName <String>] [-Id <String>] [-KeyStrength <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Represents the Windows Hello for Business authentication method registered to a user for authentication.

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

### -BodyParameter
windowsHelloForBusinessAuthenticationMethod
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod
Parameter Sets: Update, UpdateViaIdentity
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
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Device
device
To construct, please use Get-Help -Online and see NOTES section for DEVICE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDevice
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -KeyStrength
authenticationMethodKeyStrength

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

### -WindowsHelloForBusinessAuthenticationMethodId
key: id of windowsHelloForBusinessAuthenticationMethod

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

### Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsHelloForBusinessAuthenticationMethod>: windowsHelloForBusinessAuthenticationMethod
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date and time that this Windows Hello for Business key was registered.
  - `[Device <IMicrosoftGraphDevice>]`: device
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: Read-only.
    - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. Required. Default is true.  Supports $filter (eq, ne, not, in). Only callers in Global Administrator and Cloud Device Administrator roles can set this property.
    - `[AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]`: For internal use only. Not nullable. Supports $filter (eq, not, ge, le).
      - `[IdentityProvider <String>]`: For internal use only
      - `[Key <Byte[]>]`: For internal use only
      - `[Type <Int32?>]`: For internal use only
    - `[ApproximateLastSignInDateTime <DateTime?>]`: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, and eq on null values) and $orderBy.
    - `[Commands <IMicrosoftGraphCommand[]>]`: Set of commands sent to this device.
      - `[Id <String>]`: Read-only.
      - `[AppServiceName <String>]`: 
      - `[Error <String>]`: 
      - `[PackageFamilyName <String>]`: 
      - `[Payload <IMicrosoftGraphPayloadRequest>]`: payloadRequest
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[PermissionTicket <String>]`: 
      - `[PostBackUri <String>]`: 
      - `[Responsepayload <IMicrosoftGraphPayloadResponse>]`: payloadResponse
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
      - `[Status <String>]`: 
      - `[Type <String>]`: 
    - `[ComplianceExpirationDateTime <DateTime?>]`: The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DeviceCategory <String>]`: User-defined property set by Intune to automatically add devices to groups and simplify managing devices.
    - `[DeviceId <String>]`: Unique identifier set by Azure Device Registration Service at the time of registration. Supports $filter (eq, ne, not, startsWith).
    - `[DeviceMetadata <String>]`: For internal use only. Set to null.
    - `[DeviceOwnership <String>]`: Ownership of the device. This property is set by Intune. Possible values are: unknown, company, personal.
    - `[DeviceVersion <Int32?>]`: For internal use only.
    - `[DisplayName <String>]`: The display name for the device. Required. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
    - `[DomainName <String>]`: The on-premises domain name of Hybrid Azure AD joined devices. This property is set by Intune.
    - `[EnrollmentProfileName <String>]`: Enrollment profile applied to the device. For example, Apple Device Enrollment Profile, Device enrollment - Corporate device identifiers, or Windows Autopilot profile name. This property is set by Intune.
    - `[EnrollmentType <String>]`: Enrollment type of the device. This property is set by Intune. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement.
    - `[ExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]`: onPremisesExtensionAttributes
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExtensionAttribute1 <String>]`: First customizable extension attribute.
      - `[ExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
      - `[ExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
      - `[ExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
      - `[ExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
      - `[ExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
      - `[ExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
      - `[ExtensionAttribute2 <String>]`: Second customizable extension attribute.
      - `[ExtensionAttribute3 <String>]`: Third customizable extension attribute.
      - `[ExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
      - `[ExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
      - `[ExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
      - `[ExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
      - `[ExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
      - `[ExtensionAttribute9 <String>]`: Ninth customizable extension attribute.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the device. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[Hostnames <String[]>]`: List of hostNames for the device.
    - `[IsCompliant <Boolean?>]`: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).
    - `[IsManaged <Boolean?>]`: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).
    - `[IsRooted <Boolean?>]`: true if device is rooted; false if device is jail-broken. This can only be updated by Intune.
    - `[Kind <String>]`: Form factor of device. Only returned if user signs in with a Microsoft account as part of Project Rome.
    - `[ManagementType <String>]`: Management channel of the device.  This property is set by Intune. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.
    - `[Manufacturer <String>]`: Manufacturer of the device. Read-only.
    - `[MdmAppId <String>]`: Application identifier used to register device into MDM. Read-only. Supports $filter (eq, ne, not, startsWith).
    - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Model <String>]`: Model of the device. Read-only.
    - `[Name <String>]`: Friendly name of a device. Only returned if user signs in with a Microsoft account as part of Project Rome.
    - `[OnPremisesLastSyncDateTime <DateTime?>]`: The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only. Supports $filter (eq, ne, not, ge, le, in).
    - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).
    - `[OperatingSystem <String>]`: The type of operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).
    - `[OperatingSystemVersion <String>]`: The version of the operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).
    - `[PhysicalIds <String[]>]`: For internal use only. Not nullable. Supports $filter (eq, not, ge, le, startsWith).
    - `[Platform <String>]`: Platform of device. Only returned if user signs in with a Microsoft account as part of Project Rome. Only returned if user signs in with a Microsoft account as part of Project Rome.
    - `[ProfileType <String>]`: The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
    - `[RegisteredOwners <IMicrosoftGraphDirectoryObject[]>]`: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.
    - `[RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]`: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.
    - `[RegistrationDateTime <DateTime?>]`: Date and time of when the device was registered. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Status <String>]`: Device is online or offline. Only returned if user signs in with a Microsoft account as part of Project Rome.
    - `[SystemLabels <String[]>]`: List of labels applied to the device by the system.
    - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that the device is a member of. This operation is transitive. Supports $expand.
    - `[TrustType <String>]`: Type of trust for the joined device. Read-only. Possible values:  Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory
    - `[UsageRights <IMicrosoftGraphUsageRight[]>]`: Represents the usage rights a device has been granted.
      - `[Id <String>]`: Read-only.
      - `[CatalogId <String>]`: Product id corresponding to the usage right.
      - `[ServiceIdentifier <String>]`: Identifier of the service corresponding to the usage right.
      - `[State <String>]`: usageRightState
  - `[DisplayName <String>]`: The name of the device on which Windows Hello for Business is registered
  - `[KeyStrength <String>]`: authenticationMethodKeyStrength

DEVICE <IMicrosoftGraphDevice>: device
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: Read-only.
  - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. Required. Default is true.  Supports $filter (eq, ne, not, in). Only callers in Global Administrator and Cloud Device Administrator roles can set this property.
  - `[AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]`: For internal use only. Not nullable. Supports $filter (eq, not, ge, le).
    - `[IdentityProvider <String>]`: For internal use only
    - `[Key <Byte[]>]`: For internal use only
    - `[Type <Int32?>]`: For internal use only
  - `[ApproximateLastSignInDateTime <DateTime?>]`: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, and eq on null values) and $orderBy.
  - `[Commands <IMicrosoftGraphCommand[]>]`: Set of commands sent to this device.
    - `[Id <String>]`: Read-only.
    - `[AppServiceName <String>]`: 
    - `[Error <String>]`: 
    - `[PackageFamilyName <String>]`: 
    - `[Payload <IMicrosoftGraphPayloadRequest>]`: payloadRequest
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[PermissionTicket <String>]`: 
    - `[PostBackUri <String>]`: 
    - `[Responsepayload <IMicrosoftGraphPayloadResponse>]`: payloadResponse
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
    - `[Status <String>]`: 
    - `[Type <String>]`: 
  - `[ComplianceExpirationDateTime <DateTime?>]`: The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DeviceCategory <String>]`: User-defined property set by Intune to automatically add devices to groups and simplify managing devices.
  - `[DeviceId <String>]`: Unique identifier set by Azure Device Registration Service at the time of registration. Supports $filter (eq, ne, not, startsWith).
  - `[DeviceMetadata <String>]`: For internal use only. Set to null.
  - `[DeviceOwnership <String>]`: Ownership of the device. This property is set by Intune. Possible values are: unknown, company, personal.
  - `[DeviceVersion <Int32?>]`: For internal use only.
  - `[DisplayName <String>]`: The display name for the device. Required. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[DomainName <String>]`: The on-premises domain name of Hybrid Azure AD joined devices. This property is set by Intune.
  - `[EnrollmentProfileName <String>]`: Enrollment profile applied to the device. For example, Apple Device Enrollment Profile, Device enrollment - Corporate device identifiers, or Windows Autopilot profile name. This property is set by Intune.
  - `[EnrollmentType <String>]`: Enrollment type of the device. This property is set by Intune. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement.
  - `[ExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]`: onPremisesExtensionAttributes
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExtensionAttribute1 <String>]`: First customizable extension attribute.
    - `[ExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
    - `[ExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
    - `[ExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
    - `[ExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
    - `[ExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
    - `[ExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
    - `[ExtensionAttribute2 <String>]`: Second customizable extension attribute.
    - `[ExtensionAttribute3 <String>]`: Third customizable extension attribute.
    - `[ExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
    - `[ExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
    - `[ExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
    - `[ExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
    - `[ExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
    - `[ExtensionAttribute9 <String>]`: Ninth customizable extension attribute.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the device. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[Hostnames <String[]>]`: List of hostNames for the device.
  - `[IsCompliant <Boolean?>]`: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).
  - `[IsManaged <Boolean?>]`: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).
  - `[IsRooted <Boolean?>]`: true if device is rooted; false if device is jail-broken. This can only be updated by Intune.
  - `[Kind <String>]`: Form factor of device. Only returned if user signs in with a Microsoft account as part of Project Rome.
  - `[ManagementType <String>]`: Management channel of the device.  This property is set by Intune. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.
  - `[Manufacturer <String>]`: Manufacturer of the device. Read-only.
  - `[MdmAppId <String>]`: Application identifier used to register device into MDM. Read-only. Supports $filter (eq, ne, not, startsWith).
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this device is a member of. Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Model <String>]`: Model of the device. Read-only.
  - `[Name <String>]`: Friendly name of a device. Only returned if user signs in with a Microsoft account as part of Project Rome.
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only. Supports $filter (eq, ne, not, ge, le, in).
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).
  - `[OperatingSystem <String>]`: The type of operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).
  - `[OperatingSystemVersion <String>]`: The version of the operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).
  - `[PhysicalIds <String[]>]`: For internal use only. Not nullable. Supports $filter (eq, not, ge, le, startsWith).
  - `[Platform <String>]`: Platform of device. Only returned if user signs in with a Microsoft account as part of Project Rome. Only returned if user signs in with a Microsoft account as part of Project Rome.
  - `[ProfileType <String>]`: The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.
  - `[RegisteredOwners <IMicrosoftGraphDirectoryObject[]>]`: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.
  - `[RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]`: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.
  - `[RegistrationDateTime <DateTime?>]`: Date and time of when the device was registered. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Status <String>]`: Device is online or offline. Only returned if user signs in with a Microsoft account as part of Project Rome.
  - `[SystemLabels <String[]>]`: List of labels applied to the device by the system.
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that the device is a member of. This operation is transitive. Supports $expand.
  - `[TrustType <String>]`: Type of trust for the joined device. Read-only. Possible values:  Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory
  - `[UsageRights <IMicrosoftGraphUsageRight[]>]`: Represents the usage rights a device has been granted.
    - `[Id <String>]`: Read-only.
    - `[CatalogId <String>]`: Product id corresponding to the usage right.
    - `[ServiceIdentifier <String>]`: Identifier of the service corresponding to the usage right.
    - `[State <String>]`: usageRightState

INPUTOBJECT <IIdentitySignInsIdentity>: Identity Parameter
  - `[ActivityBasedTimeoutPolicyId <String>]`: key: id of activityBasedTimeoutPolicy
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AuthenticationContextClassReferenceId <String>]`: key: id of authenticationContextClassReference
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[AuthorizationPolicyId <String>]`: key: id of authorizationPolicy
  - `[BitlockerRecoveryKeyId <String>]`: key: id of bitlockerRecoveryKey
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConditionalAccessPolicyId <String>]`: key: id of conditionalAccessPolicy
  - `[CrossTenantAccessPolicyConfigurationPartnerTenantId <String>]`: key: tenantId of crossTenantAccessPolicyConfigurationPartner
  - `[DataLossPreventionPolicyId <String>]`: key: id of dataLossPreventionPolicy
  - `[DataPolicyOperationId <String>]`: key: id of dataPolicyOperation
  - `[DefaultUserRoleOverrideId <String>]`: key: id of defaultUserRoleOverride
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
  - `[RiskyUserHistoryItemId <String>]`: key: id of riskyUserHistoryItem
  - `[RiskyUserId <String>]`: key: id of riskyUser
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: key: id of sensitivityLabel
  - `[ServicePrincipalCreationConditionSetId <String>]`: key: id of servicePrincipalCreationConditionSet
  - `[ServicePrincipalCreationPolicyId <String>]`: key: id of servicePrincipalCreationPolicy
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
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

