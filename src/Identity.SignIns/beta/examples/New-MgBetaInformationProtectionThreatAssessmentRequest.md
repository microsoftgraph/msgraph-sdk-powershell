### Example 1: Create a mail assessment request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.mailAssessmentRequest"
	recipientEmail = "tifc@contoso.com"
	expectedAssessment = "block"
	category = "spam"
	messageUri = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params

```
This example will create a mail assessment request

### Example 2: Create an email assessment request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.emailFileAssessmentRequest"
	recipientEmail = "tifc@contoso.com"
	expectedAssessment = "block"
	category = "malware"
	contentData = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params

```
This example will create an email assessment request

### Example 3: Create a file assessment request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.fileAssessmentRequest"
	expectedAssessment = "block"
	category = "malware"
	fileName = "test.txt"
	contentData = "VGhpcyBpcyBhIHRlc3QgZmlsZQ=="
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params

```
This example will create a file assessment request

### Example 4: Create an url assessment request

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.urlAssessmentRequest"
	url = "http://test.com"
	expectedAssessment = "block"
	category = "phishing"
}

New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params

```
This example will create an url assessment request

