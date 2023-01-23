### Example 1: Using the Test-MgBetaInformationProtectionPolicyLabelClassificationResult Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	ContentInfo = @{
		"@odata.type" = "#microsoft.graph.contentInfo"
		"Format@odata.type" = "#microsoft.graph.contentFormat"
		Format = "default"
		Identifier = $null
		"State@odata.type" = "#microsoft.graph.contentState"
		State = "rest"
	}
	ClassificationResults = @(
		@{
			SensitiveTypeId = "cb353f78-2b72-4c3c-8827-92ebe4f69fdf"
			Count = 4
			ConfidenceLevel = 75
		}
	)
}
Test-MgBetaInformationProtectionPolicyLabelClassificationResult -BodyParameter $params
```
This example shows how to use the Test-MgBetaInformationProtectionPolicyLabelClassificationResult Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
