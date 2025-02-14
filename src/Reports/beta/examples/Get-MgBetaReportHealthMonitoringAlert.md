### Example 1: Get all alerts

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportHealthMonitoringAlert

```
This example will get all alerts

### Example 2: Get all active alerts

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportHealthMonitoringAlert -Filter "state eq microsoft.graph.healthmonitoring.alertState'active'" -Property "id, alertType" 

```
This example will get all active alerts

### Example 3: List the state of all alerts in a specific time range

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportHealthMonitoringAlert -Filter "createdDateTime gt 2024-06-10T11:23:44Z" -Property "id, alertType, createdDateTime, state" 

```
This example will list the state of all alerts in a specific time range

### Example 4: Use $expand to get all alerts with directory object resource sampling

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportHealthMonitoringAlert -ExpandProperty "enrichment/impacts/microsoft.graph.healthmonitoring.directoryobjectimpactsummary/resourceSampling" -Property "alertType, createdDateTime, enrichment'" 

```
This example will use $expand to get all alerts with directory object resource sampling

