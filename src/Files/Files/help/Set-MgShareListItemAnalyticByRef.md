---
external help file: Microsoft.Graph.Files-help.xml
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/set-mgsharelistitemanalyticbyref
schema: 2.0.0
---

# Set-MgShareListItemAnalyticByRef

## SYNOPSIS
Update the ref of navigation property analytics in shares

## SYNTAX

### SetExpanded1 (Default)
```
Set-MgShareListItemAnalyticByRef -SharedDriveItemId <String> [-AdditionalProperties <Hashtable>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SetExpanded
```
Set-MgShareListItemAnalyticByRef -ListItemId <String> -SharedDriveItemId <String>
 [-AdditionalProperties <Hashtable>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Set
```
Set-MgShareListItemAnalyticByRef -ListItemId <String> -SharedDriveItemId <String> -BodyParameter <Hashtable>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Set1
```
Set-MgShareListItemAnalyticByRef -SharedDriveItemId <String> -BodyParameter <Hashtable> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### SetViaIdentityExpanded1
```
Set-MgShareListItemAnalyticByRef -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-MgShareListItemAnalyticByRef -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SetViaIdentity1
```
Set-MgShareListItemAnalyticByRef -InputObject <IFilesIdentity> -BodyParameter <Hashtable> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### SetViaIdentity
```
Set-MgShareListItemAnalyticByRef -InputObject <IFilesIdentity> -BodyParameter <Hashtable> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the ref of navigation property analytics in shares

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: SetExpanded1, SetExpanded, SetViaIdentityExpanded1, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.

```yaml
Type: Hashtable
Parameter Sets: Set, Set1, SetViaIdentity1, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IFilesIdentity
Parameter Sets: SetViaIdentityExpanded1, SetViaIdentityExpanded, SetViaIdentity1, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListItemId
key: id of listItem

```yaml
Type: String
Parameter Sets: SetExpanded, Set
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
key: id of sharedDriveItem

```yaml
Type: String
Parameter Sets: SetExpanded1, SetExpanded, Set, Set1
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity
### System.Collections.Hashtable
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IFilesIdentity\>: Identity Parameter
  \[ColumnDefinitionId \<String\>\]: key: id of columnDefinition
  \[ColumnLinkId \<String\>\]: key: id of columnLink
  \[ContentTypeId \<String\>\]: key: id of contentType
  \[DriveId \<String\>\]: key: id of drive
  \[DriveItemId \<String\>\]: key: id of driveItem
  \[EndDateTime \<String\>\]: 
  \[GroupId \<String\>\]: key: id of group
  \[Interval \<String\>\]: 
  \[ListItemId \<String\>\]: key: id of listItem
  \[ListItemVersionId \<String\>\]: key: id of listItemVersion
  \[Q \<String\>\]: 
  \[SharedDriveItemId \<String\>\]: key: id of sharedDriveItem
  \[StartDateTime \<String\>\]: 
  \[SubscriptionId \<String\>\]: key: id of subscription
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/set-mgsharelistitemanalyticbyref](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/set-mgsharelistitemanalyticbyref)

