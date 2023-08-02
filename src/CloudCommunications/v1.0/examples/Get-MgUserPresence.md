### Example 1: Get your own presence information

```powershell

Import-Module Microsoft.Graph.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgUserPresence -UserId $userId

```
This example will get your own presence information

### Example 2: Get the presence information of another user

```powershell

Import-Module Microsoft.Graph.CloudCommunications

Get-MgUserPresence -UserId $userId

```
This example will get the presence information of another user

