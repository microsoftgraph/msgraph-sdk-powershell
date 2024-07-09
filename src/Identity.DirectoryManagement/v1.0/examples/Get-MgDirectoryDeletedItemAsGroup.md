### Example 1: Retrieve deleted groups

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryDeletedItemAsGroup

```
This example will retrieve deleted groups

### Example 2: Retrieve the count of deleted user objects and order the results by the deletedDateTime property

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryDeletedItemAsGroup -CountVariable CountVar -Sort "deletedDateTime asc" -Property "id,DisplayName,deletedDateTime" 

```
This example will retrieve the count of deleted user objects and order the results by the deleteddatetime property

