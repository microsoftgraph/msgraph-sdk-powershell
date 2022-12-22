---
external help file:
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/update-mguser
schema: 2.0.0
---

# Update-MgUser

## SYNOPSIS
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUser -UserId <String> [-AboutMe <String>] [-AccountEnabled] [-AdditionalProperties <Hashtable>]
 [-AgeGroup <String>] [-AssignedLicenses <IMicrosoftGraphAssignedLicense[]>]
 [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>] [-Authentication <IMicrosoftGraphAuthentication>]
 [-AuthorizationInfo <IMicrosoftGraphAuthorizationInfo>] [-Birthday <DateTime>] [-BusinessPhones <String[]>]
 [-Calendar <IMicrosoftGraphCalendar>] [-City <String>] [-CompanyName <String>]
 [-ConsentProvidedForMinor <String>] [-Country <String>] [-CreatedDateTime <DateTime>]
 [-CreationType <String>] [-DeletedDateTime <DateTime>] [-Department <String>]
 [-DeviceEnrollmentLimit <Int32>] [-DisplayName <String>] [-Drive <IMicrosoftGraphDrive>]
 [-EmployeeHireDate <DateTime>] [-EmployeeId <String>] [-EmployeeOrgData <IMicrosoftGraphEmployeeOrgData>]
 [-EmployeeType <String>] [-ExternalUserState <String>] [-ExternalUserStateChangeDateTime <DateTime>]
 [-FaxNumber <String>] [-GivenName <String>] [-HireDate <DateTime>] [-Id <String>]
 [-Identities <IMicrosoftGraphObjectIdentity[]>] [-ImAddresses <String[]>]
 [-InferenceClassification <IMicrosoftGraphInferenceClassification>]
 [-Insights <IMicrosoftGraphOfficeGraphInsights>] [-Interests <String[]>] [-IsResourceAccount]
 [-JobTitle <String>] [-LastPasswordChangeDateTime <DateTime>] [-LegalAgeGroupClassification <String>]
 [-LicenseAssignmentStates <IMicrosoftGraphLicenseAssignmentState[]>] [-Mail <String>]
 [-MailboxSettings <IMicrosoftGraphMailboxSettings>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MobilePhone <String>] [-MySite <String>]
 [-OfficeLocation <String>] [-Onenote <IMicrosoftGraphOnenote>] [-OnPremisesDistinguishedName <String>]
 [-OnPremisesDomainName <String>]
 [-OnPremisesExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]
 [-OnPremisesImmutableId <String>] [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]
 [-OnPremisesSamAccountName <String>] [-OnPremisesSecurityIdentifier <String>] [-OnPremisesSyncEnabled]
 [-OnPremisesUserPrincipalName <String>] [-OtherMails <String[]>] [-Outlook <IMicrosoftGraphOutlookUser>]
 [-PasswordPolicies <String>] [-PasswordProfile <IMicrosoftGraphPasswordProfile>] [-PastProjects <String[]>]
 [-Photo <IMicrosoftGraphProfilePhoto>] [-Planner <IMicrosoftGraphPlannerUser>] [-PostalCode <String>]
 [-PreferredDataLocation <String>] [-PreferredLanguage <String>] [-PreferredName <String>]
 [-Presence <IMicrosoftGraphPresence>] [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]
 [-ProxyAddresses <String[]>] [-Responsibilities <String[]>] [-Schools <String[]>]
 [-SecurityIdentifier <String>] [-Settings <IMicrosoftGraphUserSettings>] [-ShowInAddressList]
 [-SignInSessionsValidFromDateTime <DateTime>] [-Skills <String[]>] [-State <String>]
 [-StreetAddress <String>] [-Surname <String>] [-Teamwork <IMicrosoftGraphUserTeamwork>]
 [-Todo <IMicrosoftGraphTodo>] [-UsageLocation <String>] [-UserPrincipalName <String>] [-UserType <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUser -UserId <String> -BodyParameter <IMicrosoftGraphUser> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUser -InputObject <IUsersIdentity> -BodyParameter <IMicrosoftGraphUser> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUser -InputObject <IUsersIdentity> [-AboutMe <String>] [-AccountEnabled]
 [-AdditionalProperties <Hashtable>] [-AgeGroup <String>]
 [-AssignedLicenses <IMicrosoftGraphAssignedLicense[]>] [-AssignedPlans <IMicrosoftGraphAssignedPlan[]>]
 [-Authentication <IMicrosoftGraphAuthentication>] [-AuthorizationInfo <IMicrosoftGraphAuthorizationInfo>]
 [-Birthday <DateTime>] [-BusinessPhones <String[]>] [-Calendar <IMicrosoftGraphCalendar>] [-City <String>]
 [-CompanyName <String>] [-ConsentProvidedForMinor <String>] [-Country <String>] [-CreatedDateTime <DateTime>]
 [-CreationType <String>] [-DeletedDateTime <DateTime>] [-Department <String>]
 [-DeviceEnrollmentLimit <Int32>] [-DisplayName <String>] [-Drive <IMicrosoftGraphDrive>]
 [-EmployeeHireDate <DateTime>] [-EmployeeId <String>] [-EmployeeOrgData <IMicrosoftGraphEmployeeOrgData>]
 [-EmployeeType <String>] [-ExternalUserState <String>] [-ExternalUserStateChangeDateTime <DateTime>]
 [-FaxNumber <String>] [-GivenName <String>] [-HireDate <DateTime>] [-Id <String>]
 [-Identities <IMicrosoftGraphObjectIdentity[]>] [-ImAddresses <String[]>]
 [-InferenceClassification <IMicrosoftGraphInferenceClassification>]
 [-Insights <IMicrosoftGraphOfficeGraphInsights>] [-Interests <String[]>] [-IsResourceAccount]
 [-JobTitle <String>] [-LastPasswordChangeDateTime <DateTime>] [-LegalAgeGroupClassification <String>]
 [-LicenseAssignmentStates <IMicrosoftGraphLicenseAssignmentState[]>] [-Mail <String>]
 [-MailboxSettings <IMicrosoftGraphMailboxSettings>] [-MailNickname <String>]
 [-Manager <IMicrosoftGraphDirectoryObject>] [-MobilePhone <String>] [-MySite <String>]
 [-OfficeLocation <String>] [-Onenote <IMicrosoftGraphOnenote>] [-OnPremisesDistinguishedName <String>]
 [-OnPremisesDomainName <String>]
 [-OnPremisesExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]
 [-OnPremisesImmutableId <String>] [-OnPremisesLastSyncDateTime <DateTime>]
 [-OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]
 [-OnPremisesSamAccountName <String>] [-OnPremisesSecurityIdentifier <String>] [-OnPremisesSyncEnabled]
 [-OnPremisesUserPrincipalName <String>] [-OtherMails <String[]>] [-Outlook <IMicrosoftGraphOutlookUser>]
 [-PasswordPolicies <String>] [-PasswordProfile <IMicrosoftGraphPasswordProfile>] [-PastProjects <String[]>]
 [-Photo <IMicrosoftGraphProfilePhoto>] [-Planner <IMicrosoftGraphPlannerUser>] [-PostalCode <String>]
 [-PreferredDataLocation <String>] [-PreferredLanguage <String>] [-PreferredName <String>]
 [-Presence <IMicrosoftGraphPresence>] [-ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]
 [-ProxyAddresses <String[]>] [-Responsibilities <String[]>] [-Schools <String[]>]
 [-SecurityIdentifier <String>] [-Settings <IMicrosoftGraphUserSettings>] [-ShowInAddressList]
 [-SignInSessionsValidFromDateTime <DateTime>] [-Skills <String[]>] [-State <String>]
 [-StreetAddress <String>] [-Surname <String>] [-Teamwork <IMicrosoftGraphUserTeamwork>]
 [-Todo <IMicrosoftGraphTodo>] [-UsageLocation <String>] [-UserPrincipalName <String>] [-UserType <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a user object.
Not all properties can be updated by Member or Guest users with their default permissions without Administrator roles.
Compare member and guest default permissions to see properties they can manage.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AboutMe
A freeform text entry field for the user to describe themselves.
Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccountEnabled
true if the account is enabled; otherwise, false.
This property is required when a user is created.
Returned only on $select.
Supports $filter (eq, ne, not, and in).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgeGroup
Sets the age group of the user.
Allowed values: null, Minor, NotAdult and Adult.
Refer to the legal age group property definitions for further information.
Returned only on $select.
Supports $filter (eq, ne, not, and in).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedLicenses
The licenses that are assigned to the user, including inherited (group-based) licenses.
This property doesn't differentiate directly-assigned and inherited licenses.
Use the licenseAssignmentStates property to identify the directly-assigned and inherited licenses.
Not nullable.
Returned only on $select.
Supports $filter (eq, not, /$count eq 0, /$count ne 0).
To construct, see NOTES section for ASSIGNEDLICENSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAssignedLicense[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedPlans
The plans that are assigned to the user.
Read-only.
Not nullable.
Returned only on $select.
Supports $filter (eq and not).
To construct, see NOTES section for ASSIGNEDPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAssignedPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Authentication
authentication
To construct, see NOTES section for AUTHENTICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthentication
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthorizationInfo
authorizationInfo
To construct, see NOTES section for AUTHORIZATIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Birthday
The birthday of the user.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Returned only on $select.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
user
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUser
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessPhones
The telephone numbers for the user.
NOTE: Although this is a string collection, only one number can be set for this property.
Read-only for users synced from on-premises directory.
Returned by default.
Supports $filter (eq, not, ge, le, startsWith).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Calendar
calendar
To construct, see NOTES section for CALENDAR properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendar
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -City
The city in which the user is located.
Maximum length is 128 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyName
The company name which the user is associated.
This property can be useful for describing the company that an external user comes from.
The maximum length is 64 characters.Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConsentProvidedForMinor
Sets whether consent has been obtained for minors.
Allowed values: null, Granted, Denied and NotRequired.
Refer to the legal age group property definitions for further information.
Returned only on $select.
Supports $filter (eq, ne, not, and in).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Country
The country/region in which the user is located; for example, US or UK.
Maximum length is 128 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the user was created, in ISO 8601 format and in UTC time.
The value cannot be modified and is automatically populated when the entity is created.
Nullable.
For on-premises users, the value represents when they were first created in Azure AD.
Property is null for some users created before June 2018 and on-premises users that were synced to Azure AD before June 2018.
Read-only.
Read-only.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in).

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreationType
Indicates whether the user account was created through one of the following methods: As a regular school or work account (null).
As an external account (Invitation).
As a local account for an Azure Active Directory B2C tenant (LocalAccount).
Through self-service sign-up by an internal user using email verification (EmailVerified).
Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp).
Read-only.Returned only on $select.
Supports $filter (eq, ne, not, in).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Department
The name for the department in which the user works.
Maximum length is 64 characters.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceEnrollmentLimit
The limit on the maximum number of devices that the user is permitted to enroll.
Allowed values are 5 or 1000.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name displayed in the address book for the user.
This is usually the combination of the user's first name, middle initial and last name.
This property is required when a user is created and it cannot be cleared during updates.
Maximum length is 256 characters.
Returned by default.
Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Drive
drive
To construct, see NOTES section for DRIVE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDrive
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmployeeHireDate
The date and time when the user was hired or will start work in case of a future hire.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in).

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmployeeId
The employee identifier assigned to the user by the organization.
The maximum length is 16 characters.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmployeeOrgData
employeeOrgData
To construct, see NOTES section for EMPLOYEEORGDATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmployeeOrgData
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmployeeType
Captures enterprise worker type.
For example, Employee, Contractor, Consultant, or Vendor.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in, startsWith).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserState
For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status.
For invited users, the state can be PendingAcceptance or Accepted, or null for all other users.
Returned only on $select.
Supports $filter (eq, ne, not , in).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalUserStateChangeDateTime
Shows the timestamp for the latest change to the externalUserState property.
Returned only on $select.
Supports $filter (eq, ne, not , in).

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FaxNumber
The fax number of the user.
Returned only on $select.
Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GivenName
The given name (first name) of the user.
Maximum length is 64 characters.
Returned by default.
Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HireDate
The hire date of the user.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Returned only on $select.
Note: This property is specific to SharePoint Online.
We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identities
Represents the identities that can be used to sign in to this user account.
An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account.
May contain multiple items with the same signInType value.
Returned only on $select.
Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.
To construct, see NOTES section for IDENTITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphObjectIdentity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImAddresses
The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user.
Read-only.
Returned only on $select.
Supports $filter (eq, not, ge, le, startsWith).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InferenceClassification
inferenceClassification
To construct, see NOTES section for INFERENCECLASSIFICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassification
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Insights
officeGraphInsights
To construct, see NOTES section for INSIGHTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeGraphInsights
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Interests
A list for the user to describe their interests.
Returned only on $select.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsResourceAccount
Do not use – reserved for future use.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JobTitle
The user's job title.
Maximum length is 128 characters.
Returned by default.
Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastPasswordChangeDateTime
The time when this Azure AD user last changed their password or when their password was created, whichever date the latest action was performed.
The date and time information uses ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Returned only on $select.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LegalAgeGroupClassification
Used by enterprise applications to determine the legal age group of the user.
This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties.
Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult.
Refer to the legal age group property definitions for further information.
Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LicenseAssignmentStates
State of license assignments for this user.
Also indicates licenses that are directly-assigned and those that the user has inherited through group memberships.
Read-only.
Returned only on $select.
To construct, see NOTES section for LICENSEASSIGNMENTSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLicenseAssignmentState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mail
The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com.
Changes to this property will also update the user's proxyAddresses collection to include the value as an SMTP address.
This property cannot contain accent characters.
NOTE: We do not recommend updating this property for Azure AD B2C user profiles.
Use the otherMails property instead.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailboxSettings
mailboxSettings
To construct, see NOTES section for MAILBOXSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMailboxSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MailNickname
The mail alias for the user.
This property must be specified when a user is created.
Maximum length is 64 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manager
directoryObject
To construct, see NOTES section for MANAGER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobilePhone
The primary cellular telephone number for the user.
Read-only for users synced from on-premises directory.
Maximum length is 64 characters.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MySite
The URL for the user's personal site.
Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeLocation
The office location in the user's place of business.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Onenote
onenote
To construct, see NOTES section for ONENOTE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenote
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesDistinguishedName
Contains the on-premises Active Directory distinguished name or DN.
The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.
Read-only.
Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesDomainName
Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory.
The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.
Read-only.
Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesExtensionAttributes
onPremisesExtensionAttributes
To construct, see NOTES section for ONPREMISESEXTENSIONATTRIBUTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesExtensionAttributes
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesImmutableId
This property is used to associate an on-premises Active Directory user account to their Azure AD user object.
This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property.
NOTE: The $ and _ characters cannot be used when specifying this property.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in)..

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesLastSyncDateTime
Indicates the last time at which the object was synced with the on-premises directory; for example: 2013-02-16T03:04:54Z.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in).

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesProvisioningErrors
Errors when using Microsoft synchronization product during provisioning.
Returned only on $select.
Supports $filter (eq, not, ge, le).
To construct, see NOTES section for ONPREMISESPROVISIONINGERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesProvisioningError[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSamAccountName
Contains the on-premises samAccountName synchronized from the on-premises directory.
The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.
Read-only.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSecurityIdentifier
Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud.
Read-only.
Returned only on $select.
Supports $filter (eq including on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesSyncEnabled
true if this user object is currently being synced from an on-premises Active Directory (AD); otherwise the user isn't being synced and can be managed in Azure Active Directory (Azure AD).
Read-only.
Returned only on $select.
Supports $filter (eq, ne, not, in, and eq on null values).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnPremisesUserPrincipalName
Contains the on-premises userPrincipalName synchronized from the on-premises directory.
The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.
Read-only.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OtherMails
A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com'].
NOTE: This property cannot contain accent characters.
Returned only on $select.
Supports $filter (eq, not, ge, le, in, startsWith, endsWith, /$count eq 0, /$count ne 0).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Outlook
outlookUser
To construct, see NOTES section for OUTLOOK properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOutlookUser
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordPolicies
Specifies password policies for the user.
This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified.
DisablePasswordExpiration can also be specified.
The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword.
Returned only on $select.
For more information on the default password policies, see Azure AD pasword policies.
Supports $filter (ne, not, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordProfile
passwordProfile
To construct, see NOTES section for PASSWORDPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordProfile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PastProjects
A list for the user to enumerate their past projects.
Returned only on $select.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Photo
profilePhoto
To construct, see NOTES section for PHOTO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Planner
plannerUser
To construct, see NOTES section for PLANNER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUser
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostalCode
The postal code for the user's postal address.
The postal code is specific to the user's country/region.
In the United States of America, this attribute contains the ZIP code.
Maximum length is 40 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredDataLocation
The preferred data location for the user.
For more information, see OneDrive Online Multi-Geo.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredLanguage
The preferred language for the user.
Should follow ISO 639-1 Code; for example en-US.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreferredName
The preferred name for the user.
Not Supported.
This attribute returns an empty string.Returned only on $select.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Presence
presence
To construct, see NOTES section for PRESENCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPresence
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProvisionedPlans
The plans that are provisioned for the user.
Read-only.
Not nullable.
Returned only on $select.
Supports $filter (eq, not, ge, le).
To construct, see NOTES section for PROVISIONEDPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisionedPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyAddresses
For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com'].
Changes to the mail property will also update this collection to include the value as an SMTP address.
For more information, see mail and proxyAddresses properties.
The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses.
For Azure AD B2C accounts, this property has a limit of ten unique addresses.
Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center.
Not nullable.
Returned only on $select.
Supports $filter (eq, not, ge, le, startsWith, endsWith, /$count eq 0, /$count ne 0).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Responsibilities
A list for the user to enumerate their responsibilities.
Returned only on $select.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schools
A list for the user to enumerate the schools they have attended.
Returned only on $select.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityIdentifier
Security identifier (SID) of the user, used in Windows scenarios.
Read-only.
Returned by default.
Supports $select and $filter (eq, not, ge, le, startsWith).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
userSettings
To construct, see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShowInAddressList
Do not use in Microsoft Graph.
Manage this property through the Microsoft 365 admin center instead.
Represents whether the user should be included in the Outlook global address list.
See Known issue.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignInSessionsValidFromDateTime
Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).
If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint.
Read-only.
Use revokeSignInSessions to reset.
Returned only on $select.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skills
A list for the user to enumerate their skills.
Returned only on $select.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
The state or province in the user's address.
Maximum length is 128 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StreetAddress
The street address of the user's place of business.
Maximum length is 1024 characters.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Surname
The user's surname (family name or last name).
Maximum length is 64 characters.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Teamwork
userTeamwork
To construct, see NOTES section for TEAMWORK properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserTeamwork
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Todo
todo
To construct, see NOTES section for TODO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTodo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UsageLocation
A two letter country code (ISO standard 3166).
Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.
Examples include: US, JP, and GB.
Not nullable.
Returned only on $select.
Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
The user principal name (UPN) of the user.
The UPN is an Internet-style login name for the user based on the Internet standard RFC 822.
By convention, this should map to the user's email name.
The general format is alias@domain, where domain must be present in the tenant's collection of verified domains.
This property is required when a user is created.
The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters.
Only the following characters are allowed A - Z, a - z, 0 - 9, ' .
- _ ! # ^ ~.
For the complete list of allowed characters, see username policies.
Returned by default.
Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserType
A string value that can be used to classify user types in your directory, such as Member and Guest.
Returned only on $select.
Supports $filter (eq, ne, not, in, and eq on null values).
NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUser

### Microsoft.Graph.PowerShell.Models.IUsersIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUser

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNEDLICENSES <IMicrosoftGraphAssignedLicense[]>`: The licenses that are assigned to the user, including inherited (group-based) licenses. This property doesn't differentiate directly-assigned and inherited licenses. Use the licenseAssignmentStates property to identify the directly-assigned and inherited licenses. Not nullable. Returned only on $select. Supports $filter (eq, not, /$count eq 0, /$count ne 0).
  - `[DisabledPlans <String[]>]`: A collection of the unique identifiers for plans that have been disabled.
  - `[SkuId <String>]`: The unique identifier for the SKU.

`ASSIGNEDPLANS <IMicrosoftGraphAssignedPlan[]>`: The plans that are assigned to the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq and not).
  - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[CapabilityStatus <String>]`: Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut. See a detailed description of each value.
  - `[Service <String>]`: The name of the service; for example, exchange.
  - `[ServicePlanId <String>]`: A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.

`AUTHENTICATION <IMicrosoftGraphAuthentication>`: authentication
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`AUTHORIZATIONINFO <IMicrosoftGraphAuthorizationInfo>`: authorizationInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertificateUserIds <String[]>]`: 

`BODYPARAMETER <IMicrosoftGraphUser>`: user
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AboutMe <String>]`: A freeform text entry field for the user to describe themselves. Returned only on $select.
  - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. This property is required when a user is created. Returned only on $select. Supports $filter (eq, ne, not, and in).
  - `[AgeGroup <String>]`: Sets the age group of the user. Allowed values: null, Minor, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).
  - `[AssignedLicenses <IMicrosoftGraphAssignedLicense[]>]`: The licenses that are assigned to the user, including inherited (group-based) licenses. This property doesn't differentiate directly-assigned and inherited licenses. Use the licenseAssignmentStates property to identify the directly-assigned and inherited licenses.  Not nullable. Returned only on $select. Supports $filter (eq, not, /$count eq 0, /$count ne 0).
    - `[DisabledPlans <String[]>]`: A collection of the unique identifiers for plans that have been disabled.
    - `[SkuId <String>]`: The unique identifier for the SKU.
  - `[AssignedPlans <IMicrosoftGraphAssignedPlan[]>]`: The plans that are assigned to the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq and not).
    - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[CapabilityStatus <String>]`: Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut. See a detailed description of each value.
    - `[Service <String>]`: The name of the service; for example, exchange.
    - `[ServicePlanId <String>]`: A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.
  - `[Authentication <IMicrosoftGraphAuthentication>]`: authentication
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AuthorizationInfo <IMicrosoftGraphAuthorizationInfo>]`: authorizationInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CertificateUserIds <String[]>]`: 
  - `[Birthday <DateTime?>]`: The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.
  - `[BusinessPhones <String[]>]`: The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property. Read-only for users synced from on-premises directory. Returned by default. Supports $filter (eq, not, ge, le, startsWith).
  - `[Calendar <IMicrosoftGraphCalendar>]`: calendar
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
    - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
    - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
    - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
    - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[Color <String>]`: 
    - `[DefaultOnlineMeetingProvider <String>]`: 
    - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
    - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
    - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
    - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
    - `[Name <String>]`: The calendar name.
    - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
  - `[City <String>]`: The city in which the user is located. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[CompanyName <String>]`: The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length is 64 characters.Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[ConsentProvidedForMinor <String>]`: Sets whether consent has been obtained for minors. Allowed values: null, Granted, Denied and NotRequired. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).
  - `[Country <String>]`: The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[CreatedDateTime <DateTime?>]`: The date and time the user was created, in ISO 8601 format and in UTC time. The value cannot be modified and is automatically populated when the entity is created. Nullable. For on-premises users, the value represents when they were first created in Azure AD. Property is null for some users created before June 2018 and on-premises users that were synced to Azure AD before June 2018. Read-only.  Read-only. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).
  - `[CreationType <String>]`: Indicates whether the user account was created through one of the following methods:  As a regular school or work account (null). As an external account (Invitation). As a local account for an Azure Active Directory B2C tenant (LocalAccount). Through self-service sign-up by an internal user using email verification (EmailVerified). Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp). Read-only.Returned only on $select. Supports $filter (eq, ne, not, in).
  - `[Department <String>]`: The name for the department in which the user works. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, and eq on null values).
  - `[DeviceEnrollmentLimit <Int32?>]`: The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
  - `[DisplayName <String>]`: The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.
  - `[Drive <IMicrosoftGraphDrive>]`: drive
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedByUser <IMicrosoftGraphUser>]`: user
    - `[CreatedDateTime <DateTime?>]`: Date and time of item creation. Read-only.
    - `[Description <String>]`: Provides a user-visible description of the item. Optional.
    - `[ETag <String>]`: ETag for the item. Read-only.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedByUser <IMicrosoftGraphUser>]`: user
    - `[LastModifiedDateTime <DateTime?>]`: Date and time the item was last modified. Read-only.
    - `[Name <String>]`: The name of the item. Read-write.
    - `[ParentReference <IMicrosoftGraphItemReference>]`: itemReference
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
      - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
      - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
      - `[Name <String>]`: The name of the item being referenced. Read-only.
      - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
      - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
      - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
        - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
        - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
        - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
        - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
        - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
        - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
      - `[SiteId <String>]`: For OneDrive for Business and SharePoint, this property represents the ID of the site that contains the parent document library of the driveItem resource. The value is the same as the id property of that [site][] resource. It is an opaque string that consists of three identifiers of the site. For OneDrive, this property is not populated.
    - `[WebUrl <String>]`: URL that displays the resource in the browser. Read-only.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DriveType <String>]`: Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.
    - `[List <IMicrosoftGraphList>]`: list
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedByUser <IMicrosoftGraphUser>]`: user
      - `[CreatedDateTime <DateTime?>]`: Date and time of item creation. Read-only.
      - `[Description <String>]`: Provides a user-visible description of the item. Optional.
      - `[ETag <String>]`: ETag for the item. Read-only.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedByUser <IMicrosoftGraphUser>]`: user
      - `[LastModifiedDateTime <DateTime?>]`: Date and time the item was last modified. Read-only.
      - `[Name <String>]`: The name of the item. Read-write.
      - `[ParentReference <IMicrosoftGraphItemReference>]`: itemReference
      - `[WebUrl <String>]`: URL that displays the resource in the browser. Read-only.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[DisplayName <String>]`: The displayable title of the list.
      - `[Drive <IMicrosoftGraphDrive>]`: drive
      - `[List <IMicrosoftGraphListInfo>]`: listInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ContentTypesEnabled <Boolean?>]`: If true, indicates that content types are enabled for this list.
        - `[Hidden <Boolean?>]`: If true, indicates that the list is not normally visible in the SharePoint user experience.
        - `[Template <String>]`: An enumerated value that represents the base list template used in creating the list. Possible values include documentLibrary, genericList, task, survey, announcements, contacts, and more.
      - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[System <IMicrosoftGraphSystemFacet>]`: systemFacet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Owner <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Quota <IMicrosoftGraphQuota>]`: quota
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Deleted <Int64?>]`: Total space consumed by files in the recycle bin, in bytes. Read-only.
      - `[Remaining <Int64?>]`: Total space remaining before reaching the quota limit, in bytes. Read-only.
      - `[State <String>]`: Enumeration value that indicates the state of the storage space. Read-only.
      - `[StoragePlanInformation <IMicrosoftGraphStoragePlanInformation>]`: storagePlanInformation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UpgradeAvailable <Boolean?>]`: Indicates whether there are higher storage quota plans available. Read-only.
      - `[Total <Int64?>]`: Total allowed storage space, in bytes. Read-only.
      - `[Used <Int64?>]`: Total space used, in bytes. Read-only.
    - `[Root <IMicrosoftGraphDriveItem>]`: driveItem
    - `[SharePointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
    - `[System <IMicrosoftGraphSystemFacet>]`: systemFacet
  - `[EmployeeHireDate <DateTime?>]`: The date and time when the user was hired or will start work in case of a future hire. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).
  - `[EmployeeId <String>]`: The employee identifier assigned to the user by the organization. The maximum length is 16 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
  - `[EmployeeOrgData <IMicrosoftGraphEmployeeOrgData>]`: employeeOrgData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CostCenter <String>]`: The cost center associated with the user. Returned only on $select. Supports $filter.
    - `[Division <String>]`: The name of the division in which the user works. Returned only on $select. Supports $filter.
  - `[EmployeeType <String>]`: Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith).
  - `[ExternalUserState <String>]`: For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Returned only on $select. Supports $filter (eq, ne, not , in).
  - `[ExternalUserStateChangeDateTime <DateTime?>]`: Shows the timestamp for the latest change to the externalUserState property. Returned only on $select. Supports $filter (eq, ne, not , in).
  - `[FaxNumber <String>]`: The fax number of the user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
  - `[GivenName <String>]`: The given name (first name) of the user. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
  - `[HireDate <DateTime?>]`: The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.
  - `[Identities <IMicrosoftGraphObjectIdentity[]>]`: Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Returned only on $select. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.
    - `[Issuer <String>]`: Specifies the issuer of the identity, for example facebook.com.For local accounts (where signInType is not federated), this property is the local B2C tenant default domain name, for example contoso.onmicrosoft.com.For external users from other Azure AD organization, this will be the domain of the federated organization, for example contoso.com.Supports $filter. 512 character limit.
    - `[IssuerAssignedId <String>]`: Specifies the unique identifier assigned to the user by the issuer. The combination of issuer and issuerAssignedId must be unique within the organization. Represents the sign-in name for the user, when signInType is set to emailAddress or userName (also known as local accounts).When signInType is set to: emailAddress, (or a custom string that starts with emailAddress like emailAddress1) issuerAssignedId must be a valid email addressuserName, issuerAssignedId must be a valid local part of an email addressSupports $filter. 100 character limit.
    - `[SignInType <String>]`: Specifies the user sign-in types in your directory, such as emailAddress, userName, federated, or userPrincipalName. federated represents a unique identifier for a user from an issuer, that can be in any format chosen by the issuer. Setting or updating a userPrincipalName identity will update the value of the userPrincipalName property on the user object. The validations performed on the userPrincipalName property on the user object, for example, verified domains and acceptable characters, will be performed when setting or updating a userPrincipalName identity. Additional validation is enforced on issuerAssignedId when the sign-in type is set to emailAddress or userName. This property can also be set to any custom string.
  - `[ImAddresses <String[]>]`: The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith).
  - `[InferenceClassification <IMicrosoftGraphInferenceClassification>]`: inferenceClassification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Insights <IMicrosoftGraphOfficeGraphInsights>]`: officeGraphInsights
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Interests <String[]>]`: A list for the user to describe their interests. Returned only on $select.
  - `[IsResourceAccount <Boolean?>]`: Do not use – reserved for future use.
  - `[JobTitle <String>]`: The user's job title. Maximum length is 128 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
  - `[LastPasswordChangeDateTime <DateTime?>]`: The time when this Azure AD user last changed their password or when their password was created, whichever date the latest action was performed. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.
  - `[LegalAgeGroupClassification <String>]`: Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select.
  - `[LicenseAssignmentStates <IMicrosoftGraphLicenseAssignmentState[]>]`: State of license assignments for this user. Also indicates licenses that are directly-assigned and those that the user has inherited through group memberships. Read-only. Returned only on $select.
    - `[AssignedByGroup <String>]`: 
    - `[DisabledPlans <String[]>]`: 
    - `[Error <String>]`: 
    - `[LastUpdatedDateTime <DateTime?>]`: 
    - `[SkuId <String>]`: 
    - `[State <String>]`: 
  - `[Mail <String>]`: The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com. Changes to this property will also update the user's proxyAddresses collection to include the value as an SMTP address. This property cannot contain accent characters.  NOTE: We do not recommend updating this property for Azure AD B2C user profiles. Use the otherMails property instead. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).
  - `[MailNickname <String>]`: The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[MailboxSettings <IMicrosoftGraphMailboxSettings>]`: mailboxSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ArchiveFolder <String>]`: Folder ID of an archive folder for the user.
    - `[AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>]`: automaticRepliesSetting
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExternalAudience <String>]`: 
      - `[ExternalReplyMessage <String>]`: The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
      - `[InternalReplyMessage <String>]`: The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
      - `[ScheduledEndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[ScheduledStartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[Status <String>]`: 
    - `[DateFormat <String>]`: The date format for the user's mailbox.
    - `[DelegateMeetingMessageDeliveryOptions <String>]`: 
    - `[Language <IMicrosoftGraphLocaleInfo>]`: localeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
      - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
    - `[TimeFormat <String>]`: The time format for the user's mailbox.
    - `[TimeZone <String>]`: The default time zone for the user's mailbox.
    - `[UserPurpose <String>]`: 
    - `[WorkingHours <IMicrosoftGraphWorkingHours>]`: workingHours
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DaysOfWeek <String[]>]`: The days of the week on which the user works.
      - `[EndTime <String>]`: The time of the day that the user stops working.
      - `[StartTime <String>]`: The time of the day that the user starts working.
      - `[TimeZone <IMicrosoftGraphTimeZoneBase>]`: timeZoneBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Name <String>]`: The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.
  - `[Manager <IMicrosoftGraphDirectoryObject>]`: directoryObject
  - `[MobilePhone <String>]`: The primary cellular telephone number for the user. Read-only for users synced from on-premises directory. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[MySite <String>]`: The URL for the user's personal site. Returned only on $select.
  - `[OfficeLocation <String>]`: The office location in the user's place of business. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[OnPremisesDistinguishedName <String>]`: Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.
  - `[OnPremisesDomainName <String>]`: Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.
  - `[OnPremisesExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]`: onPremisesExtensionAttributes
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExtensionAttribute1 <String>]`: First customizable extension attribute.
    - `[ExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
    - `[ExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
    - `[ExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
    - `[ExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
    - `[ExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
    - `[ExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
    - `[ExtensionAttribute2 <String>]`: Second customizable extension attribute.
    - `[ExtensionAttribute3 <String>]`: Third customizable extension attribute.
    - `[ExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
    - `[ExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
    - `[ExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
    - `[ExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
    - `[ExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
    - `[ExtensionAttribute9 <String>]`: Ninth customizable extension attribute.
  - `[OnPremisesImmutableId <String>]`: This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property. NOTE: The $ and _ characters cannot be used when specifying this property. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in)..
  - `[OnPremisesLastSyncDateTime <DateTime?>]`: Indicates the last time at which the object was synced with the on-premises directory; for example: 2013-02-16T03:04:54Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in).
  - `[OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]`: Errors when using Microsoft synchronization product during provisioning. Returned only on $select. Supports $filter (eq, not, ge, le).
  - `[OnPremisesSamAccountName <String>]`: Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).
  - `[OnPremisesSecurityIdentifier <String>]`: Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only. Returned only on $select.  Supports $filter (eq including on null values).
  - `[OnPremisesSyncEnabled <Boolean?>]`: true if this user object is currently being synced from an on-premises Active Directory (AD); otherwise the user isn't being synced and can be managed in Azure Active Directory (Azure AD). Read-only. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).
  - `[OnPremisesUserPrincipalName <String>]`: Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).
  - `[Onenote <IMicrosoftGraphOnenote>]`: onenote
  - `[OtherMails <String[]>]`: A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com']. NOTE: This property cannot contain accent characters. Returned only on $select. Supports $filter (eq, not, ge, le, in, startsWith, endsWith, /$count eq 0, /$count ne 0).
  - `[Outlook <IMicrosoftGraphOutlookUser>]`: outlookUser
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[PasswordPolicies <String>]`: Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword. Returned only on $select. For more information on the default password policies, see Azure AD pasword policies. Supports $filter (ne, not, and eq on null values).
  - `[PasswordProfile <IMicrosoftGraphPasswordProfile>]`: passwordProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change her password on the next login; otherwise false. If not set, default is false. NOTE:  For Azure B2C tenants, set to false and instead use custom policies and user flows to force password reset at first sign in. See Force password reset at first logon.
    - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multi-factor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multi-factor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
    - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next login. The password must satisfy minimum requirements as specified by the user’s passwordPolicies property. By default, a strong password is required.
  - `[PastProjects <String[]>]`: A list for the user to enumerate their past projects. Returned only on $select.
  - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
  - `[Planner <IMicrosoftGraphPlannerUser>]`: plannerUser
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[PostalCode <String>]`: The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[PreferredDataLocation <String>]`: The preferred data location for the user. For more information, see OneDrive Online Multi-Geo.
  - `[PreferredLanguage <String>]`: The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)
  - `[PreferredName <String>]`: The preferred name for the user. Not Supported. This attribute returns an empty string.Returned only on $select.
  - `[Presence <IMicrosoftGraphPresence>]`: presence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Activity <String>]`: The supplemental information to a user's availability. Possible values are Available, Away, BeRightBack, Busy, DoNotDisturb, InACall, InAConferenceCall, Inactive, InAMeeting, Offline, OffWork, OutOfOffice, PresenceUnknown, Presenting, UrgentInterruptionsOnly.
    - `[Availability <String>]`: The base presence information for a user. Possible values are Available, AvailableIdle,  Away, BeRightBack, Busy, BusyIdle, DoNotDisturb, Offline, PresenceUnknown
  - `[ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]`: The plans that are provisioned for the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le).
    - `[CapabilityStatus <String>]`: For example, 'Enabled'.
    - `[ProvisioningStatus <String>]`: For example, 'Success'.
    - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'
  - `[ProxyAddresses <String[]>]`: For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. Changes to the mail property will also update this collection to include the value as an SMTP address. For more information, see mail and proxyAddresses properties. The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses. For Azure AD B2C accounts, this property has a limit of ten unique addresses. Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith, endsWith, /$count eq 0, /$count ne 0).
  - `[Responsibilities <String[]>]`: A list for the user to enumerate their responsibilities. Returned only on $select.
  - `[Schools <String[]>]`: A list for the user to enumerate the schools they have attended. Returned only on $select.
  - `[SecurityIdentifier <String>]`: Security identifier (SID) of the user, used in Windows scenarios. Read-only. Returned by default. Supports $select and $filter (eq, not, ge, le, startsWith).
  - `[Settings <IMicrosoftGraphUserSettings>]`: userSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ContributionToContentDiscoveryAsOrganizationDisabled <Boolean?>]`: 
    - `[ContributionToContentDiscoveryDisabled <Boolean?>]`: 
    - `[ShiftPreferences <IMicrosoftGraphShiftPreferences>]`: shiftPreferences
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
        - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
        - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
          - `[EndTime <String>]`: End time for the time range.
          - `[StartTime <String>]`: Start time for the time range.
        - `[TimeZone <String>]`: Specifies the time zone for the indicated time.
  - `[ShowInAddressList <Boolean?>]`: Do not use in Microsoft Graph. Manage this property through the Microsoft 365 admin center instead. Represents whether the user should be included in the Outlook global address list. See Known issue.
  - `[SignInSessionsValidFromDateTime <DateTime?>]`: Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset. Returned only on $select.
  - `[Skills <String[]>]`: A list for the user to enumerate their skills. Returned only on $select.
  - `[State <String>]`: The state or province in the user's address. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[StreetAddress <String>]`: The street address of the user's place of business. Maximum length is 1024 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[Surname <String>]`: The user's surname (family name or last name). Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[Teamwork <IMicrosoftGraphUserTeamwork>]`: userTeamwork
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Todo <IMicrosoftGraphTodo>]`: todo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[UsageLocation <String>]`: A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters. Only the following characters are allowed A - Z, a - z, 0 - 9, ' . - _ ! # ^ ~. For the complete list of allowed characters, see username policies. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.
  - `[UserType <String>]`: A string value that can be used to classify user types in your directory, such as Member and Guest. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values). NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory?

`CALENDAR <IMicrosoftGraphCalendar>`: calendar
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
  - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
  - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
  - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
  - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[Color <String>]`: 
  - `[DefaultOnlineMeetingProvider <String>]`: 
  - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
  - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
  - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
  - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
  - `[Name <String>]`: The calendar name.
  - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress

`DRIVE <IMicrosoftGraphDrive>`: drive
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedByUser <IMicrosoftGraphUser>]`: user
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AboutMe <String>]`: A freeform text entry field for the user to describe themselves. Returned only on $select.
    - `[AccountEnabled <Boolean?>]`: true if the account is enabled; otherwise, false. This property is required when a user is created. Returned only on $select. Supports $filter (eq, ne, not, and in).
    - `[AgeGroup <String>]`: Sets the age group of the user. Allowed values: null, Minor, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).
    - `[AssignedLicenses <IMicrosoftGraphAssignedLicense[]>]`: The licenses that are assigned to the user, including inherited (group-based) licenses. This property doesn't differentiate directly-assigned and inherited licenses. Use the licenseAssignmentStates property to identify the directly-assigned and inherited licenses.  Not nullable. Returned only on $select. Supports $filter (eq, not, /$count eq 0, /$count ne 0).
      - `[DisabledPlans <String[]>]`: A collection of the unique identifiers for plans that have been disabled.
      - `[SkuId <String>]`: The unique identifier for the SKU.
    - `[AssignedPlans <IMicrosoftGraphAssignedPlan[]>]`: The plans that are assigned to the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq and not).
      - `[AssignedDateTime <DateTime?>]`: The date and time at which the plan was assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[CapabilityStatus <String>]`: Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut. See a detailed description of each value.
      - `[Service <String>]`: The name of the service; for example, exchange.
      - `[ServicePlanId <String>]`: A GUID that identifies the service plan. For a complete list of GUIDs and their equivalent friendly service names, see Product names and service plan identifiers for licensing.
    - `[Authentication <IMicrosoftGraphAuthentication>]`: authentication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AuthorizationInfo <IMicrosoftGraphAuthorizationInfo>]`: authorizationInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CertificateUserIds <String[]>]`: 
    - `[Birthday <DateTime?>]`: The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.
    - `[BusinessPhones <String[]>]`: The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property. Read-only for users synced from on-premises directory. Returned by default. Supports $filter (eq, not, ge, le, startsWith).
    - `[Calendar <IMicrosoftGraphCalendar>]`: calendar
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AllowedOnlineMeetingProviders <String[]>]`: Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
      - `[CanEdit <Boolean?>]`: true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access.
      - `[CanShare <Boolean?>]`: true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it.
      - `[CanViewPrivateItems <Boolean?>]`: true if the user can read calendar items that have been marked private, false otherwise.
      - `[ChangeKey <String>]`: Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
      - `[Color <String>]`: 
      - `[DefaultOnlineMeetingProvider <String>]`: 
      - `[HexColor <String>]`: The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is empty. Read-only.
      - `[IsDefaultCalendar <Boolean?>]`: true if this is the default calendar where new events are created by default, false otherwise.
      - `[IsRemovable <Boolean?>]`: Indicates whether this user calendar can be deleted from the user mailbox.
      - `[IsTallyingResponses <Boolean?>]`: Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
      - `[Name <String>]`: The calendar name.
      - `[Owner <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[City <String>]`: The city in which the user is located. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[CompanyName <String>]`: The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length is 64 characters.Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[ConsentProvidedForMinor <String>]`: Sets whether consent has been obtained for minors. Allowed values: null, Granted, Denied and NotRequired. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).
    - `[Country <String>]`: The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[CreatedDateTime <DateTime?>]`: The date and time the user was created, in ISO 8601 format and in UTC time. The value cannot be modified and is automatically populated when the entity is created. Nullable. For on-premises users, the value represents when they were first created in Azure AD. Property is null for some users created before June 2018 and on-premises users that were synced to Azure AD before June 2018. Read-only.  Read-only. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).
    - `[CreationType <String>]`: Indicates whether the user account was created through one of the following methods:  As a regular school or work account (null). As an external account (Invitation). As a local account for an Azure Active Directory B2C tenant (LocalAccount). Through self-service sign-up by an internal user using email verification (EmailVerified). Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp). Read-only.Returned only on $select. Supports $filter (eq, ne, not, in).
    - `[Department <String>]`: The name for the department in which the user works. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, and eq on null values).
    - `[DeviceEnrollmentLimit <Int32?>]`: The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
    - `[DisplayName <String>]`: The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.
    - `[Drive <IMicrosoftGraphDrive>]`: drive
    - `[EmployeeHireDate <DateTime?>]`: The date and time when the user was hired or will start work in case of a future hire. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).
    - `[EmployeeId <String>]`: The employee identifier assigned to the user by the organization. The maximum length is 16 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
    - `[EmployeeOrgData <IMicrosoftGraphEmployeeOrgData>]`: employeeOrgData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CostCenter <String>]`: The cost center associated with the user. Returned only on $select. Supports $filter.
      - `[Division <String>]`: The name of the division in which the user works. Returned only on $select. Supports $filter.
    - `[EmployeeType <String>]`: Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith).
    - `[ExternalUserState <String>]`: For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Returned only on $select. Supports $filter (eq, ne, not , in).
    - `[ExternalUserStateChangeDateTime <DateTime?>]`: Shows the timestamp for the latest change to the externalUserState property. Returned only on $select. Supports $filter (eq, ne, not , in).
    - `[FaxNumber <String>]`: The fax number of the user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
    - `[GivenName <String>]`: The given name (first name) of the user. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
    - `[HireDate <DateTime?>]`: The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.
    - `[Identities <IMicrosoftGraphObjectIdentity[]>]`: Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Returned only on $select. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.
      - `[Issuer <String>]`: Specifies the issuer of the identity, for example facebook.com.For local accounts (where signInType is not federated), this property is the local B2C tenant default domain name, for example contoso.onmicrosoft.com.For external users from other Azure AD organization, this will be the domain of the federated organization, for example contoso.com.Supports $filter. 512 character limit.
      - `[IssuerAssignedId <String>]`: Specifies the unique identifier assigned to the user by the issuer. The combination of issuer and issuerAssignedId must be unique within the organization. Represents the sign-in name for the user, when signInType is set to emailAddress or userName (also known as local accounts).When signInType is set to: emailAddress, (or a custom string that starts with emailAddress like emailAddress1) issuerAssignedId must be a valid email addressuserName, issuerAssignedId must be a valid local part of an email addressSupports $filter. 100 character limit.
      - `[SignInType <String>]`: Specifies the user sign-in types in your directory, such as emailAddress, userName, federated, or userPrincipalName. federated represents a unique identifier for a user from an issuer, that can be in any format chosen by the issuer. Setting or updating a userPrincipalName identity will update the value of the userPrincipalName property on the user object. The validations performed on the userPrincipalName property on the user object, for example, verified domains and acceptable characters, will be performed when setting or updating a userPrincipalName identity. Additional validation is enforced on issuerAssignedId when the sign-in type is set to emailAddress or userName. This property can also be set to any custom string.
    - `[ImAddresses <String[]>]`: The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith).
    - `[InferenceClassification <IMicrosoftGraphInferenceClassification>]`: inferenceClassification
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Insights <IMicrosoftGraphOfficeGraphInsights>]`: officeGraphInsights
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Interests <String[]>]`: A list for the user to describe their interests. Returned only on $select.
    - `[IsResourceAccount <Boolean?>]`: Do not use – reserved for future use.
    - `[JobTitle <String>]`: The user's job title. Maximum length is 128 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).
    - `[LastPasswordChangeDateTime <DateTime?>]`: The time when this Azure AD user last changed their password or when their password was created, whichever date the latest action was performed. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.
    - `[LegalAgeGroupClassification <String>]`: Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select.
    - `[LicenseAssignmentStates <IMicrosoftGraphLicenseAssignmentState[]>]`: State of license assignments for this user. Also indicates licenses that are directly-assigned and those that the user has inherited through group memberships. Read-only. Returned only on $select.
      - `[AssignedByGroup <String>]`: 
      - `[DisabledPlans <String[]>]`: 
      - `[Error <String>]`: 
      - `[LastUpdatedDateTime <DateTime?>]`: 
      - `[SkuId <String>]`: 
      - `[State <String>]`: 
    - `[Mail <String>]`: The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com. Changes to this property will also update the user's proxyAddresses collection to include the value as an SMTP address. This property cannot contain accent characters.  NOTE: We do not recommend updating this property for Azure AD B2C user profiles. Use the otherMails property instead. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).
    - `[MailNickname <String>]`: The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[MailboxSettings <IMicrosoftGraphMailboxSettings>]`: mailboxSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ArchiveFolder <String>]`: Folder ID of an archive folder for the user.
      - `[AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>]`: automaticRepliesSetting
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExternalAudience <String>]`: 
        - `[ExternalReplyMessage <String>]`: The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
        - `[InternalReplyMessage <String>]`: The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
        - `[ScheduledEndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[ScheduledStartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
        - `[Status <String>]`: 
      - `[DateFormat <String>]`: The date format for the user's mailbox.
      - `[DelegateMeetingMessageDeliveryOptions <String>]`: 
      - `[Language <IMicrosoftGraphLocaleInfo>]`: localeInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
        - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
      - `[TimeFormat <String>]`: The time format for the user's mailbox.
      - `[TimeZone <String>]`: The default time zone for the user's mailbox.
      - `[UserPurpose <String>]`: 
      - `[WorkingHours <IMicrosoftGraphWorkingHours>]`: workingHours
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DaysOfWeek <String[]>]`: The days of the week on which the user works.
        - `[EndTime <String>]`: The time of the day that the user stops working.
        - `[StartTime <String>]`: The time of the day that the user starts working.
        - `[TimeZone <IMicrosoftGraphTimeZoneBase>]`: timeZoneBase
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Name <String>]`: The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.
    - `[Manager <IMicrosoftGraphDirectoryObject>]`: directoryObject
    - `[MobilePhone <String>]`: The primary cellular telephone number for the user. Read-only for users synced from on-premises directory. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[MySite <String>]`: The URL for the user's personal site. Returned only on $select.
    - `[OfficeLocation <String>]`: The office location in the user's place of business. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[OnPremisesDistinguishedName <String>]`: Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.
    - `[OnPremisesDomainName <String>]`: Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.
    - `[OnPremisesExtensionAttributes <IMicrosoftGraphOnPremisesExtensionAttributes>]`: onPremisesExtensionAttributes
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExtensionAttribute1 <String>]`: First customizable extension attribute.
      - `[ExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
      - `[ExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
      - `[ExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
      - `[ExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
      - `[ExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
      - `[ExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
      - `[ExtensionAttribute2 <String>]`: Second customizable extension attribute.
      - `[ExtensionAttribute3 <String>]`: Third customizable extension attribute.
      - `[ExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
      - `[ExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
      - `[ExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
      - `[ExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
      - `[ExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
      - `[ExtensionAttribute9 <String>]`: Ninth customizable extension attribute.
    - `[OnPremisesImmutableId <String>]`: This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property. NOTE: The $ and _ characters cannot be used when specifying this property. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in)..
    - `[OnPremisesLastSyncDateTime <DateTime?>]`: Indicates the last time at which the object was synced with the on-premises directory; for example: 2013-02-16T03:04:54Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in).
    - `[OnPremisesProvisioningErrors <IMicrosoftGraphOnPremisesProvisioningError[]>]`: Errors when using Microsoft synchronization product during provisioning. Returned only on $select. Supports $filter (eq, not, ge, le).
    - `[OnPremisesSamAccountName <String>]`: Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).
    - `[OnPremisesSecurityIdentifier <String>]`: Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only. Returned only on $select.  Supports $filter (eq including on null values).
    - `[OnPremisesSyncEnabled <Boolean?>]`: true if this user object is currently being synced from an on-premises Active Directory (AD); otherwise the user isn't being synced and can be managed in Azure Active Directory (Azure AD). Read-only. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).
    - `[OnPremisesUserPrincipalName <String>]`: Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).
    - `[Onenote <IMicrosoftGraphOnenote>]`: onenote
    - `[OtherMails <String[]>]`: A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com']. NOTE: This property cannot contain accent characters. Returned only on $select. Supports $filter (eq, not, ge, le, in, startsWith, endsWith, /$count eq 0, /$count ne 0).
    - `[Outlook <IMicrosoftGraphOutlookUser>]`: outlookUser
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[PasswordPolicies <String>]`: Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword. Returned only on $select. For more information on the default password policies, see Azure AD pasword policies. Supports $filter (ne, not, and eq on null values).
    - `[PasswordProfile <IMicrosoftGraphPasswordProfile>]`: passwordProfile
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change her password on the next login; otherwise false. If not set, default is false. NOTE:  For Azure B2C tenants, set to false and instead use custom policies and user flows to force password reset at first sign in. See Force password reset at first logon.
      - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multi-factor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multi-factor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
      - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next login. The password must satisfy minimum requirements as specified by the user’s passwordPolicies property. By default, a strong password is required.
    - `[PastProjects <String[]>]`: A list for the user to enumerate their past projects. Returned only on $select.
    - `[Photo <IMicrosoftGraphProfilePhoto>]`: profilePhoto
    - `[Planner <IMicrosoftGraphPlannerUser>]`: plannerUser
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[PostalCode <String>]`: The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[PreferredDataLocation <String>]`: The preferred data location for the user. For more information, see OneDrive Online Multi-Geo.
    - `[PreferredLanguage <String>]`: The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)
    - `[PreferredName <String>]`: The preferred name for the user. Not Supported. This attribute returns an empty string.Returned only on $select.
    - `[Presence <IMicrosoftGraphPresence>]`: presence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Activity <String>]`: The supplemental information to a user's availability. Possible values are Available, Away, BeRightBack, Busy, DoNotDisturb, InACall, InAConferenceCall, Inactive, InAMeeting, Offline, OffWork, OutOfOffice, PresenceUnknown, Presenting, UrgentInterruptionsOnly.
      - `[Availability <String>]`: The base presence information for a user. Possible values are Available, AvailableIdle,  Away, BeRightBack, Busy, BusyIdle, DoNotDisturb, Offline, PresenceUnknown
    - `[ProvisionedPlans <IMicrosoftGraphProvisionedPlan[]>]`: The plans that are provisioned for the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le).
      - `[CapabilityStatus <String>]`: For example, 'Enabled'.
      - `[ProvisioningStatus <String>]`: For example, 'Success'.
      - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'
    - `[ProxyAddresses <String[]>]`: For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. Changes to the mail property will also update this collection to include the value as an SMTP address. For more information, see mail and proxyAddresses properties. The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses. For Azure AD B2C accounts, this property has a limit of ten unique addresses. Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith, endsWith, /$count eq 0, /$count ne 0).
    - `[Responsibilities <String[]>]`: A list for the user to enumerate their responsibilities. Returned only on $select.
    - `[Schools <String[]>]`: A list for the user to enumerate the schools they have attended. Returned only on $select.
    - `[SecurityIdentifier <String>]`: Security identifier (SID) of the user, used in Windows scenarios. Read-only. Returned by default. Supports $select and $filter (eq, not, ge, le, startsWith).
    - `[Settings <IMicrosoftGraphUserSettings>]`: userSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ContributionToContentDiscoveryAsOrganizationDisabled <Boolean?>]`: 
      - `[ContributionToContentDiscoveryDisabled <Boolean?>]`: 
      - `[ShiftPreferences <IMicrosoftGraphShiftPreferences>]`: shiftPreferences
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
          - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
          - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
            - `[EndTime <String>]`: End time for the time range.
            - `[StartTime <String>]`: Start time for the time range.
          - `[TimeZone <String>]`: Specifies the time zone for the indicated time.
    - `[ShowInAddressList <Boolean?>]`: Do not use in Microsoft Graph. Manage this property through the Microsoft 365 admin center instead. Represents whether the user should be included in the Outlook global address list. See Known issue.
    - `[SignInSessionsValidFromDateTime <DateTime?>]`: Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset. Returned only on $select.
    - `[Skills <String[]>]`: A list for the user to enumerate their skills. Returned only on $select.
    - `[State <String>]`: The state or province in the user's address. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[StreetAddress <String>]`: The street address of the user's place of business. Maximum length is 1024 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[Surname <String>]`: The user's surname (family name or last name). Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[Teamwork <IMicrosoftGraphUserTeamwork>]`: userTeamwork
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Todo <IMicrosoftGraphTodo>]`: todo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[UsageLocation <String>]`: A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).
    - `[UserPrincipalName <String>]`: The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters. Only the following characters are allowed A - Z, a - z, 0 - 9, ' . - _ ! # ^ ~. For the complete list of allowed characters, see username policies. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.
    - `[UserType <String>]`: A string value that can be used to classify user types in your directory, such as Member and Guest. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values). NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory?
  - `[CreatedDateTime <DateTime?>]`: Date and time of item creation. Read-only.
  - `[Description <String>]`: Provides a user-visible description of the item. Optional.
  - `[ETag <String>]`: ETag for the item. Read-only.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedByUser <IMicrosoftGraphUser>]`: user
  - `[LastModifiedDateTime <DateTime?>]`: Date and time the item was last modified. Read-only.
  - `[Name <String>]`: The name of the item. Read-write.
  - `[ParentReference <IMicrosoftGraphItemReference>]`: itemReference
  - `[WebUrl <String>]`: URL that displays the resource in the browser. Read-only.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DriveType <String>]`: Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.
  - `[List <IMicrosoftGraphList>]`: list
  - `[Owner <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Quota <IMicrosoftGraphQuota>]`: quota
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Deleted <Int64?>]`: Total space consumed by files in the recycle bin, in bytes. Read-only.
    - `[Remaining <Int64?>]`: Total space remaining before reaching the quota limit, in bytes. Read-only.
    - `[State <String>]`: Enumeration value that indicates the state of the storage space. Read-only.
    - `[StoragePlanInformation <IMicrosoftGraphStoragePlanInformation>]`: storagePlanInformation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UpgradeAvailable <Boolean?>]`: Indicates whether there are higher storage quota plans available. Read-only.
    - `[Total <Int64?>]`: Total allowed storage space, in bytes. Read-only.
    - `[Used <Int64?>]`: Total space used, in bytes. Read-only.
  - `[Root <IMicrosoftGraphDriveItem>]`: driveItem
  - `[SharePointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
  - `[System <IMicrosoftGraphSystemFacet>]`: systemFacet

`EMPLOYEEORGDATA <IMicrosoftGraphEmployeeOrgData>`: employeeOrgData
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CostCenter <String>]`: The cost center associated with the user. Returned only on $select. Supports $filter.
  - `[Division <String>]`: The name of the division in which the user works. Returned only on $select. Supports $filter.

`IDENTITIES <IMicrosoftGraphObjectIdentity[]>`: Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Returned only on $select. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.
  - `[Issuer <String>]`: Specifies the issuer of the identity, for example facebook.com.For local accounts (where signInType is not federated), this property is the local B2C tenant default domain name, for example contoso.onmicrosoft.com.For external users from other Azure AD organization, this will be the domain of the federated organization, for example contoso.com.Supports $filter. 512 character limit.
  - `[IssuerAssignedId <String>]`: Specifies the unique identifier assigned to the user by the issuer. The combination of issuer and issuerAssignedId must be unique within the organization. Represents the sign-in name for the user, when signInType is set to emailAddress or userName (also known as local accounts).When signInType is set to: emailAddress, (or a custom string that starts with emailAddress like emailAddress1) issuerAssignedId must be a valid email addressuserName, issuerAssignedId must be a valid local part of an email addressSupports $filter. 100 character limit.
  - `[SignInType <String>]`: Specifies the user sign-in types in your directory, such as emailAddress, userName, federated, or userPrincipalName. federated represents a unique identifier for a user from an issuer, that can be in any format chosen by the issuer. Setting or updating a userPrincipalName identity will update the value of the userPrincipalName property on the user object. The validations performed on the userPrincipalName property on the user object, for example, verified domains and acceptable characters, will be performed when setting or updating a userPrincipalName identity. Additional validation is enforced on issuerAssignedId when the sign-in type is set to emailAddress or userName. This property can also be set to any custom string.

`INFERENCECLASSIFICATION <IMicrosoftGraphInferenceClassification>`: inferenceClassification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
  - `[AttachmentBaseId <String>]`: key: id of attachmentBase
  - `[AttachmentSessionId <String>]`: key: id of attachmentSession
  - `[ChecklistItemId <String>]`: key: id of checklistItem
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[ExtensionId <String>]`: key: id of extension
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[LinkedResourceId <String>]`: key: id of linkedResource
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OutlookCategoryId <String>]`: key: id of outlookCategory
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user

`INSIGHTS <IMicrosoftGraphOfficeGraphInsights>`: officeGraphInsights
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`LICENSEASSIGNMENTSTATES <IMicrosoftGraphLicenseAssignmentState[]>`: State of license assignments for this user. Also indicates licenses that are directly-assigned and those that the user has inherited through group memberships. Read-only. Returned only on $select.
  - `[AssignedByGroup <String>]`: 
  - `[DisabledPlans <String[]>]`: 
  - `[Error <String>]`: 
  - `[LastUpdatedDateTime <DateTime?>]`: 
  - `[SkuId <String>]`: 
  - `[State <String>]`: 

`MAILBOXSETTINGS <IMicrosoftGraphMailboxSettings>`: mailboxSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ArchiveFolder <String>]`: Folder ID of an archive folder for the user.
  - `[AutomaticRepliesSetting <IMicrosoftGraphAutomaticRepliesSetting>]`: automaticRepliesSetting
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExternalAudience <String>]`: 
    - `[ExternalReplyMessage <String>]`: The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
    - `[InternalReplyMessage <String>]`: The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
    - `[ScheduledEndDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
      - `[TimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
    - `[ScheduledStartDateTime <IMicrosoftGraphDateTimeZone>]`: dateTimeTimeZone
    - `[Status <String>]`: 
  - `[DateFormat <String>]`: The date format for the user's mailbox.
  - `[DelegateMeetingMessageDeliveryOptions <String>]`: 
  - `[Language <IMicrosoftGraphLocaleInfo>]`: localeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
    - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  - `[TimeFormat <String>]`: The time format for the user's mailbox.
  - `[TimeZone <String>]`: The default time zone for the user's mailbox.
  - `[UserPurpose <String>]`: 
  - `[WorkingHours <IMicrosoftGraphWorkingHours>]`: workingHours
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DaysOfWeek <String[]>]`: The days of the week on which the user works.
    - `[EndTime <String>]`: The time of the day that the user stops working.
    - `[StartTime <String>]`: The time of the day that the user starts working.
    - `[TimeZone <IMicrosoftGraphTimeZoneBase>]`: timeZoneBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: The name of a time zone. It can be a standard time zone name such as 'Hawaii-Aleutian Standard Time', or 'Customized Time Zone' for a custom time zone.

`MANAGER <IMicrosoftGraphDirectoryObject>`: directoryObject
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.

`ONENOTE <IMicrosoftGraphOnenote>`: onenote
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`ONPREMISESEXTENSIONATTRIBUTES <IMicrosoftGraphOnPremisesExtensionAttributes>`: onPremisesExtensionAttributes
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ExtensionAttribute1 <String>]`: First customizable extension attribute.
  - `[ExtensionAttribute10 <String>]`: Tenth customizable extension attribute.
  - `[ExtensionAttribute11 <String>]`: Eleventh customizable extension attribute.
  - `[ExtensionAttribute12 <String>]`: Twelfth customizable extension attribute.
  - `[ExtensionAttribute13 <String>]`: Thirteenth customizable extension attribute.
  - `[ExtensionAttribute14 <String>]`: Fourteenth customizable extension attribute.
  - `[ExtensionAttribute15 <String>]`: Fifteenth customizable extension attribute.
  - `[ExtensionAttribute2 <String>]`: Second customizable extension attribute.
  - `[ExtensionAttribute3 <String>]`: Third customizable extension attribute.
  - `[ExtensionAttribute4 <String>]`: Fourth customizable extension attribute.
  - `[ExtensionAttribute5 <String>]`: Fifth customizable extension attribute.
  - `[ExtensionAttribute6 <String>]`: Sixth customizable extension attribute.
  - `[ExtensionAttribute7 <String>]`: Seventh customizable extension attribute.
  - `[ExtensionAttribute8 <String>]`: Eighth customizable extension attribute.
  - `[ExtensionAttribute9 <String>]`: Ninth customizable extension attribute.

`ONPREMISESPROVISIONINGERRORS <IMicrosoftGraphOnPremisesProvisioningError[]>`: Errors when using Microsoft synchronization product during provisioning. Returned only on $select. Supports $filter (eq, not, ge, le).
  - `[Category <String>]`: Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
  - `[OccurredDateTime <DateTime?>]`: The date and time at which the error occurred.
  - `[PropertyCausingError <String>]`: Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
  - `[Value <String>]`: Value of the property causing the error.

`OUTLOOK <IMicrosoftGraphOutlookUser>`: outlookUser
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`PASSWORDPROFILE <IMicrosoftGraphPasswordProfile>`: passwordProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change her password on the next login; otherwise false. If not set, default is false. NOTE:  For Azure B2C tenants, set to false and instead use custom policies and user flows to force password reset at first sign in. See Force password reset at first logon.
  - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multi-factor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multi-factor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
  - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next login. The password must satisfy minimum requirements as specified by the user’s passwordPolicies property. By default, a strong password is required.

`PHOTO <IMicrosoftGraphProfilePhoto>`: profilePhoto
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Height <Int32?>]`: The height of the photo. Read-only.
  - `[Width <Int32?>]`: The width of the photo. Read-only.

`PLANNER <IMicrosoftGraphPlannerUser>`: plannerUser
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`PRESENCE <IMicrosoftGraphPresence>`: presence
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Activity <String>]`: The supplemental information to a user's availability. Possible values are Available, Away, BeRightBack, Busy, DoNotDisturb, InACall, InAConferenceCall, Inactive, InAMeeting, Offline, OffWork, OutOfOffice, PresenceUnknown, Presenting, UrgentInterruptionsOnly.
  - `[Availability <String>]`: The base presence information for a user. Possible values are Available, AvailableIdle,  Away, BeRightBack, Busy, BusyIdle, DoNotDisturb, Offline, PresenceUnknown

`PROVISIONEDPLANS <IMicrosoftGraphProvisionedPlan[]>`: The plans that are provisioned for the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le).
  - `[CapabilityStatus <String>]`: For example, 'Enabled'.
  - `[ProvisioningStatus <String>]`: For example, 'Success'.
  - `[Service <String>]`: The name of the service; for example, 'AccessControlS2S'

`SETTINGS <IMicrosoftGraphUserSettings>`: userSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ContributionToContentDiscoveryAsOrganizationDisabled <Boolean?>]`: 
  - `[ContributionToContentDiscoveryDisabled <Boolean?>]`: 
  - `[ShiftPreferences <IMicrosoftGraphShiftPreferences>]`: shiftPreferences
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Availability <IMicrosoftGraphShiftAvailability[]>]`: Availability of the user to be scheduled for work and its recurrence pattern.
      - `[Recurrence <IMicrosoftGraphPatternedRecurrence>]`: patternedRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
          - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
          - `[FirstDayOfWeek <String>]`: 
          - `[Index <String>]`: 
          - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
          - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
          - `[Type <String>]`: 
        - `[Range <IMicrosoftGraphRecurrenceRange>]`: recurrenceRange
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EndDate <DateTime?>]`: The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.
          - `[NumberOfOccurrences <Int32?>]`: The number of times to repeat the event. Required and must be positive if type is numbered.
          - `[RecurrenceTimeZone <String>]`: Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.
          - `[StartDate <DateTime?>]`: The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.
          - `[Type <String>]`: 
      - `[TimeSlots <IMicrosoftGraphTimeRange[]>]`: The time slot(s) preferred by the user.
        - `[EndTime <String>]`: End time for the time range.
        - `[StartTime <String>]`: Start time for the time range.
      - `[TimeZone <String>]`: Specifies the time zone for the indicated time.

`TEAMWORK <IMicrosoftGraphUserTeamwork>`: userTeamwork
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`TODO <IMicrosoftGraphTodo>`: todo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

## RELATED LINKS

