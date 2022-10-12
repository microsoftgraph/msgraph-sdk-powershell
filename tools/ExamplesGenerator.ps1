# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc")
)
function Get-GraphMapping {
    $graphMapping = @{}
    $graphMapping.Add("v1.0", "examples\v1.0")
    $graphMapping.Add("beta", "examples\v1.0-beta")
    return $graphMapping
}

function Start-Generator {
    Param(
        $ModulesToGenerate = @()
    )

    $GraphMapping = Get-GraphMapping 
    $GraphMapping.Keys | ForEach-Object {
        $graphProfile = $_
        Get-FilesByProfile -GraphProfile $graphProfile -GraphProfilePath $GraphMapping[$graphProfile] -ModulesToGenerate $ModulesToGenerate 
    }
}
function Get-FilesByProfile {
    Param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $GraphProfilePath = "examples\v1.0",
        [ValidateNotNullOrEmpty()]
        $ModulesToGenerate = @()
    )


    $ModulesToGenerate | ForEach-Object {
        $ModuleName = $_
        $modulePath = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\$GraphProfilePath"
        $OpenApiFile = Join-Path $PSScriptRoot "..\openApiDocs\v1.0\$ModuleName.yml"
        #test this path first before proceeding
        if (Test-Path $OpenApiFile) {
        $yamlContent = Get-Content -Path $OpenApiFile
        $OpenApiContent = ($yamlContent | ConvertFrom-Yaml)
        Get-Files -GraphProfile $GraphProfile -GraphProfilePath $modulePath -Module $ModuleName -OpenApiContent $OpenApiContent
        }
    }

}
function Get-Files {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0"),
        [ValidateNotNullOrEmpty()]
        [string] $Module = "Users",
        [Hashtable] $OpenApiContent 
    )
    $ModuleManifestFile = (Join-Path $PSScriptRoot "..\src\$Module\$Module\Microsoft.Graph.$Module.psd1")
    $ModuleManifestFileContent = Get-Content -Path $ModuleManifestFile

    try {
        if ((Test-Path $GraphProfilePath)) {
            
            foreach ($File in Get-ChildItem $GraphProfilePath) {
                #Extract command over here
                $Command = [System.IO.Path]::GetFileNameWithoutExtension($File)
                #Check for cmdlet existence from the module manifest file
                if ($ModuleManifestFileContent | Select-String -pattern $Command) {
                
                #Extract URI path
                $Uripaths = Find-MgGraphCommand -Command $Command
                $UriPath = $null
                if ($UriPaths.APIVersion.Contains($GraphProfile)) {
                    $UriPath = $UriPaths.URI[0].ToString()
                
                }
                if ($UriPath) {
                    if (-not $UriPath.Contains("microsoft.graph")) {
                        $val = $UriPath.split('/')
                        $len = $val.Length
                        $buildString = ""
                        for ($i = 0; $i -lt $len - 1; $i++) {
                            $buildString += $val[$i] + "/"
                        }
                        $UriPath = $buildString + "microsoft.graph." + $val[$len - 1]
                  
                    }

                    Get-ExternalDocs-Url -GraphProfile $GraphProfile -Url -UriPath $UriPath -Command $Command -OpenApiContent $OpenApiContent -GraphProfilePath $GraphProfilePath
                }
             }
                #Start-Sleep -Seconds 10
            }
        }
    }
    catch {
        Write-Host "`nError Message: " $_.Exception.Message
        Write-Host "`nError in Line: " $_.InvocationInfo.Line
        Write-Host "`nError in Line Number: "$_.InvocationInfo.ScriptLineNumber
        Write-Host "`nError Item Name: "$_.Exception.ItemName
    }
    
}
function Get-ExternalDocs-Url {

    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [string] $UriPath,
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [Hashtable] $OpenApiContent,
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0")
    )

    if ($UriPath) {
        if ($openApiContent.openapi && $openApiContent.info.version) {
            foreach ($path in $openApiContent.paths) {
                $externalDocUrl = $path[$UriPath].values.externalDocs.url

                if ($externalDocUrl) {
                    $url = $externalDocUrl.split(" ")
                    WebScrapping -GraphProfile $GraphProfile -ExternalDocUrl $url[0] -Command $Command -GraphProfilePath $GraphProfilePath
                }
            
            }

        }
    }

}
function WebScrapping {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [ValidateNotNullOrEmpty()]
        [string] $ExternalDocUrl = "https://learn.microsoft.com/en-us/graph/api/user-get?view=graph-rest-1.0&tabs=powershell",
        [ValidateNotNullOrEmpty()]
        [string] $Command = "Get-MgUser",
        [string] $GraphProfilePath = (Join-Path $PSScriptRoot "..\src\Users\Users\examples\v1.0")
    ) 
    $ExampleFile = "$GraphProfilePath/$Command.md"
    $url = $ExternalDocUrl
	
    $Description = "This example shows how to use the $Command Cmdlet.`r`n`r`To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference)."
    $WebResponse = Invoke-WebRequest -Uri $url
    $HeaderList = New-Object -TypeName 'System.Collections.ArrayList';
    $ExampleList = New-Object -TypeName 'System.Collections.ArrayList';
    $htmlDom = ConvertFrom-Html $WebResponse
    $nodes = $htmlDom.SelectNodes('//pre/code')
    $headers = $htmlDom.SelectNodes('//h3')
    foreach ($node in $nodes) {
        $checkPowershell = $node.OuterHtml
        
        if ($checkPowershell.Contains('lang-powershell')) {
            $result = $node.InnerHtml
            $result = $result.Replace('&quot;', '"')
            $ExampleList.Add($result)
        }
    }
    foreach ($header in $headers) {
        $checkPowershell = $header.OuterHtml
        
        if ($checkPowershell.Contains('Example')) {
            $result = $header.InnerHtml
            $HeaderList.Add($result)
        }
        
    }
  
    UpdateExampleFile -GraphProfile $GraphProfile -HeaderList $HeaderList -ExampleList $ExampleList -ExampleFile $ExampleFile -Description $Description
}

function UpdateExampleFile {
    param(
        [ValidateSet("beta", "v1.0")]
        [string] $GraphProfile = "v1.0",
        [System.Collections.ArrayList] $HeaderList,
        [System.Collections.ArrayList] $ExampleList,
        [string] $ExampleFile,
        [string] $Description
    ) 
    
    $Content = Get-Content -Path $ExampleFile
    $SearchText = "{{ Add description here }}"
    $ReplaceEverything = $False
    if ($HeaderList.Count -eq 0) {
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $HeaderList.Add("Example " + $sum + ": Code snippet".Trim())
        }
    }
    if ($HeaderList.Count -ne $ExampleList.Count) {
        $HeaderList.Clear()
        for ($d = 0; $d -lt $ExampleList.Count; $d++) {
            $sum = $d + 1
            $HeaderList.Add("Example " + $sum + ": Code snippet".Trim())
        }
    }
    if ($Content | Select-String -pattern $SearchText) {
        $ReplaceEverything = $True
        #Start-Sleep 5
       
    }

    $headCount = $HeaderList.Count
    $exampleCount = $ExampleList.Count
        
    if ($ReplaceEverything -and $exampleCount -gt 0 -and $headCount -eq $exampleCount) {
        Clear-Content $ExampleFile -Force
        for ($d = 0; $d -lt $headerList.Count; $d++) { 
            $codeValue = $exampleList[$d].Trim()
            $titleValue = "### " + $headerList[$d].Trim()
            $code = "``````powershell`r$codeValue`r`n``````"
	
            $totalText = "$titleValue`r`n`n$code`r`n$description`r`n"
            Add-Content -Path $ExampleFile -Value $totalText
        }
        git config --global user.email "timwamalwa@gmail.com"
        git config --global user.name "Timothy Wamalwa"
        git add $ExampleFile
        git commit -m "Examples update on  $ExampleFile-$GraphProfile" 
    }
    else {
        if ($headCount -ne $exampleCount) {
            Write-Host "Mismatch in Title and Snippet count i.e Title ="$headerList.Count " Snippet = "$exampleList.Count 
        }
        else {
            Write-Host "No examples found from the reference docs"
        }
            
        
    }
        
}
if (!(Get-Module "powershell-yaml" -ListAvailable -ErrorAction SilentlyContinue)) {
    Install-Module "powershell-yaml" -AcceptLicense -Scope CurrentUser -Force
}
if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
If (-not (Get-Module -ErrorAction Ignore -ListAvailable PowerHTML)) {
    Write-Verbose "Installing PowerHTML module for the current user..."
    Install-Module PowerHTML -ErrorAction Stop -Scope CurrentUser -Force
}
Import-Module -ErrorAction Stop PowerHTML

if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}
$date = Get-Date -Format "dd-MM-yyyy"
$proposedBranch = "WeeklyOpenApiDocsDownload/Examples_Update_"+$date
$exists = git branch -l $proposedBranch
if ([string]::IsNullOrEmpty($exists)) {
    git checkout -b $proposedBranch
}else{
	Write-Host "Branch already exists"
    $currentBranch = git rev-parse --abbrev-ref HEAD
    if($currentBranch -ne $proposedBranch){
        git checkout $proposedBranch
     }
     git checkout $proposedBranch
}

Start-Generator -ModulesToGenerate $ModulesToGenerate
Write-Host -ForegroundColor Green "-------------Done-------------"
