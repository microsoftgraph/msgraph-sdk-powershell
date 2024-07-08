### Example 1: Update the photo of a team

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = Binary data for the image

Set-MgBetaTeamPhotoContent -TeamId $teamId -BodyParameter $params

```
This example will update the photo of a team

