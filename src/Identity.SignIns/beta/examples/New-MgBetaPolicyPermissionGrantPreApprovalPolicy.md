### Example 1: Create a preapproval policy for both group and chat scope

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	conditions = @(
		@{
			scopeType = "chat"
			sensitivityLabels = @{
				"@odata.type" = "#microsoft.graph.allScopeSensitivityLabels"
				labelKind = "all"
			}
			permissions = @{
				"@odata.type" = "#microsoft.graph.allPreApprovedPermissions"
				permissionKind = "all"
				permissionType = "application"
			}
		}
		@{
			scopeType = "group"
			scopeSensitivityLabels = @{
				"@odata.type" = "microsoft.graph.enumeratedScopeSensitivityLabels"
				labelKind = "enumerated"
				sensitivityLabels = @(
				"d9c43deb-f3e1-4422-9fd6-ccf22a3206b8"
			"c99dade2-aa54-4890-ac1c-a146fa26bd1e"
		)
	}
	permissions = @{
		"@odata.type" = "#microsoft.graph.enumeratedPreApprovedPermissions"
		permissionKind = "enumerated"
		permissionType = "application"
		resourceApplicationId = "00000003-0000-0000-c000-000000000000"
		permissionIds = @(
		"134483aa-3dda-4d65-ac91-b8dda1417875"
	"9d33613d-f855-483b-bca7-ea63ac9f5485"
)
}
}
)
}

New-MgBetaPolicyPermissionGrantPreApprovalPolicy -BodyParameter $params

```
This example will create a preapproval policy for both group and chat scope

### Example 2: Create a preapproval policy for group scope and preapprove all permissions from a given API

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	conditions = @(
		@{
			scopeType = "group"
			sensitivityLabels = @{
				"@odata.type" = "#microsoft.graph.allScopeSensitivityLabels"
				labelKind = "all"
			}
			permissions = @{
				"@odata.type" = "#microsoft.graph.allPermissionsOnResourceApp"
				permissionKind = "allPermissionsOnResourceApp"
				permissionType = "application"
				resourceApplicationId = "00000003-0000-0000-c000-000000000000"
			}
		}
	)
}

New-MgBetaPolicyPermissionGrantPreApprovalPolicy -BodyParameter $params

```
This example will create a preapproval policy for group scope and preapprove all permissions from a given api

