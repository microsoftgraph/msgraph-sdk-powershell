---
Module Name: Microsoft.Graph.Beta.People
Module Guid: b3261020-6fa9-42b2-87fe-cbcf79c50c38
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.people
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.People Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.People Cmdlets
### [Get-MgBetaUserActivityStatistics](Get-MgBetaUserActivityStatistics.md)
The collection of work activities that a user spent time on during and outside of working hours.
Read-only.
Nullable.

### [Get-MgBetaUserPerson](Get-MgBetaUserPerson.md)
Read-only.
The most relevant people to the user.
The collection is ordered by their relevance to the user, which is determined by the user's communication, collaboration and business relationships.
A person is an aggregation of information from across mail, contacts and social networks.

### [Get-MgBetaUserProfile](Get-MgBetaUserProfile.md)
Retrieve the properties and relationships of a profile object for a given user.
The **profile** resource exposes various rich properties that are descriptive of the user as relationships, for example, anniversaries and education activities.
To get one of these navigation properties, use the corresponding GET method on that property.
See the methods exposed by **profile**.

### [Get-MgBetaUserProfileAccount](Get-MgBetaUserProfileAccount.md)
Get account from users

### [Get-MgBetaUserProfileAddress](Get-MgBetaUserProfileAddress.md)
Represents details of addresses associated with the user.

### [Get-MgBetaUserProfileAnniversary](Get-MgBetaUserProfileAnniversary.md)
Represents the details of meaningful dates associated with a person.

### [Get-MgBetaUserProfileAward](Get-MgBetaUserProfileAward.md)
Represents the details of awards or honors associated with a person.

### [Get-MgBetaUserProfileCertification](Get-MgBetaUserProfileCertification.md)
Represents the details of certifications associated with a person.

### [Get-MgBetaUserProfileEducationalActivity](Get-MgBetaUserProfileEducationalActivity.md)
Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.

### [Get-MgBetaUserProfileEmail](Get-MgBetaUserProfileEmail.md)
Represents detailed information about email addresses associated with the user.

### [Get-MgBetaUserProfileInterest](Get-MgBetaUserProfileInterest.md)
Provides detailed information about interests the user has associated with themselves in various services.

### [Get-MgBetaUserProfileLanguage](Get-MgBetaUserProfileLanguage.md)
Represents detailed information about languages that a user has added to their profile.

### [Get-MgBetaUserProfileName](Get-MgBetaUserProfileName.md)
Represents the names a user has added to their profile.

### [Get-MgBetaUserProfileNote](Get-MgBetaUserProfileNote.md)
Represents notes that a user has added to their profile.

### [Get-MgBetaUserProfilePatent](Get-MgBetaUserProfilePatent.md)
Represents patents that a user has added to their profile.

### [Get-MgBetaUserProfilePhone](Get-MgBetaUserProfilePhone.md)
Represents detailed information about phone numbers associated with a user in various services.

### [Get-MgBetaUserProfilePosition](Get-MgBetaUserProfilePosition.md)
Represents detailed information about work positions associated with a user's profile.

### [Get-MgBetaUserProfileProject](Get-MgBetaUserProfileProject.md)
Represents detailed information about projects associated with a user.

### [Get-MgBetaUserProfilePublication](Get-MgBetaUserProfilePublication.md)
Represents details of any publications a user has added to their profile.

### [Get-MgBetaUserProfileSkill](Get-MgBetaUserProfileSkill.md)
Represents detailed information about skills associated with a user in various services.

### [Get-MgBetaUserProfileWebAccount](Get-MgBetaUserProfileWebAccount.md)
Represents web accounts the user has indicated they use or has added to their user profile.

### [Get-MgBetaUserProfileWebsite](Get-MgBetaUserProfileWebsite.md)
Represents detailed information about websites associated with a user in various services.

### [New-MgBetaUserProfileAccount](New-MgBetaUserProfileAccount.md)
Create a new userAccountInformation object in a user's profile.

### [New-MgBetaUserProfileAddress](New-MgBetaUserProfileAddress.md)
Create a new itemAddress object in a user's profile.

### [New-MgBetaUserProfileAnniversary](New-MgBetaUserProfileAnniversary.md)
Use this API to create a new personAnniversary object in a user's profile.

### [New-MgBetaUserProfileAward](New-MgBetaUserProfileAward.md)
Create a new personAward object in a user's profile.

### [New-MgBetaUserProfileCertification](New-MgBetaUserProfileCertification.md)
Create a new personCertification object in a user's profile.

### [New-MgBetaUserProfileEducationalActivity](New-MgBetaUserProfileEducationalActivity.md)
Create a new educationalActivity in a user's profile.

### [New-MgBetaUserProfileEmail](New-MgBetaUserProfileEmail.md)
Create a new itemEmail object in a user's profile.

### [New-MgBetaUserProfileInterest](New-MgBetaUserProfileInterest.md)
Create a new personInterest.

### [New-MgBetaUserProfileLanguage](New-MgBetaUserProfileLanguage.md)
Use this API to create a new languageProficiency object in a user's profile.

### [New-MgBetaUserProfileName](New-MgBetaUserProfileName.md)
Use this API to create a new personName object in a user's profile.

### [New-MgBetaUserProfileNote](New-MgBetaUserProfileNote.md)
Create a new personAnnotation object in a user's profile.

### [New-MgBetaUserProfilePatent](New-MgBetaUserProfilePatent.md)
Create a new itemPatent object within a user's profile.

### [New-MgBetaUserProfilePhone](New-MgBetaUserProfilePhone.md)
Use this API to create a new itemPhone object in a user's profile.

### [New-MgBetaUserProfilePosition](New-MgBetaUserProfilePosition.md)
Use this API to create a new workPosition in a user's profile.

### [New-MgBetaUserProfileProject](New-MgBetaUserProfileProject.md)
Use this API to create a new projectParticipation object in a user's profile.

### [New-MgBetaUserProfilePublication](New-MgBetaUserProfilePublication.md)
Create a new itemPublication object in a user's profile.

### [New-MgBetaUserProfileSkill](New-MgBetaUserProfileSkill.md)
Use this API to create a new skillProficiency object in a user's profile.

### [New-MgBetaUserProfileWebAccount](New-MgBetaUserProfileWebAccount.md)
Create a new webAccount object in a user's profile.

### [New-MgBetaUserProfileWebsite](New-MgBetaUserProfileWebsite.md)
Create a new personWebsite object in a user's profile.

### [Remove-MgBetaUserProfile](Remove-MgBetaUserProfile.md)
Deletes a profile object from a user's account.

### [Remove-MgBetaUserProfileAccount](Remove-MgBetaUserProfileAccount.md)
Delete navigation property account for users

### [Remove-MgBetaUserProfileAddress](Remove-MgBetaUserProfileAddress.md)
Delete navigation property addresses for users

### [Remove-MgBetaUserProfileAnniversary](Remove-MgBetaUserProfileAnniversary.md)
Delete navigation property anniversaries for users

### [Remove-MgBetaUserProfileAward](Remove-MgBetaUserProfileAward.md)
Delete navigation property awards for users

### [Remove-MgBetaUserProfileCertification](Remove-MgBetaUserProfileCertification.md)
Delete navigation property certifications for users

### [Remove-MgBetaUserProfileEducationalActivity](Remove-MgBetaUserProfileEducationalActivity.md)
Delete navigation property educationalActivities for users

### [Remove-MgBetaUserProfileEmail](Remove-MgBetaUserProfileEmail.md)
Delete navigation property emails for users

### [Remove-MgBetaUserProfileInterest](Remove-MgBetaUserProfileInterest.md)
Delete navigation property interests for users

### [Remove-MgBetaUserProfileLanguage](Remove-MgBetaUserProfileLanguage.md)
Delete navigation property languages for users

### [Remove-MgBetaUserProfileName](Remove-MgBetaUserProfileName.md)
Delete navigation property names for users

### [Remove-MgBetaUserProfileNote](Remove-MgBetaUserProfileNote.md)
Delete navigation property notes for users

### [Remove-MgBetaUserProfilePatent](Remove-MgBetaUserProfilePatent.md)
Delete navigation property patents for users

### [Remove-MgBetaUserProfilePhone](Remove-MgBetaUserProfilePhone.md)
Delete navigation property phones for users

### [Remove-MgBetaUserProfilePosition](Remove-MgBetaUserProfilePosition.md)
Delete navigation property positions for users

### [Remove-MgBetaUserProfileProject](Remove-MgBetaUserProfileProject.md)
Delete navigation property projects for users

### [Remove-MgBetaUserProfilePublication](Remove-MgBetaUserProfilePublication.md)
Delete navigation property publications for users

### [Remove-MgBetaUserProfileSkill](Remove-MgBetaUserProfileSkill.md)
Delete navigation property skills for users

### [Remove-MgBetaUserProfileWebAccount](Remove-MgBetaUserProfileWebAccount.md)
Delete navigation property webAccounts for users

### [Remove-MgBetaUserProfileWebsite](Remove-MgBetaUserProfileWebsite.md)
Delete navigation property websites for users

### [Update-MgBetaUserProfile](Update-MgBetaUserProfile.md)
Update the navigation property profile in users

### [Update-MgBetaUserProfileAccount](Update-MgBetaUserProfileAccount.md)
Update the navigation property account in users

### [Update-MgBetaUserProfileAddress](Update-MgBetaUserProfileAddress.md)
Update the navigation property addresses in users

### [Update-MgBetaUserProfileAnniversary](Update-MgBetaUserProfileAnniversary.md)
Update the navigation property anniversaries in users

### [Update-MgBetaUserProfileAward](Update-MgBetaUserProfileAward.md)
Update the navigation property awards in users

### [Update-MgBetaUserProfileCertification](Update-MgBetaUserProfileCertification.md)
Update the navigation property certifications in users

### [Update-MgBetaUserProfileEducationalActivity](Update-MgBetaUserProfileEducationalActivity.md)
Update the navigation property educationalActivities in users

### [Update-MgBetaUserProfileEmail](Update-MgBetaUserProfileEmail.md)
Update the navigation property emails in users

### [Update-MgBetaUserProfileInterest](Update-MgBetaUserProfileInterest.md)
Update the navigation property interests in users

### [Update-MgBetaUserProfileLanguage](Update-MgBetaUserProfileLanguage.md)
Update the navigation property languages in users

### [Update-MgBetaUserProfileName](Update-MgBetaUserProfileName.md)
Update the navigation property names in users

### [Update-MgBetaUserProfileNote](Update-MgBetaUserProfileNote.md)
Update the navigation property notes in users

### [Update-MgBetaUserProfilePatent](Update-MgBetaUserProfilePatent.md)
Update the navigation property patents in users

### [Update-MgBetaUserProfilePhone](Update-MgBetaUserProfilePhone.md)
Update the navigation property phones in users

### [Update-MgBetaUserProfilePosition](Update-MgBetaUserProfilePosition.md)
Update the navigation property positions in users

### [Update-MgBetaUserProfileProject](Update-MgBetaUserProfileProject.md)
Update the navigation property projects in users

### [Update-MgBetaUserProfilePublication](Update-MgBetaUserProfilePublication.md)
Update the navigation property publications in users

### [Update-MgBetaUserProfileSkill](Update-MgBetaUserProfileSkill.md)
Update the navigation property skills in users

### [Update-MgBetaUserProfileWebAccount](Update-MgBetaUserProfileWebAccount.md)
Update the navigation property webAccounts in users

### [Update-MgBetaUserProfileWebsite](Update-MgBetaUserProfileWebsite.md)
Update the navigation property websites in users

