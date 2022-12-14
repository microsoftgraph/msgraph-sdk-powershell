### Example 1: Using the New-MgBetaComplianceEdiscoveryCaseTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "Privileged"
	Description = "The document is privileged"
	"Parent@odata.bind" = "https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/98fdad78bbce4519b75474bc150575c3"
}
New-MgBetaComplianceEdiscoveryCaseTag -CaseId $caseId -BodyParameter $params
```
This example shows how to use the New-MgBetaComplianceEdiscoveryCaseTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
