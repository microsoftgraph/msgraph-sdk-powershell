### Example 1: Create an access package policy

```powershell
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

New-MgEntitlementManagementAccessPackageAssignmentPolicy -AccessPackageId '481927e3-c76b-447e-a97d-a944f694ce03' -DisplayName 'Specific users' -Description 'Specific users can request assignment'  -DurationInDays 30 -RequestorSettings $requestorSettings -RequestApprovalSettings $requestApprovalSettings

Id                                   AccessPackageId                      CanExtend CreatedBy                         CreatedDateTime       Description                           DisplayName    DurationInDays ExpirationDate
                                                                                                                                                                                                                Time
--                                   ---------------                      --------- ---------                         ---------------       -----------                           -----------    -------------- --------------
66eb5245-7de2-471d-a545-0528353193a4 481927e3-c76b-447e-a97d-a944f694ce03 False     admin@M365x814237.onmicrosoft.com 10/28/2021 2:20:42 PM Specific users can request assignment Specific users 30
```

This example shows a request to create an access package assignment policy. In this policy, no users can request, no approval is required, and there are no access reviews.

