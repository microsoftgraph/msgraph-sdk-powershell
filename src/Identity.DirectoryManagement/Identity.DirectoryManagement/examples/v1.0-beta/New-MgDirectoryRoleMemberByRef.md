### Example 1: Add a member to a diretory role

```powershell
$DirObject = @{
  "@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/3d939dc2-d0a0-4d4d-b3f4-6bb75ce6ff6e"
  }

New-MgBetaDirectoryRoleMemberByRef -DirectoryRoleId 'c6bb44c1-73cc-48a1-a73c-b6a977084948' -BodyParameter $DirObject
```

The first command sets the value for the directory object variable $DirObject. The second command assigns the defined directory object the directory role defined by the DirectoryRoleId
