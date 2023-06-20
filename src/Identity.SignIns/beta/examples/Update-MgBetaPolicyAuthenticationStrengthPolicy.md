### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.authenticationStrengthPolicy"
	displayName = "FIDO2 only"
	description = "An auth strength allowing only FIDO2 security keys."
}

Update-MgBetaPolicyAuthenticationStrengthPolicy -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyAuthenticationStrengthPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

