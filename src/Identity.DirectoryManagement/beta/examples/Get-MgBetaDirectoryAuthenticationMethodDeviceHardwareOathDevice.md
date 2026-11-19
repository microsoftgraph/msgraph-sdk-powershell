### Example 1: List all tokens in the inventory

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice

```
This example will list all tokens in the inventory

### Example 2: List all tokens in the inventory, filtered on status

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice -Filter "status eq 'activated'" 

```
This example will list all tokens in the inventory, filtered on status

### Example 3: Find a specific token by serial number

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice -Filter "serialNumber eq 'TOTP123456'" 

```
This example will find a specific token by serial number

