### Example 1: Update the properties of a service principal

```powershell
$ServicePrincipalUpdate =@{
  "accountEnabled" = "true"
  "appRoleAssignmentRequired" = "true"
  }

Update-MgServicePrincipal -ServicePrincipalId '000e4269-1923-4c8c-9c27-1206e114d421' -BodyParameter $ServicePrincipalUpdate
```

This is example, the first command defines the properties and their values in a hashtable under the variable $ServicePrincipalUpdate. The second command updates the specified service principal.
