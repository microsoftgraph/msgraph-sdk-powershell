### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	invoiceId = "G016907411"
	attributeSet = "full"
}

Export-MgReportPartnerBillingUsageBilled -BodyParameter $params

```
This example shows how to use the Export-MgReportPartnerBillingUsageBilled Cmdlet.

