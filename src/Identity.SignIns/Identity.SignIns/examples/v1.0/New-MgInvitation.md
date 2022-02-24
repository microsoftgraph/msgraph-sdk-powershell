### Example 1: Invite a user and send default invitation email
```powershell
PS C:\> New-MgInvitation -InvitedUserDisplayName "John Doe" -InvitedUserEmailAddress John@contoso.com -InviteRedirectUrl "https://myapplications.microsoft.com" -SendInvitationMessage:$true

Id                                   InviteRedeemUrl                                                                                                   
--                                   ---------------                                                                                                   
e4247160-a778-428a-8218-bcaf717870dd https://login.microsoftonline.com/redeem?rd=https%3a%2f%2finvitations.microsoft.com%2fredeem%2f%3ftenant%3d094a...
```

Invite a guest user with the following:
- Display name is John Doe
- Invited email is John@contoso.com
- Once the user redeems the invitation, the user will be redirected to https://myapplications.microsoft.com
- The standard invitation email will be sent to the specified email

### Example 2: Invite a user and set usertype to member
```powershell
PS C:\> New-MgInvitation -InvitedUserDisplayName "John Doe" -InvitedUserEmailAddress John@contoso.com -InviteRedirectUrl "https://myapplications.microsoft.com" -InvitedUserType Member

Id                                   InviteRedeemUrl                                                                                                   
--                                   ---------------                                                                                                   
2fe815c1-aecc-4f66-b1d0-952a60df2409 https://login.microsoftonline.com/redeem?rd=https%3a%2f%2finvitations.microsoft.com%2fredeem%2f%3ftenant%3d094a...

```

Invite a guest user with the following:
- Display name is John Doe
- Invited email is John@contoso.com
- Once the user redeems the invitation, the user will be redirected to https://myapplications.microsoft.com
- The usertype will be set to Member
- SendInvitationMessage is not specified so by default an invitation email will NOT be sent 
