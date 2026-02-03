### Example 1: Update the photo of a team

```powershell

Import-Module Microsoft.Graph.Teams

$params = Binary data for the image

Set-MgTeamPhotoContent -TeamId $teamId -BodyParameter $params

```
This example will update the photo of a team

