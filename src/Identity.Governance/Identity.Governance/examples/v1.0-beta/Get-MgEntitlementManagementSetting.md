### Example 1: Get the identity governance settings

```powershell
Get-MgEntitlementManagementSetting

Id        DaysUntilExternalUserDeletedAfterBlocked ExternalUserLifecycleAction
--        ---------------------------------------- ---------------------------
singleton 30                                       BlockSignInAndDelete
```

This example returns the identity governance settings.