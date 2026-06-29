### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	displayName = "NewName"
	description = "A new roleAssignment"
}

Update-MgBetaRoleManagementCloudPcRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId -BodyParameter $params

```
This example shows how to use the Update-MgBetaRoleManagementCloudPcRoleAssignment Cmdlet.

