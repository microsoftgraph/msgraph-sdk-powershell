### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	managedDeviceIds = @(
	"30d0e128-de93-41dc-89ec-33d84bb662a0"
"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
)
reviewStatus = @{
inReview = $true
userAccessLevel = "restricted"
azureStorageAccountId = "/subscriptions/f68bd846-16ad-4b51-a7c6-c84944a3367c/resourceGroups/Review/providers/Microsoft.Storage/storageAccounts/snapshotsUnderReview"
}
}

Invoke-MgBetaBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaBulkDeviceManagementManagedDeviceSetCloudPcReviewStatus Cmdlet.

