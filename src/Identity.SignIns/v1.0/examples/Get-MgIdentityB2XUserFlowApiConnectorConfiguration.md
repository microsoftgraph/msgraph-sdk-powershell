### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgIdentityB2XUserFlowApiConnectorConfiguration -B2xIdentityUserFlowId $b2xIdentityUserFlowId -ExpandProperty "postFederationSignup,postAttributeCollection" 

```
This example shows how to use the Get-MgIdentityB2XUserFlowApiConnectorConfiguration Cmdlet.

