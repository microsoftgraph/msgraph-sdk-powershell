---
external help file:
Module Name: Microsoft.Graph.DevicesApps.SharedResources
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.sharedresources/new-mgusermobileapptroubleshootingeventapplogcollectionrequest
schema: 2.0.0
---

# New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequest

## SYNOPSIS
Create new navigation property to appLogCollectionRequests for users

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequest -MobileAppTroubleshootingEventId <String>
 -UserId <String> [-CompletedDateTime <DateTime>] [-CustomLogFolders <String[]>] [-ErrorMessage <String>]
 [-Id <String>] [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequest -MobileAppTroubleshootingEventId <String>
 -UserId <String> -BodyParameter <IMicrosoftGraphAppLogCollectionRequest> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequest
 -InputObject <IDevicesAppsSharedResourcesIdentity> -BodyParameter <IMicrosoftGraphAppLogCollectionRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserMobileAppTroubleshootingEventAppLogCollectionRequest
 -InputObject <IDevicesAppsSharedResourcesIdentity> [-CompletedDateTime <DateTime>]
 [-CustomLogFolders <String[]>] [-ErrorMessage <String>] [-Id <String>] [-Status <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to appLogCollectionRequests for users

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

### -BodyParameter
AppLogCollectionRequest Entity.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppLogCollectionRequest
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CompletedDateTime
Time at which the upload log request reached a terminal state

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CustomLogFolders
List of log folders.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ErrorMessage
Error message if any during the upload process

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsSharedResourcesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MobileAppTroubleshootingEventId
key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Status
appLogUploadState

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesAppsSharedResourcesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppLogCollectionRequest

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppLogCollectionRequest

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphAppLogCollectionRequest>: AppLogCollectionRequest Entity.
  - `[Id <String>]`: Read-only.
  - `[CompletedDateTime <DateTime?>]`: Time at which the upload log request reached a terminal state
  - `[CustomLogFolders <String[]>]`: List of log folders. 
  - `[ErrorMessage <String>]`: Error message if any during the upload process
  - `[Status <String>]`: appLogUploadState

#### INPUTOBJECT <IDevicesAppsSharedResourcesIdentity>: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: key: appLogCollectionRequest-id of appLogCollectionRequest
  - `[MobileAppTroubleshootingEventId <String>]`: key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

