### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.auditEvent"
	displayName = "Display Name value"
	componentName = "Component Name value"
	actor = @{
		"@odata.type" = "microsoft.graph.auditActor"
		type = "Type value"
		auditActorType = "Audit Actor Type value"
		userPermissions = @(
		"User Permissions value"
	)
	applicationId = "Application Id value"
	applicationDisplayName = "Application Display Name value"
	userPrincipalName = "User Principal Name value"
	servicePrincipalName = "Service Principal Name value"
	ipAddress = "Ip Address value"
	userId = "User Id value"
}
activity = "Activity value"
activityDateTime = [System.DateTime]::Parse("2016-12-31T23:59:51.6363086-08:00")
activityType = "Activity Type value"
activityOperationType = "Activity Operation Type value"
activityResult = "Activity Result value"
correlationId = "52effe71-fe71-52ef-71fe-ef5271feef52"
resources = @(
	@{
		"@odata.type" = "microsoft.graph.auditResource"
		displayName = "Display Name value"
		modifiedProperties = @(
			@{
				"@odata.type" = "microsoft.graph.auditProperty"
				displayName = "Display Name value"
				oldValue = "Old Value value"
				newValue = "New Value value"
			}
		)
		type = "Type value"
		auditResourceType = "Audit Resource Type value"
		resourceId = "Resource Id value"
	}
)
category = "Category value"
}

New-MgDeviceManagementAuditEvent -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementAuditEvent Cmdlet.

