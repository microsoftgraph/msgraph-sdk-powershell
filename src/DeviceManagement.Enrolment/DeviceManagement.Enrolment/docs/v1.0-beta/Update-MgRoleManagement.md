---
external help file:
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
Update-MgRoleManagement [-AdditionalProperties <Hashtable>]
 [-CloudPc <IMicrosoftGraphRbacApplicationMultiple>]
 [-DeviceManagement <IMicrosoftGraphRbacApplicationMultiple>] [-Directory <IMicrosoftGraphRbacApplication>]
 [-EntitlementManagement <IMicrosoftGraphRbacApplication>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgRoleManagement -BodyParameter <IMicrosoftGraphRoleManagement1> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update roleManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRoleManagement1
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
To construct, please use Get-Help -Online and see NOTES section for CLOUDPC properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple
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
To construct, please use Get-Help -Online and see NOTES section for DEVICEMANAGEMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplicationMultiple
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
To construct, please use Get-Help -Online and see NOTES section for DIRECTORY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplication
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
To construct, please use Get-Help -Online and see NOTES section for ENTITLEMENTMANAGEMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRbacApplication
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
      - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
      - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
        - `[Id <String>]`: Read-only.
        - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
        - `[Description <String>]`: Description for the action. Supports $filter (eq).
        - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
        - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[DisplayName <String>]`: 
          - `[Scope <String>]`: 
          - `[Type <String>]`: 
        - `[ResourceScopeId <String>]`: Not implemented.
    - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
      - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. Read-only.
        - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. Read-only.
      - `[Condition <String>]`: 
      - `[Description <String>]`: Description of the role assignment.
      - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
      - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
        - `[Id <String>]`: Read-only.
        - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[DisplayName <String>]`: Name of the role assignment. Required.
      - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
      - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
        - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).
        - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.
        - `[IsBuiltIn <Boolean?>]`: Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).
        - `[IsEnabled <Boolean?>]`: Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
        - `[ResourceScopes <String[]>]`: List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
        - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
          - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource. Required.
          - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
          - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
        - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.
        - `[Version <String>]`: Indicates version of the role definition. Read-only when isBuiltIn is true.
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
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
        - `[Id <String>]`: Read-only.
        - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire.
        - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
        - `[RoleEligibilityScheduleId <String>]`: Identifier of the parent roleEligibilitySchedule for this instance.
        - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start.
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
      - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
      - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
    - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
      - `[ApprovalId <String>]`: The identifier of the approval of the request.
      - `[CompletedDateTime <DateTime?>]`: The request completion date time.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CreatedDateTime <DateTime?>]`: The request creation date time.
      - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
      - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
      - `[Id <String>]`: Read-only.
      - `[Action <String>]`: Represents the type of the operation on the role assignment. The possible values are: AdminAssign: For administrators to assign roles to users or groups.AdminRemove: For administrators to remove users or groups from roles. AdminUpdate: For administrators to change existing role assignments.AdminExtend: For administrators to extend expiring assignments.AdminRenew: For administrators to renew expired assignments.SelfActivate: For users to activate their assignments.SelfDeactivate: For users to deactivate their active assignments.SelfExtend: For users to request to extend their expiring assignments.SelfRenew: For users to request to renew their expired assignments.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
        - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
        - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
        - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
        - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
        - `[Id <String>]`: Read-only.
        - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
        - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
            - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Type <String>]`: expirationPatternType
          - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
              - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
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
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
      - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
        - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
        - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
        - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
        - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
        - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
        - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
        - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
        - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
        - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
        - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
        - `[Id <String>]`: Read-only.
        - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
        - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
        - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
        - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetScheduleId <String>]`: Identifier of the schedule object attached to the assignment.
      - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[TicketNumber <String>]`: Ticket number meta data
        - `[TicketSystem <String>]`: Ticket system meta data
    - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
    - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: Resource to grant access to users or groups.
      - `[Id <String>]`: Read-only.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific.  Either this property or directoryScopeId is required. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, in).
      - `[Condition <String>]`: 
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment.  Either this property or appScopeId is required. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, in).
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq, in).
      - `[PrincipalOrganizationId <String>]`: 
      - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the role definition the assignment is for. Read only. Supports $filter (eq, in).
    - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.
    - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
    - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
      - `[ApprovalId <String>]`: The identifier of the approval of the request.
      - `[CompletedDateTime <DateTime?>]`: The request completion date time.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: The request creation date time.
      - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
      - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
      - `[Id <String>]`: Read-only.
      - `[Action <String>]`: Represents the type of the operation on the role eligibility assignment. The possible values are: AdminAssign: For administrators to assign role eligibility to users or groups to roles.AdminExtend: For administrators to extend expiring assignments.AdminUpdate: For administrators to change existing role assignments.AdminRenew: For administrators to renew expired assignments.AdminRemove: For administrators to remove users or groups from eligible roles.UserAdd: For users to activate their eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
      - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. For example, a user or a group. For groups, they must be assignable to roles, that is, the isAssignableToRole of the group property set to true.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
      - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[TargetScheduleId <String>]`: The time period for which the eligibility assignment is valid.
      - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
    - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 
    - `[TransitiveRoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: 
  - `[EntitlementManagement <IMicrosoftGraphRbacApplication>]`: rbacApplication

CLOUDPC <IMicrosoftGraphRbacApplicationMultiple>: rbacApplicationMultiple
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
      - `[Description <String>]`: Description for the action. Supports $filter (eq).
      - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: Not implemented.
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. Read-only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. Read-only.
    - `[Condition <String>]`: 
    - `[Description <String>]`: Description of the role assignment.
    - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[DisplayName <String>]`: Name of the role assignment. Required.
    - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).
      - `[IsEnabled <Boolean?>]`: Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource. Required.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.
      - `[Version <String>]`: Indicates version of the role definition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 

DEVICEMANAGEMENT <IMicrosoftGraphRbacApplicationMultiple>: rbacApplicationMultiple
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
      - `[Description <String>]`: Description for the action. Supports $filter (eq).
      - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: Not implemented.
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignmentMultiple[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppScopeIds <String[]>]`: Ids of the app specific scopes when the assignment scopes are app specific. The scopes of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. App scopes are scopes that are defined and understood by this application only.
    - `[AppScopes <IMicrosoftGraphAppScope[]>]`: Read-only collection with details of the app specific scopes when the assignment scopes are app specific. Containment entity. Read-only.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. Read-only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. Read-only.
    - `[Condition <String>]`: 
    - `[Description <String>]`: Description of the role assignment.
    - `[DirectoryScopeIds <String[]>]`: Ids of the directory objects representing the scopes of the assignment. The scopes of an assignment determine the set of resources for which the principals have been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. App scopes are scopes that are defined and understood by this application only.
    - `[DirectoryScopes <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the directory objects that are scope of the assignment. Provided so that callers can get the directory objects using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[DisplayName <String>]`: Name of the role assignment. Required.
    - `[PrincipalIds <String[]>]`: Identifiers of the principals to which the assignment is granted.  Supports $filter (any operator only).
    - `[Principals <IMicrosoftGraphDirectoryObject[]>]`: Read-only collection referencing the assigned principals. Provided so that callers can get the principals using $expand at the same time as getting the role assignment. Read-only.  Supports $expand.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).
      - `[IsEnabled <Boolean?>]`: Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource. Required.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.
      - `[Version <String>]`: Indicates version of the role definition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for.
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: 

DIRECTORY <IMicrosoftGraphRbacApplication>: rbacApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
      - `[Description <String>]`: Description for the action. Supports $filter (eq).
      - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: Not implemented.
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
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. Read-only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. Read-only.
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).
      - `[IsEnabled <Boolean?>]`: Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource. Required.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.
      - `[Version <String>]`: Indicates version of the role definition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
    - `[Id <String>]`: Read-only.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleEligibilityScheduleId <String>]`: Identifier of the parent roleEligibilitySchedule for this instance.
      - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start.
    - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
    - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
    - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
    - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
    - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
    - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
  - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Represents the type of the operation on the role assignment. The possible values are: AdminAssign: For administrators to assign roles to users or groups.AdminRemove: For administrators to remove users or groups from roles. AdminUpdate: For administrators to change existing role assignments.AdminExtend: For administrators to extend expiring assignments.AdminRenew: For administrators to renew expired assignments.SelfActivate: For users to activate their assignments.SelfDeactivate: For users to deactivate their active assignments.SelfExtend: For users to request to extend their expiring assignments.SelfRenew: For users to request to renew their expired assignments.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
          - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Type <String>]`: expirationPatternType
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
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
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetScheduleId <String>]`: Identifier of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TicketNumber <String>]`: Ticket number meta data
      - `[TicketSystem <String>]`: Ticket system meta data
  - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: Resource to grant access to users or groups.
    - `[Id <String>]`: Read-only.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific.  Either this property or directoryScopeId is required. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, in).
    - `[Condition <String>]`: 
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment.  Either this property or appScopeId is required. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, in).
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq, in).
    - `[PrincipalOrganizationId <String>]`: 
    - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the role definition the assignment is for. Read only. Supports $filter (eq, in).
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.
  - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
  - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Represents the type of the operation on the role eligibility assignment. The possible values are: AdminAssign: For administrators to assign role eligibility to users or groups to roles.AdminExtend: For administrators to extend expiring assignments.AdminUpdate: For administrators to change existing role assignments.AdminRenew: For administrators to renew expired assignments.AdminRemove: For administrators to remove users or groups from eligible roles.UserAdd: For users to activate their eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. For example, a user or a group. For groups, they must be assignable to roles, that is, the isAssignableToRole of the group property set to true.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
    - `[TargetScheduleId <String>]`: The time period for which the eligibility assignment is valid.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
  - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 
  - `[TransitiveRoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: 

ENTITLEMENTMANAGEMENT <IMicrosoftGraphRbacApplication>: rbacApplication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ResourceNamespaces <IMicrosoftGraphUnifiedRbacResourceNamespace[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).
    - `[ResourceActions <IMicrosoftGraphUnifiedRbacResourceAction[]>]`: Operations that an authorized principal are allowed to perform.
      - `[Id <String>]`: Read-only.
      - `[ActionVerb <String>]`: HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.
      - `[Description <String>]`: Description for the action. Supports $filter (eq).
      - `[Name <String>]`: Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).
      - `[ResourceScope <IMicrosoftGraphUnifiedRbacResourceScope>]`: unifiedRbacResourceScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DisplayName <String>]`: 
        - `[Scope <String>]`: 
        - `[Type <String>]`: 
      - `[ResourceScopeId <String>]`: Not implemented.
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
      - `[DisplayName <String>]`: Provides the display name of the app-specific resource represented by the app scope. Provided for display purposes since appScopeId is often an immutable, non-human-readable id. Read-only.
      - `[Type <String>]`: Describes the type of app-specific resource represented by the app scope. Provided for display purposes, so a user interface can convey to the user the kind of app specific resource represented by the app scope. Read-only.
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Description <String>]`: The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.
      - `[DisplayName <String>]`: The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).
      - `[InheritsPermissionsFrom <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.
      - `[IsBuiltIn <Boolean?>]`: Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).
      - `[IsEnabled <Boolean?>]`: Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.
      - `[ResourceScopes <String[]>]`: List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.
      - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: List of permissions included in the role. Read-only when isBuiltIn is true. Required.
        - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource. Required.
        - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
        - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
      - `[TemplateId <String>]`: Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.
      - `[Version <String>]`: Indicates version of the role definition. Read-only when isBuiltIn is true.
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
    - `[Id <String>]`: Read-only.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance>]`: unifiedRoleEligibilityScheduleInstance
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Can be a group or a user.
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.  Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[EndDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will expire.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[RoleEligibilityScheduleId <String>]`: Identifier of the parent roleEligibilitySchedule for this instance.
      - `[StartDateTime <DateTime?>]`: Time that the roleEligibilityScheduleInstance will start.
    - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
    - `[EndDateTime <DateTime?>]`: Time that the roleAssignmentInstance will expire
    - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
    - `[RoleAssignmentOriginId <String>]`: ID of the roleAssignment in the directory
    - `[RoleAssignmentScheduleId <String>]`: ID of the parent roleAssignmentSchedule for this instance
    - `[StartDateTime <DateTime?>]`: Time that the roleAssignmentInstance will start
  - `[RoleAssignmentScheduleRequests <IMicrosoftGraphUnifiedRoleAssignmentScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Represents the type of the operation on the role assignment. The possible values are: AdminAssign: For administrators to assign roles to users or groups.AdminRemove: For administrators to remove users or groups from roles. AdminUpdate: For administrators to change existing role assignments.AdminExtend: For administrators to extend expiring assignments.AdminRenew: For administrators to renew expired assignments.SelfActivate: For users to activate their assignments.SelfDeactivate: For users to deactivate their active assignments.SelfExtend: For users to request to extend their expiring assignments.SelfRenew: For users to request to renew their expired assignments.
    - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[MemberType <String>]`: Membership type of the eligible assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Expiration <IMicrosoftGraphExpirationPattern>]`: expirationPattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Duration <TimeSpan?>]`: The requestor's desired duration of access represented in ISO 8601 format for durations. For example, PT3H refers to three hours.  If specified in a request, endDateTime should not be present and the type property should be set to afterDuration.
          - `[EndDateTime <DateTime?>]`: Timestamp of date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Type <String>]`: expirationPatternType
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
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
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleAssignmentSchedule>]`: unifiedRoleAssignmentSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
      - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units or all users.
      - `[CreatedDateTime <DateTime?>]`: Time that the schedule was created.
      - `[CreatedUsing <String>]`: Identifier of the roleAssignmentScheduleRequest that created this schedule.
      - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
      - `[ModifiedDateTime <DateTime?>]`: Last time the schedule was updated.
      - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
      - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. Supports $filter (eq).
      - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
      - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only. Supports $filter (eq).
      - `[Status <String>]`: Status for the roleAssignmentSchedule. It can include state related messages like Provisioned, Revoked, Pending Provisioning, and Pending Approval. Supports $filter (eq).
      - `[Id <String>]`: Read-only.
      - `[ActivatedUsing <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
      - `[AssignmentType <String>]`: Type of the assignment. It can either be Assigned or Activated.
      - `[MemberType <String>]`: Membership type of the assignment. It can either be Inherited, Direct, or Group.
      - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetScheduleId <String>]`: Identifier of the schedule object attached to the assignment.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TicketNumber <String>]`: Ticket number meta data
      - `[TicketSystem <String>]`: Ticket system meta data
  - `[RoleAssignmentSchedules <IMicrosoftGraphUnifiedRoleAssignmentSchedule[]>]`: 
  - `[RoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: Resource to grant access to users or groups.
    - `[Id <String>]`: Read-only.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific.  Either this property or directoryScopeId is required. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, in).
    - `[Condition <String>]`: 
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment.  Either this property or appScopeId is required. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, in).
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is granted. Supports $filter (eq, in).
    - `[PrincipalOrganizationId <String>]`: 
    - `[ResourceScope <String>]`: The scope at which the unifiedRoleAssignment applies. This is / for service-wide. DO NOT USE. This property will be deprecated soon.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the role definition the assignment is for. Read only. Supports $filter (eq, in).
  - `[RoleDefinitions <IMicrosoftGraphUnifiedRoleDefinition[]>]`: Resource representing the roles allowed by RBAC providers and the permissions assigned to the roles.
  - `[RoleEligibilityScheduleInstances <IMicrosoftGraphUnifiedRoleEligibilityScheduleInstance[]>]`: 
  - `[RoleEligibilityScheduleRequests <IMicrosoftGraphUnifiedRoleEligibilityScheduleRequest[]>]`: 
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: Represents the type of the operation on the role eligibility assignment. The possible values are: AdminAssign: For administrators to assign role eligibility to users or groups to roles.AdminExtend: For administrators to extend expiring assignments.AdminUpdate: For administrators to change existing role assignments.AdminRenew: For administrators to renew expired assignments.AdminRemove: For administrators to remove users or groups from eligible roles.UserAdd: For users to activate their eligible assignments.UserExtend: For users to request to extend their expiring eligible assignments.UserRemove: For users to deactivate their active eligible assignments.UserRenew: For users to request to renew their expired eligible assignments.
    - `[AppScope <IMicrosoftGraphAppScope>]`: appScope
    - `[AppScopeId <String>]`: Identifier of the app-specific scope when the assignment scope is app-specific. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units.
    - `[DirectoryScope <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[DirectoryScopeId <String>]`: Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only.
    - `[IsValidationOnly <Boolean?>]`: A boolean that determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.
    - `[Justification <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[Principal <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[PrincipalId <String>]`: Identifier of the principal to which the assignment is being granted to. For example, a user or a group. For groups, they must be assignable to roles, that is, the isAssignableToRole of the group property set to true.
    - `[RoleDefinition <IMicrosoftGraphUnifiedRoleDefinition>]`: unifiedRoleDefinition
    - `[RoleDefinitionId <String>]`: Identifier of the unifiedRoleDefinition the assignment is for. Read only.
    - `[ScheduleInfo <IMicrosoftGraphRequestSchedule>]`: requestSchedule
    - `[TargetSchedule <IMicrosoftGraphUnifiedRoleEligibilitySchedule>]`: unifiedRoleEligibilitySchedule
    - `[TargetScheduleId <String>]`: The time period for which the eligibility assignment is valid.
    - `[TicketInfo <IMicrosoftGraphTicketInfo>]`: ticketInfo
  - `[RoleEligibilitySchedules <IMicrosoftGraphUnifiedRoleEligibilitySchedule[]>]`: 
  - `[TransitiveRoleAssignments <IMicrosoftGraphUnifiedRoleAssignment1[]>]`: 

## RELATED LINKS

