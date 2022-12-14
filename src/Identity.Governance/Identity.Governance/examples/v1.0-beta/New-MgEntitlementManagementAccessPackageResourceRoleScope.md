### Example 1: Create a new access package resource role scope

```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
$accessPackageResource = @{
  "id"= '4f5dac35-b025-4131-a27f-6e0e46d48dd1'
  "resourceType" ='Security Group'
  "originId"= '8902df17-a973-438f-8321-8b619aa18dc4'
  "originSystem"= 'AadGroup'
  }

$accessPackageResourceRole = @{
  "originId"= 'Member_8902df17-a973-438f-8321-8b619aa18dc4'
  "displayName" = 'Member'
  "originSystem" = 'AadGroup'
  "accessPackageResource" = $accessPackageResource
  }

$accessPackageResourceScope = @{
  "originId" = '8902df17-a973-438f-8321-8b619aa18dc4'
  "originSystem" ='AadGroup'
  }

New-MgBetaEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId 'bc041fda-b3ba-41fc-b911-ca95f7aac656' -AccessPackageResourceRole $accessPackageResourceRole -AccessPackageResourceScope $accessPackageResourceScope
```

```Output
AccessPackageResourceRole  : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceRole
AccessPackageResourceScope : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceScope
CreatedBy                  : admin@M365x814237.onmicrosoft.com
CreatedDateTime            : 11/5/2021 9:06:32 AM
Id                         : 3c955d0f-f6d5-45f0-b465-e8e6375a3895_5fef70e1-b78f-4d21-a6ad-979d9f54daf1
ModifiedBy                 : admin@M365x814237.onmicrosoft.com
ModifiedDateTime           : 11/5/2021 9:06:32 AM
AdditionalProperties       : {[@odata.context, https://graph.microsoft.com/beta/$metadata#identityGovernance/entitlementManagement/accessPackages('bc041fda-b3ba-41fc-b911-ca95f7aa
                             c656')/accessPackageResourceRoleScopes/$entity]}
```

This example, the commands;
1. Defines a resource variable. **Id** in the $accesspackageresource variable is the identifier of the group catalog resource.
1. Defines the resource role variable
1. Defines the resource scope variable
1. Create a new access package resource role scope.
