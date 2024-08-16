### Example 1: Retrieve deleted groups

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryDeletedItemAsGroup

```
This example will retrieve deleted groups

### Example 2: Retrieve the count of deleted user objects and order the results by the deletedDateTime property

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryDeletedItemAsGroup -CountVariable CountVar -Sort "deletedDateTime asc" -Property "id,displayName,deletedDateTime" 

```
This example will retrieve the count of deleted user objects and order the results by the deleteddatetime property

