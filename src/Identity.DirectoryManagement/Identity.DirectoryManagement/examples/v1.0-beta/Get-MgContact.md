### Example 1: Retrieve contact objects in the directory 

```powershell
Get-MgBetaContact | Format-List Id, DisplayName, Mail, MailNickname

Id           : 5d58402b-3cb2-4b17-b913-299a72c84204
DisplayName  : Bob Kelly (TAILSPIN)
Mail         : bobk@tailspintoys.com
MailNickname : BobKTAILSPIN
```

This example retrieves all contact objects in the directory.
