### Example 1: GET a user's profile

```powershell

Import-Module Microsoft.Graph.Beta.People

# A UPN can also be used as -UserId.
Get-MgBetaUserProfile -UserId $userId

```
This example will get a user's profile

### Example 2: Expand names and skills collection and select properties within the entities

```powershell

Import-Module Microsoft.Graph.Beta.People

# A UPN can also be used as -UserId.
Get-MgBetaUserProfile -UserId $userId -ExpandProperty "names(`$select=first,last),skills(`$select=displayName)" 

```
This example will expand names and skills collection and select properties within the entities

