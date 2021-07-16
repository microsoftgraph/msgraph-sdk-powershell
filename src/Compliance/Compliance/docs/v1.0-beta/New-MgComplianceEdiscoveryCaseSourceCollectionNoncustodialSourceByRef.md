---
external help file: Microsoft.Graph.Compliance-help.xml
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/new-mgcomplianceediscoverycasesourcecollectionnoncustodialsourcebyref
schema: 2.0.0
---

# New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef

## SYNOPSIS
noncustodialDataSource sources that are included in the sourceCollection

## SYNTAX

### CreateExpanded (Default)
```
New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef -CaseId <String>
 -SourceCollectionId <String> [-AdditionalProperties <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef -CaseId <String>
 -SourceCollectionId <String> -BodyParameter <Hashtable> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef -InputObject <IComplianceIdentity>
 [-AdditionalProperties <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef -InputObject <IComplianceIdentity>
 -BodyParameter <Hashtable> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
noncustodialDataSource sources that are included in the sourceCollection

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CaseId
key: id of case

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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
Type: IComplianceIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SourceCollectionId
key: id of sourceCollection

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity
### System.Collections.Hashtable
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IPaths159I4QvComplianceEdiscoveryCasesCaseIdSourcecollectionsSourcecollectionIdNoncustodialsourcesRefPostResponses201ContentApplicationJsonSchema
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IComplianceIdentity>: Identity Parameter
  - `[CaseId <String>]`: key: id of case
  - `[CaseOperationId <String>]`: key: id of caseOperation
  - `[CustodianId <String>]`: key: id of custodian
  - `[DataSourceId <String>]`: key: id of dataSource
  - `[LegalHoldId <String>]`: key: id of legalHold
  - `[NoncustodialDataSourceId <String>]`: key: id of noncustodialDataSource
  - `[ReviewSetId <String>]`: key: id of reviewSet
  - `[ReviewSetQueryId <String>]`: key: id of reviewSetQuery
  - `[SiteSourceId <String>]`: key: id of siteSource
  - `[SourceCollectionId <String>]`: key: id of sourceCollection
  - `[TagId <String>]`: key: id of tag
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSourceId <String>]`: key: id of userSource

## RELATED LINKS
