---
external help file:
Module Name: Microsoft.Graph.People
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people/get-mguserprofile
schema: 2.0.0
---

# Get-MgUserProfile

## SYNOPSIS
Retrieve the properties and relationships of a profile object for a given user.
The **profile** resource exposes various rich properties that are descriptive of the user as relationships, for example, anniversaries and education activities.
To get one of these navigation properties, use the corresponding GET method on that property.
See the methods exposed by **profile**.

## SYNTAX

### Get (Default)
```
Get-MgUserProfile -UserId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserProfile -InputObject <IPeopleIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Retrieve the properties and relationships of a profile object for a given user.
The **profile** resource exposes various rich properties that are descriptive of the user as relationships, for example, anniversaries and education activities.
To get one of these navigation properties, use the corresponding GET method on that property.
See the methods exposed by **profile**.

## EXAMPLES

### Example 1: Using the Get-MgUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfile -UserId $userId
```

This example shows how to use the Get-MgUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfile -UserId $userId -ExpandProperty "names(`$select=first,last),skills(`$select=displayName)" 
```

This example shows how to use the Get-MgUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IPeopleIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IPeopleIdentity>: Identity Parameter
  - `[ActivityStatisticsId <String>]`: The unique identifier of activityStatistics
  - `[EducationalActivityId <String>]`: The unique identifier of educationalActivity
  - `[ItemAddressId <String>]`: The unique identifier of itemAddress
  - `[ItemEmailId <String>]`: The unique identifier of itemEmail
  - `[ItemPatentId <String>]`: The unique identifier of itemPatent
  - `[ItemPhoneId <String>]`: The unique identifier of itemPhone
  - `[ItemPublicationId <String>]`: The unique identifier of itemPublication
  - `[LanguageProficiencyId <String>]`: The unique identifier of languageProficiency
  - `[PersonAnnotationId <String>]`: The unique identifier of personAnnotation
  - `[PersonAnnualEventId <String>]`: The unique identifier of personAnnualEvent
  - `[PersonAwardId <String>]`: The unique identifier of personAward
  - `[PersonCertificationId <String>]`: The unique identifier of personCertification
  - `[PersonId <String>]`: The unique identifier of person
  - `[PersonInterestId <String>]`: The unique identifier of personInterest
  - `[PersonNameId <String>]`: The unique identifier of personName
  - `[PersonWebsiteId <String>]`: The unique identifier of personWebsite
  - `[ProjectParticipationId <String>]`: The unique identifier of projectParticipation
  - `[SharedInsightId <String>]`: The unique identifier of sharedInsight
  - `[SkillProficiencyId <String>]`: The unique identifier of skillProficiency
  - `[TrendingId <String>]`: The unique identifier of trending
  - `[UsedInsightId <String>]`: The unique identifier of usedInsight
  - `[UserAccountInformationId <String>]`: The unique identifier of userAccountInformation
  - `[UserId <String>]`: The unique identifier of user
  - `[WebAccountId <String>]`: The unique identifier of webAccount
  - `[WorkPositionId <String>]`: The unique identifier of workPosition

## RELATED LINKS

