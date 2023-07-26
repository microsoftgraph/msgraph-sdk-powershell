### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My Query 1"
	contentQuery = "(Author="edison")"
}

New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewSetId $ediscoveryReviewSetId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseReviewSetQuery Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

