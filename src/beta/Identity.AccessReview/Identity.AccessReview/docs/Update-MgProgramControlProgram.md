---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/update-mgprogramcontrolprogram
schema: 2.0.0
---

# Update-MgProgramControlProgram

## SYNOPSIS
Update the navigation property program in programControls

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgProgramControlProgram -ProgramControlId <String> [-Controls <IMicrosoftGraphProgramControl[]>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgProgramControlProgram -ProgramControlId <String> -BodyParameter <IMicrosoftGraphProgram> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgProgramControlProgram -InputObject <IIdentityAccessReviewIdentity>
 -BodyParameter <IMicrosoftGraphProgram> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgProgramControlProgram -InputObject <IIdentityAccessReviewIdentity>
 [-Controls <IMicrosoftGraphProgramControl[]>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property program in programControls

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
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Controls
.
To construct, see NOTES section for CONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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

### -ProgramControlId
key: programControl-id of programControl

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgram

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphProgram>: program
  - `[Id <String>]`: Read-only.
  - `[Controls <IMicrosoftGraphProgramControl[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ControlId <String>]`: 
    - `[ControlTypeId <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[OwnerDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
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

#### CONTROLS <IMicrosoftGraphProgramControl[]>: .
  - `[Id <String>]`: Read-only.
  - `[ControlId <String>]`: 
  - `[ControlTypeId <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[OwnerDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
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

