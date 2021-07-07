### Example 1: Get a list of applications

```powershell
Get-MgApplication | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

Id              : 8ea936e0-cb74-46c0-8408-d4614a596267
DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : contoso.com
```

This examples gets a list of all the applications.

### Example 2: Get an application by Id

```powershell
Get-MgApplication -Filter "AppId eq '39b09640-ec3e-44c9-b3de-f52db4e1cf66'" | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

DisplayName     : Test App
AppId           : 39b09640-ec3e-44c9-b3de-f52db4e1cf66
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : contoso.com
```

This examples gets the application by the specified Id.
