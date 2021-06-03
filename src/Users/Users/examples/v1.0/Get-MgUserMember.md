### Example 1: Get a user's memberships
```powershell
PS C:\> Get-MgUserMemberOf -Userid "80466d12-1e49-4799-b024-021bf77d7189"

Id                                   DeletedDateTime
--                                   ---------------
bbfa9226-a965-47e1-9db2-bcfcb2c202e6
929a850e-5c44-4d8c-a793-b655adf5f39f
```

This command gets the memberships for the specified user.
