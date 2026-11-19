### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	displayConcealedNames = $true
}

Update-MgAdminReportSetting -BodyParameter $params

```
This example shows how to use the Update-MgAdminReportSetting Cmdlet.

