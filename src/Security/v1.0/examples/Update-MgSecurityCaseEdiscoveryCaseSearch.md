### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Teams search"
}

Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCaseSearch Cmdlet.

