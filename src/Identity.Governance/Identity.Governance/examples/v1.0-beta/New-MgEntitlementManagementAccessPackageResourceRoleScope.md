### Example 1: Create a new access package resource role scope

```powershell
$accessPackageResource = @{
  "id"= '36d8d18f-b081-4867-acf5-4a8b893761e8'
  "resourceType" ='Security Group'
  "originId"= 'b5cd9d19-91c0-4622-93e2-537ad8a0b3ad'
  "originSystem"= 'AadGroup'
  }

$accessPackageResourceRole = @{
  "originId"= 'Member_b5cd9d19-91c0-4622-93e2-537ad8a0b3ad'
  "displayName" = 'Member'
  "originSystem" = 'AadGroup'
  "accessPackageResource" = $accessPackageResource
  }

$accessPackageResourceScope = @{
  "originId" = 'b5cd9d19-91c0-4622-93e2-537ad8a0b3ad'
  "originSystem" ='AadGroup'
  }

New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId '481927e3-c76b-447e-a97d-a944f694ce03' -AccessPackageResourceRole $accessPackageResourceRole -AccessPackageResourceScope $accessPackageResourceScope

Id                                                                        CreatedBy                         CreatedDateTime       ModifiedBy                        ModifiedDateTime
--                                                                        ---------                         ---------------       ----------                        ----------------
2d43636d-febe-4f58-9dbf-ef1c3b9798d9_2386db28-94fc-45ce-b4bd-56188da884fe admin@M365x814237.onmicrosoft.com 10/26/2021 8:42:44 AM admin@M365x814237.onmicrosoft.com 10/26/2021 8:42:44 AM
```

This example, the commands;
1. Defines a resource variable 
1. Defines the resource role variable
1. Defines the resource scope variable
1. Create a new access package resource role scope.