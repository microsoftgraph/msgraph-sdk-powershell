---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance/get-mgrolemanagemententitlementmanagementroleeligibilityschedulerequestappscope
schema: 2.0.0
---

# Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope

## SYNOPSIS
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

## SYNTAX

### Get (Default)
```
Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope
 -UnifiedRoleEligibilityScheduleRequestId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgRoleManagementEntitlementManagementRoleEligibilityScheduleRequestAppScope
 -InputObject <IIdentityGovernanceIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Read-only property with details of the app-specific scope when the role eligibility is scoped to an app.
Nullable.
Supports $expand.

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

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRoleEligibilityScheduleRequestId
The unique identifier of unifiedRoleEligibilityScheduleRequest

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppScope

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IIdentityGovernanceIdentity>`: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: The unique identifier of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: The unique identifier of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: The unique identifier of accessPackageAssignmentRequest
  - `[AccessPackageCatalogId <String>]`: The unique identifier of accessPackageCatalog
  - `[AccessPackageId <String>]`: The unique identifier of accessPackage
  - `[AccessPackageId1 <String>]`: The unique identifier of accessPackage
  - `[AccessPackageQuestionId <String>]`: The unique identifier of accessPackageQuestion
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
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[GroupId <String>]`: The unique identifier of group
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[On <String>]`: Usage: on='{on}'
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

## RELATED LINKS

