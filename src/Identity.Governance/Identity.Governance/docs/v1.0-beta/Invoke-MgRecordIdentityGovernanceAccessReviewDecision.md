---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/invoke-mgrecordidentitygovernanceaccessreviewdecision
schema: 2.0.0
---

# Invoke-MgRecordIdentityGovernanceAccessReviewDecision

## SYNOPSIS
Invoke action recordAllDecisions

## SYNTAX

### RecordExpanded (Default)
```
Invoke-MgRecordIdentityGovernanceAccessReviewDecision [-AdditionalProperties <Hashtable>] [-Decision <String>]
 [-Justification <String>] [-PrincipalId <String>] [-ResourceId <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Record
```
Invoke-MgRecordIdentityGovernanceAccessReviewDecision
 -BodyParameter <IPathsAn1WrsIdentitygovernanceAccessreviewsDecisionsMicrosoftGraphRecordalldecisionsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action recordAllDecisions

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: RecordExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsAn1WrsIdentitygovernanceAccessreviewsDecisionsMicrosoftGraphRecordalldecisionsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Record
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Decision
.

```yaml
Type: System.String
Parameter Sets: RecordExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Justification
.

```yaml
Type: System.String
Parameter Sets: RecordExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -PrincipalId
.

```yaml
Type: System.String
Parameter Sets: RecordExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
.

```yaml
Type: System.String
Parameter Sets: RecordExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsAn1WrsIdentitygovernanceAccessreviewsDecisionsMicrosoftGraphRecordalldecisionsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsAn1WrsIdentitygovernanceAccessreviewsDecisionsMicrosoftGraphRecordalldecisionsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Decision <String>]`: 
  - `[Justification <String>]`: 
  - `[PrincipalId <String>]`: 
  - `[ResourceId <String>]`: 

## RELATED LINKS

