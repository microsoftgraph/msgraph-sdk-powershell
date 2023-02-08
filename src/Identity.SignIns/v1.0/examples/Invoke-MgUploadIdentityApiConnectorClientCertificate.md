### Example 1: Using the Invoke-MgUploadIdentityApiConnectorClientCertificate Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
	Password = "<password>"
}
Invoke-MgUploadIdentityApiConnectorClientCertificate -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Invoke-MgUploadIdentityApiConnectorClientCertificate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
