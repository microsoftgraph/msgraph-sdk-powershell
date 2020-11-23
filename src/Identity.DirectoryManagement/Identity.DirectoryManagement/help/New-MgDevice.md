---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdevice
schema: 2.0.0
---

# New-MgDevice

## SYNOPSIS
Add new entity to devices

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDevice [-AccountEnabled] [-AdditionalProperties <Hashtable>]
 [-AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>] [-ApproximateLastSignInDateTime <DateTime>]
 [-Commands <IMicrosoftGraphCommand[]>] [-ComplianceExpirationDateTime <DateTime>]
 [-DeletedDateTime <DateTime>] [-DeviceCategory <String>] [-DeviceId <String>] [-DeviceMetadata <String>]
 [-DeviceOwnership <String>] [-DeviceVersion <Int32>] [-DisplayName <String>] [-DomainName <String>]
 [-EnrollmentProfileName <String>] [-EnrollmentType <String>]
 [-ExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsCompliant] [-IsManaged] [-IsRooted]
 [-Kind <String>] [-ManagementType <String>] [-Manufacturer <String>]
 [-MemberOf <IMicrosoftGraphDirectoryObject[]>] [-Model <String>] [-Name <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-OperatingSystem <String>]
 [-OperatingSystemVersion <String>] [-PhysicalIds <String[]>] [-Platform <String>] [-ProfileType <String>]
 [-RegisteredOwners <IMicrosoftGraphDirectoryObject[]>] [-RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]
 [-RegistrationDateTime <DateTime>] [-Status <String>] [-SystemLabels <String[]>]
 [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>] [-TrustType <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create1
```
New-MgDevice -BodyParameter <IMicrosoftGraphDevice1> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to devices

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

### -AccountEnabled
true if the account is enabled; otherwise, false.
Required.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AlternativeSecurityIds
For internal use only.
Not nullable.
To construct, see NOTES section for ALTERNATIVESECURITYIDS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAlternativeSecurityId[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApproximateLastSignInDateTime
The timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
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
Type: IMicrosoftGraphDevice1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Commands
.
To construct, see NOTES section for COMMANDS properties and create a hash table.

```yaml
Type: IMicrosoftGraphCommand[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ComplianceExpirationDateTime
The timestamp when the device is no longer deemed compliant.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceCategory
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
Unique identifier set by Azure Device Registration Service at the time of registration.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceMetadata
For internal use only.
Set to null.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceOwnership
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceVersion
For internal use only.

```yaml
Type: Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the device.
Required.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainName
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentProfileName
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentType
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtensionAttributes
onPremisesExtensionAttributes
To construct, see NOTES section for EXTENSIONATTRIBUTES properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesExtensionAttributes
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Extensions
The collection of open extensions defined for the device.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphExtension[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsCompliant
true if the device complies with Mobile Device Management (MDM) policies; otherwise, false.
Read-only.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsManaged
true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRooted
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Kind
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementType
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
Manufacturer of the device.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberOf
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
Model of the device.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
The last time at which the object was synced with the on-premises directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
Read-only.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -OperatingSystem
The type of operating system on the device.
Required.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OperatingSystemVersion
The version of the operating system on the device.
Required.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PhysicalIds
For internal use only.
Not nullable.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileType
The profile type of the device.
Possible values:RegisteredDevice (default)SecureVMPrinterSharedIoT

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredOwners
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
To construct, see NOTES section for REGISTEREDOWNERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredUsers
Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
To construct, see NOTES section for REGISTEREDUSERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegistrationDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemLabels
List of labels applied to the device by the system.

```yaml
Type: String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TransitiveMemberOf
.
To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.

```yaml
Type: IMicrosoftGraphDirectoryObject[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TrustType
Type of trust for the joined device.
Read-only.
Possible values: Workplace - indicates bring your own personal devicesAzureAd - Cloud only joined devicesServerAd - on-premises domain joined devices joined to Azure AD.
For more details, see Introduction to device management in Azure Active Directory

```yaml
Type: String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDevice1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDevice1
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ALTERNATIVESECURITYIDS \<IMicrosoftGraphAlternativeSecurityId\[\]\>: For internal use only.
Not nullable.
  \[IdentityProvider \<String\>\]: For internal use only
  \[Key \<Byte\[\]\>\]: For internal use only
  \[Type \<Int32?\>\]: For internal use only

BODYPARAMETER \<IMicrosoftGraphDevice\>: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeletedDateTime \<DateTime?\>\]: 
  \[Id \<String\>\]: Read-only.
  \[AccountEnabled \<Boolean?\>\]: true if the account is enabled; otherwise, false.
Required.
  \[AlternativeSecurityIds \<IMicrosoftGraphAlternativeSecurityId\[\]\>\]: For internal use only.
Not nullable.
    \[IdentityProvider \<String\>\]: For internal use only
    \[Key \<Byte\[\]\>\]: For internal use only
    \[Type \<Int32?\>\]: For internal use only
  \[ApproximateLastSignInDateTime \<DateTime?\>\]: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.
  \[ComplianceExpirationDateTime \<DateTime?\>\]: The timestamp when the device is no longer deemed compliant.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.
  \[DeviceId \<String\>\]: Unique identifier set by Azure Device Registration Service at the time of registration.
  \[DeviceMetadata \<String\>\]: For internal use only.
Set to null.
  \[DeviceVersion \<Int32?\>\]: For internal use only.
  \[DisplayName \<String\>\]: The display name for the device.
Required.
  \[Extensions \<IMicrosoftGraphExtension\[\]\>\]: The collection of open extensions defined for the device.
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
  \[IsCompliant \<Boolean?\>\]: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false.
Read-only.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  \[IsManaged \<Boolean?\>\]: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  \[MdmAppId \<String\>\]: Application identifier used to register device into MDM.
Read-only.
Supports $filter.
  \[MemberOf \<IMicrosoftGraphDirectoryObject\[\]\>\]: Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
    \[Id \<String\>\]: Read-only.
    \[DeletedDateTime \<DateTime?\>\]: 
  \[OnPremisesLastSyncDateTime \<DateTime?\>\]: The last time at which the object was synced with the on-premises directory.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' Read-only.
  \[OnPremisesSyncEnabled \<Boolean?\>\]: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
Read-only.
  \[OperatingSystem \<String\>\]: The type of operating system on the device.
Required.
  \[OperatingSystemVersion \<String\>\]: The version of the operating system on the device.
Required.
  \[PhysicalIds \<String\[\]\>\]: For internal use only.
Not nullable.
  \[ProfileType \<String\>\]: The profile type of the device.
Possible values:RegisteredDevice (default)SecureVMPrinterSharedIoT
  \[RegisteredOwners \<IMicrosoftGraphDirectoryObject\[\]\>\]: The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
  \[RegisteredUsers \<IMicrosoftGraphDirectoryObject\[\]\>\]: Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
  \[SystemLabels \<String\[\]\>\]: List of labels applied to the device by the system.
  \[TransitiveMemberOf \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
  \[TrustType \<String\>\]: Type of trust for the joined device.
Read-only.
Possible values: Workplace - indicates bring your own personal devicesAzureAd - Cloud only joined devicesServerAd - on-premises domain joined devices joined to Azure AD.
For more details, see Introduction to device management in Azure Active Directory

EXTENSIONS \<IMicrosoftGraphExtension\[\]\>: The collection of open extensions defined for the device.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.

MEMBEROF \<IMicrosoftGraphDirectoryObject\[\]\>: Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

REGISTEREDOWNERS \<IMicrosoftGraphDirectoryObject\[\]\>: The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

REGISTEREDUSERS \<IMicrosoftGraphDirectoryObject\[\]\>: Collection of registered users of the device.
For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration.
Read-only.
Nullable.
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]: 

TRANSITIVEMEMBEROF \<IMicrosoftGraphDirectoryObject\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DeletedDateTime \<DateTime?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdevice](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdevice)

