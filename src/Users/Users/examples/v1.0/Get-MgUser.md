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

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.

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

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.

### Example 3: Get a count of all users

```powershell
Get-MgUser -Count userCount -ConsistencyLevel eventual

Id                                   DisplayName              Mail                           UserPrincipalName        
--                                   -----------              ----                           -----------------               
00f9b5d4-290f-413d-ab86-feb3cdc23736 Johanna Lorenz           JohannaL@Contoso.com           JohannaL@Contoso.com
0568f35e-9177-4630-abd6-d533b21f1f78 Brian Johnson (TAILSPIN) BrianJ@Contoso.com             BrianJ@Contoso.com
075b32dd-edb7-47cf-89ef-f3f733683a3f Patti Fernandez          PattiF@Contoso.com             PattiF@Contoso.com
0d005a1a-5e61-4388-bf5e-9060d727f891 Conf Room Baker          Baker@Contoso.com              Baker@Contoso.com
15516fb3-d57e-4d46-8aa9-8305bfd85b31 Enrico Cattaneo          EnricoC@Contoso.com            EnricoC@Contoso.com
180d5d54-159d-4970-ae07-99c8b658fa89 Allan Deyoung            AllanD@Contoso.com             AllanD@Contoso.com
185190a7-54f0-4892-add3-211c21327570 Debra Berger             DebraB@Contoso.com             DebraB@Contoso.com
```

The example gets a list of all users. The $userCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.

### Example 4: Use -Filter and -Top to get one user with a display name that starts with 'a' including a count of returned objects

```powershell
Get-MgUser -ConsistencyLevel eventual -Count userCount -Filter "startsWith(DisplayName, 'a')" -Top 1

Id                                   DisplayName   Mail                               UserPrincipalName                  UserType
--                                   -----------   ----                               -----------------                  --------
577a8b8a-ab84-4f90-a6cc-a62cd56010be Allan Deyoung AllanD@M365x814237.OnMicrosoft.com AllanD@M365x814237.OnMicrosoft.com Member
```

This example returns the top 1 users with the display name starting with 'a'. The $userCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.

### Example 5: Use -Search to get all the users whose display name contains 'Conf' including a count of the returned users

```powershell
Get-MgUser -ConsistencyLevel eventual -Count userCount -Search '"DisplayName:Conf"'

Id                                   DisplayName       Mail                UserPrincipalName                   
--                                   -----------       ----                -----------------                             
0d005a1a-5e61-4388-bf5e-9060d727f891 Conf Room Baker   Baker@Contoso.com   Baker@Contoso.com
1e34292e-e5a3-46fd-9cac-8d37f2d3ab4a Conf Room Stevens Stevens@Contoso.com Stevens@Contoso.com
4aec2afd-be23-46d1-9138-f5ee6b77af5a Conf Room Crystal Crystal@Contoso.com Crystal@Contoso.com
82a56dfc-31f9-4b90-8a1c-6c4326bbffd9 Conf Room Hood    Hood@Contoso.com    Hood@Contoso.com
a7afe08d-55b9-4c44-be94-05d17c6513f3 Conf Room Rainier Rainier@Contoso.com Rainier@Contoso.com
```

This example returns all users whose display name contains 'Conf'. The $userCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.

### Example 6: Use -Filter to get all the users with a display name that starts with 'Conf' including a count of the returned users, with the results ordered by UserPrincipalName

```powershell
Get-MgUser -ConsistencyLevel eventual -Count userCount -Filter "startsWith(DisplayName, 'Conf')" -OrderBy UserPrincipalName

Id                                   DisplayName       Mail                UserPrincipalName                   
--                                   -----------       ----                -----------------                   
0d005a1a-5e61-4388-bf5e-9060d727f891 Conf Room Baker   Baker@Contoso.com   Baker@Contoso.com
4aec2afd-be23-46d1-9138-f5ee6b77af5a Conf Room Crystal Crystal@Contoso.com Crystal@Contoso.com
82a56dfc-31f9-4b90-8a1c-6c4326bbffd9 Conf Room Hood    Hood@Contoso.com    Hood@Contoso.com
a7afe08d-55b9-4c44-be94-05d17c6513f3 Conf Room Rainier Rainier@Contoso.com Rainier@Contoso.com
1e34292e-e5a3-46fd-9cac-8d37f2d3ab4a Conf Room Stevens Stevens@Contoso.com Stevens@Contoso.com
```

This example filters all users whose display name starts with 'Conf' and orders the results by the user principal name. The $userCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;
|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|User.ReadBasic.All, User.Read.All| User.ReadWrite.All, Directory.Read.All|
|Application|User.Read.All|User.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes User.ReadBasic.All, User.Read.All`.
