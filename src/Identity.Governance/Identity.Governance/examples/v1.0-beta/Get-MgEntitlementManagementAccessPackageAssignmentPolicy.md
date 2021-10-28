### Example 1: Get all access package policy assignment policies

```powershell
Get-MgEntitlementManagementAccessPackageAssignmentPolicy | Format-List

AccessPackage           : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackage
AccessPackageCatalog    : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog
AccessPackageId         : b90cbf24-66b9-4cd8-b270-863b6fca641c
AccessReviewSettings    : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAssignmentReviewSettings
CanExtend               : False
CreatedBy               : admin@M365x814237.onmicrosoft.com
CreatedDateTime         : 9/15/2021 7:23:44 AM
Description             : Initial Policy
DisplayName             : Initial Policy
DurationInDays          : 365
ExpirationDateTime      :
Id                      : 138874b9-326b-4e77-826b-6ac08a130938
ModifiedBy              : admin@M365x814237.onmicrosoft.com
ModifiedDateTime        : 9/15/2021 7:23:44 AM
Questions               : {}
RequestApprovalSettings : Microsoft.Graph.PowerShell.Models.MicrosoftGraphApprovalSettings
RequestorSettings       : Microsoft.Graph.PowerShell.Models.MicrosoftGraphRequestorSettings
AdditionalProperties    : {}
```

This example gets a list of all the access package assignment policies.
