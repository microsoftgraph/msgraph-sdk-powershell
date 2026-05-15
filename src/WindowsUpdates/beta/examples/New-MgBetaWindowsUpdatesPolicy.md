### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.qualityUpdatePolicy"
	displayName = "Patch Tuesday 123"
	description = "Testing Patch Tuesday in test environment"
	approvalRules = @(
		@{
			"@odata.type" = "microsoft.graph.windowsUpdates.qualityUpdateApprovalRule"
			deferralInDays = 0
			classification = "nonSecurity"
			cadence = "outOfBand"
		}
	)
}

New-MgBetaWindowsUpdatesPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaWindowsUpdatesPolicy Cmdlet.

