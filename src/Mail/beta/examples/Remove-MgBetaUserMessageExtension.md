### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessageExtension -UserId $userId -MessageId $messageId -ExtensionId $extensionId
```
This example shows how to use the Remove-MgBetaBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

Get-MgBetaGroupEventExtension -GroupId $groupId -EventId $eventId -ExtensionId $extensionId
```
This example shows how to use the Remove-MgBetaBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId -ExpandProperty "extensions(`$filter=id eq 'Microsoft.OutlookServices.OpenTypeExtension.Com.Contoso.Referral')"
```
This example shows how to use the Remove-MgBetaBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

Get-MgBetaGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId
```
This example shows how to use the Remove-MgBetaBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -Filter "Extensions/any(f:f/id eq 'Com.Contoso.Referral')" -ExpandProperty "Extensions(`$filter=id eq 'Com.Contoso.Referral')"
```
This example shows how to use the Remove-MgBetaBetaUserMessageExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

