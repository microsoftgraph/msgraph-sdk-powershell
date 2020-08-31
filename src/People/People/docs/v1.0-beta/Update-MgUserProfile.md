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
 [-Anniversaries <IMicrosoftGraphPersonAnniversary[]>] [-Awards <IMicrosoftGraphPersonAward[]>]
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
 [-Anniversaries <IMicrosoftGraphPersonAnniversary[]>] [-Awards <IMicrosoftGraphPersonAward[]>]
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

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -Account
.
To construct, see NOTES section for ACCOUNT properties and create a hash table.

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
.
To construct, see NOTES section for ADDRESSES properties and create a hash table.

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
.
To construct, see NOTES section for ANNIVERSARIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPersonAnniversary[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Awards
.
To construct, see NOTES section for AWARDS properties and create a hash table.

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

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
.
To construct, see NOTES section for CERTIFICATIONS properties and create a hash table.

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
.
To construct, see NOTES section for EDUCATIONALACTIVITIES properties and create a hash table.

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
.
To construct, see NOTES section for EMAILS properties and create a hash table.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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
.
To construct, see NOTES section for INTERESTS properties and create a hash table.

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
.
To construct, see NOTES section for LANGUAGES properties and create a hash table.

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
.
To construct, see NOTES section for NAMES properties and create a hash table.

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
.
To construct, see NOTES section for NOTES properties and create a hash table.

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
.
To construct, see NOTES section for PATENTS properties and create a hash table.

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
.
To construct, see NOTES section for PHONES properties and create a hash table.

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
.
To construct, see NOTES section for POSITIONS properties and create a hash table.

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
.
To construct, see NOTES section for PROJECTS properties and create a hash table.

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
.
To construct, see NOTES section for PUBLICATIONS properties and create a hash table.

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
.
To construct, see NOTES section for SKILLS properties and create a hash table.

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
.
To construct, see NOTES section for WEBACCOUNTS properties and create a hash table.

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
.
To construct, see NOTES section for WEBSITES properties and create a hash table.

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
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[AgeGroup <String>]`: 
  - `[CountryCode <String>]`: 
  - `[PreferredLanguageTag <IMicrosoftGraphLocaleInfo>]`: localeInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
    - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
  - `[UserPrincipalName <String>]`: 

ADDRESSES <IMicrosoftGraphItemAddress[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Detail <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: 
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[DisplayName <String>]`: 
  - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
    - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.

ANNIVERSARIES <IMicrosoftGraphPersonAnniversary[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Date <DateTime?>]`: 
  - `[Type <String>]`: anniversaryType

AWARDS <IMicrosoftGraphPersonAward[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IssuedDate <DateTime?>]`: 
  - `[IssuingAuthority <String>]`: 
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: 

BODYPARAMETER <IMicrosoftGraphProfile>: profile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
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
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ConfidenceScore <Double?>]`: 
      - `[UserHasVerifiedAccuracy <Boolean?>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[AgeGroup <String>]`: 
    - `[CountryCode <String>]`: 
    - `[PreferredLanguageTag <IMicrosoftGraphLocaleInfo>]`: localeInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: A name representing the user's locale in natural language, for example, 'English (United States)'.
      - `[Locale <String>]`: A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.
    - `[UserPrincipalName <String>]`: 
  - `[Addresses <IMicrosoftGraphItemAddress[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Detail <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: 
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[DisplayName <String>]`: 
    - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
      - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
      - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
  - `[Anniversaries <IMicrosoftGraphPersonAnniversary[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Date <DateTime?>]`: 
    - `[Type <String>]`: anniversaryType
  - `[Awards <IMicrosoftGraphPersonAward[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IssuedDate <DateTime?>]`: 
    - `[IssuingAuthority <String>]`: 
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Certifications <IMicrosoftGraphPersonCertification[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[CertificationId <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[EndDate <DateTime?>]`: 
    - `[IssuedDate <DateTime?>]`: 
    - `[IssuingAuthority <String>]`: 
    - `[IssuingCompany <String>]`: 
    - `[StartDate <DateTime?>]`: 
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: 
  - `[EducationalActivities <IMicrosoftGraphEducationalActivity[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[CompletionMonthYear <DateTime?>]`: 
    - `[EndMonthYear <DateTime?>]`: 
    - `[Institution <IMicrosoftGraphInstitutionData>]`: institutionData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Location <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[WebUrl <String>]`: 
    - `[Program <IMicrosoftGraphEducationalActivityDetail>]`: educationalActivityDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Abbreviation <String>]`: 
      - `[Activities <String>]`: 
      - `[Awards <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[FieldsOfStudy <String>]`: 
      - `[Grade <String>]`: 
      - `[Notes <String>]`: 
      - `[WebUrl <String>]`: 
    - `[StartMonthYear <DateTime?>]`: 
  - `[Emails <IMicrosoftGraphItemEmail[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Address <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Type <String>]`: emailType
  - `[Interests <IMicrosoftGraphPersonInterest[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Categories <String[]>]`: 
    - `[CollaborationTags <String[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Languages <IMicrosoftGraphLanguageProficiency[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Proficiency <String>]`: languageProficiencyLevel
    - `[Reading <String>]`: languageProficiencyLevel
    - `[Spoken <String>]`: languageProficiencyLevel
    - `[Tag <String>]`: 
    - `[Written <String>]`: languageProficiencyLevel
  - `[Names <IMicrosoftGraphPersonName[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[First <String>]`: 
    - `[Initials <String>]`: 
    - `[LanguageTag <String>]`: 
    - `[Last <String>]`: 
    - `[Maiden <String>]`: 
    - `[Middle <String>]`: 
    - `[Nickname <String>]`: 
    - `[Pronunciation <IMicrosoftGraphYomiPersonName>]`: yomiPersonName
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[First <String>]`: 
      - `[Last <String>]`: 
      - `[Maiden <String>]`: 
      - `[Middle <String>]`: 
    - `[Suffix <String>]`: 
    - `[Title <String>]`: 
  - `[Notes <IMicrosoftGraphPersonAnnotation[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Detail <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[DisplayName <String>]`: 
  - `[Patents <IMicrosoftGraphItemPatent[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsPending <Boolean?>]`: 
    - `[IssuedDate <DateTime?>]`: 
    - `[IssuingAuthority <String>]`: 
    - `[Number <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Phones <IMicrosoftGraphItemPhone[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Number <String>]`: 
    - `[Type <String>]`: phoneType
  - `[Positions <IMicrosoftGraphWorkPosition[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Categories <String[]>]`: 
    - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: 
      - `[DisplayName <String>]`: 
      - `[Relationship <String>]`: personRelationship
      - `[UserPrincipalName <String>]`: 
    - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
        - `[Department <String>]`: 
        - `[DisplayName <String>]`: 
        - `[OfficeLocation <String>]`: 
        - `[Pronunciation <String>]`: 
        - `[WebUrl <String>]`: 
      - `[Description <String>]`: 
      - `[EndMonthYear <DateTime?>]`: 
      - `[JobTitle <String>]`: 
      - `[Role <String>]`: 
      - `[StartMonthYear <DateTime?>]`: 
      - `[Summary <String>]`: 
    - `[IsCurrent <Boolean?>]`: 
    - `[Manager <IMicrosoftGraphRelatedPerson>]`: relatedPerson
  - `[Projects <IMicrosoftGraphProjectParticipation[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Categories <String[]>]`: 
    - `[Client <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[CollaborationTags <String[]>]`: 
    - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: 
    - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[DisplayName <String>]`: 
    - `[Sponsors <IMicrosoftGraphRelatedPerson[]>]`: 
  - `[Publications <IMicrosoftGraphItemPublication[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[PublishedDate <DateTime?>]`: 
    - `[Publisher <String>]`: 
    - `[ThumbnailUrl <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Skills <IMicrosoftGraphSkillProficiency[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Categories <String[]>]`: 
    - `[CollaborationTags <String[]>]`: 
    - `[DisplayName <String>]`: 
    - `[Proficiency <String>]`: skillProficiencyLevel
    - `[WebUrl <String>]`: 
  - `[WebAccounts <IMicrosoftGraphWebAccount[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Description <String>]`: 
    - `[Service <IMicrosoftGraphServiceInformation>]`: serviceInformation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Name <String>]`: 
      - `[WebUrl <String>]`: 
    - `[StatusMessage <String>]`: 
    - `[UserId <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Websites <IMicrosoftGraphPersonWebsite[]>]`: 
    - `[AllowedAudiences <String>]`: allowedAudiences
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[Id <String>]`: Read-only.
    - `[Categories <String[]>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[WebUrl <String>]`: 

CERTIFICATIONS <IMicrosoftGraphPersonCertification[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[CertificationId <String>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDate <DateTime?>]`: 
  - `[IssuedDate <DateTime?>]`: 
  - `[IssuingAuthority <String>]`: 
  - `[IssuingCompany <String>]`: 
  - `[StartDate <DateTime?>]`: 
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: 

EDUCATIONALACTIVITIES <IMicrosoftGraphEducationalActivity[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[CompletionMonthYear <DateTime?>]`: 
  - `[EndMonthYear <DateTime?>]`: 
  - `[Institution <IMicrosoftGraphInstitutionData>]`: institutionData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Location <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: 
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[WebUrl <String>]`: 
  - `[Program <IMicrosoftGraphEducationalActivityDetail>]`: educationalActivityDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Abbreviation <String>]`: 
    - `[Activities <String>]`: 
    - `[Awards <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[FieldsOfStudy <String>]`: 
    - `[Grade <String>]`: 
    - `[Notes <String>]`: 
    - `[WebUrl <String>]`: 
  - `[StartMonthYear <DateTime?>]`: 

EMAILS <IMicrosoftGraphItemEmail[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Address <String>]`: 
  - `[DisplayName <String>]`: 
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
  - `[PersonAnniversaryId <String>]`: key: id of personAnniversary
  - `[PersonAnnotationId <String>]`: key: id of personAnnotation
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

INTERESTS <IMicrosoftGraphPersonInterest[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Categories <String[]>]`: 
  - `[CollaborationTags <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[WebUrl <String>]`: 

LANGUAGES <IMicrosoftGraphLanguageProficiency[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Proficiency <String>]`: languageProficiencyLevel
  - `[Reading <String>]`: languageProficiencyLevel
  - `[Spoken <String>]`: languageProficiencyLevel
  - `[Tag <String>]`: 
  - `[Written <String>]`: languageProficiencyLevel

NAMES <IMicrosoftGraphPersonName[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[First <String>]`: 
  - `[Initials <String>]`: 
  - `[LanguageTag <String>]`: 
  - `[Last <String>]`: 
  - `[Maiden <String>]`: 
  - `[Middle <String>]`: 
  - `[Nickname <String>]`: 
  - `[Pronunciation <IMicrosoftGraphYomiPersonName>]`: yomiPersonName
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
    - `[First <String>]`: 
    - `[Last <String>]`: 
    - `[Maiden <String>]`: 
    - `[Middle <String>]`: 
  - `[Suffix <String>]`: 
  - `[Title <String>]`: 

NOTES <IMicrosoftGraphPersonAnnotation[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Detail <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 

PATENTS <IMicrosoftGraphItemPatent[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsPending <Boolean?>]`: 
  - `[IssuedDate <DateTime?>]`: 
  - `[IssuingAuthority <String>]`: 
  - `[Number <String>]`: 
  - `[WebUrl <String>]`: 

PHONES <IMicrosoftGraphItemPhone[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Number <String>]`: 
  - `[Type <String>]`: phoneType

POSITIONS <IMicrosoftGraphWorkPosition[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Categories <String[]>]`: 
  - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: 
    - `[DisplayName <String>]`: 
    - `[Relationship <String>]`: personRelationship
    - `[UserPrincipalName <String>]`: 
  - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[City <String>]`: The city.
        - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
        - `[PostOfficeBox <String>]`: 
        - `[PostalCode <String>]`: The postal code.
        - `[State <String>]`: The state.
        - `[Street <String>]`: The street.
        - `[Type <String>]`: physicalAddressType
      - `[Department <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OfficeLocation <String>]`: 
      - `[Pronunciation <String>]`: 
      - `[WebUrl <String>]`: 
    - `[Description <String>]`: 
    - `[EndMonthYear <DateTime?>]`: 
    - `[JobTitle <String>]`: 
    - `[Role <String>]`: 
    - `[StartMonthYear <DateTime?>]`: 
    - `[Summary <String>]`: 
  - `[IsCurrent <Boolean?>]`: 
  - `[Manager <IMicrosoftGraphRelatedPerson>]`: relatedPerson

PROJECTS <IMicrosoftGraphProjectParticipation[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Categories <String[]>]`: 
  - `[Client <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress1>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: 
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[Department <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OfficeLocation <String>]`: 
    - `[Pronunciation <String>]`: 
    - `[WebUrl <String>]`: 
  - `[CollaborationTags <String[]>]`: 
  - `[Colleagues <IMicrosoftGraphRelatedPerson[]>]`: 
    - `[DisplayName <String>]`: 
    - `[Relationship <String>]`: personRelationship
    - `[UserPrincipalName <String>]`: 
  - `[Detail <IMicrosoftGraphPositionDetail>]`: positionDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Company <IMicrosoftGraphCompanyDetail>]`: companyDetail
    - `[Description <String>]`: 
    - `[EndMonthYear <DateTime?>]`: 
    - `[JobTitle <String>]`: 
    - `[Role <String>]`: 
    - `[StartMonthYear <DateTime?>]`: 
    - `[Summary <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Sponsors <IMicrosoftGraphRelatedPerson[]>]`: 

PUBLICATIONS <IMicrosoftGraphItemPublication[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[PublishedDate <DateTime?>]`: 
  - `[Publisher <String>]`: 
  - `[ThumbnailUrl <String>]`: 
  - `[WebUrl <String>]`: 

SKILLS <IMicrosoftGraphSkillProficiency[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Categories <String[]>]`: 
  - `[CollaborationTags <String[]>]`: 
  - `[DisplayName <String>]`: 
  - `[Proficiency <String>]`: skillProficiencyLevel
  - `[WebUrl <String>]`: 

WEBACCOUNTS <IMicrosoftGraphWebAccount[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: 
  - `[Service <IMicrosoftGraphServiceInformation>]`: serviceInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Name <String>]`: 
    - `[WebUrl <String>]`: 
  - `[StatusMessage <String>]`: 
  - `[UserId <String>]`: 
  - `[WebUrl <String>]`: 

WEBSITES <IMicrosoftGraphPersonWebsite[]>: .
  - `[AllowedAudiences <String>]`: allowedAudiences
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Inference <IMicrosoftGraphInferenceData>]`: inferenceData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ConfidenceScore <Double?>]`: 
    - `[UserHasVerifiedAccuracy <Boolean?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Source <IMicrosoftGraphPersonDataSource>]`: personDataSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Categories <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[WebUrl <String>]`: 

## RELATED LINKS

