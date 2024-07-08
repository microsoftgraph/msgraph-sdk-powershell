### Example 1: Reboot the cloudPC for the administrator

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

Restart-MgBetaDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId

```
This example will reboot the cloudpc for the administrator

