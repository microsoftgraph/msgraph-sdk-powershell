### Example 1: Creating sharable links

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	type = "view"
	password = "ThisIsMyPrivatePassword"
	scope = "anonymous"
	retainInheritedPermissions = $false
}

New-MgDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows creating sharable links

### Example 2: Creating company sharable links

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	type = "edit"
	scope = "organization"
}

New-MgDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows creating company sharable links

### Example 3: Creating embeddable links

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	type = "embed"
}

New-MgDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows creating embeddable links

