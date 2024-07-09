### Example 1: Get the properties of the specified user setting

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

Get-MgDeviceManagementVirtualEndpointUserSetting -CloudPcUserSettingId $cloudPcUserSettingId

```
This example will get the properties of the specified user setting

### Example 2: Get the properties of the specified user setting and expand on the assignments

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

Get-MgDeviceManagementVirtualEndpointUserSetting -CloudPcUserSettingId $cloudPcUserSettingId -ExpandProperty "assignments" 

```
This example will get the properties of the specified user setting and expand on the assignments

