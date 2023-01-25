### Example 1: Using the Get-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChat -ChatId $chatId -ExpandProperty "members" 
```
This example shows how to use the Get-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChat -ChatId $chatId
```
This example shows how to use the Get-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChat -ChatId $chatId
```
This example shows how to use the Get-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChat -ExpandProperty "lastMessagePreview" 
```
This example shows how to use the Get-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChat -Sort "lastMessagePreview/createdDateTime desc" 
```
This example shows how to use the Get-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
