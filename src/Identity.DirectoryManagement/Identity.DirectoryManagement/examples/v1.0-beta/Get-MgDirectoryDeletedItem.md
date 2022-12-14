### Example 1: Retrieve a list of recently deleted items

```powershell
Get-MgBetaDirectoryDeletedItem -DirectoryObjectId 'd4142c52-179b-4d31-b5b9-08940873507b'

Id                                   DeletedDateTime
--                                   ---------------
d4142c52-179b-4d31-b5b9-08940873507b 8/30/2021 7:37:37 AM
```

This command returns the details of the specified directory object. The DirectoryObjectId can be an application, group or user resource.
