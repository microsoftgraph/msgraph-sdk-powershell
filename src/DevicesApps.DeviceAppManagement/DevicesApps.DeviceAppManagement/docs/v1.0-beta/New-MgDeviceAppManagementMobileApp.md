---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/new-mgdeviceappmanagementmobileapp
schema: 2.0.0
---

# New-MgDeviceAppManagementMobileApp

## SYNOPSIS
Create new navigation property to mobileApps for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementMobileApp [-Assignments <IMicrosoftGraphMobileAppAssignment1[]>]
 [-Categories <IMicrosoftGraphMobileAppCategory[]>] [-CreatedDateTime <DateTime>] [-DependentAppCount <Int32>]
 [-Description <String>] [-Developer <String>] [-DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-InformationUrl <String>] [-InstallSummaryFailedDeviceCount <Int32>]
 [-InstallSummaryFailedUserCount <Int32>] [-InstallSummaryId <String>]
 [-InstallSummaryInstalledDeviceCount <Int32>] [-InstallSummaryInstalledUserCount <Int32>]
 [-InstallSummaryNotApplicableDeviceCount <Int32>] [-InstallSummaryNotApplicableUserCount <Int32>]
 [-InstallSummaryNotInstalledDeviceCount <Int32>] [-InstallSummaryNotInstalledUserCount <Int32>]
 [-InstallSummaryPendingInstallDeviceCount <Int32>] [-InstallSummaryPendingInstallUserCount <Int32>]
 [-IsAssigned] [-IsFeatured] [-LargeIconType <String>] [-LargeIconValueInputFile <String>]
 [-LastModifiedDateTime <DateTime>] [-Notes <String>] [-Owner <String>] [-PrivacyInformationUrl <String>]
 [-Publisher <String>] [-PublishingState <String>] [-Relationships <IMicrosoftGraphMobileAppRelationship[]>]
 [-RoleScopeTagIds <String[]>] [-UploadState <Int32>] [-UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementMobileApp -BodyParameter <IMicrosoftGraphMobileApp> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileApps for deviceAppManagement

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
The list of group assignments for this mobile app.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppAssignment1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class containing the base properties for Intune mobile apps.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The list of categories for this app.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the app was created.

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

### -DependentAppCount
The total number of dependencies the child app has.

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

### -Description
The description of the app.

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

### -Developer
The developer of the app.

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

### -DeviceStatuses
The list of installation states for this mobile app.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppInstallStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The admin provided or imported title of the app.

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
Number of Devices that have failed to install this app.

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
Number of Users that have 1 or more device that failed to install this app.

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
Number of Devices that have successfully installed this app.

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
Number of Users whose devices have all succeeded to install this app.

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

### -InstallSummaryNotApplicableDeviceCount
Number of Devices that are not applicable for this app.

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

### -InstallSummaryNotApplicableUserCount
Number of Users whose devices were all not applicable for this app.

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
Number of Devices that does not have this app installed.

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
Number of Users that have 1 or more devices that did not install this app.

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

### -InstallSummaryPendingInstallDeviceCount
Number of Devices that have been notified to install this app.

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

### -InstallSummaryPendingInstallUserCount
Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.

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

### -IsAssigned
The value indicating whether the app is assigned to at least one group.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFeatured
The value indicating whether the app is marked as featured by the admin.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeIconType
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

### -LargeIconValueInputFile
Input File for LargeIconValue (The byte array that contains the actual content.)

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
The date and time the app was last modified.

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

### -Notes
Notes for the app.

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

### -Owner
The owner of the app.

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

### -Publisher
The publisher of the app.

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

### -PublishingState
mobileAppPublishingState

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

### -Relationships
List of relationships for this mobile app.
To construct, see NOTES section for RELATIONSHIPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppRelationship[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of scope tag ids for this mobile app.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UploadState
The upload state.

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

### -UserStatuses
The list of installation states for this mobile app.
To construct, see NOTES section for USERSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserAppInstallStatus[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphMobileAppAssignment1[]>: The list of group assignments for this mobile app.
  - `[Id <String>]`: Read-only.
  - `[Intent <String>]`: installIntent
  - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
  - `[Source <String>]`: deviceAndAppManagementAssignmentSource
  - `[SourceId <String>]`: The identifier of the source of the assignment.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IMicrosoftGraphMobileApp>: An abstract class containing the base properties for Intune mobile apps.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[Intent <String>]`: installIntent
    - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
    - `[Source <String>]`: deviceAndAppManagementAssignmentSource
    - `[SourceId <String>]`: The identifier of the source of the assignment.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
  - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
  - `[Description <String>]`: The description of the app.
  - `[Developer <String>]`: The developer of the app.
  - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceId <String>]`: Device ID
    - `[DeviceName <String>]`: Device name
    - `[DisplayVersion <String>]`: Human readable version of the application
    - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
    - `[InstallState <String>]`: resultantAppState
    - `[InstallStateDetail <String>]`: resultantAppStateDetail
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time
    - `[MobileAppInstallStatusValue <String>]`: resultantAppState
    - `[OSDescription <String>]`: OS Description
    - `[OSVersion <String>]`: OS Version
    - `[UserName <String>]`: Device User Name
    - `[UserPrincipalName <String>]`: User Principal Name
  - `[DisplayName <String>]`: The admin provided or imported title of the app.
  - `[InformationUrl <String>]`: The more information Url.
  - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
  - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
  - `[InstallSummaryId <String>]`: Read-only.
  - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
  - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
  - `[InstallSummaryNotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
  - `[InstallSummaryNotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
  - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
  - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
  - `[InstallSummaryPendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
  - `[InstallSummaryPendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
  - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
  - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
  - `[LargeIconType <String>]`: Indicates the content mime type.
  - `[LargeIconValue <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
  - `[Notes <String>]`: Notes for the app.
  - `[Owner <String>]`: The owner of the app.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[Publisher <String>]`: The publisher of the app.
  - `[PublishingState <String>]`: mobileAppPublishingState
  - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[TargetDisplayName <String>]`: The target child mobile app's display name.
    - `[TargetId <String>]`: The target child mobile app's app id.
  - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
  - `[UploadState <Int32?>]`: The upload state.
  - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[Id <String>]`: Read-only.
    - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
    - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
    - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
    - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
    - `[UserName <String>]`: User name.
    - `[UserPrincipalName <String>]`: User Principal Name.

CATEGORIES <IMicrosoftGraphMobileAppCategory[]>: The list of categories for this app.
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: The name of the app category.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.

DEVICESTATUSES <IMicrosoftGraphMobileAppInstallStatus[]>: The list of installation states for this mobile app.
  - `[Id <String>]`: Read-only.
  - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[Intent <String>]`: installIntent
      - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
      - `[Source <String>]`: deviceAndAppManagementAssignmentSource
      - `[SourceId <String>]`: The identifier of the source of the assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
    - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app category.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
    - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
    - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
    - `[Description <String>]`: The description of the app.
    - `[Developer <String>]`: The developer of the app.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
    - `[DisplayName <String>]`: The admin provided or imported title of the app.
    - `[InformationUrl <String>]`: The more information Url.
    - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
    - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
    - `[InstallSummaryId <String>]`: Read-only.
    - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
    - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
    - `[InstallSummaryNotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
    - `[InstallSummaryNotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
    - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
    - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
    - `[InstallSummaryPendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
    - `[InstallSummaryPendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
    - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
    - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
    - `[LargeIconType <String>]`: Indicates the content mime type.
    - `[LargeIconValue <Byte[]>]`: The byte array that contains the actual content.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
    - `[Notes <String>]`: Notes for the app.
    - `[Owner <String>]`: The owner of the app.
    - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
    - `[Publisher <String>]`: The publisher of the app.
    - `[PublishingState <String>]`: mobileAppPublishingState
    - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[TargetDisplayName <String>]`: The target child mobile app's display name.
      - `[TargetId <String>]`: The target child mobile app's app id.
    - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
    - `[UploadState <Int32?>]`: The upload state.
    - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
      - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
      - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
      - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
      - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
      - `[UserName <String>]`: User name.
      - `[UserPrincipalName <String>]`: User Principal Name.
  - `[DeviceId <String>]`: Device ID
  - `[DeviceName <String>]`: Device name
  - `[DisplayVersion <String>]`: Human readable version of the application
  - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
  - `[InstallState <String>]`: resultantAppState
  - `[InstallStateDetail <String>]`: resultantAppStateDetail
  - `[LastSyncDateTime <DateTime?>]`: Last sync date time
  - `[MobileAppInstallStatusValue <String>]`: resultantAppState
  - `[OSDescription <String>]`: OS Description
  - `[OSVersion <String>]`: OS Version
  - `[UserName <String>]`: Device User Name
  - `[UserPrincipalName <String>]`: User Principal Name

RELATIONSHIPS <IMicrosoftGraphMobileAppRelationship[]>: List of relationships for this mobile app.
  - `[Id <String>]`: Read-only.
  - `[TargetDisplayName <String>]`: The target child mobile app's display name.
  - `[TargetId <String>]`: The target child mobile app's app id.

USERSTATUSES <IMicrosoftGraphUserAppInstallStatus[]>: The list of installation states for this mobile app.
  - `[Id <String>]`: Read-only.
  - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[Intent <String>]`: installIntent
      - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: mobileAppAssignmentSettings
      - `[Source <String>]`: deviceAndAppManagementAssignmentSource
      - `[SourceId <String>]`: The identifier of the source of the assignment.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
    - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app category.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
    - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
    - `[DependentAppCount <Int32?>]`: The total number of dependencies the child app has.
    - `[Description <String>]`: The description of the app.
    - `[Developer <String>]`: The developer of the app.
    - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The list of installation states for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[App <IMicrosoftGraphMobileApp>]`: An abstract class containing the base properties for Intune mobile apps.
      - `[DeviceId <String>]`: Device ID
      - `[DeviceName <String>]`: Device name
      - `[DisplayVersion <String>]`: Human readable version of the application
      - `[ErrorCode <Int32?>]`: The error code for install or uninstall failures.
      - `[InstallState <String>]`: resultantAppState
      - `[InstallStateDetail <String>]`: resultantAppStateDetail
      - `[LastSyncDateTime <DateTime?>]`: Last sync date time
      - `[MobileAppInstallStatusValue <String>]`: resultantAppState
      - `[OSDescription <String>]`: OS Description
      - `[OSVersion <String>]`: OS Version
      - `[UserName <String>]`: Device User Name
      - `[UserPrincipalName <String>]`: User Principal Name
    - `[DisplayName <String>]`: The admin provided or imported title of the app.
    - `[InformationUrl <String>]`: The more information Url.
    - `[InstallSummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to install this app.
    - `[InstallSummaryFailedUserCount <Int32?>]`: Number of Users that have 1 or more device that failed to install this app.
    - `[InstallSummaryId <String>]`: Read-only.
    - `[InstallSummaryInstalledDeviceCount <Int32?>]`: Number of Devices that have successfully installed this app.
    - `[InstallSummaryInstalledUserCount <Int32?>]`: Number of Users whose devices have all succeeded to install this app.
    - `[InstallSummaryNotApplicableDeviceCount <Int32?>]`: Number of Devices that are not applicable for this app.
    - `[InstallSummaryNotApplicableUserCount <Int32?>]`: Number of Users whose devices were all not applicable for this app.
    - `[InstallSummaryNotInstalledDeviceCount <Int32?>]`: Number of Devices that does not have this app installed.
    - `[InstallSummaryNotInstalledUserCount <Int32?>]`: Number of Users that have 1 or more devices that did not install this app.
    - `[InstallSummaryPendingInstallDeviceCount <Int32?>]`: Number of Devices that have been notified to install this app.
    - `[InstallSummaryPendingInstallUserCount <Int32?>]`: Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
    - `[IsAssigned <Boolean?>]`: The value indicating whether the app is assigned to at least one group.
    - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
    - `[LargeIconType <String>]`: Indicates the content mime type.
    - `[LargeIconValue <Byte[]>]`: The byte array that contains the actual content.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
    - `[Notes <String>]`: Notes for the app.
    - `[Owner <String>]`: The owner of the app.
    - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
    - `[Publisher <String>]`: The publisher of the app.
    - `[PublishingState <String>]`: mobileAppPublishingState
    - `[Relationships <IMicrosoftGraphMobileAppRelationship[]>]`: List of relationships for this mobile app.
      - `[Id <String>]`: Read-only.
      - `[TargetDisplayName <String>]`: The target child mobile app's display name.
      - `[TargetId <String>]`: The target child mobile app's app id.
    - `[RoleScopeTagIds <String[]>]`: List of scope tag ids for this mobile app.
    - `[UploadState <Int32?>]`: The upload state.
    - `[UserStatuses <IMicrosoftGraphUserAppInstallStatus[]>]`: The list of installation states for this mobile app.
  - `[DeviceStatuses <IMicrosoftGraphMobileAppInstallStatus[]>]`: The install state of the app on devices.
  - `[FailedDeviceCount <Int32?>]`: Failed Device Count.
  - `[InstalledDeviceCount <Int32?>]`: Installed Device Count.
  - `[NotInstalledDeviceCount <Int32?>]`: Not installed device count.
  - `[UserName <String>]`: User name.
  - `[UserPrincipalName <String>]`: User Principal Name.

## RELATED LINKS

