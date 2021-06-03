### Example 1: Get the list of all the users

```powershell
PS C:\>  Get-MgUser

Id                                   DisplayName              Mail                                           UserPrincipalName                              UserType
--                                   -----------              ----                                           -----------------                              --------
f36aae05-82e9-41ce-ab77-d6ff7031412d Conf Room Adams          Adams@contoso.com              Adams@contoso.com
8a7c50d3-fcbd-4727-a889-8ab232dfea01 Adele Vance              AdeleV@contoso.com             AdeleV@contoso.com
```
This command get a list of users

### Example 2: Get a user by Id

```powershell
PS C:\>  Get-MgUser -UserId 3d939dc2-d0a0-4d4d-b3f4-6bb75ce6ff6e

Id                                   DisplayName      Mail                               UserPrincipalName                  UserType
--                                   -----------      ----                               -----------------                  --------
3d939dc2-d0a0-4d4d-b3f4-6bb75ce6ff6e Irvin Sayers     IrvinS@contoso.com                 IrvinS@contoso.com

```
This command gets the specified user.


