### Example 1: Using the Get-MgTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')" 
```
This example shows how to use the Get-MgTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamworkTeamTemplate
```
This example shows how to use the Get-MgTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')"  -OutFile $outFileId
```
This example shows how to use the Get-MgTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgTeamworkTeamTemplate Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamworkTeamTemplate -ExpandProperty "definitions" -Filter "definitions/any(a:a/languageTag eq 'en-US')" 
```
This example shows how to use the Get-MgTeamworkTeamTemplate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
