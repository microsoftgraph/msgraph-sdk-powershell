### Example 1: Get a user's memberships

```powershell
Get-MgUserMemberOf -UserId '0ec3a5e8-b4b6-4678-90ff-ce786055065f'

Id                                   DeletedDateTime
--                                   ---------------
b859c8be-ba51-4320-bf50-7d985f02e10c
8b59fe93-4da9-4bd6-91f3-46a744a40e86
```

This command gets the memberships for the specified user.
