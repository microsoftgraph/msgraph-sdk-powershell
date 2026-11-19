### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.qualityUpdatePolicy"
	displayName = "Patch Tuesday Test"
	description = "Quality update policy to test upcoming Patch Tuesday updates"
	approvalRules = @(
		@{
			"@odata.type" = "microsoft.graph.windowsUpdates.qualityUpdateApprovalRule"
			deferralInDays = 0
			classification = "nonSecurity"
			cadence = "outOfBand"
		}
	)
}

Update-MgBetaWindowsUpdatesPolicy -PolicyId $policyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesPolicy Cmdlet.

