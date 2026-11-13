### Example 1: Get a section

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkSection -UserId $userId -TeamworkSectionId $teamworkSectionId

```
This example will get a section

### Example 2: Get a user-defined section with items expanded

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkSection -UserId $userId -TeamworkSectionId $teamworkSectionId -ExpandProperty "items" 

```
This example will get a user-defined section with items expanded

### Example 3: Get a system-defined section with items expanded

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkSection -UserId $userId -TeamworkSectionId $teamworkSectionId -ExpandProperty "items" 

```
This example will get a system-defined section with items expanded

