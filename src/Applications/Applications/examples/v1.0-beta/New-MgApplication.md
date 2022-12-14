### Example 1: Create a new application

```powershell
New-MgBetaApplication -DisplayName 'New app' | 
  Format-List Id, DisplayName, AppId, SignInAudience, PublisherDomain

Id              : 0f0aec7b-ac5b-4f89-9fac-e9044ba5a309
DisplayName     : New app
AppId           : c678b75d-1012-4466-8655-1672192232b4
SignInAudience  : AzureADandPersonalMicrosoftAccount
PublisherDomain : M365B977454.onmicrosoft.com
```

This example creates a new application.
