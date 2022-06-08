# Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
<#
    Copy file contents to destination.
#>
Function Copy-ModuleTemplate
{
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $Destination,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $TemplatePath,
        [Parameter(Mandatory = $true)]
        [ValidateNotNullOrEmpty()]
        [string] $ModuleName
    )
    if (-not (Test-Path $Destination)) {
        # Copy AutoRest config from templates if not found.
        New-Item -Path ([System.IO.Directory]::GetParent($Destination)) -Type Directory -Force | Out-Null
        $TemplateContent = Get-Content $TemplatePath -Raw
        New-Item -Path $Destination -Type File -Value $TemplateContent.Replace("{ModuleName}", $ModuleName) | Out-Null
    }
}