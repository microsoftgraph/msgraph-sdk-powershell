### Example 1: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite -SiteId $siteId
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite -Search "{query}"  -OutFile $outFileId
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite -Search "{query}" 
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite -Property "siteCollection,webUrl" -Filter "siteCollection/root ne null" 
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Get-MgBetaSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSite -OutFile $outFileId
```
This example shows how to use the Get-MgBetaSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
