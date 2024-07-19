### Example 1: Get a driveInclusionRule associated with an OneDriveForBusiness protection policy

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBackupRestoreOneDriveForBusinessProtectionPolicyDriveInclusionRule -OneDriveForBusinessProtectionPolicyId $oneDriveForBusinessProtectionPolicyId -DriveProtectionRuleId $driveProtectionRuleId

```
This example will get a driveinclusionrule associated with an onedriveforbusiness protection policy

