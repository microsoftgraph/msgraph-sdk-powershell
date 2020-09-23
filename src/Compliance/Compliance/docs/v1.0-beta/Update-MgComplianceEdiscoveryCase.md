---
external help file:
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/update-mgcomplianceediscoverycase
schema: 2.0.0
---

# Update-MgComplianceEdiscoveryCase

## SYNOPSIS
Update the navigation property cases in compliance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgComplianceEdiscoveryCase -EdiscoveryCaseId <String> [-AdditionalProperties <Hashtable>]
 [-ClosedBy <String>] [-ClosedDateTime <DateTime>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-ExternalId <String>] [-Id <String>] [-LastModifiedBy <String>]
 [-LastModifiedDateTime <DateTime>] [-ReviewSets <IMicrosoftGraphReviewSet[]>] [-Status <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgComplianceEdiscoveryCase -EdiscoveryCaseId <String> -BodyParameter <IMicrosoftGraphEdiscoveryCase>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgComplianceEdiscoveryCase -InputObject <IComplianceIdentity>
 -BodyParameter <IMicrosoftGraphEdiscoveryCase> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgComplianceEdiscoveryCase -InputObject <IComplianceIdentity> [-AdditionalProperties <Hashtable>]
 [-ClosedBy <String>] [-ClosedDateTime <DateTime>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-ExternalId <String>] [-Id <String>] [-LastModifiedBy <String>]
 [-LastModifiedDateTime <DateTime>] [-ReviewSets <IMicrosoftGraphReviewSet[]>] [-Status <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property cases in compliance

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
ediscoveryCase
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCase
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClosedBy
.

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

### -ClosedDateTime
.

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

### -CreatedDateTime
.

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

### -Description
.

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
.

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

### -EdiscoveryCaseId
key: id of ediscoveryCase

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

### -ExternalId
.

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

### -Id
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
Type: Microsoft.Graph.PowerShell.Models.IComplianceIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
.

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

### -LastModifiedDateTime
.

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

### -ReviewSets
.
To construct, see NOTES section for REVIEWSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReviewSet[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
caseStatus

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

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEdiscoveryCase

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEdiscoveryCase>: ediscoveryCase
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

INPUTOBJECT <IComplianceIdentity>: Identity Parameter
  - `[EdiscoveryCaseId <String>]`: key: id of ediscoveryCase
  - `[ReviewSetId <String>]`: key: id of reviewSet
  - `[ReviewSetQueryId <String>]`: key: id of reviewSetQuery

REVIEWSETS <IMicrosoftGraphReviewSet[]>: .
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

## RELATED LINKS

