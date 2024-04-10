---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/new-mgbetadevicemanagementmanageddeviceencryptionstate
schema: 2.0.0
---

# New-MgBetaDeviceManagementManagedDeviceEncryptionState

## SYNOPSIS
Create new navigation property to managedDeviceEncryptionStates for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementManagedDeviceEncryptionState [-AdditionalProperties <Hashtable>]
 [-AdvancedBitLockerStates <AdvancedBitLockerState>] [-DeviceName <String>] [-DeviceType <DeviceTypes>]
 [-EncryptionPolicySettingState <String>] [-EncryptionReadinessState <EncryptionReadinessState>]
 [-EncryptionState <EncryptionState>] [-FileVaultStates <FileVaultState>] [-Id <String>] [-OSVersion <String>]
 [-PolicyDetails <IMicrosoftGraphEncryptionReportPolicyDetails[]>] [-ResponseHeadersVariable <String>]
 [-TpmSpecificationVersion <String>] [-UserPrincipalName <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementManagedDeviceEncryptionState
 -BodyParameter <IMicrosoftGraphManagedDeviceEncryptionState> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedDeviceEncryptionStates for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -AdvancedBitLockerStates
Advanced BitLocker State

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.AdvancedBitLockerState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Encryption report per device
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedDeviceEncryptionState
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceName
Device name

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

### -DeviceType
Device type.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceTypes
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptionPolicySettingState
complianceStatus

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

### -EncryptionReadinessState
Encryption readiness state

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.EncryptionReadinessState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EncryptionState
Encryption state

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.EncryptionState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileVaultStates
FileVault State

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.FileVaultState
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

### -OSVersion
Operating system version of the device

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

### -PolicyDetails
Policy Details
To construct, see NOTES section for POLICYDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEncryptionReportPolicyDetails[]
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

### -TpmSpecificationVersion
Device TPM Version

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

### -UserPrincipalName
User name

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedDeviceEncryptionState

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedDeviceEncryptionState

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedDeviceEncryptionState>`: Encryption report per device
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdvancedBitLockerStates <AdvancedBitLockerState?>]`: Advanced BitLocker State
  - `[DeviceName <String>]`: Device name
  - `[DeviceType <DeviceTypes?>]`: Device type.
  - `[EncryptionPolicySettingState <String>]`: complianceStatus
  - `[EncryptionReadinessState <EncryptionReadinessState?>]`: Encryption readiness state
  - `[EncryptionState <EncryptionState?>]`: Encryption state
  - `[FileVaultStates <FileVaultState?>]`: FileVault State
  - `[OSVersion <String>]`: Operating system version of the device
  - `[PolicyDetails <IMicrosoftGraphEncryptionReportPolicyDetails[]>]`: Policy Details
    - `[PolicyId <String>]`: Policy Id for Encryption Report
    - `[PolicyName <String>]`: Policy Name for Encryption Report
  - `[TpmSpecificationVersion <String>]`: Device TPM Version
  - `[UserPrincipalName <String>]`: User name

`POLICYDETAILS <IMicrosoftGraphEncryptionReportPolicyDetails[]>`: Policy Details
  - `[PolicyId <String>]`: Policy Id for Encryption Report
  - `[PolicyName <String>]`: Policy Name for Encryption Report

## RELATED LINKS

