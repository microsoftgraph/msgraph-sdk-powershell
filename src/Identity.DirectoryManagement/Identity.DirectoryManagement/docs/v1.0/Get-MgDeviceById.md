---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/get-mgdevicebyid
schema: 2.0.0
---

# Get-MgDeviceById

## SYNOPSIS
Invoke action getByIds

## SYNTAX

### GetExpanded1 (Default)
```
Get-MgDeviceById [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-Types <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Get1
```
Get-MgDeviceById
 -BodyParameter <IPaths1545W8NDevicesMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getByIds

## EXAMPLES

### Example 1: Code snippet
```powershell
Import-Module Microsoft.Graph.DirectoryObjects

$params = @{
	Ids = @(
		"84b80893-8749-40a3-97b7-68513b600544"
		"5d6059b6-368d-45f8-91e1-8e07d485f1d0"
		"0b944de3-e0fc-4774-a49a-b135213725ef"
		"b75a5ab2-fe55-4463-bd31-d21ad555c6e0"
	)
	Types = @(
		"user"
		"group"
		"device"
	)
}

Get-MgDirectoryObjectById -BodyParameter $params
```

This example shows how to use the Get-MgDeviceById Cmdlet.

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1545W8NDevicesMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema
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

### -Types
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

### Microsoft.Graph.PowerShell.Models.IPaths1545W8NDevicesMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1545W8NDevicesMicrosoftGraphGetbyidsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[Types <String[]>]`: 

## RELATED LINKS

