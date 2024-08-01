### Example 1: List all cloudPC devices in a tenant

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointCloudPc

```
This example will list all cloudpc devices in a tenant

### Example 2: Get the top two cloudPC devices in a tenant

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointCloudPc -Top 2 

```
This example will get the top two cloudpc devices in a tenant

