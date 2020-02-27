---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/stop-mgaccessreview
schema: 2.0.0
---

# Stop-MgAccessReview

## SYNOPSIS
Invoke action stop

## SYNTAX

### Stop (Default)
```
Stop-MgAccessReview -AccessReviewId <String> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StopViaIdentity
```
Stop-MgAccessReview -InputObject <IIdentityAccessReviewIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action stop

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

### -AccessReviewId
key: accessReview-id of accessReview

```yaml
Type: System.String
Parameter Sets: Stop
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity
Parameter Sets: StopViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IIdentityAccessReviewIdentity>: Identity Parameter
  - `[AccessReviewDecisionId <String>]`: key: accessReviewDecision-id of accessReviewDecision
  - `[AccessReviewId <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewId1 <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewReviewerId <String>]`: key: accessReviewReviewer-id of accessReviewReviewer
  - `[BusinessFlowTemplateId <String>]`: key: businessFlowTemplate-id of businessFlowTemplate
  - `[ProgramControlId <String>]`: key: programControl-id of programControl
  - `[ProgramControlTypeId <String>]`: key: programControlType-id of programControlType
  - `[ProgramId <String>]`: key: program-id of program

## RELATED LINKS

