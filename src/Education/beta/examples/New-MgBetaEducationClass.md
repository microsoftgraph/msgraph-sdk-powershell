### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Education

$params = @{
	description = "Health Level 1"
	classCode = "Health 501"
	displayName = "Health 1"
	externalId = "11019"
	externalName = "Health Level 1"
	externalSource = "sis"
	mailNickname = "fineartschool.net"
}

New-MgBetaEducationClass -BodyParameter $params

```
This example shows how to use the New-MgBetaEducationClass Cmdlet.

