---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Enrolment
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.enrolment/new-mgdevicemanagementandroiddeviceownerenrollmentprofile
schema: 2.0.0
---

# New-MgDeviceManagementAndroidDeviceOwnerEnrollmentProfile

## SYNOPSIS
Create new navigation property to androidDeviceOwnerEnrollmentProfiles for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementAndroidDeviceOwnerEnrollmentProfile [-AccountId <String>]
 [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-EnrolledDeviceCount <Int32>] [-EnrollmentMode <AndroidDeviceOwnerEnrollmentMode>]
 [-EnrollmentTokenType <AndroidDeviceOwnerEnrollmentTokenType>] [-EnrollmentTokenUsageCount <Int32>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>] [-QrCodeContent <String>]
 [-QrCodeImage <IMicrosoftGraphMimeContent>] [-RoleScopeTagIds <String[]>] [-TokenCreationDateTime <DateTime>]
 [-TokenExpirationDateTime <DateTime>] [-TokenValue <String>] [-WifiHidden] [-WifiPassword <String>]
 [-WifiSecurityType <AospWifiSecurityType>] [-WifiSsid <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementAndroidDeviceOwnerEnrollmentProfile
 -BodyParameter <IMicrosoftGraphAndroidDeviceOwnerEnrollmentProfile> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to androidDeviceOwnerEnrollmentProfiles for deviceManagement

## EXAMPLES

## PARAMETERS

### -AccountId
Tenant GUID the enrollment profile belongs to.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Enrollment Profile used to enroll Android Enterprise devices using Google's Cloud Management.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidDeviceOwnerEnrollmentProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date time the enrollment profile was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for the enrollment profile.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for the enrollment profile.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrolledDeviceCount
Total number of Android devices that have enrolled using this enrollment profile.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentMode
The enrollment mode for an enrollment profile.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AndroidDeviceOwnerEnrollmentMode
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentTokenType
The enrollment token type for an enrollment profile.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AndroidDeviceOwnerEnrollmentTokenType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentTokenUsageCount
Total number of AOSP devices that have enrolled using the current token.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Date time the enrollment profile was last modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QrCodeContent
String used to generate a QR code for the token.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -QrCodeImage
Contains properties for a generic mime content.
To construct, please use Get-Help -Online and see NOTES section for QRCODEIMAGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMimeContent
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenCreationDateTime
Date time the most recently created token was created.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenExpirationDateTime
Date time the most recently created token will expire.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TokenValue
Value of the most recently created token for this enrollment profile.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WifiHidden
Boolean that indicates if hidden wifi networks are enabled

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WifiPassword
String that contains the wi-fi login password

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WifiSecurityType
This enum represents Wi-Fi Security Types for Android Device Owner AOSP Scenarios.

```yaml
Type: Microsoft.Graph.PowerShell.Support.AospWifiSecurityType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WifiSsid
String that contains the wi-fi login ssid

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidDeviceOwnerEnrollmentProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidDeviceOwnerEnrollmentProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAndroidDeviceOwnerEnrollmentProfile>: Enrollment Profile used to enroll Android Enterprise devices using Google's Cloud Management.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AccountId <String>]`: Tenant GUID the enrollment profile belongs to.
  - `[CreatedDateTime <DateTime?>]`: Date time the enrollment profile was created.
  - `[Description <String>]`: Description for the enrollment profile.
  - `[DisplayName <String>]`: Display name for the enrollment profile.
  - `[EnrolledDeviceCount <Int32?>]`: Total number of Android devices that have enrolled using this enrollment profile.
  - `[EnrollmentMode <AndroidDeviceOwnerEnrollmentMode?>]`: The enrollment mode for an enrollment profile.
  - `[EnrollmentTokenType <AndroidDeviceOwnerEnrollmentTokenType?>]`: The enrollment token type for an enrollment profile.
  - `[EnrollmentTokenUsageCount <Int32?>]`: Total number of AOSP devices that have enrolled using the current token.
  - `[LastModifiedDateTime <DateTime?>]`: Date time the enrollment profile was last modified.
  - `[QrCodeContent <String>]`: String used to generate a QR code for the token.
  - `[QrCodeImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[TokenCreationDateTime <DateTime?>]`: Date time the most recently created token was created.
  - `[TokenExpirationDateTime <DateTime?>]`: Date time the most recently created token will expire.
  - `[TokenValue <String>]`: Value of the most recently created token for this enrollment profile.
  - `[WifiHidden <Boolean?>]`: Boolean that indicates if hidden wifi networks are enabled
  - `[WifiPassword <String>]`: String that contains the wi-fi login password
  - `[WifiSecurityType <AospWifiSecurityType?>]`: This enum represents Wi-Fi Security Types for Android Device Owner AOSP Scenarios.
  - `[WifiSsid <String>]`: String that contains the wi-fi login ssid

QRCODEIMAGE <IMicrosoftGraphMimeContent>: Contains properties for a generic mime content.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Type <String>]`: Indicates the content mime type.
  - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

