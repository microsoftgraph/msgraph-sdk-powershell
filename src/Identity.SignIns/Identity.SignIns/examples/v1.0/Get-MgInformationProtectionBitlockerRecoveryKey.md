### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -Filter "deviceId eq '1ab40ab2-32a8-4b00-b6b5-ba724e407de9'" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey
```
