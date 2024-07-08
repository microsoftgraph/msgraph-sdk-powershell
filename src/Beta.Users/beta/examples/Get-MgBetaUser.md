### Example 1: Get the properties of the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUser -UserId $userId

```
This example will get the properties of the signed-in user

### Example 2: Get the properties of the specified user

```powershell

Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUser -UserId $userId

```
This example will get the properties of the specified user

### Example 3: Get the custom security attribute assignments for a user

```powershell

Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUser -UserId $userId -Property "customSecurityAttributes" 

```
This example will get the custom security attribute assignments for a user

### Example 4: Get the value of a schema extension for a user

```powershell

Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUser -UserId $userId -Property "ext55gb1l09_msLearnCourses" 

```
This example will get the value of a schema extension for a user

