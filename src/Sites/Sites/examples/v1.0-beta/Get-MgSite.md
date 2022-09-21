### Example 1: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -SiteId $siteId
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}"  -OutFile $outFileId
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}" 
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -Property "siteCollection,webUrl" -Filter "siteCollection/root ne null" 
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Get-MgSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -OutFile $outFileId
```
This example shows how to use the Get-MgSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
