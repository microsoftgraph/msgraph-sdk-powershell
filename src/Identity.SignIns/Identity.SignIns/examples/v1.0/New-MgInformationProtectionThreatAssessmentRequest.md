### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.emailFileAssessmentRequest"
	RecipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	ExpectedAssessment = "block"
	Category = "malware"
	ContentData = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.fileAssessmentRequest"
	ExpectedAssessment = "block"
	Category = "malware"
	FileName = "test.txt"
	ContentData = "VGhpcyBpcyBhIHRlc3QgZmlsZQ=="
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mailAssessmentRequest"
	RecipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	ExpectedAssessment = "block"
	Category = "spam"
	MessageUri = "https://graph.microsoft.com/v1.0/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.urlAssessmentRequest"
	Url = "http://test.com"
	ExpectedAssessment = "block"
	Category = "phishing"
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
