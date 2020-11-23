---
external help file: Microsoft.Graph.Compliance-help.xml
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/publish-mgcomplianceediscoverycasecustodian
schema: 2.0.0
---

# Publish-MgComplianceEdiscoveryCaseCustodian

## SYNOPSIS
Invoke action release

## SYNTAX

### Release (Default)
```
Publish-MgComplianceEdiscoveryCaseCustodian -CustodianId <String> -EdiscoveryCaseId <String> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ReleaseViaIdentity
```
Publish-MgComplianceEdiscoveryCaseCustodian -InputObject <IComplianceIdentity> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action release

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

### -CustodianId
key: id of custodian

```yaml
Type: String
Parameter Sets: Release
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryCaseId
key: id of ediscoveryCase

```yaml
Type: String
Parameter Sets: Release
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
Parameter Sets: ReleaseViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
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
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IComplianceIdentity\>: Identity Parameter
  \[CustodianId \<String\>\]: key: id of custodian
  \[EdiscoveryCaseId \<String\>\]: key: id of ediscoveryCase
  \[ReviewSetId \<String\>\]: key: id of reviewSet
  \[ReviewSetQueryId \<String\>\]: key: id of reviewSetQuery
  \[SiteSourceId \<String\>\]: key: id of siteSource
  \[UnifiedGroupSourceId \<String\>\]: key: id of unifiedGroupSource
  \[UserSourceId \<String\>\]: key: id of userSource

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/publish-mgcomplianceediscoverycasecustodian](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/publish-mgcomplianceediscoverycasecustodian)

