### Example 1: Get an Outlook task

```powershell

Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId

```
This example will get an outlook task

### Example 2: Get Outlook task with date-time properties in Pacific Standard Time

```powershell

Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUserOutlookTask -UserId $userId -OutlookTaskId $outlookTaskId

```
This example will get outlook task with date-time properties in pacific standard time

