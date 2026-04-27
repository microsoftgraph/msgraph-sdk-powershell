### Example 1: Set web account manager support
```powershell
PS C:\> Set-MgGraphOption -EnableLoginByWAM $True
```
 Sets web account manager support
 Note: Signin by Web Account Manager (WAM) is enabled by default on Windows and cannot be disabled. Setting this option will no longer have any effect. 

### Example 2: Disable WAM for sovereign cloud environments
```powershell
PS C:\> Set-MgGraphOption -DisableLoginByWAM $true
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Environment BleuCloud
```
If WAM broker-based authentication hangs or times out when connecting to a sovereign cloud environment (such as BleuCloud, DelosCloud, or GovSGCloud), disable WAM to fall back to interactive browser sign-in. This can occur when authenticating from environments like jumpboxes. The setting persists across PowerShell sessions.