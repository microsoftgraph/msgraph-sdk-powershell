### Example 1: Add a chat to a section

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	id = "19:d5b2c3a4-e6f7-8901-abcd-ef3456789012@thread.v2"
}

New-MgBetaUserTeamworkSectionItem -UserId $userId -TeamworkSectionId $teamworkSectionId -BodyParameter $params

```
This example will add a chat to a section

### Example 2: Add a community to a section

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	id = "eyJfdHlwZSI6Ikdyb3VwIiwiaWQiOiIxOTAzMzYyMTIyMTAifQ"
}

New-MgBetaUserTeamworkSectionItem -UserId $userId -TeamworkSectionId $teamworkSectionId -BodyParameter $params

```
This example will add a community to a section

