### Example 1: Get a list of directory objects that were created by a user

```powershell
Get-MgUserCreatedObject -UserId '7162fba5-6647-47a0-9d69-5837795f32e7'

Id                                   DeletedDateTime
--                                   ---------------
dd8ab0bb-8da3-4292-8c31-a7d91d04e292
f61521f6-e79a-4c70-84bc-077a18fc9bc9
94240411-75f7-44fe-b38a-674bd9f4d7c3
```

This command gets a list of all directory objects that have been created by the specified user.  This works for a user who isn't in any administrator role.
