---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance/resume-mgidentitygovernancelifecycleworkflowtaskprocessingresult
schema: 2.0.0
---

# Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult

## SYNOPSIS
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

## SYNTAX

### ResumeExpanded (Default)
```
Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult -TaskId <String>
 -TaskProcessingResultId <String> -WorkflowId <String> [-AdditionalProperties <Hashtable>]
 [-Data <IMicrosoftGraphIdentityGovernanceCustomTaskExtensionCallbackData>]
 [-ResponseHeadersVariable <String>] [-Source <String>] [-Type <String>] [-Headers <IDictionary>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Resume
```
Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult -TaskId <String>
 -TaskProcessingResultId <String> -WorkflowId <String>
 -BodyParameter <IPathsO6Ec5IIdentitygovernanceLifecycleworkflowsWorkflowsWorkflowIdTasksTaskIdTaskprocessingresultsTaskprocessingresultIdMicrosoftGraphIdentitygovernanceResumePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ResumeViaIdentity
```
Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IPathsO6Ec5IIdentitygovernanceLifecycleworkflowsWorkflowsWorkflowIdTasksTaskIdTaskprocessingresultsTaskprocessingresultIdMicrosoftGraphIdentitygovernanceResumePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ResumeViaIdentityExpanded
```
Resume-MgIdentityGovernanceLifecycleWorkflowTaskProcessingResult -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>]
 [-Data <IMicrosoftGraphIdentityGovernanceCustomTaskExtensionCallbackData>]
 [-ResponseHeadersVariable <String>] [-Source <String>] [-Type <String>] [-Headers <IDictionary>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Resume a task processing result that's inProgress.
In the default case an Azure Logic Apps system-assigned managed identity calls this API.
For more information, see: Lifecycle Workflows extensibility approach.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ResumeExpanded, ResumeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsO6Ec5IIdentitygovernanceLifecycleworkflowsWorkflowsWorkflowIdTasksTaskIdTaskprocessingresultsTaskprocessingresultIdMicrosoftGraphIdentitygovernanceResumePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Resume, ResumeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Data
customTaskExtensionCallbackData
To construct, see NOTES section for DATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityGovernanceCustomTaskExtensionCallbackData
Parameter Sets: ResumeExpanded, ResumeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: ResumeViaIdentity, ResumeViaIdentityExpanded
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
.

```yaml
Type: System.String
Parameter Sets: ResumeExpanded, ResumeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskId
The unique identifier of task

```yaml
Type: System.String
Parameter Sets: Resume, ResumeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskProcessingResultId
The unique identifier of taskProcessingResult

```yaml
Type: System.String
Parameter Sets: Resume, ResumeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
.

```yaml
Type: System.String
Parameter Sets: ResumeExpanded, ResumeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkflowId
The unique identifier of workflow

```yaml
Type: System.String
Parameter Sets: Resume, ResumeExpanded
Aliases:

Required: True
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

### Microsoft.Graph.PowerShell.Models.IPathsO6Ec5IIdentitygovernanceLifecycleworkflowsWorkflowsWorkflowIdTasksTaskIdTaskprocessingresultsTaskprocessingresultIdMicrosoftGraphIdentitygovernanceResumePostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsO6Ec5IIdentitygovernanceLifecycleworkflowsWorkflowsWorkflowIdTasksTaskIdTaskprocessingresultsTaskprocessingresultIdMicrosoftGraphIdentitygovernanceResumePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Data <IMicrosoftGraphIdentityGovernanceCustomTaskExtensionCallbackData>]`: customTaskExtensionCallbackData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[OperationStatus <String>]`: customTaskExtensionOperationStatus
  - `[Source <String>]`: 
  - `[Type <String>]`: 

`DATA <IMicrosoftGraphIdentityGovernanceCustomTaskExtensionCallbackData>`: customTaskExtensionCallbackData
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OperationStatus <String>]`: customTaskExtensionOperationStatus

`INPUTOBJECT <IIdentityGovernanceIdentity>`: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: The unique identifier of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: The unique identifier of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: The unique identifier of accessPackageAssignmentRequest
  - `[AccessPackageCatalogId <String>]`: The unique identifier of accessPackageCatalog
  - `[AccessPackageId <String>]`: The unique identifier of accessPackage
  - `[AccessPackageId1 <String>]`: The unique identifier of accessPackage
  - `[AccessPackageQuestionId <String>]`: The unique identifier of accessPackageQuestion
  - `[AccessPackageResourceEnvironmentId <String>]`: The unique identifier of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: The unique identifier of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: The unique identifier of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: The unique identifier of accessPackageResourceRole
  - `[AccessPackageResourceRoleId1 <String>]`: The unique identifier of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: The unique identifier of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: The unique identifier of accessPackageResourceScope
  - `[AccessPackageResourceScopeId1 <String>]`: The unique identifier of accessPackageResourceScope
  - `[AccessReviewHistoryDefinitionId <String>]`: The unique identifier of accessReviewHistoryDefinition
  - `[AccessReviewHistoryInstanceId <String>]`: The unique identifier of accessReviewHistoryInstance
  - `[AccessReviewInstanceDecisionItemId <String>]`: The unique identifier of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AccessReviewReviewerId <String>]`: The unique identifier of accessReviewReviewer
  - `[AccessReviewScheduleDefinitionId <String>]`: The unique identifier of accessReviewScheduleDefinition
  - `[AccessReviewStageId <String>]`: The unique identifier of accessReviewStage
  - `[AgreementAcceptanceId <String>]`: The unique identifier of agreementAcceptance
  - `[AgreementFileLocalizationId <String>]`: The unique identifier of agreementFileLocalization
  - `[AgreementFileVersionId <String>]`: The unique identifier of agreementFileVersion
  - `[AgreementId <String>]`: The unique identifier of agreement
  - `[AppConsentRequestId <String>]`: The unique identifier of appConsentRequest
  - `[ApprovalId <String>]`: The unique identifier of approval
  - `[ApprovalStageId <String>]`: The unique identifier of approvalStage
  - `[ConnectedOrganizationId <String>]`: The unique identifier of connectedOrganization
  - `[CustomCalloutExtensionId <String>]`: The unique identifier of customCalloutExtension
  - `[CustomExtensionStageSettingId <String>]`: The unique identifier of customExtensionStageSetting
  - `[CustomTaskExtensionId <String>]`: The unique identifier of customTaskExtension
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime={endDateTime}
  - `[GovernanceInsightId <String>]`: The unique identifier of governanceInsight
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[On <String>]`: Usage: on='{on}'
  - `[PrivilegedAccessGroupAssignmentScheduleId <String>]`: The unique identifier of privilegedAccessGroupAssignmentSchedule
  - `[PrivilegedAccessGroupAssignmentScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleInstance
  - `[PrivilegedAccessGroupAssignmentScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleRequest
  - `[PrivilegedAccessGroupEligibilityScheduleId <String>]`: The unique identifier of privilegedAccessGroupEligibilitySchedule
  - `[PrivilegedAccessGroupEligibilityScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleInstance
  - `[PrivilegedAccessGroupEligibilityScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleRequest
  - `[RunId <String>]`: The unique identifier of run
  - `[StartDateTime <DateTime?>]`: Usage: startDateTime={startDateTime}
  - `[TaskDefinitionId <String>]`: The unique identifier of taskDefinition
  - `[TaskId <String>]`: The unique identifier of task
  - `[TaskProcessingResultId <String>]`: The unique identifier of taskProcessingResult
  - `[TaskReportId <String>]`: The unique identifier of taskReport
  - `[UnifiedRbacResourceActionId <String>]`: The unique identifier of unifiedRbacResourceAction
  - `[UnifiedRbacResourceNamespaceId <String>]`: The unique identifier of unifiedRbacResourceNamespace
  - `[UnifiedRoleAssignmentId <String>]`: The unique identifier of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentScheduleId <String>]`: The unique identifier of unifiedRoleAssignmentSchedule
  - `[UnifiedRoleAssignmentScheduleInstanceId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleInstance
  - `[UnifiedRoleAssignmentScheduleRequestId <String>]`: The unique identifier of unifiedRoleAssignmentScheduleRequest
  - `[UnifiedRoleDefinitionId <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleDefinitionId1 <String>]`: The unique identifier of unifiedRoleDefinition
  - `[UnifiedRoleEligibilityScheduleId <String>]`: The unique identifier of unifiedRoleEligibilitySchedule
  - `[UnifiedRoleEligibilityScheduleInstanceId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleInstance
  - `[UnifiedRoleEligibilityScheduleRequestId <String>]`: The unique identifier of unifiedRoleEligibilityScheduleRequest
  - `[UserConsentRequestId <String>]`: The unique identifier of userConsentRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserProcessingResultId <String>]`: The unique identifier of userProcessingResult
  - `[WorkflowId <String>]`: The unique identifier of workflow
  - `[WorkflowTemplateId <String>]`: The unique identifier of workflowTemplate
  - `[WorkflowVersionNumber <Int32?>]`: The unique identifier of workflowVersion

## RELATED LINKS

