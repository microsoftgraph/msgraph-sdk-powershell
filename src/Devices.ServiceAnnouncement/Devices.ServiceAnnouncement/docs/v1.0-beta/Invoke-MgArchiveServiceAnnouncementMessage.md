---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.ServiceAnnouncement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devices.serviceannouncement/invoke-mgarchiveserviceannouncementmessage
schema: 2.0.0
---

# Invoke-MgBetaArchiveServiceAnnouncementMessage

## SYNOPSIS
Archive a list of serviceUpdateMessages for the signed in user.

## SYNTAX

### ArchiveExpanded (Default)
```
Invoke-MgBetaArchiveServiceAnnouncementMessage [-AdditionalProperties <Hashtable>] [-MessageIds <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Archive
```
Invoke-MgBetaArchiveServiceAnnouncementMessage
 -BodyParameter <IPaths19OsejwAdminServiceannouncementMessagesMicrosoftGraphArchivePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Archive a list of serviceUpdateMessages for the signed in user.

## EXAMPLES

### Example 1: Using the Invoke-MgBetaArchiveServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgBetaArchiveServiceAnnouncementMessage -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaArchiveServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ArchiveExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths19OsejwAdminServiceannouncementMessagesMicrosoftGraphArchivePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Archive
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MessageIds
.

```yaml
Type: System.String[]
Parameter Sets: ArchiveExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths19OsejwAdminServiceannouncementMessagesMicrosoftGraphArchivePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths19OsejwAdminServiceannouncementMessagesMicrosoftGraphArchivePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[MessageIds <String[]>]`: 

## RELATED LINKS

