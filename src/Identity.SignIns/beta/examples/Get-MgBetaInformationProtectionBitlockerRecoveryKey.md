### Example 1: Get the BitLocker key by specifying the key **id**

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId

```
This example will get the bitlocker key by specifying the key **id**

### Example 2: Get the BitLocker key with the **key** property by specifying the key **id**

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key" 

```
This example will get the bitlocker key with the **key** property by specifying the key **id**

