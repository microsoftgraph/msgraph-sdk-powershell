### Example 1: Using the Update-MgRoleManagementCloudPcRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	DisplayName = "NewName"
	Description = "A new roleAssignment"
}
Update-MgRoleManagementCloudPcRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId -BodyParameter $params
```
This example shows how to use the Update-MgRoleManagementCloudPcRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
