### Example 1: Get all alerts

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityAlertV2

```
This example will get all alerts

### Example 2: Get all alerts from Microsoft Sentinel

```powershell

Import-Module Microsoft.Graph.Beta.Security

Get-MgBetaSecurityAlertV2 -Filter "serviceSource eq 'microsoftSentinel'" 

```
This example will get all alerts from microsoft sentinel

