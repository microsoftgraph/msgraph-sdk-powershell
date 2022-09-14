### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationSoftwareOathMethod -UserId $userId -SoftwareOathAuthenticationMethodId $softwareOathAuthenticationMethodId
```
