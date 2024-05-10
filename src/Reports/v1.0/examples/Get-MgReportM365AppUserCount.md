### Example 1: CSV output

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgReportM365AppUserCount -Format "text/csv"  -Period $periodId 

```
This example will csv output

### Example 2: JSON output

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgReportM365AppUserCount -Format "application/json"  -Period $periodId 

```
This example will json output

