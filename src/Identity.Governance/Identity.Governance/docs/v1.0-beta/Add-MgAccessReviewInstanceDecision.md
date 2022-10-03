---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/add-mgaccessreviewinstancedecision
schema: 2.0.0
---

# Add-MgAccessReviewInstanceDecision

## SYNOPSIS
In the Azure AD access reviews feature, apply the decisions of a completed accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
 After an access review is finished, either because it reached the end date or an administrator stopped it manually, and auto-apply wasn't configured for the review, you can call Apply to apply the changes.
Until apply occurs, the decisions to remove access rights do not appear on the source resource, the users for instance retain their group memberships.
By calling apply, the outcome of the review is implemented by updating the group or application.
If a user's access was denied in the review, when an administrator calls this API, Azure AD removes their membership or application assignment.
After an access review is finished, and auto-apply was configured, then the status of the review will change from Completed through intermediate states and finally will change to state Applied.
You should expect to see denied users, if any, being removed from the resource group membership or app assignment in a few minutes.
A configured auto applying review, or selecting Apply doesn't have an effect on a group that originates in an on-premises directory or a dynamic group.
If you want to change a group that originates on-premises, download the results and apply those changes to the representation of the group in that directory.

## SYNTAX

### Apply (Default)
```
Add-MgAccessReviewInstanceDecision -AccessReviewId <String> -AccessReviewId1 <String> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ApplyViaIdentity
```
Add-MgAccessReviewInstanceDecision -InputObject <IIdentityGovernanceIdentity> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
In the Azure AD access reviews feature, apply the decisions of a completed accessReview.
The target object can be either a one-time access review, or an instance of a recurring access review.
 After an access review is finished, either because it reached the end date or an administrator stopped it manually, and auto-apply wasn't configured for the review, you can call Apply to apply the changes.
Until apply occurs, the decisions to remove access rights do not appear on the source resource, the users for instance retain their group memberships.
By calling apply, the outcome of the review is implemented by updating the group or application.
If a user's access was denied in the review, when an administrator calls this API, Azure AD removes their membership or application assignment.
After an access review is finished, and auto-apply was configured, then the status of the review will change from Completed through intermediate states and finally will change to state Applied.
You should expect to see denied users, if any, being removed from the resource group membership or app assignment in a few minutes.
A configured auto applying review, or selecting Apply doesn't have an effect on a group that originates in an on-premises directory or a dynamic group.
If you want to change a group that originates on-premises, download the results and apply those changes to the representation of the group in that directory.

## EXAMPLES

## PARAMETERS

### -AccessReviewId
key: id of accessReview

```yaml
Type: System.String
Parameter Sets: Apply
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
Type: System.String
Parameter Sets: Apply
Aliases:

Required: True
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
Parameter Sets: ApplyViaIdentity
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

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

## RELATED LINKS

