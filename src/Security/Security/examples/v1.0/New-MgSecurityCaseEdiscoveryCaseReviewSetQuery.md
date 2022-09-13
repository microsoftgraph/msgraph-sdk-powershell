###Example 1
```
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My Query 1"
	ContentQuery = "(Author="edison")"
}
New-MgSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
