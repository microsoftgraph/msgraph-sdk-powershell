### Example 1: Using the New-MgEducationClass Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
$params = @{
	Description = "Health Level 1"
	ClassCode = "Health 501"
	DisplayName = "Health 1"
	ExternalId = "11019"
	ExternalName = "Health Level 1"
	ExternalSource = "sis"
	MailNickname = "fineartschool.net"
}
New-MgEducationClass -BodyParameter $params
```
This example shows how to use the New-MgEducationClass Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
