### Example 1: Using the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaInformationProtectionBitlockerRecoveryKey
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaInformationProtectionBitlockerRecoveryKey -Filter "deviceId eq '1ab40ab2-32a8-4b00-b6b5-ba724e407de9'" 
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key" 
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
