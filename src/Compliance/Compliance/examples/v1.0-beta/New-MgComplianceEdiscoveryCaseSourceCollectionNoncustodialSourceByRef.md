### Example 1: Using the New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	"@odata.id" = "https://canary.graph.microsoft.com/testprodbetancsdsaslist/compliance/ediscovery/cases/06d52284-ed81-49b8-904a-b863d3164731/noncustodialDataSources/39383530323537383742433232433246"
}
New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseSourceCollectionNoncustodialSourceByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
