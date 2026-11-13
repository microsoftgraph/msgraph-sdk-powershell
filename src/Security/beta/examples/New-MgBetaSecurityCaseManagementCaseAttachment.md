### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.caseManagement.attachment"
	displayName = "Case MS-001 Attachment"
	description = "Screenshot of suspicious sign-in activity"
	fileSize = 1000
	fileExtension = "jpeg"
}

New-MgBetaSecurityCaseManagementCaseAttachment -CaseId $caseId -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityCaseManagementCaseAttachment Cmdlet.

