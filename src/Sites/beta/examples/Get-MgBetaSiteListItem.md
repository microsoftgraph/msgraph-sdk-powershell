### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItem -SiteId $siteId -ListId $listId -ExpandProperty "fields(select=Name,Color,Quantity)" 

```
This example shows how to use the Get-MgBetaSiteListItem Cmdlet.

