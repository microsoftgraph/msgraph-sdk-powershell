### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedEBookAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.allLicensedUsersAssignmentTarget"
	}
	installIntent = "required"
}

New-MgDeviceAppManagementManagedEBookAssignment -ManagedEBookId $managedEBookId -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementManagedEBookAssignment Cmdlet.

