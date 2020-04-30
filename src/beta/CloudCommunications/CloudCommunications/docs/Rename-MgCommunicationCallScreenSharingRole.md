---
external help file:
Module Name: Microsoft.Graph.CloudCommunications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.cloudcommunications/rename-mgcommunicationcallscreensharingrole
schema: 2.0.0
---

# Rename-MgCommunicationCallScreenSharingRole

## SYNOPSIS
Invoke action changeScreenSharingRole

## SYNTAX

### ChangeExpanded (Default)
```
Rename-MgCommunicationCallScreenSharingRole -CallId <String> [-Role <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Change
```
Rename-MgCommunicationCallScreenSharingRole -CallId <String>
 -BodyParameter <IPathsOj95ZpCommunicationsCallsCallIdMicrosoftGraphChangescreensharingrolePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentity
```
Rename-MgCommunicationCallScreenSharingRole -InputObject <ICloudCommunicationsIdentity>
 -BodyParameter <IPathsOj95ZpCommunicationsCallsCallIdMicrosoftGraphChangescreensharingrolePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentityExpanded
```
Rename-MgCommunicationCallScreenSharingRole -InputObject <ICloudCommunicationsIdentity> [-Role <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action changeScreenSharingRole

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsOj95ZpCommunicationsCallsCallIdMicrosoftGraphChangescreensharingrolePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Change, ChangeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CallId
key: call-id of call

```yaml
Type: System.String
Parameter Sets: Change, ChangeExpanded
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity
Parameter Sets: ChangeViaIdentity, ChangeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Role
screenSharingRole

```yaml
Type: System.String
Parameter Sets: ChangeExpanded, ChangeViaIdentityExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.ICloudCommunicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPathsOj95ZpCommunicationsCallsCallIdMicrosoftGraphChangescreensharingrolePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPathsOj95ZpCommunicationsCallsCallIdMicrosoftGraphChangescreensharingrolePostRequestbodyContentApplicationJsonSchema>: .
  - `[Role <String>]`: screenSharingRole

#### INPUTOBJECT <ICloudCommunicationsIdentity>: Identity Parameter
  - `[AudioRoutingGroupId <String>]`: key: audioRoutingGroup-id of audioRoutingGroup
  - `[CallId <String>]`: key: call-id of call
  - `[CallRecordId <String>]`: key: callRecord-id of callRecord
  - `[CommsOperationId <String>]`: key: commsOperation-id of commsOperation
  - `[OnlineMeetingId <String>]`: key: onlineMeeting-id of onlineMeeting
  - `[ParticipantId <String>]`: key: participant-id of participant
  - `[SegmentId <String>]`: key: segment-id of segment
  - `[SessionId <String>]`: key: session-id of session

## RELATED LINKS

