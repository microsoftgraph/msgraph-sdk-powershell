### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Reports

$params = @{
	displayConcealedNames = $true
}

Update-MgBetaAdminReportSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminReportSetting Cmdlet.

