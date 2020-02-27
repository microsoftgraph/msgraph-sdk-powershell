---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/update-mgprogramcontrol
schema: 2.0.0
---

# Update-MgProgramControl

## SYNOPSIS
Update entity in programControls

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgProgramControl -ProgramControlId <String> [-ProgramId <String>] [-ControlId <String>]
 [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-MicrosoftGraphEntityId <String>] [-OwnerDisplayName <String>] [-OwnerId <String>]
 [-OwnerIPAddress <String>] [-OwnerUserPrincipalName <String>]
 [-ProgramControls <IMicrosoftGraphProgramControl[]>] [-ProgramDescription <String>]
 [-ProgramDisplayName <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgProgramControl -ProgramControlId <String> -BodyParameter <IMicrosoftGraphProgramControl> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgProgramControl -ProgramControlId <String> -ProgramId <String>
 -BodyParameter <IMicrosoftGraphProgramControl> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded1
```
Update-MgProgramControl -ProgramControlId <String> -ProgramId <String> [-ControlId <String>]
 [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-MicrosoftGraphEntityId <String>] [-OwnerDisplayName <String>] [-OwnerId <String>]
 [-OwnerIPAddress <String>] [-OwnerUserPrincipalName <String>]
 [-ProgramControls <IMicrosoftGraphProgramControl[]>] [-ProgramDescription <String>]
 [-ProgramDisplayName <String>] [-ProgramId1 <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgProgramControl -InputObject <IIdentityAccessReviewIdentity>
 -BodyParameter <IMicrosoftGraphProgramControl> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgProgramControl -InputObject <IIdentityAccessReviewIdentity>
 -BodyParameter <IMicrosoftGraphProgramControl> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgProgramControl -InputObject <IIdentityAccessReviewIdentity> [-ProgramId <String>]
 [-ControlId <String>] [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-MicrosoftGraphEntityId <String>] [-OwnerDisplayName <String>] [-OwnerId <String>]
 [-OwnerIPAddress <String>] [-OwnerUserPrincipalName <String>]
 [-ProgramControls <IMicrosoftGraphProgramControl[]>] [-ProgramDescription <String>]
 [-ProgramDisplayName <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgProgramControl -InputObject <IIdentityAccessReviewIdentity> [-ProgramId <String>]
 [-ControlId <String>] [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-MicrosoftGraphEntityId <String>] [-OwnerDisplayName <String>] [-OwnerId <String>]
 [-OwnerIPAddress <String>] [-OwnerUserPrincipalName <String>]
 [-ProgramControls <IMicrosoftGraphProgramControl[]>] [-ProgramDescription <String>]
 [-ProgramDisplayName <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in programControls

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
programControl
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl
Parameter Sets: Update, Update1, UpdateViaIdentity, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ControlId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ControlTypeId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentity1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OwnerDisplayName
The identity's display name.
Note that this may not always be available or up-to-date.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OwnerId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OwnerIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OwnerUserPrincipalName
The userPrincipalName attribute of the user.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Parameter Sets: Update, Update1, UpdateExpanded, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProgramControls
.
To construct, see NOTES section for PROGRAMCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl[]
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProgramDescription
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProgramDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProgramId
key: program-id of program

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProgramId1
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceType
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Status
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphProgramControl>: programControl
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

#### PROGRAMCONTROLS <IMicrosoftGraphProgramControl[]>: .
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

## RELATED LINKS

