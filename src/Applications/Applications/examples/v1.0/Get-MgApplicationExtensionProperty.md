### Example 1
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgApplicationExtensionProperty -ApplicationId $applicationId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Applications
Get-MgApplicationExtensionProperty -ApplicationId $applicationId -ExtensionPropertyId $extensionPropertyId
```
