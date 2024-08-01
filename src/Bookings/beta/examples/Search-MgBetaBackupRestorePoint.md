### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Bookings

$params = @{
	protectionUnitIds = @(
	"23014d8c-71fe-4d00-a01a-31850bc5b42a"
"43014d8c-71fe-4d00-a01a-31850bc5b42b"
"63014d8c-71fe-4d00-a01a-31850bc5b42c"
"83014d8c-71fe-4d00-a01a-31850bc5b42d"
)
protectionTimePeriod = @{
startDateTime = [System.DateTime]::Parse("2021-01-01T00:00:00Z")
endDateTime = [System.DateTime]::Parse("2021-01-08T00:00:00Z")
}
restorePointPreference = "latest"
tags = "fastRestore"
}

Search-MgBetaBackupRestorePoint -BodyParameter $params

```
This example shows how to use the Search-MgBetaBackupRestorePoint Cmdlet.

