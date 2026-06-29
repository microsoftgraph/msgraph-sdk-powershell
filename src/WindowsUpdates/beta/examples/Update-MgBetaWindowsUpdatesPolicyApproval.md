### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.policyApproval"
	catalogEntryId = "1d8864c1-531f-4d5b-8225-8653ef4316d8"
	status = "suspended"
}

Update-MgBetaWindowsUpdatesPolicyApproval -PolicyId $policyId -PolicyApprovalId $policyApprovalId -BodyParameter $params

```
This example shows how to use the Update-MgBetaWindowsUpdatesPolicyApproval Cmdlet.

