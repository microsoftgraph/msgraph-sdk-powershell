### Example 1: Get all usage rights for a device

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDeviceUsageRights -DeviceId $deviceId

```
This example will get all usage rights for a device

### Example 2: Get usage rights for a device with specific service identifiers and states

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDeviceUsageRights -DeviceId $deviceId -Filter "state in ('active', 'suspended') and serviceIdentifier in ('ABCD')" 

```
This example will get usage rights for a device with specific service identifiers and states

