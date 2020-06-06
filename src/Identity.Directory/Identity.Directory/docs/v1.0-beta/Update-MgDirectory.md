---
external help file:
Module Name: Microsoft.Graph.Identity.Directory
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directory/update-mgdirectory
schema: 2.0.0
---

# Update-MgDirectory

## SYNOPSIS
Update directory

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDirectory [-DeletedItems <IMicrosoftGraphDirectoryObject[]>]
 [-FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>] [-Id <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDirectory -BodyParameter <IMicrosoftGraphDirectory1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update directory

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

### -BodyParameter
directory
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedItems
Recently deleted items.
Read-only.
Nullable.
To construct, see NOTES section for DELETEDITEMS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FeatureRolloutPolicies
.
To construct, see NOTES section for FEATUREROLLOUTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFeatureRolloutPolicy[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectory1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDirectory1>: directory
  - `[Id <String>]`: Read-only.
  - `[DeletedItems <IMicrosoftGraphDirectoryObject[]>]`: Recently deleted items. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[FeatureRolloutPolicies <IMicrosoftGraphFeatureRolloutPolicy[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Feature <String>]`: stagedFeatureName
    - `[IsAppliedToOrganization <Boolean?>]`: 
    - `[IsEnabled <Boolean?>]`: 

DELETEDITEMS <IMicrosoftGraphDirectoryObject[]>: Recently deleted items. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[DeletedDateTime <DateTime?>]`: 

FEATUREROLLOUTPOLICIES <IMicrosoftGraphFeatureRolloutPolicy[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DeletedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Feature <String>]`: stagedFeatureName
  - `[IsAppliedToOrganization <Boolean?>]`: 
  - `[IsEnabled <Boolean?>]`: 

## RELATED LINKS

