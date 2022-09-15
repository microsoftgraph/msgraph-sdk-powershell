### Example 1: Create an access package 

```powershell
$params = @{
DisplayName = "Marketing Campaign"
Description = "Marketing Campaign"
IsHidden = $false
Catalog = @{
Id = "88d3e491-5247-4209-9b56-c4c95d9694e9"
}
 }
New-MgEntitlementManagementAccessPackage -BodyParameter $params

AssignmentPolicies   :
Catalog              : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageCatalog1
CreatedDateTime      : 9/15/2022 9:48:28 AM
Description          : Marketing Campaign
DisplayName          : Marketing Campaign
Id                   : fd6ec077-e933-418f-9b6f-df88a54f9eee
IsHidden             : False
ModifiedDateTime     : 9/15/2022 9:48:28 AM
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#identityGovernance/entitlementManagement/accessPackages/$entity]}
```

This example creates an access package with he defined display name under the specified catalog.
