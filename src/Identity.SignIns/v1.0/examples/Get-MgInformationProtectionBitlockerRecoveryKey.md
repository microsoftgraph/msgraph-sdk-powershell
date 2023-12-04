### Example 1: Get the BitLocker key by specifying the key id

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId

```
This example will get the bitlocker key by specifying the key id

### Example 2: Get the BitLocker key with the **key** property

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key" 

```
This example will get the bitlocker key with the **key** property

