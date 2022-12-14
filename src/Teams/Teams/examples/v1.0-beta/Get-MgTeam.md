### Example 1: Using the Get-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeam -TeamId $teamId
```
This example shows how to use the Get-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeam -Filter "displayName eq 'A Contoso Team'" -Property "id,description" 
```
This example shows how to use the Get-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeam -Filter "startswith(displayName, 'A')" -Top 2 
```
This example shows how to use the Get-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeam
```
This example shows how to use the Get-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaTeam Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeam -Filter "displayName eq 'A Contoso Team'" -Property "id,description"  -OutFile $outFileId
```
This example shows how to use the Get-MgBetaTeam Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
