### Example 1: Get tenant-level summary

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportMicrosoftAppFileStorageContainerUsageSummary

```
This example will get tenant-level summary

### Example 2: Get tenant and geo-level breakdown

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportMicrosoftAppFileStorageContainerUsageSummary -ExpandProperty "usageByDataLocation" 

```
This example will get tenant and geo-level breakdown

### Example 3: Get full hierarchy with app-level breakdown

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportMicrosoftAppFileStorageContainerUsageSummary -ExpandProperty "usageByDataLocation(`$expand=usageByApp)" 

```
This example will get full hierarchy with app-level breakdown

