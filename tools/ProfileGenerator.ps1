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

    $apiList = Get-ChildItem -Path $OpenApiDocsDirectory
    $specs = @()
    $foundMultipleAPIs = $false
    if ($apiList.Count -gt 1) {
        $foundMultipleAPIs = $true
    }
    foreach ($api in $apiList) {
        # $apiVersion = $api.Name
        $openApiDocs = Get-ChildItem -File -Filter "*.yml" -Path $api.FullName
        Write-Host "Parsing openAPI docs..." -ForegroundColor Green
        $openApiDocs = $openApiDocs[1]
        foreach ($openApiDoc in $openApiDocs){
            # get paths
            $allPaths = @()
            $moduleName = $openApiDoc.BaseName
            $openApiContent = Get-Content -Path $openApiDoc.FullName | ConvertFrom-Yaml
            if ($openApiContent.openapi && $openApiContent.info.version){
                $apiVersion = $openApiContent.info.version
                # Get sovreign cloud.
                $profileName = $apiVersion

                # Get paths.
                foreach ($path in $openApiContent.paths.keys) {
                    $allPaths += @{endpoint= $path; apiVersion = $apiVersion; originalLocation = ($openApiDoc.FullName | Resolve-Path -Relative) -replace "^.\\|\\", "/"}
                }
                # Get crawl data.
                Write-Host "Crawling paths for resources and operations for $moduleName ..." -ForegroundColor Green
                $crawlResult = @{resources= @(); operations = @{}}
                foreach ($path in $allPaths) {
                    $crawlResult.operations[$path.endpoint] = (@{apiVersion = $path.apiVersion; originalLocation = $path.originalLocation})
                }

                $ModuleProfilesDirectory = "$ProfilesDirectory/$moduleName"
                if(!(Test-Path -Path $ModuleProfilesDirectory)){
                    New-Item -Path $ModuleProfilesDirectory -ItemType Directory
                }
                $telemetryDir = Join-Path $ModuleProfilesDirectory "crawl-log-$profileName.json"
                Set-Content -Path $telemetryDir -Value ($crawlResult | ConvertTo-Json)

                # Get profile.
                $profile = @{resources = @{}; operations = @{}}
                foreach ($operation in $crawlResult.operations.keys) {
                    $profile.operations[$operation] = $crawlResult.operations[$operation].apiVersion
                }
                Write-Host ($profile | ConvertTo-Json)
                $profileReadMeContent = @" 
# Microsoft Graph $profileName Profile
``````` yaml
$($profile | ConvertTo-Yaml)
``````` 
"@
                $telemetryDir = Join-Path $ModuleProfilesDirectory "readme.md"
                Set-Content -Path $telemetryDir -Value $profileReadMeContent
            }
        }
    }
}
catch {
    Write-Error "Failed to generate profile."
    Write-Error $_
}