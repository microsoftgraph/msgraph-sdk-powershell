### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.qualityUpdateRing"
	displayName = "Test Policy 123"
	description = "Pre-production test policy"
	deferralInDays = 5
	isPaused = $true
	isHotpatchEnabled = $true
}

Update-MgBetaWindowsUpdatesPolicyRing -PolicyId $policyId -RingId $ringId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesPolicyRing Cmdlet.

