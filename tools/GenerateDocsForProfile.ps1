# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

    param (
        [string] $GraphProfile = "beta",
        [string] $ModuleMappingConfigPath,
        [string] $RepositoryName = "PSGallery",
        [switch] $AllowPreRelease,
        [string] $OutputFolder
    )
 
    process {
        Select-MgProfile -Name $GraphProfile
        [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashtable

        $ModuleMapping.Keys | ForEach-Object {
            $ModuleName = $_
            $ExistingWorkloadModule = Find-Module "Microsoft.Graph.$ModuleName"-Repository $RepositoryName -AllowPrerelease:$AllowPreRelease
            Write-Warning "$ModuleName $ExistingWorkloadModule"
            Uninstall-Module $ExistingWorkloadModule.Name -Force -AllVersions
            Install-Module $ExistingWorkloadModule.Name -Repository $RepositoryName -Force -AllowClobber -AllowPrerelease:$AllowPreRelease -Scope CurrentUser
            Import-Module $ExistingWorkloadModule.Name -Force -Scope Local
            $ExistingWorkloadModulePath = Join-Path $OutputFolder $GraphProfile $ExistingWorkloadModule.Name
            if (-not (Test-Path (Join-Path $ExistingWorkloadModulePath "*"))) {
                New-Item -Path $ExistingWorkloadModulePath -Type Directory -Force
                $parameters = @{
                    Module                = $ExistingWorkloadModule.Name
                    OutputFolder          = $ExistingWorkloadModulePath
                    AlphabeticParamsOrder = $true
                    WithModulePage        = $true
                    ExcludeDontShow       = $true
                }
                New-MarkdownHelp @parameters
                New-MarkdownAboutHelp -OutputFolder $ExistingWorkloadModulePath -AboutName $ExistingWorkloadModule.Name
            }
            else {
                $logFile = $ExistingWorkloadModule.Name
                $logsPath = Join-Path $PSScriptRoot "..\logs" $GraphProfile "$logFile.txt"
                $parameters = @{
                    Path                  = $ExistingWorkloadModulePath
                    RefreshModulePage     = $true
                    AlphabeticParamsOrder = $true
                    UpdateInputOutput     = $true
                    ExcludeDontShow       = $true
                    LogPath               = $logsPath
                }
                Update-MarkdownHelpModule @parameters
            }
        }
    }
    