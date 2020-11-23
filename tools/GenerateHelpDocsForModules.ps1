# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

    param (
        [string] $ModuleMappingConfigPath =(Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
        [string] $RepositoryName = "PSGallery",
        [switch] $AllowPreRelease
    )
 
    process {
        [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashtable

        $ModuleMapping.Keys | ForEach-Object -ThrottleLimit $ModuleMapping.Keys.Count -Parallel {
            $ModuleName = $_
            $ExistingWorkloadModule = Find-Module "Microsoft.Graph.$ModuleName" -Repository $Using:RepositoryName -AllowPrerelease:$Using:AllowPreRelease
            Write-Warning "$ModuleName $ExistingWorkloadModule.Name"
            Uninstall-Module $ExistingWorkloadModule.Name -Force -AllVersions -ErrorAction Continue
            Remove-Module $ExistingWorkloadModule.Name -Force -ErrorAction Continue
            Install-Module $ExistingWorkloadModule.Name -Repository $Using:RepositoryName -Force -AllowClobber -AllowPrerelease:$Using:AllowPreRelease -Scope CurrentUser
            Import-Module $ExistingWorkloadModule.Name -Force -Scope Global
            $profiles = Get-MgProfile -ListAvailable -Module $ExistingWorkloadModule.Name
            $ExistingWorkloadModuleHelpPath = ".\src\$ModuleName\$ModuleName\help"
            foreach ($item in $profiles) {
                Write-Warning "Module:$ModuleName Profile:$item.Name $item.Description"
                Select-MgProfile -Name $item.Name
                Import-Module $ExistingWorkloadModule.Name -Force -Scope Global
                if (-not (Test-Path (Join-Path $ExistingWorkloadModuleHelpPath "*"))) {
                    New-Item -Path $ExistingWorkloadModuleHelpPath -Type Directory -Force
                    $parameters = @{
                        Module                = $ExistingWorkloadModule.Name
                        OutputFolder          = $ExistingWorkloadModuleHelpPath
                        AlphabeticParamsOrder = $true
                        WithModulePage        = $true
                        ExcludeDontShow       = $true
                    }
                    New-MarkdownHelp @parameters
                    New-MarkdownAboutHelp -OutputFolder $ExistingWorkloadModuleHelpPath -AboutName $ExistingWorkloadModule.Name
                }
                else {
                    $logFile = $ExistingWorkloadModule.Name
                    $logsPath = Join-Path $Using:PSScriptRoot "..\logs" $GraphProfile "$logFile.txt"
                    $parameters = @{
                        Path                  = $ExistingWorkloadModuleHelpPath
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
}