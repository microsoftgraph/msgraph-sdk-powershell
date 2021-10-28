### Example 1: Get all access package assignment requests

```powershell
Get-MgEntitlementManagementAccessPackageAssignmentRequest | Format-List

AccessPackage           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage
AccessPackageAssignment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignment
Answers                 : {}
CompletedDate           :
CreatedDateTime         : 10/28/2021 3:04:35 PM
ExpirationDateTime      :
Id                      : dff2f012-b65a-4b52-bd21-e48a4d876238
IsValidationOnly        : False
Justification           :
RequestState            : Scheduled
RequestStatus           : PendingNotBefore
RequestType             : AdminAdd
Requestor               : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageSubject
Schedule                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
AdditionalProperties    : {}
```

This example retrieves all access package assignment requests.

### Example 2: Get  access package assignment request using the request id

```powershell
Get-MgEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId 'e89ee9a5-670e-4306-95fa-8a5b58024f5b'

Id                                   CompletedDate CreatedDateTime       ExpirationDateTime IsValidationOnly Justification RequestState RequestStatus    RequestType
--                                   ------------- ---------------       ------------------ ---------------- ------------- ------------ -------------    -----------
e89ee9a5-670e-4306-95fa-8a5b58024f5b               10/28/2021 3:35:30 PM                    False                          Scheduled    PendingNotBefore UserAdd
```

This example returns the acess package assignment request for the specified id.