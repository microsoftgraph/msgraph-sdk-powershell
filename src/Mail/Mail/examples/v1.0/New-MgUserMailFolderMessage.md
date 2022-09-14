### Example 1: Using the New-MgUserMailFolderMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	ReceivedDateTime = [System.DateTime]::Parse("datetime-value")
	SentDateTime = [System.DateTime]::Parse("datetime-value")
	HasAttachments = $true
	Subject = "subject-value"
	Body = @{
		ContentType = ""
		Content = "content-value"
	}
	BodyPreview = "bodyPreview-value"
}
# A UPN can also be used as -UserId.
New-MgUserMailFolderMessage -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
