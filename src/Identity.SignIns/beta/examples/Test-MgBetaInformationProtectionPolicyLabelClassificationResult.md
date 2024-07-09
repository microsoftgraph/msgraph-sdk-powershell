### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	contentInfo = @{
		"@odata.type" = "#microsoft.graph.contentInfo"
		"format@odata.type" = "#microsoft.graph.contentFormat"
		format = "default"
		identifier = $null
		"state@odata.type" = "#microsoft.graph.contentState"
		state = "rest"
	}
	classificationResults = @(
		@{
			sensitiveTypeId = "cb353f78-2b72-4c3c-8827-92ebe4f69fdf"
			count = 4
			confidenceLevel = 75
		}
	)
}

Test-MgBetaInformationProtectionPolicyLabelClassificationResult -BodyParameter $params

```
This example shows how to use the Test-MgBetaInformationProtectionPolicyLabelClassificationResult Cmdlet.

