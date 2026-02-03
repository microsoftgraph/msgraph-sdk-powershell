### Example 1: Get a device

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDevice -DeviceId $deviceId

```
This example will get a device

### Example 2: Get a device and return only its id and extensionAttributes properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDevice -DeviceId $deviceId -Property "id,extensionAttributes" 

```
This example will get a device and return only its id and extensionattributes properties

