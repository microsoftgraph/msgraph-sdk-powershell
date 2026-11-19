### Example 1: Disable web account manager support
```powershell
PS C:\> Set-MgGraphOption -DisableLoginByWAM $True
```
 Disables sign in via Web Account Manager (WAM). Note: This only takes effect when using a custom ClientId. When using the default ClientId, WAM remains enabled regardless of this setting.

### Example 2: Disable WAM for sovereign cloud environments
```powershell
PS C:\> Set-MgGraphOption -DisableLoginByWAM $true
PS C:\> Connect-MgGraph -ClientId "YOUR_APP_CLIENT_ID" -TenantId "YOUR_TENANT_ID" -Environment BleuCloud
```
If WAM broker-based authentication hangs or times out when connecting to a sovereign cloud environment (such as BleuCloud, DelosCloud, or GovSGCloud), disable WAM to fall back to interactive browser sign-in. This can occur when authenticating from environments like jumpboxes. The setting persists across PowerShell sessions.
