### Example 1: Retrieve the status of a password authentication method reset operation.

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaUserAuthenticationOperation -UserId $userId -LongRunningOperationId $longRunningOperationId

```
This example will retrieve the status of a password authentication method reset operation.

