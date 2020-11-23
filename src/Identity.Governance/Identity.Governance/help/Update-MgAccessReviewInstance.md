---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgaccessreviewinstance
schema: 2.0.0
---

# Update-MgAccessReviewInstance

## SYNOPSIS
Update the navigation property instances in accessReviews

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAccessReviewInstance -AccessReviewId <String> -AccessReviewId1 <String>
 [-AdditionalProperties <Hashtable>] [-BusinessFlowTemplateId <String>]
 [-CreatedBy <IMicrosoftGraphUserIdentity>] [-Decisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-Description <String>] [-DisplayName <String>] [-EndDateTime <DateTime>] [-Id <String>]
 [-Instances <IMicrosoftGraphAccessReview[]>] [-MyDecisions <IMicrosoftGraphAccessReviewDecision[]>]
 [-ReviewedEntity <IMicrosoftGraphIdentity>] [-ReviewerType <String>]
 [-Reviewers <IMicrosoftGraphAccessReviewReviewer[]>] [-Settings <IMicrosoftGraphAccessReviewSettings>]
 [-StartDateTime <DateTime>] [-Status <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgAccessReviewInstance -AccessReviewId <String> -AccessReviewId1 <String>
 -BodyParameter <IMicrosoftGraphAccessReview> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAccessReviewInstance -InputObject <IIdentityGovernanceIdentity> [-AdditionalProperties <Hashtable>]
 [-BusinessFlowTemplateId <String>] [-CreatedBy <IMicrosoftGraphUserIdentity>]
 [-Decisions <IMicrosoftGraphAccessReviewDecision[]>] [-Description <String>] [-DisplayName <String>]
 [-EndDateTime <DateTime>] [-Id <String>] [-Instances <IMicrosoftGraphAccessReview[]>]
 [-MyDecisions <IMicrosoftGraphAccessReviewDecision[]>] [-ReviewedEntity <IMicrosoftGraphIdentity>]
 [-ReviewerType <String>] [-Reviewers <IMicrosoftGraphAccessReviewReviewer[]>]
 [-Settings <IMicrosoftGraphAccessReviewSettings>] [-StartDateTime <DateTime>] [-Status <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAccessReviewInstance -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessReview> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property instances in accessReviews

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AccessReviewId
key: id of accessReview

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessReviewId1
key: id of accessReview

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
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
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessReview
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReview
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessFlowTemplateId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
userIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Decisions
.
To construct, see NOTES section for DECISIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReviewDecision[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: DateTime
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
Type: String
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
Type: IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Instances
.
To construct, see NOTES section for INSTANCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReview[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MyDecisions
.
To construct, see NOTES section for MYDECISIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReviewDecision[]
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewedEntity
identity
To construct, see NOTES section for REVIEWEDENTITY properties and create a hash table.

```yaml
Type: IMicrosoftGraphIdentity
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reviewers
.
To construct, see NOTES section for REVIEWERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReviewReviewer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewerType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
accessReviewSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessReviewSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
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

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReview
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphAccessReview\>: accessReview
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[BusinessFlowTemplateId \<String\>\]: 
  \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[Decisions \<IMicrosoftGraphAccessReviewDecision\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessRecommendation \<String\>\]: 
    \[AccessReviewId \<String\>\]: 
    \[AppliedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[AppliedDateTime \<DateTime?\>\]: 
    \[ApplyResult \<String\>\]: 
    \[Justification \<String\>\]: 
    \[ReviewResult \<String\>\]: 
    \[ReviewedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[ReviewedDateTime \<DateTime?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[EndDateTime \<DateTime?\>\]: 
  \[Instances \<IMicrosoftGraphAccessReview\[\]\>\]: 
  \[MyDecisions \<IMicrosoftGraphAccessReviewDecision\[\]\>\]: 
  \[ReviewedEntity \<IMicrosoftGraphIdentity\>\]: identity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
  \[ReviewerType \<String\>\]: 
  \[Reviewers \<IMicrosoftGraphAccessReviewReviewer\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[Settings \<IMicrosoftGraphAccessReviewSettings\>\]: accessReviewSettings
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AccessRecommendationsEnabled \<Boolean?\>\]: 
    \[ActivityDurationInDays \<Int32?\>\]: 
    \[AutoApplyReviewResultsEnabled \<Boolean?\>\]: 
    \[AutoReviewEnabled \<Boolean?\>\]: 
    \[AutoReviewSettings \<IMicrosoftGraphAutoReviewSettings\>\]: autoReviewSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[NotReviewedResult \<String\>\]: 
    \[JustificationRequiredOnApproval \<Boolean?\>\]: 
    \[MailNotificationsEnabled \<Boolean?\>\]: 
    \[RecurrenceSettings \<IMicrosoftGraphAccessReviewRecurrenceSettings\>\]: accessReviewRecurrenceSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DurationInDays \<Int32?\>\]: 
      \[RecurrenceCount \<Int32?\>\]: 
      \[RecurrenceEndType \<String\>\]: 
      \[RecurrenceType \<String\>\]: 
    \[RemindersEnabled \<Boolean?\>\]: 
  \[StartDateTime \<DateTime?\>\]: 
  \[Status \<String\>\]: 

CREATEDBY \<IMicrosoftGraphUserIdentity\>: userIdentity
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  \[Id \<String\>\]: Unique identifier for the identity.
  \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
  \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.

DECISIONS \<IMicrosoftGraphAccessReviewDecision\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AccessRecommendation \<String\>\]: 
  \[AccessReviewId \<String\>\]: 
  \[AppliedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[AppliedDateTime \<DateTime?\>\]: 
  \[ApplyResult \<String\>\]: 
  \[Justification \<String\>\]: 
  \[ReviewResult \<String\>\]: 
  \[ReviewedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
  \[ReviewedDateTime \<DateTime?\>\]: 

INPUTOBJECT \<IIdentityGovernanceIdentity\>: Identity Parameter
  \[AccessPackageAssignmentId \<String\>\]: key: id of accessPackageAssignment
  \[AccessPackageAssignmentPolicyId \<String\>\]: key: id of accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequestId \<String\>\]: key: id of accessPackageAssignmentRequest
  \[AccessPackageAssignmentResourceRoleId \<String\>\]: key: id of accessPackageAssignmentResourceRole
  \[AccessPackageCatalogId \<String\>\]: key: id of accessPackageCatalog
  \[AccessPackageId \<String\>\]: key: id of accessPackage
  \[AccessPackageResourceId \<String\>\]: key: id of accessPackageResource
  \[AccessPackageResourceRequestId \<String\>\]: key: id of accessPackageResourceRequest
  \[AccessPackageResourceRoleId \<String\>\]: key: id of accessPackageResourceRole
  \[AccessPackageResourceRoleScopeId \<String\>\]: key: id of accessPackageResourceRoleScope
  \[AccessPackageResourceScopeId \<String\>\]: key: id of accessPackageResourceScope
  \[AccessReviewDecisionId \<String\>\]: key: id of accessReviewDecision
  \[AccessReviewId \<String\>\]: key: id of accessReview
  \[AccessReviewId1 \<String\>\]: key: id of accessReview
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AccessReviewReviewerId \<String\>\]: key: id of accessReviewReviewer
  \[AccessReviewScheduleDefinitionId \<String\>\]: key: id of accessReviewScheduleDefinition
  \[AgreementAcceptanceId \<String\>\]: key: id of agreementAcceptance
  \[AgreementFileLocalizationId \<String\>\]: key: id of agreementFileLocalization
  \[AgreementFileVersionId \<String\>\]: key: id of agreementFileVersion
  \[AgreementId \<String\>\]: key: id of agreement
  \[BusinessFlowTemplateId \<String\>\]: key: id of businessFlowTemplate
  \[ConnectedOrganizationId \<String\>\]: key: id of connectedOrganization
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[GovernanceResourceId \<String\>\]: key: id of governanceResource
  \[GovernanceRoleAssignmentId \<String\>\]: key: id of governanceRoleAssignment
  \[GovernanceRoleAssignmentRequestId \<String\>\]: key: id of governanceRoleAssignmentRequest
  \[GovernanceRoleDefinitionId \<String\>\]: key: id of governanceRoleDefinition
  \[GovernanceRoleSettingId \<String\>\]: key: id of governanceRoleSetting
  \[PrivilegedAccessId \<String\>\]: key: id of privilegedAccess
  \[PrivilegedApprovalId \<String\>\]: key: id of privilegedApproval
  \[PrivilegedOperationEventId \<String\>\]: key: id of privilegedOperationEvent
  \[PrivilegedRoleAssignmentId \<String\>\]: key: id of privilegedRoleAssignment
  \[PrivilegedRoleAssignmentRequestId \<String\>\]: key: id of privilegedRoleAssignmentRequest
  \[PrivilegedRoleId \<String\>\]: key: id of privilegedRole
  \[ProgramControlId \<String\>\]: key: id of programControl
  \[ProgramControlTypeId \<String\>\]: key: id of programControlType
  \[ProgramId \<String\>\]: key: id of program
  \[UserId \<String\>\]: key: id of user

INSTANCES \<IMicrosoftGraphAccessReview\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[BusinessFlowTemplateId \<String\>\]: 
  \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[Decisions \<IMicrosoftGraphAccessReviewDecision\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessRecommendation \<String\>\]: 
    \[AccessReviewId \<String\>\]: 
    \[AppliedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[AppliedDateTime \<DateTime?\>\]: 
    \[ApplyResult \<String\>\]: 
    \[Justification \<String\>\]: 
    \[ReviewResult \<String\>\]: 
    \[ReviewedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[ReviewedDateTime \<DateTime?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[EndDateTime \<DateTime?\>\]: 
  \[Instances \<IMicrosoftGraphAccessReview\[\]\>\]: 
  \[MyDecisions \<IMicrosoftGraphAccessReviewDecision\[\]\>\]: 
  \[ReviewedEntity \<IMicrosoftGraphIdentity\>\]: identity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
  \[ReviewerType \<String\>\]: 
  \[Reviewers \<IMicrosoftGraphAccessReviewReviewer\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[Settings \<IMicrosoftGraphAccessReviewSettings\>\]: accessReviewSettings
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AccessRecommendationsEnabled \<Boolean?\>\]: 
    \[ActivityDurationInDays \<Int32?\>\]: 
    \[AutoApplyReviewResultsEnabled \<Boolean?\>\]: 
    \[AutoReviewEnabled \<Boolean?\>\]: 
    \[AutoReviewSettings \<IMicrosoftGraphAutoReviewSettings\>\]: autoReviewSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[NotReviewedResult \<String\>\]: 
    \[JustificationRequiredOnApproval \<Boolean?\>\]: 
    \[MailNotificationsEnabled \<Boolean?\>\]: 
    \[RecurrenceSettings \<IMicrosoftGraphAccessReviewRecurrenceSettings\>\]: accessReviewRecurrenceSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DurationInDays \<Int32?\>\]: 
      \[RecurrenceCount \<Int32?\>\]: 
      \[RecurrenceEndType \<String\>\]: 
      \[RecurrenceType \<String\>\]: 
    \[RemindersEnabled \<Boolean?\>\]: 
  \[StartDateTime \<DateTime?\>\]: 
  \[Status \<String\>\]: 

MYDECISIONS \<IMicrosoftGraphAccessReviewDecision\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AccessRecommendation \<String\>\]: 
  \[AccessReviewId \<String\>\]: 
  \[AppliedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[AppliedDateTime \<DateTime?\>\]: 
  \[ApplyResult \<String\>\]: 
  \[Justification \<String\>\]: 
  \[ReviewResult \<String\>\]: 
  \[ReviewedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
  \[ReviewedDateTime \<DateTime?\>\]: 

REVIEWEDENTITY \<IMicrosoftGraphIdentity\>: identity
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  \[Id \<String\>\]: Unique identifier for the identity.

REVIEWERS \<IMicrosoftGraphAccessReviewReviewer\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: 
  \[UserPrincipalName \<String\>\]: 

SETTINGS \<IMicrosoftGraphAccessReviewSettings\>: accessReviewSettings
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AccessRecommendationsEnabled \<Boolean?\>\]: 
  \[ActivityDurationInDays \<Int32?\>\]: 
  \[AutoApplyReviewResultsEnabled \<Boolean?\>\]: 
  \[AutoReviewEnabled \<Boolean?\>\]: 
  \[AutoReviewSettings \<IMicrosoftGraphAutoReviewSettings\>\]: autoReviewSettings
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[NotReviewedResult \<String\>\]: 
  \[JustificationRequiredOnApproval \<Boolean?\>\]: 
  \[MailNotificationsEnabled \<Boolean?\>\]: 
  \[RecurrenceSettings \<IMicrosoftGraphAccessReviewRecurrenceSettings\>\]: accessReviewRecurrenceSettings
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DurationInDays \<Int32?\>\]: 
    \[RecurrenceCount \<Int32?\>\]: 
    \[RecurrenceEndType \<String\>\]: 
    \[RecurrenceType \<String\>\]: 
  \[RemindersEnabled \<Boolean?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgaccessreviewinstance](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgaccessreviewinstance)

