---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/update-mgeducationuserassignmentsubmission
schema: 2.0.0
---

# Update-MgEducationUserAssignmentSubmission

## SYNOPSIS
Update the navigation property submissions in education

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEducationUserAssignmentSubmission -EducationAssignmentId <String> -EducationSubmissionId <String>
 -EducationUserId <String> [-Id <String>] [-Outcomes <IMicrosoftGraphEducationOutcome[]>]
 [-Recipient <IMicrosoftGraphEducationSubmissionRecipient>] [-ReleasedBy <IMicrosoftGraphIdentitySet>]
 [-ReleasedDateTime <DateTime>] [-Resources <IMicrosoftGraphEducationSubmissionResource[]>]
 [-ResourcesFolderUrl <String>] [-ReturnedBy <IMicrosoftGraphIdentitySet>] [-ReturnedDateTime <DateTime>]
 [-Status <String>] [-SubmittedBy <IMicrosoftGraphIdentitySet>] [-SubmittedDateTime <DateTime>]
 [-SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]
 [-UnsubmittedBy <IMicrosoftGraphIdentitySet>] [-UnsubmittedDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEducationUserAssignmentSubmission -EducationAssignmentId <String> -EducationSubmissionId <String>
 -EducationUserId <String> -BodyParameter <IMicrosoftGraphEducationSubmission> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEducationUserAssignmentSubmission -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationSubmission> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEducationUserAssignmentSubmission -InputObject <IEducationIdentity> [-Id <String>]
 [-Outcomes <IMicrosoftGraphEducationOutcome[]>] [-Recipient <IMicrosoftGraphEducationSubmissionRecipient>]
 [-ReleasedBy <IMicrosoftGraphIdentitySet>] [-ReleasedDateTime <DateTime>]
 [-Resources <IMicrosoftGraphEducationSubmissionResource[]>] [-ResourcesFolderUrl <String>]
 [-ReturnedBy <IMicrosoftGraphIdentitySet>] [-ReturnedDateTime <DateTime>] [-Status <String>]
 [-SubmittedBy <IMicrosoftGraphIdentitySet>] [-SubmittedDateTime <DateTime>]
 [-SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]
 [-UnsubmittedBy <IMicrosoftGraphIdentitySet>] [-UnsubmittedDateTime <DateTime>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property submissions in education

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
educationSubmission
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmission
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EducationAssignmentId
key: educationAssignment-id of educationAssignment

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

### -EducationSubmissionId
key: educationSubmission-id of educationSubmission

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

### -EducationUserId
key: educationUser-id of educationUser

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
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Outcomes
.
To construct, see NOTES section for OUTCOMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationOutcome[]
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

### -Recipient
educationSubmissionRecipient

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmissionRecipient
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReleasedBy
identitySet
To construct, see NOTES section for RELEASEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReleasedDateTime
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

### -Resources
.
To construct, see NOTES section for RESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmissionResource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourcesFolderUrl
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

### -ReturnedBy
identitySet
To construct, see NOTES section for RETURNEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReturnedDateTime
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

### -Status
educationSubmissionStatus

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

### -SubmittedBy
identitySet
To construct, see NOTES section for SUBMITTEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubmittedDateTime
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

### -SubmittedResources
.
To construct, see NOTES section for SUBMITTEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmissionResource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnsubmittedBy
identitySet
To construct, see NOTES section for UNSUBMITTEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnsubmittedDateTime
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

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmission

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationSubmission>: educationSubmission
  - `[Id <String>]`: Read-only.
  - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
  - `[ReleasedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReleasedDateTime <DateTime?>]`: 
  - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AssignmentResourceUrl <String>]`: 
    - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceCreatedDateTime <DateTime?>]`: 
    - `[ResourceDisplayName <String>]`: 
    - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceLastModifiedDateTime <DateTime?>]`: 
  - `[ResourcesFolderUrl <String>]`: 
  - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReturnedDateTime <DateTime?>]`: 
  - `[Status <String>]`: educationSubmissionStatus
  - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[SubmittedDateTime <DateTime?>]`: 
  - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
  - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[UnsubmittedDateTime <DateTime?>]`: 

INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: educationAssignment-id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: educationAssignmentResource-id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: educationCategory-id of educationCategory
  - `[EducationClassId <String>]`: key: educationClass-id of educationClass
  - `[EducationOutcomeId <String>]`: key: educationOutcome-id of educationOutcome
  - `[EducationRubricId <String>]`: key: educationRubric-id of educationRubric
  - `[EducationSchoolId <String>]`: key: educationSchool-id of educationSchool
  - `[EducationSubmissionId <String>]`: key: educationSubmission-id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: educationSubmissionResource-id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: educationSynchronizationError-id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: educationSynchronizationProfile-id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: educationUser-id of educationUser

OUTCOMES <IMicrosoftGraphEducationOutcome[]>: .
  - `[Id <String>]`: Read-only.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 

RELEASEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

RESOURCES <IMicrosoftGraphEducationSubmissionResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[AssignmentResourceUrl <String>]`: 
  - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ResourceCreatedDateTime <DateTime?>]`: 
  - `[ResourceDisplayName <String>]`: 
  - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ResourceLastModifiedDateTime <DateTime?>]`: 

RETURNEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

SUBMITTEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

SUBMITTEDRESOURCES <IMicrosoftGraphEducationSubmissionResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[AssignmentResourceUrl <String>]`: 
  - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ResourceCreatedDateTime <DateTime?>]`: 
  - `[ResourceDisplayName <String>]`: 
  - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ResourceLastModifiedDateTime <DateTime?>]`: 

UNSUBMITTEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

## RELATED LINKS

