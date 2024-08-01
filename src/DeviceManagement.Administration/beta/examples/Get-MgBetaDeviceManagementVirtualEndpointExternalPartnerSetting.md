### Example 1: Get all external partner settings

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting

```
This example will get all external partner settings

### Example 2: Use $select to get all external partner settings

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting -Property "id,partnerId,enableConnection" 

```
This example will use $select to get all external partner settings

