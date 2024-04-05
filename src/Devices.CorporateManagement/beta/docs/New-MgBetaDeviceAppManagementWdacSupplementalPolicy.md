---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.corporatemanagement/new-mgbetadeviceappmanagementwdacsupplementalpolicy
schema: 2.0.0
---

# New-MgBetaDeviceAppManagementWdacSupplementalPolicy

## SYNOPSIS
Create new navigation property to wdacSupplementalPolicies for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceAppManagementWdacSupplementalPolicy [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]
 [-ContentFileName <String>] [-ContentInputFile <String>] [-CreationDateTime <DateTime>]
 [-DeploySummary <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>]
 [-Description <String>]
 [-DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]
 [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-ResponseHeadersVariable <String>]
 [-RoleScopeTagIds <String[]>] [-Version <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceAppManagementWdacSupplementalPolicy
 -BodyParameter <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to wdacSupplementalPolicies for deviceAppManagement

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The associated group assignments for the Windows Defender Application Control Supplemental Policy.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentFileName
Indicates the file name associated with the content of the Windows Defender Application Control Supplemental Policy.

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
Input File for Content (Indicates the content of the Windows Defender Application Control Supplemental Policy in byte array format.)

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
Indicates the created date and time when the Windows Defender Application Control Supplemental Policy was uploaded.

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

### -DeploySummary
Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
To construct, see NOTES section for DEPLOYSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the Windows Defender Application Control Supplemental Policy.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the Windows Defender Application Control Supplemental Policy.

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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
Indicates the last modified date and time of the Windows Defender Application Control Supplemental Policy.

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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for the Windows Defender Application Control Supplemental Policy entity.

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
Indicates the Windows Defender Application Control Supplemental Policy's version.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy

## NOTES

ALIASES

New-MgBetaDeviceAppMgtWdacSupplementalPolicy

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNMENTS <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>`: The associated group assignments for the Windows Defender Application Control Supplemental Policy.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

`BODYPARAMETER <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>`: windowsDefenderApplicationControlSupplementalPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for the Windows Defender Application Control Supplemental Policy.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[Content <Byte[]>]`: Indicates the content of the Windows Defender Application Control Supplemental Policy in byte array format.
  - `[ContentFileName <String>]`: Indicates the file name associated with the content of the Windows Defender Application Control Supplemental Policy.
  - `[CreationDateTime <DateTime?>]`: Indicates the created date and time when the Windows Defender Application Control Supplemental Policy was uploaded.
  - `[DeploySummary <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>]`: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
    - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
  - `[Description <String>]`: The description of the Windows Defender Application Control Supplemental Policy.
  - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeploymentStatus <WindowsDefenderApplicationControlSupplementalPolicyStatuses?>]`: Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.
    - `[DeviceId <String>]`: Device ID.
    - `[DeviceName <String>]`: Device name.
    - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
    - `[OSDescription <String>]`: Windows OS Version Description.
    - `[OSVersion <String>]`: Windows OS Version.
    - `[Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>]`: windowsDefenderApplicationControlSupplementalPolicy
    - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
    - `[UserName <String>]`: The name of the user of this device.
    - `[UserPrincipalName <String>]`: User Principal Name.
  - `[DisplayName <String>]`: The display name of the Windows Defender Application Control Supplemental Policy.
  - `[LastModifiedDateTime <DateTime?>]`: Indicates the last modified date and time of the Windows Defender Application Control Supplemental Policy.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for the Windows Defender Application Control Supplemental Policy entity.
  - `[Version <String>]`: Indicates the Windows Defender Application Control Supplemental Policy's version.

`DEPLOYSUMMARY <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>`: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
  - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.

`DEVICESTATUSES <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeploymentStatus <WindowsDefenderApplicationControlSupplementalPolicyStatuses?>]`: Enum values for the various WindowsDefenderApplicationControl supplemental policy deployment statuses.
  - `[DeviceId <String>]`: Device ID.
  - `[DeviceName <String>]`: Device name.
  - `[LastSyncDateTime <DateTime?>]`: Last sync date time.
  - `[OSDescription <String>]`: Windows OS Version Description.
  - `[OSVersion <String>]`: Windows OS Version.
  - `[Policy <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicy>]`: windowsDefenderApplicationControlSupplementalPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Assignments <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyAssignment[]>]`: The associated group assignments for the Windows Defender Application Control Supplemental Policy.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
        - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[Content <Byte[]>]`: Indicates the content of the Windows Defender Application Control Supplemental Policy in byte array format.
    - `[ContentFileName <String>]`: Indicates the file name associated with the content of the Windows Defender Application Control Supplemental Policy.
    - `[CreationDateTime <DateTime?>]`: Indicates the created date and time when the Windows Defender Application Control Supplemental Policy was uploaded.
    - `[DeploySummary <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>]`: Contains properties for the deployment summary of a WindowsDefenderApplicationControl supplemental policy.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeployedDeviceCount <Int32?>]`: Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
      - `[FailedDeviceCount <Int32?>]`: Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
    - `[Description <String>]`: The description of the Windows Defender Application Control Supplemental Policy.
    - `[DeviceStatuses <IMicrosoftGraphWindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus[]>]`: The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.
    - `[DisplayName <String>]`: The display name of the Windows Defender Application Control Supplemental Policy.
    - `[LastModifiedDateTime <DateTime?>]`: Indicates the last modified date and time of the Windows Defender Application Control Supplemental Policy.
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for the Windows Defender Application Control Supplemental Policy entity.
    - `[Version <String>]`: Indicates the Windows Defender Application Control Supplemental Policy's version.
  - `[PolicyVersion <String>]`: Human readable version of the WindowsDefenderApplicationControl supplemental policy.
  - `[UserName <String>]`: The name of the user of this device.
  - `[UserPrincipalName <String>]`: User Principal Name.

## RELATED LINKS

