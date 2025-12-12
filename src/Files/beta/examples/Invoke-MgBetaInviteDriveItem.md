### Example 1: Send a sharing invitation

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	recipients = @(
		@{
			email = "robin@contoso.org"
		}
	)
	message = "Here's the file that we're collaborating on."
	requireSignIn = $true
	sendInvitation = $true
	roles = @(
	"write"
)
password = "password123"
expirationDateTime = "2018-07-15T14:00:00.000Z"
}

Invoke-MgBetaInviteDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example will send a sharing invitation

### Example 2: Send sharing invitation with partial success

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	recipients = @(
		@{
			email = "helga@contoso.com"
		}
		@{
			email = "robin@contoso.org"
		}
	)
	message = "Here's the file that we're collaborating on."
	requireSignIn = $true
	sendInvitation = $true
	roles = @(
	"write"
)
password = "password123"
expirationDateTime = "2018-07-15T14:00:00.000Z"
}

Invoke-MgBetaInviteDriveItem -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example will send sharing invitation with partial success

