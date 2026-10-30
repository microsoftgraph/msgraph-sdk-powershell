### Example 1: List all entities that a user sponsors

```powershell

Import-Module Microsoft.Graph.Users

Get-MgUserSponsorOf -UserId $userId

```
This example will list all entities that a user sponsors

### Example 2: List all entities that a user sponsors, filtered by type

```powershell

Import-Module Microsoft.Graph.Users

Get-MgUserSponsorOf -UserId $userId -Filter "microsoft.graph.user/userType eq 'Guest'" 

```
This example will list all entities that a user sponsors, filtered by type

