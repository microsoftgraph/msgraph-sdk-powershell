### Example 1: Get siteInclusionRule associated with a SharePoint protection policy

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBackupRestoreSharePointProtectionPolicySiteInclusionRule -SharePointProtectionPolicyId $sharePointProtectionPolicyId -SiteProtectionRuleId $siteProtectionRuleId

```
This example will get siteinclusionrule associated with a sharepoint protection policy

