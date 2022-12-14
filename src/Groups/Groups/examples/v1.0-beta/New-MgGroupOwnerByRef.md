### Example 1: Add an owner to a group

```powershell
$newGroupOwner =@{
  "@odata.id"= "https://graph.microsoft.com/v1.0/users/{4de19c17-6a28-4a91-86d1-f717c3c8c229}"
  }

New-MgBetaGroupOwnerByRef -GroupId '1cb7317c-9c49-4dc8-a358-67ad8e95217c' -BodyParameter $newGroupOwner
```

In this example, the first command defines the value of the $newGroupOwner variable. The second command creates the value is an owner of the specified group.
