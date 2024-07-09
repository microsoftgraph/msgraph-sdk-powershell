### Example 1: List all appCredentialSignInActivities

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportAppCredentialSignInActivity

```
This example will list all appcredentialsigninactivities

### Example 2:  Get an appCredentialSignInActivitiy for a credential by keyId

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportAppCredentialSignInActivity -Filter "keyId eq '83f45296-fb8f-4aaa-a399-ac51084e02b7'" 

```
This example will  get an appcredentialsigninactivitiy for a credential by keyid

### Example 3:  Get an appCredentialSignInActivity for an application by appId

```powershell

Import-Module Microsoft.Graph.Beta.Reports

Get-MgBetaReportAppCredentialSignInActivity -Filter "appId eq 'f4d9654f-0305-4072-878c-8bf266dfe146'" 

```
This example will  get an appcredentialsigninactivity for an application by appid

