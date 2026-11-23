# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

BeforeAll {
    $toolsSource = Split-Path $PSScriptRoot -Parent
}

Describe 'Authentication preview switch forwarding' {
    BeforeEach {
        $toolsPath = Join-Path $TestDrive 'tools'
        $modulePath = Join-Path $TestDrive 'src\Authentication\Authentication'
        $configPath = Join-Path $TestDrive 'config'
        New-Item -ItemType Directory -Force -Path $toolsPath, $modulePath, $configPath | Out-Null
        Copy-Item (Join-Path $toolsSource 'GenerateAuthenticationModule.ps1') $toolsPath
        Copy-Item (Join-Path $toolsSource 'BuildModule.ps1') $toolsPath

        @'
function Set-CSProjValues { }
'@ | Set-Content (Join-Path $toolsPath 'CSProjHelper.ps1')
        @'
function Set-NuSpecValues { }
'@ | Set-Content (Join-Path $toolsPath 'NuspecHelper.ps1')
        foreach ($scriptName in @('PackModule.ps1', 'PublishModule.ps1', 'TestModule.ps1')) {
            Set-Content (Join-Path $toolsPath $scriptName) ''
        }
        Set-Content (Join-Path $modulePath 'run-module.ps1') ''
        @'
param([switch] $OneAuthPreview, [switch] $Release)
@{
    OneAuthPreview = [bool]$OneAuthPreview
    Release = [bool]$Release
} | ConvertTo-Json | Set-Content (Join-Path $PSScriptRoot 'build-arguments.json')
'@ | Set-Content (Join-Path $modulePath 'build-module.ps1')
        @'
{
  "copyright": "Microsoft",
  "iconUri": "https://example.com/icon.png",
  "releaseNotes": "Test",
  "versions": { "authentication": { "version": "1.0.0", "prerelease": "" } }
}
'@ | Set-Content (Join-Path $configPath 'ModuleMetadata.json')

        Mock Find-Module {
            @{ AdditionalMetadata = @{ GUID = '11111111-1111-1111-1111-111111111111' } }
        }
        Mock Update-ModuleManifest { }
        Mock dotnet { }
    }

    It 'forwards preview=<Preview> through the <Action> build chain' -ForEach @(
        @{ Action = 'Build'; Preview = $true }
        @{ Action = 'Build'; Preview = $false }
        @{ Action = 'Run'; Preview = $true }
        @{ Action = 'Run'; Preview = $false }
    ) {
        $parameters = @{ $Action = $true; OneAuthPreview = $Preview }

        & (Join-Path $toolsPath 'GenerateAuthenticationModule.ps1') @parameters

        $arguments = Get-Content (Join-Path $modulePath 'build-arguments.json') -Raw | ConvertFrom-Json
        $arguments.OneAuthPreview | Should -Be $Preview
        $arguments.Release | Should -BeTrue
    }

    It 'preserves preview=<Preview> for dotnet tests' -ForEach @(
        @{ Preview = $true }
        @{ Preview = $false }
    ) {
        & (Join-Path $toolsPath 'GenerateAuthenticationModule.ps1') -Test -OneAuthPreview:$Preview

        if ($Preview) {
            Should -Invoke dotnet -Exactly -Times 1 -ParameterFilter {
                $args -contains '-p:EnableOneAuthPreview=true'
            }
        }
        else {
            Should -Invoke dotnet -Exactly -Times 1 -ParameterFilter {
                $args -notcontains '-p:EnableOneAuthPreview=true'
            }
        }
    }
}
