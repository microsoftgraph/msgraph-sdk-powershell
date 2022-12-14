### Example 1: Using the New-MgBetaUserMailFolderMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	ReceivedDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	SentDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	HasAttachments = $true
	Subject = "subject-value"
	Body = @{
		ContentType = ""
		Content = "content-value"
	}
	BodyPreview = "bodyPreview-value"
}
# A UPN can also be used as -UserId.
New-MgBetaUserMailFolderMessage -UserId $userId -MailFolderId $mailFolderId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserMailFolderMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
