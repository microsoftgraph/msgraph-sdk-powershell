### Example 1: Get the list of applications

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplication

```
This example will get the list of applications

### Example 2: Use $filter and $top to get one application with a display name that starts with 'a' including a count of returned objects

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplication -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName"  -ConsistencyLevel eventual 


```
This example will use $filter and $top to get one application with a display name that starts with 'a' including a count of returned objects

### Example 3: Use $search to get applications with display names that contain the letters 'Web' including a count of returned objects

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplication -Search '"displayName:Web"' -CountVariable CountVar -Property "appId,identifierUris,displayName,publisherDomain,signInAudience"  -ConsistencyLevel eventual 


```
This example will use $search to get applications with display names that contain the letters 'web' including a count of returned objects

### Example 4: Get applications with less than two owners

```powershell

Import-Module Microsoft.Graph.Applications

Get-MgApplication -Filter "owners/`$count eq 0 or owners/`$count eq 1" -CountVariable CountVar -Property "id,displayName"  -ConsistencyLevel eventual 


```
This example will get applications with less than two owners

