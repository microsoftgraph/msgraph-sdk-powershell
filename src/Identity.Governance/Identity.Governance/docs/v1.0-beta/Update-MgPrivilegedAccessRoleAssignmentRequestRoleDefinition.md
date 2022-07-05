---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedaccessroleassignmentrequestroledefinition
schema: 2.0.0
---

# Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition

## SYNOPSIS
Update the navigation property roleDefinition in privilegedAccess

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition -GovernanceRoleAssignmentRequestId <String>
 -PrivilegedAccessId <String> [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-ExternalId <String>] [-Id <String>] [-Resource <IMicrosoftGraphGovernanceResource>] [-ResourceId <String>]
 [-RoleSetting <IMicrosoftGraphGovernanceRoleSetting>] [-TemplateId <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition -GovernanceRoleAssignmentRequestId <String>
 -PrivilegedAccessId <String> -BodyParameter <IMicrosoftGraphGovernanceRoleDefinition> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphGovernanceRoleDefinition> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedAccessRoleAssignmentRequestRoleDefinition -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-ExternalId <String>] [-Id <String>]
 [-Resource <IMicrosoftGraphGovernanceResource>] [-ResourceId <String>]
 [-RoleSetting <IMicrosoftGraphGovernanceRoleSetting>] [-TemplateId <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property roleDefinition in privilegedAccess

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
governanceRoleDefinition
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleDefinition
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the role definition.

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

### -ExternalId
The external id of the role definition.

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

### -GovernanceRoleAssignmentRequestId
key: id of governanceRoleAssignmentRequest

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

### -PrivilegedAccessId
key: id of privilegedAccess

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

### -Resource
governanceResource
To construct, please use Get-Help -Online and see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceResource
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
Required.
The id of the resource associated with the role definition.

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

### -RoleSetting
governanceRoleSetting
To construct, please use Get-Help -Online and see NOTES section for ROLESETTING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleSetting
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateId
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphGovernanceRoleDefinition

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphGovernanceRoleDefinition>: governanceRoleDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The display name of the role definition.
  - `[ExternalId <String>]`: The external id of the role definition.
  - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The display name of the resource.
    - `[ExternalId <String>]`: The external id of the resource, representing its original id in the external system. For example, a subscription resource's external id can be '/subscriptions/c14ae696-5e0c-4e5d-88cc-bef6637737ac'.
    - `[Parent <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[RegisteredDateTime <DateTime?>]`: Represents the date time when the resource is registered in PIM.
    - `[RegisteredRoot <String>]`: The externalId of the resource's root scope that is registered in PIM. The root scope can be the parent, grandparent, or higher ancestor resources.
    - `[RoleAssignmentRequests <IMicrosoftGraphGovernanceRoleAssignmentRequest[]>]`: The collection of role assignment requests for the resource.
      - `[Id <String>]`: 
      - `[AssignmentState <String>]`: Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).
      - `[LinkedEligibleRoleAssignmentId <String>]`: If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.
      - `[Reason <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[RequestedDateTime <DateTime?>]`: Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.
      - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
      - `[RoleDefinitionId <String>]`: Required. The identifier of the Azure role definition that the role assignment request is associated with.
      - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Duration <TimeSpan?>]`: The duration of a role assignment. It is in format of a TimeSpan.
        - `[EndDateTime <DateTime?>]`: The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Note: if the value is null, it indicates a permanent assignment.
        - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Type <String>]`: The role assignment schedule type. Only Once is supported for now.
      - `[Status <IMicrosoftGraphGovernanceRoleAssignmentRequestStatus>]`: governanceRoleAssignmentRequestStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Status <String>]`: The status of the role assignment request. The value can be InProgress or Closed.
        - `[StatusDetails <IMicrosoftGraphKeyValue[]>]`: The details of the status of the role assignment request. It represents the evaluation results of different rules.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[SubStatus <String>]`: The sub status of the role assignment request. The values can be Accepted, PendingEvaluation, Granted, Denied, PendingProvisioning, Provisioned, PendingRevocation, Revoked, Canceled, Failed, PendingApprovalProvisioning, PendingApproval, FailedAsResourceIsLocked, PendingAdminDecision, AdminApproved, AdminDenied, TimedOut, and ProvisioningStarted.
      - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[DisplayName <String>]`: The display name of the subject.
        - `[Email <String>]`: The email address of the user subject. If the subject is in other types, it is empty.
        - `[PrincipalName <String>]`: The principal name of the user subject. If the subject is in other types, it is empty.
        - `[Type <String>]`: The type of the subject. The value can be User, Group, and ServicePrincipal.
      - `[SubjectId <String>]`: Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.
      - `[Type <String>]`: Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.
    - `[RoleAssignments <IMicrosoftGraphGovernanceRoleAssignment[]>]`: The collection of role assignments for the resource.
      - `[Id <String>]`: 
      - `[AssignmentState <String>]`: The state of the assignment. The value can be Eligible for eligible assignment or Active if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.
      - `[EndDateTime <DateTime?>]`: For a non-permanent role assignment, this is the time when the role assignment will be expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ExternalId <String>]`: The external ID the resource that is used to identify the role assignment in the provider.
      - `[LinkedEligibleRoleAssignment <IMicrosoftGraphGovernanceRoleAssignment>]`: governanceRoleAssignment
      - `[LinkedEligibleRoleAssignmentId <String>]`: If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.
      - `[MemberType <String>]`: The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment is not inherited, but comes from the membership of a group assignment), or User (if the role assignment is neither inherited nor from a group assignment).
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The ID of the resource which the role assignment is associated with.
      - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
      - `[RoleDefinitionId <String>]`: Required. The ID of the role definition which the role assignment is associated with.
      - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Status <String>]`: 
      - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
      - `[SubjectId <String>]`: Required. The ID of the subject which the role assignment is associated with.
    - `[RoleDefinitions <IMicrosoftGraphGovernanceRoleDefinition[]>]`: The collection of role defintions for the resource.
    - `[RoleSettings <IMicrosoftGraphGovernanceRoleSetting[]>]`: The collection of role settings for the resource.
      - `[Id <String>]`: 
      - `[AdminEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add an eligible role assignment.
        - `[RuleIdentifier <String>]`: The id of the rule. For example, ExpirationRule and MfaRule.
        - `[Setting <String>]`: The settings of the rule. The value is a JSON string with a list of pairs in the format of Parameter_Name:Parameter_Value. For example, {'permanentAssignment':false,'maximumGrantPeriodInMinutes':129600}
      - `[AdminMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add a direct member role assignment.
      - `[IsDefault <Boolean?>]`: Read-only. Indicate if the roleSetting is a default roleSetting
      - `[LastUpdatedBy <String>]`: Read-only. The display name of the administrator who last updated the roleSetting.
      - `[LastUpdatedDateTime <DateTime?>]`: Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The id of the resource that the role setting is associated with.
      - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
      - `[RoleDefinitionId <String>]`: Required. The id of the role definition that the role setting is associated with.
      - `[UserEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.
      - `[UserMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to activate his role assignment.
    - `[Status <String>]`: The status of a given resource. For example, it could represent whether the resource is locked or not (values: Active/Locked). Note: This property may be extended in the future to support more scenarios.
    - `[Type <String>]`: Required. Resource type. For example, for Azure resources, the type could be 'Subscription', 'ResourceGroup', 'Microsoft.Sql/server', etc.
  - `[ResourceId <String>]`: Required. The id of the resource associated with the role definition.
  - `[RoleSetting <IMicrosoftGraphGovernanceRoleSetting>]`: governanceRoleSetting
  - `[TemplateId <String>]`: 

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
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
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
  - `[UserConsentRequestId <String>]`: key: id of userConsentRequest
  - `[UserId <String>]`: key: id of user

RESOURCE <IMicrosoftGraphGovernanceResource>: governanceResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The display name of the resource.
  - `[ExternalId <String>]`: The external id of the resource, representing its original id in the external system. For example, a subscription resource's external id can be '/subscriptions/c14ae696-5e0c-4e5d-88cc-bef6637737ac'.
  - `[Parent <IMicrosoftGraphGovernanceResource>]`: governanceResource
  - `[RegisteredDateTime <DateTime?>]`: Represents the date time when the resource is registered in PIM.
  - `[RegisteredRoot <String>]`: The externalId of the resource's root scope that is registered in PIM. The root scope can be the parent, grandparent, or higher ancestor resources.
  - `[RoleAssignmentRequests <IMicrosoftGraphGovernanceRoleAssignmentRequest[]>]`: The collection of role assignment requests for the resource.
    - `[Id <String>]`: 
    - `[AssignmentState <String>]`: Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).
    - `[LinkedEligibleRoleAssignmentId <String>]`: If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.
    - `[Reason <String>]`: A message provided by users and administrators when create the request about why it is needed.
    - `[RequestedDateTime <DateTime?>]`: Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[ResourceId <String>]`: Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.
    - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: The display name of the role definition.
      - `[ExternalId <String>]`: The external id of the role definition.
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The id of the resource associated with the role definition.
      - `[RoleSetting <IMicrosoftGraphGovernanceRoleSetting>]`: governanceRoleSetting
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[AdminEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add an eligible role assignment.
          - `[RuleIdentifier <String>]`: The id of the rule. For example, ExpirationRule and MfaRule.
          - `[Setting <String>]`: The settings of the rule. The value is a JSON string with a list of pairs in the format of Parameter_Name:Parameter_Value. For example, {'permanentAssignment':false,'maximumGrantPeriodInMinutes':129600}
        - `[AdminMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add a direct member role assignment.
        - `[IsDefault <Boolean?>]`: Read-only. Indicate if the roleSetting is a default roleSetting
        - `[LastUpdatedBy <String>]`: Read-only. The display name of the administrator who last updated the roleSetting.
        - `[LastUpdatedDateTime <DateTime?>]`: Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
        - `[ResourceId <String>]`: Required. The id of the resource that the role setting is associated with.
        - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
        - `[RoleDefinitionId <String>]`: Required. The id of the role definition that the role setting is associated with.
        - `[UserEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.
        - `[UserMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to activate his role assignment.
      - `[TemplateId <String>]`: 
    - `[RoleDefinitionId <String>]`: Required. The identifier of the Azure role definition that the role assignment request is associated with.
    - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Duration <TimeSpan?>]`: The duration of a role assignment. It is in format of a TimeSpan.
      - `[EndDateTime <DateTime?>]`: The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Note: if the value is null, it indicates a permanent assignment.
      - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Type <String>]`: The role assignment schedule type. Only Once is supported for now.
    - `[Status <IMicrosoftGraphGovernanceRoleAssignmentRequestStatus>]`: governanceRoleAssignmentRequestStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Status <String>]`: The status of the role assignment request. The value can be InProgress or Closed.
      - `[StatusDetails <IMicrosoftGraphKeyValue[]>]`: The details of the status of the role assignment request. It represents the evaluation results of different rules.
        - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
        - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
      - `[SubStatus <String>]`: The sub status of the role assignment request. The values can be Accepted, PendingEvaluation, Granted, Denied, PendingProvisioning, Provisioned, PendingRevocation, Revoked, Canceled, Failed, PendingApprovalProvisioning, PendingApproval, FailedAsResourceIsLocked, PendingAdminDecision, AdminApproved, AdminDenied, TimedOut, and ProvisioningStarted.
    - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DisplayName <String>]`: The display name of the subject.
      - `[Email <String>]`: The email address of the user subject. If the subject is in other types, it is empty.
      - `[PrincipalName <String>]`: The principal name of the user subject. If the subject is in other types, it is empty.
      - `[Type <String>]`: The type of the subject. The value can be User, Group, and ServicePrincipal.
    - `[SubjectId <String>]`: Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.
    - `[Type <String>]`: Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.
  - `[RoleAssignments <IMicrosoftGraphGovernanceRoleAssignment[]>]`: The collection of role assignments for the resource.
    - `[Id <String>]`: 
    - `[AssignmentState <String>]`: The state of the assignment. The value can be Eligible for eligible assignment or Active if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.
    - `[EndDateTime <DateTime?>]`: For a non-permanent role assignment, this is the time when the role assignment will be expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[ExternalId <String>]`: The external ID the resource that is used to identify the role assignment in the provider.
    - `[LinkedEligibleRoleAssignment <IMicrosoftGraphGovernanceRoleAssignment>]`: governanceRoleAssignment
    - `[LinkedEligibleRoleAssignmentId <String>]`: If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.
    - `[MemberType <String>]`: The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment is not inherited, but comes from the membership of a group assignment), or User (if the role assignment is neither inherited nor from a group assignment).
    - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[ResourceId <String>]`: Required. The ID of the resource which the role assignment is associated with.
    - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
    - `[RoleDefinitionId <String>]`: Required. The ID of the role definition which the role assignment is associated with.
    - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Status <String>]`: 
    - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
    - `[SubjectId <String>]`: Required. The ID of the subject which the role assignment is associated with.
  - `[RoleDefinitions <IMicrosoftGraphGovernanceRoleDefinition[]>]`: The collection of role defintions for the resource.
  - `[RoleSettings <IMicrosoftGraphGovernanceRoleSetting[]>]`: The collection of role settings for the resource.
  - `[Status <String>]`: The status of a given resource. For example, it could represent whether the resource is locked or not (values: Active/Locked). Note: This property may be extended in the future to support more scenarios.
  - `[Type <String>]`: Required. Resource type. For example, for Azure resources, the type could be 'Subscription', 'ResourceGroup', 'Microsoft.Sql/server', etc.

ROLESETTING <IMicrosoftGraphGovernanceRoleSetting>: governanceRoleSetting
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AdminEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add an eligible role assignment.
    - `[RuleIdentifier <String>]`: The id of the rule. For example, ExpirationRule and MfaRule.
    - `[Setting <String>]`: The settings of the rule. The value is a JSON string with a list of pairs in the format of Parameter_Name:Parameter_Value. For example, {'permanentAssignment':false,'maximumGrantPeriodInMinutes':129600}
  - `[AdminMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when an administrator tries to add a direct member role assignment.
  - `[IsDefault <Boolean?>]`: Read-only. Indicate if the roleSetting is a default roleSetting
  - `[LastUpdatedBy <String>]`: Read-only. The display name of the administrator who last updated the roleSetting.
  - `[LastUpdatedDateTime <DateTime?>]`: Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The display name of the resource.
    - `[ExternalId <String>]`: The external id of the resource, representing its original id in the external system. For example, a subscription resource's external id can be '/subscriptions/c14ae696-5e0c-4e5d-88cc-bef6637737ac'.
    - `[Parent <IMicrosoftGraphGovernanceResource>]`: governanceResource
    - `[RegisteredDateTime <DateTime?>]`: Represents the date time when the resource is registered in PIM.
    - `[RegisteredRoot <String>]`: The externalId of the resource's root scope that is registered in PIM. The root scope can be the parent, grandparent, or higher ancestor resources.
    - `[RoleAssignmentRequests <IMicrosoftGraphGovernanceRoleAssignmentRequest[]>]`: The collection of role assignment requests for the resource.
      - `[Id <String>]`: 
      - `[AssignmentState <String>]`: Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).
      - `[LinkedEligibleRoleAssignmentId <String>]`: If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.
      - `[Reason <String>]`: A message provided by users and administrators when create the request about why it is needed.
      - `[RequestedDateTime <DateTime?>]`: Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.
      - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[DisplayName <String>]`: The display name of the role definition.
        - `[ExternalId <String>]`: The external id of the role definition.
        - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
        - `[ResourceId <String>]`: Required. The id of the resource associated with the role definition.
        - `[RoleSetting <IMicrosoftGraphGovernanceRoleSetting>]`: governanceRoleSetting
        - `[TemplateId <String>]`: 
      - `[RoleDefinitionId <String>]`: Required. The identifier of the Azure role definition that the role assignment request is associated with.
      - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Duration <TimeSpan?>]`: The duration of a role assignment. It is in format of a TimeSpan.
        - `[EndDateTime <DateTime?>]`: The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Note: if the value is null, it indicates a permanent assignment.
        - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Type <String>]`: The role assignment schedule type. Only Once is supported for now.
      - `[Status <IMicrosoftGraphGovernanceRoleAssignmentRequestStatus>]`: governanceRoleAssignmentRequestStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Status <String>]`: The status of the role assignment request. The value can be InProgress or Closed.
        - `[StatusDetails <IMicrosoftGraphKeyValue[]>]`: The details of the status of the role assignment request. It represents the evaluation results of different rules.
          - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
          - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
        - `[SubStatus <String>]`: The sub status of the role assignment request. The values can be Accepted, PendingEvaluation, Granted, Denied, PendingProvisioning, Provisioned, PendingRevocation, Revoked, Canceled, Failed, PendingApprovalProvisioning, PendingApproval, FailedAsResourceIsLocked, PendingAdminDecision, AdminApproved, AdminDenied, TimedOut, and ProvisioningStarted.
      - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[DisplayName <String>]`: The display name of the subject.
        - `[Email <String>]`: The email address of the user subject. If the subject is in other types, it is empty.
        - `[PrincipalName <String>]`: The principal name of the user subject. If the subject is in other types, it is empty.
        - `[Type <String>]`: The type of the subject. The value can be User, Group, and ServicePrincipal.
      - `[SubjectId <String>]`: Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.
      - `[Type <String>]`: Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.
    - `[RoleAssignments <IMicrosoftGraphGovernanceRoleAssignment[]>]`: The collection of role assignments for the resource.
      - `[Id <String>]`: 
      - `[AssignmentState <String>]`: The state of the assignment. The value can be Eligible for eligible assignment or Active if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.
      - `[EndDateTime <DateTime?>]`: For a non-permanent role assignment, this is the time when the role assignment will be expired. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ExternalId <String>]`: The external ID the resource that is used to identify the role assignment in the provider.
      - `[LinkedEligibleRoleAssignment <IMicrosoftGraphGovernanceRoleAssignment>]`: governanceRoleAssignment
      - `[LinkedEligibleRoleAssignmentId <String>]`: If this is an active assignment and created due to activation on an eligible assignment, it represents the ID of that eligible assignment; Otherwise, the value is null.
      - `[MemberType <String>]`: The type of member. The value can be: Inherited (if the role assignment is inherited from a parent resource scope), Group (if the role assignment is not inherited, but comes from the membership of a group assignment), or User (if the role assignment is neither inherited nor from a group assignment).
      - `[Resource <IMicrosoftGraphGovernanceResource>]`: governanceResource
      - `[ResourceId <String>]`: Required. The ID of the resource which the role assignment is associated with.
      - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
      - `[RoleDefinitionId <String>]`: Required. The ID of the role definition which the role assignment is associated with.
      - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Status <String>]`: 
      - `[Subject <IMicrosoftGraphGovernanceSubject>]`: governanceSubject
      - `[SubjectId <String>]`: Required. The ID of the subject which the role assignment is associated with.
    - `[RoleDefinitions <IMicrosoftGraphGovernanceRoleDefinition[]>]`: The collection of role defintions for the resource.
    - `[RoleSettings <IMicrosoftGraphGovernanceRoleSetting[]>]`: The collection of role settings for the resource.
    - `[Status <String>]`: The status of a given resource. For example, it could represent whether the resource is locked or not (values: Active/Locked). Note: This property may be extended in the future to support more scenarios.
    - `[Type <String>]`: Required. Resource type. For example, for Azure resources, the type could be 'Subscription', 'ResourceGroup', 'Microsoft.Sql/server', etc.
  - `[ResourceId <String>]`: Required. The id of the resource that the role setting is associated with.
  - `[RoleDefinition <IMicrosoftGraphGovernanceRoleDefinition>]`: governanceRoleDefinition
  - `[RoleDefinitionId <String>]`: Required. The id of the role definition that the role setting is associated with.
  - `[UserEligibleSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.
  - `[UserMemberSettings <IMicrosoftGraphGovernanceRuleSetting[]>]`: The rule settings that are evaluated when a user tries to activate his role assignment.

## RELATED LINKS

