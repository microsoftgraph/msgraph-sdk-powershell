### Example 1: Using the Get-MgBetaTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')" 
```
This example shows how to use the Get-MgBetaTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamworkTeamTemplate
```
This example shows how to use the Get-MgBetaTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')"  -OutFile $outFileId
```
This example shows how to use the Get-MgBetaTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')" 
```
This example shows how to use the Get-MgBetaTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
