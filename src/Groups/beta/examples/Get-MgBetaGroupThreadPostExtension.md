### Example 1: Using the Get-MgBetaGroupThreadPostExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
Get-MgBetaGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId
```
This example shows how to use the Get-MgBetaGroupThreadPostExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
