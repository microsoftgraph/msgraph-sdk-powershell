---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogram
schema: 2.0.0
---

# New-MgProgram

## SYNOPSIS
Add new entity to programs

## SYNTAX

### CreateExpanded (Default)
```
New-MgProgram [-AdditionalProperties <Hashtable>] [-Controls <IMicrosoftGraphProgramControl[]>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgProgram -BodyParameter <IMicrosoftGraphProgram> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to programs

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
program
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphProgram
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
Type: IMicrosoftGraphProgramControl[]
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
Type: String
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
Type: String
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
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphProgram\>: program
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Controls \<IMicrosoftGraphProgramControl\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[ControlId \<String\>\]: 
    \[ControlTypeId \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[DisplayName \<String\>\]: 
    \[Owner \<IMicrosoftGraphUserIdentity\>\]: userIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
      \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
    \[Program \<IMicrosoftGraphProgram\>\]: program
    \[ProgramId \<String\>\]: 
    \[Resource \<IMicrosoftGraphProgramResource\>\]: programResource
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[Type \<String\>\]: 
    \[Status \<String\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 

CONTROLS \<IMicrosoftGraphProgramControl\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[ControlId \<String\>\]: 
  \[ControlTypeId \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[DisplayName \<String\>\]: 
  \[Owner \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[Program \<IMicrosoftGraphProgram\>\]: program
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Controls \<IMicrosoftGraphProgramControl\[\]\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
  \[ProgramId \<String\>\]: 
  \[Resource \<IMicrosoftGraphProgramResource\>\]: programResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[Type \<String\>\]: 
  \[Status \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogram](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogram)

