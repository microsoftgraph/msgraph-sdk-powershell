### Example 1: Get all directory roles

```powershell
Get-MgDirectoryRole | Format-List

DeletedDateTime      :
Description          : Can read basic directory information. Commonly used to grant directory read access to
                       applications and guests.
DisplayName          : Directory Readers
Id                   : 86596a70-0099-457d-8c89-1f5085b395ca
Members              :
RoleTemplateId       : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScopedMembers        :
AdditionalProperties : {}
```

This examples gets all the available directory roles.

### Example 2: Get a directory role by Id

```powershell
Get-MgDirectoryRole -DirectoryRoleId '86596a70-0099-457d-8c89-1f5085b395ca' |
  Format-List

DeletedDateTime      :
Description          : Can read basic directory information. Commonly used to grant directory read access to
                       applications and guests.
DisplayName          : Directory Readers
Id                   : 86596a70-0099-457d-8c89-1f5085b395ca
Members              :
RoleTemplateId       : 88d8e3e3-8f55-4a1e-953a-9b9898b8876b
ScopedMembers        :
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#directoryRoles/$entity]}
```

This example gets the directory role based on the specified Id.
