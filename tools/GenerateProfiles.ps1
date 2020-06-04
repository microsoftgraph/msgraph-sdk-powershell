Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $OpenApiDocsDirectory,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ProfilesDirectory
)
try {
    # Install dependencies.
    if (!(Get-Module "powershell-yaml" -ListAvailable -ErrorAction SilentlyContinue)){
        Install-Module "powershell-yaml"
    }

    if(!(Test-Path -Path $OpenApiDocsDirectory)){
        New-Item -Path $OpenApiDocsDirectory -ItemType Directory
    }

    if(!(Test-Path -Path $ProfilesDirectory)){
        New-Item -Path $ProfilesDirectory -ItemType Directory
    }
    $GetNationalCloudPS1 = Join-Path $PSScriptRoot ".\GetNationalCloud.ps1" -Resolve

    $openApiFiles = @{}
    foreach ($api in (Get-ChildItem -Path $OpenApiDocsDirectory)) {
        $openApiDocs = Get-ChildItem -File -Filter "*.yml" -Path $api.FullName
        Write-Host "Parsing $($api.Name) openAPI docs..." -ForegroundColor Yellow
        foreach ($openApiDoc in $openApiDocs){
            $allPaths = @()
            $moduleName = $openApiDoc.BaseName
            $openApiRelativePath = ($openApiDoc.FullName | Resolve-Path -Relative) -replace "^.\\|\\", "/"
            $openApiFiles[$moduleName] += @('$(this-folder)../..'+ $openApiRelativePath)
            # Create required directories.
            $ModuleProfilesDirectory = "$ProfilesDirectory/$moduleName"
            if(!(Test-Path -Path $ModuleProfilesDirectory)){
                New-Item -Path $ModuleProfilesDirectory -ItemType Directory
            }

            $ModuleProfilesDefinitionsDirectory = "$ModuleProfilesDirectory/definitions"
            if(!(Test-Path -Path $ModuleProfilesDefinitionsDirectory)){
                New-Item -Path $ModuleProfilesDefinitionsDirectory -ItemType Directory
            }

            $openApiContent = Get-Content -Path $openApiDoc.FullName | ConvertFrom-Yaml
            if ($openApiContent.openapi && $openApiContent.info.version){
                $apiVersion = $openApiContent.info.version
                # Get national cloud profile.
                $profileName = & $GetNationalCloudPS1 -apiVersion $apiVersion -serverUrl $openApiContent.servers.url

                # Get paths.
                foreach ($path in $openApiContent.paths.keys) {
                    $allPaths += @{endpoint= $path; apiVersion = $apiVersion; originalLocation = $openApiRelativePath}
                }
                # Get crawl data.
                Write-Host "Crawling '$moduleName' paths for resources and operations ..." -ForegroundColor Green
                $crawlResult = @{resources= @(); operations = @{}}
                foreach ($path in $allPaths) {
                    $crawlResult.operations[$path.endpoint] = (@{apiVersion = $path.apiVersion; originalLocation = $path.originalLocation})
                }
                $telemetryDir = Join-Path $ModuleProfilesDirectory "crawl-log-$profileName.json"
                Set-Content -Path $telemetryDir -Value ($crawlResult | ConvertTo-Json)
                Write-Host "Telemetry written at $telemetryDir" -ForegroundColor Blue

                # Get profile.
                $profile =  @{resources = @{}; operations = @{}}
                foreach ($operation in $crawlResult.operations.keys) {
                    $profile.operations[$operation] = $crawlResult.operations[$operation].apiVersion
                }
                $profilesNode = @{profiles = @{ $profileName = $profile}}
                $profilesInYaml = $profilesNode | ConvertTo-Yaml
                $profileReadMeContent = @"
# Microsoft Graph $profileName Profile

> see https://aka.ms/autorest

``````` yaml
$profilesInYaml
```````
"@
                $profileReadMeDir = Join-Path $ModuleProfilesDefinitionsDirectory "$profileName.md"
                Set-Content -Path $profileReadMeDir -Value $profileReadMeContent
                Write-Host "Profile '$profileName' written at $profileReadMeDir" -ForegroundColor Blue
            }
        }
    }

    # Get all profile defintions of a module and generate a single readme.
    foreach ($moduleItem in (Get-ChildItem $ProfilesDirectory)) {
        $definitionsRelativePaths = @{ require = @()}
        foreach ($moduleDefinition in (Get-ChildItem -Filter *.md -Path "$($moduleItem.FullName)/definitions")) {
            $definitionsRelativePaths.require += '$(this-folder)/definitions/'+ $moduleDefinition.Name
        }
        $definitionsRelativePathsAsYaml = ($definitionsRelativePaths | ConvertTo-Yaml)

        $inputFiles = @{}
        $inputFiles["input-file"] = $openApiFiles[$moduleItem.Name]

        $moduleReadMeContent = @"
# Microsoft Graph $($moduleItem.Name) Profiles

> see https://aka.ms/autorest

> The files under this directory are the profile definitions used by autorest.

``````` yaml
$definitionsRelativePathsAsYaml
```````

## Multi-API/Profile support for AutoRest v3 generators

AutoRest V3 generators require the use of `--tag=all-api-versions` to select api files.

This block is updated by an automatic script. Edits may be lost!

``````` yaml `$(tag) == 'all-api-versions' /* autogenerated */
$($inputFiles | ConvertTo-Yaml)
```````
"@
        $moduleReadMeDir = Join-Path $moduleItem.FullName "readme.md"
        Set-Content -Path $moduleReadMeDir -Value $moduleReadMeContent
        Write-Host "Regenerated profiles readme.md at $moduleReadMeDir" -ForegroundColor Yellow
    }
}
catch {
    Write-Error "Failed to generate profile."
    Write-Error $_
}