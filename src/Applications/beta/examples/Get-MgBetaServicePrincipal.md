### Example 1: Get a list of service principals

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal

```
This example will get a list of service principals

### Example 2: Use $filter and $top to get one service principal with a display name that starts with 'a' including a count of returned objects

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName"  -ConsistencyLevel eventual 


```
This example will use $filter and $top to get one service principal with a display name that starts with 'a' including a count of returned objects

### Example 3: Use $search to get service principals with display names that contain the letters 'Team' including a count of returned objects

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal -Search '"displayName:Team"' -CountVariable CountVar -Property "accountEnabled,displayName,publisherName,servicePrincipalType,signInAudience"  -ConsistencyLevel eventual 


```
This example will use $search to get service principals with display names that contain the letters 'team' including a count of returned objects

### Example 4: Get service principals with less than two owners

```powershell

Import-Module Microsoft.Graph.Beta.Applications

Get-MgBetaServicePrincipal -Filter "owners/`$count eq 0 or owners/`$count eq 1" -CountVariable CountVar -Property "id,displayName"  -ConsistencyLevel eventual 


```
This example will get service principals with less than two owners

