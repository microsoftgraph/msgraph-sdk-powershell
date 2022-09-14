### Example 1
``` powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupThreadPostAttachment -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId
```
