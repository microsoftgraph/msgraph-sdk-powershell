### Example 1: List all sign-ins

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaAuditLogSignIn

```
This example will list all sign-ins

### Example 2: Retrieve the first 10 sign-ins to apps with the appDisplayName that starts with 'Azure'

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaAuditLogSignIn -Filter "startsWith(appDisplayName,'Azure')" -Top 10 

```
This example will retrieve the first 10 sign-ins to apps with the appdisplayname that starts with 'azure'

### Example 3: Retrieve the first 10 sign-ins where the signInEventType is not interactiveUser starting with the latest sign-in

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaAuditLogSignIn -Filter "(signInEventTypes/any(t: t ne 'interactiveUser'))" -Sort "createdDateTime DESC" -Top 10 

```
This example will retrieve the first 10 sign-ins where the signineventtype is not interactiveuser starting with the latest sign-in

