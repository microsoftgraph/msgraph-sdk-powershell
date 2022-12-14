---
external help file:
Module Name: Microsoft.Graph.Beta.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.compliance/reset-mgcomplianceediscoverycasesettingtodefault
schema: 2.0.0
---

# Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault

## SYNOPSIS
Reset a caseSettings object to the default values.

## SYNTAX

### Reset (Default)
```
Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault -CaseId <String> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ResetViaIdentity
```
Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault -InputObject <IComplianceIdentity> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Reset a caseSettings object to the default values.

## EXAMPLES

### Example 1: Using the Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault -CaseId $caseId
```

This example shows how to use the Reset-MgBetaComplianceEdiscoveryCaseSettingToDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -CaseId
key: id of case

```yaml
Type: System.String
Parameter Sets: Reset
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity
Parameter Sets: ResetViaIdentity
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

### Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity

## OUTPUTS

### System.Boolean

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
  - `[TagId1 <String>]`: key: id of tag
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSourceId <String>]`: key: id of userSource

## RELATED LINKS

