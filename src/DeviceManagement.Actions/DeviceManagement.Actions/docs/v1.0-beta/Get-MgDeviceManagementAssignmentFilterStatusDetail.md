---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/get-mgdevicemanagementassignmentfilterstatusdetail
schema: 2.0.0
---

# Get-MgDeviceManagementAssignmentFilterStatusDetail

## SYNOPSIS
Invoke action getAssignmentFiltersStatusDetails

## SYNTAX

### GetExpanded (Default)
```
Get-MgDeviceManagementAssignmentFilterStatusDetail [-AdditionalProperties <Hashtable>]
 [-AssignmentFilterIds <String[]>] [-ManagedDeviceId <String>] [-PayloadId <String>] [-Skip <Int32>]
 [-Top <Int32>] [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgDeviceManagementAssignmentFilterStatusDetail
 -BodyParameter <IPaths1Dv3M96DevicemanagementMicrosoftGraphGetassignmentfiltersstatusdetailsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getAssignmentFiltersStatusDetails

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentFilterIds
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Dv3M96DevicemanagementMicrosoftGraphGetassignmentfiltersstatusdetailsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceId
.

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PayloadId
.

```yaml
Type: System.String
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
.

```yaml
Type: System.Int32
Parameter Sets: GetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
.

```yaml
Type: System.Int32
Parameter Sets: GetExpanded
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: GetExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Dv3M96DevicemanagementMicrosoftGraphGetassignmentfiltersstatusdetailsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAssignmentFilterStatusDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Dv3M96DevicemanagementMicrosoftGraphGetassignmentfiltersstatusdetailsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignmentFilterIds <String[]>]`: 
  - `[ManagedDeviceId <String>]`: 
  - `[PayloadId <String>]`: 
  - `[Skip <Int32?>]`: 
  - `[Top <Int32?>]`: 
  - `[UserId <String>]`: 

## RELATED LINKS

