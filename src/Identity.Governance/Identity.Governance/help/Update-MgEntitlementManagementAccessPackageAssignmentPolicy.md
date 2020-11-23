---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentpolicy
schema: 2.0.0
---

# Update-MgEntitlementManagementAccessPackageAssignmentPolicy

## SYNOPSIS
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId <String>
 [-AccessPackageId <String>] [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]
 [-AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>] [-AdditionalProperties <Hashtable>]
 [-CanExtend] [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-Questions <IMicrosoftGraphAccessPackageQuestion[]>]
 [-RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]
 [-RequestorSettings <IMicrosoftGraphRequestorSettings>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpanded
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId <String>
 -AccessPackageId <String> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>] [-AccessPackageId1 <String>]
 [-AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>] [-AdditionalProperties <Hashtable>]
 [-CanExtend] [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-Questions <IMicrosoftGraphAccessPackageQuestion[]>]
 [-RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]
 [-RequestorSettings <IMicrosoftGraphRequestorSettings>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update1
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId <String>
 -BodyParameter <IMicrosoftGraphAccessPackageAssignmentPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageAssignmentPolicyId <String>
 -AccessPackageId <String> -BodyParameter <IMicrosoftGraphAccessPackageAssignmentPolicy> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy [-AccessPackageId <String>]
 -InputObject <IIdentityGovernanceIdentity> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]
 [-AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>] [-AdditionalProperties <Hashtable>]
 [-CanExtend] [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-Questions <IMicrosoftGraphAccessPackageQuestion[]>]
 [-RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]
 [-RequestorSettings <IMicrosoftGraphRequestorSettings>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy [-AccessPackageId <String>]
 -InputObject <IIdentityGovernanceIdentity> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]
 [-AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>] [-AdditionalProperties <Hashtable>]
 [-CanExtend] [-CreatedBy <String>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-DurationInDays <Int32>] [-ExpirationDateTime <DateTime>] [-Id <String>]
 [-ModifiedBy <String>] [-ModifiedDateTime <DateTime>] [-Questions <IMicrosoftGraphAccessPackageQuestion[]>]
 [-RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]
 [-RequestorSettings <IMicrosoftGraphRequestorSettings>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessPackageAssignmentPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicy -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAccessPackageAssignmentPolicy> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageAssignmentPolicies in identityGovernance

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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentPolicyId
key: id of accessPackageAssignmentPolicy

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, Update1, Update
Aliases:

Required: True
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageId
key: id of accessPackage

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -AccessPackageId1
.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessReviewSettings
assignmentReviewSettings
To construct, see NOTES section for ACCESSREVIEWSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAssignmentReviewSettings
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageAssignmentPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageAssignmentPolicy
Parameter Sets: Update1, Update, UpdateViaIdentity1, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CanExtend
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DurationInDays
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded, UpdateViaIdentity1, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ModifiedBy
.

```yaml
Type: String
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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

### -Questions
.
To construct, see NOTES section for QUESTIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageQuestion[]
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestApprovalSettings
approvalSettings
To construct, see NOTES section for REQUESTAPPROVALSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphApprovalSettings
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestorSettings
requestorSettings
To construct, see NOTES section for REQUESTORSETTINGS properties and create a hash table.

```yaml
Type: IMicrosoftGraphRequestorSettings
Parameter Sets: UpdateExpanded1, UpdateExpanded, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy
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

ACCESSREVIEWSETTINGS \<IMicrosoftGraphAssignmentReviewSettings\>: assignmentReviewSettings
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DurationInDays \<Int32?\>\]: 
  \[IsEnabled \<Boolean?\>\]: 
  \[RecurrenceType \<String\>\]: 
  \[ReviewerType \<String\>\]: 
  \[Reviewers \<IMicrosoftGraphUserSet\[\]\>\]: 
    \[IsBackup \<Boolean?\>\]: 
  \[StartDateTime \<DateTime?\>\]: 

BODYPARAMETER \<IMicrosoftGraphAccessPackageAssignmentPolicy\>: accessPackageAssignmentPolicy
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
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

QUESTIONS \<IMicrosoftGraphAccessPackageQuestion\[\]\>: .
  \[Id \<String\>\]: 
  \[IsRequired \<Boolean?\>\]: 
  \[Sequence \<Int32?\>\]: 
  \[Text \<IMicrosoftGraphAccessPackageLocalizedContent\>\]: accessPackageLocalizedContent
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DefaultText \<String\>\]: 
    \[LocalizedTexts \<IMicrosoftGraphAccessPackageLocalizedText\[\]\>\]: 
      \[LanguageCode \<String\>\]: 
      \[Text \<String\>\]: 

REQUESTAPPROVALSETTINGS \<IMicrosoftGraphApprovalSettings\>: approvalSettings
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ApprovalMode \<String\>\]: 
  \[ApprovalStages \<IMicrosoftGraphApprovalStage\[\]\>\]: 
    \[ApprovalStageTimeOutInDays \<Int32?\>\]: 
    \[EscalationApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
      \[IsBackup \<Boolean?\>\]: 
    \[EscalationTimeInMinutes \<Int32?\>\]: 
    \[IsApproverJustificationRequired \<Boolean?\>\]: 
    \[IsEscalationEnabled \<Boolean?\>\]: 
    \[PrimaryApprovers \<IMicrosoftGraphUserSet\[\]\>\]: 
  \[IsApprovalRequired \<Boolean?\>\]: 
  \[IsApprovalRequiredForExtension \<Boolean?\>\]: 
  \[IsRequestorJustificationRequired \<Boolean?\>\]: 

REQUESTORSETTINGS \<IMicrosoftGraphRequestorSettings\>: requestorSettings
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AcceptRequests \<Boolean?\>\]: 
  \[AllowedRequestors \<IMicrosoftGraphUserSet\[\]\>\]: 
    \[IsBackup \<Boolean?\>\]: 
  \[ScopeType \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentpolicy](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentpolicy)

