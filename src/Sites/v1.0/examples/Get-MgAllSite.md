### Example 1: Initial request

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgAllSite

```
This example will initial request

### Example 2: Subsequent request

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgAllSite -Skiptoken "U1BHZW9EYXRhTG9jYXRpb25Db2RlYU5BTQ" 

```
This example will subsequent request

