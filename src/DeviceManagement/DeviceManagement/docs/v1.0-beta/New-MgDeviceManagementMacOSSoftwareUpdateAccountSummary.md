---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement/new-mgdevicemanagementmacossoftwareupdateaccountsummary
schema: 2.0.0
---

# New-MgBetaDeviceManagementMacOSSoftwareUpdateAccountSummary

## SYNOPSIS
Create new navigation property to macOSSoftwareUpdateAccountSummaries for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementMacOSSoftwareUpdateAccountSummary [-AdditionalProperties <Hashtable>]
 [-CategorySummaries <IMicrosoftGraphMacOSSoftwareUpdateCategorySummary[]>] [-DeviceId <String>]
 [-DeviceName <String>] [-DisplayName <String>] [-FailedUpdateCount <Int32>] [-Id <String>]
 [-LastUpdatedDateTime <DateTime>] [-OSVersion <String>] [-SuccessfulUpdateCount <Int32>]
 [-TotalUpdateCount <Int32>] [-UserId <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementMacOSSoftwareUpdateAccountSummary
 -BodyParameter <IMicrosoftGraphMacOSSoftwareUpdateAccountSummary> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to macOSSoftwareUpdateAccountSummaries for deviceManagement

## EXAMPLES

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

### -BodyParameter
MacOS software update account summary report for a device and user
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMacOSSoftwareUpdateAccountSummary
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CategorySummaries
Summary of the updates by category.
To construct, please use Get-Help -Online and see NOTES section for CATEGORYSUMMARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMacOSSoftwareUpdateCategorySummary[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceId
The device ID.

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

### -DeviceName
The device name.

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

### -DisplayName
The name of the report

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

### -FailedUpdateCount
Number of failed updates on the device.

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

### -Id
The unique idenfier for an entity.
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

### -LastUpdatedDateTime
Last date time the report for this device was updated.

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

### -OSVersion
The OS version.

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

### -SuccessfulUpdateCount
Number of successful updates on the device.

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

### -TotalUpdateCount
Number of total updates on the device.

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

### -UserId
The user ID.

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
The user principal name

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMacOSSoftwareUpdateAccountSummary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMacOSSoftwareUpdateAccountSummary

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphMacOSSoftwareUpdateAccountSummary>: MacOS software update account summary report for a device and user
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CategorySummaries <IMicrosoftGraphMacOSSoftwareUpdateCategorySummary[]>]`: Summary of the updates by category.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DeviceId <String>]`: The device ID.
    - `[DisplayName <String>]`: The name of the report
    - `[FailedUpdateCount <Int32?>]`: Number of failed updates on the device
    - `[LastUpdatedDateTime <DateTime?>]`: Last date time the report for this device was updated.
    - `[SuccessfulUpdateCount <Int32?>]`: Number of successful updates on the device
    - `[TotalUpdateCount <Int32?>]`: Number of total updates on the device
    - `[UpdateCategory <MacOSSoftwareUpdateCategory?>]`: MacOS Software Update Category
    - `[UpdateStateSummaries <IMicrosoftGraphMacOSSoftwareUpdateStateSummary[]>]`: Summary of the update states.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[DisplayName <String>]`: Human readable name of the software update
      - `[LastUpdatedDateTime <DateTime?>]`: Last date time the report for this device and product key was updated.
      - `[ProductKey <String>]`: Product key of the software update.
      - `[State <MacOSSoftwareUpdateState?>]`: MacOS Software Update State
      - `[UpdateCategory <MacOSSoftwareUpdateCategory?>]`: MacOS Software Update Category
      - `[UpdateVersion <String>]`: Version of the software update
    - `[UserId <String>]`: The user ID.
  - `[DeviceId <String>]`: The device ID.
  - `[DeviceName <String>]`: The device name.
  - `[DisplayName <String>]`: The name of the report
  - `[FailedUpdateCount <Int32?>]`: Number of failed updates on the device.
  - `[LastUpdatedDateTime <DateTime?>]`: Last date time the report for this device was updated.
  - `[OSVersion <String>]`: The OS version.
  - `[SuccessfulUpdateCount <Int32?>]`: Number of successful updates on the device.
  - `[TotalUpdateCount <Int32?>]`: Number of total updates on the device.
  - `[UserId <String>]`: The user ID.
  - `[UserPrincipalName <String>]`: The user principal name

CATEGORYSUMMARIES <IMicrosoftGraphMacOSSoftwareUpdateCategorySummary[]>: Summary of the updates by category.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeviceId <String>]`: The device ID.
  - `[DisplayName <String>]`: The name of the report
  - `[FailedUpdateCount <Int32?>]`: Number of failed updates on the device
  - `[LastUpdatedDateTime <DateTime?>]`: Last date time the report for this device was updated.
  - `[SuccessfulUpdateCount <Int32?>]`: Number of successful updates on the device
  - `[TotalUpdateCount <Int32?>]`: Number of total updates on the device
  - `[UpdateCategory <MacOSSoftwareUpdateCategory?>]`: MacOS Software Update Category
  - `[UpdateStateSummaries <IMicrosoftGraphMacOSSoftwareUpdateStateSummary[]>]`: Summary of the update states.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DisplayName <String>]`: Human readable name of the software update
    - `[LastUpdatedDateTime <DateTime?>]`: Last date time the report for this device and product key was updated.
    - `[ProductKey <String>]`: Product key of the software update.
    - `[State <MacOSSoftwareUpdateState?>]`: MacOS Software Update State
    - `[UpdateCategory <MacOSSoftwareUpdateCategory?>]`: MacOS Software Update Category
    - `[UpdateVersion <String>]`: Version of the software update
  - `[UserId <String>]`: The user ID.

## RELATED LINKS

