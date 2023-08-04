### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "members"
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "lastMessagePreview"
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

