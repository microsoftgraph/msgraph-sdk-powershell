---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/update-mgbetaentitlementmanagementaccesspackageresourcerequest
schema: 2.0.0
---

# Update-MgBetaEntitlementManagementAccessPackageResourceRequest

## SYNOPSIS
Update the navigation property accessPackageResourceRequests in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaEntitlementManagementAccessPackageResourceRequest -AccessPackageResourceRequestId <String>
 [-AccessPackageResource <IMicrosoftGraphAccessPackageResource>] [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-ExecuteImmediately] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-IsValidationOnly] [-Justification <String>] [-Requestor <IMicrosoftGraphAccessPackageSubject>]
 [-RequestState <String>] [-RequestStatus <String>] [-RequestType <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaEntitlementManagementAccessPackageResourceRequest -AccessPackageResourceRequestId <String>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRequest> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaEntitlementManagementAccessPackageResourceRequest -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRequest> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaEntitlementManagementAccessPackageResourceRequest -InputObject <IIdentityGovernanceIdentity>
 [-AccessPackageResource <IMicrosoftGraphAccessPackageResource>] [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-ExecuteImmediately] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-IsValidationOnly] [-Justification <String>] [-Requestor <IMicrosoftGraphAccessPackageSubject>]
 [-RequestState <String>] [-RequestStatus <String>] [-RequestType <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageResourceRequests in identityGovernance

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AccessPackageResource
accessPackageResource
To construct, see NOTES section for ACCESSPACKAGERESOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageResource
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRequestId
The unique identifier of accessPackageResourceRequest

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
accessPackageResourceRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogId
The unique ID of the access package catalog.

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

### -ExecuteImmediately
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

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

### -Id
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsValidationOnly
If set, does not add the resource.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Justification
The requestor's justification for adding or removing the resource.

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

### -Requestor
accessPackageSubject
To construct, see NOTES section for REQUESTOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageSubject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestState
The outcome of whether the service was able to add the resource to the catalog.
The value is Delivered if the resource was added or removed.
Read-Only.

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

### -RequestStatus
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

### -RequestType
Use AdminAdd to add a resource, if the caller is an administrator or resource owner, AdminUpdate to update a resource, or AdminRemove to remove a resource.

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

### Microsoft.Graph.Beta.PowerShell.Models.IIdentityGovernanceIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACCESSPACKAGERESOURCE <IMicrosoftGraphAccessPackageResource>`: accessPackageResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
    - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
    - `[CreatedBy <String>]`: The display name of the user that created this object.
    - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Description <String>]`: The description of this object.
    - `[DisplayName <String>]`: The display name of this object.
    - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.
    - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
    - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: A description for the resource role.
    - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
    - `[OriginId <String>]`: The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable. Supports $expand.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: The description of the scope.
    - `[DisplayName <String>]`: The display name of the scope.
    - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
    - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
    - `[OriginSystem <String>]`: The origin system for the scope.
    - `[RoleOriginId <String>]`: The origin system for the role, if different.
    - `[Url <String>]`: A resource locator for the scope.
  - `[AddedBy <String>]`: The name of the user or application that first added this resource. Read-only.
  - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: Contains information about the attributes to be collected from the requestor and sent to the resource application.
    - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AttributeName <String>]`: The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension2b676109c7c74ae2b41549205f1947edpersonalTitle.
    - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Unique identifier for the attribute on the access package resource. Read-only.
    - `[IsEditable <Boolean?>]`: Specifies whether or not an existing attribute value can be edited by the requester.
    - `[IsPersistedOnAssignmentRemoval <Boolean?>]`: Specifies whether the attribute will remain in the end system after an assignment ends.
  - `[Description <String>]`: A description for the resource.
  - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name, or site name.
  - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment. Read-only.
  - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, originId is the identifier of the group.
  - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication, or AadGroup.
  - `[ResourceType <String>]`: The type of the resource, such as Application if it is a Microsoft Entra connected application, or SharePoint Online Site for a SharePoint Online site.
  - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.

`BODYPARAMETER <IMicrosoftGraphAccessPackageResourceRequest>`: accessPackageResourceRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
      - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
      - `[CreatedBy <String>]`: The display name of the user that created this object.
      - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of this object.
      - `[DisplayName <String>]`: The display name of this object.
      - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.
      - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
      - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: A description for the resource role.
      - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
      - `[OriginId <String>]`: The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: The description of the scope.
      - `[DisplayName <String>]`: The display name of the scope.
      - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
      - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
      - `[OriginSystem <String>]`: The origin system for the scope.
      - `[RoleOriginId <String>]`: The origin system for the role, if different.
      - `[Url <String>]`: A resource locator for the scope.
    - `[AddedBy <String>]`: The name of the user or application that first added this resource. Read-only.
    - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: Contains information about the attributes to be collected from the requestor and sent to the resource application.
      - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AttributeName <String>]`: The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension2b676109c7c74ae2b41549205f1947edpersonalTitle.
      - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Unique identifier for the attribute on the access package resource. Read-only.
      - `[IsEditable <Boolean?>]`: Specifies whether or not an existing attribute value can be edited by the requester.
      - `[IsPersistedOnAssignmentRemoval <Boolean?>]`: Specifies whether the attribute will remain in the end system after an assignment ends.
    - `[Description <String>]`: A description for the resource.
    - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name, or site name.
    - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment. Read-only.
    - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, originId is the identifier of the group.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication, or AadGroup.
    - `[ResourceType <String>]`: The type of the resource, such as Application if it is a Microsoft Entra connected application, or SharePoint Online Site for a SharePoint Online site.
    - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
  - `[CatalogId <String>]`: The unique ID of the access package catalog.
  - `[ExecuteImmediately <Boolean?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[IsValidationOnly <Boolean?>]`: If set, does not add the resource.
  - `[Justification <String>]`: The requestor's justification for adding or removing the resource.
  - `[RequestState <String>]`: The outcome of whether the service was able to add the resource to the catalog.  The value is Delivered if the resource was added or removed. Read-Only.
  - `[RequestStatus <String>]`: 
  - `[RequestType <String>]`: Use AdminAdd to add a resource, if the caller is an administrator or resource owner, AdminUpdate to update a resource, or AdminRemove to remove a resource.
  - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AltSecId <String>]`: Not Supported.
    - `[CleanupScheduledDateTime <DateTime?>]`: The date and time the subject is marked to be blocked from sign in or deleted. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
    - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the connected organization.
      - `[DisplayName <String>]`: The display name of the connected organization. Supports $filter (eq).
      - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
      - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: The identity sources in this connected organization, one of azureActiveDirectoryTenant, crossCloudAzureActiveDirectoryTenant, domainIdentitySource, externalDomainFederation, or socialIdentitySource. Read-only. Nullable. Supports $select and $filter(eq). To filter by the derived types, you must declare the resource using its full OData cast, for example, $filter=identitySources/any(is:is/microsoft.graph.azureActiveDirectoryTenant/tenantId eq 'bcfdfff4-cbc3-43f2-9000-ba7b7515054f').
      - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[ModifiedBy <String>]`: UPN of the user who last modified this resource. Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[State <String>]`: connectedOrganizationState
    - `[ConnectedOrganizationId <String>]`: The identifier of the connected organization of the subject.
    - `[DisplayName <String>]`: The display name of the subject.
    - `[Email <String>]`: The email address of the subject.
    - `[ObjectId <String>]`: The object identifier of the subject. null if the subject isn't yet a user in the tenant. Alternate key.
    - `[OnPremisesSecurityIdentifier <String>]`: 
    - `[PrincipalName <String>]`: The principal name, if known, of the subject.
    - `[SubjectLifecycle <String>]`: accessPackageSubjectLifecycle
    - `[Type <String>]`: The resource type of the subject.

`INPUTOBJECT <IIdentityGovernanceIdentity>`: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: The unique identifier of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: The unique identifier of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: The unique identifier of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: The unique identifier of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: The unique identifier of accessPackageCatalog
  - `[AccessPackageId <String>]`: The unique identifier of accessPackage
  - `[AccessPackageId1 <String>]`: The unique identifier of accessPackage
  - `[AccessPackageResourceEnvironmentId <String>]`: The unique identifier of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: The unique identifier of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: The unique identifier of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: The unique identifier of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: The unique identifier of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: The unique identifier of accessPackageResourceScope
  - `[AccessPackageSubjectId <String>]`: The unique identifier of accessPackageSubject
  - `[AccessReviewDecisionId <String>]`: The unique identifier of accessReviewDecision
  - `[AccessReviewHistoryDefinitionId <String>]`: The unique identifier of accessReviewHistoryDefinition
  - `[AccessReviewHistoryInstanceId <String>]`: The unique identifier of accessReviewHistoryInstance
  - `[AccessReviewId <String>]`: The unique identifier of accessReview
  - `[AccessReviewId1 <String>]`: The unique identifier of accessReview
  - `[AccessReviewInstanceDecisionItemId <String>]`: The unique identifier of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceDecisionItemId1 <String>]`: The unique identifier of accessReviewInstanceDecisionItem
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
  - `[ApprovalStepId <String>]`: The unique identifier of approvalStep
  - `[BusinessFlowTemplateId <String>]`: The unique identifier of businessFlowTemplate
  - `[ConnectedOrganizationId <String>]`: The unique identifier of connectedOrganization
  - `[CustomAccessPackageWorkflowExtensionId <String>]`: The unique identifier of customAccessPackageWorkflowExtension
  - `[CustomCalloutExtensionId <String>]`: The unique identifier of customCalloutExtension
  - `[CustomExtensionHandlerId <String>]`: The unique identifier of customExtensionHandler
  - `[CustomExtensionStageSettingId <String>]`: The unique identifier of customExtensionStageSetting
  - `[CustomTaskExtensionId <String>]`: The unique identifier of customTaskExtension
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime={endDateTime}
  - `[FindingId <String>]`: The unique identifier of finding
  - `[GovernanceInsightId <String>]`: The unique identifier of governanceInsight
  - `[GovernanceResourceId <String>]`: The unique identifier of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: The unique identifier of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: The unique identifier of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: The unique identifier of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: The unique identifier of governanceRoleSetting
  - `[GroupId <String>]`: The unique identifier of group
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[ObjectId <String>]`: Alternate key of accessPackageSubject
  - `[On <String>]`: Usage: on='{on}'
  - `[PermissionsCreepIndexDistributionId <String>]`: The unique identifier of permissionsCreepIndexDistribution
  - `[PermissionsRequestChangeId <String>]`: The unique identifier of permissionsRequestChange
  - `[PrivilegedAccessGroupAssignmentScheduleId <String>]`: The unique identifier of privilegedAccessGroupAssignmentSchedule
  - `[PrivilegedAccessGroupAssignmentScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleInstance
  - `[PrivilegedAccessGroupAssignmentScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleRequest
  - `[PrivilegedAccessGroupEligibilityScheduleId <String>]`: The unique identifier of privilegedAccessGroupEligibilitySchedule
  - `[PrivilegedAccessGroupEligibilityScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleInstance
  - `[PrivilegedAccessGroupEligibilityScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleRequest
  - `[PrivilegedAccessId <String>]`: The unique identifier of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: The unique identifier of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: The unique identifier of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: The unique identifier of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentId1 <String>]`: The unique identifier of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: The unique identifier of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: The unique identifier of privilegedRole
  - `[ProgramControlId <String>]`: The unique identifier of programControl
  - `[ProgramControlId1 <String>]`: The unique identifier of programControl
  - `[ProgramControlTypeId <String>]`: The unique identifier of programControlType
  - `[ProgramId <String>]`: The unique identifier of program
  - `[RbacApplicationId <String>]`: The unique identifier of rbacApplication
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
  - `[UnifiedRoleManagementAlertConfigurationId <String>]`: The unique identifier of unifiedRoleManagementAlertConfiguration
  - `[UnifiedRoleManagementAlertDefinitionId <String>]`: The unique identifier of unifiedRoleManagementAlertDefinition
  - `[UnifiedRoleManagementAlertId <String>]`: The unique identifier of unifiedRoleManagementAlert
  - `[UnifiedRoleManagementAlertIncidentId <String>]`: The unique identifier of unifiedRoleManagementAlertIncident
  - `[UserConsentRequestId <String>]`: The unique identifier of userConsentRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserProcessingResultId <String>]`: The unique identifier of userProcessingResult
  - `[WorkflowId <String>]`: The unique identifier of workflow
  - `[WorkflowTemplateId <String>]`: The unique identifier of workflowTemplate
  - `[WorkflowVersionNumber <Int32?>]`: The unique identifier of workflowVersion

`REQUESTOR <IMicrosoftGraphAccessPackageSubject>`: accessPackageSubject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AltSecId <String>]`: Not Supported.
  - `[CleanupScheduledDateTime <DateTime?>]`: The date and time the subject is marked to be blocked from sign in or deleted. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
  - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the connected organization.
    - `[DisplayName <String>]`: The display name of the connected organization. Supports $filter (eq).
    - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: The identity sources in this connected organization, one of azureActiveDirectoryTenant, crossCloudAzureActiveDirectoryTenant, domainIdentitySource, externalDomainFederation, or socialIdentitySource. Read-only. Nullable. Supports $select and $filter(eq). To filter by the derived types, you must declare the resource using its full OData cast, for example, $filter=identitySources/any(is:is/microsoft.graph.azureActiveDirectoryTenant/tenantId eq 'bcfdfff4-cbc3-43f2-9000-ba7b7515054f').
    - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[ModifiedBy <String>]`: UPN of the user who last modified this resource. Read-only.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[State <String>]`: connectedOrganizationState
  - `[ConnectedOrganizationId <String>]`: The identifier of the connected organization of the subject.
  - `[DisplayName <String>]`: The display name of the subject.
  - `[Email <String>]`: The email address of the subject.
  - `[ObjectId <String>]`: The object identifier of the subject. null if the subject isn't yet a user in the tenant. Alternate key.
  - `[OnPremisesSecurityIdentifier <String>]`: 
  - `[PrincipalName <String>]`: The principal name, if known, of the subject.
  - `[SubjectLifecycle <String>]`: accessPackageSubjectLifecycle
  - `[Type <String>]`: The resource type of the subject.

## RELATED LINKS

