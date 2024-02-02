### Example 1: Get the BitLocker key by specifying the key id

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId
```
This example shows how to use the Get-MgInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the BitLocker key with the <strong>key</strong> property

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgInformationProtectionBitlockerRecoveryKey -BitlockerRecoveryKeyId $bitlockerRecoveryKeyId -Property "key"
```
This example shows how to use the Get-MgInformationProtectionBitlockerRecoveryKey Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

