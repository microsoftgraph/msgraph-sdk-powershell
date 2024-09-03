### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	effectiveDateTime = [System.DateTime]::Parse("2024-04-19T12:01:03.45Z")
}

Initialize-MgBetaBackupRestoreServiceApp -ServiceAppId $serviceAppId -BodyParameter $params

```
This example shows how to use the Initialize-MgBetaBackupRestoreServiceApp Cmdlet.

