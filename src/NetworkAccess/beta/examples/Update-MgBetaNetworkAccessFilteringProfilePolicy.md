### Example 1: Update a filteringPolicyLink

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.filteringPolicyLink"
	state = "disabled"
}

Update-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -PolicyLinkId $policyLinkId -BodyParameter $params

```
This example will update a filteringpolicylink

### Example 2: Update a tlsInspectionPolicyLink

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	state = "disabled"
}

Update-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -PolicyLinkId $policyLinkId -BodyParameter $params

```
This example will update a tlsinspectionpolicylink

