---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/test-mgbetadevicemanagementassignmentfilter
schema: 2.0.0
---

# Test-MgBetaDeviceManagementAssignmentFilter

## SYNOPSIS
Invoke action validateFilter

## SYNTAX

### ValidateExpanded (Default)
```
Test-MgBetaDeviceManagementAssignmentFilter [-AdditionalProperties <Hashtable>]
 [-DeviceAndAppManagementAssignmentFilter <IMicrosoftGraphDeviceAndAppManagementAssignmentFilter>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Validate
```
Test-MgBetaDeviceManagementAssignmentFilter
 -BodyParameter <IPaths1Y9WuhoDevicemanagementAssignmentfiltersMicrosoftGraphValidatefilterPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action validateFilter

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
Parameter Sets: ValidateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Y9WuhoDevicemanagementAssignmentfiltersMicrosoftGraphValidatefilterPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Validate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceAndAppManagementAssignmentFilter
A class containing the properties used for Assignment Filter.
To construct, see NOTES section for DEVICEANDAPPMANAGEMENTASSIGNMENTFILTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceAndAppManagementAssignmentFilter
Parameter Sets: ValidateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Y9WuhoDevicemanagementAssignmentfiltersMicrosoftGraphValidatefilterPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1Y9WuhoDevicemanagementAssignmentfiltersMicrosoftGraphValidatefilterPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeviceAndAppManagementAssignmentFilter <IMicrosoftGraphDeviceAndAppManagementAssignmentFilter>]`: A class containing the properties used for Assignment Filter.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AssignmentFilterManagementType <AssignmentFilterManagementType?>]`: Supported filter management types whether its devices or apps.
    - `[CreatedDateTime <DateTime?>]`: The creation time of the assignment filter. The value cannot be modified and is automatically populated during new assignment filter process. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
    - `[Description <String>]`: Optional description of the Assignment Filter.
    - `[DisplayName <String>]`: The name of the Assignment Filter.
    - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the Assignment Filter. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Payloads <IMicrosoftGraphPayloadByFilter[]>]`: Indicates associated assignments for a specific filter.
      - `[AssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
      - `[GroupId <String>]`: The Azure AD security group ID
      - `[PayloadId <String>]`: The policy identifier
      - `[PayloadType <AssociatedAssignmentPayloadType?>]`: This enum represents associated assignment payload type
    - `[Platform <DevicePlatformType?>]`: Supported platform types.
    - `[RoleScopeTags <String[]>]`: Indicates role scope tags assigned for the assignment filter.
    - `[Rule <String>]`: Rule definition of the assignment filter.

`DEVICEANDAPPMANAGEMENTASSIGNMENTFILTER <IMicrosoftGraphDeviceAndAppManagementAssignmentFilter>`: A class containing the properties used for Assignment Filter.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AssignmentFilterManagementType <AssignmentFilterManagementType?>]`: Supported filter management types whether its devices or apps.
  - `[CreatedDateTime <DateTime?>]`: The creation time of the assignment filter. The value cannot be modified and is automatically populated during new assignment filter process. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
  - `[Description <String>]`: Optional description of the Assignment Filter.
  - `[DisplayName <String>]`: The name of the Assignment Filter.
  - `[LastModifiedDateTime <DateTime?>]`: Last modified time of the Assignment Filter. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Payloads <IMicrosoftGraphPayloadByFilter[]>]`: Indicates associated assignments for a specific filter.
    - `[AssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
    - `[GroupId <String>]`: The Azure AD security group ID
    - `[PayloadId <String>]`: The policy identifier
    - `[PayloadType <AssociatedAssignmentPayloadType?>]`: This enum represents associated assignment payload type
  - `[Platform <DevicePlatformType?>]`: Supported platform types.
  - `[RoleScopeTags <String[]>]`: Indicates role scope tags assigned for the assignment filter.
  - `[Rule <String>]`: Rule definition of the assignment filter.

## RELATED LINKS

