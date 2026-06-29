### Example 1: Activate an inactive protection policy

```powershell

Import-Module Microsoft.Graph.Bookings

Initialize-MgBackupRestoreProtectionPolicy -ProtectionPolicyBaseId $protectionPolicyBaseId

```
This example will activate an inactive protection policy

### Example 2: Activate an active protection policy

```powershell

Import-Module Microsoft.Graph.Bookings

Initialize-MgBackupRestoreProtectionPolicy -ProtectionPolicyBaseId $protectionPolicyBaseId

```
This example will activate an active protection policy

