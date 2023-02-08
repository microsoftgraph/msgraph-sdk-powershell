### Example 1: Get all access package assignment requests

```powershell
Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest | Format-List

AccessPackage           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage
AccessPackageAssignment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignment
Answers                 : {}
CompletedDate           : 11/8/2021 10:21:35 AM
CreatedDateTime         : 11/8/2021 7:21:09 AM
ExpirationDateTime      :
Id                      : c82bc0cd-4fbc-4492-8c75-54c41dc74803
IsValidationOnly        : False
Justification           :
RequestState            : Delivered
RequestStatus           : FulfilledNotificationTriggered
RequestType             : UserAdd
Requestor               : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageSubject
Schedule                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
AdditionalProperties    : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackageAssignmentRequests/$entity]}
```

This example retrieves all access package assignment requests.

### Example 2: Get  access package assignment request using the request id

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId 'c82bc0cd-4fbc-4492-8c75-54c41dc74803'| Format-List

AccessPackage           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage
AccessPackageAssignment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageAssignment
Answers                 : {}
CompletedDate           : 11/8/2021 10:21:35 AM
CreatedDateTime         : 11/8/2021 7:21:09 AM
ExpirationDateTime      :
Id                      : c82bc0cd-4fbc-4492-8c75-54c41dc74803
IsValidationOnly        : False
Justification           :
RequestState            : Delivered
RequestStatus           : FulfilledNotificationTriggered
RequestType             : UserAdd
Requestor               : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageSubject
Schedule                : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestSchedule
AdditionalProperties    : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackageAssignmentRequests/$entity]}
```

This example returns the access package assignment request for the specified id.
