### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "My Reviewset 3"
}

New-MgBetaComplianceEdiscoveryCaseReviewSet -CaseId $caseId -BodyParameter $params

```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseReviewSet Cmdlet.

