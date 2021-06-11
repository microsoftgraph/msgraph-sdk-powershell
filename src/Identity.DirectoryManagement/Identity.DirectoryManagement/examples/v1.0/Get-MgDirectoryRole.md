### Example 1: Get all directory roles

This examples gets all the available directory roles.

```powershell
Get-MgDirectoryRole | Format-List
```

```Output
DeletedDateTime      :
Description          : Can manage all aspects of Azure AD and Microsoft services that use Azure AD identities.
DisplayName          : Global Administrator
Id                   : a2d10e79-df32-47fc-86ef-64d199860810
Members              :
RoleTemplateId       : 1f12db9c-dbb3-410d-a893-4c0bc322bf85
ScopedMembers        :
AdditionalProperties : {}
```

### Example 2: Get a directory role by Id

This example gets the directory role based on the specified Id.

```powershell
Get-MgDirectoryRole -DirectoryRoleId 'a2d10e79-df32-47fc-86ef-64d199860810' |
  Format-List
```

```Output
DeletedDateTime      :
Description          : Can manage all aspects of Azure AD and Microsoft services that use Azure AD identities.
DisplayName          : Global Administrator
Id                   : a2d10e79-df32-47fc-86ef-64d199860810
Members              :
RoleTemplateId       : 1f12db9c-dbb3-410d-a893-4c0bc322bf85
ScopedMembers        :
AdditionalProperties : {}
```