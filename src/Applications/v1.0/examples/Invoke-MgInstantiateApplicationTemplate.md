### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	displayName = "Azure AD SAML Toolkit"
}

Invoke-MgInstantiateApplicationTemplate -ApplicationTemplateId $applicationTemplateId -BodyParameter $params

```
This example shows how to use the Invoke-MgInstantiateApplicationTemplate Cmdlet.

