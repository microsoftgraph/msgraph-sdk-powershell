### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContact

```
This example shows how to use the Get-MgBetaContact Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContact -Filter "startswith(displayName,'A')" -CountVariable CountVar -Top 1 -Sort "displayName"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaContact Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaContact -Search '"displayName:wa"' -CountVariable CountVar  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaContact Cmdlet.

