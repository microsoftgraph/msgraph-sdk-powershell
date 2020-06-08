---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/new-mgteamworkactivitynotification
schema: 2.0.0
---

# New-MgTeamworkActivityNotification

## SYNOPSIS
Invoke action generateActivityNotification

## SYNTAX

### GenerateExpanded (Default)
```
New-MgTeamworkActivityNotification [-About <String>] [-ActivityType <String>] [-AggregationId <Int64>]
 [-OnClickWebUrl <String>] [-PreviewText <String>] [-Recipient <IMicrosoftGraphTeamworkNotificationAudience>]
 [-TeamsAppId <String>] [-TemplateParameters <IMicrosoftGraphKeyValuePair[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Generate
```
New-MgTeamworkActivityNotification
 -BodyParameter <IPaths1Vqmvy2TeamworkMicrosoftGraphGenerateactivitynotificationPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action generateActivityNotification

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

### -About
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityType
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AggregationId
.

```yaml
Type: System.Int64
Parameter Sets: GenerateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Vqmvy2TeamworkMicrosoftGraphGenerateactivitynotificationPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Generate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OnClickWebUrl
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreviewText
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recipient
teamworkNotificationAudience

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkNotificationAudience
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId
.

```yaml
Type: System.String
Parameter Sets: GenerateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateParameters
.
To construct, see NOTES section for TEMPLATEPARAMETERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: GenerateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Vqmvy2TeamworkMicrosoftGraphGenerateactivitynotificationPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Vqmvy2TeamworkMicrosoftGraphGenerateactivitynotificationPostRequestbodyContentApplicationJsonSchema>: .
  - `[About <String>]`: 
  - `[ActivityType <String>]`: 
  - `[AggregationId <Int64?>]`: 
  - `[OnClickWebUrl <String>]`: 
  - `[PreviewText <String>]`: 
  - `[Recipient <IMicrosoftGraphTeamworkNotificationAudience>]`: teamworkNotificationAudience
  - `[TeamsAppId <String>]`: 
  - `[TemplateParameters <IMicrosoftGraphKeyValuePair[]>]`: 
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair

TEMPLATEPARAMETERS <IMicrosoftGraphKeyValuePair[]>: .
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

## RELATED LINKS

