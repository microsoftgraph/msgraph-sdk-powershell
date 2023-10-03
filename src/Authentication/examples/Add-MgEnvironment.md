### Example 1: Add user defined environment
```powershell
PS C:\> Add-MgEnvironment -Name "Canary" -GraphEndpoint "https://canary.graph.microsoft.com" -AzureADEndpoint "https://login.microsoftonline.com"
Name     AzureADEndpoint                      GraphEndpoint                 Type
----     ---------------                      -------------                 ----
Canary    https://login.microsoftonline.com   https://microsoftgraph.com User-defined
```
Adds user defined environment.