---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedebook
schema: 2.0.0
---

# New-MgDeviceAppMgtManagedEBook

## SYNOPSIS
Create new navigation property to managedEBooks for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtManagedEBook [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphManagedEBookAssignment[]>] [-Categories <IMicrosoftGraphManagedEBookCategory[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DeviceStates <IMicrosoftGraphDeviceInstallState[]>]
 [-DisplayName <String>] [-Id <String>] [-InformationUrl <String>]
 [-InstallSummary <IMicrosoftGraphEBookInstallSummary>] [-LargeCover <IMicrosoftGraphMimeContent>]
 [-LastModifiedDateTime <DateTime>] [-PrivacyInformationUrl <String>] [-PublishedDateTime <DateTime>]
 [-Publisher <String>] [-UserStateSummary <IMicrosoftGraphUserInstallStateSummary[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtManagedEBook -BodyParameter <IMicrosoftGraphManagedEBook> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedEBooks for deviceAppManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of assignments for this eBook.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedEBookAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class containing the base properties for Managed eBook.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedEBook
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The list of categories for this eBook.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedEBookCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time when the eBook file was created.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStates
The list of installation states for this eBook.
To construct, see NOTES section for DEVICESTATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphDeviceInstallState[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the eBook.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InformationUrl
The more information Url.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummary
Contains properties for the installation summary of a book for a device.
To construct, see NOTES section for INSTALLSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphEBookInstallSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeCover
Contains properties for a generic mime content.
To construct, see NOTES section for LARGECOVER properties and create a hash table.

```yaml
Type: IMicrosoftGraphMimeContent
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time when the eBook was last modified.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivacyInformationUrl
The privacy statement Url.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedDateTime
The date and time when the eBook was published.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publisher
Publisher.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserStateSummary
The list of installation states for this eBook.
To construct, see NOTES section for USERSTATESUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserInstallStateSummary[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNMENTS \<IMicrosoftGraphManagedEBookAssignment1\[\]\>: The list of assignments for this eBook.
  \[Id \<String\>\]: Read-only.
  \[InstallIntent \<String\>\]: installIntent
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphManagedEBook1\>: An abstract class containing the base properties for Managed eBook.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphManagedEBookAssignment1\[\]\>\]: The list of assignments for this eBook.
    \[Id \<String\>\]: Read-only.
    \[InstallIntent \<String\>\]: installIntent
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CreatedDateTime \<DateTime?\>\]: The date and time when the eBook file was created.
  \[Description \<String\>\]: Description.
  \[DeviceStates \<IMicrosoftGraphDeviceInstallState\[\]\>\]: The list of installation states for this eBook.
    \[Id \<String\>\]: Read-only.
    \[DeviceId \<String\>\]: Device Id.
    \[DeviceName \<String\>\]: Device name.
    \[ErrorCode \<String\>\]: The error code for install failures.
    \[InstallState \<String\>\]: installState
    \[LastSyncDateTime \<DateTime?\>\]: Last sync date and time.
    \[OSDescription \<String\>\]: OS Description.
    \[OSVersion \<String\>\]: OS Version.
    \[UserName \<String\>\]: Device User Name.
  \[DisplayName \<String\>\]: Name of the eBook.
  \[InformationUrl \<String\>\]: The more information Url.
  \[InstallSummary \<IMicrosoftGraphEBookInstallSummary\>\]: Contains properties for the installation summary of a book for a device.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[FailedDeviceCount \<Int32?\>\]: Number of Devices that have failed to install this book.
    \[FailedUserCount \<Int32?\>\]: Number of Users that have 1 or more device that failed to install this book.
    \[InstalledDeviceCount \<Int32?\>\]: Number of Devices that have successfully installed this book.
    \[InstalledUserCount \<Int32?\>\]: Number of Users whose devices have all succeeded to install this book.
    \[NotInstalledDeviceCount \<Int32?\>\]: Number of Devices that does not have this book installed.
    \[NotInstalledUserCount \<Int32?\>\]: Number of Users that did not install this book.
  \[LargeCover \<IMicrosoftGraphMimeContent\>\]: Contains properties for a generic mime content.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Type \<String\>\]: Indicates the content mime type.
    \[Value \<Byte\[\]\>\]: The byte array that contains the actual content.
  \[LastModifiedDateTime \<DateTime?\>\]: The date and time when the eBook was last modified.
  \[PrivacyInformationUrl \<String\>\]: The privacy statement Url.
  \[PublishedDateTime \<DateTime?\>\]: The date and time when the eBook was published.
  \[Publisher \<String\>\]: Publisher.
  \[UserStateSummary \<IMicrosoftGraphUserInstallStateSummary\[\]\>\]: The list of installation states for this eBook.
    \[Id \<String\>\]: Read-only.
    \[DeviceStates \<IMicrosoftGraphDeviceInstallState\[\]\>\]: The install state of the eBook.
    \[FailedDeviceCount \<Int32?\>\]: Failed Device Count.
    \[InstalledDeviceCount \<Int32?\>\]: Installed Device Count.
    \[NotInstalledDeviceCount \<Int32?\>\]: Not installed device count.
    \[UserName \<String\>\]: User name.

DEVICESTATES \<IMicrosoftGraphDeviceInstallState\[\]\>: The list of installation states for this eBook.
  \[Id \<String\>\]: Read-only.
  \[DeviceId \<String\>\]: Device Id.
  \[DeviceName \<String\>\]: Device name.
  \[ErrorCode \<String\>\]: The error code for install failures.
  \[InstallState \<String\>\]: installState
  \[LastSyncDateTime \<DateTime?\>\]: Last sync date and time.
  \[OSDescription \<String\>\]: OS Description.
  \[OSVersion \<String\>\]: OS Version.
  \[UserName \<String\>\]: Device User Name.

INSTALLSUMMARY \<IMicrosoftGraphEBookInstallSummary\>: Contains properties for the installation summary of a book for a device.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[FailedDeviceCount \<Int32?\>\]: Number of Devices that have failed to install this book.
  \[FailedUserCount \<Int32?\>\]: Number of Users that have 1 or more device that failed to install this book.
  \[InstalledDeviceCount \<Int32?\>\]: Number of Devices that have successfully installed this book.
  \[InstalledUserCount \<Int32?\>\]: Number of Users whose devices have all succeeded to install this book.
  \[NotInstalledDeviceCount \<Int32?\>\]: Number of Devices that does not have this book installed.
  \[NotInstalledUserCount \<Int32?\>\]: Number of Users that did not install this book.

LARGECOVER \<IMicrosoftGraphMimeContent\>: Contains properties for a generic mime content.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Type \<String\>\]: Indicates the content mime type.
  \[Value \<Byte\[\]\>\]: The byte array that contains the actual content.

USERSTATESUMMARY \<IMicrosoftGraphUserInstallStateSummary\[\]\>: The list of installation states for this eBook.
  \[Id \<String\>\]: Read-only.
  \[DeviceStates \<IMicrosoftGraphDeviceInstallState\[\]\>\]: The install state of the eBook.
    \[Id \<String\>\]: Read-only.
    \[DeviceId \<String\>\]: Device Id.
    \[DeviceName \<String\>\]: Device name.
    \[ErrorCode \<String\>\]: The error code for install failures.
    \[InstallState \<String\>\]: installState
    \[LastSyncDateTime \<DateTime?\>\]: Last sync date and time.
    \[OSDescription \<String\>\]: OS Description.
    \[OSVersion \<String\>\]: OS Version.
    \[UserName \<String\>\]: Device User Name.
  \[FailedDeviceCount \<Int32?\>\]: Failed Device Count.
  \[InstalledDeviceCount \<Int32?\>\]: Installed Device Count.
  \[NotInstalledDeviceCount \<Int32?\>\]: Not installed device count.
  \[UserName \<String\>\]: User name.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedebook](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedebook)

