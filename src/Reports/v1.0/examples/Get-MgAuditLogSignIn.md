### Example 1: List all sign-ins during a specific time period

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogSignIn -Filter "createdDateTime ge 2024-07-01T00:00:00Z and createdDateTime le 2024-07-14T23:59:59Z" 

```
This example will list all sign-ins during a specific time period

### Example 2: Retrieve the first 10 sign-ins to apps with the appDisplayName that starts with 'Graph'

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogSignIn -Filter "startsWith(appDisplayName,'Graph')" -Top 10 

```
This example will retrieve the first 10 sign-ins to apps with the appdisplayname that starts with 'graph'

