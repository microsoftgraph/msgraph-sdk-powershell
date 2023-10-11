### Example 1: Remove user-defined environment
```powershell
PS C:\> Remove-MgEnvironment Canary
Name     AzureADEndpoint                      GraphEndpoint                 Type
----     ---------------                      -------------                 ----
Canary    https://login.microsoftonline.com   https://microsoftgraph.com User-defined
```
Removes user-defined environment.