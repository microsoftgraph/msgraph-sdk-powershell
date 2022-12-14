### Example 1: Using the New-MgBetaExternalConnectionGroupMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Id = "e811976d-83df-4cbd-8b9b-5215b18aa874"
	Type = "user"
}
New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaExternalConnectionGroupMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaExternalConnectionGroupMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Id = "e5477431-1038-484e-bf69-1dfedb97a110"
	Type = "externalGroup"
}
New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaExternalConnectionGroupMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaExternalConnectionGroupMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Id = "1431b9c38ee647f6a"
	Type = "externalGroup"
}
New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaExternalConnectionGroupMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
