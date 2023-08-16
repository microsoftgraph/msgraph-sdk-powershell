### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ExpandProperty "lastMessagePreview" 

```
This example shows how to use the Get-MgBetaChat Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -Sort "lastMessagePreview/createdDateTime desc" 

```
This example shows how to use the Get-MgBetaChat Cmdlet.

