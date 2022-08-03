---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmobileapp
schema: 2.0.0
---

# New-MgDeviceAppMgtMobileApp

## SYNOPSIS
Create new navigation property to mobileApps for deviceAppManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceAppMgtMobileApp [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphMobileAppAssignment1[]>] [-Categories <IMicrosoftGraphMobileAppCategory[]>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-Developer <String>] [-DisplayName <String>]
 [-Id <String>] [-InformationUrl <String>] [-IsFeatured] [-LargeIcon <IMicrosoftGraphMimeContent>]
 [-LastModifiedDateTime <DateTime>] [-Notes <String>] [-Owner <String>] [-PrivacyInformationUrl <String>]
 [-Publisher <String>] [-PublishingState <MobileAppPublishingState>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceAppMgtMobileApp -BodyParameter <IMicrosoftGraphMobileApp1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileApps for deviceAppManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The list of group assignments for this mobile app.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppAssignment1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
An abstract class containing the base properties for Intune mobile apps.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
The list of categories for this app.
To construct, please use Get-Help -Online and see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppCategory[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time the app was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Developer
The developer of the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The admin provided or imported title of the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InformationUrl
The more information Url.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsFeatured
The value indicating whether the app is marked as featured by the admin.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LargeIcon
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for LARGEICON properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time the app was last modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Notes
Notes for the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
The owner of the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivacyInformationUrl
The privacy statement Url.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publisher
The publisher of the app.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishingState
Indicates the publishing state of an app.

```yaml
Type: Microsoft.Graph.PowerShell.Support.MobileAppPublishingState
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileApp1

## NOTES

ALIASES

### New-MgDeviceAppManagementMobileApp

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphMobileAppAssignment1[]>: The list of group assignments for this mobile app.
  - `[Id <String>]`: 
  - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
  - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphMobileApp1>: An abstract class containing the base properties for Intune mobile apps.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphMobileAppAssignment1[]>]`: The list of group assignments for this mobile app.
    - `[Id <String>]`: 
    - `[Intent <InstallIntent?>]`: Possible values for the install intent chosen by the admin.
    - `[Settings <IMicrosoftGraphMobileAppAssignmentSettings>]`: Abstract class to contain properties used to assign a mobile app to a group.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <IMicrosoftGraphMobileAppCategory[]>]`: The list of categories for this app.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The name of the app category.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.
  - `[CreatedDateTime <DateTime?>]`: The date and time the app was created.
  - `[Description <String>]`: The description of the app.
  - `[Developer <String>]`: The developer of the app.
  - `[DisplayName <String>]`: The admin provided or imported title of the app.
  - `[InformationUrl <String>]`: The more information Url.
  - `[IsFeatured <Boolean?>]`: The value indicating whether the app is marked as featured by the admin.
  - `[LargeIcon <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the app was last modified.
  - `[Notes <String>]`: Notes for the app.
  - `[Owner <String>]`: The owner of the app.
  - `[PrivacyInformationUrl <String>]`: The privacy statement Url.
  - `[Publisher <String>]`: The publisher of the app.
  - `[PublishingState <MobileAppPublishingState?>]`: Indicates the publishing state of an app.

CATEGORIES <IMicrosoftGraphMobileAppCategory[]>: The list of categories for this app.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The name of the app category.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time the mobileAppCategory was last modified.

LARGEICON <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

