### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.qrPin"
	code = "09599786"
}

Update-MgBetaUserAuthenticationQrCodePinMethodPin -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserAuthenticationQrCodePinMethodPin Cmdlet.

