### Example 1: Set web account manager support
```powershell
PS C:\> Set-MgGraphOption -EnableLoginByWAM $True
```
 Sets web account manager support
 Note: Signin by Web Account Manager (WAM) is enabled by default on Windows and cannot be disabled. Setting this option to $False will have no effect on Windows systems. 