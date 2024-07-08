### Example 1: Get all the permissions and scope IDs of the authenticated user

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Functions

Get-MgBetaDeviceManagementVirtualEndpointScopedPermission

```
This example will get all the permissions and scope ids of the authenticated user

### Example 2: Get a filtered list of permissions and scope IDs of the authenticated user

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Functions

Get-MgBetaDeviceManagementVirtualEndpointScopedPermission -Filter "permission in ('Microsoft.CloudPC/ProvisioningPolicies/Update','Microsoft.CloudPC/ProvisioningPolicies/Create')" 

```
This example will get a filtered list of permissions and scope ids of the authenticated user

### Example 3: No scope IDs are returned

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Functions

Get-MgBetaDeviceManagementVirtualEndpointScopedPermission

```
This example will no scope ids are returned

