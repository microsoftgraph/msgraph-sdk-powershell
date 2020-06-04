---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/new-mgdeviceappmanagementmanagedebook
schema: 2.0.0
---

# New-MgDeviceAppManagementManagedEBook

## SYNOPSIS
Create new navigation property to managedEBooks for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementManagedEBook [-Assignments <IMicrosoftGraphManagedEBookAssignment[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DeviceStates <IMicrosoftGraphDeviceInstallState[]>]
 [-DisplayName <String>] [-Id <String>] [-InformationUrl <String>] [-InstallSummaryFailedDeviceCount <Int32>]
 [-InstallSummaryFailedUserCount <Int32>] [-InstallSummaryId <String>]
 [-InstallSummaryInstalledDeviceCount <Int32>] [-InstallSummaryInstalledUserCount <Int32>]
 [-InstallSummaryNotInstalledDeviceCount <Int32>] [-InstallSummaryNotInstalledUserCount <Int32>]
 [-LargeCoverType <String>] [-LargeCoverValueInputFile <String>] [-LastModifiedDateTime <DateTime>]
 [-PrivacyInformationUrl <String>] [-PublishedDateTime <DateTime>] [-Publisher <String>]
 [-UserStateSummary <IMicrosoftGraphUserInstallStateSummary[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementManagedEBook -BodyParameter <IMicrosoftGraphManagedEBook> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedEBooks for deviceAppManagement

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

### -Assignments
The list of assignments for this eBook.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBookAssignment[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time when the eBook file was created.

```yaml
Type: System.DateTime
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceInstallState[]
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
Type: System.String
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
Type: System.String
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
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryFailedDeviceCount
Number of Devices that have failed to install this book.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryFailedUserCount
Number of Users that have 1 or more device that failed to install this book.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryInstalledDeviceCount
Number of Devices that have successfully installed this book.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryInstalledUserCount
Number of Users whose devices have all succeeded to install this book.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryNotInstalledDeviceCount
Number of Devices that does not have this book installed.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstallSummaryNotInstalledUserCount
Number of Users that did not install this book.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeCoverType
Indicates the content mime type.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeCoverValueInputFile
Input File for LargeCoverValue (The byte array that contains the actual content.)

```yaml
Type: System.String
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
Type: System.DateTime
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
Type: System.String
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
Type: System.DateTime
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserInstallStateSummary[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedEBook

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphManagedEBookAssignment[]>: The list of assignments for this eBook.
  - `[Id <String>]`: Read-only.
  - `[InstallIntent <String>]`: installIntent
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IMicrosoftGraphManagedEBook>: An abstract class containing the base properties for Managed eBook.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphManagedEBookAssignment[]>]`: The list of assignments for this eBook.
    - `[Id <String>]`: Read-only.
    - `[InstallIntent <String>]`: installIntent
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[CreatedDateTime <DateTime?>]`: The date and time when the eBook file was created.
  - `[Description <String>]`: Description.
  - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The list of installation states for this eBook.
    - `[Id <String>]`: Read-only.
    - `[DeviceId <String>]`: Device Id.
    - `[DeviceName <String>]`: Device name.
    - `[ErrorCode <String>]`: The error code for install failures.
    - `[InstallState <String>]`: installState
    - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
    - `[OSDescription <String>]`: OS Description.
    - `[OSVersion <String>]`: OS Version.
    - `[UserName <String>]`: Device User Name.
  - `[DisplayName <String>]`: Name of the eBook.
  - `[InformationUrl <String>]`: The more information Url.
  - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this book.
  - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this book.
  - `[InstallSummaryId <String>]`: Read-only.
  - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this book.
  - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this book.
  - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this book installed.
  - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that did not install this book.
  - `[LargeCoverType <String>]`: Indicates the content mime type.
  - `[LargeCoverValue <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the eBook was last modified.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[PublishedDateTime <DateTime?>]`: The date and time when the eBook was published.
  - `[Publisher <String>]`: Publisher.
  - `[UserStateSummary <IMicrosoftGraphUserInstallStateSummary[]>]`: The list of installation states for this eBook.
    - `[Id <String>]`: Read-only.
    - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The install state of the eBook.
    - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
    - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
    - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
    - `[UserName <String>]`: User name.

DEVICESTATES <IMicrosoftGraphDeviceInstallState[]>: The list of installation states for this eBook.
  - `[Id <String>]`: Read-only.
  - `[DeviceId <String>]`: Device Id.
  - `[DeviceName <String>]`: Device name.
  - `[ErrorCode <String>]`: The error code for install failures.
  - `[InstallState <String>]`: installState
  - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
  - `[OSDescription <String>]`: OS Description.
  - `[OSVersion <String>]`: OS Version.
  - `[UserName <String>]`: Device User Name.

USERSTATESUMMARY <IMicrosoftGraphUserInstallStateSummary[]>: The list of installation states for this eBook.
  - `[Id <String>]`: Read-only.
  - `[DeviceStates <IMicrosoftGraphDeviceInstallState[]>]`: The install state of the eBook.
    - `[Id <String>]`: Read-only.
    - `[DeviceId <String>]`: Device Id.
    - `[DeviceName <String>]`: Device name.
    - `[ErrorCode <String>]`: The error code for install failures.
    - `[InstallState <String>]`: installState
    - `[LastSyncDateTime <DateTime?>]`: Last sync date and time.
    - `[OSDescription <String>]`: OS Description.
    - `[OSVersion <String>]`: OS Version.
    - `[UserName <String>]`: Device User Name.
  - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
  - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
  - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
  - `[UserName <String>]`: User name.

## RELATED LINKS

