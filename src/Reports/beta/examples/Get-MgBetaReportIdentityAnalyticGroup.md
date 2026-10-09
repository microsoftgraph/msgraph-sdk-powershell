### Example 1: Get a list of groupAnalytics objects

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportIdentityAnalyticGroup

```
This example will get a list of groupanalytics objects

### Example 2: Get valid groups that contain guests, with selected properties

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportIdentityAnalyticGroup -Filter "isValidGroup eq true and guestTransitiveUserCount gt 0" -Property "id,displayName,createdDateTime,groupType,transitiveUserCount,guestTransitiveUserCount" -Sort "createdDateTime desc" -Top 10 

```
This example will get valid groups that contain guests, with selected properties

