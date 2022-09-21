### Example 1: Using the New-MgComplianceEdiscoveryCaseTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "Privileged"
	Description = "The document is privileged"
	"Parent@odata.bind" = "https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/98fdad78bbce4519b75474bc150575c3"
}
New-MgComplianceEdiscoveryCaseTag -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgComplianceEdiscoveryCaseTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
