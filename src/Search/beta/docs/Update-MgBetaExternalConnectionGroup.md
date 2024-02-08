---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/update-mgbetaexternalconnectiongroup
schema: 2.0.0
---

# Update-MgBetaExternalConnectionGroup

## SYNOPSIS
Update the navigation property groups in external

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaExternalConnectionGroup -ExternalConnectionId <String> -ExternalGroupId <String>
 [-AdditionalProperties <Hashtable>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-Members <IMicrosoftGraphExternalConnectorsIdentity[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaExternalConnectionGroup -ExternalConnectionId <String> -ExternalGroupId <String>
 -BodyParameter <IMicrosoftGraphExternalConnectorsExternalGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaExternalConnectionGroup -InputObject <ISearchIdentity>
 -BodyParameter <IMicrosoftGraphExternalConnectorsExternalGroup> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaExternalConnectionGroup -InputObject <ISearchIdentity> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-Members <IMicrosoftGraphExternalConnectorsIdentity[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property groups in external

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Search
```

$params = @{
	displayName = "Contoso Marketing"
	description = "The product marketing team"
}

Update-MgBetaExternalConnectionGroup -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params

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
externalGroup
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalGroup
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The description of the external group.
Optional.

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

### -DisplayName
The friendly name of the external group.
Optional.

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

### -ExternalConnectionId
The unique identifier of externalConnection

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

### -ExternalGroupId
The unique identifier of externalGroup

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
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -Members
A member added to an externalGroup.
You can add Microsoft Entra users, Microsoft Entra groups, or other externalGroups as members.
To construct, see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsIdentity[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalGroup

### Microsoft.Graph.Beta.PowerShell.Models.ISearchIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExternalConnectorsExternalGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphExternalConnectorsExternalGroup>`: externalGroup
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the external group. Optional.
  - `[DisplayName <String>]`: The friendly name of the external group. Optional.
  - `[Members <IMicrosoftGraphExternalConnectorsIdentity[]>]`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or other externalGroups as members.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Type <String>]`: identityType

`INPUTOBJECT <ISearchIdentity>`: Identity Parameter
  - `[AcronymId <String>]`: The unique identifier of acronym
  - `[AuthorizationSystemId <String>]`: The unique identifier of authorizationSystem
  - `[BookmarkId <String>]`: The unique identifier of bookmark
  - `[ConnectionOperationId <String>]`: The unique identifier of connectionOperation
  - `[ExternalActivityId <String>]`: The unique identifier of externalActivity
  - `[ExternalConnectionId <String>]`: The unique identifier of externalConnection
  - `[ExternalGroupId <String>]`: The unique identifier of externalGroup
  - `[ExternalItemId <String>]`: The unique identifier of externalItem
  - `[IdentityId <String>]`: The unique identifier of identity
  - `[InboundFlowId <String>]`: The unique identifier of inboundFlow
  - `[IndustryDataConnectorId <String>]`: The unique identifier of industryDataConnector
  - `[IndustryDataRunActivityId <String>]`: The unique identifier of industryDataRunActivity
  - `[IndustryDataRunId <String>]`: The unique identifier of industryDataRun
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[QnaId <String>]`: The unique identifier of qna
  - `[ReferenceDefinitionId <String>]`: The unique identifier of referenceDefinition
  - `[RoleGroupId <String>]`: The unique identifier of roleGroup
  - `[SourceSystemDefinitionId <String>]`: The unique identifier of sourceSystemDefinition
  - `[YearTimePeriodDefinitionId <String>]`: The unique identifier of yearTimePeriodDefinition

`MEMBERS <IMicrosoftGraphExternalConnectorsIdentity[]>`: A member added to an externalGroup. You can add Microsoft Entra users, Microsoft Entra groups, or other externalGroups as members.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Type <String>]`: identityType

## RELATED LINKS

