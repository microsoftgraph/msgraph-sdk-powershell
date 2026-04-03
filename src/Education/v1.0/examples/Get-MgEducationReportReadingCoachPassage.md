### Example 1: Get a list of the Reading Coach passages from the last 24 hours

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationReportReadingCoachPassage

```
This example will get a list of the reading coach passages from the last 24 hours

### Example 2: Get a list of the Reading Coach passages for a specific date using $filter

```powershell

Import-Module Microsoft.Graph.Education

Get-MgEducationReportReadingCoachPassage -Filter "practicedAtDateTime gt 2025-06-22T00:00:00Z and practicedAtDateTime lt 2025-06-23T00:00:00Z" 

```
This example will get a list of the reading coach passages for a specific date using $filter

