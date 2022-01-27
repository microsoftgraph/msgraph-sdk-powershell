---
external help file:
Module Name: Microsoft.Graph.DirectoryObjects
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.directoryobjects/restore-mgdirectoryobject
schema: 2.0.0
---

# Restore-MgDirectoryObject

## SYNOPSIS
Invoke action restore

## SYNTAX

### Restore (Default)
```
Restore-MgDirectoryObject -DirectoryObjectId <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RestoreViaIdentity
```
Restore-MgDirectoryObject -InputObject <IDirectoryObjectsIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action restore

## EXAMPLES

## PARAMETERS

### -DirectoryObjectId
key: id of directoryObject

```yaml
Type: System.String
Parameter Sets: Restore
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDirectoryObjectsIdentity
Parameter Sets: RestoreViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IDirectoryObjectsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDirectoryObjectsIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: id of directoryObject

## RELATED LINKS

