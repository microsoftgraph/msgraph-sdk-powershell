### Example 1: Using the Get-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "internetMessageHeaders" 
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "subject,body,bodyPreview,uniqueBody" 
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgUserMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -Property "sender,subject" 
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
