### Example 1: Get the Reflect check-in responses from the last 24 hours

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportReflectCheck

```
This example will get the reflect check-in responses from the last 24 hours

### Example 2: Get the Reflect check-in responses for a specific date using $filter

```powershell

Import-Module Microsoft.Graph.Beta.Education

Get-MgBetaEducationReportReflectCheck -Filter "submitDateTime gt 2023-10-10T00:00:00.000Z" 

```
This example will get the reflect check-in responses for a specific date using $filter

