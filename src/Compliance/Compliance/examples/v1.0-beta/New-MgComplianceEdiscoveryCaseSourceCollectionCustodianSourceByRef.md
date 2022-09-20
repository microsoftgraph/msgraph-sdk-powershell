### Example 1: Using the New-MgComplianceEdiscoveryCaseSourceCollectionCustodianSourceByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/custodians/ab3a628a383045eba344b3caecba3104/userSources/31423539-3846-4333-4136-353644383531"
}
New-MgComplianceEdiscoveryCaseSourceCollectionCustodianSourceByRef -CaseId $caseId -SourceCollectionId $sourceCollectionId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseSourceCollectionCustodianSourceByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
