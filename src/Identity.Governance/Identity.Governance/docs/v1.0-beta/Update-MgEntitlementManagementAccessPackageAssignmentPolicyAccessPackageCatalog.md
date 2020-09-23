---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentpolicyaccesspackagecatalog
schema: 2.0.0
---

# Update-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalog

## SYNOPSIS
Update the navigation property accessPackageCatalog in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalog
 -AccessPackageAssignmentPolicyId <String>
 [-AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]
 [-AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]
 [-AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]
 [-AccessPackages <IMicrosoftGraphAccessPackage[]>] [-AdditionalProperties <Hashtable>]
 [-CatalogStatus <String>] [-CatalogType <String>] [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsExternallyVisible] [-ModifiedBy <String>]
 [-ModifiedDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalog
 -AccessPackageAssignmentPolicyId <String> -BodyParameter <IMicrosoftGraphAccessPackageCatalog> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalog
 -InputObject <IIdentityGovernanceIdentity> -BodyParameter <IMicrosoftGraphAccessPackageCatalog> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEntitlementManagementAccessPackageAssignmentPolicyAccessPackageCatalog
 -InputObject <IIdentityGovernanceIdentity>
 [-AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]
 [-AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]
 [-AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]
 [-AccessPackages <IMicrosoftGraphAccessPackage[]>] [-AdditionalProperties <Hashtable>]
 [-CatalogStatus <String>] [-CatalogType <String>] [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsExternallyVisible] [-ModifiedBy <String>]
 [-ModifiedDateTime <DateTime>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageCatalog in identityGovernance

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AccessPackageAssignmentPolicyId
key: id of accessPackageAssignmentPolicy

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

### -AccessPackageResourceRoles
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRole[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResources
.
To construct, see NOTES section for ACCESSPACKAGERESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceScopes
.
To construct, see NOTES section for ACCESSPACKAGERESOURCESCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceScope[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackages
.
To construct, see NOTES section for ACCESSPACKAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageCatalog
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogStatus
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

### -CatalogType
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

### -CreatedBy
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

### -CreatedDateTime
.

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

### -Description
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

### -DisplayName
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

### -Id
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsExternallyVisible
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

### -ModifiedBy
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

### -ModifiedDateTime
.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGERESOURCEROLES <IMicrosoftGraphAccessPackageResourceRole[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[RoleOriginId <String>]`: 
      - `[Url <String>]`: 
    - `[AddedBy <String>]`: 
    - `[AddedOn <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsPendingOnboarding <Boolean?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Url <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 

ACCESSPACKAGERESOURCES <IMicrosoftGraphAccessPackageResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsRootScope <Boolean?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[RoleOriginId <String>]`: 
    - `[Url <String>]`: 
  - `[AddedBy <String>]`: 
  - `[AddedOn <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsPendingOnboarding <Boolean?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[ResourceType <String>]`: 
  - `[Url <String>]`: 

ACCESSPACKAGERESOURCESCOPES <IMicrosoftGraphAccessPackageResourceScope[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AddedBy <String>]`: 
    - `[AddedOn <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsPendingOnboarding <Boolean?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Url <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsRootScope <Boolean?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[RoleOriginId <String>]`: 
  - `[Url <String>]`: 

ACCESSPACKAGES <IMicrosoftGraphAccessPackage[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
            - `[Id <String>]`: Read-only.
            - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
            - `[Description <String>]`: 
            - `[DisplayName <String>]`: 
            - `[IsRootScope <Boolean?>]`: 
            - `[OriginId <String>]`: 
            - `[OriginSystem <String>]`: 
            - `[RoleOriginId <String>]`: 
            - `[Url <String>]`: 
          - `[AddedBy <String>]`: 
          - `[AddedOn <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[IsPendingOnboarding <Boolean?>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
          - `[ResourceType <String>]`: 
          - `[Url <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
      - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[CatalogStatus <String>]`: 
      - `[CatalogType <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsExternallyVisible <Boolean?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>]`: assignmentReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationInDays <Int32?>]`: 
      - `[IsEnabled <Boolean?>]`: 
      - `[RecurrenceType <String>]`: 
      - `[ReviewerType <String>]`: 
      - `[Reviewers <IMicrosoftGraphUserSet[]>]`: 
        - `[IsBackup <Boolean?>]`: 
      - `[StartDateTime <DateTime?>]`: 
    - `[CanExtend <Boolean?>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[DurationInDays <Int32?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]`: approvalSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApprovalMode <String>]`: 
      - `[ApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
        - `[ApprovalStageTimeOutInDays <Int32?>]`: 
        - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[EscalationTimeInMinutes <Int32?>]`: 
        - `[IsApproverJustificationRequired <Boolean?>]`: 
        - `[IsEscalationEnabled <Boolean?>]`: 
        - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[IsApprovalRequired <Boolean?>]`: 
      - `[IsApprovalRequiredForExtension <Boolean?>]`: 
      - `[IsRequestorJustificationRequired <Boolean?>]`: 
    - `[RequestorSettings <IMicrosoftGraphRequestorSettings>]`: requestorSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcceptRequests <Boolean?>]`: 
      - `[AllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
      - `[ScopeType <String>]`: 
  - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
  - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
    - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[CatalogId <String>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsHidden <Boolean?>]`: 
  - `[IsRoleScopesVisible <Boolean?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

BODYPARAMETER <IMicrosoftGraphAccessPackageCatalog>: accessPackageCatalog
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsRootScope <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[RoleOriginId <String>]`: 
        - `[Url <String>]`: 
      - `[AddedBy <String>]`: 
      - `[AddedOn <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsPendingOnboarding <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[ResourceType <String>]`: 
      - `[Url <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
  - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
      - `[AccessPackageId <String>]`: 
      - `[AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>]`: assignmentReviewSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DurationInDays <Int32?>]`: 
        - `[IsEnabled <Boolean?>]`: 
        - `[RecurrenceType <String>]`: 
        - `[ReviewerType <String>]`: 
        - `[Reviewers <IMicrosoftGraphUserSet[]>]`: 
          - `[IsBackup <Boolean?>]`: 
        - `[StartDateTime <DateTime?>]`: 
      - `[CanExtend <Boolean?>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[DurationInDays <Int32?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]`: approvalSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ApprovalMode <String>]`: 
        - `[ApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
          - `[ApprovalStageTimeOutInDays <Int32?>]`: 
          - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
          - `[EscalationTimeInMinutes <Int32?>]`: 
          - `[IsApproverJustificationRequired <Boolean?>]`: 
          - `[IsEscalationEnabled <Boolean?>]`: 
          - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[IsApprovalRequired <Boolean?>]`: 
        - `[IsApprovalRequiredForExtension <Boolean?>]`: 
        - `[IsRequestorJustificationRequired <Boolean?>]`: 
      - `[RequestorSettings <IMicrosoftGraphRequestorSettings>]`: requestorSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AcceptRequests <Boolean?>]`: 
        - `[AllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
        - `[ScopeType <String>]`: 
    - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
      - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[CatalogId <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsHidden <Boolean?>]`: 
    - `[IsRoleScopesVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[CatalogStatus <String>]`: 
  - `[CatalogType <String>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsExternallyVisible <Boolean?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

INPUTOBJECT <IIdentityGovernanceIdentity>: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: key: id of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: key: id of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: key: id of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: key: id of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: key: id of accessPackageCatalog
  - `[AccessPackageId <String>]`: key: id of accessPackage
  - `[AccessPackageResourceId <String>]`: key: id of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: key: id of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: key: id of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: key: id of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: key: id of accessPackageResourceScope
  - `[AccessReviewDecisionId <String>]`: key: id of accessReviewDecision
  - `[AccessReviewId <String>]`: key: id of accessReview
  - `[AccessReviewId1 <String>]`: key: id of accessReview
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewReviewerId <String>]`: key: id of accessReviewReviewer
  - `[AccessReviewScheduleDefinitionId <String>]`: key: id of accessReviewScheduleDefinition
  - `[AgreementAcceptanceId <String>]`: key: id of agreementAcceptance
  - `[AgreementFileLocalizationId <String>]`: key: id of agreementFileLocalization
  - `[AgreementId <String>]`: key: id of agreement
  - `[BusinessFlowTemplateId <String>]`: key: id of businessFlowTemplate
  - `[ConnectedOrganizationId <String>]`: key: id of connectedOrganization
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[GovernanceResourceId <String>]`: key: id of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: key: id of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: key: id of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: key: id of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: key: id of governanceRoleSetting
  - `[PrivilegedAccessId <String>]`: key: id of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: key: id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: id of privilegedRole
  - `[ProgramControlId <String>]`: key: id of programControl
  - `[ProgramControlTypeId <String>]`: key: id of programControlType
  - `[ProgramId <String>]`: key: id of program
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

