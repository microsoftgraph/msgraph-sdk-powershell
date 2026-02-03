### Example 1: Get a list of the Reflect check-in responses from the last 24 hours

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationReportReflectCheck

```
This example will get a list of the reflect check-in responses from the last 24 hours

### Example 2: Get a list of the Reflect check-in responses for a specific date using $filter

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationReportReflectCheck -Filter "submitDateTime gt 2025-06-11T00:00:00.000Z and submitDateTime lt 2025-06-12T00:00:00Z" 

```
This example will get a list of the reflect check-in responses for a specific date using $filter

