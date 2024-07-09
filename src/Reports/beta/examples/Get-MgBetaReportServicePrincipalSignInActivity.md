### Example 1: Get a list of servicePrincipalSignInActivity objects

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportServicePrincipalSignInActivity

```
This example will get a list of serviceprincipalsigninactivity objects

### Example 2: Get a servicePrincipalSignInActivity filtered by appId

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportServicePrincipalSignInActivity -Filter "appId eq 'f4d9654f-0305-4072-878c-8bf266dfe146'" 

```
This example will get a serviceprincipalsigninactivity filtered by appid

