### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	managedEBookAssignments = @(
		@{
			"@odata.type" = "#microsoft.graph.managedEBookAssignment"
			id = "ae8b0d27-0d27-ae8b-270d-8bae270d8bae"
			target = @{
				"@odata.type" = "microsoft.graph.allLicensedUsersAssignmentTarget"
			}
			installIntent = "required"
		}
	)
}

Set-MgDeviceAppManagementManagedEBook -ManagedEBookId $managedEBookId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceAppManagementManagedEBook Cmdlet.

