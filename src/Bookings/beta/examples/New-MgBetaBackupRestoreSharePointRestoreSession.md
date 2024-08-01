### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	siteRestoreArtifacts = @(
		@{
			restorePoint = @{
				"@odata.id" = "1f1fccc3-a642-4f61-bf49-f37b9a888279"
			}
			destinationType = "inPlace"
		}
		@{
			restorePoint = @{
				"@odata.id" = "1f1fccc3-a642-4f61-bf49-f37b9a888280"
			}
			destinationType = "inPlace"
		}
	)
}

New-MgBetaBackupRestoreSharePointRestoreSession -BodyParameter $params

```
This example shows how to use the New-MgBetaBackupRestoreSharePointRestoreSession Cmdlet.

