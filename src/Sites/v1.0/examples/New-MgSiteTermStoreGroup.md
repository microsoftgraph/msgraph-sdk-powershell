### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	displayName = "myGroup"
}

New-MgSiteTermStoreGroup -SiteId $siteId -BodyParameter $params

```
This example shows how to use the New-MgSiteTermStoreGroup Cmdlet.

