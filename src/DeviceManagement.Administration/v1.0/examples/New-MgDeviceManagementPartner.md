### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.deviceManagementPartner"
	lastHeartbeatDateTime = [System.DateTime]::Parse("2016-12-31T23:59:37.9174975-08:00")
	partnerState = "unavailable"
	partnerAppType = "singleTenantApp"
	singleTenantAppId = "Single Tenant App Id value"
	displayName = "Display Name value"
	isConfigured = $true
	whenPartnerDevicesWillBeRemovedDateTime = [System.DateTime]::Parse("2016-12-31T23:56:38.2655023-08:00")
	whenPartnerDevicesWillBeMarkedAsNonCompliantDateTime = [System.DateTime]::Parse("2016-12-31T23:58:42.2131231-08:00")
	groupsRequiringPartnerEnrollment = @(
		@{
			"@odata.type" = "microsoft.graph.deviceManagementPartnerAssignment"
			target = @{
				"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
				collectionId = "Collection Id value"
			}
		}
	)
}

New-MgDeviceManagementPartner -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementPartner Cmdlet.

