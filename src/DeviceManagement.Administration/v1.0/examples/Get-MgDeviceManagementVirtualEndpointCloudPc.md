### Example 1: List all cloudPC devices in a tenant

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

Get-MgDeviceManagementVirtualEndpointCloudPc

```
This example will list all cloudpc devices in a tenant

### Example 2: Get the top two cloudPC devices in a tenant

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

Get-MgDeviceManagementVirtualEndpointCloudPc -Top 2 

```
This example will get the top two cloudpc devices in a tenant

