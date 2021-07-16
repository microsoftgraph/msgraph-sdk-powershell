---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/update-mgdevicemanagementandroidmanagedstoreaccountenterprisesetting
schema: 2.0.0
---

# Update-MgDeviceManagementAndroidManagedStoreAccountEnterpriseSetting

## SYNOPSIS
The singleton Android managed store account enterprise settings entity.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementAndroidManagedStoreAccountEnterpriseSetting [-AdditionalProperties <Hashtable>]
 [-AndroidDeviceOwnerFullyManagedEnrollmentEnabled] [-BindStatus <String>]
 [-CompanyCodes <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>] [-DeviceOwnerManagementEnabled]
 [-EnrollmentTarget <String>] [-Id <String>] [-LastAppSyncDateTime <DateTime>] [-LastAppSyncStatus <String>]
 [-LastModifiedDateTime <DateTime>] [-OwnerOrganizationName <String>] [-OwnerUserPrincipalName <String>]
 [-TargetGroupIds <String[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementAndroidManagedStoreAccountEnterpriseSetting
 -BodyParameter <IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The singleton Android managed store account enterprise settings entity.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AndroidDeviceOwnerFullyManagedEnrollmentEnabled
Company codes for AndroidManagedStoreAccountEnterpriseSettings

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BindStatus
androidManagedStoreAccountBindStatus

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Enterprise settings for an Android managed store account.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompanyCodes
Company codes for AndroidManagedStoreAccountEnterpriseSettings
To construct, see NOTES section for COMPANYCODES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAndroidEnrollmentCompanyCode[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceOwnerManagementEnabled
Indicates if this account is flighting for Android Device Owner Management with CloudDPC.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentTarget
androidManagedStoreAccountEnrollmentTarget

```yaml
Type: String
Parameter Sets: UpdateExpanded
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
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastAppSyncDateTime
Last completion time for app sync

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastAppSyncStatus
androidManagedStoreAccountAppSyncStatus

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last modification time for Android enterprise settings

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerOrganizationName
Organization name used when onboarding Android Enterprise

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerUserPrincipalName
Owner UPN that created the enterprise

```yaml
Type: String
Parameter Sets: UpdateExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetGroupIds
Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'

```yaml
Type: String[]
Parameter Sets: UpdateExpanded
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings>: Enterprise settings for an Android managed store account.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AndroidDeviceOwnerFullyManagedEnrollmentEnabled <Boolean?>]`: Company codes for AndroidManagedStoreAccountEnterpriseSettings
  - `[BindStatus <String>]`: androidManagedStoreAccountBindStatus
  - `[CompanyCodes <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>]`: Company codes for AndroidManagedStoreAccountEnterpriseSettings
    - `[EnrollmentToken <String>]`: Enrollment Token used by the User to enroll their device.
    - `[QrCodeContent <String>]`: String used to generate a QR code for the token.
    - `[QrCodeImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: Indicates the content mime type.
      - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[DeviceOwnerManagementEnabled <Boolean?>]`: Indicates if this account is flighting for Android Device Owner Management with CloudDPC.
  - `[EnrollmentTarget <String>]`: androidManagedStoreAccountEnrollmentTarget
  - `[LastAppSyncDateTime <DateTime?>]`: Last completion time for app sync
  - `[LastAppSyncStatus <String>]`: androidManagedStoreAccountAppSyncStatus
  - `[LastModifiedDateTime <DateTime?>]`: Last modification time for Android enterprise settings
  - `[OwnerOrganizationName <String>]`: Organization name used when onboarding Android Enterprise
  - `[OwnerUserPrincipalName <String>]`: Owner UPN that created the enterprise
  - `[TargetGroupIds <String[]>]`: Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'

COMPANYCODES <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>: Company codes for AndroidManagedStoreAccountEnterpriseSettings
  - `[EnrollmentToken <String>]`: Enrollment Token used by the User to enroll their device.
  - `[QrCodeContent <String>]`: String used to generate a QR code for the token.
  - `[QrCodeImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS
