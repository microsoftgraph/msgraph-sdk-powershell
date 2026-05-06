### Example 1: Get-MgEnvironment
```powershell
PS C:\> Get-MgEnvironment
Name         AzureADEndpoint                        GraphEndpoint                           Type
----         ---------------                        -------------                           ----
BleuCloud    https://login.sovcloud-identity.fr     https://graph.svc.sovcloud.fr           Built-in
China        https://login.chinacloudapi.cn         https://microsoftgraph.chinacloudapi.cn Built-in
DelosCloud   https://login.sovcloud-identity.de     https://graph.svc.sovcloud.de           Built-in
Global       https://login.microsoftonline.com      https://graph.microsoft.com             Built-in
GovSGCloud   https://login.sovcloud-identity.sg     https://graph.svc.sovcloud.sg           Built-in
USGov        https://login.microsoftonline.us       https://graph.microsoft.us              Built-in
USGovDoD     https://login.microsoftonline.us       https://dod-graph.microsoft.us          Built-in
```
This command gets list of all environments.