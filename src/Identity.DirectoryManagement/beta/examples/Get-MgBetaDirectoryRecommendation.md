### Example 1: Get the list of recommendations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryRecommendation

```
This example will get the list of recommendations

### Example 2: Get a recommendation object without its associated resources by the recommendationType

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryRecommendation -Filter "recommendationType eq 'turnOffPerUserMFA'" 

```
This example will get a recommendation object without its associated resources by the recommendationtype

### Example 3: Get a recommendation object with its associated impacted resources

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDirectoryRecommendation -Filter "id eq '0cb31920-84b9-471f-a6fb-468c1a847088_Microsoft.Identity.IAM.Insights.TurnOffPerUserMFA'" -ExpandProperty "impactedResources" 

```
This example will get a recommendation object with its associated impacted resources

