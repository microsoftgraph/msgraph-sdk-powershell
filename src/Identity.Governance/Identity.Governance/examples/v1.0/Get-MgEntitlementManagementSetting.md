### Example 1: Get the identity governance settings

```powershell
Connect-MgGraph -Scopes 'EntitlementManagement.ReadWrite.All'

Get-MgEntitlementManagementSetting

Id        ExternalUserLifecycleAction
--        ---------------------------
singleton blockSignInAndDelete
```

This example returns the identity governance settings.
