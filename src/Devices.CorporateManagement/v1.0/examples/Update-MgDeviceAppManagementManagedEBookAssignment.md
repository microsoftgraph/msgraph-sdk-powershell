### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.iosVppEBookAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.deviceAndAppManagementAssignmentTarget"
	}
	installIntent = "required"
}

Update-MgDeviceAppManagementManagedEBookAssignment -ManagedEBookId $managedEBookId -ManagedEBookAssignmentId $managedEBookAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementManagedEBookAssignment Cmdlet.

