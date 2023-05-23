### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Teams search"
}

Update-MgBetaSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaSecurityCaseEdiscoveryCaseSearch Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

