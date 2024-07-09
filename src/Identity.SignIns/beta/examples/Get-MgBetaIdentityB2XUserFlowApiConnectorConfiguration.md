### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityB2XUserFlowApiConnectorConfiguration -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "postFederationSignup,postAttributeCollection" 

```
This example shows how to use the Get-MgBetaIdentityB2XUserFlowApiConnectorConfiguration Cmdlet.

