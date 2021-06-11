### Example 1: Create a new group

This example creates a new group.

```powershell
New-MgGroup -DisplayName 'Test Group' -MailEnabled:$False  -MailNickName 'testgroup' -SecurityEnabled
```

```Output
Id                                   DisplayName Description GroupTypes
--                                   ----------- ----------- ----------
15bb6c2c-ac32-41a1-b9ec-b6300b8b8e52 Test Group              {}
```

