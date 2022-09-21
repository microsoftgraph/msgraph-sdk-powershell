### Example 1: Using the Remove-MgApplicationOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationOwnerByRef -ApplicationId $applicationId -DirectoryObjectId $directoryObjectId
```
This example shows how to use the Remove-MgApplicationOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
