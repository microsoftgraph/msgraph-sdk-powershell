### Example 1: Reboot the cloudPC for the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Restart-MgBetaUserCloudPc -UserId $userId -CloudPCId $cloudPCId

```
This example will reboot the cloudpc for the signed-in user

