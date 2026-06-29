### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	contentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		"format@odata.type" = "#microsoft.graph.security.contentFormat"
		format = "default"
		contentFormat = "File"
		identifier = "c:\user\new.docx"
		"state@odata.type" = "#microsoft.graph.security.contentState"
		state = "rest"
		metadata = @(
		)
	}
	classificationResults = @(
		@{
			sensitiveTypeId = "50842eb7-edc8-4019-85dd-5a5c1f2bb085"
			count = 7
			confidenceLevel = 99
		}
	)
}

Test-MgBetaUserSecurityInformationProtectionSensitivityLabelClassificationResult -UserId $userId -BodyParameter $params

```
This example shows how to use the Test-MgBetaUserSecurityInformationProtectionSensitivityLabelClassificationResult Cmdlet.

