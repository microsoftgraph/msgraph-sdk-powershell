---
external help file:
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/update-mgcomplianceediscovery
schema: 2.0.0
---

# Update-MgComplianceEdiscovery

## SYNOPSIS
Update the navigation property ediscovery in compliance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgComplianceEdiscovery [-AdditionalProperties <Hashtable>] [-Cases <IMicrosoftGraphEdiscoveryCase[]>]
 [-Id <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgComplianceEdiscovery -BodyParameter <IMicrosoftGraphEdiscovery> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property ediscovery in compliance

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
ediscovery
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscovery
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Cases
.
To construct, see NOTES section for CASES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCase[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscovery

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEdiscovery>: ediscovery
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Cases <IMicrosoftGraphEdiscoveryCase[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ClosedBy <String>]`: 
    - `[ClosedDateTime <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[ExternalId <String>]`: 
    - `[LastModifiedBy <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[ReviewSets <IMicrosoftGraphReviewSet[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[Queries <IMicrosoftGraphReviewSetQuery[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[CreatedBy <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[DisplayName <String>]`: 
        - `[LastModifiedBy <String>]`: 
        - `[LastModifiedDateTime <DateTime?>]`: 
        - `[Query <String>]`: 
    - `[Status <String>]`: caseStatus

CASES <IMicrosoftGraphEdiscoveryCase[]>: .
  - `[Id <String>]`: Read-only.
  - `[ClosedBy <String>]`: 
  - `[ClosedDateTime <DateTime?>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[ExternalId <String>]`: 
  - `[LastModifiedBy <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ReviewSets <IMicrosoftGraphReviewSet[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Queries <IMicrosoftGraphReviewSetQuery[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedBy <String>]`: 
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Query <String>]`: 
  - `[Status <String>]`: caseStatus

## RELATED LINKS

