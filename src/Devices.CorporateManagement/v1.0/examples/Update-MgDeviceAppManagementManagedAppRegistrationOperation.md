### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedAppOperation"
	displayName = "Display Name value"
	state = "State value"
	version = "Version value"
}

Update-MgDeviceAppManagementManagedAppRegistrationOperation -ManagedAppRegistrationId $managedAppRegistrationId -ManagedAppOperationId $managedAppOperationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementManagedAppRegistrationOperation Cmdlet.

