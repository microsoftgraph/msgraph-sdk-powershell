### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My review set 2"
}

New-MgBetaSecurityCaseEdiscoveryCaseReviewSet -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseReviewSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

