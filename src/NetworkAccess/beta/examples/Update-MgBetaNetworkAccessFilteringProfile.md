### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	state = "disabled"
}

Update-MgBetaNetworkAccessFilteringProfile -FilteringProfileId $filteringProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessFilteringProfile Cmdlet.

