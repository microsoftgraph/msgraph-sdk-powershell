### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	definition = @(
	"definition-value"
)
displayName = "displayName-value"
isOrganizationDefault = $true
}

New-MgPolicyActivityBasedTimeoutPolicy -BodyParameter $params

```
This example shows how to use the New-MgPolicyActivityBasedTimeoutPolicy Cmdlet.

