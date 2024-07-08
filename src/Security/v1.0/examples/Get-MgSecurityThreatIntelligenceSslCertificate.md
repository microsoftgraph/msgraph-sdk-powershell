### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

Get-MgSecurityThreatIntelligenceSslCertificate -Search '"subject/commonName:microsoft.com"' -CountVariable CountVar -Top 1 

```
This example shows how to use the Get-MgSecurityThreatIntelligenceSslCertificate Cmdlet.

