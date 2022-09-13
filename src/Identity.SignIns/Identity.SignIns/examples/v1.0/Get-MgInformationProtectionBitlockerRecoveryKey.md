###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey -Filter "deviceId eq '1ab40ab2-32a8-4b00-b6b5-ba724e407de9'" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgInformationProtectionBitlockerRecoveryKey
```
