### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.emailFileAssessmentRequest"
	recipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	expectedAssessment = "block"
	category = "malware"
	contentData = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.fileAssessmentRequest"
	expectedAssessment = "block"
	category = "malware"
	fileName = "test.txt"
	contentData = "VGhpcyBpcyBhIHRlc3QgZmlsZQ=="
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.urlAssessmentRequest"
	url = "http://test.com"
	expectedAssessment = "block"
	category = "phishing"
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

