### Example 1: Create a new user

This command first sets a value for the passwordprofile variable and uses it to create a new user.

```powershell
$PasswordProfile = @{
  Password = 'xWwvJ]6NMw+bWH-d'
  }
New-MgUser -DisplayName 'Rene Magi' -PasswordProfile $PasswordProfile -AccountEnabled -MailNickName 'ReneMagi' -UserPrincipalName 'ReneMagi@contoso.com'
```

```Output
Id                                   DisplayName Mail UserPrincipalName                    UserType
--                                   ----------- ---- -----------------                    --------
1fe21dc8-7d53-4a92-b1fa-32043b9875a7 Rene Magi        ReneMagi@contoso.com
```

