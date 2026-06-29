### Example 1: CSV output

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportMicrosoft365CopilotUserCountSummary -Format "text/csv"  -Period $periodId 

```
This example will csv output

### Example 2: JSON output

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportMicrosoft365CopilotUserCountSummary -Format "application/json"  -Period $periodId 

```
This example will json output

