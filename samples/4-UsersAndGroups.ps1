# Microsoft Graph Users and Groups Snippets

# List of Users
Get-User -top 999 | Select-Object id, displayName, OfficeLocation, BusinessPhones

# List of users with no Office Location
Get-User | Select-Object id, displayName, OfficeLocation, BusinessPhones | Where-Object {!$_.OfficeLocation }

# Update the location of the user
Update-User -UserId $UserId -OfficeLocation $NewLocation

# Get all Groups
Get-Group -top 999 | Select-Object id, DisplayName, GroupTypes

# Get-Details of a single Group
Get-Group -GroupId $groupId | Format-List | more

# Get Owners of a Group
Get-GroupOwner -GroupId $GroupId 

# Translate Directory Objects to Users 
Get-GroupOwner -GroupId $GroupId | ForEach-Object { @{ UserId=$_.Id}} | get-user | Select-Object id, DisplayName, Mail

# Could do the same for Group Members
Get-GroupMember -GroupId $GroupId 

# Get your mail
Get-UserMessage -UserId $UserId -Filter "contains(subject,'Marketing')" | select sentDateTime, subject

# New Group
$group = new-Group -DisplayName "PowerFam" -MailEnabled:$false -mailNickName "powerfam" -SecurityEnabled

# Add member to Group
new-GroupMember -GroupId $Group.Id -DirectoryObjectId $UserId

# View new member to Group
Get-GroupMember -GroupId $group.Id  | ForEach-Object { @{ UserId=$_.Id}} | get-user | Select-Object id, DisplayName, Mail

#Remove Group
Remove-Group -GroupId $Group.Id

# Create a new User
new-user -displayName "Bob Brown" -AccountEnabled -PasswordProfilePassword "{password}" `
         -MailNickname "Bob.Brown" -UserPrincipalName "bob.brown@{tenantdomain}"
