---
external help file:
Module Name: Microsoft.Graph.DevicesApps.DeviceAppManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.deviceappmanagement/new-mgdeviceappmanagementwdacsupplementalpolicy
schema: 2.0.0
---

# New-MgDeviceAppManagementWdacSupplementalPolicy

## SYNOPSIS
Create new navigation property to wdacSupplementalPolicies for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppManagementWdacSupplementalPolicy
 [-Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]
 [-ContentFileName <String>] [-ContentInputFile <String>] [-CreationDateTime <DateTime>]
 [-DeploySummaryDeployedDeviceCount <Int32>] [-DeploySummaryFailedDeviceCount <Int32>]
 [-DeploySummaryId <String>] [-Description <String>]
 [-DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTagIds <String[]>]
 [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppManagementWdacSupplementalPolicy
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to wdacSupplementalPolicies for deviceAppManagement

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
The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
windowsDefenderApplicationControlSupplementalPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentFileName
The WindowsDefenderApplicationControl supplemental policy content's file name.

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

### -ContentInputFile
Input File for Content (The WindowsDefenderApplicationControl supplemental policy content in byte array format.)

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

### -CreationDateTime
The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.

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

### -DeploySummaryDeployedDeviceCount
Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.

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

### -DeploySummaryFailedDeviceCount
Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.

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

### -DeploySummaryId
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

### -Description
The description of WindowsDefenderApplicationControl supplemental policy.

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
The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
To construct, see NOTES section for DEVICESTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of WindowsDefenderApplicationControl supplemental policy.

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

### -LastModifiedDateTime
The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.

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

### -RoleScopeTagIds
List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.

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

### -Version
The WindowsDefenderApplicationControl supplemental policy's version.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget

BODYPARAMETER <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>: windowsDefenderApplicationControlSupplementalPolicy
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[Content <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  - `[ContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
  - `[CreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryId <String>]`: Read-only.
  - `[Description <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
  - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
    - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
    - `[DeploySummaryId <String>]`: Read-only.
    - `[DeploymentStatus <String>]`: windowsDefenderApplicationControlSupplementalPolicyStatuses
    - `[DeviceId <String>]`: Device ID.
    - `[DeviceName <String>]`: Device name.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
    - `[OSDescription <String>]`: Windows OS Version Description.
    - `[OSVersion <String>]`: Windows OS Version.
    - `[PolicyAssignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyContent <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
    - `[PolicyContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
    - `[PolicyCreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
    - `[PolicyDescription <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyDeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyDisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
    - `[PolicyId <String>]`: Read-only.
    - `[PolicyLastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
    - `[PolicyRoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
    - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
    - `[UserName <String>]`: The name of the user of this device.
    - `[UserPrincipalName <String>]`: User Principal Name.
    - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.
  - `[DisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.

DEVICESTATUSES <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
  - `[Id <String>]`: Read-only.
  - `[DeploySummaryDeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryFailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[DeploySummaryId <String>]`: Read-only.
  - `[DeploymentStatus <String>]`: windowsDefenderApplicationControlSupplementalPolicyStatuses
  - `[DeviceId <String>]`: Device ID.
  - `[DeviceName <String>]`: Device name.
  - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
  - `[OSDescription <String>]`: Windows OS Version Description.
  - `[OSVersion <String>]`: Windows OS Version.
  - `[PolicyAssignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: deviceAndAppManagementAssignmentTarget
  - `[PolicyContent <Byte[]>]`: The WindowsDefenderApplicationControl supplemental policy content in byte array format.
  - `[PolicyContentFileName <String>]`: The WindowsDefenderApplicationControl supplemental policy content's file name.
  - `[PolicyCreationDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was uploaded.
  - `[PolicyDescription <String>]`: The description of WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyDeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyDisplayName <String>]`: The display name of WindowsDefenderApplicationControl supplemental policy.
  - `[PolicyId <String>]`: Read-only.
  - `[PolicyLastModifiedDateTime <DateTime?>]`: The date and time when the WindowsDefenderApplicationControl supplemental policy was last modified.
  - `[PolicyRoleScopeTagIds <String[]>]`: List of Scope Tags for this WindowsDefenderApplicationControl supplemental policy entity.
  - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
  - `[UserName <String>]`: The name of the user of this device.
  - `[UserPrincipalName <String>]`: User Principal Name.
  - `[Version <String>]`: The WindowsDefenderApplicationControl supplemental policy's version.

## RELATED LINKS

