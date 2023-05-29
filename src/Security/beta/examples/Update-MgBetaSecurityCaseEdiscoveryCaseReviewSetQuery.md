### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My Query 1 (update)"
	contentQuery = "(Author="edisons")"
}

Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

