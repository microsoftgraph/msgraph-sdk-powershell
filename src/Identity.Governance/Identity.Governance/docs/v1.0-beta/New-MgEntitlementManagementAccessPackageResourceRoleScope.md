---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackageresourcerolescope
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackageResourceRoleScope

## SYNOPSIS
Nullable.

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId <String>
 [-AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]
 [-AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>] [-AdditionalProperties <Hashtable>]
 [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Id <String>] [-ModifiedBy <String>]
 [-ModifiedDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId <String>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRoleScope> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgEntitlementManagementAccessPackageResourceRoleScope -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRoleScope> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgEntitlementManagementAccessPackageResourceRoleScope -InputObject <IIdentityGovernanceIdentity>
 [-AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]
 [-AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>] [-AdditionalProperties <Hashtable>]
 [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Id <String>] [-ModifiedBy <String>]
 [-ModifiedDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Nullable.

## EXAMPLES

## PARAMETERS

### -AccessPackageId
key: id of accessPackage

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRole
accessPackageResourceRole
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRole
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceScope
accessPackageResourceScope
To construct, see NOTES section for ACCESSPACKAGERESOURCESCOPE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceScope
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageResourceRoleScope
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ModifiedBy
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGERESOURCEROLE <IMicrosoftGraphAccessPackageResourceRole>: accessPackageResourceRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

ACCESSPACKAGERESOURCESCOPE <IMicrosoftGraphAccessPackageResourceScope>: accessPackageResourceScope
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: A description for the resource role.
      - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
      - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
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
  - `[Description <String>]`: The description of the scope.
  - `[DisplayName <String>]`: The display name of the scope.
  - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
  - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
  - `[OriginSystem <String>]`: The origin system for the scope.
  - `[RoleOriginId <String>]`: The origin system for the role, if different.
  - `[Url <String>]`: A resource locator for the scope.

BODYPARAMETER <IMicrosoftGraphAccessPackageResourceRoleScope>: accessPackageResourceRoleScope
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
  - `[CreatedBy <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[ModifiedBy <String>]`: Read-only.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

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
  - `[AccessReviewId <String>]`: key: id of accessReview
  - `[AccessReviewId1 <String>]`: key: id of accessReview
  - `[AccessReviewInstanceDecisionItemId <String>]`: key: id of accessReviewInstanceDecisionItem
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
  - `[GovernanceResourceId <String>]`: key: id of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: key: id of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: key: id of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: key: id of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: key: id of governanceRoleSetting
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

## RELATED LINKS

