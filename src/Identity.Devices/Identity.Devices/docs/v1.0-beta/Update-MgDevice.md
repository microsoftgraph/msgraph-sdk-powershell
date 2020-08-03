---
external help file:
Module Name: Microsoft.Graph.Identity.Devices
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.devices/update-mgdevice
schema: 2.0.0
---

# Update-MgDevice

## SYNOPSIS
Update entity in devices

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDevice -DeviceId <String> [-AccountEnabled]
 [-AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]
 [-ApproximateLastSignInDateTime <DateTime>] [-Commands <IMicrosoftGraphCommand[]>]
 [-ComplianceExpirationDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-DeviceId1 <String>]
 [-DeviceMetadata <String>] [-DeviceVersion <Int32>] [-DisplayName <String>]
 [-ExtensionAttributeExtensionAttribute1 <String>] [-ExtensionAttributeExtensionAttribute10 <String>]
 [-ExtensionAttributeExtensionAttribute11 <String>] [-ExtensionAttributeExtensionAttribute12 <String>]
 [-ExtensionAttributeExtensionAttribute13 <String>] [-ExtensionAttributeExtensionAttribute14 <String>]
 [-ExtensionAttributeExtensionAttribute15 <String>] [-ExtensionAttributeExtensionAttribute2 <String>]
 [-ExtensionAttributeExtensionAttribute3 <String>] [-ExtensionAttributeExtensionAttribute4 <String>]
 [-ExtensionAttributeExtensionAttribute5 <String>] [-ExtensionAttributeExtensionAttribute6 <String>]
 [-ExtensionAttributeExtensionAttribute7 <String>] [-ExtensionAttributeExtensionAttribute8 <String>]
 [-ExtensionAttributeExtensionAttribute9 <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>]
 [-IsCompliant] [-IsManaged] [-Kind <String>] [-Manufacturer <String>]
 [-MemberOf <IMicrosoftGraphDirectoryObject[]>] [-Model <String>] [-Name <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-OperatingSystem <String>]
 [-OperatingSystemVersion <String>] [-PhysicalIds <String[]>] [-Platform <String>] [-ProfileType <String>]
 [-RegisteredOwners <IMicrosoftGraphDirectoryObject[]>] [-RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]
 [-Status <String>] [-SystemLabels <String[]>] [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-TrustType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDevice -DeviceId <String> -BodyParameter <IMicrosoftGraphDevice1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDevice -InputObject <IIdentityDevicesIdentity> -BodyParameter <IMicrosoftGraphDevice1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDevice -InputObject <IIdentityDevicesIdentity> [-DeviceId <String>] [-AccountEnabled]
 [-AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]
 [-ApproximateLastSignInDateTime <DateTime>] [-Commands <IMicrosoftGraphCommand[]>]
 [-ComplianceExpirationDateTime <DateTime>] [-DeletedDateTime <DateTime>] [-DeviceMetadata <String>]
 [-DeviceVersion <Int32>] [-DisplayName <String>] [-ExtensionAttributeExtensionAttribute1 <String>]
 [-ExtensionAttributeExtensionAttribute10 <String>] [-ExtensionAttributeExtensionAttribute11 <String>]
 [-ExtensionAttributeExtensionAttribute12 <String>] [-ExtensionAttributeExtensionAttribute13 <String>]
 [-ExtensionAttributeExtensionAttribute14 <String>] [-ExtensionAttributeExtensionAttribute15 <String>]
 [-ExtensionAttributeExtensionAttribute2 <String>] [-ExtensionAttributeExtensionAttribute3 <String>]
 [-ExtensionAttributeExtensionAttribute4 <String>] [-ExtensionAttributeExtensionAttribute5 <String>]
 [-ExtensionAttributeExtensionAttribute6 <String>] [-ExtensionAttributeExtensionAttribute7 <String>]
 [-ExtensionAttributeExtensionAttribute8 <String>] [-ExtensionAttributeExtensionAttribute9 <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsCompliant] [-IsManaged] [-Kind <String>]
 [-Manufacturer <String>] [-MemberOf <IMicrosoftGraphDirectoryObject[]>] [-Model <String>] [-Name <String>]
 [-OnPremisesLastSyncDateTime <DateTime>] [-OnPremisesSyncEnabled] [-OperatingSystem <String>]
 [-OperatingSystemVersion <String>] [-PhysicalIds <String[]>] [-Platform <String>] [-ProfileType <String>]
 [-RegisteredOwners <IMicrosoftGraphDirectoryObject[]>] [-RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]
 [-Status <String>] [-SystemLabels <String[]>] [-TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]
 [-TrustType <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in devices

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

### -AccountEnabled
true if the account is enabled; otherwise, false.
Required.

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

### -AlternativeSecurityIds
For internal use only.
Not nullable.
To construct, see NOTES section for ALTERNATIVESECURITYIDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAlternativeSecurityId[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.DateTime
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDevice1
Parameter Sets: Update, UpdateViaIdentity
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCommand[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.DateTime
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

### -DeviceId
key: device-id of device

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId1
Unique identifier set by Azure Device Registration Service at the time of registration.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceMetadata
For interal use only.
Set to null.

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

### -DeviceVersion
For interal use only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name for the device.
Required.

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

### -ExtensionAttributeExtensionAttribute1
First customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute10
Tenth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute11
Eleventh customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute12
Twelfth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute13
Thirteenth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute14
Fourteenth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute15
Fifteenth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute2
Second customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute3
Third customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute4
Fourth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute5
Fifth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute6
Sixth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute7
Seventh customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute8
Eighth customizable extension attribute.

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

### -ExtensionAttributeExtensionAttribute9
Ninth customizable extension attribute.

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

### -Extensions
The collection of open extensions defined for the device.
Read-only.
Nullable.
To construct, see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension[]
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityDevicesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsCompliant
true if the device complies with Mobile Device Management (MDM) policies; otherwise, false.
Read-only.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.

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

### -IsManaged
true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false.
This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.

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

### -Kind
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

### -Manufacturer
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

### -MemberOf
Groups that this group is a member of.
HTTP Methods: GET (supported for all groups).
Read-only.
Nullable.
To construct, see NOTES section for MEMBEROF properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
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

### -Name
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

### -OnPremisesLastSyncDateTime
The last time at which the object was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' Read-only.

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

### -OnPremisesSyncEnabled
true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default).
Read-only.

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

### -OperatingSystem
The type of operating system on the device.
Required.

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

### -OperatingSystemVersion
The version of the operating system on the device.
Required.

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

### -PhysicalIds
For interal use only.
Not nullable.

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

### -Platform
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

### -ProfileType
The profile type of the device.
Possible values:RegisteredDevice (default)SecureVMPrinterSharedIoT

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

### -RegisteredOwners
The user that cloud joined the device or registered their personal device.
The registered owner is set at the time of registration.
Currently, there can be only one owner.
Read-only.
Nullable.
To construct, see NOTES section for REGISTEREDOWNERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityDevicesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDevice1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALTERNATIVESECURITYIDS <IMicrosoftGraphAlternativeSecurityId[]>: For internal use only. Not nullable.
  - `[IdentityProvider <String>]`: For internal use only
  - `[Key <Byte[]>]`: For internal use only
  - `[Type <Int32?>]`: For internal use only

BODYPARAMETER <IMicrosoftGraphDevice1>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. Required.
  - `[AlternativeSecurityIds <IMicrosoftGraphAlternativeSecurityId[]>]`: For internal use only. Not nullable.
    - `[IdentityProvider <String>]`: For internal use only
    - `[Key <Byte[]>]`: For internal use only
    - `[Type <Int32?>]`: For internal use only
  - `[ApproximateLastSignInDateTime <DateTime?>]`: The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[Commands <IMicrosoftGraphCommand[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppServiceName <String>]`: 
    - `[Error <String>]`: 
    - `[PackageFamilyName <String>]`: 
    - `[Payload <IMicrosoftGraphPayloadRequest>]`: PayloadRequest
    - `[PermissionTicket <String>]`: 
    - `[PostBackUri <String>]`: 
    - `[ResponsepayloadId <String>]`: Read-only.
    - `[Status <String>]`: 
    - `[Type <String>]`: 
  - `[ComplianceExpirationDateTime <DateTime?>]`: The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
  - `[DeviceId <String>]`: Unique identifier set by Azure Device Registration Service at the time of registration.
  - `[DeviceMetadata <String>]`: For interal use only. Set to null.
  - `[DeviceVersion <Int32?>]`: For interal use only.
  - `[DisplayName <String>]`: The display name for the device. Required.
  - `[ExtensionAttributeExtensionAttribute1 <String>]`: First customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute2 <String>]`: Second customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute3 <String>]`: Third customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
  - `[ExtensionAttributeExtensionAttribute9 <String>]`: Ninth customizable extension attribute.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the device. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[IsCompliant <Boolean?>]`: true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  - `[IsManaged <Boolean?>]`: true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
  - `[Kind <String>]`: 
  - `[Manufacturer <String>]`: 
  - `[MemberOf <IMicrosoftGraphDirectoryObject[]>]`: Groups that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: The last time at which the object was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' Read-only.
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only.
  - `[OperatingSystem <String>]`: The type of operating system on the device. Required.
  - `[OperatingSystemVersion <String>]`: The version of the operating system on the device. Required.
  - `[PhysicalIds <String[]>]`: For interal use only. Not nullable.
  - `[Platform <String>]`: 
  - `[ProfileType <String>]`: The profile type of the device. Possible values:RegisteredDevice (default)SecureVMPrinterSharedIoT
  - `[RegisteredOwners <IMicrosoftGraphDirectoryObject[]>]`: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
  - `[RegisteredUsers <IMicrosoftGraphDirectoryObject[]>]`: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
  - `[Status <String>]`: 
  - `[SystemLabels <String[]>]`: List of labels applied to the device by the system.
  - `[TransitiveMemberOf <IMicrosoftGraphDirectoryObject[]>]`: 
  - `[TrustType <String>]`: Type of trust for the joined device. Read-only. Possible values: Workplace - indicates bring your own personal devicesAzureAd - Cloud only joined devicesServerAd - on-premises domain joined devices joined to Azure AD. For more details, see Introduction to device management in Azure Active Directory

COMMANDS <IMicrosoftGraphCommand[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppServiceName <String>]`: 
  - `[Error <String>]`: 
  - `[PackageFamilyName <String>]`: 
  - `[Payload <IMicrosoftGraphPayloadRequest>]`: PayloadRequest
  - `[PermissionTicket <String>]`: 
  - `[PostBackUri <String>]`: 
  - `[ResponsepayloadId <String>]`: Read-only.
  - `[Status <String>]`: 
  - `[Type <String>]`: 

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for the device. Read-only. Nullable.
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IIdentityDevicesIdentity>: Identity Parameter
  - `[CommandId <String>]`: key: command-id of command
  - `[DeviceId <String>]`: key: device-id of device
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionId <String>]`: key: extension-id of extension

MEMBEROF <IMicrosoftGraphDirectoryObject[]>: Groups that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

REGISTEREDOWNERS <IMicrosoftGraphDirectoryObject[]>: The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

REGISTEREDUSERS <IMicrosoftGraphDirectoryObject[]>: Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

## RELATED LINKS

