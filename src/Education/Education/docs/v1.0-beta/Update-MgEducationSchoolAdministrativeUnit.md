---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/update-mgeducationschooladministrativeunit
schema: 2.0.0
---

# Update-MgBetaEducationSchoolAdministrativeUnit

## SYNOPSIS
Update the navigation property administrativeUnit in education

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaEducationSchoolAdministrativeUnit -EducationSchoolId <String> [-AdditionalProperties <Hashtable>]
 [-DeletedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>]
 [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>] [-IsMemberManagementRestricted]
 [-Members <IMicrosoftGraphDirectoryObject[]>] [-ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]
 [-Visibility <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaEducationSchoolAdministrativeUnit -EducationSchoolId <String>
 -BodyParameter <IMicrosoftGraphAdministrativeUnit> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaEducationSchoolAdministrativeUnit -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphAdministrativeUnit> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaEducationSchoolAdministrativeUnit -InputObject <IEducationIdentity>
 [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-Extensions <IMicrosoftGraphExtension[]>] [-Id <String>]
 [-IsMemberManagementRestricted] [-Members <IMicrosoftGraphDirectoryObject[]>]
 [-ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>] [-Visibility <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property administrativeUnit in education

## EXAMPLES

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
administrativeUnit
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAdministrativeUnit
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

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
An optional description for the administrative unit.
Supports $filter (eq, ne, in, startsWith), $search.

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
Display name for the administrative unit.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.

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

### -EducationSchoolId
key: id of educationSchool

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

### -Extensions
The collection of open extensions defined for this administrative unit.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for EXTENSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExtension[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsMemberManagementRestricted
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Members
Users and groups that are members of this administrative unit.
Supports $expand.
To construct, please use Get-Help -Online and see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject[]
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

### -ScopedRoleMembers
Scoped-role members of this administrative unit.
To construct, please use Get-Help -Online and see NOTES section for SCOPEDROLEMEMBERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphScopedRoleMembership[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Visibility
Controls whether the administrative unit and its members are hidden or public.
Can be set to HiddenMembership or Public.
If not set, the default behavior is Public.
When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

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

### Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAdministrativeUnit

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAdministrativeUnit>: administrativeUnit
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.
  - `[DisplayName <String>]`: Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for this administrative unit. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsMemberManagementRestricted <Boolean?>]`: 
  - `[Members <IMicrosoftGraphDirectoryObject[]>]`: Users and groups that are members of this administrative unit. Supports $expand.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[ScopedRoleMembers <IMicrosoftGraphScopedRoleMembership[]>]`: Scoped-role members of this administrative unit.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
    - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
    - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
  - `[Visibility <String>]`: Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership or Public. If not set, the default behavior is Public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.

EXTENSIONS <IMicrosoftGraphExtension[]>: The collection of open extensions defined for this administrative unit. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: id of educationCategory
  - `[EducationClassId <String>]`: key: id of educationClass
  - `[EducationOutcomeId <String>]`: key: id of educationOutcome
  - `[EducationRubricId <String>]`: key: id of educationRubric
  - `[EducationSchoolId <String>]`: key: id of educationSchool
  - `[EducationSubmissionId <String>]`: key: id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: id of educationUser

MEMBERS <IMicrosoftGraphDirectoryObject[]>: Users and groups that are members of this administrative unit. Supports $expand.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

SCOPEDROLEMEMBERS <IMicrosoftGraphScopedRoleMembership[]>: Scoped-role members of this administrative unit.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdministrativeUnitId <String>]`: Unique identifier for the administrative unit that the directory role is scoped to
  - `[RoleId <String>]`: Unique identifier for the directory role that the member is in.
  - `[RoleMemberInfo <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.

## RELATED LINKS

