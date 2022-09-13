###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationSoftwareOathMethod -UserId $userId -SoftwareOathAuthenticationMethodId $softwareOathAuthenticationMethodId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationSoftwareOathMethod -UserId $userId
```
