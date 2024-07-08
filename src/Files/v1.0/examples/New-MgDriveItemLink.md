### Example 1: Code snippet

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
This example shows how to use the New-MgDriveItemLink Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	type = "edit"
	scope = "organization"
}

New-MgDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the New-MgDriveItemLink Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

$params = @{
	type = "embed"
}

New-MgDriveItemLink -DriveId $driveId -DriveItemId $driveItemId -BodyParameter $params

```
This example shows how to use the New-MgDriveItemLink Cmdlet.

