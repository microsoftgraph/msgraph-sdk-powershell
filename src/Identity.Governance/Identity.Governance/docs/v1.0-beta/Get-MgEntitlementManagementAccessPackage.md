---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/get-mgentitlementmanagementaccesspackage
schema: 2.0.0
---

# Get-MgEntitlementManagementAccessPackage

## SYNOPSIS
Get accessPackages from identityGovernance

## SYNTAX

### ListAll (Default)
```
Get-MgEntitlementManagementAccessPackage [-ExpandProperty <String[]>] [-Property <String[]>]
 [-Sort <String[]>] [-All] [<CommonParameters>]
```

### Get
```
Get-MgEntitlementManagementAccessPackage -AccessPackageId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgEntitlementManagementAccessPackage -InputObject <IIdentityGovernanceIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### List
```
Get-MgEntitlementManagementAccessPackage [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### ListByCatalogId
```
Get-MgEntitlementManagementAccessPackage -CatalogId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [-Sort <String[]>] [-Top <Int32>] [-All] [<CommonParameters>]
```

### ListByDisplayNameContains
```
Get-MgEntitlementManagementAccessPackage -DisplayNameContains <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [-Sort <String[]>] [-Top <Int32>] [-All] [<CommonParameters>]
```

### ListByDisplayNameEq
```
Get-MgEntitlementManagementAccessPackage -DisplayNameEq <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [-Sort <String[]>] [-Top <Int32>] [-All] [<CommonParameters>]
```

## DESCRIPTION
Get accessPackages from identityGovernance

## EXAMPLES

### Example 1: Get a list of all access packages
```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackage | Format-List

AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 11/5/2021 8:03:39 AM
Description                     :
DisplayName                     : Marketing Campaign
Id                              : bc041fda-b3ba-41fc-b911-ca95f7aac656
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 11/5/2021 9:08:44 AM
AdditionalProperties            : {}

AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 9/15/2021 7:23:44 AM
Description                     : Access for Sales and Marketing users and guests
DisplayName                     : Sales and Marketing
Id                              : b90cbf24-66b9-4cd8-b270-863b6fca641c
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 9/15/2021 7:23:44 AM
AdditionalProperties            : {}
```

This examples returns all access packages.

### Example 2: Get access package by Id
```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgEntitlementManagementAccessPackage -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656'| Format-List


AccessPackageAssignmentPolicies :
AccessPackageCatalog            : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageResourceRoleScopes :
AccessPackagesIncompatibleWith  :
CatalogId                       : 54152ecb-c65d-47f2-8a4d-ba2732de0a7b
CreatedBy                       : admin@M365x814237.onmicrosoft.com
CreatedDateTime                 : 11/5/2021 8:03:39 AM
Description                     :
DisplayName                     : Marketing Campaign
Id                              : bc041fda-b3ba-41fc-b911-ca95f7aac656
IncompatibleAccessPackages      :
IncompatibleGroups              :
IsHidden                        : False
IsRoleScopesVisible             : False
ModifiedBy                      : admin@M365x814237.onmicrosoft.com
ModifiedDateTime                : 11/5/2021 9:08:44 AM
AdditionalProperties            : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackages/$entity]}

```

This example returns the access package of the specified id.

## PARAMETERS

### -AccessPackageId
key: id of accessPackage

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

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, ListAll, ListByCatalogId, ListByDisplayNameContains, ListByDisplayNameEq
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CatalogId
Filter items by property values

```yaml
Type: System.String
Parameter Sets: ListByCatalogId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayNameContains
Filter items by property values

```yaml
Type: System.String
Parameter Sets: ListByDisplayNameContains
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayNameEq
Filter items by property values

```yaml
Type: System.String
Parameter Sets: ListByDisplayNameEq
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List, ListAll, ListByCatalogId, ListByDisplayNameContains, ListByDisplayNameEq
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List, ListByCatalogId, ListByDisplayNameContains, ListByDisplayNameEq
Aliases: Limit

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

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

## RELATED LINKS

