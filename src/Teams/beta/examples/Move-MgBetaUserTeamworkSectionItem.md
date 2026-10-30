### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	targetSectionId = "c3d4e5f6-a7b8-9012-cdef-123456789012"
}

Move-MgBetaUserTeamworkSectionItem -UserId $userId -TeamworkSectionId $teamworkSectionId -TeamworkSectionItemId $teamworkSectionItemId -BodyParameter $params

```
This example shows how to use the Move-MgBetaUserTeamworkSectionItem Cmdlet.

