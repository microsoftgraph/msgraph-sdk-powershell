### Example 1: Get the BitLocker key by specifying the key id

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the BitLocker key with the <strong>key</strong> property

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key"
```
This example shows how to use the Get-MgBetaInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

