---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgusermanageddevicewindowsprotectionstate
schema: 2.0.0
---

# Update-MgUserManagedDeviceWindowsProtectionState

## SYNOPSIS
Update the properties of a windowsProtectionState object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserManagedDeviceWindowsProtectionState -ManagedDeviceId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AntiMalwareVersion <String>]
 [-DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]
 [-DeviceState <WindowsDeviceHealthState>] [-EngineVersion <String>] [-FullScanOverdue] [-FullScanRequired]
 [-Id <String>] [-IsVirtualMachine] [-LastFullScanDateTime <DateTime>]
 [-LastFullScanSignatureVersion <String>] [-LastQuickScanDateTime <DateTime>]
 [-LastQuickScanSignatureVersion <String>] [-LastReportedDateTime <DateTime>] [-MalwareProtectionEnabled]
 [-NetworkInspectionSystemEnabled] [-ProductStatus <WindowsDefenderProductStatus>] [-QuickScanOverdue]
 [-RealTimeProtectionEnabled] [-RebootRequired] [-SignatureUpdateOverdue] [-SignatureVersion <String>]
 [-TamperProtectionEnabled] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserManagedDeviceWindowsProtectionState -ManagedDeviceId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphWindowsProtectionState> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserManagedDeviceWindowsProtectionState -InputObject <IDevicesCorporateManagementIdentity>
 -BodyParameter <IMicrosoftGraphWindowsProtectionState> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserManagedDeviceWindowsProtectionState -InputObject <IDevicesCorporateManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-AntiMalwareVersion <String>]
 [-DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]
 [-DeviceState <WindowsDeviceHealthState>] [-EngineVersion <String>] [-FullScanOverdue] [-FullScanRequired]
 [-Id <String>] [-IsVirtualMachine] [-LastFullScanDateTime <DateTime>]
 [-LastFullScanSignatureVersion <String>] [-LastQuickScanDateTime <DateTime>]
 [-LastQuickScanSignatureVersion <String>] [-LastReportedDateTime <DateTime>] [-MalwareProtectionEnabled]
 [-NetworkInspectionSystemEnabled] [-ProductStatus <WindowsDefenderProductStatus>] [-QuickScanOverdue]
 [-RealTimeProtectionEnabled] [-RebootRequired] [-SignatureUpdateOverdue] [-SignatureVersion <String>]
 [-TamperProtectionEnabled] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a windowsProtectionState object.

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AntiMalwareVersion
Current anti malware version

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

### -BodyParameter
Device protection status entity.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsProtectionState
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DetectedMalwareState
Device malware list
To construct, see NOTES section for DETECTEDMALWARESTATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDeviceMalwareState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceState
Computer endpoint protection state

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsDeviceHealthState
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EngineVersion
Current endpoint protection engine's version

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

### -FullScanOverdue
When TRUE indicates full scan is overdue, when FALSE indicates full scan is not overdue.
Defaults to setting on client device.

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

### -FullScanRequired
When TRUE indicates full scan is required, when FALSE indicates full scan is not required.
Defaults to setting on client device.

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

### -Id
The unique idenfier for an entity.
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
Type: Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsVirtualMachine
When TRUE indicates the device is a virtual machine, when FALSE indicates the device is not a virtual machine.
Defaults to setting on client device.

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

### -LastFullScanDateTime
Last quick scan datetime

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

### -LastFullScanSignatureVersion
Last full scan signature version

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

### -LastQuickScanDateTime
Last quick scan datetime

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

### -LastQuickScanSignatureVersion
Last quick scan signature version

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

### -LastReportedDateTime
Last device health status reported time

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

### -MalwareProtectionEnabled
When TRUE indicates anti malware is enabled when FALSE indicates anti malware is not enabled.

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

### -ManagedDeviceId
The unique identifier of managedDevice

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

### -NetworkInspectionSystemEnabled
When TRUE indicates network inspection system enabled, when FALSE indicates network inspection system is not enabled.
Defaults to setting on client device.

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

### -ProductStatus
Product Status of Windows Defender

```yaml
Type: Microsoft.Graph.PowerShell.Support.WindowsDefenderProductStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QuickScanOverdue
When TRUE indicates quick scan is overdue, when FALSE indicates quick scan is not overdue.
Defaults to setting on client device.

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

### -RealTimeProtectionEnabled
When TRUE indicates real time protection is enabled, when FALSE indicates real time protection is not enabled.
Defaults to setting on client device.

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

### -RebootRequired
When TRUE indicates reboot is required, when FALSE indicates when TRUE indicates reboot is not required.
Defaults to setting on client device.

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

### -SignatureUpdateOverdue
When TRUE indicates signature is out of date, when FALSE indicates signature is not out of date.
Defaults to setting on client device.

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

### -SignatureVersion
Current malware definitions version

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

### -TamperProtectionEnabled
When TRUE indicates the Windows Defender tamper protection feature is enabled, when FALSE indicates the Windows Defender tamper protection feature is not enabled.
Defaults to setting on client device.

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

### -UserId
The unique identifier of user

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

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsProtectionState

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsProtectionState

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsProtectionState>`: Device protection status entity.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AntiMalwareVersion <String>]`: Current anti malware version
  - `[DetectedMalwareState <IMicrosoftGraphWindowsDeviceMalwareState[]>]`: Device malware list
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AdditionalInformationUrl <String>]`: Information URL to learn more about the malware
    - `[Category <WindowsMalwareCategory?>]`: Malware category id
    - `[DetectionCount <Int32?>]`: Number of times the malware is detected
    - `[DisplayName <String>]`: Malware name
    - `[ExecutionState <WindowsMalwareExecutionState?>]`: Malware execution status
    - `[InitialDetectionDateTime <DateTime?>]`: Initial detection datetime of the malware
    - `[LastStateChangeDateTime <DateTime?>]`: The last time this particular threat was changed
    - `[Severity <WindowsMalwareSeverity?>]`: Malware severity
    - `[State <WindowsMalwareState?>]`: Malware current status
    - `[ThreatState <WindowsMalwareThreatState?>]`: Malware threat status
  - `[DeviceState <WindowsDeviceHealthState?>]`: Computer endpoint protection state
  - `[EngineVersion <String>]`: Current endpoint protection engine's version
  - `[FullScanOverdue <Boolean?>]`: When TRUE indicates full scan is overdue, when FALSE indicates full scan is not overdue. Defaults to setting on client device.
  - `[FullScanRequired <Boolean?>]`: When TRUE indicates full scan is required, when FALSE indicates full scan is not required. Defaults to setting on client device.
  - `[IsVirtualMachine <Boolean?>]`: When TRUE indicates the device is a virtual machine, when FALSE indicates the device is not a virtual machine. Defaults to setting on client device.
  - `[LastFullScanDateTime <DateTime?>]`: Last quick scan datetime
  - `[LastFullScanSignatureVersion <String>]`: Last full scan signature version
  - `[LastQuickScanDateTime <DateTime?>]`: Last quick scan datetime
  - `[LastQuickScanSignatureVersion <String>]`: Last quick scan signature version
  - `[LastReportedDateTime <DateTime?>]`: Last device health status reported time
  - `[MalwareProtectionEnabled <Boolean?>]`: When TRUE indicates anti malware is enabled when FALSE indicates anti malware is not enabled.
  - `[NetworkInspectionSystemEnabled <Boolean?>]`: When TRUE indicates network inspection system enabled, when FALSE indicates network inspection system is not enabled. Defaults to setting on client device.
  - `[ProductStatus <WindowsDefenderProductStatus?>]`: Product Status of Windows Defender
  - `[QuickScanOverdue <Boolean?>]`: When TRUE indicates quick scan is overdue, when FALSE indicates quick scan is not overdue. Defaults to setting on client device.
  - `[RealTimeProtectionEnabled <Boolean?>]`: When TRUE indicates real time protection is enabled, when FALSE indicates real time protection is not enabled. Defaults to setting on client device.
  - `[RebootRequired <Boolean?>]`: When TRUE indicates reboot is required, when FALSE indicates when TRUE indicates reboot is not required. Defaults to setting on client device.
  - `[SignatureUpdateOverdue <Boolean?>]`: When TRUE indicates signature is out of date, when FALSE indicates signature is not out of date. Defaults to setting on client device.
  - `[SignatureVersion <String>]`: Current malware definitions version
  - `[TamperProtectionEnabled <Boolean?>]`: When TRUE indicates the Windows Defender tamper protection feature is enabled, when FALSE indicates the Windows Defender tamper protection feature is not enabled. Defaults to setting on client device.

`DETECTEDMALWARESTATE <IMicrosoftGraphWindowsDeviceMalwareState[]>`: Device malware list
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdditionalInformationUrl <String>]`: Information URL to learn more about the malware
  - `[Category <WindowsMalwareCategory?>]`: Malware category id
  - `[DetectionCount <Int32?>]`: Number of times the malware is detected
  - `[DisplayName <String>]`: Malware name
  - `[ExecutionState <WindowsMalwareExecutionState?>]`: Malware execution status
  - `[InitialDetectionDateTime <DateTime?>]`: Initial detection datetime of the malware
  - `[LastStateChangeDateTime <DateTime?>]`: The last time this particular threat was changed
  - `[Severity <WindowsMalwareSeverity?>]`: Malware severity
  - `[State <WindowsMalwareState?>]`: Malware current status
  - `[ThreatState <WindowsMalwareThreatState?>]`: Malware threat status

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
  - `[MobileAppId <String>]`: The unique identifier of mobileApp
  - `[TargetedManagedAppConfigurationId <String>]`: The unique identifier of targetedManagedAppConfiguration
  - `[TargetedManagedAppPolicyAssignmentId <String>]`: The unique identifier of targetedManagedAppPolicyAssignment
  - `[UserId <String>]`: The unique identifier of user
  - `[UserInstallStateSummaryId <String>]`: The unique identifier of userInstallStateSummary
  - `[VppTokenId <String>]`: The unique identifier of vppToken
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsInformationProtectionAppLockerFileId <String>]`: The unique identifier of windowsInformationProtectionAppLockerFile
  - `[WindowsInformationProtectionPolicyId <String>]`: The unique identifier of windowsInformationProtectionPolicy

## RELATED LINKS

