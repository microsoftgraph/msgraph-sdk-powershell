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

New-MgDeviceAppManagementManagedEBookAssignment -ManagedEBookId $managedEBookId -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementManagedEBookAssignment Cmdlet.

