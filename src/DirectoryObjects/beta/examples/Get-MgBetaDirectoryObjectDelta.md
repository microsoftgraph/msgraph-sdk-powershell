### Example 1: Retrieve changes for a collection of users and groups

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

Get-MgBetaDirectoryObjectDelta -Filter "isof('microsoft.graph.user') or isof('microsoft.graph.group')" 

```
This example will retrieve changes for a collection of users and groups

### Example 2: Retrieve a collection of changes for a directory object

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

Get-MgBetaDirectoryObjectDelta -Filter "id eq '87d349ed-44d7-43e1-9a83-5f2406dee5bd'" 

```
This example will retrieve a collection of changes for a directory object

### Example 3: Retrieve changes to specific properties for a collection of users and groups

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

Get-MgBetaDirectoryObjectDelta -Filter "isof('microsoft.graph.user') or isof('microsoft.graph.group')" -Property "microsoft.graph.user/surname,microsoft.graph.group/displayName" 

```
This example will retrieve changes to specific properties for a collection of users and groups

### Example 4: Retrieve specific properties only if they changed for a collection of users and groups

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

Get-MgBetaDirectoryObjectDelta -Filter "isof('microsoft.graph.user') or isof('microsoft.graph.group')" -Property "microsoft.graph.user/surname,microsoft.graph.group/displayName" 

```
This example will retrieve specific properties only if they changed for a collection of users and groups

