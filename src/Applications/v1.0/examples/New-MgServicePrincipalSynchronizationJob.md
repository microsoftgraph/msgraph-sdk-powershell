### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	templateId = "BoxOutDelta"
}

New-MgServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the New-MgServicePrincipalSynchronizationJob Cmdlet.

