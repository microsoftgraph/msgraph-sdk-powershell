### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	currencyCode = "USD"
	attributeSet = "full"
	billingPeriod = "current"
}

Export-MgBetaReportPartnerBillingReconciliationUnbilled -BodyParameter $params

```
This example shows how to use the Export-MgBetaReportPartnerBillingReconciliationUnbilled Cmdlet.

