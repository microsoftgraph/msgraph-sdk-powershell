### Example 1: Get your own presence information

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserPresence -UserId $userId

```
This example will get your own presence information

### Example 2: Get the presence information of another user

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

Get-MgBetaUserPresence -UserId $userId

```
This example will get the presence information of another user

