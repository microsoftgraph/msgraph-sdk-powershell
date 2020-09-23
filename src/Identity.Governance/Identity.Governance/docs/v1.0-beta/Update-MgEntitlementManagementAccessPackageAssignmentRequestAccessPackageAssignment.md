---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgentitlementmanagementaccesspackageassignmentrequestaccesspackageassignment
schema: 2.0.0
---

# Update-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignment

## SYNOPSIS
Update the navigation property accessPackageAssignment in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignment
 -AccessPackageAssignmentRequestId <String> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]
 [-AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]
 [-AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]
 [-AccessPackageId <String>] [-AdditionalProperties <Hashtable>] [-AssignmentPolicyId <String>]
 [-AssignmentState <String>] [-AssignmentStatus <String>] [-CatalogId <String>] [-ExpiredDateTime <DateTime>]
 [-Id <String>] [-IsExtended] [-Target <IMicrosoftGraphAccessPackageSubject>] [-TargetId <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignment
 -AccessPackageAssignmentRequestId <String> -BodyParameter <IMicrosoftGraphAccessPackageAssignment>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignment
 -InputObject <IIdentityGovernanceIdentity> -BodyParameter <IMicrosoftGraphAccessPackageAssignment>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEntitlementManagementAccessPackageAssignmentRequestAccessPackageAssignment
 -InputObject <IIdentityGovernanceIdentity> [-AccessPackage <IMicrosoftGraphAccessPackage>]
 [-AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]
 [-AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]
 [-AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]
 [-AccessPackageId <String>] [-AdditionalProperties <Hashtable>] [-AssignmentPolicyId <String>]
 [-AssignmentState <String>] [-AssignmentStatus <String>] [-CatalogId <String>] [-ExpiredDateTime <DateTime>]
 [-Id <String>] [-IsExtended] [-Target <IMicrosoftGraphAccessPackageSubject>] [-TargetId <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property accessPackageAssignment in identityGovernance

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

### -AccessPackage
accessPackage
To construct, see NOTES section for ACCESSPACKAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentPolicy
accessPackageAssignmentPolicy
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentRequestId
key: id of accessPackageAssignmentRequest

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

### -AccessPackageAssignmentRequests
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentResourceRoles
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTRESOURCEROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentResourceRole[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageId
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

### -AssignmentPolicyId
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

### -AssignmentState
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

### -AssignmentStatus
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

### -BodyParameter
accessPackageAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment
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
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpiredDateTime
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

### -IsExtended
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

### -Target
accessPackageSubject
To construct, see NOTES section for TARGET properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageSubject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetId
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGE <IMicrosoftGraphAccessPackage>: accessPackage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

ACCESSPACKAGEASSIGNMENTPOLICY <IMicrosoftGraphAccessPackageAssignmentPolicy>: accessPackageAssignmentPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
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

ACCESSPACKAGEASSIGNMENTREQUESTS <IMicrosoftGraphAccessPackageAssignmentRequest[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>]`: accessPackageAssignment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
      - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
      - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
      - `[AccessPackageSubject <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[AltSecId <String>]`: 
        - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[CreatedBy <String>]`: 
          - `[CreatedDateTime <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
            - `[Id <String>]`: Read-only.
            - `[DeletedDateTime <DateTime?>]`: 
          - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
          - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
          - `[ModifiedBy <String>]`: 
          - `[ModifiedDateTime <DateTime?>]`: 
        - `[ConnectedOrganizationId <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Email <String>]`: 
        - `[ObjectId <String>]`: 
        - `[OnPremisesSecurityIdentifier <String>]`: 
        - `[PrincipalName <String>]`: 
        - `[Type <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Status <String>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AssignmentPolicyId <String>]`: 
    - `[AssignmentState <String>]`: 
    - `[AssignmentStatus <String>]`: 
    - `[CatalogId <String>]`: 
    - `[ExpiredDateTime <DateTime?>]`: 
    - `[IsExtended <Boolean?>]`: 
    - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[TargetId <String>]`: 
  - `[CompletedDate <DateTime?>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[IsValidationOnly <Boolean?>]`: 
  - `[Justification <String>]`: 
  - `[RequestState <String>]`: 
  - `[RequestStatus <String>]`: 
  - `[RequestType <String>]`: 
  - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject

ACCESSPACKAGEASSIGNMENTRESOURCEROLES <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
    - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>]`: accessPackageAssignment
      - `[CompletedDate <DateTime?>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[IsValidationOnly <Boolean?>]`: 
      - `[Justification <String>]`: 
      - `[RequestState <String>]`: 
      - `[RequestStatus <String>]`: 
      - `[RequestType <String>]`: 
      - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[AltSecId <String>]`: 
        - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[CreatedBy <String>]`: 
          - `[CreatedDateTime <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
            - `[Id <String>]`: Read-only.
            - `[DeletedDateTime <DateTime?>]`: 
          - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
          - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
          - `[ModifiedBy <String>]`: 
          - `[ModifiedDateTime <DateTime?>]`: 
        - `[ConnectedOrganizationId <String>]`: 
        - `[DisplayName <String>]`: 
        - `[Email <String>]`: 
        - `[ObjectId <String>]`: 
        - `[OnPremisesSecurityIdentifier <String>]`: 
        - `[PrincipalName <String>]`: 
        - `[Type <String>]`: 
    - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AssignmentPolicyId <String>]`: 
    - `[AssignmentState <String>]`: 
    - `[AssignmentStatus <String>]`: 
    - `[CatalogId <String>]`: 
    - `[ExpiredDateTime <DateTime?>]`: 
    - `[IsExtended <Boolean?>]`: 
    - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[TargetId <String>]`: 
  - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
  - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
  - `[AccessPackageSubject <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Status <String>]`: 

BODYPARAMETER <IMicrosoftGraphAccessPackageAssignment>: accessPackageAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignment <IMicrosoftGraphAccessPackageAssignment>]`: accessPackageAssignment
    - `[CompletedDate <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsValidationOnly <Boolean?>]`: 
    - `[Justification <String>]`: 
    - `[RequestState <String>]`: 
    - `[RequestStatus <String>]`: 
    - `[RequestType <String>]`: 
    - `[Requestor <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AltSecId <String>]`: 
      - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[CreatedBy <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[DeletedDateTime <DateTime?>]`: 
        - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
        - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[ModifiedBy <String>]`: 
        - `[ModifiedDateTime <DateTime?>]`: 
      - `[ConnectedOrganizationId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Email <String>]`: 
      - `[ObjectId <String>]`: 
      - `[OnPremisesSecurityIdentifier <String>]`: 
      - `[PrincipalName <String>]`: 
      - `[Type <String>]`: 
  - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
    - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
    - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
    - `[AccessPackageSubject <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Status <String>]`: 
  - `[AccessPackageId <String>]`: 
  - `[AssignmentPolicyId <String>]`: 
  - `[AssignmentState <String>]`: 
  - `[AssignmentStatus <String>]`: 
  - `[CatalogId <String>]`: 
  - `[ExpiredDateTime <DateTime?>]`: 
  - `[IsExtended <Boolean?>]`: 
  - `[Target <IMicrosoftGraphAccessPackageSubject>]`: accessPackageSubject
  - `[TargetId <String>]`: 

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

TARGET <IMicrosoftGraphAccessPackageSubject>: accessPackageSubject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AltSecId <String>]`: 
  - `[ConnectedOrganization <IMicrosoftGraphConnectedOrganization>]`: connectedOrganization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[ExternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[IdentitySources <IMicrosoftGraphIdentitySource[]>]`: 
    - `[InternalSponsors <IMicrosoftGraphDirectoryObject[]>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[ConnectedOrganizationId <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[ObjectId <String>]`: 
  - `[OnPremisesSecurityIdentifier <String>]`: 
  - `[PrincipalName <String>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

