### Example 1: Create a new service principal object

```powershell
$ServicePrincipalID=@{
  "AppId" = "fc876dd1-6bcb-4304-b9b6-18ddf1526b62"
  }
New-MgBetaServicePrincipal -BodyParameter $ServicePrincipalId | 
  Format-List id, DisplayName, AppId, SignInAudience

Id             : ac483a5f-f291-4499-8a62-058547724579
DisplayName    : Example App
AppId          : ffdf268a-2fe2-49e1-8cd7-66ecb61641ec
SignInAudience : AzureADandPersonalMicrosoftAccount
```

In this example, the first command defines the service principal object in the variable $ServiceprincipalId. The second command creates a new service principal object.
