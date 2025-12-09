---
external help file: Microsoft.Graph.Authentication.dll-Help.xml
Module Name: Microsoft.Graph.Authentication
online version: https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/invoke-mggraphrequest
schema: 2.0.0
---

# Invoke-MgGraphRequest

## SYNOPSIS
Invoke-MgGraphRequest issues REST API requests to the Graph API. It works for any Graph API if you know the REST URI, method, and optional body parameter. This command is especially useful for accessing APIs for which there isn't an equivalent cmdlet yet.

## SYNTAX

```
Invoke-MgGraphRequest [[-Method] <GraphRequestMethod>] [-Uri] <Uri> [[-Body] <Object>]
 [[-Headers] <IDictionary>] [[-OutputFilePath] <String>] [-InferOutputFileName] [[-InputFilePath] <String>]
 [-PassThru] [-SkipHeaderValidation] [[-ContentType] <String>] [[-SessionVariable] <String>]
 [[-ResponseHeadersVariable] <String>] [[-StatusCodeVariable] <String>] [-SkipHttpErrorCheck]
 [[-GraphRequestSession] <GraphRequestSession>] [[-UserAgent] <String>] [[-OutputType] <OutputType>]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
This command issues REST API requests.

## EXAMPLES

### Example 1: Using Invoke-MgGraphRequest
```powershell
PS C:\> Invoke-MgGraphRequest -Method GET https://graph.microsoft.com/v1.0/me
Name                           Value
----                           -----
userPrincipalName              admin@Contoso.com
preferredLanguage              en-US
mobilePhone                    425-555-0101
displayName                    MOD Administrator
givenName                      MOD
mail                           admin@contoso.com
@odata.context                 https://graph.microsoft.com/v1.0/$metadata#users/$entity
id                             694bab60-392a-4f64-9430-c1dea2951f50
jobTitle
officeLocation
businessPhones                 {425-555-0100}
surname                        Administrator
```

Issues REST API requests.

## PARAMETERS

### -Body
Request Body.
Required when Method is Post or Patch

```yaml
Type: Object
Parameter Sets: (All)
Aliases:

Required: False
Position: 3
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentType
Custom Content Type

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 11
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GraphRequestSession
Custom Graph Request Session

```yaml
Type: GraphRequestSession
Parameter Sets: (All)
Aliases:

Required: False
Position: 17
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional Custom Headers

```yaml
Type: IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: 4
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InferOutputFileName
Infer output filename

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 6
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputFilePath
Input file to send in the request

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 7
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Method
HTTP Method

```yaml
Type: GraphRequestMethod
Parameter Sets: (All)
Aliases:
Accepted values: GET, POST, PUT, PATCH, DELETE

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutputFilePath
Output file where the response body will be saved

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 5
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OutputType
Output Type to return to the caller

```yaml
Type: OutputType
Parameter Sets: (All)
Aliases:
Accepted values: HashTable, PSObject, HttpResponseMessage, Json

Required: False
Position: 19
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Indicates that the cmdlet returns the results, in addition to writing them to a file.
Only valid when the OutFile parameter is also used.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 8
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

### -ResponseHeadersVariable
Response Headers Variable

```yaml
Type: String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: 14
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SessionVariable
Specifies a web request session.
Enter the variable name, including the dollar sign ($).You can't use the SessionVariable and GraphRequestSession parameters in the same command.

```yaml
Type: String
Parameter Sets: (All)
Aliases: SV

Required: False
Position: 13
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipHeaderValidation
Add headers to Request Header collection without validation

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 10
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipHttpErrorCheck
Skip Checking HTTP Errors

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 16
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StatusCodeVariable
Response Status Code Variable

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 15
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Uri
Uri to call can be segments such as /beta/me or fully qualified https://graph.microsoft.com/beta/me

```yaml
Type: Uri
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAgent
Custom User Specified User Agent

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: 18
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.Object
## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/invoke-mggraphrequest](https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/invoke-mggraphrequest)

