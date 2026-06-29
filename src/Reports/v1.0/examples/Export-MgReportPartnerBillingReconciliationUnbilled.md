### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	attributeSet = "full"
	billingPeriod = "current"
	currencyCode = "USD"
}

Export-MgReportPartnerBillingReconciliationUnbilled -BodyParameter $params

```
This example shows how to use the Export-MgReportPartnerBillingReconciliationUnbilled Cmdlet.

