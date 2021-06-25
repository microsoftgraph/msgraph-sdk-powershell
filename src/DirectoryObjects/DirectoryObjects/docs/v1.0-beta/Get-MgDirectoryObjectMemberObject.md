---
external help file: Microsoft.Graph.DirectoryObjects-help.xml
Module Name: Microsoft.Graph.DirectoryObjects
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.directoryobjects/get-mgdirectoryobjectmemberobject
schema: 2.0.0
---

# Get-MgDirectoryObjectMemberObject

## SYNOPSIS
Invoke action getMemberObjects

## SYNTAX

### GetExpanded1 (Default)
```
Get-MgDirectoryObjectMemberObject -DirectoryObjectId <String> [-AdditionalProperties <Hashtable>]
 [-SecurityEnabledOnly] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Get1
```
Get-MgDirectoryObjectMemberObject -DirectoryObjectId <String>
 -BodyParameter <IPaths16Hhl7EDirectoryobjectsDirectoryobjectIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### GetViaIdentityExpanded1
```
Get-MgDirectoryObjectMemberObject -InputObject <IDirectoryObjectsIdentity> [-AdditionalProperties <Hashtable>]
 [-SecurityEnabledOnly] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgDirectoryObjectMemberObject -InputObject <IDirectoryObjectsIdentity>
 -BodyParameter <IPaths16Hhl7EDirectoryobjectsDirectoryobjectIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getMemberObjects

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: GetExpanded1, GetViaIdentityExpanded1
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
Type: IPaths16Hhl7EDirectoryobjectsDirectoryobjectIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get1, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryObjectId
key: id of directoryObject

```yaml
Type: String
Parameter Sets: GetExpanded1, Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IDirectoryObjectsIdentity
Parameter Sets: GetViaIdentityExpanded1, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SecurityEnabledOnly
.

```yaml
Type: SwitchParameter
Parameter Sets: GetExpanded1, GetViaIdentityExpanded1
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IPaths16Hhl7EDirectoryobjectsDirectoryobjectIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths16Hhl7EDirectoryobjectsDirectoryobjectIdMicrosoftGraphGetmemberobjectsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SecurityEnabledOnly <Boolean?>]`: 

INPUTOBJECT <IDirectoryObjectsIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: id of directoryObject

## RELATED LINKS
