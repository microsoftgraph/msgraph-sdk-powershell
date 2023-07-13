### Example 1: Using the Set-MgBetaDeviceManagementManagedDeviceCloudPcReviewStatus Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	ReviewStatus = @{
		InReview = $true
		UserAccessLevel = "restricted"
		AzureStorageAccountId = "/subscriptions/f68bd846-16ad-4b51-a7c6-c84944a3367c/resourceGroups/Review/providers/Microsoft.Storage/storageAccounts/snapshotsUnderReview"
	}
}
Set-MgBetaDeviceManagementManagedDeviceCloudPcReviewStatus -ManagedDeviceId $managedDeviceId -BodyParameter $params
```
This example shows how to use the Set-MgBetaDeviceManagementManagedDeviceCloudPcReviewStatus Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
