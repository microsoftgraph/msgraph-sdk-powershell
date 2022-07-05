---
external help file:
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/update-mguserprofile
schema: 2.0.0
---

# Update-MgUserProfile

## SYNOPSIS
Update the navigation property profile in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserProfile -UserId <String> [-Account <IMicrosoftGraphUserAccountInformation[]>]
 [-AdditionalProperties <Hashtable>] [-Addresses <IMicrosoftGraphItemAddress[]>]
 [-Anniversaries <IMicrosoftGraphPersonAnnualEvent[]>] [-Awards <IMicrosoftGraphPersonAward[]>]
 [-Certifications <IMicrosoftGraphPersonCertification[]>]
 [-EducationalActivities <IMicrosoftGraphEducationalActivity[]>] [-Emails <IMicrosoftGraphItemEmail[]>]
 [-Id <String>] [-Interests <IMicrosoftGraphPersonInterest[]>]
 [-Languages <IMicrosoftGraphLanguageProficiency[]>] [-Names <IMicrosoftGraphPersonName[]>]
 [-Notes <IMicrosoftGraphPersonAnnotation[]>] [-Patents <IMicrosoftGraphItemPatent[]>]
 [-Phones <IMicrosoftGraphItemPhone[]>] [-Positions <IMicrosoftGraphWorkPosition[]>]
 [-Projects <IMicrosoftGraphProjectParticipation[]>] [-Publications <IMicrosoftGraphItemPublication[]>]
 [-Skills <IMicrosoftGraphSkillProficiency[]>] [-WebAccounts <IMicrosoftGraphWebAccount[]>]
 [-Websites <IMicrosoftGraphPersonWebsite[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserProfile -UserId <String> -BodyParameter <IMicrosoftGraphProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserProfile -InputObject <IPeopleIdentity> -BodyParameter <IMicrosoftGraphProfile> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserProfile -InputObject <IPeopleIdentity> [-Account <IMicrosoftGraphUserAccountInformation[]>]
 [-AdditionalProperties <Hashtable>] [-Addresses <IMicrosoftGraphItemAddress[]>]
 [-Anniversaries <IMicrosoftGraphPersonAnnualEvent[]>] [-Awards <IMicrosoftGraphPersonAward[]>]
 [-Certifications <IMicrosoftGraphPersonCertification[]>]
 [-EducationalActivities <IMicrosoftGraphEducationalActivity[]>] [-Emails <IMicrosoftGraphItemEmail[]>]
 [-Id <String>] [-Interests <IMicrosoftGraphPersonInterest[]>]
 [-Languages <IMicrosoftGraphLanguageProficiency[]>] [-Names <IMicrosoftGraphPersonName[]>]
 [-Notes <IMicrosoftGraphPersonAnnotation[]>] [-Patents <IMicrosoftGraphItemPatent[]>]
 [-Phones <IMicrosoftGraphItemPhone[]>] [-Positions <IMicrosoftGraphWorkPosition[]>]
 [-Projects <IMicrosoftGraphProjectParticipation[]>] [-Publications <IMicrosoftGraphItemPublication[]>]
 [-Skills <IMicrosoftGraphSkillProficiency[]>] [-WebAccounts <IMicrosoftGraphWebAccount[]>]
 [-Websites <IMicrosoftGraphPersonWebsite[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property profile in users

## EXAMPLES

## PARAMETERS

### -Account
.
To construct, please use Get-Help -Online and see NOTES section for ACCOUNT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserAccountInformation[]
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

### -Addresses
Represents details of addresses associated with the user.
To construct, please use Get-Help -Online and see NOTES section for ADDRESSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemAddress[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Anniversaries
Represents the details of meaningful dates associated with a person.
To construct, please use Get-Help -Online and see NOTES section for ANNIVERSARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonAnnualEvent[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Awards
Represents the details of awards or honors associated with a person.
To construct, please use Get-Help -Online and see NOTES section for AWARDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonAward[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
profile
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Certifications
Represents the details of certifications associated with a person.
To construct, please use Get-Help -Online and see NOTES section for CERTIFICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonCertification[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationalActivities
Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.
To construct, please use Get-Help -Online and see NOTES section for EDUCATIONALACTIVITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationalActivity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Emails
Represents detailed information about email addresses associated with the user.
To construct, please use Get-Help -Online and see NOTES section for EMAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemEmail[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPeopleIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Interests
Provides detailed information about interests the user has associated with themselves in various services.
To construct, please use Get-Help -Online and see NOTES section for INTERESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonInterest[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Languages
Represents detailed information about languages that a user has added to their profile.
To construct, please use Get-Help -Online and see NOTES section for LANGUAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLanguageProficiency[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
Represents the names a user has added to their profile.
To construct, please use Get-Help -Online and see NOTES section for NAMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonName[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Notes
Represents notes that a user has added to their profile.
To construct, please use Get-Help -Online and see NOTES section for NOTES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonAnnotation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Patents
Represents patents that a user has added to their profile.
To construct, please use Get-Help -Online and see NOTES section for PATENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemPatent[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Phones
Represents detailed information about phone numbers associated with a user in various services.
To construct, please use Get-Help -Online and see NOTES section for PHONES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemPhone[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Positions
Represents detailed information about work positions associated with a user's profile.
To construct, please use Get-Help -Online and see NOTES section for POSITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWorkPosition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Projects
Represents detailed information about projects associated with a user.
To construct, please use Get-Help -Online and see NOTES section for PROJECTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProjectParticipation[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publications
Represents details of any publications a user has added to their profile.
To construct, please use Get-Help -Online and see NOTES section for PUBLICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemPublication[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skills
Represents detailed information about skills associated with a user in various services.
To construct, please use Get-Help -Online and see NOTES section for SKILLS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkillProficiency[]
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

### -WebAccounts
Represents web accounts the user has indicated they use or has added to their user profile.
To construct, please use Get-Help -Online and see NOTES section for WEBACCOUNTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWebAccount[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Websites
Represents detailed information about websites associated with a user in various services.
To construct, please use Get-Help -Online and see NOTES section for WEBSITES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonWebsite[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfile

### Microsoft.Graph.PowerShell.Models.IPeopleIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCOUNT <IMicrosoftGraphUserAccountInformation[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[AgeGroup <String>]`: Shows the age group of user. Allowed values null, minor, notAdult and adult are generated by the directory and cannot be changed.
  - `[CountryCode <String>]`: Contains the two-character country code associated with the users account.
  - `[PreferredLanguageTag <IMicrosoftGraphLocaleInfo>]`: localeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
    - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the user associated with the account.

ADDRESSES <IMicrosoftGraphItemAddress[]>: Represents details of addresses associated with the user.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Detail <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[DisplayName <String>]`: Friendly name the user has assigned to this address.
  - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Writable on OneDrive Personal.
    - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Writable on OneDrive Personal.

ANNIVERSARIES <IMicrosoftGraphPersonAnnualEvent[]>: Represents the details of meaningful dates associated with a person.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Date <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[Type <String>]`: personAnnualEventType

AWARDS <IMicrosoftGraphPersonAward[]>: Represents the details of awards or honors associated with a person.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Description <String>]`: Descpription of the award or honor.
  - `[DisplayName <String>]`: Name of the award or honor.
  - `[IssuedDate <DateTime?>]`: The date that the award or honor was granted.
  - `[IssuingAuthority <String>]`: Authority which granted the award or honor.
  - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the award or honor.
  - `[WebUrl <String>]`: URL referencing the award or honor.

BODYPARAMETER <IMicrosoftGraphProfile>: profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Account <IMicrosoftGraphUserAccountInformation[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
      - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String[]>]`: 
    - `[Id <String>]`: 
    - `[AgeGroup <String>]`: Shows the age group of user. Allowed values null, minor, notAdult and adult are generated by the directory and cannot be changed.
    - `[CountryCode <String>]`: Contains the two-character country code associated with the users account.
    - `[PreferredLanguageTag <IMicrosoftGraphLocaleInfo>]`: localeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
      - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
    - `[UserPrincipalName <String>]`: The user principal name (UPN) of the user associated with the account.
  - `[Addresses <IMicrosoftGraphItemAddress[]>]`: Represents details of addresses associated with the user.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Detail <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[DisplayName <String>]`: Friendly name the user has assigned to this address.
    - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
      - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Writable on OneDrive Personal.
      - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Writable on OneDrive Personal.
  - `[Anniversaries <IMicrosoftGraphPersonAnnualEvent[]>]`: Represents the details of meaningful dates associated with a person.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Date <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[Type <String>]`: personAnnualEventType
  - `[Awards <IMicrosoftGraphPersonAward[]>]`: Represents the details of awards or honors associated with a person.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Description <String>]`: Descpription of the award or honor.
    - `[DisplayName <String>]`: Name of the award or honor.
    - `[IssuedDate <DateTime?>]`: The date that the award or honor was granted.
    - `[IssuingAuthority <String>]`: Authority which granted the award or honor.
    - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the award or honor.
    - `[WebUrl <String>]`: URL referencing the award or honor.
  - `[Certifications <IMicrosoftGraphPersonCertification[]>]`: Represents the details of certifications associated with a person.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[CertificationId <String>]`: The referenceable identifier for the certification.
    - `[Description <String>]`: Description of the certification.
    - `[DisplayName <String>]`: Title of the certification.
    - `[EndDate <DateTime?>]`: The date that the certification expires.
    - `[IssuedDate <DateTime?>]`: The date that the certification was issued.
    - `[IssuingAuthority <String>]`: Authority which granted the certification.
    - `[IssuingCompany <String>]`: Company which granted the certification.
    - `[StartDate <DateTime?>]`: The date that the certification became valid.
    - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the certification.
    - `[WebUrl <String>]`: URL referencing the certification.
  - `[EducationalActivities <IMicrosoftGraphEducationalActivity[]>]`: Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[CompletionMonthYear <DateTime?>]`: The month and year the user graduated or completed the activity.
    - `[EndMonthYear <DateTime?>]`: The month and year the user completed the educational activity referenced.
    - `[Institution <IMicrosoftGraphInstitutionData>]`: institutionData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: Short description of the institution the user studied at.
      - `[DisplayName <String>]`: Name of the institution the user studied at.
      - `[Location <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[WebUrl <String>]`: Link to the institution or department homepage.
    - `[Program <IMicrosoftGraphEducationalActivityDetail>]`: educationalActivityDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Abbreviation <String>]`: Shortened name of the degree or program (example: PhD, MBA)
      - `[Activities <String[]>]`: Extracurricular activities undertaken alongside the program.
      - `[Awards <String[]>]`: Any awards or honors associated with the program.
      - `[Description <String>]`: Short description of the program provided by the user.
      - `[DisplayName <String>]`: Long-form name of the program that the user has provided.
      - `[FieldsOfStudy <String[]>]`: Majors and minors associated with the program. (if applicable)
      - `[Grade <String>]`: The final grade, class, GPA or score.
      - `[Notes <String>]`: Additional notes the user has provided.
      - `[WebUrl <String>]`: Link to the degree or program page.
    - `[StartMonthYear <DateTime?>]`: The month and year the user commenced the activity referenced.
  - `[Emails <IMicrosoftGraphItemEmail[]>]`: Represents detailed information about email addresses associated with the user.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Address <String>]`: The email address itself.
    - `[DisplayName <String>]`: The name or label a user has associated with a particular email address.
    - `[Type <String>]`: emailType
  - `[Interests <IMicrosoftGraphPersonInterest[]>]`: Provides detailed information about interests the user has associated with themselves in various services.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Categories <String[]>]`: Contains categories a user has associated with the interest (for example, personal, recipies).
    - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
    - `[Description <String>]`: Contains a description of the interest.
    - `[DisplayName <String>]`: Contains a friendly name for the interest.
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: Contains a link to a web page or resource about the interest.
  - `[Languages <IMicrosoftGraphLanguageProficiency[]>]`: Represents detailed information about languages that a user has added to their profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Contains the long-form name for the language.
    - `[Proficiency <String>]`: languageProficiencyLevel
    - `[Reading <String>]`: languageProficiencyLevel
    - `[Spoken <String>]`: languageProficiencyLevel
    - `[Tag <String>]`: Contains the four-character BCP47 name for the language (en-US, no-NB, en-AU).
    - `[ThumbnailUrl <String>]`: 
    - `[Written <String>]`: languageProficiencyLevel
  - `[Names <IMicrosoftGraphPersonName[]>]`: Represents the names a user has added to their profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.
    - `[First <String>]`: First name of the user.
    - `[Initials <String>]`: Initials of the user.
    - `[LanguageTag <String>]`: Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.
    - `[Last <String>]`: Last name of the user.
    - `[Maiden <String>]`: Maiden name of the user.
    - `[Middle <String>]`: Middle name of the user.
    - `[Nickname <String>]`: Nickname of the user.
    - `[Pronunciation <IMicrosoftGraphPersonNamePronounciation>]`: personNamePronounciation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[First <String>]`: 
      - `[Last <String>]`: 
      - `[Maiden <String>]`: 
      - `[Middle <String>]`: 
    - `[Suffix <String>]`: Designators used after the users name (eg: PhD.)
    - `[Title <String>]`: Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)
  - `[Notes <IMicrosoftGraphPersonAnnotation[]>]`: Represents notes that a user has added to their profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Detail <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[DisplayName <String>]`: Contains a friendly name for the note.
    - `[ThumbnailUrl <String>]`: 
  - `[Patents <IMicrosoftGraphItemPatent[]>]`: Represents patents that a user has added to their profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Description <String>]`: Descpription of the patent or filing.
    - `[DisplayName <String>]`: Title of the patent or filing.
    - `[IsPending <Boolean?>]`: Indicates the patent is pending.
    - `[IssuedDate <DateTime?>]`: The date that the patent was granted.
    - `[IssuingAuthority <String>]`: Authority which granted the patent.
    - `[Number <String>]`: The patent number.
    - `[WebUrl <String>]`: URL referencing the patent or filing.
  - `[Phones <IMicrosoftGraphItemPhone[]>]`: Represents detailed information about phone numbers associated with a user in various services.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: Friendly name the user has assigned this phone number.
    - `[Number <String>]`: Phone number provided by the user.
    - `[Type <String>]`: phoneType
  - `[Positions <IMicrosoftGraphWorkPosition[]>]`: Represents detailed information about work positions associated with a user's profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Categories <String[]>]`: Categories that the user has associated with this position.
    - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: Colleagues that are associated with this position.
      - `[DisplayName <String>]`: Name of the person.
      - `[Relationship <String>]`: personRelationship
      - `[UserPrincipalName <String>]`: Email address or reference to person within organization.
    - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
        - `[Department <String>]`: Department Name within a company.
        - `[DisplayName <String>]`: Company name.
        - `[OfficeLocation <String>]`: Office Location of the person referred to.
        - `[Pronunciation <String>]`: Pronunciation guide for the company name.
        - `[WebUrl <String>]`: Link to the company home page.
      - `[Description <String>]`: Description of the position in question.
      - `[EndMonthYear <DateTime?>]`: When the position ended.
      - `[JobTitle <String>]`: The title held when in that position.
      - `[Role <String>]`: The role the position entailed.
      - `[StartMonthYear <DateTime?>]`: The start month and year of the position.
      - `[Summary <String>]`: Short summary of the position.
    - `[IsCurrent <Boolean?>]`: Denotes whether or not the position is current.
    - `[Manager <IMicrosoftGraphRelatedPerson>]`: relatedPerson
  - `[Projects <IMicrosoftGraphProjectParticipation[]>]`: Represents detailed information about projects associated with a user.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Categories <String[]>]`: Contains categories a user has associated with the project (for example, digital transformation, oil rig).
    - `[Client <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
    - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: Lists people that also worked on the project.
    - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[DisplayName <String>]`: Contains a friendly name for the project.
    - `[Sponsors <IMicrosoftGraphRelatedPerson[]>]`: The Person or people who sponsored the project.
    - `[ThumbnailUrl <String>]`: 
  - `[Publications <IMicrosoftGraphItemPublication[]>]`: Represents details of any publications a user has added to their profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Description <String>]`: Description of the publication.
    - `[DisplayName <String>]`: Title of the publication.
    - `[PublishedDate <DateTime?>]`: The date that the publication was published.
    - `[Publisher <String>]`: Publication or publisher for the publication.
    - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the publication.
    - `[WebUrl <String>]`: URL referencing the publication.
  - `[Skills <IMicrosoftGraphSkillProficiency[]>]`: Represents detailed information about skills associated with a user in various services.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Categories <String[]>]`: Contains categories a user has associated with the skill (for example, personal, professional, hobby).
    - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
    - `[DisplayName <String>]`: Contains a friendly name for the skill.
    - `[Proficiency <String>]`: skillProficiencyLevel
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: Contains a link to an information source about the skill.
  - `[WebAccounts <IMicrosoftGraphWebAccount[]>]`: Represents web accounts the user has indicated they use or has added to their user profile.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Description <String>]`: Contains the description the user has provided for the account on the service being referenced.
    - `[Service <IMicrosoftGraphServiceInformation>]`: serviceInformation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: The name of the cloud service (for example, Twitter, Instagram).
      - `[WebUrl <String>]`: Contains the URL for the service being referenced.
    - `[StatusMessage <String>]`: Contains a status message from the cloud service if provided or synchronized.
    - `[ThumbnailUrl <String>]`: 
    - `[UserId <String>]`: The user name  displayed for the webaccount.
    - `[WebUrl <String>]`: Contains a link to the user's profile on the cloud service if one exists.
  - `[Websites <IMicrosoftGraphPersonWebsite[]>]`: Represents detailed information about websites associated with a user in various services.
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[IsSearchable <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
    - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[Id <String>]`: 
    - `[Categories <String[]>]`: Contains categories a user has associated with the website (for example, personal, recipes).
    - `[Description <String>]`: Contains a description of the website.
    - `[DisplayName <String>]`: Contains a friendly name for the website.
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: Contains a link to the website itself.

CERTIFICATIONS <IMicrosoftGraphPersonCertification[]>: Represents the details of certifications associated with a person.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[CertificationId <String>]`: The referenceable identifier for the certification.
  - `[Description <String>]`: Description of the certification.
  - `[DisplayName <String>]`: Title of the certification.
  - `[EndDate <DateTime?>]`: The date that the certification expires.
  - `[IssuedDate <DateTime?>]`: The date that the certification was issued.
  - `[IssuingAuthority <String>]`: Authority which granted the certification.
  - `[IssuingCompany <String>]`: Company which granted the certification.
  - `[StartDate <DateTime?>]`: The date that the certification became valid.
  - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the certification.
  - `[WebUrl <String>]`: URL referencing the certification.

EDUCATIONALACTIVITIES <IMicrosoftGraphEducationalActivity[]>: Represents data that a user has supplied related to undergraduate, graduate, postgraduate or other educational activities.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[CompletionMonthYear <DateTime?>]`: The month and year the user graduated or completed the activity.
  - `[EndMonthYear <DateTime?>]`: The month and year the user completed the educational activity referenced.
  - `[Institution <IMicrosoftGraphInstitutionData>]`: institutionData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: Short description of the institution the user studied at.
    - `[DisplayName <String>]`: Name of the institution the user studied at.
    - `[Location <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[WebUrl <String>]`: Link to the institution or department homepage.
  - `[Program <IMicrosoftGraphEducationalActivityDetail>]`: educationalActivityDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Abbreviation <String>]`: Shortened name of the degree or program (example: PhD, MBA)
    - `[Activities <String[]>]`: Extracurricular activities undertaken alongside the program.
    - `[Awards <String[]>]`: Any awards or honors associated with the program.
    - `[Description <String>]`: Short description of the program provided by the user.
    - `[DisplayName <String>]`: Long-form name of the program that the user has provided.
    - `[FieldsOfStudy <String[]>]`: Majors and minors associated with the program. (if applicable)
    - `[Grade <String>]`: The final grade, class, GPA or score.
    - `[Notes <String>]`: Additional notes the user has provided.
    - `[WebUrl <String>]`: Link to the degree or program page.
  - `[StartMonthYear <DateTime?>]`: The month and year the user commenced the activity referenced.

EMAILS <IMicrosoftGraphItemEmail[]>: Represents detailed information about email addresses associated with the user.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Address <String>]`: The email address itself.
  - `[DisplayName <String>]`: The name or label a user has associated with a particular email address.
  - `[Type <String>]`: emailType

INPUTOBJECT <IPeopleIdentity>: Identity Parameter
  - `[ActivityStatisticsId <String>]`: key: id of activityStatistics
  - `[EducationalActivityId <String>]`: key: id of educationalActivity
  - `[ItemAddressId <String>]`: key: id of itemAddress
  - `[ItemEmailId <String>]`: key: id of itemEmail
  - `[ItemPatentId <String>]`: key: id of itemPatent
  - `[ItemPhoneId <String>]`: key: id of itemPhone
  - `[ItemPublicationId <String>]`: key: id of itemPublication
  - `[LanguageProficiencyId <String>]`: key: id of languageProficiency
  - `[PersonAnnotationId <String>]`: key: id of personAnnotation
  - `[PersonAnnualEventId <String>]`: key: id of personAnnualEvent
  - `[PersonAwardId <String>]`: key: id of personAward
  - `[PersonCertificationId <String>]`: key: id of personCertification
  - `[PersonId <String>]`: key: id of person
  - `[PersonInterestId <String>]`: key: id of personInterest
  - `[PersonNameId <String>]`: key: id of personName
  - `[PersonWebsiteId <String>]`: key: id of personWebsite
  - `[ProjectParticipationId <String>]`: key: id of projectParticipation
  - `[SharedInsightId <String>]`: key: id of sharedInsight
  - `[SkillProficiencyId <String>]`: key: id of skillProficiency
  - `[TrendingId <String>]`: key: id of trending
  - `[UsedInsightId <String>]`: key: id of usedInsight
  - `[UserAccountInformationId <String>]`: key: id of userAccountInformation
  - `[UserId <String>]`: key: id of user
  - `[WebAccountId <String>]`: key: id of webAccount
  - `[WorkPositionId <String>]`: key: id of workPosition

INTERESTS <IMicrosoftGraphPersonInterest[]>: Provides detailed information about interests the user has associated with themselves in various services.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Categories <String[]>]`: Contains categories a user has associated with the interest (for example, personal, recipies).
  - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
  - `[Description <String>]`: Contains a description of the interest.
  - `[DisplayName <String>]`: Contains a friendly name for the interest.
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: Contains a link to a web page or resource about the interest.

LANGUAGES <IMicrosoftGraphLanguageProficiency[]>: Represents detailed information about languages that a user has added to their profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Contains the long-form name for the language.
  - `[Proficiency <String>]`: languageProficiencyLevel
  - `[Reading <String>]`: languageProficiencyLevel
  - `[Spoken <String>]`: languageProficiencyLevel
  - `[Tag <String>]`: Contains the four-character BCP47 name for the language (en-US, no-NB, en-AU).
  - `[ThumbnailUrl <String>]`: 
  - `[Written <String>]`: languageProficiencyLevel

NAMES <IMicrosoftGraphPersonName[]>: Represents the names a user has added to their profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Provides an ordered rendering of firstName and lastName depending on the locale of the user or their device.
  - `[First <String>]`: First name of the user.
  - `[Initials <String>]`: Initials of the user.
  - `[LanguageTag <String>]`: Contains the name for the language (en-US, no-NB, en-AU) following IETF BCP47 format.
  - `[Last <String>]`: Last name of the user.
  - `[Maiden <String>]`: Maiden name of the user.
  - `[Middle <String>]`: Middle name of the user.
  - `[Nickname <String>]`: Nickname of the user.
  - `[Pronunciation <IMicrosoftGraphPersonNamePronounciation>]`: personNamePronounciation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
    - `[First <String>]`: 
    - `[Last <String>]`: 
    - `[Maiden <String>]`: 
    - `[Middle <String>]`: 
  - `[Suffix <String>]`: Designators used after the users name (eg: PhD.)
  - `[Title <String>]`: Honorifics used to prefix a users name (eg: Dr, Sir, Madam, Mrs.)

NOTES <IMicrosoftGraphPersonAnnotation[]>: Represents notes that a user has added to their profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Detail <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: Contains a friendly name for the note.
  - `[ThumbnailUrl <String>]`: 

PATENTS <IMicrosoftGraphItemPatent[]>: Represents patents that a user has added to their profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Description <String>]`: Descpription of the patent or filing.
  - `[DisplayName <String>]`: Title of the patent or filing.
  - `[IsPending <Boolean?>]`: Indicates the patent is pending.
  - `[IssuedDate <DateTime?>]`: The date that the patent was granted.
  - `[IssuingAuthority <String>]`: Authority which granted the patent.
  - `[Number <String>]`: The patent number.
  - `[WebUrl <String>]`: URL referencing the patent or filing.

PHONES <IMicrosoftGraphItemPhone[]>: Represents detailed information about phone numbers associated with a user in various services.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Friendly name the user has assigned this phone number.
  - `[Number <String>]`: Phone number provided by the user.
  - `[Type <String>]`: phoneType

POSITIONS <IMicrosoftGraphWorkPosition[]>: Represents detailed information about work positions associated with a user's profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Categories <String[]>]`: Categories that the user has associated with this position.
  - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: Colleagues that are associated with this position.
    - `[DisplayName <String>]`: Name of the person.
    - `[Relationship <String>]`: personRelationship
    - `[UserPrincipalName <String>]`: Email address or reference to person within organization.
  - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[City <String>]`: The city.
        - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
        - `[PostOfficeBox <String>]`: The post office box number.
        - `[PostalCode <String>]`: The postal code.
        - `[State <String>]`: The state.
        - `[Street <String>]`: The street.
        - `[Type <String>]`: physicalAddressType
      - `[Department <String>]`: Department Name within a company.
      - `[DisplayName <String>]`: Company name.
      - `[OfficeLocation <String>]`: Office Location of the person referred to.
      - `[Pronunciation <String>]`: Pronunciation guide for the company name.
      - `[WebUrl <String>]`: Link to the company home page.
    - `[Description <String>]`: Description of the position in question.
    - `[EndMonthYear <DateTime?>]`: When the position ended.
    - `[JobTitle <String>]`: The title held when in that position.
    - `[Role <String>]`: The role the position entailed.
    - `[StartMonthYear <DateTime?>]`: The start month and year of the position.
    - `[Summary <String>]`: Short summary of the position.
  - `[IsCurrent <Boolean?>]`: Denotes whether or not the position is current.
  - `[Manager <IMicrosoftGraphRelatedPerson>]`: relatedPerson

PROJECTS <IMicrosoftGraphProjectParticipation[]>: Represents detailed information about projects associated with a user.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Categories <String[]>]`: Contains categories a user has associated with the project (for example, digital transformation, oil rig).
  - `[Client <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[Department <String>]`: Department Name within a company.
    - `[DisplayName <String>]`: Company name.
    - `[OfficeLocation <String>]`: Office Location of the person referred to.
    - `[Pronunciation <String>]`: Pronunciation guide for the company name.
    - `[WebUrl <String>]`: Link to the company home page.
  - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
  - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: Lists people that also worked on the project.
    - `[DisplayName <String>]`: Name of the person.
    - `[Relationship <String>]`: personRelationship
    - `[UserPrincipalName <String>]`: Email address or reference to person within organization.
  - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[Description <String>]`: Description of the position in question.
    - `[EndMonthYear <DateTime?>]`: When the position ended.
    - `[JobTitle <String>]`: The title held when in that position.
    - `[Role <String>]`: The role the position entailed.
    - `[StartMonthYear <DateTime?>]`: The start month and year of the position.
    - `[Summary <String>]`: Short summary of the position.
  - `[DisplayName <String>]`: Contains a friendly name for the project.
  - `[Sponsors <IMicrosoftGraphRelatedPerson[]>]`: The Person or people who sponsored the project.
  - `[ThumbnailUrl <String>]`: 

PUBLICATIONS <IMicrosoftGraphItemPublication[]>: Represents details of any publications a user has added to their profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Description <String>]`: Description of the publication.
  - `[DisplayName <String>]`: Title of the publication.
  - `[PublishedDate <DateTime?>]`: The date that the publication was published.
  - `[Publisher <String>]`: Publication or publisher for the publication.
  - `[ThumbnailUrl <String>]`: URL referencing a thumbnail of the publication.
  - `[WebUrl <String>]`: URL referencing the publication.

SKILLS <IMicrosoftGraphSkillProficiency[]>: Represents detailed information about skills associated with a user in various services.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Categories <String[]>]`: Contains categories a user has associated with the skill (for example, personal, professional, hobby).
  - `[CollaborationTags <String[]>]`: Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
  - `[DisplayName <String>]`: Contains a friendly name for the skill.
  - `[Proficiency <String>]`: skillProficiencyLevel
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: Contains a link to an information source about the skill.

WEBACCOUNTS <IMicrosoftGraphWebAccount[]>: Represents web accounts the user has indicated they use or has added to their user profile.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Description <String>]`: Contains the description the user has provided for the account on the service being referenced.
  - `[Service <IMicrosoftGraphServiceInformation>]`: serviceInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: The name of the cloud service (for example, Twitter, Instagram).
    - `[WebUrl <String>]`: Contains the URL for the service being referenced.
  - `[StatusMessage <String>]`: Contains a status message from the cloud service if provided or synchronized.
  - `[ThumbnailUrl <String>]`: 
  - `[UserId <String>]`: The user name  displayed for the webaccount.
  - `[WebUrl <String>]`: Contains a link to the user's profile on the cloud service if one exists.

WEBSITES <IMicrosoftGraphPersonWebsite[]>: Represents detailed information about websites associated with a user in various services.
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: Confidence score reflecting the accuracy of the data inferred about the user.
    - `[UserHasVerifiedAccuracy <Boolean?>]`: Records if the user has confirmed this inference as being True or False.
  - `[IsSearchable <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: Provides the dateTimeOffset for when the entity was created.
  - `[Source <IMicrosoftGraphPersonDataSources>]`: personDataSources
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String[]>]`: 
  - `[Id <String>]`: 
  - `[Categories <String[]>]`: Contains categories a user has associated with the website (for example, personal, recipes).
  - `[Description <String>]`: Contains a description of the website.
  - `[DisplayName <String>]`: Contains a friendly name for the website.
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: Contains a link to the website itself.

## RELATED LINKS

