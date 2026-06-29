### Example 1: Create a building

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.building"
	displayName = "B001"
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a building

### Example 2: Create a floor

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.floor"
	displayName = "F1"
	parentId = "767a31a7-6987-41c9-b829-ab351b8aab53"
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a floor

### Example 3: Create a section

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.section"
	displayName = "S1"
	parentId = "46ef7aed-5d94-4fd4-ae03-b333bc7a6955"
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a section

### Example 4: Create a desk

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.desk"
	displayName = "D1"
	parentId = "1ad0f725-6885-49c5-9a47-3b22a1f9409d"
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a desk

### Example 5: Create a room

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.room"
	displayName = "Conf Room 4/3.3G11"
	parentId = "46ef7aed-5d94-4fd4-ae03-b333bc7a6955"
	bookingType = "standard"
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a room

### Example 6: Create a workspace

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	"@odata.type" = "microsoft.graph.workspace"
	parentId = "f7de7265-e420-47b4-9d49-28d728716241"
	displayName = "testSpace001"
	tags = @(
	"test"
)
}

New-MgBetaPlace -BodyParameter $params

```
This example will create a workspace

