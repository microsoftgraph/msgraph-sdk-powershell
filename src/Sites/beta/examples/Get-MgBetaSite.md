### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSite -Property "siteCollection,webUrl" -Filter "siteCollection/root ne null" 

```
This example shows how to use the Get-MgBetaSite Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSite

```
This example shows how to use the Get-MgBetaSite Cmdlet.

