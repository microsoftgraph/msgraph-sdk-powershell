### Example 1: Get appRoleAssignments granted to a group

```powershell
Get-MgGroupAppRoleAssignment -GroupId '2692d278-8323-4094-b286-e0ffce5e54a5' |
  Format-List

AppRoleId            : 00000000-0000-0000-0000-000000000000
CreatedDateTime      : 7/29/2021 10:08:49 AM
DeletedDateTime      :
Id                   : eNKSJiODlECyhuD_zl5UpexaKrcAYuZEhjCKxfNmzDM
PrincipalDisplayName : Marketing
PrincipalId          : 2692d278-8323-4094-b286-e0ffce5e54a5
PrincipalType        : Group
ResourceDisplayName  : Common Data Service
ResourceId           : 93af1c70-e87f-45df-8780-8af2d7afd05e
AdditionalProperties : {}
```

This example get all app role assignments granted to the specified group.
