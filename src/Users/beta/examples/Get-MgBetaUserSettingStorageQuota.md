### Example 1: Get the unified quota information for the current user

```powershell

Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUserSettingStorageQuota -UserId $userId

```
This example will get the unified quota information for the current user

### Example 2: Get the unified quota information for the current user

```powershell

Import-Module Microsoft.Graph.Beta.Users

Get-MgBetaUserSettingStorageQuota -UserId $userId

```
This example will get the unified quota information for the current user

### Example 3: Get the unified quota information, along with the service breakdowns, for the current user

```powershell

Import-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Get-MgBetaUserSettingStorageQuota -UserId $userId -ExpandProperty "services" 

```
This example will get the unified quota information, along with the service breakdowns, for the current user

