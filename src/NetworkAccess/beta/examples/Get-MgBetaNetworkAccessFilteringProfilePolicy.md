### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

Get-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -Filter "isof('microsoft.graph.networkaccess.securityProviderPolicyLink')" 

```
This example shows how to use the Get-MgBetaNetworkAccessFilteringProfilePolicy Cmdlet.

