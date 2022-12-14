---
external help file:
Module Name: Microsoft.Graph.Beta.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.cloudcommunications/get-mgcommunicationpresencebyuserid
schema: 2.0.0
---

# Get-MgBetaCommunicationPresenceByUserId

## SYNOPSIS
Get the presence information for multiple users.

## SYNTAX

### GetExpanded1 (Default)
```
Get-MgBetaCommunicationPresenceByUserId [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Get1
```
Get-MgBetaCommunicationPresenceByUserId
 -BodyParameter <IPaths10WpgkzCommunicationsMicrosoftGraphGetpresencesbyuseridPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Get the presence information for multiple users.

## EXAMPLES

### Example 1: Using the Get-MgBetaCommunicationPresenceByUserId Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	Ids = @(
		"fa8bf3dc-eca7-46b7-bad1-db199b62afc3"
		"66825e03-7ef5-42da-9069-724602c31f6b"
	)
}
Get-MgBetaCommunicationPresenceByUserId -BodyParameter $params
```

This example shows how to use the Get-MgBetaCommunicationPresenceByUserId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths10WpgkzCommunicationsMicrosoftGraphGetpresencesbyuseridPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths10WpgkzCommunicationsMicrosoftGraphGetpresencesbyuseridPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPresence1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths10WpgkzCommunicationsMicrosoftGraphGetpresencesbyuseridPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 

## RELATED LINKS

