### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Security

$params = @{
	displayName = "My Query 1"
	contentQuery = "(Author="edison")"
}

New-MgSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the New-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

