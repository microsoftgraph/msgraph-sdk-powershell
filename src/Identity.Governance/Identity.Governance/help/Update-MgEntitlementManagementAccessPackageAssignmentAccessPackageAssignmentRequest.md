---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentaccesspackageassignmentrequest
schema: 2.0.0
---

# Update-MgEntitlementManagementAccessPackageAssignmentAccessPackageAssignmentRequest

## SYNOPSIS
Update the navigation property accessPackageAssignmentRequests in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEntitlementManagementAccessPackageAssignmentAccessPackageAssignmentRequest
 -AccessPackageAssignmentId <String> -AccessPackageAssignmentRequestId <String>
 [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>] [-AdditionalProperties <Hashtable>]
 [-Answers <IMicrosoftGraphAccessPackageAnswer[]>] [-CompletedDate <DateTime>] [-CreatedDateTime <DateTime>]
 [-ExpirationDateTime <DateTime>] [-Id <String>] [-IsValidationOnly] [-Justification <String>]
 [-RequestState <String>] [-RequestStatus <String>] [-RequestType <String>]
 [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-Schedule <IMicrosoftGraphRequestSchedule>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgEntitlementManagementAccessPackageAssignmentAccessPackageAssignmentRequest
 -AccessPackageAssignmentId <String> -AccessPackageAssignmentRequestId <String>
 -BodyParameter <IMicrosoftGraphAccessPackageAssignmentRequest> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEntitlementManagementAccessPackageAssignmentAccessPackageAssignmentRequest
 -InputObject <IIdentityGovernanceIdentity> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>] [-AdditionalProperties <Hashtable>]
 [-Answers <IMicrosoftGraphAccessPackageAnswer[]>] [-CompletedDate <DateTime>] [-CreatedDateTime <DateTime>]
 [-ExpirationDateTime <DateTime>] [-Id <String>] [-IsValidationOnly] [-Justification <String>]
 [-RequestState <String>] [-RequestStatus <String>] [-RequestType <String>]
 [-Requestor <IMicrosoftGraphAccessPackageSubject>] [-Schedule <IMicrosoftGraphRequestSchedule>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEntitlementManagementAccessPackageAssignmentAccessPackageAssignmentRequest
 -InputObject <IIdentityGovernanceIdentity> -BodyParameter <IMicrosoftGraphAccessPackageAssignmentRequest>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageAssignmentRequests in identityGovernance

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

### -AccessPackage
accessPackage
To construct, see NOTES section for ACCESSPACKAGE properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackage
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignment
accessPackageAssignment
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENT properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAssignment
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentId
key: id of accessPackageAssignment

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

### -AccessPackageAssignmentRequestId
key: id of accessPackageAssignmentRequest

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

### -Answers
.
To construct, see NOTES section for ANSWERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAnswer[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageAssignmentRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAssignmentRequest
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompletedDate
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

### -CreatedDateTime
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

### -Schedule
requestSchedule
To construct, see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: IMicrosoftGraphRequestSchedule
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSPACKAGE \<IMicrosoftGraphAccessPackage\>: accessPackage
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackageAssignmentPolicies \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
        \[Id \<String\>\]: Read-only.
        \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[Id \<String\>\]: Read-only.
          \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
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
        \[Description \<String\>\]: 
        \[DisplayName \<String\>\]: 
        \[OriginId \<String\>\]: 
        \[OriginSystem \<String\>\]: 
      \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
      \[AccessPackageResources \<IMicrosoftGraphAccessPackageResource\[\]\>\]: 
      \[AccessPackages \<IMicrosoftGraphAccessPackage\[\]\>\]: 
      \[CatalogStatus \<String\>\]: 
      \[CatalogType \<String\>\]: 
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[IsExternallyVisible \<Boolean?\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
    \[AccessPackageId \<String\>\]: 
    \[AccessReviewSettings \<IMicrosoftGraphAssignmentReviewSettings\>\]: assignmentReviewSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DurationInDays \<Int32?\>\]: 
      \[IsEnabled \<Boolean?\>\]: 
      \[RecurrenceType \<String\>\]: 
      \[ReviewerType \<String\>\]: 
      \[Reviewers \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[IsBackup \<Boolean?\>\]: 
      \[StartDateTime \<DateTime?\>\]: 
    \[CanExtend \<Boolean?\>\]: 
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[DurationInDays \<Int32?\>\]: 
    \[ExpirationDateTime \<DateTime?\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
    \[Questions \<IMicrosoftGraphAccessPackageQuestion\[\]\>\]: 
      \[Id \<String\>\]: 
      \[IsRequired \<Boolean?\>\]: 
      \[Sequence \<Int32?\>\]: 
      \[Text \<IMicrosoftGraphAccessPackageLocalizedContent\>\]: accessPackageLocalizedContent
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DefaultText \<String\>\]: 
        \[LocalizedTexts \<IMicrosoftGraphAccessPackageLocalizedText\[\]\>\]: 
          \[LanguageCode \<String\>\]: 
          \[Text \<String\>\]: 
    \[RequestApprovalSettings \<IMicrosoftGraphApprovalSettings\>\]: approvalSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[ApprovalMode \<String\>\]: 
      \[ApprovalStages \<IMicrosoftGraphApprovalStage\[\]\>\]: 
        \[ApprovalStageTimeOutInDays \<Int32?\>\]: 
        \[EscalationApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[EscalationTimeInMinutes \<Int32?\>\]: 
        \[IsApproverJustificationRequired \<Boolean?\>\]: 
        \[IsEscalationEnabled \<Boolean?\>\]: 
        \[PrimaryApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
      \[IsApprovalRequired \<Boolean?\>\]: 
      \[IsApprovalRequiredForExtension \<Boolean?\>\]: 
      \[IsRequestorJustificationRequired \<Boolean?\>\]: 
    \[RequestorSettings \<IMicrosoftGraphRequestorSettings\>\]: requestorSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AcceptRequests \<Boolean?\>\]: 
      \[AllowedRequestors \<IMicrosoftGraphUserSet\[\]\>\]: 
      \[ScopeType \<String\>\]: 
  \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
  \[AccessPackageResourceRoleScopes \<IMicrosoftGraphAccessPackageResourceRoleScope\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
    \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
  \[CatalogId \<String\>\]: 
  \[CreatedBy \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsHidden \<Boolean?\>\]: 
  \[IsRoleScopesVisible \<Boolean?\>\]: 
  \[ModifiedBy \<String\>\]: 
  \[ModifiedDateTime \<DateTime?\>\]: 

ACCESSPACKAGEASSIGNMENT \<IMicrosoftGraphAccessPackageAssignment\>: accessPackageAssignment
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageAssignmentPolicies \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
      \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
          \[Id \<String\>\]: Read-only.
          \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
            \[(Any) \<Object\>\]: This indicates any property can be added to this object.
            \[Id \<String\>\]: Read-only.
            \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
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
          \[Description \<String\>\]: 
          \[DisplayName \<String\>\]: 
          \[OriginId \<String\>\]: 
          \[OriginSystem \<String\>\]: 
        \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
        \[AccessPackageResources \<IMicrosoftGraphAccessPackageResource\[\]\>\]: 
        \[AccessPackages \<IMicrosoftGraphAccessPackage\[\]\>\]: 
        \[CatalogStatus \<String\>\]: 
        \[CatalogType \<String\>\]: 
        \[CreatedBy \<String\>\]: 
        \[CreatedDateTime \<DateTime?\>\]: 
        \[Description \<String\>\]: 
        \[DisplayName \<String\>\]: 
        \[IsExternallyVisible \<Boolean?\>\]: 
        \[ModifiedBy \<String\>\]: 
        \[ModifiedDateTime \<DateTime?\>\]: 
      \[AccessPackageId \<String\>\]: 
      \[AccessReviewSettings \<IMicrosoftGraphAssignmentReviewSettings\>\]: assignmentReviewSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DurationInDays \<Int32?\>\]: 
        \[IsEnabled \<Boolean?\>\]: 
        \[RecurrenceType \<String\>\]: 
        \[ReviewerType \<String\>\]: 
        \[Reviewers \<IMicrosoftGraphUserSet\[\]\>\]: 
          \[IsBackup \<Boolean?\>\]: 
        \[StartDateTime \<DateTime?\>\]: 
      \[CanExtend \<Boolean?\>\]: 
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[DurationInDays \<Int32?\>\]: 
      \[ExpirationDateTime \<DateTime?\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
      \[Questions \<IMicrosoftGraphAccessPackageQuestion\[\]\>\]: 
        \[Id \<String\>\]: 
        \[IsRequired \<Boolean?\>\]: 
        \[Sequence \<Int32?\>\]: 
        \[Text \<IMicrosoftGraphAccessPackageLocalizedContent\>\]: accessPackageLocalizedContent
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[DefaultText \<String\>\]: 
          \[LocalizedTexts \<IMicrosoftGraphAccessPackageLocalizedText\[\]\>\]: 
            \[LanguageCode \<String\>\]: 
            \[Text \<String\>\]: 
      \[RequestApprovalSettings \<IMicrosoftGraphApprovalSettings\>\]: approvalSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[ApprovalMode \<String\>\]: 
        \[ApprovalStages \<IMicrosoftGraphApprovalStage\[\]\>\]: 
          \[ApprovalStageTimeOutInDays \<Int32?\>\]: 
          \[EscalationApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
          \[EscalationTimeInMinutes \<Int32?\>\]: 
          \[IsApproverJustificationRequired \<Boolean?\>\]: 
          \[IsEscalationEnabled \<Boolean?\>\]: 
          \[PrimaryApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[IsApprovalRequired \<Boolean?\>\]: 
        \[IsApprovalRequiredForExtension \<Boolean?\>\]: 
        \[IsRequestorJustificationRequired \<Boolean?\>\]: 
      \[RequestorSettings \<IMicrosoftGraphRequestorSettings\>\]: requestorSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[AcceptRequests \<Boolean?\>\]: 
        \[AllowedRequestors \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[ScopeType \<String\>\]: 
    \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
    \[AccessPackageResourceRoleScopes \<IMicrosoftGraphAccessPackageResourceRoleScope\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
      \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
    \[CatalogId \<String\>\]: 
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsHidden \<Boolean?\>\]: 
    \[IsRoleScopesVisible \<Boolean?\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
  \[AccessPackageAssignmentPolicy \<IMicrosoftGraphAccessPackageAssignmentPolicy\>\]: accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequests \<IMicrosoftGraphAccessPackageAssignmentRequest\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[AccessPackageAssignment \<IMicrosoftGraphAccessPackageAssignment\>\]: accessPackageAssignment
    \[Answers \<IMicrosoftGraphAccessPackageAnswer\[\]\>\]: 
      \[AnsweredQuestion \<IMicrosoftGraphAccessPackageQuestion\>\]: accessPackageQuestion
      \[DisplayValue \<String\>\]: 
    \[CompletedDate \<DateTime?\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
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
    \[Schedule \<IMicrosoftGraphRequestSchedule\>\]: requestSchedule
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Expiration \<IMicrosoftGraphExpirationPattern\>\]: expirationPattern
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Duration \<TimeSpan?\>\]: 
        \[EndDateTime \<DateTime?\>\]: 
        \[Type \<String\>\]: expirationPatternType
      \[Recurrence \<IMicrosoftGraphPatternedRecurrence\>\]: patternedRecurrence
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Pattern \<IMicrosoftGraphRecurrencePattern\>\]: recurrencePattern
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[DayOfMonth \<Int32?\>\]: The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.
          \[DaysOfWeek \<String\[\]\>\]: A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern. 
Required if type is weekly, relativeMonthly, or relativeYearly.
          \[FirstDayOfWeek \<String\>\]: dayOfWeek
          \[Index \<String\>\]: weekIndex
          \[Interval \<Int32?\>\]: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.
          \[Month \<Int32?\>\]: The month in which the event occurs. 
This is a number from 1 to 12.
          \[Type \<String\>\]: recurrencePatternType
        \[Range \<IMicrosoftGraphRecurrenceRange\>\]: recurrenceRange
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[EndDate \<DateTime?\>\]: The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.
          \[NumberOfOccurrences \<Int32?\>\]: The number of times to repeat the event.
Required and must be positive if type is numbered.
          \[RecurrenceTimeZone \<String\>\]: Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.
          \[StartDate \<DateTime?\>\]: The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.
          \[Type \<String\>\]: recurrenceRangeType
      \[StartDateTime \<DateTime?\>\]: 
  \[AccessPackageAssignmentResourceRoles \<IMicrosoftGraphAccessPackageAssignmentResourceRole\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AccessPackageAssignments \<IMicrosoftGraphAccessPackageAssignment\[\]\>\]: 
    \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
    \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
    \[AccessPackageSubject \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
    \[OriginId \<String\>\]: 
    \[OriginSystem \<String\>\]: 
    \[Status \<String\>\]: 
  \[AccessPackageId \<String\>\]: 
  \[AssignmentPolicyId \<String\>\]: 
  \[AssignmentState \<String\>\]: 
  \[AssignmentStatus \<String\>\]: 
  \[CatalogId \<String\>\]: 
  \[ExpiredDateTime \<DateTime?\>\]: 
  \[IsExtended \<Boolean?\>\]: 
  \[Schedule \<IMicrosoftGraphRequestSchedule\>\]: requestSchedule
  \[Target \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
  \[TargetId \<String\>\]: 

ANSWERS \<IMicrosoftGraphAccessPackageAnswer\[\]\>: .
  \[AnsweredQuestion \<IMicrosoftGraphAccessPackageQuestion\>\]: accessPackageQuestion
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: 
    \[IsRequired \<Boolean?\>\]: 
    \[Sequence \<Int32?\>\]: 
    \[Text \<IMicrosoftGraphAccessPackageLocalizedContent\>\]: accessPackageLocalizedContent
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DefaultText \<String\>\]: 
      \[LocalizedTexts \<IMicrosoftGraphAccessPackageLocalizedText\[\]\>\]: 
        \[LanguageCode \<String\>\]: 
        \[Text \<String\>\]: 
  \[DisplayValue \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackageAssignmentRequest\>: accessPackageAssignmentRequest
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageAssignmentPolicies \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
      \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
          \[Id \<String\>\]: Read-only.
          \[AccessPackageResource \<IMicrosoftGraphAccessPackageResource\>\]: accessPackageResource
            \[(Any) \<Object\>\]: This indicates any property can be added to this object.
            \[Id \<String\>\]: Read-only.
            \[AccessPackageResourceRoles \<IMicrosoftGraphAccessPackageResourceRole\[\]\>\]: 
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
          \[Description \<String\>\]: 
          \[DisplayName \<String\>\]: 
          \[OriginId \<String\>\]: 
          \[OriginSystem \<String\>\]: 
        \[AccessPackageResourceScopes \<IMicrosoftGraphAccessPackageResourceScope\[\]\>\]: 
        \[AccessPackageResources \<IMicrosoftGraphAccessPackageResource\[\]\>\]: 
        \[AccessPackages \<IMicrosoftGraphAccessPackage\[\]\>\]: 
        \[CatalogStatus \<String\>\]: 
        \[CatalogType \<String\>\]: 
        \[CreatedBy \<String\>\]: 
        \[CreatedDateTime \<DateTime?\>\]: 
        \[Description \<String\>\]: 
        \[DisplayName \<String\>\]: 
        \[IsExternallyVisible \<Boolean?\>\]: 
        \[ModifiedBy \<String\>\]: 
        \[ModifiedDateTime \<DateTime?\>\]: 
      \[AccessPackageId \<String\>\]: 
      \[AccessReviewSettings \<IMicrosoftGraphAssignmentReviewSettings\>\]: assignmentReviewSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[DurationInDays \<Int32?\>\]: 
        \[IsEnabled \<Boolean?\>\]: 
        \[RecurrenceType \<String\>\]: 
        \[ReviewerType \<String\>\]: 
        \[Reviewers \<IMicrosoftGraphUserSet\[\]\>\]: 
          \[IsBackup \<Boolean?\>\]: 
        \[StartDateTime \<DateTime?\>\]: 
      \[CanExtend \<Boolean?\>\]: 
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[Description \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[DurationInDays \<Int32?\>\]: 
      \[ExpirationDateTime \<DateTime?\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
      \[Questions \<IMicrosoftGraphAccessPackageQuestion\[\]\>\]: 
        \[Id \<String\>\]: 
        \[IsRequired \<Boolean?\>\]: 
        \[Sequence \<Int32?\>\]: 
        \[Text \<IMicrosoftGraphAccessPackageLocalizedContent\>\]: accessPackageLocalizedContent
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[DefaultText \<String\>\]: 
          \[LocalizedTexts \<IMicrosoftGraphAccessPackageLocalizedText\[\]\>\]: 
            \[LanguageCode \<String\>\]: 
            \[Text \<String\>\]: 
      \[RequestApprovalSettings \<IMicrosoftGraphApprovalSettings\>\]: approvalSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[ApprovalMode \<String\>\]: 
        \[ApprovalStages \<IMicrosoftGraphApprovalStage\[\]\>\]: 
          \[ApprovalStageTimeOutInDays \<Int32?\>\]: 
          \[EscalationApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
          \[EscalationTimeInMinutes \<Int32?\>\]: 
          \[IsApproverJustificationRequired \<Boolean?\>\]: 
          \[IsEscalationEnabled \<Boolean?\>\]: 
          \[PrimaryApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[IsApprovalRequired \<Boolean?\>\]: 
        \[IsApprovalRequiredForExtension \<Boolean?\>\]: 
        \[IsRequestorJustificationRequired \<Boolean?\>\]: 
      \[RequestorSettings \<IMicrosoftGraphRequestorSettings\>\]: requestorSettings
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[AcceptRequests \<Boolean?\>\]: 
        \[AllowedRequestors \<IMicrosoftGraphUserSet\[\]\>\]: 
        \[ScopeType \<String\>\]: 
    \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
    \[AccessPackageResourceRoleScopes \<IMicrosoftGraphAccessPackageResourceRoleScope\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
      \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
      \[CreatedBy \<String\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[ModifiedBy \<String\>\]: 
      \[ModifiedDateTime \<DateTime?\>\]: 
    \[CatalogId \<String\>\]: 
    \[CreatedBy \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[IsHidden \<Boolean?\>\]: 
    \[IsRoleScopesVisible \<Boolean?\>\]: 
    \[ModifiedBy \<String\>\]: 
    \[ModifiedDateTime \<DateTime?\>\]: 
  \[AccessPackageAssignment \<IMicrosoftGraphAccessPackageAssignment\>\]: accessPackageAssignment
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[AccessPackageAssignmentPolicy \<IMicrosoftGraphAccessPackageAssignmentPolicy\>\]: accessPackageAssignmentPolicy
    \[AccessPackageAssignmentRequests \<IMicrosoftGraphAccessPackageAssignmentRequest\[\]\>\]: 
    \[AccessPackageAssignmentResourceRoles \<IMicrosoftGraphAccessPackageAssignmentResourceRole\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackageAssignments \<IMicrosoftGraphAccessPackageAssignment\[\]\>\]: 
      \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
      \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
      \[AccessPackageSubject \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
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
      \[OriginId \<String\>\]: 
      \[OriginSystem \<String\>\]: 
      \[Status \<String\>\]: 
    \[AccessPackageId \<String\>\]: 
    \[AssignmentPolicyId \<String\>\]: 
    \[AssignmentState \<String\>\]: 
    \[AssignmentStatus \<String\>\]: 
    \[CatalogId \<String\>\]: 
    \[ExpiredDateTime \<DateTime?\>\]: 
    \[IsExtended \<Boolean?\>\]: 
    \[Schedule \<IMicrosoftGraphRequestSchedule\>\]: requestSchedule
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Expiration \<IMicrosoftGraphExpirationPattern\>\]: expirationPattern
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Duration \<TimeSpan?\>\]: 
        \[EndDateTime \<DateTime?\>\]: 
        \[Type \<String\>\]: expirationPatternType
      \[Recurrence \<IMicrosoftGraphPatternedRecurrence\>\]: patternedRecurrence
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Pattern \<IMicrosoftGraphRecurrencePattern\>\]: recurrencePattern
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[DayOfMonth \<Int32?\>\]: The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.
          \[DaysOfWeek \<String\[\]\>\]: A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern. 
Required if type is weekly, relativeMonthly, or relativeYearly.
          \[FirstDayOfWeek \<String\>\]: dayOfWeek
          \[Index \<String\>\]: weekIndex
          \[Interval \<Int32?\>\]: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.
          \[Month \<Int32?\>\]: The month in which the event occurs. 
This is a number from 1 to 12.
          \[Type \<String\>\]: recurrencePatternType
        \[Range \<IMicrosoftGraphRecurrenceRange\>\]: recurrenceRange
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[EndDate \<DateTime?\>\]: The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.
          \[NumberOfOccurrences \<Int32?\>\]: The number of times to repeat the event.
Required and must be positive if type is numbered.
          \[RecurrenceTimeZone \<String\>\]: Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.
          \[StartDate \<DateTime?\>\]: The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.
          \[Type \<String\>\]: recurrenceRangeType
      \[StartDateTime \<DateTime?\>\]: 
    \[Target \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
    \[TargetId \<String\>\]: 
  \[Answers \<IMicrosoftGraphAccessPackageAnswer\[\]\>\]: 
    \[AnsweredQuestion \<IMicrosoftGraphAccessPackageQuestion\>\]: accessPackageQuestion
    \[DisplayValue \<String\>\]: 
  \[CompletedDate \<DateTime?\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[IsValidationOnly \<Boolean?\>\]: 
  \[Justification \<String\>\]: 
  \[RequestState \<String\>\]: 
  \[RequestStatus \<String\>\]: 
  \[RequestType \<String\>\]: 
  \[Requestor \<IMicrosoftGraphAccessPackageSubject\>\]: accessPackageSubject
  \[Schedule \<IMicrosoftGraphRequestSchedule\>\]: requestSchedule

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

SCHEDULE \<IMicrosoftGraphRequestSchedule\>: requestSchedule
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Expiration \<IMicrosoftGraphExpirationPattern\>\]: expirationPattern
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Duration \<TimeSpan?\>\]: 
    \[EndDateTime \<DateTime?\>\]: 
    \[Type \<String\>\]: expirationPatternType
  \[Recurrence \<IMicrosoftGraphPatternedRecurrence\>\]: patternedRecurrence
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Pattern \<IMicrosoftGraphRecurrencePattern\>\]: recurrencePattern
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DayOfMonth \<Int32?\>\]: The day of the month on which the event occurs.
Required if type is absoluteMonthly or absoluteYearly.
      \[DaysOfWeek \<String\[\]\>\]: A collection of the days of the week on which the event occurs.
The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.
If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern. 
Required if type is weekly, relativeMonthly, or relativeYearly.
      \[FirstDayOfWeek \<String\>\]: dayOfWeek
      \[Index \<String\>\]: weekIndex
      \[Interval \<Int32?\>\]: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type.
Required.
      \[Month \<Int32?\>\]: The month in which the event occurs. 
This is a number from 1 to 12.
      \[Type \<String\>\]: recurrencePatternType
    \[Range \<IMicrosoftGraphRecurrenceRange\>\]: recurrenceRange
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[EndDate \<DateTime?\>\]: The date to stop applying the recurrence pattern.
Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date.
Required if type is endDate.
      \[NumberOfOccurrences \<Int32?\>\]: The number of times to repeat the event.
Required and must be positive if type is numbered.
      \[RecurrenceTimeZone \<String\>\]: Time zone for the startDate and endDate properties.
Optional.
If not specified, the time zone of the event is used.
      \[StartDate \<DateTime?\>\]: The date to start applying the recurrence pattern.
The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event.
Must be the same value as the start property of the recurring event.
Required.
      \[Type \<String\>\]: recurrenceRangeType
  \[StartDateTime \<DateTime?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentaccesspackageassignmentrequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentaccesspackageassignmentrequest)

