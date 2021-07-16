---
external help file: Microsoft.Graph.DeviceManagement.Enrolment-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/update-mgrolemanagement
schema: 2.0.0
---

# Update-MgRoleManagement

## SYNOPSIS
Update roleManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgRoleManagement [-AdditionalProperties <Hashtable>] [-CloudPc <IMicrosoftGraphRbacApplicationMultiple>]
 [-DeviceManagement <IMicrosoftGraphRbacApplicationMultiple>] [-Directory <IMicrosoftGraphRbacApplication>]
 [-EntitlementManagement <IMicrosoftGraphRbacApplication>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgRoleManagement -BodyParameter <IMicrosoftGraphRoleManagement1> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update roleManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
roleManagement
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphRoleManagement1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CloudPc
rbacApplicationMultiple
To construct, see NOTES section for CLOUDPC properties and create a hash table.

```yaml
Type: IMicrosoftGraphRbacApplicationMultiple
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceManagement
rbacApplicationMultiple
To construct, see NOTES section for DEVICEMANAGEMENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphRbacApplicationMultiple
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Directory
rbacApplication
To construct, see NOTES section for DIRECTORY properties and create a hash table.

```yaml
Type: IMicrosoftGraphRbacApplication
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntitlementManagement
rbacApplication
To construct, see NOTES section for ENTITLEMENTMANAGEMENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphRbacApplication
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleManagement1
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRoleManagement1>: roleManagement
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CloudPc <IMicrosoftGraphRbacApplicationMultiple>]`: rbacApplicationMultiple
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Name <String>]`: 
      - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[ActionVerb <String>]`: 
        - `[Description <String>]`: 
        - `[Name <String>]`: 
        - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[DisplayName <String>]`: 
          - `[Scope <String>]`: 
          - `[Type <String>]`: 
        - `[ResourceScopeId <String>]`: 
    - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
        - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
      - `[Condition <String>]`: 
      - `[Description <String>]`: Description of the role assignment.
      - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
        - `[Id <String>]`: Read-only.
        - `[DeletedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: Name of the role assignment. Required.
      - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
      - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
        - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).
        - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
        - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).
        - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
        - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This is going to be deprecated soon. Attach scope to role assignment
        - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
          - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
          - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
          - `[ExcludedResourceActions <String[]>]`: 
        - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
        - `[Version <String>]`: Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
    - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 
  - `[DeviceManagement <IMicrosoftGraphRbacApplicationMultiple>]`: rbacApplicationMultiple
  - `[Directory <IMicrosoftGraphRbacApplication>]`: rbacApplication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[RoleAssignmentApprovals <IMicrosoftGraphApproval[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Steps <IMicrosoftGraphApprovalStep[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
        - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
        - `[Justification <String>]`: The justification associated with the approval step decision.
        - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
        - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
    - `[RoleAssignmentScheduleInstances <IMicrosoftGraphUnifiedRoleAssignmentScheduleInstance[]>]`: 
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
        - `[Id <String>]`: Read-only.
        - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire
        - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
        - `[RoleEligibilityScheduleId <String>]`: ID of the parent roleEligibilitySchedule for this instance
        - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
      - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
      - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
    - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
      - `[ApprovalId <String>]`: 
      - `[CompletedDateTime <DateTime?>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CreatedDateTime <DateTime?>]`: 
      - `[CustomData <String>]`: 
      - `[Status <String>]`: 
      - `[Id <String>]`: Read-only.
      - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
        - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
        - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
        - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
        - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
        - `[Id <String>]`: Read-only.
        - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
        - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Duration <TimeSpan?>]`: The requestor's desired duration of access. If specified in a request, endDateTime should not be present.
            - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Type <String>]`: expirationPatternType
          - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
              - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
              - `[FirstDayOfWeek <String>]`: dayOfWeek
              - `[Index <String>]`: weekIndex
              - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
              - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
              - `[Type <String>]`: recurrencePatternType
            - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
              - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
              - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
              - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
              - `[Type <String>]`: recurrenceRangeType
          - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
      - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
        - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
        - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
        - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
        - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
        - `[Id <String>]`: Read-only.
        - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
        - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
        - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
        - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
      - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[TicketNumber <String>]`: Ticket number meta data
        - `[TicketSystem <String>]`: Ticket system meta data
    - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
    - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[Condition <String>]`: 
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq operator only).
      - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read-only. Supports $filter (eq operator only).
    - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 
    - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
    - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
      - `[ApprovalId <String>]`: 
      - `[CompletedDateTime <DateTime?>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[CustomData <String>]`: 
      - `[Status <String>]`: 
      - `[Id <String>]`: Read-only.
      - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
      - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
      - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
    - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 
  - `[EntitlementManagement <IMicrosoftGraphRbacApplication>]`: rbacApplication

CLOUDPC <IMicrosoftGraphRbacApplicationMultiple>: rbacApplicationMultiple
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: 
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: 
      - `[Description <String>]`: 
      - `[Name <String>]`: 
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
    - `[Condition <String>]`: 
    - `[Description <String>]`: Description of the role assignment.
    - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: Name of the role assignment. Required.
    - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).
      - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This is going to be deprecated soon. Attach scope to role assignment
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: 
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
      - `[Version <String>]`: Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 

DEVICEMANAGEMENT <IMicrosoftGraphRbacApplicationMultiple>: rbacApplicationMultiple
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: 
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: 
      - `[Description <String>]`: 
      - `[Name <String>]`: 
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
    - `[Condition <String>]`: 
    - `[Description <String>]`: Description of the role assignment.
    - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: Name of the role assignment. Required.
    - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).
      - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This is going to be deprecated soon. Attach scope to role assignment
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: 
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
      - `[Version <String>]`: Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 

DIRECTORY <IMicrosoftGraphRbacApplication>: rbacApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: 
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: 
      - `[Description <String>]`: 
      - `[Name <String>]`: 
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: 
  - `[RoleAssignmentApprovals <IMicrosoftGraphApproval[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Steps <IMicrosoftGraphApprovalStep[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
      - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
      - `[Justification <String>]`: The justification associated with the approval step decision.
      - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
      - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
  - `[RoleAssignmentScheduleInstances <IMicrosoftGraphUnifiedRoleAssignmentScheduleInstance[]>]`: 
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).
      - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This is going to be deprecated soon. Attach scope to role assignment
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: 
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
      - `[Version <String>]`: Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[Id <String>]`: Read-only.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Id <String>]`: Read-only.
      - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleEligibilityScheduleId <String>]`: ID of the parent roleEligibilitySchedule for this instance
      - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start
    - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
    - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
    - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
    - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
    - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
    - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
  - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: 
    - `[CompletedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[CustomData <String>]`: 
    - `[Status <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
      - `[Id <String>]`: Read-only.
      - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Duration <TimeSpan?>]`: The requestor's desired duration of access. If specified in a request, endDateTime should not be present.
          - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Type <String>]`: expirationPatternType
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
            - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
            - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
            - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
            - `[Type <String>]`: recurrenceRangeType
        - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TicketNumber <String>]`: Ticket number meta data
      - `[TicketSystem <String>]`: Ticket system meta data
  - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[Condition <String>]`: 
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq operator only).
    - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read-only. Supports $filter (eq operator only).
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 
  - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
  - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: 
    - `[CompletedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[CustomData <String>]`: 
    - `[Status <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
    - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
  - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 

ENTITLEMENTMANAGEMENT <IMicrosoftGraphRbacApplication>: rbacApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: 
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: 
      - `[Description <String>]`: 
      - `[Name <String>]`: 
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: 
  - `[RoleAssignmentApprovals <IMicrosoftGraphApproval[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Steps <IMicrosoftGraphApprovalStep[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
      - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
      - `[Justification <String>]`: The justification associated with the approval step decision.
      - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
      - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
  - `[RoleAssignmentScheduleInstances <IMicrosoftGraphUnifiedRoleAssignmentScheduleInstance[]>]`: 
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. This property is read only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. This property is read only.
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq and startsWith operators only).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles support this attribute.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating if the unifiedRoleDefinition is part of the default set included with the product or custom. Read-only.  Supports $filter (eq operator only).
      - `[IsEnabled <Boolean?>]`: Flag indicating if the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of scopes permissions granted by the role definition apply to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This is going to be deprecated soon. Attach scope to role assignment
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: 
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false. This identifier is typically used if one needs an identifier to be the same across different directories. Read-only when isBuiltIn is true.
      - `[Version <String>]`: Indicates version of the unifiedRoleDefinition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[Id <String>]`: Read-only.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Id <String>]`: Read-only.
      - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleEligibilityScheduleId <String>]`: ID of the parent roleEligibilitySchedule for this instance
      - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start
    - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
    - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
    - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
    - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
    - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
    - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
  - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: 
    - `[CompletedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[CustomData <String>]`: 
    - `[Status <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
      - `[Id <String>]`: Read-only.
      - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Duration <TimeSpan?>]`: The requestor's desired duration of access. If specified in a request, endDateTime should not be present.
          - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Type <String>]`: expirationPatternType
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
            - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
            - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
            - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
            - `[Type <String>]`: recurrenceRangeType
        - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: ID of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval.
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TicketNumber <String>]`: Ticket number meta data
      - `[TicketSystem <String>]`: Ticket system meta data
  - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[Condition <String>]`: 
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq operator only).
    - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read-only. Supports $filter (eq operator only).
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 
  - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
  - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: 
    - `[CompletedDateTime <DateTime?>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[CustomData <String>]`: 
    - `[Status <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators assign users/groups to roles;UserAdd: Users activate eligible assignments; AdminUpdate: Administrators change existing role assignmentsAdminRemove: Administrators remove users/groups from roles;UserRemove: Users deactivate active assignments;UserExtend: Users request to extend their expiring assignments;AdminExtend: Administrators extend expiring assignments.UserRenew: Users request to renew their expired assignments;AdminRenew: Administrators extend expiring assignments.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Id of the app specific scope when the assignment scope is app specific. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use '/' for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[DirectoryScopeId <String>]`: Id of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    - `[PrincipalId <String>]`: Objectid of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: ID of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
    - `[TargetScheduleId <String>]`: ID of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
  - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 

## RELATED LINKS

## RELATED LINKS
