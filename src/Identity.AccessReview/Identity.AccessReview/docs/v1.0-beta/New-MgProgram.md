---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/new-mgprogram
schema: 2.0.0
---

# New-MgProgram

## SYNOPSIS
Add new entity to programs

## SYNTAX

### CreateExpanded (Default)
```
New-MgProgram [-Controls <IMicrosoftGraphProgramControl[]>] [-Description <String>] [-DisplayName <String>]
 [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgProgram -BodyParameter <IMicrosoftGraphProgram> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to programs

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
program
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Controls
.
To construct, see NOTES section for CONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphProgram>: program
  - `[Id <String>]`: Read-only.
  - `[Controls <IMicrosoftGraphProgramControl[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ControlId <String>]`: 
    - `[ControlTypeId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[OwnerDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[OwnerIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[OwnerId <String>]`: Unique identifier for the identity.
    - `[OwnerUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[ProgramControls <IMicrosoftGraphProgramControl[]>]`: 
    - `[ProgramDescription <String>]`: 
    - `[ProgramDisplayName <String>]`: 
    - `[ProgramId <String>]`: 
    - `[ResourceDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[ResourceId <String>]`: Unique identifier for the identity.
    - `[ResourceType <String>]`: 
    - `[Status <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 

CONTROLS <IMicrosoftGraphProgramControl[]>: .
  - `[Id <String>]`: Read-only.
  - `[ControlId <String>]`: 
  - `[ControlTypeId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[OwnerDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[OwnerIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[OwnerId <String>]`: Unique identifier for the identity.
  - `[OwnerUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[ProgramControls <IMicrosoftGraphProgramControl[]>]`: 
  - `[ProgramDescription <String>]`: 
  - `[ProgramDisplayName <String>]`: 
  - `[ProgramId <String>]`: 
  - `[ResourceDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ResourceId <String>]`: Unique identifier for the identity.
  - `[ResourceType <String>]`: 
  - `[Status <String>]`: 

## RELATED LINKS

