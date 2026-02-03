### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.context" = "https://graph.microsoft.com/beta/$metadata#policies/permissionGrantPreApprovalPolicies/$entity"
	id = "71ba13dc-5947-4e59-bcc5-0ad5c339a853"
	deletedDateTime = $null
	conditions = @(
		@{
			scopeType = "chat"
			sensitivityLabels = @{
				"@odata.type" = "#microsoft.graph.enumeratedScopeSensitivityLabels"
				labelKind = "enumerated"
				sensitivityLabels = @(
				"d9c43deb-f3e1-4422-9fd6-ccf22a3206b8"
			)
		}
		permissions = @{
			"@odata.type" = "#microsoft.graph.allPreApprovedPermissions"
			permissionKind = "all"
			permissionType = "application"
		}
	}
	@{
		scopeType = "group"
		sensitivityLabels = @{
			"@odata.type" = "#microsoft.graph.allScopeSensitivityLabels"
			labelKind = "all"
		}
		permissions = @{
			"@odata.type" = "#microsoft.graph.enumeratedPreApprovedPermissions"
			permissionKind = "enumerated"
			resourceApplicationId = "00000003-0000-0000-c000-000000000000"
			permissionIds = @(
			"134483aa-3dda-4d65-ac91-b8dda1417875"
		"9d33613d-f855-483b-bca7-ea63ac9f5485"
	)
	permissionType = "application"
}
}
)
}

Update-MgBetaPolicyPermissionGrantPreApprovalPolicy -PermissionGrantPreApprovalPolicyId $permissionGrantPreApprovalPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyPermissionGrantPreApprovalPolicy Cmdlet.

