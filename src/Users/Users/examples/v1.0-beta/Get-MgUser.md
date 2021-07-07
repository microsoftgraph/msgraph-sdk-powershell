### Example 1: Get the list of all the users

```powershell
Get-MgUser  | Format-List  ID, DisplayName, Mail, UserPrincipalName

Id                : e4e2b110-8d4f-434f-a990-7cd63e23aed6
DisplayName       : Kristi Laar
Mail              : Adams@contoso.com
UserPrincipalName : Adams@contoso.com

Id                : dba12422-ac75-486a-a960-cd7cb3f6963f
DisplayName       : Adele Vance
Mail              : AdeleV@contoso.com
UserPrincipalName : AdeleV@contoso.com
```

This command returns a list of all users.

### Example 2: Get a user by Id

```powershell
Get-MgUser -UserId 'e4e2b110-8d4f-434f-a990-7cd63e23aed6' | 
  Format-List  ID, DisplayName, Mail, UserPrincipalName

Id                : e4e2b110-8d4f-434f-a990-7cd63e23aed6
DisplayName       : Kristi Laar
Mail              : Adams@contoso.com
UserPrincipalName : Adams@contoso.com
```

This command gets the specified user.
