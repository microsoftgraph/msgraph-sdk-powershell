### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	description = "This is an updated description."
}

Update-MgBetaComplianceEdiscoveryCaseTag -CaseId $caseId -TagId $tagId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCaseTag Cmdlet.

