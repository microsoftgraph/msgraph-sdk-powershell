### Example 1: Add a member to a group

```powershell

Import-Module Microsoft.Graph.Groups

$UserId = (Get-MgUser -UserId John.Doe@contoso.com).Id
$GroupId = Get-MgGroup -Filter "displayname eq 'Microsoft Graph PowerShell SDK Gurus'" | Select-Object -ExpandProperty Id
New-MgGroupMember -GroupId $GroupId -DirectoryObjectId $UserId

```
This example adds a user account member to a group
