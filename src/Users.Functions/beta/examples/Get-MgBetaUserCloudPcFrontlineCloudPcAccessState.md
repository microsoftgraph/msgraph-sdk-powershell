### Example 1: Get the frontline Cloud PC access state for the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Functions

# A UPN can also be used as -UserId.
Get-MgBetaUserCloudPcFrontlineCloudPcAccessState -UserId $userId -CloudPCId $cloudPCId

```
This example will get the frontline cloud pc access state for the signed-in user

