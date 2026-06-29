### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.qrCode"
	expireDateTime = [System.DateTime]::Parse("2025-12-19T12:00:00Z")
	startDateTime = [System.DateTime]::Parse("2025-01-01T12:00:00Z")
}

Update-MgBetaUserAuthenticationQrCodePinMethodStandardQrCode -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserAuthenticationQrCodePinMethodStandardQrCode Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.qrCode"
	expireDateTime = [System.DateTime]::Parse("2025-12-01T12:00:00Z")
}

# A UPN can also be used as -UserId.
Update-MgBetaUserAuthenticationQrCodePinMethodStandardQrCode -UserId $userId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserAuthenticationQrCodePinMethodStandardQrCode Cmdlet.

