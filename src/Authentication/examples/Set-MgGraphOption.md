### Example 1: Disable web account manager support
```powershell
PS C:\> Set-MgGraphOption -DisableLoginByWAM $True
```
 Disables sign in via Web Account Manager (WAM). Note: This only takes effect when using a custom ClientId. When using the default ClientId, WAM remains enabled regardless of this setting.