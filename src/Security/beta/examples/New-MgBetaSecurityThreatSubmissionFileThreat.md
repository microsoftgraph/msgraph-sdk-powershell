### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.fileContentThreatSubmission"
	category = "malware"
	fileName = "test.html"
	fileContent = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}

New-MgBetaSecurityThreatSubmissionFileThreat -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityThreatSubmissionFileThreat Cmdlet.

