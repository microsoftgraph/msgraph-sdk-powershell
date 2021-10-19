### Example 1: Get a list of applications

```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

Id              : 8ea936e0-cb74-46c0-8408-d4614a596267
DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com
```

This examples gets a list of all the applications.

One of the following permissions is required to run this cmdlet;

|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|
|Delegated (personal Microsoft account)|Application.Read.All and User.Read|Application.ReadWrite.All and User.Read|
|Application|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 2: Get an application by Id

```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -Filter "AppId eq '39b09640-ec3e-44c9-b3de-f52db4e1cf66'" | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : Contoso.com
```

This examples gets the application by the specified Id.

One of the following permissions is required to run this cmdlet;

|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|
|Delegated (personal Microsoft account)|Application.Read.All and User.Read|Application.ReadWrite.All and User.Read|
|Application|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 3: Get a count of all applications

```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
4f6f867b-4c34-44b2-9680-fe49d024ce74 New apps           bb6e3bbc-8048-412e-a55f-a6bbd8bac525 AzureADandPersonalMicrosoftAccount Contoso.com
bce20771-2a69-41e5-a0dd-125ac2fa2708 Example 3 App      ffdf268a-2fe2-49e1-8cd7-66ecb61641ec AzureADandPersonalMicrosoftAccount Contoso.com
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com
fe4caed6-6182-4aca-b70b-b114c5334a8a New app            641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com
```

This example gets a list of all applications. The $appCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;

|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|
|Delegated (personal Microsoft account)|Application.Read.All and User.Read|Application.ReadWrite.All and User.Read|
|Application|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 4: Use -Search to get all the applications whose display name contains 'Test' including a count of the returned users

```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount -Search '"DisplayName:Test"'

Id                                   DisplayName        AppId                                SignInAudience                     PublisherDomain
--                                   -----------        -----                                --------------                     ---------------
dcaa0c3a-8dfa-4b47-bc04-0edbab42043a Principal-Test App bd38ad43-6c46-4cc6-b65c-a0db533a2a6f AzureADMyOrg                       Contoso.com
f6b30057-7095-4e2c-89f8-224149f591b7 Testing App        00e80963-9bc0-4147-b9e0-2ba56093e7e6 AzureADandPersonalMicrosoftAccount Contoso.com
```

This example returns all applications whose display name contains 'Test'. The $appCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;

|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|
|Delegated (personal Microsoft account)|Application.Read.All and User.Read|Application.ReadWrite.All and User.Read|
|Application|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.

### Example 5: Use -Filter to get all the applications with a display name that starts with 'New' including a count of the returned users, with the results ordered by display name

```powershell
Connect-MgGraph -Scopes 'Application.Read.All'
Get-MgApplication -ConsistencyLevel eventual -Count appCount -Filter "startsWith(DisplayName, 'New')" -OrderBy DisplayName

Id                                   DisplayName AppId                                SignInAudience                     PublisherDomain
--                                   ----------- -----                                --------------                     ---------------
fe4caed6-6182-4aca-b70b-b114c5334a8a New app     641992e9-d176-4aff-a3b6-a867b3ba48c4 AzureADandPersonalMicrosoftAccount Contoso.com
0672d487-4c0c-475a-bf22-0e714f015597 New apps    ced14895-14ac-4dcf-8b93-0779f60c000d AzureADandPersonalMicrosoftAccount Contoso.com
```

This example returns all applications whose display name starts with 'New'. The $appCount variable contains the count of the objects in the result. Advanced query requires the ConsistencyLevel parameter set to `eventual` and the Count parameter in the command. For more information about *ConsistencyLevel* and *Count*, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

One of the following permissions is required to run this cmdlet;

|Permission type| Recommended Permissions| Other Permissions|
|-----|------|------|
|Delegated (work or school account)|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|
|Delegated (personal Microsoft account)|Application.Read.All and User.Read|Application.ReadWrite.All and User.Read|
|Application|Application.Read.All|Application.ReadWrite.All, Directory.Read.All|

To consent to any of these permissions run `Connect-MgGraph -Scopes Permission`. For example, `Connect-MgGraph -Scopes Application.Read.All, Application.ReadWrite.All`.
