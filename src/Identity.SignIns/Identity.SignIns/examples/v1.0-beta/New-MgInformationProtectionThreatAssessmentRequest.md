### Example 1: Using the New-MgInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
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
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
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
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.mailAssessmentRequest"
	RecipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	ExpectedAssessment = "block"
	Category = "spam"
	MessageUri = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.type" = "#microsoft.graph.urlAssessmentRequest"
	Url = "http://test.com"
	ExpectedAssessment = "block"
	Category = "phishing"
}
New-MgInformationProtectionThreatAssessmentRequest -BodyParameter $params
```
This example shows how to use the New-MgInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
