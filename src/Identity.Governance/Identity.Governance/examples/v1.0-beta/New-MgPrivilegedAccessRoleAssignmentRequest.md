### Example 1: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "ea48ad5e-e3b0-4d10-af54-39a45bbfe68d"
	ResourceId = "e5e7d29d-5465-45ac-885f-4716a5ee74b5"
	SubjectId = "918e54be-12c4-4f4c-a6d3-2ee0e3661c51"
	AssignmentState = "Eligible"
	Type = "AdminAdd"
	Reason = "Assign an eligible role"
	Schedule = @{
		StartDateTime = [System.DateTime]::Parse("2018-05-12T23:37:43.356Z")
		EndDateTime = [System.DateTime]::Parse("2018-11-08T23:37:43.356Z")
		Type = "Once"
	}
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "8b4d1d51-08e9-4254-b0a6-b16177aae376"
	ResourceId = "e5e7d29d-5465-45ac-885f-4716a5ee74b5"
	SubjectId = "918e54be-12c4-4f4c-a6d3-2ee0e3661c51"
	AssignmentState = "Active"
	Type = "UserAdd"
	Reason = "Activate the owner role"
	Schedule = @{
		Type = "Once"
		StartDateTime = [System.DateTime]::Parse("2018-05-12T23:28:43.537Z")
		Duration = "PT9H"
	}
	LinkedEligibleRoleAssignmentId = "e327f4be-42a0-47a2-8579-0a39b025b394"
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "bc75b4e6-7403-4243-bf2f-d1f6990be122"
	ResourceId = "fb016e3a-c3ed-4d9d-96b6-a54cd4f0b735"
	SubjectId = "918e54be-12c4-4f4c-a6d3-2ee0e3661c51"
	AssignmentState = "Active"
	Type = "UserRemove"
	Reason = "Deactivate the role"
	LinkedEligibleRoleAssignmentId = "cb8a533e-02d5-42ad-8499-916b1e4822ec"
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "65bb4622-61f5-4f25-9d75-d0e20cf92019"
	ResourceId = "e5e7d29d-5465-45ac-885f-4716a5ee74b5"
	SubjectId = "74765671-9ca4-40d7-9e36-2f4a570608a6"
	AssignmentState = "Eligible"
	Type = "AdminRemove"
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "70521f3e-3b95-4e51-b4d2-a2f485b02103"
	ResourceId = "e5e7d29d-5465-45ac-885f-4716a5ee74b5"
	SubjectId = "1566d11d-d2b6-444a-a8de-28698682c445"
	AssignmentState = "Eligible"
	Type = "AdminUpdate"
	Schedule = @{
		Type = "Once"
		StartDateTime = [System.DateTime]::Parse("2018-03-08T05:42:45.317Z")
		EndDateTime = [System.DateTime]::Parse("2018-06-05T05:42:31.000Z")
	}
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	RoleDefinitionId = "0e88fd18-50f5-4ee1-9104-01c3ed910065"
	ResourceId = "e5e7d29d-5465-45ac-885f-4716a5ee74b5"
	SubjectId = "74765671-9ca4-40d7-9e36-2f4a570608a6"
	AssignmentState = "Eligible"
	Type = "AdminExtend"
	Reason = "extend role assignment"
	Schedule = @{
		Type = "Once"
		StartDateTime = [System.DateTime]::Parse("2018-05-12T23:53:55.327Z")
		EndDateTime = [System.DateTime]::Parse("2018-08-10T23:53:55.327Z")
	}
}
New-MgPrivilegedAccessRoleAssignmentRequest -PrivilegedAccessId $privilegedAccessId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedAccessRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
