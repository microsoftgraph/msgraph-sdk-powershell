---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageresourcerequest
schema: 2.0.0
---

# Update-MgEntitlementManagementAccessPackageResourceRequest

## SYNOPSIS
Update the navigation property accessPackageResourceRequests in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEntitlementManagementAccessPackageResourceRequest -AccessPackageResourceRequestId <String>
 [-AccessPackageResource <IMicrosoftGraphAccessPackageResource>] [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-ExecuteImmediately] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-IsValidationOnly] [-Justification <String>] [-RequestState <String>] [-RequestStatus <String>]
 [-RequestType <String>] [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgEntitlementManagementAccessPackageResourceRequest -AccessPackageResourceRequestId <String>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRequest> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEntitlementManagementAccessPackageResourceRequest -InputObject <IIdentityGovernanceIdentity>
 [-AccessPackageResource <IMicrosoftGraphAccessPackageResource>] [-AdditionalProperties <Hashtable>]
 [-CatalogId <String>] [-ExecuteImmediately] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-IsValidationOnly] [-Justification <String>] [-RequestState <String>] [-RequestStatus <String>]
 [-RequestType <String>] [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEntitlementManagementAccessPackageResourceRequest -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessPackageResourceRequest> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageResourceRequests in identityGovernance

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

### -AccessPackageResource
accessPackageResource
To construct, see NOTES section for ACCESSPACKAGERESOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResource
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRequestId
key: id of accessPackageResourceRequest

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
accessPackageResourceRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceRequest
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogId
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

### -ExecuteImmediately
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
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

### -IsValidationOnly
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Justification
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

### -Requestor
accessPackageSubject
To construct, see NOTES section for REQUESTOR properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageSubject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestState
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

### -RequestStatus
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

### -RequestType
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSPACKAGERESOURCE \<IMicrosoftGraphAccessPackageResource\>: accessPackageResource
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
  \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsRootScope \<Boolean?\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
    \[RoleOriginId \<String\>\]: 
    \[Url \<String\>\]: 
  \[AddedBy \<String\>\]: 
  \[AddedOn \<DateTime?\>\]: 
  \[Attributes \<IMicrosoftGraphAccessPackageResourceAttribute\[\]\>\]: 
    \[AttributeDestination \<IMicrosoftGraphAccessPackageResourceAttributeDestination\>\]: accessPackageResourceAttributeDestination
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AttributeName \<String\>\]: 
    \[AttributeSource \<IMicrosoftGraphAccessPackageResourceAttributeSource\>\]: accessPackageResourceAttributeSource
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsPendingOnboarding \<Boolean?\>\]: 
  \[OriginId \<String\>\]: 
  \[OriginSystem \<String\>\]: 
  \[ResourceType \<String\>\]: 
  \[Url \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackageResourceRequest\>: accessPackageResourceRequest
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[OriginId \<String\>\]: 
      \[OriginSystem \<String\>\]: 
    \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[IsRootScope \<Boolean?\>\]: 
      \[OriginId \<String\>\]: 
      \[OriginSystem \<String\>\]: 
      \[RoleOriginId \<String\>\]: 
      \[Url \<String\>\]: 
    \[AddedBy \<String\>\]: 
    \[AddedOn \<DateTime?\>\]: 
    \[Attributes \<IMicrosoftGraphAccessPackageResourceAttribute\[\]\>\]: 
      \[AttributeDestination \<IMicrosoftGraphAccessPackageResourceAttributeDestination\>\]: accessPackageResourceAttributeDestination
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AttributeName \<String\>\]: 
      \[AttributeSource \<IMicrosoftGraphAccessPackageResourceAttributeSource\>\]: accessPackageResourceAttributeSource
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsPendingOnboarding \<Boolean?\>\]: 
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
    \[ResourceType \<String\>\]: 
    \[Url \<String\>\]: 
  \[CatalogId \<String\>\]: 
  \[ExecuteImmediately \<Boolean?\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[IsValidationOnly \<Boolean?\>\]: 
  \[Justification \<String\>\]: 
  \[RequestState \<String\>\]: 
  \[RequestStatus \<String\>\]: 
  \[RequestType \<String\>\]: 
  \[Requestor \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AltSecId \<String\>\]: 
    \[ConnectedOrganization \<IMicrosoftGraphConnectedOrganization\>\]: connectedOrganization
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[ExternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
        \[Id \<String\>\]: Read-only.
        \[DeletedDateTime \<DateTime?\>\]: 
      \[IdentitySources \<IMicrosoftGraphIdentitySource\[\]\>\]: 
      \[InternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
      \[State \<String\>\]: connectedOrganizationState
    \[ConnectedOrganizationId \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[Email \<String\>\]: 
    \[ObjectId \<String\>\]: 
    \[OnPremisesSecurityIdentifier \<String\>\]: 
    \[PrincipalName \<String\>\]: 
    \[Type \<String\>\]: 

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

REQUESTOR \<IMicrosoftGraphAccessPackageSubject\>: accessPackageSubject
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AltSecId \<String\>\]: 
  \[ConnectedOrganization \<IMicrosoftGraphConnectedOrganization\>\]: connectedOrganization
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[ExternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[DeletedDateTime \<DateTime?\>\]: 
    \[IdentitySources \<IMicrosoftGraphIdentitySource\[\]\>\]: 
    \[InternalSponsors \<IMicrosoftGraphDirectoryObject\[\]\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
    \[State \<String\>\]: connectedOrganizationState
  \[ConnectedOrganizationId \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[Email \<String\>\]: 
  \[ObjectId \<String\>\]: 
  \[OnPremisesSecurityIdentifier \<String\>\]: 
  \[PrincipalName \<String\>\]: 
  \[Type \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageresourcerequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageresourcerequest)

