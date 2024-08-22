### Example 1: Retrieve a list of BitLocker keys in the tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey

```
This example will retrieve a list of bitlocker keys in the tenant

### Example 2: Retrieve a list of BitLocker keys filtered by **deviceId**

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey -Filter "deviceId eq '1ab40ab2-32a8-4b00-b6b5-ba724e407de9'" 

```
This example will retrieve a list of bitlocker keys filtered by **deviceid**

