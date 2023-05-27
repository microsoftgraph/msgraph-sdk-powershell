### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Security

$params = @{
	displayName = "My Query 1 (update)"
	contentQuery = "(Author="edisons")"
}

Update-MgSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -EdiscoveryReviewSetQueryId $ediscoveryReviewSetQueryId -BodyParameter $params
```
This example shows how to use the Get-MgSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

