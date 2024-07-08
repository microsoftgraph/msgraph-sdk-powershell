### Example 1: Create a mail assessment request

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.mailAssessmentRequest"
	recipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	expectedAssessment = "block"
	category = "spam"
	messageUri = "https://graph.microsoft.com/v1.0/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}

New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Create an email assessment request

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.emailFileAssessmentRequest"
	recipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	expectedAssessment = "block"
	category = "malware"
	contentData = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}

New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Create a file assessment request

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.fileAssessmentRequest"
	expectedAssessment = "block"
	category = "malware"
	fileName = "test.txt"
	contentData = "VGhpcyBpcyBhIHRlc3QgZmlsZQ=="
}

New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Create an url assessment request

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.urlAssessmentRequest"
	url = "http://test.com"
	expectedAssessment = "block"
	category = "phishing"
}

New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

