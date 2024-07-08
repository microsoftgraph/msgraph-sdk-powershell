### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	currencyCode = "USD"
	attributeSet = "full"
	billingPeriod = "current"
}

Export-MgBetaReportPartnerBillingUsageUnbilled -BodyParameter $params

```
This example shows how to use the Export-MgBetaReportPartnerBillingUsageUnbilled Cmdlet.

