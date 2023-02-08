### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.siteSource"
}
New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.userSource"
	Email = "badguy@contoso.com"
}
New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.siteSource"
}
New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
