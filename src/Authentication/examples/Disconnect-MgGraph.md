
### Example 1: Using Disconnect-MgGraph
```powershell
PS C:\> Disconnect-MgGraph
```
Use Disconnect-MgGraph to sign out.

### Example 2: Sign out and also clear the Windows broker (WAM) cache
```powershell
PS C:\> Disconnect-MgGraph -SignOutFromBroker
```
Signs out and additionally removes cached accounts from the Windows broker (WAM). Because the broker store is shared at the OS level, this can also sign you out of other broker-enabled applications (for example Visual Studio, Azure CLI, or Azure PowerShell) using the same Windows account.