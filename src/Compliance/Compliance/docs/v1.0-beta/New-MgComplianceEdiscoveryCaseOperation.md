---
external help file:
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/new-mgcomplianceediscoverycaseoperation
schema: 2.0.0
---

# New-MgComplianceEdiscoveryCaseOperation

## SYNOPSIS
Create new navigation property to operations for compliance

## SYNTAX

### CreateExpanded (Default)
```
New-MgComplianceEdiscoveryCaseOperation -CaseId <String> [-Action <String>]
 [-AdditionalProperties <Hashtable>] [-CompletedDateTime <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-PercentProgress <Int32>]
 [-ResultInfo <IMicrosoftGraphResultInfo>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgComplianceEdiscoveryCaseOperation -CaseId <String>
 -BodyParameter <IMicrosoftGraphEdiscoveryCaseOperation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgComplianceEdiscoveryCaseOperation -InputObject <IComplianceIdentity>
 -BodyParameter <IMicrosoftGraphEdiscoveryCaseOperation> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgComplianceEdiscoveryCaseOperation -InputObject <IComplianceIdentity> [-Action <String>]
 [-AdditionalProperties <Hashtable>] [-CompletedDateTime <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-PercentProgress <Int32>]
 [-ResultInfo <IMicrosoftGraphResultInfo>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to operations for compliance

## EXAMPLES

## PARAMETERS

### -Action
caseAction

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
caseOperation
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCaseOperation
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
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompletedDateTime
The date and time the operation was completed.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the operation was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IComplianceIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PercentProgress
The progress of the operation.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResultInfo
resultInfo
To construct, please use Get-Help -Online and see NOTES section for RESULTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphResultInfo
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
caseOperationStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCaseOperation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCaseOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEdiscoveryCaseOperation>: caseOperation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Action <String>]`: caseAction
  - `[CompletedDateTime <DateTime?>]`: The date and time the operation was completed.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time the operation was created.
  - `[PercentProgress <Int32?>]`: The progress of the operation.
  - `[ResultInfo <IMicrosoftGraphResultInfo>]`: resultInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <Int32?>]`: The result code.
    - `[Message <String>]`: The message.
    - `[Subcode <Int32?>]`: The result sub-code.
  - `[Status <String>]`: caseOperationStatus

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

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
  - `[TagId1 <String>]`: key: id of tag
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSourceId <String>]`: key: id of userSource

RESULTINFO <IMicrosoftGraphResultInfo>: resultInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Code <Int32?>]`: The result code.
  - `[Message <String>]`: The message.
  - `[Subcode <Int32?>]`: The result sub-code.

## RELATED LINKS

