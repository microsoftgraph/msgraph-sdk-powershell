---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/new-mgprogramcontrol
schema: 2.0.0
---

# New-MgProgramControl

## SYNOPSIS
Add new entity to programControls

## SYNTAX

### CreateExpanded (Default)
```
New-MgProgramControl [-ProgramId <String>] [-ControlId <String>] [-ControlTypeId <String>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>] [-MicrosoftGraphEntityId <String>]
 [-OwnerDisplayName <String>] [-OwnerId <String>] [-OwnerIPAddress <String>]
 [-OwnerUserPrincipalName <String>] [-ProgramControls <IMicrosoftGraphProgramControl[]>]
 [-ProgramDescription <String>] [-ProgramDisplayName <String>] [-ResourceDisplayName <String>]
 [-ResourceId <String>] [-ResourceType <String>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgProgramControl -BodyParameter <IMicrosoftGraphProgramControl> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgProgramControl -ProgramId <String> -BodyParameter <IMicrosoftGraphProgramControl> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateExpanded1
```
New-MgProgramControl -ProgramId <String> [-ControlId <String>] [-ControlTypeId <String>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>] [-MicrosoftGraphEntityId <String>]
 [-OwnerDisplayName <String>] [-OwnerId <String>] [-OwnerIPAddress <String>]
 [-OwnerUserPrincipalName <String>] [-ProgramControls <IMicrosoftGraphProgramControl[]>]
 [-ProgramDescription <String>] [-ProgramDisplayName <String>] [-ProgramId1 <String>]
 [-ResourceDisplayName <String>] [-ResourceId <String>] [-ResourceType <String>] [-Status <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgProgramControl -InputObject <IIdentityAccessReviewIdentity>
 -BodyParameter <IMicrosoftGraphProgramControl> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgProgramControl -InputObject <IIdentityAccessReviewIdentity> [-ProgramId <String>] [-ControlId <String>]
 [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-MicrosoftGraphEntityId <String>] [-OwnerDisplayName <String>] [-OwnerId <String>]
 [-OwnerIPAddress <String>] [-OwnerUserPrincipalName <String>]
 [-ProgramControls <IMicrosoftGraphProgramControl[]>] [-ProgramDescription <String>]
 [-ProgramDisplayName <String>] [-ResourceDisplayName <String>] [-ResourceId <String>]
 [-ResourceType <String>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to programControls

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
Parameter Sets: Create, Create1, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ControlId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ControlTypeId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerUserPrincipalName
The userPrincipalName attribute of the user.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramControls
.
To construct, see NOTES section for PROGRAMCONTROLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl[]
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramDescription
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramId
key: program-id of program

```yaml
Type: System.String
Parameter Sets: Create1, CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramId1
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded1, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphProgramControl>: programControl
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

INPUTOBJECT <IIdentityAccessReviewIdentity>: Identity Parameter
  - `[AccessReviewDecisionId <String>]`: key: accessReviewDecision-id of accessReviewDecision
  - `[AccessReviewId <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewId1 <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewReviewerId <String>]`: key: accessReviewReviewer-id of accessReviewReviewer
  - `[BusinessFlowTemplateId <String>]`: key: businessFlowTemplate-id of businessFlowTemplate
  - `[ProgramControlId <String>]`: key: programControl-id of programControl
  - `[ProgramControlTypeId <String>]`: key: programControlType-id of programControlType
  - `[ProgramId <String>]`: key: program-id of program

PROGRAMCONTROLS <IMicrosoftGraphProgramControl[]>: .
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

