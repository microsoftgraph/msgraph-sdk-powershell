### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	currencyCode = "USD"
	attributeSet = "full"
	billingPeriod = "current"
}

Export-MgReportPartnerBillingUsageUnbilled -BodyParameter $params

```
This example shows how to use the Export-MgReportPartnerBillingUsageUnbilled Cmdlet.

