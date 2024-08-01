### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.contentApproval"
	isRevoked = $true
}

Update-MgBetaWindowsUpdatesPolicyComplianceChange -UpdatePolicyId $updatePolicyId -ComplianceChangeId $complianceChangeId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesPolicyComplianceChange Cmdlet.

