---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackage
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackage

## SYNOPSIS
Create new navigation property to accessPackages for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAccessPackage
 [-AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]
 [-AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]
 [-AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]
 [-AdditionalProperties <Hashtable>] [-CatalogId <String>] [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsHidden] [-IsRoleScopesVisible]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAccessPackage -BodyParameter <IMicrosoftGraphAccessPackage> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to accessPackages for identityGovernance

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

### -AccessPackageAssignmentPolicies
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTPOLICIES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAssignmentPolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageCatalog
accessPackageCatalog
To construct, see NOTES section for ACCESSPACKAGECATALOG properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageCatalog
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRoleScopes
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLESCOPES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceRoleScope[]
Parameter Sets: CreateExpanded
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
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackage
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackage
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsHidden
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRoleScopesVisible
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedBy
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSPACKAGEASSIGNMENTPOLICIES \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AccessPackageAssignmentPolicies \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>\]: 
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
  \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
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

ACCESSPACKAGECATALOG \<IMicrosoftGraphAccessPackageCatalog\>: accessPackageCatalog
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
    \[Id \<String\>\]: Read-only.
    \[AccessPackageAssignmentPolicies \<IMicrosoftGraphAccessPackageAssignmentPolicy\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AccessPackage \<IMicrosoftGraphAccessPackage\>\]: accessPackage
      \[AccessPackageCatalog \<IMicrosoftGraphAccessPackageCatalog\>\]: accessPackageCatalog
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
  \[CatalogStatus \<String\>\]: 
  \[CatalogType \<String\>\]: 
  \[CreatedBy \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[IsExternallyVisible \<Boolean?\>\]: 
  \[ModifiedBy \<String\>\]: 
  \[ModifiedDateTime \<DateTime?\>\]: 

ACCESSPACKAGERESOURCEROLESCOPES \<IMicrosoftGraphAccessPackageResourceRoleScope\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AccessPackageResourceRole \<IMicrosoftGraphAccessPackageResourceRole\>\]: accessPackageResourceRole
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
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
  \[AccessPackageResourceScope \<IMicrosoftGraphAccessPackageResourceScope\>\]: accessPackageResourceScope
  \[CreatedBy \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[ModifiedBy \<String\>\]: 
  \[ModifiedDateTime \<DateTime?\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackage\>: accessPackage
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

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackage](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackage)

