### Example 1: Reprovision the cloudPC for the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Invoke-MgBetaReprovisionUserCloudPc -UserId $userId -CloudPCId $cloudPCId

```
This example will reprovision the cloudpc for the signed-in user

