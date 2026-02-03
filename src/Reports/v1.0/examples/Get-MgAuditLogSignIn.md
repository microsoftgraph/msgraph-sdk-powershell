### Example 1: List all sign-ins

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogSignIn

```
This example will list all sign-ins

### Example 2: Retrieve the first 10 sign-ins to apps with the appDisplayName that starts with 'Graph'

```powershell

Import-Module Microsoft.Graph.Reports

Get-MgAuditLogSignIn -Filter "startsWith(appDisplayName,'Graph')" -Top 10 

```
This example will retrieve the first 10 sign-ins to apps with the appdisplayname that starts with 'graph'

