### Example 1: Add an administrative unit member

```powershell
$member = @{
  "@odata.id"="https://graph.microsoft.com/v1.0/users/{8a7c50d3-fcbd-4727-a889-8ab232dfea01}"
  }

New-MgDirectoryAdministrativeUnitMemberByRef -AdministrativeUnitId 'd924fbd3-69c5-4cdf-b9ea-9b0badcf9c4d'-BodyParameter $member
```

The first command defines the member to be added to the administrative unit.

The second command adds the member to the specified administrative unit.
