### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.contentApproval"
	content = @{
		"@odata.type" = "#microsoft.graph.windowsUpdates.catalogContent"
		catalogEntry = @{
			"@odata.type" = "#microsoft.graph.windowsUpdates.featureUpdateCatalogEntry"
			id = "6b7e60db-a8e4-426a-9aed-bd12b5c0b9d4"
		}
	}
	deploymentSettings = @{
	}
	schedule = @{
		startDateTime = "String (timestamp)"
		gradualRollout = @{
			"@odata.type" = "#microsoft.graph.windowsUpdates.dateDrivenRolloutSettings"
			endDateTime = "String (timestamp)"
		}
	}
}

New-MgBetaWindowsUpdatesPolicyComplianceChange -UpdatePolicyId $updatePolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaWindowsUpdatesPolicyComplianceChange Cmdlet.

