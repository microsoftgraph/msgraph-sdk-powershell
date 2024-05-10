### Example 1: Default properties

```powershell

Import-Module Microsoft.Graph.Beta.Users.Functions

Get-MgBetaUserDelta

```
This example will default properties

### Example 2: Selecting three properties

```powershell

Import-Module Microsoft.Graph.Beta.Users.Functions

Get-MgBetaUserDelta -Property "displayName,jobTitle,mobilePhone" 

```
This example shows selecting three properties

### Example 3: Alternative minimal response behavior

```powershell

Import-Module Microsoft.Graph.Beta.Users.Functions

Get-MgBetaUserDelta -Property "displayName,jobTitle,mobilePhone" 

```
This example will alternative minimal response behavior

