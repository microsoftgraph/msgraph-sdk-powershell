### Example 1: Create an anonymous sharing link

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	type = "view"
	scope = "anonymous"
	password = "String"
	recipients = @(
		@{
			"@odata.type" = "microsoft.graph.driveRecipient"
		}
	)
	sendNotification = $true
	retainInheritedPermissions = $false
}

New-MgBetaDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example will create an anonymous sharing link

### Example 2: Creating company sharable links

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	type = "edit"
	scope = "organization"
}

New-MgBetaDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows creating company sharable links

### Example 3: Creating embeddable links

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	type = "embed"
}

New-MgBetaDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows creating embeddable links

