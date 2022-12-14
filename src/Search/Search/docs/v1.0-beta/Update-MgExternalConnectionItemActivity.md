---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.search/update-mgexternalconnectionitemactivity
schema: 2.0.0
---

# Update-MgBetaExternalConnectionItemActivity

## SYNOPSIS
Update the navigation property activities in external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaExternalConnectionItemActivity -ExternalActivityId <String> -ExternalConnectionId <String>
 -ExternalItemId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>] [-StartDateTime <DateTime>] [-Type <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaExternalConnectionItemActivity -ExternalActivityId <String> -ExternalConnectionId <String>
 -ExternalItemId <String> -BodyParameter <IMicrosoftGraphExternalConnectorsExternalActivity> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaExternalConnectionItemActivity -InputObject <ISearchIdentity>
 -BodyParameter <IMicrosoftGraphExternalConnectorsExternalActivity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaExternalConnectionItemActivity -InputObject <ISearchIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>] [-StartDateTime <DateTime>]
 [-Type <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property activities in external

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
externalActivity
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalActivity
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExternalActivityId
key: id of externalActivity

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ISearchIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PerformedBy
identity
To construct, please use Get-Help -Online and see NOTES section for PERFORMEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
When the particular activity occurred.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
externalActivityType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalActivity

### Microsoft.Graph.Beta.PowerShell.Models.ISearchIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternalActivity>: externalActivity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[PerformedBy <IMicrosoftGraphExternalConnectorsIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Type <String>]`: identityType
  - `[StartDateTime <DateTime?>]`: When the particular activity occurred.
  - `[Type <String>]`: externalActivityType

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

PERFORMEDBY <IMicrosoftGraphExternalConnectorsIdentity>: identity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Type <String>]`: identityType

## RELATED LINKS

