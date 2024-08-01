### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
	password = "<password>"
}

Invoke-MgUploadIdentityApiConnectorClientCertificate -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params

```
This example shows how to use the Invoke-MgUploadIdentityApiConnectorClientCertificate Cmdlet.

