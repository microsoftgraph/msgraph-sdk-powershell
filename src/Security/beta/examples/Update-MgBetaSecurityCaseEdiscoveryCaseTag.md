### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My tag API 2"
	description = "Use Graph API to create tags (updated)"
}

Update-MgBetaSecurityCaseEdiscoveryCaseTag -EdiscoveryCaseId $ediscoveryCaseId -EdiscoveryReviewTagId $ediscoveryReviewTagId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCaseTag Cmdlet.

