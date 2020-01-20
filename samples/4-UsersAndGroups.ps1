# Microsoft Graph Users and Groups Snippets

# List of Users
Get-MgUser -top 999 | Select-Object id, displayName, OfficeLocation, BusinessPhones

# List of users with no Office Location
Get-MgUser | Select-Object id, displayName, OfficeLocation, BusinessPhones | Where-Object {!$_.OfficeLocation }

# Update the location of the user
Update-MgUser -UserId $UserId -OfficeLocation $NewLocation

# Get all Groups
Get-MgGroup -top 999 | Select-Object id, DisplayName, GroupTypes

# Get-Details of a single Group
Get-MgGroup -GroupId $groupId | Format-List | more

# Get Owners of a Group
Get-MgGroupOwner -GroupId $GroupId 

# Translate Directory Objects to Users 
Get-MgGroupOwner -GroupId $GroupId | ForEach-Object { @{ UserId=$_.Id}} | get-MgUser | Select-Object id, DisplayName, Mail

# Could do the same for Group Members
Get-MgGroupMember -GroupId $GroupId 

# Get your mail
Get-MgUserMessage -UserId $UserId -Filter "contains(subject,'Marketing')" | select sentDateTime, subject

# New Group
$group = new-MgGroup -DisplayName "PowerFam" -MailEnabled:$false -mailNickName "powerfam" -SecurityEnabled

# Add member to Group  
new-MgGroupMember -GroupId $Group.Id -DirectoryObjectId $UserId

# View new member to Group
Get-MgGroupMember -GroupId $group.Id  | ForEach-Object { @{ UserId=$_.Id}} | get-user | Select-Object id, DisplayName, Mail

#Remove Group
Remove-MgGroup -GroupId $Group.Id

# Create a new User
new-MgUser -displayName "Bob Brown" -AccountEnabled -PasswordProfilePassword "{password}" `
         -MailNickname "Bob.Brown" -UserPrincipalName "bob.brown@{tenantdomain}"
