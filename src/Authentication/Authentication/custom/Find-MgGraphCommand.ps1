# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Set-StrictMode -Version 2

<#
.Synopsis
Find Microsoft Graph PowerShell command meta-info by URI or command name.
.Description
The Find-MgGraphCommand command retrieves meta-info about Microsoft Graph PowerShell commands by URI or command name.
.PARAMETER Uri
The API path a command calls. e.g., /users.
.PARAMETER Method
The HTTP method a command makes.
.PARAMETER ApiVersion
The service API version.
.PARAMETER Command
The name of a command. e.g., Get-MgUser.
.Example
PS C:\> Find-MgGraphCommand -Uri "/users/{id}"

   APIVersion: v1.0

Command       Module Method URI              OutputType           Permissions
-------       ------ ------ ---              ----------           -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser1 {DeviceManagementApps.Read.All DeviceManagementApps.Rea…
Remove-MgUser Users  DELETE /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…
Update-MgUser Users  PATCH  /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…

   APIVersion: beta

Command       Module Method URI              OutputType          Permissions
-------       ------ ------ ---              ----------          -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser {DeviceManagementApps.Read.All DeviceManagementApps.Read…
Remove-MgUser Users  DELETE /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…
Update-MgUser Users  PATCH  /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…

This example finds all commands that call the provided Microsoft Graph URI.
.Example
PS C:\> Find-MgGraphCommand -Command Send-MgUserMessage -ApiVersion beta

   APIVersion: beta

Command            Module        Method URI                                                         OutputType Permissions
-------            ------        ------ ---                                                         ---------- -----------
Send-MgUserMessage Users.Actions POST   /users/{user-id}/messages/{message-id}/microsoft.graph.send            {Mail.Send}

This example looks up a command with the provided command name that calls the beta version of the API.
.Inputs
Pipeline input accepts API URIs as an array of strings.
.Outputs
Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand with the following properties:
    1. Command: Name of command.
    2. Module: Module in which a command is defined.
    3. Method: The HTTP method a command makes.
    4. Uri: The Microsoft Graph API URI a command calls.
    5. OutputType: The return type of a command.
    6. Permissions: Permissions needed to use a command. This field can be empty if the permissions are not yet available in Graph Explorer.
    7. Variants: The parameter sets of a command.
#>
Function Find-MgGraphCommand {
    [CmdletBinding(DefaultParameterSetName = 'FindByUri', PositionalBinding = $false)]
    [OutputType([Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand])]
    param (
        [Parameter(ParameterSetName = "FindByUri", Mandatory = $true, Position = 0, ValueFromPipeline = $true)]
        [string[]]$Uri,

        [Parameter(ParameterSetName = "FindByUri")]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method,

        [Parameter(ParameterSetName = "FindByUri")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [ValidateSet("v1.0", "beta")]
        [Alias("Profile")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [ValidateNotNullorEmpty()]
        [string[]]$Command
    )

    begin {
        # Import utility scripts.
        . "$PSScriptRoot/common/GraphCommand.ps1" | Out-Null
        . "$PSScriptRoot/common/GraphUri.ps1" | Out-Null

        # Read content of metadata file and cache in session object.
        if ($null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance -and
            $null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata) {
            Write-Debug "Reading MgCommandMetadata from session object."
        }
        else {
            [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata = GraphCommand_ReadGraphCommandMetadata
        }
    }

    process {
        $Result = @()
        try {
            switch ($PSCmdlet.ParameterSetName) {
                "FindByUri" {
                    foreach ($u in $Uri) {
                        Write-Debug "Received URI: $u."
                        $GraphUri = GraphUri_ConvertStringToUri $u

                        # Use API version in URI if -ApiVersion is not provided.
                        if ([System.String]::IsNullOrWhiteSpace($ApiVersion) -and ($GraphUri.OriginalString -match "(v1.0|beta)\/")) {
                            $ApiVersion = $Matches[1]
                        }

                        if (!$GraphUri.IsAbsoluteUri) {
                            $GraphUri = GraphUri_ConvertRelativeUriToAbsoluteUri -Uri $GraphUri -ApiVersion $ApiVersion
                        }
                        Write-Debug "Resolved URI: $GraphUri."

                        $TokenizedUri = GraphUri_TokenizeIds $GraphUri
                        Write-Debug "Tokenized URI: $TokenizedUri."

                        $ResourceSegmentRegex = GraphUri_GetResourceSegmentRegex $TokenizedUri
                        Write-Debug "Matching URI: $ResourceSegmentRegex"
                        Write-Debug "Matching Method: $Method"
                        Write-Debug "Matching ApiVersion: $ApiVersion"
                        [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                            if ($_.Method -match $Method -and
                                $_.ApiVersion -match $ApiVersion -and
                                $_.Uri -match $ResourceSegmentRegex) {
                                $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
                            }
                        }
                        if ($Result.Count -lt 1) {
                            Write-Error "URI '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Ensure the URI is formated correctly and try again."
                        }
                    }
                }
                "FindByCommand" {
                    foreach ($c in $Command) {
                        Write-Debug "Matching Command: $c"
                        Write-Debug "Matching ApiVersion: $ApiVersion"
                        [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                            if ($_.ApiVersion -match $ApiVersion -and
                                $_.Command -match "^$c$") {
                                $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
                            }
                        }
                        if ($Result.Count -lt 1) {
                            Write-Error "'$c' is not a valid Microsoft Graph PowerShell command. Please check the name and try again."
                        }
                    }
                }
            }
        }
        catch {
            Write-Error $_.Exception
        }

        return $Result | Sort-Object @{Expression = "APIVersion"; Descending = $True }, @{Expression = "Command"; Descending = $False }
    }
}