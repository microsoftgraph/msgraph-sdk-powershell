---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmanagementmobileappasmanagedmobilelobappcontentversion
schema: 2.0.0
---

# New-MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion

## SYNOPSIS
Create new navigation property to contentVersions for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion -MobileAppId <String>
 [-AdditionalProperties <Hashtable>] [-ContainedApps <IMicrosoftGraphMobileContainedApp[]>]
 [-Files <IMicrosoftGraphMobileAppContentFile[]>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion -MobileAppId <String>
 -BodyParameter <IMicrosoftGraphMobileAppContent> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion
 -InputObject <IDevicesCorporateManagementIdentity> -BodyParameter <IMicrosoftGraphMobileAppContent>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgDeviceAppManagementMobileAppAsManagedMobileLobAppContentVersion
 -InputObject <IDevicesCorporateManagementIdentity> [-AdditionalProperties <Hashtable>]
 [-ContainedApps <IMicrosoftGraphMobileContainedApp[]>] [-Files <IMicrosoftGraphMobileAppContentFile[]>]
 [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to contentVersions for deviceAppManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Contains content properties for a specific app version.
Each mobileAppContent can have multiple mobileAppContentFile.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppContent
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContainedApps
The collection of contained apps in a MobileLobApp acting as a package.
To construct, see NOTES section for CONTAINEDAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileContainedApp[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Files
The list of files for this app content version.
To construct, see NOTES section for FILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppContentFile[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MobileAppId
The unique identifier of mobileApp

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppContent

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppContent

## NOTES

ALIASES

New-MgDeviceAppMgtMobileAppAsManagedMobileLobAppContentVersion

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphMobileAppContent>`: Contains content properties for a specific app version. Each mobileAppContent can have multiple mobileAppContentFile.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ContainedApps <IMicrosoftGraphMobileContainedApp[]>]`: The collection of contained apps in a MobileLobApp acting as a package.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Files <IMicrosoftGraphMobileAppContentFile[]>]`: The list of files for this app content version.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AzureStorageUri <String>]`: The Azure Storage URI.
    - `[AzureStorageUriExpirationDateTime <DateTime?>]`: The time the Azure storage Uri expires.
    - `[CreatedDateTime <DateTime?>]`: The time the file was created.
    - `[IsCommitted <Boolean?>]`: A value indicating whether the file is committed.
    - `[Manifest <Byte[]>]`: The manifest information.
    - `[Name <String>]`: the file name.
    - `[Size <Int64?>]`: The size of the file prior to encryption.
    - `[SizeEncrypted <Int64?>]`: The size of the file after encryption.
    - `[UploadState <String>]`: Contains properties for upload request states.

`CONTAINEDAPPS <IMicrosoftGraphMobileContainedApp[]>`: The collection of contained apps in a MobileLobApp acting as a package.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`FILES <IMicrosoftGraphMobileAppContentFile[]>`: The list of files for this app content version.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AzureStorageUri <String>]`: The Azure Storage URI.
  - `[AzureStorageUriExpirationDateTime <DateTime?>]`: The time the Azure storage Uri expires.
  - `[CreatedDateTime <DateTime?>]`: The time the file was created.
  - `[IsCommitted <Boolean?>]`: A value indicating whether the file is committed.
  - `[Manifest <Byte[]>]`: The manifest information.
  - `[Name <String>]`: the file name.
  - `[Size <Int64?>]`: The size of the file prior to encryption.
  - `[SizeEncrypted <Int64?>]`: The size of the file after encryption.
  - `[UploadState <String>]`: Contains properties for upload request states.

`INPUTOBJECT <IDevicesCorporateManagementIdentity>`: Identity Parameter
  - `[AndroidManagedAppProtectionId <String>]`: The unique identifier of androidManagedAppProtection
  - `[DefaultManagedAppProtectionId <String>]`: The unique identifier of defaultManagedAppProtection
  - `[DeviceCompliancePolicyStateId <String>]`: The unique identifier of deviceCompliancePolicyState
  - `[DeviceConfigurationStateId <String>]`: The unique identifier of deviceConfigurationState
  - `[DeviceInstallStateId <String>]`: The unique identifier of deviceInstallState
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementTroubleshootingEventId <String>]`: The unique identifier of deviceManagementTroubleshootingEvent
  - `[IosManagedAppProtectionId <String>]`: The unique identifier of iosManagedAppProtection
  - `[ManagedAppOperationId <String>]`: The unique identifier of managedAppOperation
  - `[ManagedAppPolicyId <String>]`: The unique identifier of managedAppPolicy
  - `[ManagedAppRegistrationId <String>]`: The unique identifier of managedAppRegistration
  - `[ManagedAppStatusId <String>]`: The unique identifier of managedAppStatus
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[ManagedDeviceMobileAppConfigurationAssignmentId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationAssignment
  - `[ManagedDeviceMobileAppConfigurationDeviceStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationDeviceStatus
  - `[ManagedDeviceMobileAppConfigurationId <String>]`: The unique identifier of managedDeviceMobileAppConfiguration
  - `[ManagedDeviceMobileAppConfigurationUserStatusId <String>]`: The unique identifier of managedDeviceMobileAppConfigurationUserStatus
  - `[ManagedEBookAssignmentId <String>]`: The unique identifier of managedEBookAssignment
  - `[ManagedEBookId <String>]`: The unique identifier of managedEBook
  - `[ManagedMobileAppId <String>]`: The unique identifier of managedMobileApp
  - `[MdmWindowsInformationProtectionPolicyId <String>]`: The unique identifier of mdmWindowsInformationProtectionPolicy
  - `[MobileAppAssignmentId <String>]`: The unique identifier of mobileAppAssignment
  - `[MobileAppCategoryId <String>]`: The unique identifier of mobileAppCategory
  - `[MobileAppContentFileId <String>]`: The unique identifier of mobileAppContentFile
  - `[MobileAppContentId <String>]`: The unique identifier of mobileAppContent
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[MobileContainedAppId <String>]`: The unique identifier of mobileContainedApp
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLockerFileId <String>]`: The unique identifier of windowsInformationProtectionAppLockerFile
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy

## RELATED LINKS

