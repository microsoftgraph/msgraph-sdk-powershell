### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	"@odata.type" = "#microsoft.graph.subjectRightsRequest"
	internalDueDateTime = [System.DateTime]::Parse("2021-08-30T00:00:00Z")
}

Update-MgBetaPrivacySubjectRightsRequest -SubjectRightsRequestId $subjectRightsRequestId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPrivacySubjectRightsRequest Cmdlet.

