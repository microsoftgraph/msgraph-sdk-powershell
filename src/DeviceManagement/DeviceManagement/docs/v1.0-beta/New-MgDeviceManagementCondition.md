---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementcondition
schema: 2.0.0
---

# New-MgDeviceManagementCondition

## SYNOPSIS
The management conditions associated with device management of the company.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementCondition [-AdditionalProperties <Hashtable>] [-ApplicablePlatforms <String[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-ETag <String>] [-Id <String>]
 [-ManagementConditionStatements <IMicrosoftGraphManagementConditionStatement[]>]
 [-ModifiedDateTime <DateTime>] [-UniqueName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementCondition -BodyParameter <IMicrosoftGraphManagementCondition> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The management conditions associated with device management of the company.

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

### -ApplicablePlatforms
The applicable platforms for this management condition.

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

### -BodyParameter
Management conditions are events that can be triggered dynamically such as geo-fences, time-fences, and network-fences.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagementCondition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The time the management condition was created.
Generated service side.

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
The admin defined description of the management condition.

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
The admin defined name of the management condition.

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

### -ETag
ETag of the management condition.
Updated service side.

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

### -ManagementConditionStatements
The management condition statements associated to the management condition.
To construct, please use Get-Help -Online and see NOTES section for MANAGEMENTCONDITIONSTATEMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagementConditionStatement[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The time the management condition was last modified.
Updated service side.

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

### -UniqueName
Unique name for the management condition.
Used in management condition expressions.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagementCondition

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagementCondition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagementCondition>: Management conditions are events that can be triggered dynamically such as geo-fences, time-fences, and network-fences.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ApplicablePlatforms <String[]>]`: The applicable platforms for this management condition.
  - `[CreatedDateTime <DateTime?>]`: The time the management condition was created. Generated service side.
  - `[Description <String>]`: The admin defined description of the management condition.
  - `[DisplayName <String>]`: The admin defined name of the management condition.
  - `[ETag <String>]`: ETag of the management condition. Updated service side.
  - `[ManagementConditionStatements <IMicrosoftGraphManagementConditionStatement[]>]`: The management condition statements associated to the management condition.
    - `[Id <String>]`: Read-only.
    - `[ApplicablePlatforms <String[]>]`: The applicable platforms for this management condition statement.
    - `[CreatedDateTime <DateTime?>]`: The time the management condition statement was created. Generated service side.
    - `[Description <String>]`: The admin defined description of the management condition statement.
    - `[DisplayName <String>]`: The admin defined name of the management condition statement.
    - `[ETag <String>]`: ETag of the management condition statement. Updated service side.
    - `[Expression <IMicrosoftGraphManagementConditionExpression>]`: A management condition expression is an expression that produces a boolean value when evaluated, i.e. one of true or false, indicating that a management condition statement is activated/deactivated. A management condition expression may be composed of a combination of the expression variables and boolean-valued expression operators.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ManagementConditions <IMicrosoftGraphManagementCondition[]>]`: The management conditions associated to the management condition statement.
    - `[ModifiedDateTime <DateTime?>]`: The time the management condition statement was last modified. Updated service side.
  - `[ModifiedDateTime <DateTime?>]`: The time the management condition was last modified. Updated service side.
  - `[UniqueName <String>]`: Unique name for the management condition. Used in management condition expressions.

MANAGEMENTCONDITIONSTATEMENTS <IMicrosoftGraphManagementConditionStatement[]>: The management condition statements associated to the management condition.
  - `[Id <String>]`: Read-only.
  - `[ApplicablePlatforms <String[]>]`: The applicable platforms for this management condition statement.
  - `[CreatedDateTime <DateTime?>]`: The time the management condition statement was created. Generated service side.
  - `[Description <String>]`: The admin defined description of the management condition statement.
  - `[DisplayName <String>]`: The admin defined name of the management condition statement.
  - `[ETag <String>]`: ETag of the management condition statement. Updated service side.
  - `[Expression <IMicrosoftGraphManagementConditionExpression>]`: A management condition expression is an expression that produces a boolean value when evaluated, i.e. one of true or false, indicating that a management condition statement is activated/deactivated. A management condition expression may be composed of a combination of the expression variables and boolean-valued expression operators.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagementConditions <IMicrosoftGraphManagementCondition[]>]`: The management conditions associated to the management condition statement.
    - `[Id <String>]`: Read-only.
    - `[ApplicablePlatforms <String[]>]`: The applicable platforms for this management condition.
    - `[CreatedDateTime <DateTime?>]`: The time the management condition was created. Generated service side.
    - `[Description <String>]`: The admin defined description of the management condition.
    - `[DisplayName <String>]`: The admin defined name of the management condition.
    - `[ETag <String>]`: ETag of the management condition. Updated service side.
    - `[ManagementConditionStatements <IMicrosoftGraphManagementConditionStatement[]>]`: The management condition statements associated to the management condition.
    - `[ModifiedDateTime <DateTime?>]`: The time the management condition was last modified. Updated service side.
    - `[UniqueName <String>]`: Unique name for the management condition. Used in management condition expressions.
  - `[ModifiedDateTime <DateTime?>]`: The time the management condition statement was last modified. Updated service side.

## RELATED LINKS

