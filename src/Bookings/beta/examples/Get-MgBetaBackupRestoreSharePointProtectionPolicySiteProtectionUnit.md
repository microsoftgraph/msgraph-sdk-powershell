### Example 1: List the siteProtectionUnits associated with a SharePoint protection policy

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBackupRestoreSharePointProtectionPolicySiteProtectionUnit -SharePointProtectionPolicyId $sharePointProtectionPolicyId

```
This example will list the siteprotectionunits associated with a sharepoint protection policy

