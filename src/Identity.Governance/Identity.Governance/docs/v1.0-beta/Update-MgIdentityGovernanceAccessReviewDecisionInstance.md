---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgidentitygovernanceaccessreviewdecisioninstance
schema: 2.0.0
---

# Update-MgIdentityGovernanceAccessReviewDecisionInstance

## SYNOPSIS
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgIdentityGovernanceAccessReviewDecisionInstance -AccessReviewInstanceDecisionItemId <String>
 [-AdditionalProperties <Hashtable>] [-ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]
 [-Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>]
 [-Definition <IMicrosoftGraphAccessReviewScheduleDefinition1>] [-EndDateTime <DateTime>]
 [-Errors <IMicrosoftGraphAccessReviewError[]>]
 [-FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>] [-Id <String>]
 [-Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>] [-Scope <Hashtable>] [-StartDateTime <DateTime>]
 [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgIdentityGovernanceAccessReviewDecisionInstance -AccessReviewInstanceDecisionItemId <String>
 -BodyParameter <IMicrosoftGraphAccessReviewInstance> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgIdentityGovernanceAccessReviewDecisionInstance -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessReviewInstance> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgIdentityGovernanceAccessReviewDecisionInstance -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]
 [-Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>]
 [-Definition <IMicrosoftGraphAccessReviewScheduleDefinition1>] [-EndDateTime <DateTime>]
 [-Errors <IMicrosoftGraphAccessReviewError[]>]
 [-FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>] [-Id <String>]
 [-Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>] [-Scope <Hashtable>] [-StartDateTime <DateTime>]
 [-Status <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
There is exactly one accessReviewInstance associated with each decision.
The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.

## EXAMPLES

## PARAMETERS

### -AccessReviewInstanceDecisionItemId
key: id of accessReviewInstanceDecisionItem

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
accessReviewInstance
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewInstance
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContactedReviewers
Returns the collection of reviewers who were contacted to complete this review.
While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities.
Supports $select.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for CONTACTEDREVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Decisions
Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
To construct, please use Get-Help -Online and see NOTES section for DECISIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewInstanceDecisionItem[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Definition
accessReviewScheduleDefinition
To construct, please use Get-Help -Online and see NOTES section for DEFINITION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewScheduleDefinition1
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Supports $select.
Read-only.

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

### -Errors
Collection of errors in an access review instance lifecycle.
Read-only.
To construct, please use Get-Help -Online and see NOTES section for ERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewError[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FallbackReviewers
This collection of reviewer scopes is used to define the list of fallback reviewers.
These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified.
This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist.
Supports $select.
To construct, please use Get-Help -Online and see NOTES section for FALLBACKREVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewerScope[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Reviewers
This collection of access review scopes is used to define who the reviewers are.
Supports $select.
For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
To construct, please use Get-Help -Online and see NOTES section for REVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewerScope[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
accessReviewScope

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

### -StartDateTime
DateTime when review instance is scheduled to start.
May be in the future.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Supports $select.
Read-only.

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
Specifies the status of an accessReview.
Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.
Supports $select, $orderby, and $filter (eq only).
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

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewInstance

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAccessReviewInstance>: accessReviewInstance
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
    - `[DisplayName <String>]`: Name of reviewer.
    - `[UserPrincipalName <String>]`: User principal name of the user.
  - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>]`: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
    - `[Id <String>]`: Read-only.
    - `[AccessReviewId <String>]`: The identifier of the accessReviewInstance parent. Supports $select. Read-only.
    - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
      - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[AppliedDateTime <DateTime?>]`: The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.
    - `[ApplyResult <String>]`: The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.
    - `[Decision <String>]`: Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).
    - `[Insights <IMicrosoftGraphGovernanceInsight[]>]`: Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.
      - `[Id <String>]`: Read-only.
      - `[InsightCreatedDateTime <DateTime?>]`: Indicates when the insight was created.
    - `[Instance <IMicrosoftGraphAccessReviewInstance>]`: accessReviewInstance
    - `[Justification <String>]`: Justification left by the reviewer when they made the decision.
    - `[Principal <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[PrincipalLink <String>]`: Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.
    - `[Recommendation <String>]`: A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.
    - `[Resource <IMicrosoftGraphAccessReviewInstanceDecisionItemResource>]`: accessReviewInstanceDecisionItemResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: Display name of the resource
      - `[Id <String>]`: Resource ID
      - `[Type <String>]`: Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.
    - `[ResourceLink <String>]`: A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.
    - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[ReviewedDateTime <DateTime?>]`: The timestamp when the review decision occurred. Supports $select. Read-only.
    - `[Target <IMicrosoftGraphAccessReviewInstanceDecisionItemTarget>]`: accessReviewInstanceDecisionItemTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Definition <IMicrosoftGraphAccessReviewScheduleDefinition1>]`: accessReviewScheduleDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AdditionalNotificationRecipients <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>]`: Defines the list of additional users or group members to be notified of the access review progress.
      - `[NotificationRecipientScope <IMicrosoftGraphAccessReviewNotificationRecipientScope>]`: accessReviewNotificationRecipientScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NotificationTemplateType <String>]`: Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.
    - `[BackupReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: 
      - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
      - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
      - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
    - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[CreatedDateTime <DateTime?>]`: Timestamp when the access review series was created. Supports $select. Read-only.
    - `[DescriptionForAdmins <String>]`: Description provided by review creators to provide more context of the review to admins. Supports $select.
    - `[DescriptionForReviewers <String>]`: Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.
    - `[DisplayName <String>]`: Name of the access review series. Supports $select and $orderBy. Required on create.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select.
    - `[InstanceEnumerationScope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Instances <IMicrosoftGraphAccessReviewInstance[]>]`: Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
    - `[LastModifiedDateTime <DateTime?>]`: Timestamp when the access review series was last modified. Supports $select. Read-only.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
    - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings>]`: accessReviewScheduleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
      - `[AutoApplyDecisionsEnabled <Boolean?>]`: Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
      - `[DefaultDecision <String>]`: Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
      - `[DefaultDecisionEnabled <Boolean?>]`: Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
      - `[InstanceDurationInDays <Int32?>]`: Duration of each recurrence of review (accessReviewInstance) in number of days.
      - `[JustificationRequiredOnApproval <Boolean?>]`: Indicates whether reviewers are required to provide justification with their decision. Default value is false.
      - `[MailNotificationsEnabled <Boolean?>]`: Indicates whether emails are enabled or disabled. Default value is false.
      - `[RecommendationInsightSettings <IMicrosoftGraphAccessReviewRecommendationInsightSetting[]>]`: Optional. Describes the types of insights that aid reviewers to make access review decisions.
      - `[RecommendationLookBackDuration <TimeSpan?>]`: Optional field. Indicates the time period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days.
      - `[RecommendationsEnabled <Boolean?>]`: Indicates whether decision recommendations are enabled or disabled.
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
      - `[ReminderNotificationsEnabled <Boolean?>]`: Indicates whether reminders are enabled or disabled. Default value is false.
    - `[Status <String>]`: This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[EndDateTime <DateTime?>]`: DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
  - `[Errors <IMicrosoftGraphAccessReviewError[]>]`: Collection of errors in an access review instance lifecycle. Read-only.
    - `[Code <String>]`: The error code.
    - `[Message <String>]`: The error message.
  - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
  - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
  - `[StartDateTime <DateTime?>]`: DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
  - `[Status <String>]`: Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.

CONTACTEDREVIEWERS <IMicrosoftGraphAccessReviewReviewer[]>: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
  - `[DisplayName <String>]`: Name of reviewer.
  - `[UserPrincipalName <String>]`: User principal name of the user.

DECISIONS <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
  - `[Id <String>]`: Read-only.
  - `[AccessReviewId <String>]`: The identifier of the accessReviewInstance parent. Supports $select. Read-only.
  - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[AppliedDateTime <DateTime?>]`: The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.
  - `[ApplyResult <String>]`: The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[Decision <String>]`: Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).
  - `[Insights <IMicrosoftGraphGovernanceInsight[]>]`: Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.
    - `[Id <String>]`: Read-only.
    - `[InsightCreatedDateTime <DateTime?>]`: Indicates when the insight was created.
  - `[Instance <IMicrosoftGraphAccessReviewInstance>]`: accessReviewInstance
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
      - `[Id <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
      - `[DisplayName <String>]`: Name of reviewer.
      - `[UserPrincipalName <String>]`: User principal name of the user.
    - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>]`: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
    - `[Definition <IMicrosoftGraphAccessReviewScheduleDefinition1>]`: accessReviewScheduleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AdditionalNotificationRecipients <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>]`: Defines the list of additional users or group members to be notified of the access review progress.
        - `[NotificationRecipientScope <IMicrosoftGraphAccessReviewNotificationRecipientScope>]`: accessReviewNotificationRecipientScope
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NotificationTemplateType <String>]`: Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.
      - `[BackupReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: 
        - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
        - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
        - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
      - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[CreatedDateTime <DateTime?>]`: Timestamp when the access review series was created. Supports $select. Read-only.
      - `[DescriptionForAdmins <String>]`: Description provided by review creators to provide more context of the review to admins. Supports $select.
      - `[DescriptionForReviewers <String>]`: Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.
      - `[DisplayName <String>]`: Name of the access review series. Supports $select and $orderBy. Required on create.
      - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select.
      - `[InstanceEnumerationScope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Instances <IMicrosoftGraphAccessReviewInstance[]>]`: Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
      - `[LastModifiedDateTime <DateTime?>]`: Timestamp when the access review series was last modified. Supports $select. Read-only.
      - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
      - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
      - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings>]`: accessReviewScheduleSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
        - `[AutoApplyDecisionsEnabled <Boolean?>]`: Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
        - `[DefaultDecision <String>]`: Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
        - `[DefaultDecisionEnabled <Boolean?>]`: Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
        - `[InstanceDurationInDays <Int32?>]`: Duration of each recurrence of review (accessReviewInstance) in number of days.
        - `[JustificationRequiredOnApproval <Boolean?>]`: Indicates whether reviewers are required to provide justification with their decision. Default value is false.
        - `[MailNotificationsEnabled <Boolean?>]`: Indicates whether emails are enabled or disabled. Default value is false.
        - `[RecommendationInsightSettings <IMicrosoftGraphAccessReviewRecommendationInsightSetting[]>]`: Optional. Describes the types of insights that aid reviewers to make access review decisions.
        - `[RecommendationLookBackDuration <TimeSpan?>]`: Optional field. Indicates the time period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days.
        - `[RecommendationsEnabled <Boolean?>]`: Indicates whether decision recommendations are enabled or disabled.
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
        - `[ReminderNotificationsEnabled <Boolean?>]`: Indicates whether reminders are enabled or disabled. Default value is false.
      - `[Status <String>]`: This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.
    - `[EndDateTime <DateTime?>]`: DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[Errors <IMicrosoftGraphAccessReviewError[]>]`: Collection of errors in an access review instance lifecycle. Read-only.
      - `[Code <String>]`: The error code.
      - `[Message <String>]`: The error message.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
    - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[StartDateTime <DateTime?>]`: DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[Status <String>]`: Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[Justification <String>]`: Justification left by the reviewer when they made the decision.
  - `[Principal <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[PrincipalLink <String>]`: Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.
  - `[Recommendation <String>]`: A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[Resource <IMicrosoftGraphAccessReviewInstanceDecisionItemResource>]`: accessReviewInstanceDecisionItemResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: Display name of the resource
    - `[Id <String>]`: Resource ID
    - `[Type <String>]`: Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.
  - `[ResourceLink <String>]`: A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.
  - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
  - `[ReviewedDateTime <DateTime?>]`: The timestamp when the review decision occurred. Supports $select. Read-only.
  - `[Target <IMicrosoftGraphAccessReviewInstanceDecisionItemTarget>]`: accessReviewInstanceDecisionItemTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

DEFINITION <IMicrosoftGraphAccessReviewScheduleDefinition1>: accessReviewScheduleDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AdditionalNotificationRecipients <IMicrosoftGraphAccessReviewNotificationRecipientItem[]>]`: Defines the list of additional users or group members to be notified of the access review progress.
    - `[NotificationRecipientScope <IMicrosoftGraphAccessReviewNotificationRecipientScope>]`: accessReviewNotificationRecipientScope
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NotificationTemplateType <String>]`: Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.
  - `[BackupReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: 
    - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
    - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
    - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[CreatedDateTime <DateTime?>]`: Timestamp when the access review series was created. Supports $select. Read-only.
  - `[DescriptionForAdmins <String>]`: Description provided by review creators to provide more context of the review to admins. Supports $select.
  - `[DescriptionForReviewers <String>]`: Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Email notifications support up to 256 characters. Supports $select.
  - `[DisplayName <String>]`: Name of the access review series. Supports $select and $orderBy. Required on create.
  - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select.
  - `[InstanceEnumerationScope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Instances <IMicrosoftGraphAccessReviewInstance[]>]`: Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
    - `[Id <String>]`: Read-only.
    - `[ContactedReviewers <IMicrosoftGraphAccessReviewReviewer[]>]`: Returns the collection of reviewers who were contacted to complete this review. While the reviewers and fallbackReviewers properties of the accessReviewScheduleDefinition might specify group owners or managers as reviewers, contactedReviewers returns their individual identities. Supports $select. Read-only.
      - `[Id <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date when the reviewer was added for the access review.
      - `[DisplayName <String>]`: Name of reviewer.
      - `[UserPrincipalName <String>]`: User principal name of the user.
    - `[Decisions <IMicrosoftGraphAccessReviewInstanceDecisionItem[]>]`: Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.
      - `[Id <String>]`: Read-only.
      - `[AccessReviewId <String>]`: The identifier of the accessReviewInstance parent. Supports $select. Read-only.
      - `[AppliedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[AppliedDateTime <DateTime?>]`: The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.
      - `[ApplyResult <String>]`: The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.
      - `[Decision <String>]`: Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).
      - `[Insights <IMicrosoftGraphGovernanceInsight[]>]`: Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.
        - `[Id <String>]`: Read-only.
        - `[InsightCreatedDateTime <DateTime?>]`: Indicates when the insight was created.
      - `[Instance <IMicrosoftGraphAccessReviewInstance>]`: accessReviewInstance
      - `[Justification <String>]`: Justification left by the reviewer when they made the decision.
      - `[Principal <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[PrincipalLink <String>]`: Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.
      - `[Recommendation <String>]`: A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.
      - `[Resource <IMicrosoftGraphAccessReviewInstanceDecisionItemResource>]`: accessReviewInstanceDecisionItemResource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: Display name of the resource
        - `[Id <String>]`: Resource ID
        - `[Type <String>]`: Type of resource. Types include: Group, ServicePrincipal, DirectoryRole, AzureRole, AccessPackageAssignmentPolicy.
      - `[ResourceLink <String>]`: A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.
      - `[ReviewedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[ReviewedDateTime <DateTime?>]`: The timestamp when the review decision occurred. Supports $select. Read-only.
      - `[Target <IMicrosoftGraphAccessReviewInstanceDecisionItemTarget>]`: accessReviewInstanceDecisionItemTarget
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Definition <IMicrosoftGraphAccessReviewScheduleDefinition1>]`: accessReviewScheduleDefinition
    - `[EndDateTime <DateTime?>]`: DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[Errors <IMicrosoftGraphAccessReviewError[]>]`: Collection of errors in an access review instance lifecycle. Read-only.
      - `[Code <String>]`: The error code.
      - `[Message <String>]`: The error message.
    - `[FallbackReviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
    - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
    - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
    - `[StartDateTime <DateTime?>]`: DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.
    - `[Status <String>]`: Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.
  - `[LastModifiedDateTime <DateTime?>]`: Timestamp when the access review series was last modified. Supports $select. Read-only.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
  - `[Scope <IMicrosoftGraphAccessReviewScope>]`: accessReviewScope
  - `[Settings <IMicrosoftGraphAccessReviewScheduleSettings>]`: accessReviewScheduleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ApplyActions <IMicrosoftGraphAccessReviewApplyAction[]>]`: Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
    - `[AutoApplyDecisionsEnabled <Boolean?>]`: Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
    - `[DefaultDecision <String>]`: Decision chosen if defaultDecisionEnabled is enabled. Can be one of Approve, Deny, or Recommendation.
    - `[DefaultDecisionEnabled <Boolean?>]`: Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
    - `[InstanceDurationInDays <Int32?>]`: Duration of each recurrence of review (accessReviewInstance) in number of days.
    - `[JustificationRequiredOnApproval <Boolean?>]`: Indicates whether reviewers are required to provide justification with their decision. Default value is false.
    - `[MailNotificationsEnabled <Boolean?>]`: Indicates whether emails are enabled or disabled. Default value is false.
    - `[RecommendationInsightSettings <IMicrosoftGraphAccessReviewRecommendationInsightSetting[]>]`: Optional. Describes the types of insights that aid reviewers to make access review decisions.
    - `[RecommendationLookBackDuration <TimeSpan?>]`: Optional field. Indicates the time period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look back duration. For reviews of groups and Azure AD roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days.
    - `[RecommendationsEnabled <Boolean?>]`: Indicates whether decision recommendations are enabled or disabled.
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
    - `[ReminderNotificationsEnabled <Boolean?>]`: Indicates whether reminders are enabled or disabled. Default value is false.
  - `[Status <String>]`: This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.

ERRORS <IMicrosoftGraphAccessReviewError[]>: Collection of errors in an access review instance lifecycle. Read-only.
  - `[Code <String>]`: The error code.
  - `[Message <String>]`: The error message.

FALLBACKREVIEWERS <IMicrosoftGraphAccessReviewReviewerScope[]>: This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. Supports $select.
  - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
  - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
  - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.

INPUTOBJECT <IIdentityGovernanceIdentity>: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: key: id of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: key: id of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: key: id of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: key: id of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: key: id of accessPackageCatalog
  - `[AccessPackageId <String>]`: key: id of accessPackage
  - `[AccessPackageResourceEnvironmentId <String>]`: key: id of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: key: id of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: key: id of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: key: id of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: key: id of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: key: id of accessPackageResourceScope
  - `[AccessReviewDecisionId <String>]`: key: id of accessReviewDecision
  - `[AccessReviewHistoryDefinitionId <String>]`: key: id of accessReviewHistoryDefinition
  - `[AccessReviewHistoryInstanceId <String>]`: key: id of accessReviewHistoryInstance
  - `[AccessReviewId <String>]`: key: id of accessReview
  - `[AccessReviewId1 <String>]`: key: id of accessReview
  - `[AccessReviewInstanceDecisionItemId <String>]`: key: id of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceDecisionItemId1 <String>]`: key: id of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewReviewerId <String>]`: key: id of accessReviewReviewer
  - `[AccessReviewScheduleDefinitionId <String>]`: key: id of accessReviewScheduleDefinition
  - `[AgreementAcceptanceId <String>]`: key: id of agreementAcceptance
  - `[AgreementFileLocalizationId <String>]`: key: id of agreementFileLocalization
  - `[AgreementFileVersionId <String>]`: key: id of agreementFileVersion
  - `[AgreementId <String>]`: key: id of agreement
  - `[AppConsentRequestId <String>]`: key: id of appConsentRequest
  - `[ApprovalId <String>]`: key: id of approval
  - `[ApprovalStageId <String>]`: key: id of approvalStage
  - `[ApprovalStepId <String>]`: key: id of approvalStep
  - `[BusinessFlowTemplateId <String>]`: key: id of businessFlowTemplate
  - `[ConnectedOrganizationId <String>]`: key: id of connectedOrganization
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[GovernanceInsightId <String>]`: key: id of governanceInsight
  - `[GovernanceResourceId <String>]`: key: id of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: key: id of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: key: id of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: key: id of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: key: id of governanceRoleSetting
  - `[GroupId <String>]`: key: id of group
  - `[On <String>]`: Usage: on={on}
  - `[PrivilegedAccessId <String>]`: key: id of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: key: id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: id of privilegedRole
  - `[ProgramControlId <String>]`: key: id of programControl
  - `[ProgramControlTypeId <String>]`: key: id of programControlType
  - `[ProgramId <String>]`: key: id of program
  - `[UserConsentRequestId <String>]`: key: id of userConsentRequest
  - `[UserId <String>]`: key: id of user

REVIEWERS <IMicrosoftGraphAccessReviewReviewerScope[]>: This collection of access review scopes is used to define who the reviewers are. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.
  - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
  - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
  - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.

## RELATED LINKS

