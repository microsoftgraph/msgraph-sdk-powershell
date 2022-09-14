### Example 1
``` powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	DisplayName = "Azure AD SAML Toolkit"
}
Invoke-MgInstantiateApplicationTemplate -ApplicationTemplateId $applicationTemplateId -BodyParameter $params
```
