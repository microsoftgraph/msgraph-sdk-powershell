### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	invoiceId = "G016907411"
	attributeSet = "full"
}

Export-MgBetaReportPartnerBillingUsageBilled -BodyParameter $params

```
This example shows how to use the Export-MgBetaReportPartnerBillingUsageBilled Cmdlet.

