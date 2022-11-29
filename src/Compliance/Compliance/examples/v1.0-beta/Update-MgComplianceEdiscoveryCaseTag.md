### Example 1: Using the Update-MgComplianceEdiscoveryCaseTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	Description = "This is an updated description."
}
Update-MgComplianceEdiscoveryCaseTag -CaseId $caseId -TagId $tagId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCaseTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
