### Example 1: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminAdd"
	Assignment = @{
		TargetId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
		AssignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		AccessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminAdd"
	Assignment = @{
		TargetId = "46184453-e63b-4f20-86c2-c557ed5d5df9"
		AssignmentPolicyId = "2264bf65-76ba-417b-a27d-54d291f0cbc8"
		AccessPackageId = "a914b616-e04e-476b-aa37-91038f0b165b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "AdminRemove"
	Assignment = @{
		Id = "a6bb6942-3ae1-4259-9908-0133aaee9377"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "userAdd"
	Assignment = @{
		AccessPackageId = "d7be3253-b9c6-4fab-adef-30d30de8da2b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgEntitlementManagementAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RequestType = "userAdd"
	Assignment = @{
		AccessPackageId = "d7be3253-b9c6-4fab-adef-30d30de8da2b"
	}
}
New-MgEntitlementManagementAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
