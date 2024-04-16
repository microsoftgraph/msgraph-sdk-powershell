---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement/update-mgbetadevicemanagementandroidmanagedstoreaccountenterprisesetting
schema: 2.0.0
---

# Update-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSetting

## SYNOPSIS
Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSetting [-AdditionalProperties <Hashtable>]
 [-AndroidDeviceOwnerFullyManagedEnrollmentEnabled] [-BindStatus <String>]
 [-CompanyCodes <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>] [-DeviceOwnerManagementEnabled]
 [-EnrollmentTarget <String>] [-Id <String>] [-LastAppSyncDateTime <DateTime>] [-LastAppSyncStatus <String>]
 [-LastModifiedDateTime <DateTime>] [-ManagedGooglePlayInitialScopeTagIds <String[]>]
 [-OwnerOrganizationName <String>] [-OwnerUserPrincipalName <String>] [-ResponseHeadersVariable <String>]
 [-TargetGroupIds <String[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSetting
 -BodyParameter <IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property androidManagedStoreAccountEnterpriseSettings in deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BindStatus
Bind status of the tenant with the Google EMM API

```yaml
Type: System.String
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAndroidEnrollmentCompanyCode[]
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnrollmentTarget
Android for Work device management targeting type for the account

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
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
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastAppSyncStatus
Sync status of the tenant with the Google EMM API

```yaml
Type: System.String
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
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedGooglePlayInitialScopeTagIds
Initial scope tags for MGP apps

```yaml
Type: System.String[]
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
Type: System.String
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
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetGroupIds
Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'

```yaml
Type: System.String[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAndroidManagedStoreAccountEnterpriseSettings>`: Enterprise settings for an Android managed store account.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AndroidDeviceOwnerFullyManagedEnrollmentEnabled <Boolean?>]`: Company codes for AndroidManagedStoreAccountEnterpriseSettings
  - `[BindStatus <String>]`: Bind status of the tenant with the Google EMM API
  - `[CompanyCodes <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>]`: Company codes for AndroidManagedStoreAccountEnterpriseSettings
    - `[EnrollmentToken <String>]`: Enrollment Token used by the User to enroll their device.
    - `[QrCodeContent <String>]`: String used to generate a QR code for the token.
    - `[QrCodeImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Type <String>]`: Indicates the content mime type.
      - `[Value <Byte[]>]`: The byte array that contains the actual content.
  - `[DeviceOwnerManagementEnabled <Boolean?>]`: Indicates if this account is flighting for Android Device Owner Management with CloudDPC.
  - `[EnrollmentTarget <String>]`: Android for Work device management targeting type for the account
  - `[LastAppSyncDateTime <DateTime?>]`: Last completion time for app sync
  - `[LastAppSyncStatus <String>]`: Sync status of the tenant with the Google EMM API
  - `[LastModifiedDateTime <DateTime?>]`: Last modification time for Android enterprise settings
  - `[ManagedGooglePlayInitialScopeTagIds <String[]>]`: Initial scope tags for MGP apps
  - `[OwnerOrganizationName <String>]`: Organization name used when onboarding Android Enterprise
  - `[OwnerUserPrincipalName <String>]`: Owner UPN that created the enterprise
  - `[TargetGroupIds <String[]>]`: Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'

`COMPANYCODES <IMicrosoftGraphAndroidEnrollmentCompanyCode[]>`: Company codes for AndroidManagedStoreAccountEnterpriseSettings
  - `[EnrollmentToken <String>]`: Enrollment Token used by the User to enroll their device.
  - `[QrCodeContent <String>]`: String used to generate a QR code for the token.
  - `[QrCodeImage <IMicrosoftGraphMimeContent>]`: Contains properties for a generic mime content.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Type <String>]`: Indicates the content mime type.
    - `[Value <Byte[]>]`: The byte array that contains the actual content.

## RELATED LINKS

