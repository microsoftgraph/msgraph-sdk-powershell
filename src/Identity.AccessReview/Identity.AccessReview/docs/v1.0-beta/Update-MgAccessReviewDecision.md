---
external help file:
Module Name: Microsoft.Graph.Identity.AccessReview
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.accessreview/update-mgaccessreviewdecision
schema: 2.0.0
---

# Update-MgAccessReviewDecision

## SYNOPSIS
Update the navigation property decisions in accessReviews

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAccessReviewDecision -AccessReviewDecisionId <String> -AccessReviewId <String>
 [-AccessRecommendation <String>] [-AccessReviewId1 <String>] [-AppliedByDisplayName <String>]
 [-AppliedById <String>] [-AppliedByIPAddress <String>] [-AppliedByUserPrincipalName <String>]
 [-AppliedDateTime <DateTime>] [-ApplyResult <String>] [-Id <String>] [-Justification <String>]
 [-ReviewedByDisplayName <String>] [-ReviewedById <String>] [-ReviewedByIPAddress <String>]
 [-ReviewedByUserPrincipalName <String>] [-ReviewedDateTime <DateTime>] [-ReviewResult <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAccessReviewDecision -AccessReviewDecisionId <String> -AccessReviewId <String>
 -BodyParameter <IMicrosoftGraphAccessReviewDecision> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAccessReviewDecision -InputObject <IIdentityAccessReviewIdentity>
 -BodyParameter <IMicrosoftGraphAccessReviewDecision> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAccessReviewDecision -InputObject <IIdentityAccessReviewIdentity> [-AccessReviewId <String>]
 [-AccessRecommendation <String>] [-AppliedByDisplayName <String>] [-AppliedById <String>]
 [-AppliedByIPAddress <String>] [-AppliedByUserPrincipalName <String>] [-AppliedDateTime <DateTime>]
 [-ApplyResult <String>] [-Id <String>] [-Justification <String>] [-ReviewedByDisplayName <String>]
 [-ReviewedById <String>] [-ReviewedByIPAddress <String>] [-ReviewedByUserPrincipalName <String>]
 [-ReviewedDateTime <DateTime>] [-ReviewResult <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property decisions in accessReviews

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

### -AccessRecommendation
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

### -AccessReviewDecisionId
key: accessReviewDecision-id of accessReviewDecision

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

### -AccessReviewId
key: accessReview-id of accessReview

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessReviewId1
.

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

### -AppliedByDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

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

### -AppliedById
Unique identifier for the identity.

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

### -AppliedByIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

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

### -AppliedByUserPrincipalName
The userPrincipalName attribute of the user.

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

### -AppliedDateTime
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

### -ApplyResult
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

### -BodyParameter
accessReviewDecision
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewDecision
Parameter Sets: Update, UpdateViaIdentity
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityAccessReviewIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Justification
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

### -ReviewedByDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

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

### -ReviewedById
Unique identifier for the identity.

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

### -ReviewedByIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

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

### -ReviewedByUserPrincipalName
The userPrincipalName attribute of the user.

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

### -ReviewedDateTime
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

### -ReviewResult
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewDecision

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAccessReviewDecision>: accessReviewDecision
  - `[Id <String>]`: Read-only.
  - `[AccessRecommendation <String>]`: 
  - `[AccessReviewId <String>]`: 
  - `[AppliedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[AppliedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[AppliedById <String>]`: Unique identifier for the identity.
  - `[AppliedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: 
  - `[ApplyResult <String>]`: 
  - `[Justification <String>]`: 
  - `[ReviewResult <String>]`: 
  - `[ReviewedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ReviewedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[ReviewedById <String>]`: Unique identifier for the identity.
  - `[ReviewedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[ReviewedDateTime <DateTime?>]`: 

INPUTOBJECT <IIdentityAccessReviewIdentity>: Identity Parameter
  - `[AccessReviewDecisionId <String>]`: key: accessReviewDecision-id of accessReviewDecision
  - `[AccessReviewId <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewId1 <String>]`: key: accessReview-id of accessReview
  - `[AccessReviewReviewerId <String>]`: key: accessReviewReviewer-id of accessReviewReviewer
  - `[BusinessFlowTemplateId <String>]`: key: businessFlowTemplate-id of businessFlowTemplate
  - `[ProgramControlId <String>]`: key: programControl-id of programControl
  - `[ProgramControlTypeId <String>]`: key: programControlType-id of programControlType
  - `[ProgramId <String>]`: key: program-id of program

## RELATED LINKS

