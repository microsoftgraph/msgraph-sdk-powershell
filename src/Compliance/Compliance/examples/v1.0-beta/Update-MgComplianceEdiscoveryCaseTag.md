### Example 1: Using the Update-MgBetaComplianceEdiscoveryCaseTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	Description = "This is an updated description."
}
Update-MgBetaComplianceEdiscoveryCaseTag -CaseId $caseId -TagId $tagId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
