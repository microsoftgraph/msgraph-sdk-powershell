### Example 1: Enroll a signed-in registrant

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	"@odata.type" = "#microsoft.graph.meetingRegistrant"
	firstName = "Frederick"
	lastName = "Cormier"
	email = "frederick.cormier@contoso.com"
	customQuestionAnswers = @(
		@{
			questionId = "MSM5YjlmM2Q4ZS03ZmVkLTRmN3gwMDIw94MDAyMF9hX3gwMDIwX2RldmU="
			value = "No"
		}
		@{
			questionId = "MSM5M2E2OWQ1Ni1jZTc4LTQDAwMjBfZGlkX3gwMDIwX3lvdV94MDAyMF8="
			value = "Internet"
		}
	)
}

New-MgBetaUserOnlineMeetingRegistrationRegistrant -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params

```
This example will enroll a signed-in registrant

### Example 2: Enroll an anonymous registrant

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

$params = @{
	"@odata.type" = "#microsoft.graph.meetingRegistrant"
	firstName = "Lisa"
	lastName = "Adkins"
	email = "lisa.adkins@contoso.com"
	customQuestionAnswers = @(
		@{
			questionId = "MSM5YjlmM2Q4ZS03ZmVkLTRmN3gwMDIw94MDAyMF9hX3gwMDIwX2RldmU="
			value = "No"
		}
		@{
			questionId = "MSM5M2E2OWQ1Ni1jZTc4LTQDAwMjBfZGlkX3gwMDIwX3lvdV94MDAyMF8="
			value = "Internet"
		}
	)
}

New-MgBetaUserOnlineMeetingRegistrationRegistrant -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params

```
This example will enroll an anonymous registrant

