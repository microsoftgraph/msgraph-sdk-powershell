### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	displayName = "OneDrive For Business Protection Policy"
	driveProtectionUnits = @(
		@{
			userId = "cdd3a849-dcaf-4a85-af82-7e39fc14019"
		}
		@{
			userId = "9bc069da-b746-41a4-89ab-26125c6373c7"
		}
		@{
			userId = "b218eb4a-ea72-42bd-8f0b-d0bbf794bec7"
		}
	)
}

New-MgBetaBackupRestoreOneDriveForBusinessProtectionPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaBackupRestoreOneDriveForBusinessProtectionPolicy Cmdlet.

