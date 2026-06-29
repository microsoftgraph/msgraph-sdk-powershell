### Example 1: Delete a filteringPolicyLink

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

Remove-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -PolicyLinkId $policyLinkId

```
This example will delete a filteringpolicylink

### Example 2: Delete a tlsInspectionPolicyLink

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

Remove-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -PolicyLinkId $policyLinkId

```
This example will delete a tlsinspectionpolicylink

