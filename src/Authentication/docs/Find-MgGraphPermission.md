---
external help file: Microsoft.Graph.Authentication-help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission
schema: 2.0.0
---

# Find-MgGraphPermission

## SYNOPSIS
The Microsoft Graph PowerShell SDK application requires users to have domain knowledge of both the semantics and syntax of Microsoft Graph API permissions used to authorize access to the API. This cmdlet helps to answer the following questions:  - How do I find the values to supply to the permission-related parameters of commands like New-MgApplication and other application and consent related commands? - What permissions are applicable to a certain domain, for example, application, directory? To use Microsoft Graph PowerShell SDK to access Microsoft Graph, users must sign in to an Azure AD application using the Connect-MgGraph command. Use the Find-MgGraphCommand to find which permissions to use for a specific cmdlet or API.-  Currently PowerShell commands and scripts, including those implemented with Microsoft Graph PowerShell SDK itself, have no way of validating user input that refers to permissions or providing "auto-complete" user experiences to help users accurately supply input to commands

## SYNTAX

### Search
```
Find-MgGraphPermission [-SearchString] <String> [-ExactMatch] [-PermissionType <String>] [-Online]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### All
```
Find-MgGraphPermission [-PermissionType <String>] [-Online] [-All] [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

## DESCRIPTION
Retrieves permissions that are applicable to a certain domain. For example application, directory.

## EXAMPLES

### Example 1: Find permissions related to a given domain
```powershell
PS C:\> Find-MgGraphPermission application
PermissionType: Delegated

Id                                   Consent Name                                      Description
--                                   ------- ----                                      -----------
c79f8feb-a9db-4090-85f9-90d820caa0eb Admin   Application.Read.All                      Allows the app to read applications and service principals on behalf of the signed-in user.
bdfbf15f-ee85-4955-8675-146e8e5296b5 Admin   Application.ReadWrite.All                 Allows the app to create, read, update and delete applications and service principals on behalf of the signed-in user. Does not allow management of consent grants.
b27add92-efb2-4f16-84f5-8108ba77985c Admin   Policy.ReadWrite.ApplicationConfiguration Allows the app to read and write your organization's application configuration policies on behalf of the signed-in user.  This includes policies such as activityBasedTimeoutPolicy, claimsMappingPolicy, homeRealmDiscoveryPolicy,  tokenIssuancePolicy and tokenLifetimePolicy.


   PermissionType: Application

Id                                   Consent Name                                      Description
--                                   ------- ----                                      -----------
9a5d68dd-52b0-4cc2-bd40-abcf44ac3a30 Admin   Application.Read.All                      Allows the app to read all applications and service principals without a signed-in user.
1bfefb4e-e0b5-418b-a88f-73c46d2cc8e9 Admin   Application.ReadWrite.All                 Allows the app to create, read, update and delete applications and service principals without a signed-in user.  Does not allow management of consent grants.
18a4783c-866b-4cc7-a460-3d5e5662c884 Admin   Application.ReadWrite.OwnedBy             Allows the app to create other applications, and fully manage those applications (read, update, update application secrets and delete), without a signed-in user.  It cannot update any apps that it is not an owner of.
be74164b-cff1-491c-8741-e671cb536e13 Admin   Policy.ReadWrite.ApplicationConfiguration Allows the app to read and write your organization's application configuration policies, without a signed-in user.  This includes policies such as activityBasedTimeoutPolicy, claimsMappingPolicy, homeRealmDiscoveryPolicy, tokenIssuancePolicy  and tokenLifetimePolicy.
```

Retrieves permissions related to a given domain.

### Example 2: Find the identifier for a specific permission
```powershell
PS C:\> Find-MgGraphPermission application.Read | Format-List
Id             : c79f8feb-a9db-4090-85f9-90d820caa0eb
PermissionType : Delegated
Consent        : Admin
Name           : Application.Read.All
Description    : Allows the app to read applications and service principals on behalf of the signed-in user.

Id             : bdfbf15f-ee85-4955-8675-146e8e5296b5
PermissionType : Delegated
Consent        : Admin
Name           : Application.ReadWrite.All
Description    : Allows the app to create, read, update and delete applications and service principals on behalf of the signed-in user. Does not allow management of consent grants.

Id             : 9a5d68dd-52b0-4cc2-bd40-abcf44ac3a30
PermissionType : Application
Consent        : Admin
Name           : Application.Read.All
Description    : Allows the app to read all applications and service principals without a signed-in user.
```

Retrieves identifier for a specific permission.

## PARAMETERS

### -All
{{ Fill All Description }}

```yaml
Type: SwitchParameter
Parameter Sets: All
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExactMatch
{{ Fill ExactMatch Description }}

```yaml
Type: SwitchParameter
Parameter Sets: Search
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Online
{{ Fill Online Description }}

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

### -PermissionType
{{ Fill PermissionType Description }}

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SearchString
{{ Fill SearchString Description }}

```yaml
Type: String
Parameter Sets: Search
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### You can pipe permission names in the form of strings to Find-MgGraphPermission.
## OUTPUTS

### This command returns a collection of items with the following fields:
### * Name: The name of the permission as found in Microsoft Graph permissions reference documentation. Names will typically
### have a form like 'User.Read.All', or 'Files.ReadWrite' for instance.
### * Description: Provides a description of what access is granted by the permission
### * Id: The unique identifier for the permission in the form of a Guid. The unique identifier is required for using
### certain Microsoft Graph REST API resources or Microsoft Graph-based PowerShell commands that manage application consent.
### * Consent: Denotes whether the specified permission requires administrator or user consent. The valid values are 'Admin' and 'User'.
### * PermissionType: Valid values are 'Delegated' or 'Application' depending on whether the permission is one that is delegated by
### the user to the application ('Delegated'), or is directly assigned to the application without the consent of a user ('Application').
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission)

