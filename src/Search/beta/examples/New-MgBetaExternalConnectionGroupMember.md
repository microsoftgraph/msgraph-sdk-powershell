### Example 1: Add an Azure Active Directory user as a member

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	id = "e811976d-83df-4cbd-8b9b-5215b18aa874"
	type = "user"
}

New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params

```
This example will add an azure active directory user as a member

### Example 2: Add an Azure Active Directory group as a member

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	id = "e5477431-1038-484e-bf69-1dfedb97a110"
	type = "externalGroup"
}

New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params

```
This example will add an azure active directory group as a member

### Example 3: Add another external group as a member

```powershell

Import-Module Microsoft.Graph.Beta.Search

$params = @{
	id = "1431b9c38ee647f6a"
	type = "externalGroup"
}

New-MgBetaExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -BodyParameter $params

```
This example will add another external group as a member

