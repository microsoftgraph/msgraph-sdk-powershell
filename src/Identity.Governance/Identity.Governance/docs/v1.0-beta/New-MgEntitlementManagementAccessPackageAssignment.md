---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageassignment
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackageAssignment

## SYNOPSIS
Create a new entitlement management accessPackageAssignment

## SYNTAX

### CreateMultipleRequestAdminAddExistingUser (Default)
```
New-MgEntitlementManagementAccessPackageAssignment -AccessPackageId <String> -AssignmentPolicyId <String>
 -RequiredUserId <String[]> [-ExistingAssignment <MicrosoftGraphAccessPackageAssignment[]>]
 [-Answers <IMicrosoftGraphAccessPackageAnswer[]>] [-Justification <String>] [-StartDate <String>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateMultipleRequestAdminAddExistingGroupMember
```
New-MgEntitlementManagementAccessPackageAssignment -AccessPackageId <String> -AssignmentPolicyId <String>
 [-ExistingAssignment <MicrosoftGraphAccessPackageAssignment[]>]
 [-Answers <IMicrosoftGraphAccessPackageAnswer[]>] [-Justification <String>] [-StartDate <String>]
 -RequiredGroupMember <PSObject[]> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create a new entitlement management accessPackageAssignment

## EXAMPLES

## PARAMETERS

### -AccessPackageId

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Answers
Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
To construct, see NOTES section for ANSWERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAnswer[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentPolicyId

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExistingAssignment
To construct, see NOTES section for EXISTINGASSIGNMENT properties and create a hash table.

```yaml
Type: MicrosoftGraphAccessPackageAssignment[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Justification
The requestor's supplied justification.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredGroupMember

```yaml
Type: PSObject[]
Parameter Sets: CreateMultipleRequestAdminAddExistingGroupMember
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequiredUserId

```yaml
Type: String[]
Parameter Sets: CreateMultipleRequestAdminAddExistingUser
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDate

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ANSWERS <IMicrosoftGraphAccessPackageAnswer[]>: Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
  - `[AnsweredQuestion <IMicrosoftGraphAccessPackageQuestion>]`: accessPackageQuestion
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: ID of the question.
    - `[IsRequired <Boolean?>]`: Whether the requestor is required to supply an answer or not.
    - `[Sequence <Int32?>]`: Relative position of this question when displaying a list of questions to the requestor.
    - `[Text <IMicrosoftGraphAccessPackageLocalizedContent>]`: accessPackageLocalizedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DefaultText <String>]`: The fallback string, which is used when a requested localization is not available. Required.
      - `[LocalizedTexts <IMicrosoftGraphAccessPackageLocalizedText[]>]`: Content represented in a format for a specific locale.
        - `[LanguageCode <String>]`: The ISO code for the intended language. Required.
        - `[Text <String>]`: The text in the specific language. Required.
  - `[DisplayValue <String>]`: The display value of the answer. Required.

EXISTINGASSIGNMENT <MicrosoftGraphAccessPackageAssignment[]>: 
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: Read-only.
            - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: Read-only.
              - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
              - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
              - `[CreatedBy <String>]`: The display name of the user that created this object.
              - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
              - `[DisplayName <String>]`: The display name of this object.
              - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
              - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
              - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
              - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
            - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
            - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
              - `[Id <String>]`: Read-only.
              - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
              - `[Description <String>]`: The description of the scope.
              - `[DisplayName <String>]`: The display name of the scope.
              - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
              - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
              - `[OriginSystem <String>]`: The origin system for the scope.
              - `[RoleOriginId <String>]`: The origin system for the role, if different.
              - `[Url <String>]`: A resource locator for the scope.
            - `[AddedBy <String>]`: Read-only.
            - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
            - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
              - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[AttributeName <String>]`: 
              - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Id <String>]`: 
            - `[Description <String>]`: A description for the resource.
            - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
            - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
            - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
            - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
            - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
            - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
          - `[Description <String>]`: A description for the resource role.
          - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
          - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
          - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
        - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Nullable.
        - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: The access packages in this catalog. Read-only. Nullable.
        - `[CatalogStatus <String>]`: Has the value Published if the access packages are available for management.
        - `[CatalogType <String>]`: One of UserManaged or ServiceDefault.
        - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Description <String>]`: The description of the access package catalog.
        - `[DisplayName <String>]`: The display name of the access package catalog.
        - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
        - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
        - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[AccessPackageId <String>]`: ID of the access package.
      - `[AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>]`: assignmentReviewSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DurationInDays <Int32?>]`: The number of days to allow input from reviewers.
        - `[IsEnabled <Boolean?>]`: If true, access reviews are required for assignments from this policy.
        - `[RecurrenceType <String>]`: The interval for recurrence, such as monthly or quarterly.
        - `[ReviewerType <String>]`: Who should be asked to do the review, either Self or Reviewers.
        - `[Reviewers <IMicrosoftGraphUserSet[]>]`: If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers.
          - `[IsBackup <Boolean?>]`: For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
        - `[StartDateTime <DateTime?>]`: When the first review should start.
      - `[CanExtend <Boolean?>]`: Indicates whether a user can extend the access package assignment duration after approval.
      - `[CreatedBy <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Description <String>]`: The description of the policy.
      - `[DisplayName <String>]`: The display name of the policy.
      - `[DurationInDays <Int32?>]`: The number of days in which assignments from this policy last until they are expired.
      - `[ExpirationDateTime <DateTime?>]`: The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ModifiedBy <String>]`: Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Questions <IMicrosoftGraphAccessPackageQuestion[]>]`: Questions that are posed to the  requestor.
        - `[Id <String>]`: ID of the question.
        - `[IsRequired <Boolean?>]`: Whether the requestor is required to supply an answer or not.
        - `[Sequence <Int32?>]`: Relative position of this question when displaying a list of questions to the requestor.
        - `[Text <IMicrosoftGraphAccessPackageLocalizedContent>]`: accessPackageLocalizedContent
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DefaultText <String>]`: The fallback string, which is used when a requested localization is not available. Required.
          - `[LocalizedTexts <IMicrosoftGraphAccessPackageLocalizedText[]>]`: Content represented in a format for a specific locale.
            - `[LanguageCode <String>]`: The ISO code for the intended language. Required.
            - `[Text <String>]`: The text in the specific language. Required.
      - `[RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]`: approvalSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ApprovalMode <String>]`: One of NoApproval, SingleStage or Serial. The NoApproval is used when isApprovalRequired is false.
        - `[ApprovalStages <IMicrosoftGraphApprovalStage1[]>]`: If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.
          - `[ApprovalStageTimeOutInDays <Int32?>]`: The number of days that a request can be pending a response before it is automatically denied.
          - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
          - `[EscalationTimeInMinutes <Int32?>]`: If escalation is required, the time a request can be pending a response from a primary approver.
          - `[IsApproverJustificationRequired <Boolean?>]`: Indicates whether the approver is required to provide a justification for approving a request.
          - `[IsEscalationEnabled <Boolean?>]`: If true, then one or more escalation approvers are configured in this approval stage.
          - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
        - `[IsApprovalRequired <Boolean?>]`: If false, then approval is not required for requests in this policy.
        - `[IsApprovalRequiredForExtension <Boolean?>]`: If false, then approval is not required for a user who already has an assignment to extend their assignment.
        - `[IsRequestorJustificationRequired <Boolean?>]`: Indicates whether the requestor is required to supply a justification in their request.
      - `[RequestorSettings <IMicrosoftGraphRequestorSettings>]`: requestorSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AcceptRequests <Boolean?>]`: Indicates whether new requests are accepted on this policy.
        - `[AllowedRequestors <IMicrosoftGraphUserSet[]>]`: The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.
        - `[ScopeType <String>]`: Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.
    - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
      - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
      - `[CreatedBy <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ModifiedBy <String>]`: Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CatalogId <String>]`: ID of the access package catalog referencing this access package. Read-only.
    - `[CreatedBy <String>]`: UPN of the user or identity of the subject who created this resource. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package.
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[IsRoleScopesVisible <Boolean?>]`: Indicates whether role scopes are visible.
    - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>]`: accessPackageAssignment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
      - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
      - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: The resource roles delivered to the target user for this assignment. Read-only. Nullable.
        - `[Id <String>]`: Read-only.
        - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: The access package assignments resulting in this role assignment. Read-only. Nullable.
        - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
        - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
        - `[AccessPackageSubject <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[AltSecId <String>]`: 
          - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: Read-only.
            - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
            - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
            - `[Description <String>]`: The description of the connected organization.
            - `[DisplayName <String>]`: The display name of the connected organization.
            - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: Nullable.
              - `[Id <String>]`: Read-only.
              - `[DeletedDateTime <DateTime?>]`: 
            - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
            - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: Nullable.
            - `[ModifiedBy <String>]`: UPN of the user who last modified this resource. Read-only.
            - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
            - `[State <String>]`: connectedOrganizationState
          - `[ConnectedOrganizationId <String>]`: 
          - `[DisplayName <String>]`: The display name of the subject.
          - `[Email <String>]`: The email address of the subject.
          - `[ObjectId <String>]`: The object ID of the subject.
          - `[OnPremisesSecurityIdentifier <String>]`: 
          - `[PrincipalName <String>]`: The principal name, if known, of the subject.
          - `[Type <String>]`: The resource type of the subject.
        - `[OriginId <String>]`: A unique identifier relative to the origin system, corresponding to the originId property of the accessPackageResourceRole.
        - `[OriginSystem <String>]`: The system where the role assignment is to be created or has been created for an access package assignment, such as SharePointOnline, AadGroup or AadApplication, corresponding to the originSystem property of the accessPackageResourceRole.
        - `[Status <String>]`: The value is PendingFulfillment when the access package assignment has not yet been delivered to the origin system, and Fulfilled when the access package assignment has been delivered to the origin system.
      - `[AccessPackageId <String>]`: The identifier of the access package. Read-only.
      - `[AssignmentPolicyId <String>]`: The identifier of the access package assignment policy. Read-only.
      - `[AssignmentState <String>]`: The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only.
      - `[AssignmentStatus <String>]`: More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.
      - `[CatalogId <String>]`: The identifier of the catalog containing the access package. Read-only.
      - `[ExpiredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[IsExtended <Boolean?>]`: Indicates whether the access package assignment is extended. Read-only.
      - `[Schedule <IMicrosoftGraphRequestSchedule>]`: requestSchedule
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
      - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
      - `[TargetId <String>]`: The ID of the subject with the assignment. Read-only.
    - `[Answers <IMicrosoftGraphAccessPackageAnswer[]>]`: Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
      - `[AnsweredQuestion <IMicrosoftGraphAccessPackageQuestion>]`: accessPackageQuestion
      - `[DisplayValue <String>]`: The display value of the answer. Required.
    - `[CompletedDate <DateTime?>]`: The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsValidationOnly <Boolean?>]`: True if the request is not to be processed for assignment.
    - `[Justification <String>]`: The requestor's supplied justification.
    - `[RequestState <String>]`: One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, Submitted or Scheduled. Read-only.
    - `[RequestStatus <String>]`: More information on the request processing status. Read-only.
    - `[RequestType <String>]`: One of UserAdd, UserRemove, AdminAdd, AdminRemove or SystemRemove. A request from the user themselves would have requestType of UserAdd or UserRemove. Read-only.
    - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[Schedule <IMicrosoftGraphRequestSchedule>]`: requestSchedule
  - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: The resource roles delivered to the target user for this assignment. Read-only. Nullable.
  - `[AccessPackageId <String>]`: The identifier of the access package. Read-only.
  - `[AssignmentPolicyId <String>]`: The identifier of the access package assignment policy. Read-only.
  - `[AssignmentState <String>]`: The state of the access package assignment. Possible values are Delivering, Delivered, or Expired. Read-only.
  - `[AssignmentStatus <String>]`: More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.
  - `[CatalogId <String>]`: The identifier of the catalog containing the access package. Read-only.
  - `[ExpiredDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[IsExtended <Boolean?>]`: Indicates whether the access package assignment is extended. Read-only.
  - `[Schedule <IMicrosoftGraphRequestSchedule>]`: requestSchedule
  - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
  - `[TargetId <String>]`: The ID of the subject with the assignment. Read-only.
  - `[Id <String>]`: Read-only.

## RELATED LINKS

## RELATED LINKS
