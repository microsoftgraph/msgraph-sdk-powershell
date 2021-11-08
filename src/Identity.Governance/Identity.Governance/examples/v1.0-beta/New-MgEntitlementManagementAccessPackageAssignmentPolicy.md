### Example 1: Create an access package policy

```powershell
$allowedRequestors = @(@{
  "@odata.type" = '#microsoft.graph.singleUser'
  "isBackup" = $false
  "id"= 'e4ef0e03-e149-4cbc-8f56-27bb22171a64'
  "description" = 'Requestor1'
  })

$requestorSettings =@{
  "scopeType" = 'SpecificDirectorySubjects'
  "acceptRequests" = $true
  "allowedRequestors" = $allowedRequestors
  }

$requestApprovalSettings = @{
  "isApprovalRequired" = $false
  "isApprovalRequiredForExtension" =$false
  "isRequestorJustificationRequired"= $false
  "approvalMode"= 'NoApproval'
  "approvalStages"= '[]'
  }

New-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656' -DisplayName 'Specific users' -Description 'Specific users can request assignment'  -DurationInDays 30 -RequestorSettings $requestorSettings -RequestApprovalSettings $requestApprovalSettings

AccessPackage           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage
AccessPackageCatalog    : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageId         : bc041fda-b3ba-41fc-b911-ca95f7aac656
AccessReviewSettings    : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAssignmentReviewSettings
CanExtend               : False
CreatedBy               : admin@M365x814237.onmicrosoft.com
CreatedDateTime         : 11/8/2021 7:16:07 AM
Description             : Specific users can request assignment
DisplayName             : Specific users
DurationInDays          : 30
ExpirationDateTime      :
Id                      : f134999f-8a59-49bb-b3a9-e8365d6fff94
ModifiedBy              : admin@M365x814237.onmicrosoft.com
ModifiedDateTime        : 11/8/2021 7:16:07 AM
Questions               : {}
RequestApprovalSettings : Microsoft.Graph.PowerShell.Models.MicrosoftGraphApprovalSettings
RequestorSettings       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestorSettings
AdditionalProperties    : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackageAssignmentPolicies/$entity]}
```

This example shows a request to create an access package assignment policy. In this policy no approval is required, and there are no access reviews.

