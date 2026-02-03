### Example 1: Create a tag

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My tag API"
	description = "Use Graph API to create tags"
	childSelectability = "Many"
}

New-MgBetaSecurityCaseEdiscoveryCaseTag -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will create a tag

### Example 2: Create a tag with a parent

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My tag API"
	description = "Use Graph API to create tags"
	childSelectability = "Many"
	"parent@odata.bind" = ""
}

New-MgBetaSecurityCaseEdiscoveryCaseTag -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example will create a tag with a parent

