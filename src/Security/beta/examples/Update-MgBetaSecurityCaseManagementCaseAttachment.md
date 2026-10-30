### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Case MS-001 Attachment"
	description = "Screenshot of suspicious sign-in activity"
}

Update-MgBetaSecurityCaseManagementCaseAttachment -CaseId $caseId -AttachmentId $attachmentId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseManagementCaseAttachment Cmdlet.

