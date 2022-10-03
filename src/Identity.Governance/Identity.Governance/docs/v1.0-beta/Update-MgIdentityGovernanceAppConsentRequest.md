---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgidentitygovernanceappconsentrequest
schema: 2.0.0
---

# Update-MgIdentityGovernanceAppConsentRequest

## SYNOPSIS
Update the navigation property appConsentRequests in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId <String> [-AdditionalProperties <Hashtable>]
 [-AppDisplayName <String>] [-AppId <String>] [-ConsentType <String>] [-Id <String>]
 [-PendingScopes <IMicrosoftGraphAppConsentRequestScope[]>]
 [-UserConsentRequests <IMicrosoftGraphUserConsentRequest1[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId <String>
 -BodyParameter <IMicrosoftGraphAppConsentRequest1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgIdentityGovernanceAppConsentRequest -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAppConsentRequest1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgIdentityGovernanceAppConsentRequest -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-AppDisplayName <String>] [-AppId <String>] [-ConsentType <String>]
 [-Id <String>] [-PendingScopes <IMicrosoftGraphAppConsentRequestScope[]>]
 [-UserConsentRequests <IMicrosoftGraphUserConsentRequest1[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property appConsentRequests in identityGovernance

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

### -AppConsentRequestId
key: id of appConsentRequest

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

### -AppDisplayName
The display name of the app for which consent is requested.
Required.
Supports $filter (eq only) and $orderby.

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

### -AppId
The identifier of the application.
Required.
Supports $filter (eq only) and $orderby.

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
appConsentRequest
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppConsentRequest1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConsentType
The consent type of the request.
Possible values are: Static and Dynamic.
These represent static and dynamic permissions, respectively, requested in the consent workflow.
Supports $filter (eq only) and $orderby.
Required.

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

### -Id
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

### -PendingScopes
A list of pending scopes waiting for approval.
This is empty if the consentType is Static.
Required.
To construct, please use Get-Help -Online and see NOTES section for PENDINGSCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppConsentRequestScope[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserConsentRequests
A list of pending user consent requests.
Supports $filter (eq).
To construct, please use Get-Help -Online and see NOTES section for USERCONSENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserConsentRequest1[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppConsentRequest1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAppConsentRequest1>: appConsentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppDisplayName <String>]`: The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.
  - `[AppId <String>]`: The identifier of the application. Required. Supports $filter (eq only) and $orderby.
  - `[ConsentType <String>]`: The consent type of the request. Possible values are: Static and Dynamic. These represent static and dynamic permissions, respectively, requested in the consent workflow. Supports $filter (eq only) and $orderby. Required.
  - `[PendingScopes <IMicrosoftGraphAppConsentRequestScope[]>]`: A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.
    - `[DisplayName <String>]`: The name of the scope.
  - `[UserConsentRequests <IMicrosoftGraphUserConsentRequest1[]>]`: A list of pending user consent requests. Supports $filter (eq).
    - `[ApprovalId <String>]`: The identifier of the approval of the request.
    - `[CompletedDateTime <DateTime?>]`: The request completion date time.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: The request creation date time.
    - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
    - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
    - `[Id <String>]`: 
    - `[Approval <IMicrosoftGraphApproval1>]`: approval
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Steps <IMicrosoftGraphApprovalStep[]>]`: 
        - `[Id <String>]`: 
        - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
        - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
        - `[Justification <String>]`: The justification associated with the approval step decision.
        - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
        - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
        - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
    - `[Reason <String>]`: The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.

INPUTOBJECT <IIdentityGovernanceIdentity>: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: key: id of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: key: id of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: key: id of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: key: id of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: key: id of accessPackageCatalog
  - `[AccessPackageId <String>]`: key: id of accessPackage
  - `[AccessPackageId1 <String>]`: key: id of accessPackage
  - `[AccessPackageId2 <String>]`: Usage: accessPackageId='{accessPackageId}'
  - `[AccessPackageResourceEnvironmentId <String>]`: key: id of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: key: id of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: key: id of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: key: id of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: key: id of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: key: id of accessPackageResourceScope
  - `[AccessPackageSubjectId <String>]`: key: id of accessPackageSubject
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
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
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
  - `[CustomAccessPackageWorkflowExtensionId <String>]`: key: id of customAccessPackageWorkflowExtension
  - `[CustomExtensionHandlerId <String>]`: key: id of customExtensionHandler
  - `[CustomTaskExtensionId <String>]`: key: id of customTaskExtension
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime={endDateTime}
  - `[GovernanceInsightId <String>]`: key: id of governanceInsight
  - `[GovernanceResourceId <String>]`: key: id of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: key: id of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: key: id of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: key: id of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: key: id of governanceRoleSetting
  - `[GroupId <String>]`: key: id of group
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[On <String>]`: Usage: on='{on}'
  - `[PrivilegedAccessId <String>]`: key: id of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: key: id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentId1 <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: id of privilegedRole
  - `[ProgramControlId <String>]`: key: id of programControl
  - `[ProgramControlId1 <String>]`: key: id of programControl
  - `[ProgramControlTypeId <String>]`: key: id of programControlType
  - `[ProgramId <String>]`: key: id of program
  - `[RunId <String>]`: key: id of run
  - `[StartDateTime <DateTime?>]`: Usage: startDateTime={startDateTime}
  - `[TaskDefinitionId <String>]`: key: id of taskDefinition
  - `[TaskId <String>]`: key: id of task
  - `[TaskProcessingResultId <String>]`: key: id of taskProcessingResult
  - `[TaskReportId <String>]`: key: id of taskReport
  - `[UserConsentRequestId <String>]`: key: id of userConsentRequest
  - `[UserId <String>]`: key: id of user
  - `[UserProcessingResultId <String>]`: key: id of userProcessingResult
  - `[WorkflowId <String>]`: key: id of workflow
  - `[WorkflowTemplateId <String>]`: key: id of workflowTemplate
  - `[WorkflowVersionNumber <Int32?>]`: key: versionNumber of workflowVersion

PENDINGSCOPES <IMicrosoftGraphAppConsentRequestScope[]>: A list of pending scopes waiting for approval. This is empty if the consentType is Static. Required.
  - `[DisplayName <String>]`: The name of the scope.

USERCONSENTREQUESTS <IMicrosoftGraphUserConsentRequest1[]>: A list of pending user consent requests. Supports $filter (eq).
  - `[ApprovalId <String>]`: The identifier of the approval of the request.
  - `[CompletedDateTime <DateTime?>]`: The request completion date time.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The request creation date time.
  - `[CustomData <String>]`: Free text field to define any custom data for the request. Not used.
  - `[Status <String>]`: The status of the request. Not nullable. The possible values are: Canceled, Denied, Failed, Granted, PendingAdminDecision, PendingApproval, PendingProvisioning, PendingScheduleCreation, Provisioned, Revoked, and ScheduleCreated. Not nullable.
  - `[Id <String>]`: 
  - `[Approval <IMicrosoftGraphApproval1>]`: approval
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Steps <IMicrosoftGraphApprovalStep[]>]`: 
      - `[Id <String>]`: 
      - `[AssignedToMe <Boolean?>]`: Indicates whether the step is assigned to the calling user to review. Read-only.
      - `[DisplayName <String>]`: The label provided by the policy creator to identify an approval step. Read-only.
      - `[Justification <String>]`: The justification associated with the approval step decision.
      - `[ReviewResult <String>]`: The result of this approval record. Possible values include: NotReviewed, Approved, Denied.
      - `[ReviewedBy <IMicrosoftGraphIdentity>]`: identity
      - `[ReviewedDateTime <DateTime?>]`: The date and time when a decision was recorded. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Status <String>]`: The step status. Possible values: InProgress, Initializing, Completed, Expired. Read-only.
  - `[Reason <String>]`: The user's justification for requiring access to the app. Supports $filter (eq only) and $orderby.

## RELATED LINKS

