### Example 1: Using the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.siteSource"
}
New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.userSource"
	Email = "badguy@contoso.com"
}
New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	"@odata.type" = "microsoft.graph.ediscovery.siteSource"
}
New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseSourceCollectionAdditionalSource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
