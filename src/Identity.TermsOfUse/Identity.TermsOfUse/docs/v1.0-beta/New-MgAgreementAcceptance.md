---
external help file:
Module Name: Microsoft.Graph.Identity.TermsOfUse
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.termsofuse/new-mgagreementacceptance
schema: 2.0.0
---

# New-MgAgreementAcceptance

## SYNOPSIS
Add new entity to agreementAcceptances

## SYNTAX

### CreateExpanded (Default)
```
New-MgAgreementAcceptance [-AgreementFileId <String>] [-AgreementId <String>] [-Id <String>]
 [-RecordedDateTime <DateTime>] [-State <String>] [-UserDisplayName <String>] [-UserEmail <String>]
 [-UserId <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAgreementAcceptance -BodyParameter <IMicrosoftGraphAgreementAcceptance> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to agreementAcceptances

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

### -AgreementFileId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgreementId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
agreementAcceptance
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreementAcceptance
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecordedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
agreementAcceptanceState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserEmail
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreementAcceptance

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreementAcceptance

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAgreementAcceptance>: agreementAcceptance
  - `[Id <String>]`: Read-only.
  - `[AgreementFileId <String>]`: 
  - `[AgreementId <String>]`: 
  - `[RecordedDateTime <DateTime?>]`: 
  - `[State <String>]`: agreementAcceptanceState
  - `[UserDisplayName <String>]`: 
  - `[UserEmail <String>]`: 
  - `[UserId <String>]`: 
  - `[UserPrincipalName <String>]`: 

## RELATED LINKS

