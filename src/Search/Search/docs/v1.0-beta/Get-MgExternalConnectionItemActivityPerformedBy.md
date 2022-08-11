---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/get-mgexternalconnectionitemactivityperformedby
schema: 2.0.0
---

# Get-MgExternalConnectionItemActivityPerformedBy

## SYNOPSIS
Get performedBy from external

## SYNTAX

### Get (Default)
```
Get-MgExternalConnectionItemActivityPerformedBy -ExternalActivityId <String> -ExternalConnectionId <String>
 -ExternalItemId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgExternalConnectionItemActivityPerformedBy -InputObject <ISearchIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get performedBy from external

## EXAMPLES

## PARAMETERS

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalActivityId
key: id of externalActivity

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalConnectionId
key: id of externalConnection

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalItemId
key: id of externalItem

```yaml
Type: System.String
Parameter Sets: Get
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
Type: Microsoft.Graph.PowerShell.Models.ISearchIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ISearchIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExternalConnectorsIdentity

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISearchIdentity>: Identity Parameter
  - `[AcronymId <String>]`: key: id of acronym
  - `[BookmarkId <String>]`: key: id of bookmark
  - `[ConnectionOperationId <String>]`: key: id of connectionOperation
  - `[ExternalActivityId <String>]`: key: id of externalActivity
  - `[ExternalConnectionId <String>]`: key: id of externalConnection
  - `[ExternalGroupId <String>]`: key: id of externalGroup
  - `[ExternalItemId <String>]`: key: id of externalItem
  - `[IdentityId <String>]`: key: id of identity
  - `[QnaId <String>]`: key: id of qna

## RELATED LINKS

