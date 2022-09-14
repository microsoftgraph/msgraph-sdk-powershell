### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
	Password = "<password>"
}
Invoke-MgUploadIdentityApiConnectorClientCertificate -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
