### Example 1: List the driveProtectionUnits associated with a OneDrive for Business protection policy

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

Get-MgBetaBackupRestoreOneDriveForBusinessProtectionPolicyDriveProtectionUnit -OneDriveForBusinessProtectionPolicyId $oneDriveForBusinessProtectionPolicyId

```
This example will list the driveprotectionunits associated with a onedrive for business protection policy

