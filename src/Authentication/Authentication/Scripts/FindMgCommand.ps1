# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding(DefaultParameterSetName = "FindByUrl")]
Param(
    [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
    [string]
    $Url,

    [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
    [string]
    $Method,

    [Parameter(ParameterSetName = "FindByUrl")]
    [Parameter(ParameterSetName = "FindByCommand")]
    [Alias('Profile')]
    [string] $ApiVersion = "v1.0",

    [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
    [string] $Command
)
$MgCommandMetadataPath = ".\artifacts\MgCommandMetadata.json"
$MgCommandMetadata = Get-Content -Path $MgCommandMetadataPath | ConvertFrom-Json -AsHashtable
$CommandMatch = [System.Collections.ArrayList]@()

if ($PSCmdlet.ParameterSetName -eq "FindByUrl") {
    if ($Url -match "https:\/\/graph.microsoft.com\/(v1.0|beta)(\/.*)(\?(.*))?") {
        $ApiVersion = $matches[1]
        $ResourceSegement = $matches[2]
        # TODO: Handle query parameters.
        $QueryParameters = $matches[3]
        $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '.*')$"
    }
    else {
        Write-Error "The provided URL doesn't match the expected URL format. Please ensure that the URL is formated as https://graph.microsoft.com/{api-version}/{resource}."
    }
    Write-Host "REGEX: $RegexResourceSegement" -ForegroundColor yellow

    $MgCommandMetadata.GetEnumerator() | ForEach-Object {
        $CommandPath = $_.Value
        if ($CommandPath.Method -eq $Method -and
            $CommandPath.ApiVersion -eq $ApiVersion -and
            $CommandPath.Url -match $RegexResourceSegement) {
            $null = $CommandMatch.Add($CommandPath)
        }
    }
}
else {
    $MgCommandMetadata.GetEnumerator() | ForEach-Object {
        $CommandPath = $_.Value
        if ($CommandPath.ApiVersion -eq $ApiVersion -and
            $CommandPath.Command -eq $Command) {
            $null = $CommandMatch.Add($CommandPath)
        }
    }
}

if ($CommandMatch.Count -ge 1) {
    Write-Host "Command: $($CommandMatch[0].Command)" -ForegroundColor green
    Write-Host "Module: Microsoft.Graph.$($CommandMatch[0].Module)" -ForegroundColor green
    Write-Host "Profile: $($CommandMatch[0].ApiVersion)" -ForegroundColor green
    Write-Host "Returns: $($CommandMatch[0].OutputType)" -ForegroundColor green
    Write-Host "Url: $($CommandMatch[0].Url)" -ForegroundColor green
}
else {
    Write-Warning "Command not found!"
}